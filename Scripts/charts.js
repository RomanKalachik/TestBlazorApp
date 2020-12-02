import { ensureElement, getCurrentStyle, calculateStyles, changeDom, elementHasCssClass, toggleCssClass } from "./dom-utils";
import { attachEventToElement } from "./event-utils";
import { parseTranslateInfo, translatePosition } from "./popup-utils";

class ChartData {
    constructor(domElement, widget) {
        this.widget = widget;
        this.chartElement = ChartData.getChartElement(domElement);
    }
    static getChartElement(domElement) {
        return domElement.querySelector(".dx-chart");
    }
}
const activeCharts = new Map();
function disposeWidget(domEl, disposeDomEl) {
    domEl = ensureElement(domEl);
    const chartData = activeCharts.get(domEl);
    if(chartData !== undefined) {
        chartData.chartElement = null;
        chartData.widget = null;
        if(disposeDomEl)
            activeCharts.delete(domEl);
    }
    return Promise.resolve("ok");
}
function findRelatedWidget(domEl) {
    const chartData = activeCharts.get(domEl);
    return chartData === undefined ? Promise.reject() : chartData.widget;
}
function updateRelatedWidget(domEl, settings, setupFunc) {
    const chartData = activeCharts.get(domEl);
    if(chartData === undefined || chartData.chartElement !== ChartData.getChartElement(domEl)) {
        const widgetReady = createRelatedWidget(domEl, settings, setupFunc);
        activeCharts.set(domEl, new ChartData(domEl, widgetReady));
        return widgetReady;
    }
    return chartData.widget.then(function(chart) {
        return new Promise(function(resolve) {
            function updateChart(options) {
                options.animation = { enabled: false };
                chart.option(options);
                resolve("ok");
            }
            setupFunc(settings, updateChart);
        });
    }).catch(window.console.error);
}
export function createWidgetBuilder(DxBlazorViz, hostElement, state, callback) {
    const category = state.series.map(x => x.category)[0];
    const widgetClass = category === "pie" || category === "donut" ? DxBlazorViz.viz.dxPieChart : DxBlazorViz.viz.dxChart;
    return function builder(options) {
        options.type = category;
        // eslint-disable-next-line new-cap
        callback(new widgetClass(hostElement, options));
    };
}
function createRelatedWidget(domEl, state, setupFunc) {
    const widgetReady = new Promise(function(resolve) {
        import("devexpress.viz").then(function(DxBlazorViz) {
            const widgetBuilder = createWidgetBuilder(DxBlazorViz, ChartData.getChartElement(domEl), state, resolve);
            setupFunc(state, widgetBuilder);
        });
    });
    return widgetReady;
}
function proceedWithPalette(opt, initFunc) {
    if(opt.palette) return initFunc(opt.palette);

    const defaultColorClasses = ["bg-primary", "bg-success", "bg-danger", "bg-warning", "bg-info", "bg-secondary"];
    const container = document.createElement("DIV");
    container.className = "d-none position-absolute";
    for(let i = 0; i < defaultColorClasses.length; i++) {
        const colorContainer = document.createElement("DIV");
        colorContainer.className = defaultColorClasses[i];
        container.appendChild(colorContainer);
    }
    changeDom(function() {
        document.body.appendChild(container);
        calculateStyles(function() {
            const bsPalette = [];
            for(let i = 0; i < container.childNodes.length; i++)
                bsPalette.push(getCurrentStyle(container.childNodes[i]).backgroundColor);
            changeDom(function() {
                document.body.removeChild(container);
                initFunc(bsPalette);
            });
        });
    });
}
function attachEventToLegendItem(el, chart, seriesIndex, pointId, evtNames, seriesAction) {
    evtNames.forEach(function(evtName) {
        attachEventToElement(el, evtName, function(e) {
            const target = getLegendItemTarget(chart, seriesIndex, pointId);
            if(target)
                seriesAction(target);
        });
    });
}
function ensureSeriesLegendColor(mainElement, chart) {
    const legendElements = mainElement.querySelectorAll(".dx-chart-legend-item");
    for(let i = 0; i < legendElements.length; i++) {
        const legendElement = legendElements[i];
        const seriesIndex = +legendElement.getAttribute("data-series");
        const pointId = legendElement.getAttribute("data-point");
        syncLegendItemAndSeries(legendElement, chart, seriesIndex, pointId, true);
    }
}
function getLegendItemTarget(chart, seriesIndex, pointId) {
    let target = chart.getSeriesByPos(seriesIndex);
    if(pointId)
        target = target.getPoints().filter(function(p) { return p.tag === pointId; })[0];
    return target;
}
function syncLegendItemAndSeries(legendEl, chart, seriesIndex, pointId, skipAttachEvents) {
    if(!legendEl) return;
    const target = getLegendItemTarget(chart, seriesIndex, pointId);
    if(!target) return;

    const iconEl = legendEl.querySelector(".dx-chart-legend-icon");
    if(iconEl) {
        const color = target.getColor();
        if(elementHasCssClass(iconEl, "dx-chart-def-icon"))
            iconEl.style.backgroundColor = color;
        iconEl.style.color = color;
    }
    if(skipAttachEvents) return;

    attachEventToLegendItem(legendEl, chart, seriesIndex, pointId, ["mouseover", "focusin"], function(t) { t.hover(chart.option("legend.hoverMode")); });
    attachEventToLegendItem(legendEl, chart, seriesIndex, pointId, ["mouseout", "focusout"], function(t) { t.clearHover(); });
}
function createTooltipContentPlaceholderHTML(elementRef, tag) {
    return calculateStyles(function() {
        const box = elementRef.getBoundingClientRect();
        return `<div id="_${tag}" class="dx-chart-tooltip-wrapper" style="width: ${box.width}px; height: ${box.height}px;"></div>`;
    });
}
function setupTooltip(options, dotnetHelper) {
    let currentPointTag = null;
    let shownPointTag = null;
    let element = null;
    const placeholderCache = {};
    const contentCache = {};
    let timerId = -1;
    let currentPoint = null;

    function fetchContent(point, showTooltip) {
        const tag = point.tag;
        clearTimeout(timerId);
        timerId = setTimeout(function() {
            currentPointTag = tag;
            dotnetHelper.invokeMethodAsync("GetTooltipTemplate", [tag])
                .then(function(elementRef) {
                    elementRef = ensureElement(elementRef);
                    contentCache[tag] = elementRef;
                    return createTooltipContentPlaceholderHTML(elementRef, tag);
                })
                .then(function(html) {
                    placeholderCache[tag] = html;
                    if(currentPointTag === tag) {
                        currentPoint = point;
                        showTooltip();
                    }
                })
                .catch(function(e) { window.console.error(e); });
        }, 100);
    }
    function onTooltipHidden(e) {
        hideBlazorTooltip();
    }

    function hideBlazorTooltip(e) {
        shownPointTag = null;
        if(element) {
            (function(_) {
                import("./popup-utils").then(function(p) { p.hide(_); });
            })(element);
            element = null;
        }
    }

    function onTooltipShown(e) {
        hideBlazorTooltip();
        let point = e.target;
        if(!point) {
            point = currentPoint;
            if(!point)
                return;
            currentPoint = null;
        }
        const tag = point.tag;
        if(placeholderCache[tag]) {
            shownPointTag = tag;
            import("./popup-utils").then(function(p) {
                if(shownPointTag === tag) {
                    element = contentCache[tag];
                    p.show(element, document.getElementById("_" + tag), "top-sides left-sides");
                }
            });
        }
    }
    function getPointRender(e) {
        if(!placeholderCache[e.point.tag]) {
            fetchContent(e.point, function() { e.point.showTooltip(); });
            return { text: "" };
        }
        else
            return { html: placeholderCache[e.point.tag] };
    }
    options.tooltip = { enabled: true, paddingLeftRight: 0, paddingTopBottom: 0, customizeTooltip: getPointRender };
    options.onTooltipHidden = onTooltipHidden;
    options.onTooltipShown = onTooltipShown;
}
function getValueAxisByPane(chart, pane) {
    return chart._valueAxes.filter(function(va) { return va.pane === pane.name; })[0];
}
function adjustLegend(mainElement, chart) {
    if(!chart.panes || chart.panes.filter(function(p) { return p.name !== "default"; }).length === 0)
        return;

    function translateY(style, offset) {
        changeDom(function() { translatePosition(style, 0, offset); });
    }
    function translatePaneParts(paneLegendElementStyle, axisGroupElementStyle, axisGridElementStyle, legendOffset, paneOffset) {
        translateY(paneLegendElementStyle, legendOffset);
        paneLegendElementStyle.marginTop = "-" + paneOffset + "px";
        translateY(axisGroupElementStyle, -paneOffset);
        translateY(axisGridElementStyle, -paneOffset);
    }
    calculateStyles(function() {
        let chartMarginTop = 0;
        const defaultSpacing = 10;
        for(let i = chart.panes.length - 2; i >= 0; i--) {
            const pane = chart.panes[i];
            const paneLegendElement = mainElement.querySelector(".dx-chart-legend[data-pane='" + pane.name + "']");
            if(paneLegendElement) {
                const paneOffset = paneLegendElement.offsetHeight + chartMarginTop;
                const valueAxis = getValueAxisByPane(chart, pane);
                const axisGroupElement = valueAxis._axisGroup.element;
                const axisGridElement = valueAxis._axisGridGroup.element;
                const gridBottom = axisGridElement.getBoundingClientRect().bottom + defaultSpacing;
                const existingTransform = parseTranslateInfo(paneLegendElement.style);
                const legendTop = paneLegendElement.getBoundingClientRect().top - existingTransform.top;

                chart.series.filter(function(s) { return s.pane === pane.name; }).forEach(function(series) {
                    translateY(series._group.element.style, -paneOffset);
                });
                translatePaneParts(paneLegendElement.style, axisGroupElement.style, axisGridElement.style, gridBottom - legendTop, paneOffset);
                chartMarginTop += paneOffset;
            }
        }
        changeDom(function() {
            chart.option("margin", { top: chartMarginTop });
        });
    });
}
function init(mainElement, opt, dotnetHelper) {
    return updateRelatedWidget(mainElement, opt, function(opt, widgetBuilder) {
        proceedWithPalette(opt, function(palette) {
            let isDrawn = false;
            function ensureInitialized(sender) {
                if(!isDrawn) {
                    isDrawn = true;
                    ensureSeriesLegendColor(mainElement, sender.component);
                    adjustLegend(mainElement, sender.component);
                    toggleCssClass(mainElement, "dx-loading", false);
                }
            }
            const options = {
                tooltip: opt.tooltip,
                dataSource: opt.dataSource,
                palette: palette,
                rotated: opt.rotated,
                resolveLabelOverlapping: opt.labelOverlap,
                size: opt.size,
                commonAxisSettings: {
                    label: {
                        overlappingBehavior: "rotate",
                        rotationAngle: 45
                    }
                },
                dataPrepareSettings: {
                    sortingMethod: false
                },
                commonSeriesSettings: {
                    argumentField: "argument",
                    valueField: "value",
                    openValueField: "openValue",
                    highValueField: "highValue",
                    lowValueField: "lowValue",
                    closeValueField: "closeValue",
                    rangeValue1Field: "startValue",
                    rangeValue2Field: "endValue",
                    sizeField: "size",
                    type: "bar"
                },
                adaptiveLayout: { width: 0, height: 0 },
                seriesTemplate: {
                    nameField: "seriesId",
                    customizeSeries: function(valueFromNameField) {
                        return opt.series.filter(function(s) { return s.seriesId === valueFromNameField; })[0];
                    }
                },
                customizeLabel: function(point) { return point.data.pointLabel; },
                customizePoint: function(point) { return point.data.pointAppearance; },
                legend: { visible: false, hoverMode: (opt.legend ? opt.legend.hoverMode : null) || "includepoints" },
                onDrawn: ensureInitialized,
                valueAxis: opt.valueAxis,
                panes: opt.panes,
                argumentAxis: opt.argumentAxis,
                pathModified: true
            };
            if(opt.hasTooltipCustomization)
                setupTooltip(options, dotnetHelper);
            else
                options.tooltip = opt.tooltip;
            widgetBuilder(options);
        });
    })
        .then(function() { return Promise.resolve("ok"); })
        .catch(function(r) { window.console.error(r); });
}
function onSeriesLegendElementReceived(mainElement, seriesIndex, pointId, legendItemElement) {
    return findRelatedWidget(mainElement).then(function(chart) {
        syncLegendItemAndSeries(legendItemElement, chart, seriesIndex, pointId);
        return Promise.resolve();
    }).catch(function(r) {
        window.console.error(r);
    });
}
function onSeriesVisibleChanged(mainElement, seriesIndex, pointId, visible) {
    return findRelatedWidget(mainElement).then(function(chart) {
        const target = getLegendItemTarget(chart, seriesIndex, pointId);
        if(visible)
            target.show();
        else
            target.hide();
        return Promise.resolve();
    }).catch(function(r) {
        window.console.error(r);
    });
}
function dispose(mainElement) {
    mainElement = ensureElement(mainElement);

    if(!mainElement) return;
    return disposeWidget(mainElement, true);
}
function destroyTooltips() {
    return new Promise(function(resolve, _) {
        const liveTooltipElements = Array.prototype.slice.call(document.querySelectorAll(".dxc-tooltip"));
        for(let i = 0; i < liveTooltipElements.length; i++) {
            const el = liveTooltipElements[i];
            el.parentNode.removeChild(el);
        }
        resolve(true);
    });
}

export default { init, dispose, onSeriesLegendElementReceived, onSeriesVisibleChanged, destroyTooltips };

import { ensureElement, toggleCssClass } from "./dom-utils";

class FunnelData {
    constructor(domElement, widget) {
        this.widget = widget;
        this.chartElement = FunnelData.getChartElement(domElement);
    }
    static getChartElement(domElement) {
        return domElement.querySelector(".dx-funnel");
    }
}
function disposeWidget(domEl, disposeDomEl) {
    domEl = ensureElement(domEl);
    const chartData = activeCharts.get(domEl);
    if (chartData !== undefined) {
        chartData.chartElement = null;
        chartData.widget = null;
        if (disposeDomEl)
            activeCharts.delete(domEl);
    }
    return Promise.resolve("ok");
}

export function createWidgetBuilder(DxBlazorViz, hostElement, state, callback) {
    const widgetClass = DxBlazorViz.viz.dxFunnel;
    return function builder(options) {
        callback(new widgetClass(hostElement, options));
    };
}
function createRelatedWidget(domEl, state, setupFunc) {
    const widgetReady = new Promise(function (resolve) {
        import("devexpress.viz").then(function (DxBlazorViz) {
            const widgetBuilder = createWidgetBuilder(DxBlazorViz, FunnelData.getChartElement(domEl), state, resolve);
            setupFunc(state, widgetBuilder);
        });
    });
    return widgetReady;
}
function updateRelatedWidget(domEl, settings, setupFunc) {
    
}
function init(mainElement, opt, dotnetHelper) {
    return createRelatedWidget(mainElement, opt, function (opt, widgetBuilder) {
        
    })
        .then(function () { return Promise.resolve("ok"); })
        .catch(function (r) { window.console.error(r); });
}
function dispose(mainElement) {
    mainElement = ensureElement(mainElement);

    if (!mainElement) return;
    return disposeWidget(mainElement, true);
}

export default { init, dispose };

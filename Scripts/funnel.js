//import DevExpress from "./external/devexpress.viz.js";
import { ensureElement, toggleCssClass } from "./dom-utils";

class FunnelData {
    constructor(domElement, widget) {
        this.widget = widget;
        this.chartElement = FunnelData.getChartElement(domElement);
    }
    static getElement(domElement) {
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

export function createWidgetBuilder(DxBlazorViz, hostElement, state) {
    console.log(state);
    new DxBlazorViz.viz.dxFunnel(hostElement, state);

}
function createRelatedWidget(domEl, state, setupFunc) {
    const widgetReady = new Promise(function (resolve) {
        import("devexpress.viz").then(function (DxBlazorViz) {
            const widgetBuilder = createWidgetBuilder(DxBlazorViz, FunnelData.getElement(domEl));
            setupFunc(state, widgetBuilder);
        });
    });
    return widgetReady;
}
function init(mainElement, opt, dotnetHelper) {
    import("devexpress.viz").then(function (DxBlazorViz) {
        createWidgetBuilder(DxBlazorViz, mainElement, opt);
    });
}
function dispose(mainElement) {
    mainElement = ensureElement(mainElement);

    if (!mainElement) return;
    return disposeWidget(mainElement, true);
}

export default { init, dispose };

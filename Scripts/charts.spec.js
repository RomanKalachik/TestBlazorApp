import { createWidgetBuilder } from "./charts";

function dxChart(hostElement, options) {
    this.options = options;
}
function dxPieChart(hostElement, options) {
    this.options = options;
}
const DxBlazorVizMock = {
    viz: {
        dxChart: dxChart,
        dxPieChart: dxPieChart
    }
};
describe("chart spec", () => {
    let widgetContainer;


    beforeEach(() => {
        widgetContainer = document.createElement("DIV");
        document.body.appendChild(widgetContainer);
    });
    afterEach(() => {
        document.body.removeChild(widgetContainer);
        widgetContainer = null;
    });
    describe("create correct type of chart", () => {
        let widgetInstance, widgetCallback;
        beforeEach(() => {
            widgetInstance = null;
            widgetCallback = (w) => {
                widgetInstance = w;
            };
        });
        it("pie if pie series in options", () => {
            var builder = createWidgetBuilder(DxBlazorVizMock, widgetContainer, { series: [{ category: "pie" }] }, widgetCallback);
            builder({});
            expect(widgetInstance instanceof dxPieChart).toBe(true);
        });
        it("donut if pie series in options", () => {
            var builder = createWidgetBuilder(DxBlazorVizMock, widgetContainer, { series: [{ category: "donut" }] }, widgetCallback);
            builder({});
            expect(widgetInstance instanceof dxPieChart).toBe(true);
            expect(widgetInstance.options.type).toBe("donut");
        });
        it("chart if common series in options", () => {
            var builder = createWidgetBuilder(DxBlazorVizMock, widgetContainer, { series: [{ category: "common" }] }, widgetCallback);
            builder({});
            expect(widgetInstance instanceof dxChart).toBe(true);
        });
    });
});

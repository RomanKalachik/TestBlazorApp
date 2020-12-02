"use strict";

var DevExpress = window.DxBlazorInternal._devextreme = window.DxBlazorInternal._devextreme || {};
var viz = DevExpress.viz = require("../../node_modules/devextreme/bundles/modules/viz");
viz.exportWidgets = require("../../node_modules/devextreme/viz/export").exportWidgets;
viz.dxChart = require("../../node_modules/devextreme/viz/chart");
viz.dxPieChart = require("../../node_modules/devextreme/viz/pie_chart");
viz.dxPolarChart = require("../../node_modules/devextreme/viz/polar_chart");
viz.dxRangeSelector = require("../../node_modules/devextreme/viz/range_selector");
viz.dxSparkline = require("../../node_modules/devextreme/viz/sparkline");
viz.dxFunnel = require("../../node_modules/devextreme/viz/funnel");
module.exports = viz;

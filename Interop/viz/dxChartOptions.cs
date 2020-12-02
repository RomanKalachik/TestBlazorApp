/// Generated - Do Not Edit
namespace DevExpress.viz
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using DevExpress.Blazor.Interop.Internal;
    using DevExpress.Blazor.Interop.Internal.Callbacks;
    using Microsoft.JSInterop;

    interface dxChartOptions : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxChartOptionsCachedEntity>))]
    class dxChartOptionsCachedEntity : CachedEntityObject, dxChartOptions
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties
        
        public bool adjustOnZoom
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "adjustOnZoom"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "adjustOnZoom",
                    value
                );
            }
        }

        
        public dxChartAnnotationConfigCachedEntity[] annotations
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<dxChartAnnotationConfigCachedEntity>(
                    this.___guid,
                    "annotations",
                    (entity) =>
                    {
                        return new dxChartAnnotationConfigCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "annotations",
                    value
                );
            }
        }

        private dxChartArgumentAxisCachedEntity __argumentAxis;
        public dxChartArgumentAxisCachedEntity argumentAxis
        {
            get
            {
            if(__argumentAxis == null)
            {
                __argumentAxis = EventHorizonBlazorInterop.GetClass<dxChartArgumentAxisCachedEntity>(
                    this.___guid,
                    "argumentAxis",
                    (entity) =>
                    {
                        return new dxChartArgumentAxisCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __argumentAxis;
            }
            set
            {
__argumentAxis = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "argumentAxis",
                    value
                );
            }
        }

        
        public bool autoHidePointMarkers
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoHidePointMarkers"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoHidePointMarkers",
                    value
                );
            }
        }

        
        public decimal barGroupPadding
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "barGroupPadding"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "barGroupPadding",
                    value
                );
            }
        }

        
        public decimal barGroupWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "barGroupWidth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "barGroupWidth",
                    value
                );
            }
        }

        
        public decimal barWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "barWidth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "barWidth",
                    value
                );
            }
        }

        private dxChartCommonAnnotationConfigCachedEntity __commonAnnotationSettings;
        public dxChartCommonAnnotationConfigCachedEntity commonAnnotationSettings
        {
            get
            {
            if(__commonAnnotationSettings == null)
            {
                __commonAnnotationSettings = EventHorizonBlazorInterop.GetClass<dxChartCommonAnnotationConfigCachedEntity>(
                    this.___guid,
                    "commonAnnotationSettings",
                    (entity) =>
                    {
                        return new dxChartCommonAnnotationConfigCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __commonAnnotationSettings;
            }
            set
            {
__commonAnnotationSettings = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "commonAnnotationSettings",
                    value
                );
            }
        }

        private dxChartCommonAxisSettingsCachedEntity __commonAxisSettings;
        public dxChartCommonAxisSettingsCachedEntity commonAxisSettings
        {
            get
            {
            if(__commonAxisSettings == null)
            {
                __commonAxisSettings = EventHorizonBlazorInterop.GetClass<dxChartCommonAxisSettingsCachedEntity>(
                    this.___guid,
                    "commonAxisSettings",
                    (entity) =>
                    {
                        return new dxChartCommonAxisSettingsCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __commonAxisSettings;
            }
            set
            {
__commonAxisSettings = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "commonAxisSettings",
                    value
                );
            }
        }

        private dxChartCommonPaneSettingsCachedEntity __commonPaneSettings;
        public dxChartCommonPaneSettingsCachedEntity commonPaneSettings
        {
            get
            {
            if(__commonPaneSettings == null)
            {
                __commonPaneSettings = EventHorizonBlazorInterop.GetClass<dxChartCommonPaneSettingsCachedEntity>(
                    this.___guid,
                    "commonPaneSettings",
                    (entity) =>
                    {
                        return new dxChartCommonPaneSettingsCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __commonPaneSettings;
            }
            set
            {
__commonPaneSettings = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "commonPaneSettings",
                    value
                );
            }
        }

        private dxChartCommonSeriesSettingsCachedEntity __commonSeriesSettings;
        public dxChartCommonSeriesSettingsCachedEntity commonSeriesSettings
        {
            get
            {
            if(__commonSeriesSettings == null)
            {
                __commonSeriesSettings = EventHorizonBlazorInterop.GetClass<dxChartCommonSeriesSettingsCachedEntity>(
                    this.___guid,
                    "commonSeriesSettings",
                    (entity) =>
                    {
                        return new dxChartCommonSeriesSettingsCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __commonSeriesSettings;
            }
            set
            {
__commonSeriesSettings = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "commonSeriesSettings",
                    value
                );
            }
        }

        
        public string containerBackgroundColor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "containerBackgroundColor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "containerBackgroundColor",
                    value
                );
            }
        }

        
        public CachedEntity crosshair
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "crosshair",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "crosshair",
                    value
                );
            }
        }

        
        public bool dataPrepareSettings
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "dataPrepareSettings"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "dataPrepareSettings",
                    value
                );
            }
        }

        
        public string defaultPane
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "defaultPane"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defaultPane",
                    value
                );
            }
        }

        
        public bool equalBarWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "equalBarWidth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "equalBarWidth",
                    value
                );
            }
        }

        private dxChartLegendCachedEntity __legend;
        public dxChartLegendCachedEntity legend
        {
            get
            {
            if(__legend == null)
            {
                __legend = EventHorizonBlazorInterop.GetClass<dxChartLegendCachedEntity>(
                    this.___guid,
                    "legend",
                    (entity) =>
                    {
                        return new dxChartLegendCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __legend;
            }
            set
            {
__legend = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "legend",
                    value
                );
            }
        }

        
        public decimal maxBubbleSize
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxBubbleSize"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxBubbleSize",
                    value
                );
            }
        }

        
        public decimal minBubbleSize
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "minBubbleSize"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "minBubbleSize",
                    value
                );
            }
        }

        
        public bool negativesAsZeroes
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "negativesAsZeroes"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "negativesAsZeroes",
                    value
                );
            }
        }

        private dxChartPanesCachedEntity __panes;
        public dxChartPanesCachedEntity panes
        {
            get
            {
            if(__panes == null)
            {
                __panes = EventHorizonBlazorInterop.GetClass<dxChartPanesCachedEntity>(
                    this.___guid,
                    "panes",
                    (entity) =>
                    {
                        return new dxChartPanesCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __panes;
            }
            set
            {
__panes = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "panes",
                    value
                );
            }
        }

        
        public bool resizePanesOnZoom
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "resizePanesOnZoom"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "resizePanesOnZoom",
                    value
                );
            }
        }

        
        public CachedEntity resolveLabelOverlapping
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "resolveLabelOverlapping",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "resolveLabelOverlapping",
                    value
                );
            }
        }

        
        public bool rotated
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "rotated"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rotated",
                    value
                );
            }
        }

        
        public CachedEntity scrollBar
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "scrollBar",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scrollBar",
                    value
                );
            }
        }

        
        public CachedEntity scrollingMode
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "scrollingMode",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scrollingMode",
                    value
                );
            }
        }

        private ChartSeriesCachedEntity __series;
        public ChartSeriesCachedEntity series
        {
            get
            {
            if(__series == null)
            {
                __series = EventHorizonBlazorInterop.GetClass<ChartSeriesCachedEntity>(
                    this.___guid,
                    "series",
                    (entity) =>
                    {
                        return new ChartSeriesCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __series;
            }
            set
            {
__series = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "series",
                    value
                );
            }
        }

        
        public CachedEntity seriesSelectionMode
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "seriesSelectionMode",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "seriesSelectionMode",
                    value
                );
            }
        }

        
        public CachedEntity seriesTemplate
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "seriesTemplate",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "seriesTemplate",
                    value
                );
            }
        }

        
        public bool stickyHovering
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "stickyHovering"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "stickyHovering",
                    value
                );
            }
        }

        
        public bool synchronizeMultiAxes
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "synchronizeMultiAxes"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "synchronizeMultiAxes",
                    value
                );
            }
        }

        private dxChartTooltipCachedEntity __tooltip;
        public dxChartTooltipCachedEntity tooltip
        {
            get
            {
            if(__tooltip == null)
            {
                __tooltip = EventHorizonBlazorInterop.GetClass<dxChartTooltipCachedEntity>(
                    this.___guid,
                    "tooltip",
                    (entity) =>
                    {
                        return new dxChartTooltipCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __tooltip;
            }
            set
            {
__tooltip = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tooltip",
                    value
                );
            }
        }

        
        public bool useAggregation
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useAggregation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useAggregation",
                    value
                );
            }
        }

        private dxChartValueAxisCachedEntity __valueAxis;
        public dxChartValueAxisCachedEntity valueAxis
        {
            get
            {
            if(__valueAxis == null)
            {
                __valueAxis = EventHorizonBlazorInterop.GetClass<dxChartValueAxisCachedEntity>(
                    this.___guid,
                    "valueAxis",
                    (entity) =>
                    {
                        return new dxChartValueAxisCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __valueAxis;
            }
            set
            {
__valueAxis = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "valueAxis",
                    value
                );
            }
        }

        
        public CachedEntity zoomAndPan
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "zoomAndPan",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "zoomAndPan",
                    value
                );
            }
        }

        
        public CachedEntity zoomingMode
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "zoomingMode",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "zoomingMode",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public dxChartOptionsCachedEntity() : base() { }

        public dxChartOptionsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public dxChartAnnotationConfigCachedEntity customizeAnnotation()
        {
            return EventHorizonBlazorInterop.FuncClass<dxChartAnnotationConfigCachedEntity>(
                entity => new dxChartAnnotationConfigCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "customizeAnnotation" }
                }
            );
        }

        public Date onArgumentAxisClick()
        {
            return EventHorizonBlazorInterop.FuncClass<Date>(
                entity => new Date() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "onArgumentAxisClick" }
                }
            );
        }

        #region onLegendClick TODO: Get Comments as metadata identification
        private bool _isOnLegendClickEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onLegendClickActionMap = new Dictionary<string, Func<Task>>();

        public string onLegendClick(
            Func<Task> callback
        )
        {
            SetupOnLegendClickLoop();

            var handle = Guid.NewGuid().ToString();
            _onLegendClickActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onLegendClick_Remove(
            string handle
        )
        {
            return _onLegendClickActionMap.Remove(
                handle
            );
        }

        private void SetupOnLegendClickLoop()
        {
            if (_isOnLegendClickEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onLegendClick",
                "CallOnLegendClickActions",
                _invokableReference
            );
            _isOnLegendClickEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnLegendClickActions()
        {
            foreach (var action in _onLegendClickActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onSeriesClick TODO: Get Comments as metadata identification
        private bool _isOnSeriesClickEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onSeriesClickActionMap = new Dictionary<string, Func<Task>>();

        public string onSeriesClick(
            Func<Task> callback
        )
        {
            SetupOnSeriesClickLoop();

            var handle = Guid.NewGuid().ToString();
            _onSeriesClickActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onSeriesClick_Remove(
            string handle
        )
        {
            return _onSeriesClickActionMap.Remove(
                handle
            );
        }

        private void SetupOnSeriesClickLoop()
        {
            if (_isOnSeriesClickEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onSeriesClick",
                "CallOnSeriesClickActions",
                _invokableReference
            );
            _isOnSeriesClickEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnSeriesClickActions()
        {
            foreach (var action in _onSeriesClickActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onSeriesHoverChanged TODO: Get Comments as metadata identification
        private bool _isOnSeriesHoverChangedEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onSeriesHoverChangedActionMap = new Dictionary<string, Func<Task>>();

        public string onSeriesHoverChanged(
            Func<Task> callback
        )
        {
            SetupOnSeriesHoverChangedLoop();

            var handle = Guid.NewGuid().ToString();
            _onSeriesHoverChangedActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onSeriesHoverChanged_Remove(
            string handle
        )
        {
            return _onSeriesHoverChangedActionMap.Remove(
                handle
            );
        }

        private void SetupOnSeriesHoverChangedLoop()
        {
            if (_isOnSeriesHoverChangedEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onSeriesHoverChanged",
                "CallOnSeriesHoverChangedActions",
                _invokableReference
            );
            _isOnSeriesHoverChangedEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnSeriesHoverChangedActions()
        {
            foreach (var action in _onSeriesHoverChangedActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onSeriesSelectionChanged TODO: Get Comments as metadata identification
        private bool _isOnSeriesSelectionChangedEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onSeriesSelectionChangedActionMap = new Dictionary<string, Func<Task>>();

        public string onSeriesSelectionChanged(
            Func<Task> callback
        )
        {
            SetupOnSeriesSelectionChangedLoop();

            var handle = Guid.NewGuid().ToString();
            _onSeriesSelectionChangedActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onSeriesSelectionChanged_Remove(
            string handle
        )
        {
            return _onSeriesSelectionChangedActionMap.Remove(
                handle
            );
        }

        private void SetupOnSeriesSelectionChangedLoop()
        {
            if (_isOnSeriesSelectionChangedEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onSeriesSelectionChanged",
                "CallOnSeriesSelectionChangedActions",
                _invokableReference
            );
            _isOnSeriesSelectionChangedEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnSeriesSelectionChangedActions()
        {
            foreach (var action in _onSeriesSelectionChangedActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public Date onZoomEnd()
        {
            return EventHorizonBlazorInterop.FuncClass<Date>(
                entity => new Date() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "onZoomEnd" }
                }
            );
        }

        #region onZoomStart TODO: Get Comments as metadata identification
        private bool _isOnZoomStartEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onZoomStartActionMap = new Dictionary<string, Func<Task>>();

        public string onZoomStart(
            Func<Task> callback
        )
        {
            SetupOnZoomStartLoop();

            var handle = Guid.NewGuid().ToString();
            _onZoomStartActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onZoomStart_Remove(
            string handle
        )
        {
            return _onZoomStartActionMap.Remove(
                handle
            );
        }

        private void SetupOnZoomStartLoop()
        {
            if (_isOnZoomStartEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onZoomStart",
                "CallOnZoomStartActions",
                _invokableReference
            );
            _isOnZoomStartEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnZoomStartActions()
        {
            foreach (var action in _onZoomStartActionMap.Values)
            {
                await action();
            }
        }
        #endregion
        #endregion
    }
}

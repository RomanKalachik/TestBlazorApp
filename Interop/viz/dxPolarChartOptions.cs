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

    interface dxPolarChartOptions : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxPolarChartOptionsCachedEntity>))]
    class dxPolarChartOptionsCachedEntity : CachedEntityObject, dxPolarChartOptions
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
        private dxPolarChartAdaptiveLayoutCachedEntity __adaptiveLayout;
        public dxPolarChartAdaptiveLayoutCachedEntity adaptiveLayout
        {
            get
            {
            if(__adaptiveLayout == null)
            {
                __adaptiveLayout = EventHorizonBlazorInterop.GetClass<dxPolarChartAdaptiveLayoutCachedEntity>(
                    this.___guid,
                    "adaptiveLayout",
                    (entity) =>
                    {
                        return new dxPolarChartAdaptiveLayoutCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __adaptiveLayout;
            }
            set
            {
__adaptiveLayout = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "adaptiveLayout",
                    value
                );
            }
        }

        
        public dxPolarChartAnnotationConfigCachedEntity[] annotations
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<dxPolarChartAnnotationConfigCachedEntity>(
                    this.___guid,
                    "annotations",
                    (entity) =>
                    {
                        return new dxPolarChartAnnotationConfigCachedEntity() { ___guid = entity.___guid };
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

        private dxPolarChartArgumentAxisCachedEntity __argumentAxis;
        public dxPolarChartArgumentAxisCachedEntity argumentAxis
        {
            get
            {
            if(__argumentAxis == null)
            {
                __argumentAxis = EventHorizonBlazorInterop.GetClass<dxPolarChartArgumentAxisCachedEntity>(
                    this.___guid,
                    "argumentAxis",
                    (entity) =>
                    {
                        return new dxPolarChartArgumentAxisCachedEntity() { ___guid = entity.___guid };
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

        private dxPolarChartCommonAnnotationConfigCachedEntity __commonAnnotationSettings;
        public dxPolarChartCommonAnnotationConfigCachedEntity commonAnnotationSettings
        {
            get
            {
            if(__commonAnnotationSettings == null)
            {
                __commonAnnotationSettings = EventHorizonBlazorInterop.GetClass<dxPolarChartCommonAnnotationConfigCachedEntity>(
                    this.___guid,
                    "commonAnnotationSettings",
                    (entity) =>
                    {
                        return new dxPolarChartCommonAnnotationConfigCachedEntity() { ___guid = entity.___guid };
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

        private dxPolarChartCommonAxisSettingsCachedEntity __commonAxisSettings;
        public dxPolarChartCommonAxisSettingsCachedEntity commonAxisSettings
        {
            get
            {
            if(__commonAxisSettings == null)
            {
                __commonAxisSettings = EventHorizonBlazorInterop.GetClass<dxPolarChartCommonAxisSettingsCachedEntity>(
                    this.___guid,
                    "commonAxisSettings",
                    (entity) =>
                    {
                        return new dxPolarChartCommonAxisSettingsCachedEntity() { ___guid = entity.___guid };
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

        private dxPolarChartCommonSeriesSettingsCachedEntity __commonSeriesSettings;
        public dxPolarChartCommonSeriesSettingsCachedEntity commonSeriesSettings
        {
            get
            {
            if(__commonSeriesSettings == null)
            {
                __commonSeriesSettings = EventHorizonBlazorInterop.GetClass<dxPolarChartCommonSeriesSettingsCachedEntity>(
                    this.___guid,
                    "commonSeriesSettings",
                    (entity) =>
                    {
                        return new dxPolarChartCommonSeriesSettingsCachedEntity() { ___guid = entity.___guid };
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

        private dxPolarChartLegendCachedEntity __legend;
        public dxPolarChartLegendCachedEntity legend
        {
            get
            {
            if(__legend == null)
            {
                __legend = EventHorizonBlazorInterop.GetClass<dxPolarChartLegendCachedEntity>(
                    this.___guid,
                    "legend",
                    (entity) =>
                    {
                        return new dxPolarChartLegendCachedEntity() { ___guid = entity.___guid };
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

        private PolarChartSeriesCachedEntity __series;
        public PolarChartSeriesCachedEntity series
        {
            get
            {
            if(__series == null)
            {
                __series = EventHorizonBlazorInterop.GetClass<PolarChartSeriesCachedEntity>(
                    this.___guid,
                    "series",
                    (entity) =>
                    {
                        return new PolarChartSeriesCachedEntity() { ___guid = entity.___guid };
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

        private dxPolarChartTooltipCachedEntity __tooltip;
        public dxPolarChartTooltipCachedEntity tooltip
        {
            get
            {
            if(__tooltip == null)
            {
                __tooltip = EventHorizonBlazorInterop.GetClass<dxPolarChartTooltipCachedEntity>(
                    this.___guid,
                    "tooltip",
                    (entity) =>
                    {
                        return new dxPolarChartTooltipCachedEntity() { ___guid = entity.___guid };
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

        
        public bool useSpiderWeb
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useSpiderWeb"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useSpiderWeb",
                    value
                );
            }
        }

        private dxPolarChartValueAxisCachedEntity __valueAxis;
        public dxPolarChartValueAxisCachedEntity valueAxis
        {
            get
            {
            if(__valueAxis == null)
            {
                __valueAxis = EventHorizonBlazorInterop.GetClass<dxPolarChartValueAxisCachedEntity>(
                    this.___guid,
                    "valueAxis",
                    (entity) =>
                    {
                        return new dxPolarChartValueAxisCachedEntity() { ___guid = entity.___guid };
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
        #endregion
        
        #region Constructor
        public dxPolarChartOptionsCachedEntity() : base() { }

        public dxPolarChartOptionsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public dxPolarChartAnnotationConfigCachedEntity customizeAnnotation()
        {
            return EventHorizonBlazorInterop.FuncClass<dxPolarChartAnnotationConfigCachedEntity>(
                entity => new dxPolarChartAnnotationConfigCachedEntity() { ___guid = entity.___guid },
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

        #region onZoomEnd TODO: Get Comments as metadata identification
        private bool _isOnZoomEndEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onZoomEndActionMap = new Dictionary<string, Func<Task>>();

        public string onZoomEnd(
            Func<Task> callback
        )
        {
            SetupOnZoomEndLoop();

            var handle = Guid.NewGuid().ToString();
            _onZoomEndActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onZoomEnd_Remove(
            string handle
        )
        {
            return _onZoomEndActionMap.Remove(
                handle
            );
        }

        private void SetupOnZoomEndLoop()
        {
            if (_isOnZoomEndEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onZoomEnd",
                "CallOnZoomEndActions",
                _invokableReference
            );
            _isOnZoomEndEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnZoomEndActions()
        {
            foreach (var action in _onZoomEndActionMap.Values)
            {
                await action();
            }
        }
        #endregion

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

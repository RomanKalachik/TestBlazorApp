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

    interface dxFunnelOptions : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxFunnelOptionsCachedEntity>))]
    class dxFunnelOptionsCachedEntity : CachedEntityObject, dxFunnelOptions
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
        
        public CachedEntity adaptiveLayout
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "adaptiveLayout",
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
                    "adaptiveLayout",
                    value
                );
            }
        }

        
        public CachedEntity algorithm
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "algorithm",
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
                    "algorithm",
                    value
                );
            }
        }

        
        public string argumentField
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "argumentField"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "argumentField",
                    value
                );
            }
        }

        
        public string colorField
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "colorField"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "colorField",
                    value
                );
            }
        }

        
        public CachedEntity[] dataSource
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<CachedEntity>(
                    this.___guid,
                    "dataSource",
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
                    "dataSource",
                    value
                );
            }
        }

        
        public bool hoverEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hoverEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "hoverEnabled",
                    value
                );
            }
        }

        
        public bool inverted
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "inverted"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inverted",
                    value
                );
            }
        }

        
        public CachedEntity item
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "item",
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
                    "item",
                    value
                );
            }
        }

        
        public CachedEntity label
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "label",
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
                    "label",
                    value
                );
            }
        }

        private dxFunnelLegendCachedEntity __legend;
        public dxFunnelLegendCachedEntity legend
        {
            get
            {
            if(__legend == null)
            {
                __legend = EventHorizonBlazorInterop.GetClass<dxFunnelLegendCachedEntity>(
                    this.___guid,
                    "legend",
                    (entity) =>
                    {
                        return new dxFunnelLegendCachedEntity() { ___guid = entity.___guid };
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

        
        public decimal neckHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "neckHeight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "neckHeight",
                    value
                );
            }
        }

        
        public decimal neckWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "neckWidth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "neckWidth",
                    value
                );
            }
        }

        
        public string[] palette
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<string>(
                    this.___guid,
                    "palette"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "palette",
                    value
                );
            }
        }

        
        public CachedEntity paletteExtensionMode
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "paletteExtensionMode",
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
                    "paletteExtensionMode",
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

        
        public CachedEntity selectionMode
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "selectionMode",
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
                    "selectionMode",
                    value
                );
            }
        }

        
        public bool sortData
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "sortData"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sortData",
                    value
                );
            }
        }

        private dxFunnelTooltipCachedEntity __tooltip;
        public dxFunnelTooltipCachedEntity tooltip
        {
            get
            {
            if(__tooltip == null)
            {
                __tooltip = EventHorizonBlazorInterop.GetClass<dxFunnelTooltipCachedEntity>(
                    this.___guid,
                    "tooltip",
                    (entity) =>
                    {
                        return new dxFunnelTooltipCachedEntity() { ___guid = entity.___guid };
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

        
        public string valueField
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "valueField"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "valueField",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public dxFunnelOptionsCachedEntity() : base() { }

        public dxFunnelOptionsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        #region onHoverChanged TODO: Get Comments as metadata identification
        private bool _isOnHoverChangedEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onHoverChangedActionMap = new Dictionary<string, Func<Task>>();

        public string onHoverChanged(
            Func<Task> callback
        )
        {
            SetupOnHoverChangedLoop();

            var handle = Guid.NewGuid().ToString();
            _onHoverChangedActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onHoverChanged_Remove(
            string handle
        )
        {
            return _onHoverChangedActionMap.Remove(
                handle
            );
        }

        private void SetupOnHoverChangedLoop()
        {
            if (_isOnHoverChangedEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onHoverChanged",
                "CallOnHoverChangedActions",
                _invokableReference
            );
            _isOnHoverChangedEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnHoverChangedActions()
        {
            foreach (var action in _onHoverChangedActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onItemClick TODO: Get Comments as metadata identification
        private bool _isOnItemClickEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onItemClickActionMap = new Dictionary<string, Func<Task>>();

        public string onItemClick(
            Func<Task> callback
        )
        {
            SetupOnItemClickLoop();

            var handle = Guid.NewGuid().ToString();
            _onItemClickActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onItemClick_Remove(
            string handle
        )
        {
            return _onItemClickActionMap.Remove(
                handle
            );
        }

        private void SetupOnItemClickLoop()
        {
            if (_isOnItemClickEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onItemClick",
                "CallOnItemClickActions",
                _invokableReference
            );
            _isOnItemClickEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnItemClickActions()
        {
            foreach (var action in _onItemClickActionMap.Values)
            {
                await action();
            }
        }
        #endregion

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

        #region onSelectionChanged TODO: Get Comments as metadata identification
        private bool _isOnSelectionChangedEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onSelectionChangedActionMap = new Dictionary<string, Func<Task>>();

        public string onSelectionChanged(
            Func<Task> callback
        )
        {
            SetupOnSelectionChangedLoop();

            var handle = Guid.NewGuid().ToString();
            _onSelectionChangedActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onSelectionChanged_Remove(
            string handle
        )
        {
            return _onSelectionChangedActionMap.Remove(
                handle
            );
        }

        private void SetupOnSelectionChangedLoop()
        {
            if (_isOnSelectionChangedEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onSelectionChanged",
                "CallOnSelectionChangedActions",
                _invokableReference
            );
            _isOnSelectionChangedEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnSelectionChangedActions()
        {
            foreach (var action in _onSelectionChangedActionMap.Values)
            {
                await action();
            }
        }
        #endregion
        #endregion
    }
}

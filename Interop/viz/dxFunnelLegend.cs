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

    interface dxFunnelLegend : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxFunnelLegendCachedEntity>))]
    class dxFunnelLegendCachedEntity : CachedEntityObject, dxFunnelLegend
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
        
        public string markerTemplate
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "markerTemplate"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "markerTemplate",
                    value
                );
            }
        }

        
        public bool visible
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "visible"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "visible",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public dxFunnelLegendCachedEntity() : base() { }

        public dxFunnelLegendCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        #region customizeHint TODO: Get Comments as metadata identification
        private bool _isCustomizeHintEnabled = false;
        private readonly IDictionary<string, Func<Task>> _customizeHintActionMap = new Dictionary<string, Func<Task>>();

        public string customizeHint(
            Func<Task> callback
        )
        {
            SetupCustomizeHintLoop();

            var handle = Guid.NewGuid().ToString();
            _customizeHintActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool customizeHint_Remove(
            string handle
        )
        {
            return _customizeHintActionMap.Remove(
                handle
            );
        }

        private void SetupCustomizeHintLoop()
        {
            if (_isCustomizeHintEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "customizeHint",
                "CallCustomizeHintActions",
                _invokableReference
            );
            _isCustomizeHintEnabled = true;
        }

        [JSInvokable]
        public async Task CallCustomizeHintActions()
        {
            foreach (var action in _customizeHintActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region customizeItems TODO: Get Comments as metadata identification
        private bool _isCustomizeItemsEnabled = false;
        private readonly IDictionary<string, Func<Task>> _customizeItemsActionMap = new Dictionary<string, Func<Task>>();

        public string customizeItems(
            Func<Task> callback
        )
        {
            SetupCustomizeItemsLoop();

            var handle = Guid.NewGuid().ToString();
            _customizeItemsActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool customizeItems_Remove(
            string handle
        )
        {
            return _customizeItemsActionMap.Remove(
                handle
            );
        }

        private void SetupCustomizeItemsLoop()
        {
            if (_isCustomizeItemsEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "customizeItems",
                "CallCustomizeItemsActions",
                _invokableReference
            );
            _isCustomizeItemsEnabled = true;
        }

        [JSInvokable]
        public async Task CallCustomizeItemsActions()
        {
            foreach (var action in _customizeItemsActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region customizeText TODO: Get Comments as metadata identification
        private bool _isCustomizeTextEnabled = false;
        private readonly IDictionary<string, Func<Task>> _customizeTextActionMap = new Dictionary<string, Func<Task>>();

        public string customizeText(
            Func<Task> callback
        )
        {
            SetupCustomizeTextLoop();

            var handle = Guid.NewGuid().ToString();
            _customizeTextActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool customizeText_Remove(
            string handle
        )
        {
            return _customizeTextActionMap.Remove(
                handle
            );
        }

        private void SetupCustomizeTextLoop()
        {
            if (_isCustomizeTextEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "customizeText",
                "CallCustomizeTextActions",
                _invokableReference
            );
            _isCustomizeTextEnabled = true;
        }

        [JSInvokable]
        public async Task CallCustomizeTextActions()
        {
            foreach (var action in _customizeTextActionMap.Values)
            {
                await action();
            }
        }
        #endregion
        #endregion
    }
}

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

    interface dxPolarChartLegend : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxPolarChartLegendCachedEntity>))]
    class dxPolarChartLegendCachedEntity : CachedEntityObject, dxPolarChartLegend
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
        
        public CachedEntity hoverMode
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "hoverMode",
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
                    "hoverMode",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public dxPolarChartLegendCachedEntity() : base() { }

        public dxPolarChartLegendCachedEntity(
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

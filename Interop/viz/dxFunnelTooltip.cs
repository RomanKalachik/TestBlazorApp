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

    interface dxFunnelTooltip : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxFunnelTooltipCachedEntity>))]
    class dxFunnelTooltipCachedEntity : CachedEntityObject, dxFunnelTooltip
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
        
        public string contentTemplate
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "contentTemplate"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "contentTemplate",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public dxFunnelTooltipCachedEntity() : base() { }

        public dxFunnelTooltipCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        #region customizeTooltip TODO: Get Comments as metadata identification
        private bool _isCustomizeTooltipEnabled = false;
        private readonly IDictionary<string, Func<Task>> _customizeTooltipActionMap = new Dictionary<string, Func<Task>>();

        public string customizeTooltip(
            Func<Task> callback
        )
        {
            SetupCustomizeTooltipLoop();

            var handle = Guid.NewGuid().ToString();
            _customizeTooltipActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool customizeTooltip_Remove(
            string handle
        )
        {
            return _customizeTooltipActionMap.Remove(
                handle
            );
        }

        private void SetupCustomizeTooltipLoop()
        {
            if (_isCustomizeTooltipEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "customizeTooltip",
                "CallCustomizeTooltipActions",
                _invokableReference
            );
            _isCustomizeTooltipEnabled = true;
        }

        [JSInvokable]
        public async Task CallCustomizeTooltipActions()
        {
            foreach (var action in _customizeTooltipActionMap.Values)
            {
                await action();
            }
        }
        #endregion
        #endregion
    }
}

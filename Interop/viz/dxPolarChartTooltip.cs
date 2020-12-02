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

    interface dxPolarChartTooltip : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxPolarChartTooltipCachedEntity>))]
    class dxPolarChartTooltipCachedEntity : CachedEntityObject, dxPolarChartTooltip
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
        
        public bool shared
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "shared"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shared",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public dxPolarChartTooltipCachedEntity() : base() { }

        public dxPolarChartTooltipCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}

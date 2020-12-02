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

    interface dxPolarChartValueAxisTick : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxPolarChartValueAxisTickCachedEntity>))]
    class dxPolarChartValueAxisTickCachedEntity : CachedEntityObject, dxPolarChartValueAxisTick
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
        public dxPolarChartValueAxisTickCachedEntity() : base() { }

        public dxPolarChartValueAxisTickCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}

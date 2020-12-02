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

    interface dxPolarChartArgumentAxisMinorTick : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxPolarChartArgumentAxisMinorTickCachedEntity>))]
    class dxPolarChartArgumentAxisMinorTickCachedEntity : CachedEntityObject, dxPolarChartArgumentAxisMinorTick
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
        
        public decimal shift
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "shift"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shift",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public dxPolarChartArgumentAxisMinorTickCachedEntity() : base() { }

        public dxPolarChartArgumentAxisMinorTickCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}

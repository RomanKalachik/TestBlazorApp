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

    interface dxPolarChartAdaptiveLayout : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxPolarChartAdaptiveLayoutCachedEntity>))]
    class dxPolarChartAdaptiveLayoutCachedEntity : CachedEntityObject, dxPolarChartAdaptiveLayout
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
        
        public decimal height
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "height"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "height",
                    value
                );
            }
        }

        
        public decimal width
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "width"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "width",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public dxPolarChartAdaptiveLayoutCachedEntity() : base() { }

        public dxPolarChartAdaptiveLayoutCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}

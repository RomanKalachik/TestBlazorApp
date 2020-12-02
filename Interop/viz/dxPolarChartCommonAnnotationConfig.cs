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

    interface dxPolarChartCommonAnnotationConfig : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxPolarChartCommonAnnotationConfigCachedEntity>))]
    class dxPolarChartCommonAnnotationConfigCachedEntity : CachedEntityObject, dxPolarChartCommonAnnotationConfig
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
        
        public decimal angle
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "angle"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "angle",
                    value
                );
            }
        }

        
        public decimal radius
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "radius"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "radius",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public dxPolarChartCommonAnnotationConfigCachedEntity() : base() { }

        public dxPolarChartCommonAnnotationConfigCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}

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

    interface dxPolarChartAnnotationConfig : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxPolarChartAnnotationConfigCachedEntity>))]
    class dxPolarChartAnnotationConfigCachedEntity : CachedEntityObject, dxPolarChartAnnotationConfig
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
        
        public string name
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public dxPolarChartAnnotationConfigCachedEntity() : base() { }

        public dxPolarChartAnnotationConfigCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}

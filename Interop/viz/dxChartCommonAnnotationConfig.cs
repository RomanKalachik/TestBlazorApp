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

    interface dxChartCommonAnnotationConfig : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxChartCommonAnnotationConfigCachedEntity>))]
    class dxChartCommonAnnotationConfigCachedEntity : CachedEntityObject, dxChartCommonAnnotationConfig
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
        
        public string axis
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "axis"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "axis",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public dxChartCommonAnnotationConfigCachedEntity() : base() { }

        public dxChartCommonAnnotationConfigCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}

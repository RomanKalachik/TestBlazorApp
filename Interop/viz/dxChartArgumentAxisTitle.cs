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

    interface dxChartArgumentAxisTitle : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxChartArgumentAxisTitleCachedEntity>))]
    class dxChartArgumentAxisTitleCachedEntity : CachedEntityObject, dxChartArgumentAxisTitle
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
        
        public string text
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "text"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "text",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public dxChartArgumentAxisTitleCachedEntity() : base() { }

        public dxChartArgumentAxisTitleCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}

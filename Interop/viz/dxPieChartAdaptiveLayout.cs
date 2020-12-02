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

    interface dxPieChartAdaptiveLayout : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxPieChartAdaptiveLayoutCachedEntity>))]
    class dxPieChartAdaptiveLayoutCachedEntity : CachedEntityObject, dxPieChartAdaptiveLayout
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
        
        public bool keepLabels
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "keepLabels"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "keepLabels",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public dxPieChartAdaptiveLayoutCachedEntity() : base() { }

        public dxPieChartAdaptiveLayoutCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}

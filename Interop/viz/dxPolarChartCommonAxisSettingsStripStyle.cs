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

    interface dxPolarChartCommonAxisSettingsStripStyle : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxPolarChartCommonAxisSettingsStripStyleCachedEntity>))]
    class dxPolarChartCommonAxisSettingsStripStyleCachedEntity : CachedEntityObject, dxPolarChartCommonAxisSettingsStripStyle
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
        private dxPolarChartCommonAxisSettingsStripStyleLabelCachedEntity __label;
        public dxPolarChartCommonAxisSettingsStripStyleLabelCachedEntity label
        {
            get
            {
            if(__label == null)
            {
                __label = EventHorizonBlazorInterop.GetClass<dxPolarChartCommonAxisSettingsStripStyleLabelCachedEntity>(
                    this.___guid,
                    "label",
                    (entity) =>
                    {
                        return new dxPolarChartCommonAxisSettingsStripStyleLabelCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __label;
            }
            set
            {
__label = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "label",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public dxPolarChartCommonAxisSettingsStripStyleCachedEntity() : base() { }

        public dxPolarChartCommonAxisSettingsStripStyleCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}

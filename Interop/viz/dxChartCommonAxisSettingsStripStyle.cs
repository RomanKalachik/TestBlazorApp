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

    interface dxChartCommonAxisSettingsStripStyle : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxChartCommonAxisSettingsStripStyleCachedEntity>))]
    class dxChartCommonAxisSettingsStripStyleCachedEntity : CachedEntityObject, dxChartCommonAxisSettingsStripStyle
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
        private dxChartCommonAxisSettingsStripStyleLabelCachedEntity __label;
        public dxChartCommonAxisSettingsStripStyleLabelCachedEntity label
        {
            get
            {
            if(__label == null)
            {
                __label = EventHorizonBlazorInterop.GetClass<dxChartCommonAxisSettingsStripStyleLabelCachedEntity>(
                    this.___guid,
                    "label",
                    (entity) =>
                    {
                        return new dxChartCommonAxisSettingsStripStyleLabelCachedEntity() { ___guid = entity.___guid };
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

        
        public decimal paddingLeftRight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "paddingLeftRight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "paddingLeftRight",
                    value
                );
            }
        }

        
        public decimal paddingTopBottom
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "paddingTopBottom"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "paddingTopBottom",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public dxChartCommonAxisSettingsStripStyleCachedEntity() : base() { }

        public dxChartCommonAxisSettingsStripStyleCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}

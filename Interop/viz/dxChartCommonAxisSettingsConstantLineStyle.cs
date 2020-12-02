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

    interface dxChartCommonAxisSettingsConstantLineStyle : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxChartCommonAxisSettingsConstantLineStyleCachedEntity>))]
    class dxChartCommonAxisSettingsConstantLineStyleCachedEntity : CachedEntityObject, dxChartCommonAxisSettingsConstantLineStyle
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
        
        public string color
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "color"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "color",
                    value
                );
            }
        }

        
        public CachedEntity dashStyle
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "dashStyle",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "dashStyle",
                    value
                );
            }
        }

        private dxChartCommonAxisSettingsConstantLineStyleLabelCachedEntity __label;
        public dxChartCommonAxisSettingsConstantLineStyleLabelCachedEntity label
        {
            get
            {
            if(__label == null)
            {
                __label = EventHorizonBlazorInterop.GetClass<dxChartCommonAxisSettingsConstantLineStyleLabelCachedEntity>(
                    this.___guid,
                    "label",
                    (entity) =>
                    {
                        return new dxChartCommonAxisSettingsConstantLineStyleLabelCachedEntity() { ___guid = entity.___guid };
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
        public dxChartCommonAxisSettingsConstantLineStyleCachedEntity() : base() { }

        public dxChartCommonAxisSettingsConstantLineStyleCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}

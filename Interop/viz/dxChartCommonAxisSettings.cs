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

    interface dxChartCommonAxisSettings : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxChartCommonAxisSettingsCachedEntity>))]
    class dxChartCommonAxisSettingsCachedEntity : CachedEntityObject, dxChartCommonAxisSettings
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
        
        public bool allowDecimals
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "allowDecimals"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "allowDecimals",
                    value
                );
            }
        }

        
        public CachedEntity breakStyle
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "breakStyle",
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
                    "breakStyle",
                    value
                );
            }
        }

        
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

        private dxChartCommonAxisSettingsConstantLineStyleCachedEntity __constantLineStyle;
        public dxChartCommonAxisSettingsConstantLineStyleCachedEntity constantLineStyle
        {
            get
            {
            if(__constantLineStyle == null)
            {
                __constantLineStyle = EventHorizonBlazorInterop.GetClass<dxChartCommonAxisSettingsConstantLineStyleCachedEntity>(
                    this.___guid,
                    "constantLineStyle",
                    (entity) =>
                    {
                        return new dxChartCommonAxisSettingsConstantLineStyleCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __constantLineStyle;
            }
            set
            {
__constantLineStyle = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "constantLineStyle",
                    value
                );
            }
        }

        
        public CachedEntity discreteAxisDivisionMode
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "discreteAxisDivisionMode",
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
                    "discreteAxisDivisionMode",
                    value
                );
            }
        }

        
        public bool endOnTick
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "endOnTick"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "endOnTick",
                    value
                );
            }
        }

        
        public CachedEntity grid
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "grid",
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
                    "grid",
                    value
                );
            }
        }

        
        public bool inverted
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "inverted"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inverted",
                    value
                );
            }
        }

        private dxChartCommonAxisSettingsLabelCachedEntity __label;
        public dxChartCommonAxisSettingsLabelCachedEntity label
        {
            get
            {
            if(__label == null)
            {
                __label = EventHorizonBlazorInterop.GetClass<dxChartCommonAxisSettingsLabelCachedEntity>(
                    this.___guid,
                    "label",
                    (entity) =>
                    {
                        return new dxChartCommonAxisSettingsLabelCachedEntity() { ___guid = entity.___guid };
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

        
        public decimal maxValueMargin
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxValueMargin"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxValueMargin",
                    value
                );
            }
        }

        
        public decimal minValueMargin
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "minValueMargin"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "minValueMargin",
                    value
                );
            }
        }

        
        public CachedEntity minorGrid
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "minorGrid",
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
                    "minorGrid",
                    value
                );
            }
        }

        
        public CachedEntity minorTick
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "minorTick",
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
                    "minorTick",
                    value
                );
            }
        }

        
        public decimal opacity
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "opacity"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "opacity",
                    value
                );
            }
        }

        
        public decimal placeholderSize
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "placeholderSize"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "placeholderSize",
                    value
                );
            }
        }

        private dxChartCommonAxisSettingsStripStyleCachedEntity __stripStyle;
        public dxChartCommonAxisSettingsStripStyleCachedEntity stripStyle
        {
            get
            {
            if(__stripStyle == null)
            {
                __stripStyle = EventHorizonBlazorInterop.GetClass<dxChartCommonAxisSettingsStripStyleCachedEntity>(
                    this.___guid,
                    "stripStyle",
                    (entity) =>
                    {
                        return new dxChartCommonAxisSettingsStripStyleCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __stripStyle;
            }
            set
            {
__stripStyle = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "stripStyle",
                    value
                );
            }
        }

        
        public CachedEntity tick
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "tick",
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
                    "tick",
                    value
                );
            }
        }

        private dxChartCommonAxisSettingsTitleCachedEntity __title;
        public dxChartCommonAxisSettingsTitleCachedEntity title
        {
            get
            {
            if(__title == null)
            {
                __title = EventHorizonBlazorInterop.GetClass<dxChartCommonAxisSettingsTitleCachedEntity>(
                    this.___guid,
                    "title",
                    (entity) =>
                    {
                        return new dxChartCommonAxisSettingsTitleCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __title;
            }
            set
            {
__title = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "title",
                    value
                );
            }
        }

        
        public bool valueMarginsEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "valueMarginsEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "valueMarginsEnabled",
                    value
                );
            }
        }

        
        public bool visible
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "visible"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "visible",
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
        public dxChartCommonAxisSettingsCachedEntity() : base() { }

        public dxChartCommonAxisSettingsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}

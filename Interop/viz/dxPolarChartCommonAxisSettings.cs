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

    interface dxPolarChartCommonAxisSettings : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxPolarChartCommonAxisSettingsCachedEntity>))]
    class dxPolarChartCommonAxisSettingsCachedEntity : CachedEntityObject, dxPolarChartCommonAxisSettings
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

        private dxPolarChartCommonAxisSettingsConstantLineStyleCachedEntity __constantLineStyle;
        public dxPolarChartCommonAxisSettingsConstantLineStyleCachedEntity constantLineStyle
        {
            get
            {
            if(__constantLineStyle == null)
            {
                __constantLineStyle = EventHorizonBlazorInterop.GetClass<dxPolarChartCommonAxisSettingsConstantLineStyleCachedEntity>(
                    this.___guid,
                    "constantLineStyle",
                    (entity) =>
                    {
                        return new dxPolarChartCommonAxisSettingsConstantLineStyleCachedEntity() { ___guid = entity.___guid };
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

        private dxPolarChartCommonAxisSettingsLabelCachedEntity __label;
        public dxPolarChartCommonAxisSettingsLabelCachedEntity label
        {
            get
            {
            if(__label == null)
            {
                __label = EventHorizonBlazorInterop.GetClass<dxPolarChartCommonAxisSettingsLabelCachedEntity>(
                    this.___guid,
                    "label",
                    (entity) =>
                    {
                        return new dxPolarChartCommonAxisSettingsLabelCachedEntity() { ___guid = entity.___guid };
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

        private dxPolarChartCommonAxisSettingsMinorTickCachedEntity __minorTick;
        public dxPolarChartCommonAxisSettingsMinorTickCachedEntity minorTick
        {
            get
            {
            if(__minorTick == null)
            {
                __minorTick = EventHorizonBlazorInterop.GetClass<dxPolarChartCommonAxisSettingsMinorTickCachedEntity>(
                    this.___guid,
                    "minorTick",
                    (entity) =>
                    {
                        return new dxPolarChartCommonAxisSettingsMinorTickCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __minorTick;
            }
            set
            {
__minorTick = null;
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

        private dxPolarChartCommonAxisSettingsStripStyleCachedEntity __stripStyle;
        public dxPolarChartCommonAxisSettingsStripStyleCachedEntity stripStyle
        {
            get
            {
            if(__stripStyle == null)
            {
                __stripStyle = EventHorizonBlazorInterop.GetClass<dxPolarChartCommonAxisSettingsStripStyleCachedEntity>(
                    this.___guid,
                    "stripStyle",
                    (entity) =>
                    {
                        return new dxPolarChartCommonAxisSettingsStripStyleCachedEntity() { ___guid = entity.___guid };
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

        private dxPolarChartCommonAxisSettingsTickCachedEntity __tick;
        public dxPolarChartCommonAxisSettingsTickCachedEntity tick
        {
            get
            {
            if(__tick == null)
            {
                __tick = EventHorizonBlazorInterop.GetClass<dxPolarChartCommonAxisSettingsTickCachedEntity>(
                    this.___guid,
                    "tick",
                    (entity) =>
                    {
                        return new dxPolarChartCommonAxisSettingsTickCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __tick;
            }
            set
            {
__tick = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tick",
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
        public dxPolarChartCommonAxisSettingsCachedEntity() : base() { }

        public dxPolarChartCommonAxisSettingsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}

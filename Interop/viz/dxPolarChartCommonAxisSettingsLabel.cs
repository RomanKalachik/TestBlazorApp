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

    interface dxPolarChartCommonAxisSettingsLabel : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxPolarChartCommonAxisSettingsLabelCachedEntity>))]
    class dxPolarChartCommonAxisSettingsLabelCachedEntity : CachedEntityObject, dxPolarChartCommonAxisSettingsLabel
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
        private FontCachedEntity __font;
        public FontCachedEntity font
        {
            get
            {
            if(__font == null)
            {
                __font = EventHorizonBlazorInterop.GetClass<FontCachedEntity>(
                    this.___guid,
                    "font",
                    (entity) =>
                    {
                        return new FontCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __font;
            }
            set
            {
__font = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "font",
                    value
                );
            }
        }

        
        public decimal indentFromAxis
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "indentFromAxis"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "indentFromAxis",
                    value
                );
            }
        }

        
        public CachedEntity overlappingBehavior
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "overlappingBehavior",
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
                    "overlappingBehavior",
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
        #endregion
        
        #region Constructor
        public dxPolarChartCommonAxisSettingsLabelCachedEntity() : base() { }

        public dxPolarChartCommonAxisSettingsLabelCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}

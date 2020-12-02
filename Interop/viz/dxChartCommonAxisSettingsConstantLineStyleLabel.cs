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

    interface dxChartCommonAxisSettingsConstantLineStyleLabel : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxChartCommonAxisSettingsConstantLineStyleLabelCachedEntity>))]
    class dxChartCommonAxisSettingsConstantLineStyleLabelCachedEntity : CachedEntityObject, dxChartCommonAxisSettingsConstantLineStyleLabel
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

        
        public CachedEntity position
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "position",
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
                    "position",
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
        public dxChartCommonAxisSettingsConstantLineStyleLabelCachedEntity() : base() { }

        public dxChartCommonAxisSettingsConstantLineStyleLabelCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}

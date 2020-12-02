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

    interface dxChartCommonAxisSettingsStripStyleLabel : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxChartCommonAxisSettingsStripStyleLabelCachedEntity>))]
    class dxChartCommonAxisSettingsStripStyleLabelCachedEntity : CachedEntityObject, dxChartCommonAxisSettingsStripStyleLabel
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

        
        public CachedEntity horizontalAlignment
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "horizontalAlignment",
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
                    "horizontalAlignment",
                    value
                );
            }
        }

        
        public CachedEntity verticalAlignment
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "verticalAlignment",
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
                    "verticalAlignment",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public dxChartCommonAxisSettingsStripStyleLabelCachedEntity() : base() { }

        public dxChartCommonAxisSettingsStripStyleLabelCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}

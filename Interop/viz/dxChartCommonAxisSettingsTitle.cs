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

    interface dxChartCommonAxisSettingsTitle : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxChartCommonAxisSettingsTitleCachedEntity>))]
    class dxChartCommonAxisSettingsTitleCachedEntity : CachedEntityObject, dxChartCommonAxisSettingsTitle
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
        
        public CachedEntity alignment
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "alignment",
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
                    "alignment",
                    value
                );
            }
        }

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

        
        public decimal margin
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "margin"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "margin",
                    value
                );
            }
        }

        
        public CachedEntity textOverflow
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "textOverflow",
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
                    "textOverflow",
                    value
                );
            }
        }

        
        public CachedEntity wordWrap
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "wordWrap",
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
                    "wordWrap",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public dxChartCommonAxisSettingsTitleCachedEntity() : base() { }

        public dxChartCommonAxisSettingsTitleCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}

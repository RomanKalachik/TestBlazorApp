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

    interface dxChartCommonPaneSettings : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxChartCommonPaneSettingsCachedEntity>))]
    class dxChartCommonPaneSettingsCachedEntity : CachedEntityObject, dxChartCommonPaneSettings
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
        
        public string backgroundColor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "backgroundColor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "backgroundColor",
                    value
                );
            }
        }

        
        public CachedEntity border
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "border",
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
                    "border",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public dxChartCommonPaneSettingsCachedEntity() : base() { }

        public dxChartCommonPaneSettingsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}

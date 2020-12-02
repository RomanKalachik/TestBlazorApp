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

    interface dxPolarChartCommonSeriesSettings : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxPolarChartCommonSeriesSettingsCachedEntity>))]
    class dxPolarChartCommonSeriesSettingsCachedEntity : CachedEntityObject, dxPolarChartCommonSeriesSettings
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
        
        public CachedEntity area
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "area",
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
                    "area",
                    value
                );
            }
        }

        
        public CachedEntity bar
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "bar",
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
                    "bar",
                    value
                );
            }
        }

        
        public CachedEntity line
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "line",
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
                    "line",
                    value
                );
            }
        }

        
        public CachedEntity scatter
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "scatter",
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
                    "scatter",
                    value
                );
            }
        }

        
        public CachedEntity stackedbar
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "stackedbar",
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
                    "stackedbar",
                    value
                );
            }
        }

        
        public CachedEntity type
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "type",
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
                    "type",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public dxPolarChartCommonSeriesSettingsCachedEntity() : base() { }

        public dxPolarChartCommonSeriesSettingsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}

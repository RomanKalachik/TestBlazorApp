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

    interface dxChartValueAxisLabel : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxChartValueAxisLabelCachedEntity>))]
    class dxChartValueAxisLabelCachedEntity : CachedEntityObject, dxChartValueAxisLabel
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
        private format __format;
        public format format
        {
            get
            {
            if(__format == null)
            {
                __format = EventHorizonBlazorInterop.GetClass<format>(
                    this.___guid,
                    "format",
                    (entity) =>
                    {
                        return new format() { ___guid = entity.___guid };
                    }
                );
            }
            return __format;
            }
            set
            {
__format = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "format",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public dxChartValueAxisLabelCachedEntity() : base() { }

        public dxChartValueAxisLabelCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public Date customizeHint()
        {
            return EventHorizonBlazorInterop.FuncClass<Date>(
                entity => new Date() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "customizeHint" }
                }
            );
        }

        public Date customizeText()
        {
            return EventHorizonBlazorInterop.FuncClass<Date>(
                entity => new Date() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "customizeText" }
                }
            );
        }
        #endregion
    }
}

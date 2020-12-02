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

    interface dxChartArgumentAxisConstantLineStyle : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxChartArgumentAxisConstantLineStyleCachedEntity>))]
    class dxChartArgumentAxisConstantLineStyleCachedEntity : CachedEntityObject, dxChartArgumentAxisConstantLineStyle
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
        private dxChartArgumentAxisConstantLineStyleLabelCachedEntity __label;
        public dxChartArgumentAxisConstantLineStyleLabelCachedEntity label
        {
            get
            {
            if(__label == null)
            {
                __label = EventHorizonBlazorInterop.GetClass<dxChartArgumentAxisConstantLineStyleLabelCachedEntity>(
                    this.___guid,
                    "label",
                    (entity) =>
                    {
                        return new dxChartArgumentAxisConstantLineStyleLabelCachedEntity() { ___guid = entity.___guid };
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
        #endregion
        
        #region Constructor
        public dxChartArgumentAxisConstantLineStyleCachedEntity() : base() { }

        public dxChartArgumentAxisConstantLineStyleCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}

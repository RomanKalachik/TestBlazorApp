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

    interface dxChartValueAxisConstantLineStyle : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxChartValueAxisConstantLineStyleCachedEntity>))]
    class dxChartValueAxisConstantLineStyleCachedEntity : CachedEntityObject, dxChartValueAxisConstantLineStyle
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
        private dxChartValueAxisConstantLineStyleLabelCachedEntity __label;
        public dxChartValueAxisConstantLineStyleLabelCachedEntity label
        {
            get
            {
            if(__label == null)
            {
                __label = EventHorizonBlazorInterop.GetClass<dxChartValueAxisConstantLineStyleLabelCachedEntity>(
                    this.___guid,
                    "label",
                    (entity) =>
                    {
                        return new dxChartValueAxisConstantLineStyleLabelCachedEntity() { ___guid = entity.___guid };
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
        public dxChartValueAxisConstantLineStyleCachedEntity() : base() { }

        public dxChartValueAxisConstantLineStyleCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}

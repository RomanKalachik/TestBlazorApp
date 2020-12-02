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

    interface dxPolarChartValueAxis : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxPolarChartValueAxisCachedEntity>))]
    class dxPolarChartValueAxisCachedEntity : CachedEntityObject, dxPolarChartValueAxis
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
        
        public decimal axisDivisionFactor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "axisDivisionFactor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "axisDivisionFactor",
                    value
                );
            }
        }

        
        public decimal[] categories
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "categories"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "categories",
                    value
                );
            }
        }

        
        public dxPolarChartValueAxisConstantLinesCachedEntity[] constantLines
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<dxPolarChartValueAxisConstantLinesCachedEntity>(
                    this.___guid,
                    "constantLines",
                    (entity) =>
                    {
                        return new dxPolarChartValueAxisConstantLinesCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "constantLines",
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

        private dxPolarChartValueAxisLabelCachedEntity __label;
        public dxPolarChartValueAxisLabelCachedEntity label
        {
            get
            {
            if(__label == null)
            {
                __label = EventHorizonBlazorInterop.GetClass<dxPolarChartValueAxisLabelCachedEntity>(
                    this.___guid,
                    "label",
                    (entity) =>
                    {
                        return new dxPolarChartValueAxisLabelCachedEntity() { ___guid = entity.___guid };
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

        
        public decimal linearThreshold
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "linearThreshold"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "linearThreshold",
                    value
                );
            }
        }

        
        public decimal logarithmBase
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "logarithmBase"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "logarithmBase",
                    value
                );
            }
        }

        
        public decimal maxValueMargin
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxValueMargin"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxValueMargin",
                    value
                );
            }
        }

        
        public decimal minValueMargin
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "minValueMargin"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "minValueMargin",
                    value
                );
            }
        }

        
        public decimal minVisualRangeLength
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "minVisualRangeLength"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "minVisualRangeLength",
                    value
                );
            }
        }

        
        public decimal minorTickCount
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "minorTickCount"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "minorTickCount",
                    value
                );
            }
        }

        
        public decimal minorTickInterval
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "minorTickInterval"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "minorTickInterval",
                    value
                );
            }
        }

        
        public bool showZero
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "showZero"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "showZero",
                    value
                );
            }
        }

        
        public dxPolarChartValueAxisStripsCachedEntity[] strips
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<dxPolarChartValueAxisStripsCachedEntity>(
                    this.___guid,
                    "strips",
                    (entity) =>
                    {
                        return new dxPolarChartValueAxisStripsCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "strips",
                    value
                );
            }
        }

        private dxPolarChartValueAxisTickCachedEntity __tick;
        public dxPolarChartValueAxisTickCachedEntity tick
        {
            get
            {
            if(__tick == null)
            {
                __tick = EventHorizonBlazorInterop.GetClass<dxPolarChartValueAxisTickCachedEntity>(
                    this.___guid,
                    "tick",
                    (entity) =>
                    {
                        return new dxPolarChartValueAxisTickCachedEntity() { ___guid = entity.___guid };
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

        
        public decimal tickInterval
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tickInterval"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tickInterval",
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

        
        public bool valueMarginsEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "valueMarginsEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "valueMarginsEnabled",
                    value
                );
            }
        }

        
        public CachedEntity valueType
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "valueType",
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
                    "valueType",
                    value
                );
            }
        }

        
        public decimal visualRange
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "visualRange"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "visualRange",
                    value
                );
            }
        }

        
        public CachedEntity visualRangeUpdateMode
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "visualRangeUpdateMode",
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
                    "visualRangeUpdateMode",
                    value
                );
            }
        }

        
        public decimal wholeRange
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "wholeRange"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "wholeRange",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public dxPolarChartValueAxisCachedEntity() : base() { }

        public dxPolarChartValueAxisCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}

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

    interface dxChartValueAxis : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxChartValueAxisCachedEntity>))]
    class dxChartValueAxisCachedEntity : CachedEntityObject, dxChartValueAxis
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
        
        public bool autoBreaksEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoBreaksEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoBreaksEnabled",
                    value
                );
            }
        }

        
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

        
        public ScaleBreakCachedEntity[] breaks
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<ScaleBreakCachedEntity>(
                    this.___guid,
                    "breaks",
                    (entity) =>
                    {
                        return new ScaleBreakCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "breaks",
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

        private dxChartValueAxisConstantLineStyleCachedEntity __constantLineStyle;
        public dxChartValueAxisConstantLineStyleCachedEntity constantLineStyle
        {
            get
            {
            if(__constantLineStyle == null)
            {
                __constantLineStyle = EventHorizonBlazorInterop.GetClass<dxChartValueAxisConstantLineStyleCachedEntity>(
                    this.___guid,
                    "constantLineStyle",
                    (entity) =>
                    {
                        return new dxChartValueAxisConstantLineStyleCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __constantLineStyle;
            }
            set
            {
__constantLineStyle = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "constantLineStyle",
                    value
                );
            }
        }

        
        public dxChartValueAxisConstantLinesCachedEntity[] constantLines
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<dxChartValueAxisConstantLinesCachedEntity>(
                    this.___guid,
                    "constantLines",
                    (entity) =>
                    {
                        return new dxChartValueAxisConstantLinesCachedEntity() { ___guid = entity.___guid };
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

        
        public decimal customPosition
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "customPosition"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "customPosition",
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

        private dxChartValueAxisLabelCachedEntity __label;
        public dxChartValueAxisLabelCachedEntity label
        {
            get
            {
            if(__label == null)
            {
                __label = EventHorizonBlazorInterop.GetClass<dxChartValueAxisLabelCachedEntity>(
                    this.___guid,
                    "label",
                    (entity) =>
                    {
                        return new dxChartValueAxisLabelCachedEntity() { ___guid = entity.___guid };
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

        
        public decimal max
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "max"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "max",
                    value
                );
            }
        }

        
        public decimal maxAutoBreakCount
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxAutoBreakCount"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxAutoBreakCount",
                    value
                );
            }
        }

        
        public decimal min
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "min"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "min",
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

        
        public decimal multipleAxesSpacing
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "multipleAxesSpacing"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "multipleAxesSpacing",
                    value
                );
            }
        }

        
        public string name
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
            }
        }

        
        public decimal offset
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "offset"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "offset",
                    value
                );
            }
        }

        
        public string pane
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "pane"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pane",
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

        
        public dxChartValueAxisStripsCachedEntity[] strips
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<dxChartValueAxisStripsCachedEntity>(
                    this.___guid,
                    "strips",
                    (entity) =>
                    {
                        return new dxChartValueAxisStripsCachedEntity() { ___guid = entity.___guid };
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

        
        public decimal synchronizedValue
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "synchronizedValue"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "synchronizedValue",
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

        private dxChartValueAxisTitleCachedEntity __title;
        public dxChartValueAxisTitleCachedEntity title
        {
            get
            {
            if(__title == null)
            {
                __title = EventHorizonBlazorInterop.GetClass<dxChartValueAxisTitleCachedEntity>(
                    this.___guid,
                    "title",
                    (entity) =>
                    {
                        return new dxChartValueAxisTitleCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __title;
            }
            set
            {
__title = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "title",
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
        public dxChartValueAxisCachedEntity() : base() { }

        public dxChartValueAxisCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}

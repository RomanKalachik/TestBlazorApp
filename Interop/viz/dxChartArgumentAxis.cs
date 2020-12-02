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

    interface dxChartArgumentAxis : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxChartArgumentAxisCachedEntity>))]
    class dxChartArgumentAxisCachedEntity : CachedEntityObject, dxChartArgumentAxis
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
        
        public bool aggregateByCategory
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "aggregateByCategory"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "aggregateByCategory",
                    value
                );
            }
        }

        
        public decimal aggregationGroupWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "aggregationGroupWidth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "aggregationGroupWidth",
                    value
                );
            }
        }

        
        public decimal aggregationInterval
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "aggregationInterval"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "aggregationInterval",
                    value
                );
            }
        }

        
        public CachedEntity argumentType
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "argumentType",
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
                    "argumentType",
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

        private dxChartArgumentAxisConstantLineStyleCachedEntity __constantLineStyle;
        public dxChartArgumentAxisConstantLineStyleCachedEntity constantLineStyle
        {
            get
            {
            if(__constantLineStyle == null)
            {
                __constantLineStyle = EventHorizonBlazorInterop.GetClass<dxChartArgumentAxisConstantLineStyleCachedEntity>(
                    this.___guid,
                    "constantLineStyle",
                    (entity) =>
                    {
                        return new dxChartArgumentAxisConstantLineStyleCachedEntity() { ___guid = entity.___guid };
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

        
        public dxChartArgumentAxisConstantLinesCachedEntity[] constantLines
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<dxChartArgumentAxisConstantLinesCachedEntity>(
                    this.___guid,
                    "constantLines",
                    (entity) =>
                    {
                        return new dxChartArgumentAxisConstantLinesCachedEntity() { ___guid = entity.___guid };
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

        
        public string customPositionAxis
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "customPositionAxis"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "customPositionAxis",
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

        private Date __holidays;
        public Date holidays
        {
            get
            {
            if(__holidays == null)
            {
                __holidays = EventHorizonBlazorInterop.GetClass<Date>(
                    this.___guid,
                    "holidays",
                    (entity) =>
                    {
                        return new Date() { ___guid = entity.___guid };
                    }
                );
            }
            return __holidays;
            }
            set
            {
__holidays = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "holidays",
                    value
                );
            }
        }

        
        public CachedEntity hoverMode
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "hoverMode",
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
                    "hoverMode",
                    value
                );
            }
        }

        private dxChartArgumentAxisLabelCachedEntity __label;
        public dxChartArgumentAxisLabelCachedEntity label
        {
            get
            {
            if(__label == null)
            {
                __label = EventHorizonBlazorInterop.GetClass<dxChartArgumentAxisLabelCachedEntity>(
                    this.___guid,
                    "label",
                    (entity) =>
                    {
                        return new dxChartArgumentAxisLabelCachedEntity() { ___guid = entity.___guid };
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

        private Date __singleWorkdays;
        public Date singleWorkdays
        {
            get
            {
            if(__singleWorkdays == null)
            {
                __singleWorkdays = EventHorizonBlazorInterop.GetClass<Date>(
                    this.___guid,
                    "singleWorkdays",
                    (entity) =>
                    {
                        return new Date() { ___guid = entity.___guid };
                    }
                );
            }
            return __singleWorkdays;
            }
            set
            {
__singleWorkdays = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "singleWorkdays",
                    value
                );
            }
        }

        
        public dxChartArgumentAxisStripsCachedEntity[] strips
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<dxChartArgumentAxisStripsCachedEntity>(
                    this.___guid,
                    "strips",
                    (entity) =>
                    {
                        return new dxChartArgumentAxisStripsCachedEntity() { ___guid = entity.___guid };
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

        private dxChartArgumentAxisTitleCachedEntity __title;
        public dxChartArgumentAxisTitleCachedEntity title
        {
            get
            {
            if(__title == null)
            {
                __title = EventHorizonBlazorInterop.GetClass<dxChartArgumentAxisTitleCachedEntity>(
                    this.___guid,
                    "title",
                    (entity) =>
                    {
                        return new dxChartArgumentAxisTitleCachedEntity() { ___guid = entity.___guid };
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

        
        public decimal[] workWeek
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "workWeek"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "workWeek",
                    value
                );
            }
        }

        
        public bool workdaysOnly
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "workdaysOnly"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "workdaysOnly",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public dxChartArgumentAxisCachedEntity() : base() { }

        public dxChartArgumentAxisCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}

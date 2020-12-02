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

    interface dxPolarChartArgumentAxis : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxPolarChartArgumentAxisCachedEntity>))]
    class dxPolarChartArgumentAxisCachedEntity : CachedEntityObject, dxPolarChartArgumentAxis
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

        
        public dxPolarChartArgumentAxisConstantLinesCachedEntity[] constantLines
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<dxPolarChartArgumentAxisConstantLinesCachedEntity>(
                    this.___guid,
                    "constantLines",
                    (entity) =>
                    {
                        return new dxPolarChartArgumentAxisConstantLinesCachedEntity() { ___guid = entity.___guid };
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

        
        public bool firstPointOnStartAngle
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "firstPointOnStartAngle"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "firstPointOnStartAngle",
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

        private dxPolarChartArgumentAxisLabelCachedEntity __label;
        public dxPolarChartArgumentAxisLabelCachedEntity label
        {
            get
            {
            if(__label == null)
            {
                __label = EventHorizonBlazorInterop.GetClass<dxPolarChartArgumentAxisLabelCachedEntity>(
                    this.___guid,
                    "label",
                    (entity) =>
                    {
                        return new dxPolarChartArgumentAxisLabelCachedEntity() { ___guid = entity.___guid };
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

        private dxPolarChartArgumentAxisMinorTickCachedEntity __minorTick;
        public dxPolarChartArgumentAxisMinorTickCachedEntity minorTick
        {
            get
            {
            if(__minorTick == null)
            {
                __minorTick = EventHorizonBlazorInterop.GetClass<dxPolarChartArgumentAxisMinorTickCachedEntity>(
                    this.___guid,
                    "minorTick",
                    (entity) =>
                    {
                        return new dxPolarChartArgumentAxisMinorTickCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __minorTick;
            }
            set
            {
__minorTick = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "minorTick",
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

        
        public decimal originValue
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "originValue"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "originValue",
                    value
                );
            }
        }

        
        public decimal period
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "period"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "period",
                    value
                );
            }
        }

        
        public decimal startAngle
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "startAngle"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "startAngle",
                    value
                );
            }
        }

        
        public dxPolarChartArgumentAxisStripsCachedEntity[] strips
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<dxPolarChartArgumentAxisStripsCachedEntity>(
                    this.___guid,
                    "strips",
                    (entity) =>
                    {
                        return new dxPolarChartArgumentAxisStripsCachedEntity() { ___guid = entity.___guid };
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

        private dxPolarChartArgumentAxisTickCachedEntity __tick;
        public dxPolarChartArgumentAxisTickCachedEntity tick
        {
            get
            {
            if(__tick == null)
            {
                __tick = EventHorizonBlazorInterop.GetClass<dxPolarChartArgumentAxisTickCachedEntity>(
                    this.___guid,
                    "tick",
                    (entity) =>
                    {
                        return new dxPolarChartArgumentAxisTickCachedEntity() { ___guid = entity.___guid };
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
        #endregion
        
        #region Constructor
        public dxPolarChartArgumentAxisCachedEntity() : base() { }

        public dxPolarChartArgumentAxisCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}

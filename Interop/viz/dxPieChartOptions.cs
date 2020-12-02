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

    interface dxPieChartOptions : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxPieChartOptionsCachedEntity>))]
    class dxPieChartOptionsCachedEntity : CachedEntityObject, dxPieChartOptions
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
        private dxPieChartAdaptiveLayoutCachedEntity __adaptiveLayout;
        public dxPieChartAdaptiveLayoutCachedEntity adaptiveLayout
        {
            get
            {
            if(__adaptiveLayout == null)
            {
                __adaptiveLayout = EventHorizonBlazorInterop.GetClass<dxPieChartAdaptiveLayoutCachedEntity>(
                    this.___guid,
                    "adaptiveLayout",
                    (entity) =>
                    {
                        return new dxPieChartAdaptiveLayoutCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __adaptiveLayout;
            }
            set
            {
__adaptiveLayout = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "adaptiveLayout",
                    value
                );
            }
        }

        
        public string centerTemplate
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "centerTemplate"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "centerTemplate",
                    value
                );
            }
        }

        
        public CachedEntity commonSeriesSettings
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "commonSeriesSettings",
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
                    "commonSeriesSettings",
                    value
                );
            }
        }

        
        public decimal diameter
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "diameter"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "diameter",
                    value
                );
            }
        }

        
        public decimal innerRadius
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "innerRadius"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "innerRadius",
                    value
                );
            }
        }

        private dxPieChartLegendCachedEntity __legend;
        public dxPieChartLegendCachedEntity legend
        {
            get
            {
            if(__legend == null)
            {
                __legend = EventHorizonBlazorInterop.GetClass<dxPieChartLegendCachedEntity>(
                    this.___guid,
                    "legend",
                    (entity) =>
                    {
                        return new dxPieChartLegendCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __legend;
            }
            set
            {
__legend = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "legend",
                    value
                );
            }
        }

        
        public decimal minDiameter
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "minDiameter"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "minDiameter",
                    value
                );
            }
        }

        
        public string[] palette
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<string>(
                    this.___guid,
                    "palette"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "palette",
                    value
                );
            }
        }

        
        public CachedEntity resolveLabelOverlapping
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "resolveLabelOverlapping",
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
                    "resolveLabelOverlapping",
                    value
                );
            }
        }

        
        public CachedEntity segmentsDirection
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "segmentsDirection",
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
                    "segmentsDirection",
                    value
                );
            }
        }

        private PieChartSeriesCachedEntity __series;
        public PieChartSeriesCachedEntity series
        {
            get
            {
            if(__series == null)
            {
                __series = EventHorizonBlazorInterop.GetClass<PieChartSeriesCachedEntity>(
                    this.___guid,
                    "series",
                    (entity) =>
                    {
                        return new PieChartSeriesCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __series;
            }
            set
            {
__series = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "series",
                    value
                );
            }
        }

        
        public CachedEntity seriesTemplate
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "seriesTemplate",
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
                    "seriesTemplate",
                    value
                );
            }
        }

        
        public string sizeGroup
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "sizeGroup"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sizeGroup",
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
        public dxPieChartOptionsCachedEntity() : base() { }

        public dxPieChartOptionsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public string onLegendClick()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "onLegendClick" }
                }
            );
        }
        #endregion
    }
}

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

    interface dxPolarChartArgumentAxisConstantLines : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxPolarChartArgumentAxisConstantLinesCachedEntity>))]
    class dxPolarChartArgumentAxisConstantLinesCachedEntity : CachedEntityObject, dxPolarChartArgumentAxisConstantLines
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
        
        public bool displayBehindSeries
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "displayBehindSeries"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "displayBehindSeries",
                    value
                );
            }
        }

        
        public bool extendAxis
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "extendAxis"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "extendAxis",
                    value
                );
            }
        }

        private dxPolarChartArgumentAxisConstantLinesLabelCachedEntity __label;
        public dxPolarChartArgumentAxisConstantLinesLabelCachedEntity label
        {
            get
            {
            if(__label == null)
            {
                __label = EventHorizonBlazorInterop.GetClass<dxPolarChartArgumentAxisConstantLinesLabelCachedEntity>(
                    this.___guid,
                    "label",
                    (entity) =>
                    {
                        return new dxPolarChartArgumentAxisConstantLinesLabelCachedEntity() { ___guid = entity.___guid };
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

        
        public decimal value
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "value"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "value",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public dxPolarChartArgumentAxisConstantLinesCachedEntity() : base() { }

        public dxPolarChartArgumentAxisConstantLinesCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}

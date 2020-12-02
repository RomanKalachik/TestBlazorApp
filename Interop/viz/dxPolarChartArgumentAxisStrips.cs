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

    interface dxPolarChartArgumentAxisStrips : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxPolarChartArgumentAxisStripsCachedEntity>))]
    class dxPolarChartArgumentAxisStripsCachedEntity : CachedEntityObject, dxPolarChartArgumentAxisStrips
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
        
        public string color
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "color"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "color",
                    value
                );
            }
        }

        
        public decimal endValue
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "endValue"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "endValue",
                    value
                );
            }
        }

        private dxPolarChartArgumentAxisStripsLabelCachedEntity __label;
        public dxPolarChartArgumentAxisStripsLabelCachedEntity label
        {
            get
            {
            if(__label == null)
            {
                __label = EventHorizonBlazorInterop.GetClass<dxPolarChartArgumentAxisStripsLabelCachedEntity>(
                    this.___guid,
                    "label",
                    (entity) =>
                    {
                        return new dxPolarChartArgumentAxisStripsLabelCachedEntity() { ___guid = entity.___guid };
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

        
        public decimal startValue
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "startValue"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "startValue",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public dxPolarChartArgumentAxisStripsCachedEntity() : base() { }

        public dxPolarChartArgumentAxisStripsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}

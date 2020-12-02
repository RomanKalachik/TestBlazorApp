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

    interface dxChartArgumentAxisStrips : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxChartArgumentAxisStripsCachedEntity>))]
    class dxChartArgumentAxisStripsCachedEntity : CachedEntityObject, dxChartArgumentAxisStrips
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

        private dxChartArgumentAxisStripsLabelCachedEntity __label;
        public dxChartArgumentAxisStripsLabelCachedEntity label
        {
            get
            {
            if(__label == null)
            {
                __label = EventHorizonBlazorInterop.GetClass<dxChartArgumentAxisStripsLabelCachedEntity>(
                    this.___guid,
                    "label",
                    (entity) =>
                    {
                        return new dxChartArgumentAxisStripsLabelCachedEntity() { ___guid = entity.___guid };
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
        public dxChartArgumentAxisStripsCachedEntity() : base() { }

        public dxChartArgumentAxisStripsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}

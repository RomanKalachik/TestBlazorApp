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

    interface dxChartArgumentAxisConstantLinesLabel : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<dxChartArgumentAxisConstantLinesLabelCachedEntity>))]
    class dxChartArgumentAxisConstantLinesLabelCachedEntity : CachedEntityObject, dxChartArgumentAxisConstantLinesLabel
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
        
        public CachedEntity horizontalAlignment
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "horizontalAlignment",
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
                    "horizontalAlignment",
                    value
                );
            }
        }

        
        public string text
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "text"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "text",
                    value
                );
            }
        }

        
        public CachedEntity verticalAlignment
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "verticalAlignment",
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
                    "verticalAlignment",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public dxChartArgumentAxisConstantLinesLabelCachedEntity() : base() { }

        public dxChartArgumentAxisConstantLinesLabelCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}

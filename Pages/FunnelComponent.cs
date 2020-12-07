using DevExpress.Blazor.Internal;
using DevExpress.Blazor.Interop.Internal;
using DevExpress.viz;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.JSInterop;
using System;
using System.Linq;

namespace BlazorApp.Shared
{
    public partial class FunnelComponent : ComponentBase
    {
        readonly Guid _uniqueId = Guid.NewGuid();

        protected ElementReference MainElement { get; set; }

        protected override async void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);
            var di = await EnvironmentInfo.DeviceInfo;
            //var dxfo = EventHorizonBlazorInterop.GetClass<dxFunnelOptionsCachedEntity>(
            //    "getObject",
            //    "obj",
            //    (entity) =>
            //    {
            //        return new dxFunnelOptionsCachedEntity(entity);
            //    });
            //dxfo.argumentField = "Argument";
            //dxfo.valueField = "Value";
            //dxfo.dataSource = new DataInfo[]
            //{
            //    new DataInfo { Argument = "Visited the Website", Value = 9152 },
            //    new DataInfo { Argument = "Downloaded a Trial", Value = 6879 },
            //    new DataInfo { Argument = "Contacted Support", Value = 5121 },
            //    new DataInfo { Argument = "Subscribed", Value = 2224 },
            //    new DataInfo { Argument = "Renewed", Value = 1670 }
            //};
            await JsRuntime.InvokeVoidAsync(
                "DxBlazor.Funnel.init",
                MainElement,
                "",
                DotNetObjectReference.Create(this));
        }

        [Inject] protected IEnvironmentInfo EnvironmentInfo { get; set; }

        [Inject] protected IJSRuntime JsRuntime { get; set; }
    }

    class DataInfo : CachedEntity
    {
        public string Argument { get; set; }

        public int Value { get; set; }
    }
}
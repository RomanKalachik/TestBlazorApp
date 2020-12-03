using DevExpress.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Linq;

namespace BlazorApp.Shared
{
    public partial class CounterCompnent : ComponentBase
    {
        [Inject] protected IEnvironmentInfo EnvironmentInfo { get; set; }
        readonly Guid _uniqueId = Guid.NewGuid();
        protected sealed override void BuildRenderTree(RenderTreeBuilder builder)
        {
            BeforeBuildRenderTree(builder);
        }
        protected virtual void BeforeBuildRenderTree(RenderTreeBuilder builder)
        {
            EnvironmentInfo.RenderScriptLoader(builder, _uniqueId);

            builder.OpenElement(0, "div");
            builder.AddContent(1, "some test");
            builder.CloseElement();
        }
    }
}
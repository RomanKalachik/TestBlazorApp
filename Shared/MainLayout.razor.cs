using DevExpress.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Linq;

namespace BlazorApp.Shared
{
    public partial class MainLayout
    {
        [Inject] protected IEnvironmentInfo EnvironmentInfo { get; set; }
        readonly Guid _uniqueId = Guid.NewGuid();
        protected virtual void BeforeBuildRenderTree(RenderTreeBuilder builder)
        {
            EnvironmentInfo.RenderScriptLoader(builder, _uniqueId);
        }
    }
    public class MainLayoutEx : MainLayout {
        protected override void BuildRenderTree(RenderTreeBuilder __builder)
        {
            BeforeBuildRenderTree(__builder);
            base.BuildRenderTree(__builder);
        }
    }
}
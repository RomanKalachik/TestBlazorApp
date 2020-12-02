using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;

namespace DevExpress.Blazor.Internal {
    public abstract partial class ScriptModulesLoaderBase : ComponentBase, IAsyncDisposable {
        [Parameter] public virtual IEnvironmentInfo EnvironmentInfo { get; set; }
        [Parameter] public EventCallback RemovedFromDOM { get; set; }

        string _modulesBootstrapperPath;

        protected override void OnInitialized() {
            var sb = new StringBuilder();
            sb.Append(EnvironmentInfo.ResolveUrl("/dx-blazor.js"));
            AddScriptLoaderQueryParts(sb);
            _modulesBootstrapperPath = sb.ToString();
        }

        protected override void BuildRenderTree(RenderTreeBuilder builder) {
            builder.OpenElement(0, "script");
            builder.AddAttribute(1, "src", _modulesBootstrapperPath);
            builder.AddAttribute(2, "async", true);
            builder.AddAttribute(3, "onload", EventCallback.Factory.Create<ProgressEventArgs>(EnvironmentInfo, EnvironmentInfo.InitializeRuntime));
            builder.CloseElement();
        }

        public async ValueTask DisposeAsync() {
            try {
                await RemovedFromDOM.InvokeAsync(null);
            } catch { }
        }

        partial void AddScriptLoaderQueryParts(StringBuilder sb);
    }
}

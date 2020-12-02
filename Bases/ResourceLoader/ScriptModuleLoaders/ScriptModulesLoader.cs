using Microsoft.AspNetCore.Components;

namespace DevExpress.Blazor.Internal {
    public sealed class ScriptModulesLoader : ScriptModulesLoaderBase {
        [Inject] IEnvironmentInfo _environmentInfo { get; set; }
        public sealed override IEnvironmentInfo EnvironmentInfo { get => _environmentInfo; set => _environmentInfo = value; }
        protected override bool ShouldRender() {
            return false;
        }
    }
}

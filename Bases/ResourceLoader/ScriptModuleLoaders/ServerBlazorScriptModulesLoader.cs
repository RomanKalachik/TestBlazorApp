namespace DevExpress.Blazor.Internal {
    public sealed class ServerBlazorScriptModulesLoader : ScriptModulesLoaderBase {
        protected sealed override bool ShouldRender() {
            return false;
        }
    }
}

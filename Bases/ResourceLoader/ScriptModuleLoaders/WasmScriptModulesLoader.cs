namespace DevExpress.Blazor.Internal {
    public sealed class WasmScriptModulesLoader : ScriptModulesLoaderBase {
        protected sealed override bool ShouldRender() {
            return false;
        }
    }
}

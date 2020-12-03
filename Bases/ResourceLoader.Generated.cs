using System.Text;
namespace DevExpress.Blazor.Internal {
    public abstract partial class ScriptModulesLoaderBase {
        partial void AddScriptLoaderQueryParts(StringBuilder sb) {
            sb.Append("?version=");
            sb.Append("cjs25eb61ac.js");
            sb.Append("esm2faa4817.js");
        }
    }
}
using System.Text;
namespace DevExpress.Blazor.Internal {
    public abstract partial class ScriptModulesLoaderBase {
        partial void AddScriptLoaderQueryParts(StringBuilder sb) {
            sb.Append("?version=");
            sb.Append("cjse448d2b4.js");
            sb.Append("esm398a61b4.js");
        }
    }
}
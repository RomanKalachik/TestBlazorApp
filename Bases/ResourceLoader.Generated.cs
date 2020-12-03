using System.Text;
namespace DevExpress.Blazor.Internal {
    public abstract partial class ScriptModulesLoaderBase {
        partial void AddScriptLoaderQueryParts(StringBuilder sb) {
            sb.Append("?version=");
            sb.Append("cjs32f21716.js");
            sb.Append("esmd67ba9c3.js");
        }
    }
}
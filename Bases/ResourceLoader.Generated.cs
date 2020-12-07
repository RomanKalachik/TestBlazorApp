using System.Text;
namespace DevExpress.Blazor.Internal {
    public abstract partial class ScriptModulesLoaderBase {
        partial void AddScriptLoaderQueryParts(StringBuilder sb) {
            sb.Append("?version=");
            sb.Append("cjs745794f9.js");
            sb.Append("esm4d9dccdc.js");
        }
    }
}
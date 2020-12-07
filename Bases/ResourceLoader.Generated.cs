using System.Text;
namespace DevExpress.Blazor.Internal {
    public abstract partial class ScriptModulesLoaderBase {
        partial void AddScriptLoaderQueryParts(StringBuilder sb) {
            sb.Append("?version=");
            sb.Append("cjse12a0471.js");
            sb.Append("esma4c29f2a.js");
        }
    }
}
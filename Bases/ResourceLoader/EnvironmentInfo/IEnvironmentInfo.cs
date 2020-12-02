using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.JSInterop;

namespace DevExpress.Blazor.Internal {
    public interface IEnvironmentInfo : IDisposable {
        DateTime GetDateTimeNow();
        ValueTask<ApiScheme> ApiScheme { get; }
        ValueTask<DeviceInfo> DeviceInfo { get; }
        Task InitializeRuntime();
        void RenderScriptLoader(RenderTreeBuilder builder, Guid containerId);
        string ResolveUrl(string url);
        [JSInvokable] void OnMessage(int msg);
    }
}

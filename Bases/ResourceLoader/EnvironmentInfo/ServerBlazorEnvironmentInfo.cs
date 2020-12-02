using System;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace DevExpress.Blazor.Internal {
    public sealed class ServerBlazorEnvironmentInfo : EnvironmentInfoBase {
        public ServerBlazorEnvironmentInfo(NavigationManager navigationManager, IJSRuntime runtime) : base(navigationManager, runtime) { }
        private protected override Type ScriptLoaderComponentType => typeof(ServerBlazorScriptModulesLoader);
        public override void OnScriptLoaderRemovedFromDOM() {
            if(DeviceTcs.Task.IsCompleted || !IsLoaderRendered) return;
            IsLoaderRendered = false;
        }
    }
}

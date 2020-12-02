using System;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace DevExpress.Blazor.Internal {
    public sealed class WasmEnvironmentInfo : EnvironmentInfoBase {
        public WasmEnvironmentInfo(NavigationManager navigationManager, IJSRuntime runtime) : base(navigationManager, runtime) { }
        private protected override Type ScriptLoaderComponentType => typeof(WasmScriptModulesLoader);
        public override void OnScriptLoaderRemovedFromDOM() {
            if(DeviceTcs.Task.IsCompleted || !IsLoaderRendered) return;
            IsLoaderRendered = false;
        }
    }
}

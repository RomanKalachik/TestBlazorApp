using System;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;

namespace DevExpress.Blazor.Internal {
    public interface IEnvironmentInfoFactory {
        IEnvironmentInfo CreateEnvironmentInfo();
    }


    sealed class EnvironmentInfoFactory : IEnvironmentInfoFactory {
        readonly IServiceProvider _serviceProvider;
        public EnvironmentInfoFactory(IServiceProvider serviceProvider) {
            _serviceProvider = serviceProvider;
        }

        public IEnvironmentInfo CreateEnvironmentInfo() {
            switch(_serviceProvider.GetService<IJSRuntime>()) {
                case IJSInProcessRuntime runtime:
                    return new WasmEnvironmentInfo(_serviceProvider.GetService<NavigationManager>(), runtime);
                case IJSRuntime runtime:
                    return new ServerBlazorEnvironmentInfo(_serviceProvider.GetService<NavigationManager>(), runtime);
            }
            throw new NotImplementedException();
        }
    }
}

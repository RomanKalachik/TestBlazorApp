using System;
using System.ComponentModel;
using DevExpress.Blazor;
using DevExpress.Blazor.Internal;
using DevExpress.Blazor.Internal.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Microsoft.Extensions.DependencyInjection {
    public static class DevExpressServiceCollectionExtensions {
        public static void AddDevExpressBlazor(this IServiceCollection services) {
            services.TryAddScoped<IEnvironmentInfoFactory, EnvironmentInfoFactory>();
            services.TryAddScoped<IEnvironmentInfo>(ResolveEnvironmentInfo);
        }

        static IEnvironmentInfo ResolveEnvironmentInfo(IServiceProvider arg) {
            var factory = arg.GetService<IEnvironmentInfoFactory>();
            return factory.CreateEnvironmentInfo();
        }
    }
}


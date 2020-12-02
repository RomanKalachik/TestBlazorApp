using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace DevExpress.Blazor.Internal.Services {
    public interface IComponentServiceCollection {
        void AddComponentScopedService<T, TImpl>()
            where T : class, IComponentService
            where TImpl : class, T;
        void AddComponentTransientService<T, TImpl>()
            where T : class, IComponentService
            where TImpl : class, T;
    }
}


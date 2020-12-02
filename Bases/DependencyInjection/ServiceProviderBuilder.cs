using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace DevExpress.Blazor.Internal.Services {

    public interface IComponentServiceProviderBuilder {
        IComponentServiceProvider Build();
        IComponentServiceProvider Build<T>();
        IComponentServiceProvider Build<T, TComponent>();
    }
}
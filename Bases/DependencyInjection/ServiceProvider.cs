using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace DevExpress.Blazor.Internal.Services {
    public interface IComponentScope {
        bool IsDisposed { get; }
        CancellationToken Cancellation { get; }
    }

    public interface IComponentServiceProvider : IComponentScope, IServiceScope {
        T GetService<T>();
    }
}
namespace DevExpress.Blazor.Internal {
    using DevExpress.Blazor.Internal.Services;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.DependencyInjection.Extensions;

   

}

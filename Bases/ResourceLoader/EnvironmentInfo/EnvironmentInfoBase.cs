using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.JSInterop;

namespace DevExpress.Blazor.Internal {
    public abstract class EnvironmentInfoBase : IEnvironmentInfo, IHandleEvent {
        const int
            API_SCHEME_LOADED = 0,
            ORIENTATION_CHANGED = 1;// todo: support

        readonly NavigationManager _navigationManager;
        readonly IJSRuntime _runtime;
        readonly CancellationTokenSource _lifeTimeCts;
        readonly CancellationToken _cancellationToken;
        private protected readonly TaskCompletionSource<DeviceInfo> DeviceTcs;
        readonly TaskCompletionSource<ApiScheme> _apiSchemeTcs;

        bool _disposed;
        protected bool IsLoaderRendered { get; set; }
        Guid _containerId;
        DotNetObjectReference<IEnvironmentInfo> _interopReference;

        private protected EnvironmentInfoBase(NavigationManager navigationManager, IJSRuntime runtime) {
            _navigationManager = navigationManager;
            _runtime = runtime;
            _lifeTimeCts = new CancellationTokenSource();
            _cancellationToken = _lifeTimeCts.Token;

            _apiSchemeTcs = new TaskCompletionSource<ApiScheme>(TaskCreationOptions.RunContinuationsAsynchronously);
            DeviceTcs = new TaskCompletionSource<DeviceInfo>(TaskCreationOptions.RunContinuationsAsynchronously);
        }


        public ValueTask<DeviceInfo> DeviceInfo => TryReturnCompleted(DeviceTcs.Task);
        public DateTime GetDateTimeNow() {
            return DateTime.Now;
        }

        public ValueTask<ApiScheme> ApiScheme => TryReturnCompleted(_apiSchemeTcs.Task);

        public async Task InitializeRuntime() {
            // TODO: replace on media queries
            if(DeviceTcs.Task.IsCompleted || _interopReference != null) return;

            _interopReference = DotNetObjectReference.Create<IEnvironmentInfo>(this);
            var deviceInfo = _runtime.InvokeAsync<DeviceInfo>("DxBlazorInternal", _cancellationToken, _interopReference, ResolveUrl("/"), "DxBlazor");
            try {
                var result = await deviceInfo;
                DeviceTcs.TrySetResult(result);
            } catch {
                if(!deviceInfo.IsCanceled)
                    throw;
            }
        }

        public void RenderScriptLoader(RenderTreeBuilder builder, Guid containerId) {
            if(IsLoaderRendered && _containerId != containerId) return;
            if(!IsLoaderRendered) {
                _navigationManager.LocationChanged += OnLocationChanged;
                IsLoaderRendered = true;
                _containerId = containerId;
            }

            builder.OpenComponent(0, ScriptLoaderComponentType);
            builder.AddAttribute(1, nameof(ScriptModulesLoaderBase.EnvironmentInfo), this);
            builder.AddAttribute(2, nameof(ScriptModulesLoaderBase.RemovedFromDOM), EventCallback.Factory.Create(this, OnScriptLoaderRemovedFromDOM));
            builder.CloseComponent();
        }

        public string ResolveUrl(string resourceUrl) {
            resourceUrl = _navigationManager.BaseUri + resourceUrl;
            resourceUrl = _navigationManager.ToBaseRelativePath(resourceUrl);
            return _navigationManager.ToAbsoluteUri(resourceUrl).PathAndQuery;
        }


        public Task HandleEventAsync(EventCallbackWorkItem item, object arg) {
            return item.InvokeAsync(arg);
        }


        [JSInvokable]
        public void OnMessage(int msg) {
            switch(msg) {
                case API_SCHEME_LOADED:
                    _apiSchemeTcs.TrySetResult(new ApiScheme(true));
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        public void Dispose() {
            try {
                if(_disposed) return;
                _disposed = true;
                _apiSchemeTcs.TrySetCanceled();
                DeviceTcs.TrySetCanceled();
                _interopReference?.Dispose();
                _interopReference = null;
                _navigationManager.LocationChanged -= OnLocationChanged;
                _lifeTimeCts.Cancel();
                _lifeTimeCts.Dispose();
            } catch { }
        }

        private protected abstract Type ScriptLoaderComponentType { get; }

        static ValueTask<T> TryReturnCompleted<T>(Task<T> task) {
            if(task.IsCompletedSuccessfully) return new ValueTask<T>(task.Result);
            return task.IsCompleted ? new ValueTask<T>(task) : GetAwaiter();

            async ValueTask<T> GetAwaiter() => await task.ConfigureAwait(false);
        }

        public abstract void OnScriptLoaderRemovedFromDOM();

        void OnLocationChanged(object sender, LocationChangedEventArgs e) {
            if(!e.IsNavigationIntercepted) {
                _navigationManager.LocationChanged -= OnLocationChanged;
                OnScriptLoaderRemovedFromDOM();
            }
        }
    }
}

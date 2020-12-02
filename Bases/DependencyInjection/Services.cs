using System;

namespace DevExpress.Blazor.Internal.Services {

    public interface IComponentService : IDisposable {
        public void AfterDependenciesResolved() { }
        public void OnServiceDispose() { }

        protected virtual void Dispose(bool disposing) {
            OnServiceDispose();
        }
        void IDisposable.Dispose() {
            try {
                Dispose(true);
            } catch { }
        }
    }

}

export function loader(entryName, _dx) {
    function resolveId(id) { return id.indexOf("./") === 0 ? id.substring(2) : id; }
    function moduleContainerBuilder(importScript) {
        return getOrAddModule;

        function getOrAddModule(id) { return moduleContainerBuilder[id] || (moduleContainerBuilder[id] = new ModuleWrapper(id)); }

        function ModuleWrapper(id) {
            function createExportsPromise(d) {
                const exportsObject = d[1];
                const result = Promise.resolve(exportsObject);
                Object.keys(exportsObject).forEach(function(k) {
                    Object.defineProperty(result, k, { get: function() { return exportsObject[k]; } });
                });
                return result;
            }
            function addResolveOnInitialize(resolve) {
                this.initialize = function(impl) { impl.then(resolve); };
            }
            const resourceReady = importScript("modules/" + resolveId(id));
            const exportsReady = new Promise(addResolveOnInitialize.bind(this));
            const moduleReady = Promise.all([resourceReady, exportsReady]).then(createExportsPromise);
            this.getPromise = function() { return moduleReady; };
        }
    }

    const moduleContainer = moduleContainerBuilder(_dx.importScript);

    function requireInPrefetched(prefetched) {
        return function(id) {
            id = resolveId(id);
            return prefetched.filter(function(r) { return r.id === id; })[0] || require(id);
        };
    }
    function buildModule(id, builder, relatedImports) {
        const allImports = Promise.all(relatedImports.map(require));
        return allImports.then(function(prefetched) {
            const _module = { exports: {} };
            builder(requireInPrefetched(prefetched), _module, _module.exports);
            _module.exports.id = id;
            return Promise.resolve(Object.freeze(_module.exports));
        });
    }

    function require(id) { return moduleContainer(id).getPromise(); }

    if(!window.NodeList.prototype.forEach) window.NodeList.prototype.forEach = Array.prototype.forEach;

    _dx.define = function(id, builder, imports) { moduleContainer(id).initialize(buildModule(id, builder, imports)); };

    require(entryName).then(_dx[_dx]);
}

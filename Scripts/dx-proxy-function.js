export function createInvoker(resolveImporter) {
    return function invoke(name, args) {
        args = Array.prototype.slice.call(args);
        return resolveImporter().then(function(m) {
            const result = m.default[name].apply(m, args);
            return result && result.then ? result : Promise.resolve();
        });
    };
}

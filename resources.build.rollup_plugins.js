const path = require("path");
const fs = require("fs");
const buble = require('buble');

const terserModule = require("terser");

const minifyOptions = {
        mangle: {
            module: true,
            toplevel: true
        },
        compress: {
            drop_debugger: true,
            drop_console: true,
            pure_getters: true,
            toplevel: true,
            side_effects: false,
            warnings: true,
            module: true
        }
    };
const es5Config = {
    namedFunctionExpressions: false,
    transforms: { modules: false, classes: true }
};

function minify(code, canMinify) {
    return canMinify ? terserModule.minify(code, minifyOptions).code : code;
}
function toES5(code) {
    return buble.transform(code, es5Config).code;
}
function wrapInDefine(chunk, code) {
    return "DxBlazorInternal.define('" + chunk.fileName + "', function(require, module, exports) {" +
        code + "}," + JSON.stringify(chunk.imports) + ");";
}

module.exports = {
    minify: minify,
    prepareModules: function(canMinify, es5format, externalModule) {
        return {
            renderChunk(source, chunk, outputOptions) {
                var code = undefined;
                if(outputOptions.format === es5format) {
                    if(chunk.name !== externalModule)
                        code = toES5(source);
                    code = wrapInDefine(chunk, code || source);
                }
                if(canMinify && chunk.name !== externalModule)
                    code = minify(code || source, canMinify);
                return code;
            }
        };
    },
    inject_viz: function (name, globalName) {
        var fileUrl;
        return {
            resolveId: function (id, importer) {
                if(id === name)
                    return fileUrl = path.resolve(path.dirname(importer), id) + ".js";
            },
            load: function(id) {
                if(id == fileUrl)
                    return { code: "", map: { mappings: '' } };
            },
            renderChunk: function(source, chunk, outputOptions) {
                if(chunk.name == name) {
                    var realCode = "var DevExpress = " + globalName + " = " + globalName + " || {};\n";
                    realCode += fs.readFileSync(path.resolve(path.dirname(fileUrl), "./external/devexpress.viz.js"));
                    if(outputOptions.format === "cjs")
                        realCode += "\nexports.viz = DevExpress.viz;";
                    else
                        realCode += "\nvar viz = DevExpress.viz;\nexport { viz };";
                    return { code: realCode, map: { mappings: '' } };
                }
            }
        }
    },
    lazy_api: function (rootId, onEntryChunkReady) {
        var rootFileUrl = path.resolve(rootId);
        var proxyModules = {};

        function processExports(id, astBlock, buffer, stack) {
            var defaultExport = astBlock.body.filter(b => b.type === "ExportDefaultDeclaration")[0];
            if(!defaultExport)
                throw new Error("API: Dont export modules without default export!");

            var exportMembers = defaultExport.declaration.properties.map(p => p.key.name);
            buffer.push('import { createInvoker } from "./dx-proxy-function";');
            buffer.push("const invoke = createInvoker(function() { return import(\"" + id + "\"); });");
            for (let index = 0; index < exportMembers.length; index++) {
                const name = exportMembers[index];
                buffer.push("function " + name + "(){ return invoke(\"" + name + "\", arguments); }");
            }
            buffer.push("export default { " + exportMembers.join(", ") + " };");
        }
        return {
            load(id) {
                if (proxyModules[id]) {
                    var realModule = this.parse(fs.readFileSync(proxyModules[id].path));
                    var codelines = [];
                    processExports(proxyModules[id].id, realModule, codelines, []);
                    var code = codelines.join("\r\n");
                    var ast = this.parse(code);
                    return { code: code, ast: ast, map: null };
                }
            },
            generateBundle(options, bundle) {
                for (var moduleName in bundle) {
                    var module = bundle[moduleName];
                    if (module.facadeModuleId === rootFileUrl) {
                        onEntryChunkReady(options.format === "cjs" ? "cjs" : "esm", module.fileName);
                        break;
                    }
                }
            },
            resolveId(id, importer) {
                if (importer === rootFileUrl) {
                    var proxyId = id + "_proxy";
                    proxyModules[proxyId] = { path: path.resolve(path.dirname(importer), id) + ".js", id: id };
                    return proxyId;
                }
                if (proxyModules[importer] && proxyModules[importer].id === id)
                    return proxyModules[importer].path;
                if(id === "./dx-proxy-function")
                    return path.resolve(path.dirname(rootFileUrl), id) + ".js";
            }
        };
    }
};

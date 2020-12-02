const fs = require('fs'), fsp = fs.promises;
const { execSync } = require('child_process');
const path = require('path');
const crypto = require('crypto');

const options = { configName: "Debug", packageVersion: "0.0.0.0" };
process.argv.forEach((val, index) => {
    let option = val.split("=");
    if (option.length === 2)
        options[option[0]] = option[1].toLowerCase();
});

const IS_DEBUG = options.configName !== "release";
const GLOBAL_ENTRY_NAME = "DxBlazor";
const GLOBAL_INTEROP_NAME = "DxBlazorInternal";
const GLOBAL_DEVEXTREME_NAME = "window.DxBlazorInternal._devextreme";

const MINIFY_OUTPUT = !IS_DEBUG;
const JS_SOURCES = path.resolve("./Scripts/");
const JS_BUNDLE_CONFIG = path.join(JS_SOURCES, "dx-blazor.js");
const OUTPUT_PATH = path.resolve("./wwwroot/");
const MODULES_FOLDER = path.join(OUTPUT_PATH, "modules/");
const CAN_RUN_TESTS = false;

const { lazy_api, inject_viz, prepareModules, minify } = require("./resources.build.rollup_plugins");
const sass = require('node-sass');
const rollup = require('rollup');
const karma_cfg = require('karma').config;
const karma_server = require('karma').Server;
const rollup_clean_comments = require('rollup-plugin-cleanup');

function getBundleOutputOptions() {
    return ["cjs", "esm"].map((f) => {
        return {
            format: f,
            dir: MODULES_FOLDER,
            name: GLOBAL_ENTRY_NAME,
            sourcemap: false,
            entryFileNames: f + "-[name]-[hash].js",
            chunkFileNames: f + "-[name]-[hash].js",
            preferConst: f === "esm",
            esModule: f === "esm",
            strict: f === "cjs"
    }});
}

function ensureDevExtremeBundle() {
    const BUNDLE_OUTPUTFILE_PATH = path.resolve(JS_SOURCES, "external/devextreme.viz.js");
    const BUNDLE_INITIALIZER_SRC_PATH = path.resolve("./node_modules/devextreme/bundles/modules/core.js");

    const BUNDLE_CONFIG_PATH = "Scripts/external/devexpress.viz.config.js";
    const BUNDLER_PATH = "node_modules/devextreme/bin/bundler.js";
    const nodeFullPath = process.execPath;
    let cmdText = `"${nodeFullPath}" ${BUNDLER_PATH} ${BUNDLE_CONFIG_PATH}`;
    let initializerCode = fs.readFileSync(BUNDLE_INITIALIZER_SRC_PATH).toString();
    if (initializerCode.indexOf(GLOBAL_DEVEXTREME_NAME + " = {};") === -1) {
        initializerCode = initializerCode.replace("window.DevExpress = window.DevExpress || {};", GLOBAL_DEVEXTREME_NAME + " = {};");
        fs.writeFileSync(BUNDLE_INITIALIZER_SRC_PATH, initializerCode);
        execSync(cmdText, { stdio: 'inherit' });
    }

    if (!fs.existsSync(BUNDLE_OUTPUTFILE_PATH)) {
        execSync(cmdText, { stdio: 'inherit' });
    }
}
function createEntryModuleWriter() { return ((w) => (loaderType, name) => w = w.then(writeLoader(loaderType, name)))(Promise.resolve()); }
function getRollupConfig(entryModuleWriter) {
    return {
        input: JS_BUNDLE_CONFIG,
        plugins: [
            rollup_clean_comments({ comments: 'none', sourcemap: false }),
            inject_viz("devexpress.viz", GLOBAL_DEVEXTREME_NAME),
            lazy_api(JS_BUNDLE_CONFIG, entryModuleWriter),
            prepareModules(MINIFY_OUTPUT, "cjs", "devexpress.viz")],
        inlineDynamicImports: false,
        treeshake: {
            annotations: false,
            moduleSideEffects: false,
            propertyReadSideEffects: false
        }
    };
}
function getLoaderName(loaderType, name) { return [name, loaderType, "js"].filter(p => !!p).join("."); }
function getFilePaths(src) { return fsp.readdir(src).then(files => Promise.resolve((files || []).map(f => path.join(src, f)))); }
function processFileHandler(filePath, fp, dp) { return (stats) => stats.isFile() ? fp(filePath) : (stats.isDirectory() ? dp(filePath) : Promise.resolve()); }
function processFile(filePath, fp, dp) { return fsp.stat(filePath).then(processFileHandler(filePath, fp, dp)); }
async function iterateDir(src, fp, dp) { return getFilePaths(src).then((filePaths) => Promise.all(filePaths.map(f => processFile(f, fp, dp)))); }
async function ensureFolder(src) { return fs.existsSync(src) ? Promise.resolve(src) : fsp.mkdir(src, { recursive: true }); }
async function writeToOutput(fileName, content) { return ensureFolder(OUTPUT_PATH).then(() => fsp.writeFile(path.join(OUTPUT_PATH, fileName), content)); }
async function buildStyles() {
    return new Promise((res, _) =>
        sass.render({ file: "Styles/dx-blazor.scss", outputStyle: MINIFY_OUTPUT ? "compressed" : "expanded" }, (e, r) =>
            e ? _(e) : writeToOutput("dx-blazor.css", r.css).then(res)
        )
    );
}
async function bundleModules(entryModuleWriter) {
    return rollup.rollup(getRollupConfig(entryModuleWriter))
        .then((bundle) => Promise.all(getBundleOutputOptions().map(bundle.write)))
        .then(() => entryModuleWriter("", "dx-blazor.js"));
}
async function getModulesCIWorker() {
    if (!CAN_RUN_TESTS)
        return Promise.resolve(createEntryModuleWriter());
    return new Promise((resolve, reject) => {
        var cfg = karma_cfg.parseConfig(path.resolve('./resources.build.karma_ci.js'));
        var server = new karma_server(cfg, (exitCode) => {
            process.exit(exitCode);
        });
        server.on("run_complete", (browsers, results) => {
            if(results.failed > 0 || results.error)
                reject('KARMA TESTS FAILED');
            else
                resolve(createEntryModuleWriter());
        });
        server.start();
    });
}
var typeToEntryNameLookup = {};
async function writeLoader(type, entryName) {
    if (!type) {
        fs.writeFileSync("./Bases/ResourceLoader.Generated.cs",
`using System.Text;
namespace DevExpress.Blazor.Internal {
    public abstract partial class ScriptModulesLoaderBase {
        partial void AddScriptLoaderQueryParts(StringBuilder sb) {
            sb.Append("?version=");
            sb.Append("` + typeToEntryNameLookup[true] + `");
            sb.Append("` + typeToEntryNameLookup[false] + `");
        }
    }
}`);
        return fsp.readFile(path.join(JS_SOURCES, "dx-loader.js"), { encoding: "utf8" })
            .then((t) => writeToOutput("dx-blazor.js", minify("(" + t.replace("export ", "") + ")(this, document.head, " + JSON.stringify(typeToEntryNameLookup) + ", this.navigator.userAgent, \"DxBlazorInternal\");", MINIFY_OUTPUT)));
    } else {
        var fileName = typeToEntryNameLookup[type === "cjs"] = entryName.replace("-dx-blazor-", "");
        return fsp.readFile(path.join(JS_SOURCES, getLoaderName(type, "dx-loader")), { encoding: "utf8" })
            .then((t) => writeToOutput(fileName, minify("(" + t.replace("export ", "") + ")(\"" + entryName + "\", this." + GLOBAL_INTEROP_NAME + ");", MINIFY_OUTPUT)));
    }
}
async function clearFilesInFolder(src) { return ensureFolder(src).then(() => iterateDir(src, fsp.unlink, clearFilesInFolder)); }
async function buildRecources() {
    console.log("========= RESOURCES BUILD STARTED");
    ensureDevExtremeBundle();
    await clearFilesInFolder(OUTPUT_PATH)
            .then(() => Promise.all([
                buildStyles(),
                getModulesCIWorker().then(bundleModules)
            ]))
            .catch((r) => console.error(r))
            .finally(() => console.log("========= RESOURCES BUILD COMPLETED"));
}
buildRecources();

const path = require("path");
const fs = require("fs");
const scriptsDir = path.resolve("./Scripts");
const relativeDir = path.resolve("./") + "/";

function es6Module(config) {
    return function (req, res, next) {
        if(req.originalUrl.indexOf("~/") != -1) {
            res.writeHead(200, { "Content-Type": "text/javascript"});
            let name = path.basename(req.originalUrl);
            var contentStr =
                `var _history = (window._test_network_requests || (window._test_network_requests = []));
                 _history.push({ name: "`+name+`", state: "start init" });
                `+fs.readFileSync(relativeDir + req.originalUrl.split("~/")[1])+`
                _history.push({ name: "`+name+`", state: "end init" });`;
            res.end(contentStr);
        } else if(req.originalUrl.indexOf("/base/Scripts/") === 0 && req.originalUrl.indexOf(".js") === -1) {
            res.writeHead(200, { "Content-Type": "text/javascript"});
            res.end(fs.readFileSync(req.originalUrl.replace("/base/Scripts", scriptsDir) + ".js"));
        } else
            next();
    }
}
module.exports = function (config) {
    config.set({
        basePath: '',
        frameworks: ['jasmine'],
        files: [
            { pattern: './Scripts/*.spec.js', type: "module" },
            { pattern: './Scripts/*.js', type: "module", included: false },
            { pattern: './wwwroot/*.js', type: "js", included: false }
        ],
        mime: {
            'text/javascript': ['js', '']
        },
        exclude: [
        ],
        reporters: ['progress', 'teamcity'],
        port: 9876,
        colors: true,
        logLevel: config.LOG_INFO,
        autoWatch: false,
        browsers: ['ChromeHeadless'],
        singleRun: true,
        concurrency: Infinity,
        beforeMiddleware: ['es6Module'],
        plugins: [
            'karma-*',
            {'middleware:es6Module': ['factory', es6Module]}
        ],
        preprocessors: {
            '**/*.js': ['generic']
        },
        genericPreprocessor: {
            rules: [{
              match: "**/*.js",
              process: function (content, file, done, log) {
                if(file.originalPath.indexOf(scriptsDir) === 0 && file.originalPath.indexOf(".spec.js") === -1) {
                    file.path = file.path.substring(0, file.path.length - 3);
                }
                done(content);
              }
            }]
        }
    })
};

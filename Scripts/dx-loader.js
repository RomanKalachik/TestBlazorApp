export function DxBlazorInternal(host, container, lookup, userAgent, alias) {
    function getLookupSrc() {
        return lookup[(userAgent.indexOf("Trident") > -1 || userAgent.indexOf("Edge") > -1).toString()];
    }
    function defineGlobalAlias(name, v) {
        if(!host[name]) Object.defineProperty(host, name, { value: v });
    }
    defineGlobalAlias(alias, function DxBlazor(dotNetRef, folder, apiGatewayName) {
        return new Promise(function(resolve) {
            resolve({
                isMobileDevice: /(cpu iphone os)|(Android)/i.test(userAgent),
                isTablet: /(ipad)/i.test(userAgent)
            });
            DxBlazor[DxBlazor] = completeApiGateBuild;
            DxBlazor.importScript = importScript;
            importScript(getLookupSrc()).catch(window.console.error);
        });

        function completeApiGateBuild(module) {
            defineGlobalAlias(apiGatewayName, module);
            dotNetRef.invokeMethodAsync("OnMessage", 0);
        }
        function importScript(src) {
            return new Promise(function(resolve) {
                const scriptElement = container.ownerDocument.createElement("script");
                scriptElement.onload = function() {
                    container.removeChild(scriptElement);
                    resolve();
                };
                scriptElement.src = folder + src;
                container.appendChild(scriptElement);
            });
        }
    });
}

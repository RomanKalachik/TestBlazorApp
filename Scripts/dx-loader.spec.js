import {DxBlazorInternal} from "./dx-loader";

let nextId = 0;

class dotNetReference {
    async invokeMethodAsync() {
        return null;
    }
}
async function delay(duration) {
    return new Promise((r, _) => {
       setTimeout(r, duration);
    });
}
describe("DxLoader", () => {
    let host, id, dotNetReferenceInst;
    beforeEach(() => {
        host = {};
        id = "testHost" + ++nextId;
        console.log(id);
        window[id] = host;
        dotNetReferenceInst = new dotNetReference();
    });
    afterEach(() => {
        host = null;
        setTimeout((v) => delete window[v], 100, id);
    });
    describe("defines entry point for our components", () => {
        let sampleScript, blob;
        beforeEach(() => {
            let _id = "window." + id + "." + id;
            blob = new Blob([_id + "[" + _id + "](42)"], {type: "text/javascript"});
            sampleScript = window.URL.createObjectURL(blob);
            DxBlazorInternal(host, document.head, {false: sampleScript, true: sampleScript}, "", id);
        });
        afterEach(() => {
            URL.revokeObjectURL(sampleScript);
        });
        it("defines global alias for entry point", () => {
            expect(host[id]).not.toBeUndefined();
        });
        describe("method provided by alias", () => {
            let deviceInfo, folder, gateName, invokeMethodAsyncSpy;

            beforeEach(async () => {
                folder = "";
                gateName = id + "_Gate";
                invokeMethodAsyncSpy = spyOn(dotNetReferenceInst, "invokeMethodAsync");
                deviceInfo = await (host[id](dotNetReferenceInst, folder, gateName));
            });
            it("accepts dotNetReference and resource folder path and return promise which resolves deviceInfo", () => {
                expect(deviceInfo).toBeTruthy();
                expect(deviceInfo.isMobileDevice).toBeDefined();
                expect(deviceInfo.isTablet).toBeDefined();
            });
            it("inside of returned promise loader start injecting the rest of modules and notify dotNetRef when completed with flag 0", async () => {
                await delay(50);
                expect(invokeMethodAsyncSpy).toHaveBeenCalledWith("OnMessage", 0);
            });
            it("injects gate into host with specified alias",async () => {
                await delay(50);
                expect(host[gateName]).toBe(42);
            });
        });
    });
});
const expectedAPI = [
    "DropDown",
    "FormLayout",
    "ComboBox",
    "TagBox",
    "CheckBox",
    "Dom",
    "Charts",
    "Grid",
    "GridColumnResize",
    "Scheduler",
    "Calendar",
    "Roller",
    "Popup",
    "Upload",
    "ColumnChooser",
    "DragAndDrop",
    "SpinEdit",
    "FocusUtils",
    "Toolbar",
    "ButtonEdit",
    "ContextMenu",
    "Snackbar",
    "WindowResizeHelper"
];
const createWrapper = (fileContent) =>
    (userAgentMock) => `
        var testHost = { navigator: { userAgent: "` + userAgentMock + `" } };
        (function testLoader() {
            ` + fileContent + `
        }).bind(testHost)();
        window._testHost = testHost;
        window.DxBlazorInternal = testHost.DxBlazorInternal;`;

const createSandboxDocumentMarkup = (scriptUrl) =>
    `<!DOCTYPE html>
    <html>
        <head>
            <title>_</title>
            <script src="` + scriptUrl + `"></script>
        </head>
        <body></body>
    </html>`;

const createSandbox = async (scriptCode) =>
    new Promise((r, _) => {
        let blob = new Blob([scriptCode], {type: "text/javascript"});
        let scriptUrl = URL.createObjectURL(blob);
        let containerElement = document.createElement("iframe");
        containerElement.srcdoc = createSandboxDocumentMarkup(scriptUrl);
        containerElement.addEventListener("load", (e) => {
            URL.revokeObjectURL(scriptUrl);
            r(containerElement.contentWindow);
        });
        document.body.appendChild(containerElement);
    });

describe("Default bootstrapper", () => {
    let getScriptCodeText;
    beforeAll(async () => {
        let response = await fetch("~/wwwroot/dx-blazor.js");
        let fileContent = await response.text();
        getScriptCodeText = createWrapper(fileContent);
    });
    ["Modern browsers", "Trident/Edge"].forEach((platformCategory) => {
        describe("for " + platformCategory, () => {
            let sandboxWindow, expectedPrefix;
            beforeEach(async () => {
                expectedPrefix = platformCategory === "Modern browsers" ? "esm" : "cjs";
                sandboxWindow = await createSandbox(getScriptCodeText(platformCategory));
                await sandboxWindow.DxBlazorInternal(new dotNetReference(), "~/wwwroot/", "DxBlazor");
                await delay(50);
            });
            afterEach(() => document.body.removeChild(sandboxWindow.frameElement));

            it("injects DxBlazor into host window", () => {
                expect(sandboxWindow._testHost.DxBlazor).toBeTruthy();
            });
            it("contains only required API (extend expected API set in case new module export)", () => {
                let exposedAPI = Object.keys(sandboxWindow._testHost.DxBlazor).filter(k => k !== "id");
                let isMissing = expectedAPI.some(i => exposedAPI.indexOf(i) === -1);
                expect(isMissing).toBe(false, "some published API is missing now!");
                expect(exposedAPI.length).toBe(expectedAPI.length, "review exposed API!");
            });
            it("loaded via platform-specific file", () => {
                function onlyUnique(value, index, self) {
                    return self.indexOf(value) === index;
                }

                let requests = sandboxWindow._test_network_requests.filter(req => req.name.indexOf(expectedPrefix + "-") != -1).map(req => req.name).filter(onlyUnique);
                requests.forEach(name => {
                    expect(name.indexOf(expectedPrefix) === 0).toBe(true, name + " " + expectedPrefix + " " + platformCategory);
                });
                expect(requests.length).toBe(1, requests);
            });
        });
    });
});

import { Browser } from "./browser";

export function cloneObject(srcObject) {
    if(typeof (srcObject) !== "object" || srcObject == null)
        return srcObject;
    const newObject = {};
    /* jshint ignore:start */
    for(const i in srcObject)
        newObject[i] = srcObject[i];
    /* jshint ignore:end */
    return newObject;
}

export function getDocumentClientWidth() {
    if(document.documentElement.clientWidth === 0)
        return document.body.clientWidth;
    return document.documentElement.clientWidth;
}

export function getDocumentClientHeight() {
    if(Browser.Firefox && window.innerHeight - document.documentElement.clientHeight > getVerticalScrollBarWidth())
        return window.innerHeight;

    if(Browser.Opera && Browser.Version < 9.6 || document.documentElement.clientHeight === 0)
        return document.body.clientHeight;

    return document.documentElement.clientHeight;
}

let verticalScrollBarWidth;
export function getVerticalScrollBarWidth() {
    if(typeof (verticalScrollBarWidth) === "undefined") {
        const container = document.createElement("DIV");
        container.style.cssText = "position: absolute; top: 0px; left: 0px; visibility: hidden; width: 200px; height: 150px; overflow: hidden; box-sizing: content-box";
        document.body.appendChild(container);

        const child = document.createElement("P");
        container.appendChild(child);
        child.style.cssText = "width: 100%; height: 200px;";

        const widthWithoutScrollBar = child.offsetWidth;
        container.style.overflow = "scroll";
        let widthWithScrollBar = child.offsetWidth;
        if(widthWithoutScrollBar === widthWithScrollBar)
            widthWithScrollBar = container.clientWidth;

        verticalScrollBarWidth = widthWithoutScrollBar - widthWithScrollBar;

        document.body.removeChild(container);
    }
    return verticalScrollBarWidth;
}

export function getAbsoluteX(curEl) {
    return getAbsolutePositionX(curEl);
}
export function getAbsoluteY(curEl) {
    return getAbsolutePositionY(curEl);
}
export function setAbsoluteX(element, x) {
    element.style.left = prepareClientPosForElement(x, element, true) + "px";
}
export function setAbsoluteY(element, y) {
    element.style.top = prepareClientPosForElement(y, element, false) + "px";
}
export function getAbsolutePositionX(element) {
    if(Browser.IE)
        return getAbsolutePositionX_IE(element);
    else if(Browser.Firefox && Browser.Version >= 3)
        return getAbsolutePositionX_FF3(element);
    else if(Browser.WebKitFamily || Browser.Edge)
        return getAbsolutePositionX_FF3(element);
    else
        return window.getAbsolutePositionX_Other(element);
}
function getAbsolutePositionX_IE(element) {
    if(element == null || Browser.IE && element.parentNode == null) return 0; // B96664
    return element.getBoundingClientRect().left + getDocumentScrollLeft();
}
function getAbsolutePositionX_FF3(element) {
    if(element == null) return 0;
    const x = element.getBoundingClientRect().left + getDocumentScrollLeft();
    return x;
}
export function getAbsolutePositionY(element) {
    if(Browser.IE)
        return getAbsolutePositionY_IE(element);
    if(Browser.Firefox && Browser.Version >= 3)
        return getAbsolutePositionY_FF3(element);
    else if(Browser.WebKitFamily || Browser.Edge)
        return getAbsolutePositionY_FF3(element);
    else
        return window.getAbsolutePositionY_Other(element);
}

function getAbsolutePositionY_IE(element) {
    if(element == null || Browser.IE && element.parentNode == null) return 0; // B96664
    return element.getBoundingClientRect().top + getDocumentScrollTop();
}
function getAbsolutePositionY_FF3(element) {
    if(element == null) return 0;
    const y = element.getBoundingClientRect().top + getDocumentScrollTop();
    return y;
}

export function prepareClientPosForElement(pos, element, isX) {
    pos -= getPositionElementOffset(element, isX);
    return pos;
}
function createElementMock(element) {
    const div = document.createElement("DIV");
    div.style.top = "0px";
    div.style.left = "0px";
    div.visibility = "hidden";
    div.style.position = getCurrentStyle(element).position;
    return div;
}
function getExperimentalPositionOffset(element, isX) {
    const div = createElementMock(element);
    if(div.style.position === "static")
        div.style.position = "absolute";
    element.parentNode.appendChild(div);
    const realPos = isX ? getAbsoluteX(div) : getAbsoluteY(div);
    element.parentNode.removeChild(div);
    return realPos;
}
export function getPositionElementOffset(element, isX) {
    return getExperimentalPositionOffset(element, isX);
}

// Utils.js 3057
export function elementHasCssClass(element, className) {
    try {
        let elementClasses;
        const classList = getClassNameList(element);
        if(!classList) {
            const elementClassName = getClassName(element);
            if(!elementClassName)
                return false;
            elementClasses = elementClassName.split(" ");
        }
        const classNames = className.split(" ");
        for(let i = classNames.length - 1; i >= 0; i--) {
            if(classList) {
                if(classList.indexOf(classNames[i]) === -1)
                    return false;
                continue;
            }
            if(elementClasses.indexOf(classNames[i]) < 0)
                return false;
        }
        return true;
    }
    catch(e) {
        return false;
    }
}

export function addClassNameToElement(element, className) {
    if(!element || typeof (className) !== "string") return;
    className = className.trim();
    if(!elementHasCssClass(element, className) && className !== "") {
        const oldClassName = getClassName(element);
        setClassName(element, (oldClassName === "") ? className : oldClassName + " " + className);
    }
}

// Utils.js 3104
export function removeClassNameFromElement(element, className) {
    if(!element) return;
    const elementClassName = getClassName(element);
    const updClassName = " " + elementClassName + " ";
    const newClassName = updClassName.replace(" " + className + " ", " ");
    if(updClassName.length !== newClassName.length)
        setClassName(element, newClassName.trim());
}

// Utils.js 3128
export function getClassNameList(element) {
    return element.classList ? [].slice.call(element.classList) : getClassName(element).replace(/^\s+|\s+$/g, "").split(/\s+/);
}

// Utils.js 3131
export function getClassName(element) {
    if(element.tagName === "svg")
        return element.className.baseVal;
    return element.className;
}
// Utils.js 3140
export function setClassName(element, className) {
    if(element.tagName === "svg")
        element.className.baseVal = className.trim();
    else
        element.className = className.trim();
}

// Utils.js 3176
function getItemByIndex(collection, index) {
    if(!index) index = 0;
    if(collection != null && collection.length > index)
        return collection[index];
    return null;
}
// Utils.js 3276
export function getNodesByTagName(element, tagName) {
    const tagNameToUpper = tagName.toUpperCase();
    let result = null;
    if(element) {
        if(element.getElementsByTagName) {
            result = element.getElementsByTagName(tagNameToUpper);
            if(result.length === 0)
                result = element.getElementsByTagName(tagName);
        }
        else if(element.all && element.all.tags !== undefined)
            result = Browser.Netscape ? element.all.tags[tagNameToUpper] : element.all.tags(tagNameToUpper);
    }
    return result;
}

// Utils.js 3291
export function getNodeByTagName(element, tagName, index) {
    if(element != null) {
        const collection = getNodesByTagName(element, tagName);
        return getItemByIndex(collection, index);
    }
    return null;
}

// Utils.js 3556
export function getCurrentStyle(element) {
    if(document.defaultView && document.defaultView.getComputedStyle) {
        let result = document.defaultView.getComputedStyle(element, null);
        if(!result && Browser.Firefox && window.frameElement) {
            const changes = [];
            let curElement = window.frameElement;
            while(!(result = document.defaultView.getComputedStyle(element, null))) {
                changes.push([curElement, curElement.style.display]);
                setStylesCore(curElement, "display", "block", true);
                curElement = curElement.tagName === "BODY" ? curElement.ownerDocument.defaultView.frameElement : curElement.parentNode;
            }
            result = cloneObject(result);
            for(let ch, i = 0; ch = changes[i]; i++)
                setStylesCore(ch[0], "display", ch[1]);
            document.body.offsetWidth; // T334387
        }
        if(Browser.Firefox && Browser.MajorVersion >= 62 && window.frameElement && result.length === 0) { // T689462
            result = cloneObject(result);
            result.display = element.style.display;
        }
        return result;
    }
    return window.getComputedStyle(element, null);
}

// Utils.js 3556
export function createStyleSheetInDocument(doc) {
    if(doc.createStyleSheet) {
        try {
            return doc.createStyleSheet();
        }
        catch(e) {
            const message = "The CSS link limit (31) has been exceeded. Please enable CSS merging or reduce the number of CSS files on the page. For details, see http://www.devexpress.com/Support/Center/p/K18487.aspx.";
            throw new Error(message);
        }
    }
    else {
        const styleSheet = doc.createElement("STYLE");
        getNodeByTagName(doc, "HEAD", 0).appendChild(styleSheet);
        return styleSheet.sheet;
    }
}

// Utils.js 3597
let currentStyleSheet = null;
export function getCurrentStyleSheet() {
    if(!currentStyleSheet)
        currentStyleSheet = createStyleSheetInDocument(document);
    return currentStyleSheet;
}
// Utils.js 4659
export function setStylesCore(element, property, value, makeImportant) {
    if(makeImportant) {
        const index = property.search("[A-Z]");
        if(index !== -1)
            property = property.replace(property.charAt(index), "-" + property.charAt(index).toLowerCase());
        if(element.style.setProperty)
            element.style.setProperty(property, value, "important");
        else
            element.style.cssText += ";" + property + ":" + value + "!important";
    }
    else
        element.style[property] = value;
}

function getParentByClassNameInternal(element, className, selector) {
    while(element != null) {
        if(element.tagName === "BODY" || element.nodeName === "#document")
            return null;
        if(selector(element, className))
            return element;
        element = element.parentNode;
    }
    return null;
}
export function getParentByClassName(element, className) {
    return getParentByClassNameInternal(element, className, elementHasCssClass);
}
export function retrieveByPredicate(scourceCollection, predicate) {
    const result = [];
    for(let i = 0; i < scourceCollection.length; i++) {
        const element = scourceCollection[i];
        if(!predicate || predicate(element))
            result.push(element);
    }
    return result;
}

export function focusElement(element) {
    if(typeof element === "string")
        element = document.querySelector(element);
    if(element)
        element.focus();
}
export function setAttribute(element, attrName, attrValue) {
    if(element)
        element[attrName] = attrValue;
}

export function setCheckInputIndeterminate(inputElement, value) {
    if(inputElement)
        inputElement.indeterminate = value;
}

export function removeSelection() {
    document.getSelection().removeAllRanges();
}

export function log(message) { /* console.log(message); */ }

export function ensureElement(element) {
    if(!element) return null;

    let internalId = null;
    if(typeof element === "string") {
        const elRef = JSON.parse(element);
        if(elRef && elRef.__internalId)
            internalId = elRef.__internalId;

    }

    if(!internalId && element["__internalId"])
        internalId = element["__internalId"];

    if(internalId) {
        const blid = "_bl_" + internalId;
        element = document.querySelector("[" + blid + "]");
    }

    if(!element || !element["tagName"] || element.parentNode === null)
        element = null;

    return element;
}
export function setInputAttribute(element, attrName, attrValue) {
    element = ensureElement(element);
    if(element)
        setAttribute(element, attrName, attrValue);
}

export function querySelectorFromRoot(element, method) {
    element.dataset.tempUniqueId = "tempUniqueId";
    try {
        method("[data-temp-unique-id]");
    }
    catch(e) {}
    finally {
        delete element.dataset.tempUniqueId;
    }
}

function removeAttribute(obj, attrName) {
    if(obj.removeAttribute)
        obj.removeAttribute(attrName);
    else if(obj.removeProperty)
        obj.removeProperty(attrName);
}
function setOrRemoveAttribute(obj, attrName, value) {
    if(!value)
        removeAttribute(obj, attrName);
    else
        setAttribute(obj, attrName, value);
}


export function getLeftRightBordersAndPaddingsSummaryValue(element, currentStyle) {
    return getLeftRightPaddings(element, currentStyle) + getHorizontalBordersWidth(element, currentStyle);
}
export function getTopBottomBordersAndPaddingsSummaryValue(element, currentStyle) {
    return getTopBottomPaddings(element, currentStyle) + getVerticalBordersWidth(element, currentStyle);
}
export function getLeftRightPaddings(element, style) {
    const currentStyle = style ? style : getCurrentStyle(element);
    return parseInt(currentStyle.paddingLeft) + parseInt(currentStyle.paddingRight);
}
export function getTopBottomPaddings(element, style) {
    const currentStyle = style ? style : getCurrentStyle(element);
    return parseInt(currentStyle.paddingTop) + parseInt(currentStyle.paddingBottom);
}
export function getVerticalBordersWidth(element, style) {
    if(!style)
        style = (Browser.IE && Browser.MajorVersion !== 9 && window.getComputedStyle) ? window.getComputedStyle(element) : getCurrentStyle(element);
    let res = 0;

    if(style.borderTopStyle !== "none")
        res += parseFloat(style.borderTopWidth);
    if(style.borderBottomStyle !== "none")
        res += parseFloat(style.borderBottomWidth);
    return res;
}
export function getHorizontalBordersWidth(element, style) {
    if(!style)
        style = (Browser.IE && window.getComputedStyle) ? window.getComputedStyle(element) : getCurrentStyle(element);
    let res = 0;

    if(style.borderLeftStyle !== "none")
        res += parseFloat(style.borderLeftWidth);
    if(style.borderRightStyle !== "none")
        res += parseFloat(style.borderRightWidth);

    return res;
}

const requestAnimationFrameFunc = window.requestAnimationFrame || function(callback) { callback(); };
const cancelAnimationFrameFunc = window.cancelAnimationFrame || function(id) { };
export function CancelAnimationFrame(id) { cancelAnimationFrameFunc(id); }
export function RequestAnimationFrame(callback) { return requestAnimationFrameFunc(callback); }

const FrameContext = function(requestFrame) {
    this.requestFrame = requestFrame;
    this.cache = [[]];
    this.isInFrame = false;
    this.frameTimestamp = null;
    this.isWaiting = false;

    this.getBuffer = function(order) {
        if(!order) order = 0;
        if(this.cache.length <= order) this.cache[order] = [];
        return this.cache[order];
    };
    this.execute = function(callback, order) {
        if(!this.isInFrame)
            return false;
        let buffer = this.cache[order || 0];
        if(buffer === null)
            callback(requestFrameId, this.frameTimestamp);
        else (buffer = this.getBuffer(order)).push(callback);
        return true;
    };
    this.runAll = function(frameTimestamp) {
        this.isWaiting = false;
        this.isInFrame = true;
        this.frameTimestamp = frameTimestamp;
        for(let i = 0; i < this.cache.length; i++) {
            const buffer = this.cache[i];
            if(buffer) {
                this.cache[i] = null;
                while(buffer.length)
                    buffer.shift()(requestFrameId, this.frameTimestamp);
            }
        }
        this.waitNextFrame();
    };
    this.waitNextFrame = function() {
        this.cache = [[]];
        this.isInFrame = false;
        this.isWaiting = false;
    };
    this.requestExecution = function(func, order) {
        const that = this;
        return new Promise(function(resolve) {
            function callback(requestFrameId, frameTimestamp) {
                resolve(func(requestFrameId, frameTimestamp));
            }
            if(!that.execute(callback, order)) {
                that.getBuffer(order).push(callback);
                if(that.isWaiting === false) {
                    that.isWaiting = true;
                    that.requestFrame(that.runAll.bind(that));
                }
            }
        });
    };
};

let requestFrameId = null;
// eslint-disable-next-line new-cap
function requestAnimationFrame(callback) { return requestFrameId = RequestAnimationFrame(callback); }

function createAccumulator(requestFrame) {
    const context = new FrameContext(requestFrame);
    return context.requestExecution.bind(context);
}
const changeDomCore = createAccumulator(requestAnimationFrame);
const calculateStylesCore = createAccumulator(function(callback) { return changeDomCore(function() { setTimeout(callback); }); });

export function changeDom(c) { return changeDomCore(c); }
export function calculateStyles(c) { return calculateStylesCore(c); }

let observers = []; const minimumIntervalBetweenChecks = 50;
function itemObserver(element, callback, width) {
    return function() {
        if(element.compareDocumentPosition(document.body) & window.Node.DOCUMENT_POSITION_DISCONNECTED)
            return false;
        const currentStyle = getCurrentStyle(element);
        if(currentStyle.width === "auto")// auto if inside of display none || element is inline
            return true;
        const w = parseInt(currentStyle.width) - getLeftRightBordersAndPaddingsSummaryValue(element);
        if(width !== w)
            callback(width = w);
        return true;
    };
}
function elementSizeObserver(element, callback, size) {
    return function() {
        if(element.compareDocumentPosition(document.body) & window.Node.DOCUMENT_POSITION_DISCONNECTED)
            return false;
        const currentStyle = getCurrentStyle(element);
        if(currentStyle.width === "auto")// auto if inside of display none || element is inline
            return true;
        const elementWidth = parseInt(currentStyle.width) - getLeftRightBordersAndPaddingsSummaryValue(element);
        const elementHeight = parseInt(currentStyle.height) - getTopBottomBordersAndPaddingsSummaryValue(element);
        if(size.width !== elementWidth || size.height !== elementHeight) {
            size.width = elementWidth;
            size.height = elementHeight;
            callback(size);
        }
        return true;
    };
}
function elementDisconnectedObserver(element, onDisconnected) {
    return function() {
        if(element.compareDocumentPosition(document.body) & window.Node.DOCUMENT_POSITION_DISCONNECTED) {
            onDisconnected();
            return false;
        }
        return true;
    };
}
export function unsubscribeElement(observer) {
    observers.splice(observers.indexOf(observer), 1);
}
export function subscribeElementContentWidth(el, callback) {
    const observer = itemObserver(el, callback, -1);
    subscribeElementObserver(observer);
    return observer;
}
export function subscribeElementContentSize(element, callback) {
    const observer = elementSizeObserver(element, callback, { width: -1, height: -1 });
    subscribeElementObserver(observer);
    return observer;
}
export function subscribeElementDisconnected(element, onDisconnected) {
    subscribeElementObserver(elementDisconnectedObserver(element, onDisconnected));
}
function subscribeElementObserver(observer) {
    if(observers.length === 0) {
        observers.push(observer);
        calculateStyles(updateTrackedElements);
    }
    else
        observers.push(observer);
}
function updateTrackedElements() {
    observers = observers.filter(function(observer) { return observer(); });
    if(observers.length > 0) {
        setTimeout(function() {
            calculateStyles(updateTrackedElements);
        }, minimumIntervalBetweenChecks);
    }
}
export function applyStyles(element, styles) {
    const stylesArr = [];
    for(const property in styles) {
        if(Object.prototype.hasOwnProperty.call(styles, property))
            stylesArr.push({ attr: property, value: styles[property] });
    }
    if(stylesArr.length === 1)
        element.style[stylesArr[0].attr] = stylesArr[0].value;
    else {
        let cssText = "";
        if(element.style.cssText) {
            const oldStylesArr = element.style.cssText.split(";").map(function(nvp) { return nvp.trim().split(":"); });
            for(let i = 0; i < oldStylesArr.length; i++) {
                const oldStyleArr = oldStylesArr[i];
                if(oldStyleArr.length === 2 && styles[oldStyleArr[0]] === undefined)
                    cssText += oldStyleArr[0] + ":" + oldStyleArr[1].trim() + ";";
            }
        }
        for(let i = 0; i < stylesArr.length; i++) {
            const style = stylesArr[i];
            if(style.value !== "")
                cssText += style.attr + ":" + style.value + ";";
        }
        setOrRemoveAttribute(element, "style", cssText);
    }
}
export function applyStateToElement(element, state) {
    if(state.inlineStyles === null)
        removeAttribute(element, "style");
    else
        applyStyles(element, state.inlineStyles);

    for(const attrName in state.attributes) {
        if(Object.prototype.hasOwnProperty.call(state, attrName))
            setOrRemoveAttribute(element, attrName, state.attributes[attrName]);
    }

    const allCssClasses = getClassNameList(state);
    if(allCssClasses) {
        const toggleInfo = state.cssClassToggleInfo;
        const cssClasses = allCssClasses.filter(function(c) { return toggleInfo[c] !== false; });
        for(const c in toggleInfo) {
            if(Object.prototype.hasOwnProperty.call(toggleInfo, c) && toggleInfo[c] && cssClasses.indexOf(c) === -1)
                cssClasses.push(c);
        }
        const cssClass = cssClasses.join(" ");
        if(cssClass)
            setClassName(element, cssClass);
        else
            removeAttribute(element, "class");
    }
}
export function createElementState(element) {
    return { inlineStyles: {}, cssClassToggleInfo: {}, className: getClassName(element), attributes: {} };
}
export function updateElementState(elementOrCollection, callback) {
    if(elementOrCollection.length !== undefined) {
        for(let i = 0; i < elementOrCollection.length; i++)
            updateElementState(elementOrCollection[i], callback);
        return;
    }
    const element = elementOrCollection;
    if(!element._dxCurrentFrameElementStateInfo) {
        callback(element._dxCurrentFrameElementStateInfo = createElementState(element));
        changeDom(function() {
            applyStateToElement(element, element._dxCurrentFrameElementStateInfo);
            element._dxCurrentFrameElementStateInfo = null;
        }, 1);
    }
    else
        callback(element._dxCurrentFrameElementStateInfo);
}
export function setStyles(el, styles) {
    updateElementState(el, function(state) {
        if(state.inlineStyles === null)
            state.inlineStyles = styles;
        else {
            for(const i in styles) {
                if(Object.prototype.hasOwnProperty.call(styles, i))
                    state.inlineStyles[i] = styles[i];
            }
        }
    });
}
export function clearStyles(el) {
    updateElementState(el, function(state) {
        state.inlineStyles = null;
        state.cssClassToggleInfo["visually-hidden"] = false;
    });
}
export function toggleCssClass(el, cssClass, condition) {
    updateElementState(el, function(state) {
        state.cssClassToggleInfo[cssClass] = condition;
    });
}
export function setCssClassName(el, className) {
    updateElementState(el, function(state) {
        state.cssClassToggleInfo = {};
        state.className = className;
    });
}
export function updateAttribute(el, attrName, attrValue) {
    updateElementState(el, function(state) {
        state.attributes[attrName] = attrValue;
    });
}
export function nextChangeDOM(callback) {
    changeDom(callback, 2);
}

export function elementIsInDOM(element) {
    return document.body.contains(element);
}

export function findParentBySelector(element, selector) {
    if(!element) return null;
    if(element.closest) return element.closest(selector);

    do {
        const matches = element.matches || element.msMatchesSelector; // IE11
        if(matches.call(element, selector)) return element;
        element = element.parentElement || element.parentNode;
    } while(element && element.tagName !== "BODY");
    return null;
}
export function getDocumentScrollLeft() {
    const isScrollBodyIE = false;// Browser.IE && ASPx.GetCurrentStyle(document.body).overflow == "hidden" && document.body.scrollLeft > 0;
    if(Browser.Edge || isScrollBodyIE)
        return document.body ? document.body.scrollLeft : document.documentElement.scrollLeft;
    if(Browser.WebKitFamily)
        return document.documentElement.scrollLeft || document.body.scrollLeft;
    return document.documentElement.scrollLeft;
}
export function getDocumentScrollTop() {
    const isScrollBodyIE = false; // Browser.IE && ASPx.GetCurrentStyle(document.body).overflow == "hidden" && document.body.scrollTop > 0;
    if(Browser.WebKitFamily || Browser.Edge || isScrollBodyIE) {
        if(Browser.MacOSMobilePlatform) // B157267
            return window.pageYOffset;
        if(Browser.WebKitFamily)
            return document.documentElement.scrollTop || document.body.scrollTop;
        return document.body.scrollTop;
    }
    else
        return document.documentElement.scrollTop;
}

export function eraseBlazorIdentificators(element) {
    if(element.attributes) {
        for(let i = 0; i < element.attributes.length; i++) {
            const name = element.attributes[i].name;
            if(name.startsWith("_bl_") || name.startsWith("id"))
                element.removeAttribute(name);
        }
    }
    element.childNodes.forEach(chl => { eraseBlazorIdentificators(chl); });
}
export function GetNearestPositionedParent(element, includingSelf = false) {
    let parent = includingSelf ? element : element.parentNode;
    while(parent && window.getComputedStyle(parent).position === "static")
        parent = parent.parentNode;
    return parent;
}
export function toPx(value) {
    return value + "px";
}
export function pxToInt(px) {
    return pxToNumber(px, parseInt);
}
export function pxToFloat(px) {
    return pxToNumber(px, parseFloat);
}
function pxToNumber(px, parseFunction) {
    let result = 0;
    if(px != null && px !== "") {
        try {
            const indexOfPx = px.indexOf("px");
            if(indexOfPx > -1)
                result = parseFunction(px.substr(0, indexOfPx));
        }
        catch(e) { }
    }
    return result;
}
export default { focusElement, setInputAttribute, setCheckInputIndeterminate };

import { getClassName, getCurrentStyleSheet, elementHasCssClass, changeDom, setStyles, toggleCssClass, clearStyles } from "./dom-utils";
import { getVerticalScrollBarWidth } from "./utils-scrollbars";

const showCssClass = "show";
const matrixRegex = "\\s*matrix\\(\\s*" + ([0, 0, 0, 0, 0, 0].map(function() { return "(\\-?\\d+\\.?\\d*)"; }).join(",\\s*")) + "\\)\\s*";

function pxToNumber(px) {
    let result = 0;
    if(px != null && px !== "") {
        try {
            const indexOfPx = px.indexOf("px");
            if(indexOfPx > -1)
                result = parseFloat(px.substr(0, indexOfPx));
        }
        catch(e) { }
    }
    return Math.ceil(result);
}

export function parseTranslateInfo(styles) {
    const m = new RegExp(matrixRegex).exec(styles.transform);
    return m ? { left: parseInt(m[5]), top: parseInt(m[6]) } : { left: 0, top: 0 };
}
export function translatePosition(styles, x, y) {
    styles["transform"] = "matrix(1, 0, 0, 1, " + x + ", " + y + ")";
}
function getBoundingBox(x, y, w, h) { return { left: x, top: y, right: x + w, bottom: y + h, width: w, height: h }; }
function getSafeBoundingBox(element, roundLT, roundRB) {
    const box = element.getBoundingClientRect();
    const safeBox = { left: roundLT(box.left), top: roundLT(box.top), right: roundRB(box.right), bottom: roundRB(box.bottom) };
    safeBox.width = safeBox.right - safeBox.left;
    safeBox.height = safeBox.bottom - safeBox.top;
    return safeBox;
}
function getOuterBoundingBox(element) {
    return getSafeBoundingBox(element, Math.floor, Math.ceil);
}
function getInnerBoundingBox(element) {
    return getSafeBoundingBox(element, Math.ceil, Math.floor);
}
class DockPoint {
    constructor(key, info) {
        this.key = key;
        this.info = info;
    }
    checkMargin() { return true; }
    allowScroll() { return this.info.size === "height"; }
    canApplyToElement(element) { return getClassName(element).indexOf("dxbs-align-" + this.key) > -1; }
    getRange(dockInfo) {
        const c1 = this.getTargetBox(dockInfo)[this.info.to];
        const c2 = c1 + this.info.sizeM * (dockInfo.elementBox[this.info.size] + (this.checkMargin() ? dockInfo.margin : 0));
        return {
            from: Math.min(c1, c2),
            to: Math.max(c1, c2),
            windowOverflow: 0
        };
    }
    getTargetBox(dockInfo) { return null; }
    validate(range, windowInfo) {
        const windowSize = windowInfo[this.info.size];
        range.windowOverflow = Math.abs(Math.min(0, range.from - windowSize.from) + Math.min(0, windowSize.to - range.to));
        range.validTo = Math.min(range.to, windowSize.to);
        range.validFrom = Math.max(range.from, windowSize.from);
        return range.windowOverflow === 0;
    }
    applyRange(range, dockInfo) {
        dockInfo.appliedModifierKeys[this.info.size] = this.key;
        const side = this.info.size === "width" ? "left" : "top";
        const style = dockInfo.styles;
        let from = range.from;
        if(this.allowScroll() && range.windowOverflow > 0) {
            if(!dockInfo.limitBox.scroll.width) {
                dockInfo.limitBox.scroll.width = true;
                dockInfo.limitBox.width.to -= getVerticalScrollBarWidth();
            }
            if(dockInfo.isScrollable) {
                style["max-height"] = dockInfo.height - range.windowOverflow + "px";
                dockInfo.width += getVerticalScrollBarWidth();
                dockInfo.elementBox.width += getVerticalScrollBarWidth();
                from = range.validFrom;
            }
        }
        style.width = dockInfo.width + "px";
        if(this.checkMargin())
            from += Math.max(0, this.info.sizeM) * dockInfo.margin;
        dockInfo.elementBox[side] += from;
        translatePosition(style, dockInfo.elementBox.left, dockInfo.elementBox.top);

    }
    dockElementToTarget(dockInfo) {
        const range1 = this.getRange(dockInfo);
        if(!this.dockElementToTargetInternal(range1, dockInfo))
            this.applyRange(range1, dockInfo);
    }
    dockElementToTargetInternal(range1, dockInfo) { }
}
class OuterDockPoint extends DockPoint {
    constructor(name, info, oppositePointName) {
        super(name, info, oppositePointName);
        this.oppositePointName = oppositePointName || null;
    }
    getTargetBox(dockInfo) { return dockInfo.targetBox.outer; }
    getOppositePoint() {
        return this._oppositePoint || (this._oppositePoint = dockPoints.filter(function(d) {
            return d.key === this.oppositePointName;
        }.bind(this))[0]);
    }
    dockElementToTargetInternal(range1, dockInfo) {
        if(this.validate(range1, dockInfo.limitBox))
            this.applyRange(range1, dockInfo);
        else {
            const oppositePoint = this.getOppositePoint();
            const range2 = oppositePoint.getRange(dockInfo);
            if(oppositePoint.validate(range2, dockInfo.limitBox) || range2.windowOverflow < range1.windowOverflow)
                oppositePoint.applyRange(range2, dockInfo);
            else
                return false;
        }
        return true;
    }
}
class InnerDockPoint extends DockPoint {
    checkMargin() { return false; }
    getTargetBox(dockInfo) { return dockInfo.targetBox.inner; }
    dockElementToTargetInternal(range1, dockInfo) {
        this.validate(range1, dockInfo.limitBox);
        return false;
    }
    validate(range, windowInfo) {
        const toOverflow = Math.min(range.from, Math.max(0, range.to - windowInfo[this.info.size].to));
        if(toOverflow > 0) {
            range.from -= toOverflow;
            range.to -= toOverflow;
        }
        return super.validate(range, windowInfo);
    }
}
const dockPoints = [
    new OuterDockPoint("above", { to: "top", from: "bottom", size: "height", sizeM: -1 }, "below"),
    new OuterDockPoint("below", { to: "bottom", from: "top", size: "height", sizeM: 1 }, "above"),
    new InnerDockPoint("top-sides", { to: "top", from: "top", size: "height", sizeM: 1 }),
    new InnerDockPoint("bottom-sides", { to: "bottom", from: "bottom", size: "height", sizeM: -1 }),
    new OuterDockPoint("outside-left", { to: "left", from: "right", size: "width", sizeM: -1 }, "outside-right"),
    new OuterDockPoint("outside-right", { to: "right", from: "left", size: "width", sizeM: 1 }, "outside-left"),
    new InnerDockPoint("left-sides", { to: "left", from: "left", size: "width", sizeM: 1 }),
    new InnerDockPoint("right-sides", { to: "right", from: "right", size: "width", sizeM: -1 })
];

function getElementPopupInfo(element, targetElement, settings) {
    const elementStyle = getCurrentStyleSheet(element);
    const box = getOuterBoundingBox(element);
    const targetBox = getInnerBoundingBox(targetElement);
    const docEl = element.ownerDocument.documentElement;
    const result = {
        isScrollable: elementHasCssClass(element, "dxbs-scrollable"),
        specifiedOffsetModifiers: dockPoints.filter(function(m) { return m.canApplyToElement(element); }),
        margin: pxToNumber(elementStyle.marginTop),
        width: settings ? Math.max(settings.width, Math.ceil(element.offsetWidth)) : Math.ceil(element.offsetWidth),
        height: Math.ceil(element.offsetHeight),
        appliedModifierKeys: { height: null, width: null }
    };
    const styles = parseTranslateInfo(elementStyle);
    const left = element.classList.contains("visually-hidden") ? targetBox.left : box.left;
    result.elementBox = getBoundingBox(styles.left - left, styles.top - box.top, box.width, box.height);
    result.targetBox = { outer: getOuterBoundingBox(targetElement), inner: getInnerBoundingBox(targetElement) };
    result.limitBox = {
        scroll: { width: docEl.clientWidth < window.innerWidth, height: docEl.clientHeight < window.innerHeight },
        width: { from: 0, to: docEl.clientWidth },
        height: { from: 0, to: docEl.clientHeight }
    };
    result.styles = {};
    const highPriorityModifiersData = element.getAttribute("data-popup-align") || settings && settings.align;
    const highPriorityModifiers = highPriorityModifiersData.split(/\s+/);
    result.offsetModifiers = dockPoints.filter(function(m) {
        return highPriorityModifiers.some(function(k) { return m.key === k; });
    });
    return result;
}
function preparePosition(element, targetElement, settings, onShow) {
    return changeDom(function() {
        const dockInfo = getElementPopupInfo(element, targetElement, settings);
        for(let i = 0; i < dockInfo.offsetModifiers.length; i++)
            dockInfo.offsetModifiers[i].dockElementToTarget(dockInfo);
        onShow(dockInfo);
        setStyles(element, dockInfo.styles);
    });
}
export function hide(element) {
    if(elementHasCssClass(element, showCssClass)) {
        if(element.isDockedElementHidden)
            delete element.isDockedElementHidden;
        clearStyles(element);
        toggleCssClass(element, showCssClass, false);
    }
    else if(element.isDockedElementHidden)
        delete element.isDockedElementHidden;
}
export function show(element, targetElement, align) {
    if(targetElement === null)
        return;
    preparePosition(element, targetElement, { align: align }, () => { });
    toggleCssClass(element, showCssClass, true);
    clearStyles(element);
}

export function getElementPaddingRight(element) {
    return parseFloat(window.getComputedStyle(element, null).getPropertyValue("padding-right"));
}

export function getScrollbarWidth() {
    return window.innerWidth - document.body.getBoundingClientRect().width;
}

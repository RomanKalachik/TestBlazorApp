export function attachEventToElement(element, eventName, func, onlyBubbling, passive) {
    if(element.addEventListener)
        element.addEventListener(eventName, func, isPassiveListenersSupported() ? { capture: !onlyBubbling, passive: !!passive } : !onlyBubbling);
    else
        element.attachEvent("on" + eventName, func);
}
export function detachEventFromElement(element, eventName, func) {
    if(element.removeEventListener)
        element.removeEventListener(eventName, func, true);
    else
        element.detachEvent("on" + eventName, func);
}
export function preventEvent(evt) {
    if(evt.preventDefault)
        evt.preventDefault();
    else
        evt.returnValue = false;
    return false;
}
export function preventEventAndBubble(evt) {
    preventEvent(evt);
    if(evt.stopPropagation)
        evt.stopPropagation();
    evt.cancelBubble = true;
    return false;
}
export function getEventSource(evt) {
    return evt && (evt.srcElement || evt.target);
}
const isPassiveListenersSupported = function() {
    return true;
};
export function isLeftButtonPressed(evt) {
    return evt.button === 0;
}

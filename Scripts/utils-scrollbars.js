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

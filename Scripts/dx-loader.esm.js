export function loader(entryName, dx) {
    import("./modules/" + entryName).then((module) => {
        dx[dx](module.default);
    });
}

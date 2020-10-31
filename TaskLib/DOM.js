function nestedDepth() {
    return Math.max.apply(null, $('ul, ol').map((i, l) => $(l).find('ul, ol').length)) + 1;
}
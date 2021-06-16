// Declare our namspace
var Blazority = Blazority || {};
var Blr = Blazority;

Blr.ResizableTable = function (tableSelector, colSelector, resizerSelector) {
    var table = document.querySelector(tableSelector);
    var tbody = document.querySelector(tableSelector + ' tbody');
    if (!table) return;

    var cols = table.querySelectorAll(colSelector);
    for (var i = 0; i < cols.length; i++) {
        var resizer = cols[i].querySelector(resizerSelector);
        setListeners(resizer);
    }

    var pageX, curCol, nxtCol, curColWidth, nxtColWidth, curResizer;

    function setListeners(resizer) {
        resizer.addEventListener('mousedown', function (e) {
            document.addEventListener('mousemove', mouseMoveHandler);
            document.addEventListener('mouseup', mouseUpHandler);

            curResizer = resizer;
            curCol = e.target.parentElement;
            nxtCol = curCol.nextElementSibling;
            pageX = e.pageX;

            resizer.style.height = (resizer.offsetHeight + tbody.offsetHeight) + 'px';

            var padding = paddingDiff(curCol);

            curColWidth = curCol.offsetWidth - padding;
            if (nxtCol)
                nxtColWidth = nxtCol.offsetWidth - padding;
        });
    }

    function mouseMoveHandler(e) {
        if (curCol) {
            var diffX = e.pageX - pageX;

            if (nxtCol)
                nxtCol.style.width = (nxtColWidth - (diffX)) + 'px';

            curCol.style.width = (curColWidth + diffX) + 'px';
        }
    }

    function mouseUpHandler() {
        document.removeEventListener('mousemove', mouseMoveHandler);
        document.removeEventListener('mouseup', mouseUpHandler);

        curResizer.style.removeProperty('height');

        curResizer = undefined;
        curCol = undefined;
        nxtCol = undefined;
        pageX = undefined;
        nxtColWidth = undefined;
        curColWidth = undefined
    }

    function paddingDiff(col) {
        if (getStyleVal(col, 'box-sizing') == 'border-box') {
            return 0;
        }

        var padLeft = getStyleVal(col, 'padding-left');
        var padRight = getStyleVal(col, 'padding-right');
        return (parseInt(padLeft) + parseInt(padRight));

    }

    function getStyleVal(elm, css) {
        return (window.getComputedStyle(elm, null).getPropertyValue(css))
    }
};
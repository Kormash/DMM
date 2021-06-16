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
// Declare our namspace
var Blazority = Blazority || {};
var Blr = Blazority;
/**
* Set focus on specified element
* @param {any} selector
*/
Blr.SetElemFocus = function (el) {
el && el.focus();
};
/**
* Set focus on specified element by selector
* @param {any} selector
*/
Blr.SetFocus = function (selector) {
if (selector) {
var el = document.querySelector(selector);
Blr.SetElemFocus(el);
}
};
/**
* Update property of the specific element
* @param {any} el Element
* @param {any} property Property key to set value on
* @param {any} value Property value
*/
Blr.SetElemProperty = function (el, property, value) {
if (el && property) {
el[property] = value;
}
};
/**
* Clear focus on specified element
* @param {any} selector
*/
Blr.ClearElemFocus = function (el) {
el && el.blur();
};
/**
* Clear focus on specified element by selector
* @param {any} selector
*/
Blr.ClearFocus = function (selector) {
if (selector) {
var el = document.querySelector(selector);
Blr.ClearElemFocus(el);
}
};
/**
* Clear all user selection ranges
*/
Blr.ClearSelectionRanges = function () {
var selection = window && window.getSelection();
selection && selection.removeAllRanges();
};
/**
* Get bounding rectangle of an element.
* @param {any} selector
*/
Blr.GetBoundingClientRect = function (selector) {
var el = document.querySelector(selector);
return el && el.getBoundingClientRect();
};
// Declare our namspace
var Blazority = Blazority || {};
var Blr = Blazority;
/**
* Update the range slider.
* @param {any} inputSelector
* @param {any} sliderSelector
*/
Blr.UpdateSlider = function (inputSelector, sliderSelector) {
if (inputSelector && sliderSelector) {
var input = document.querySelector(inputSelector);
var sliderEl = document.querySelector(sliderSelector);
if (input && sliderEl) {
var inputWidth = input.offsetWidth;
var minValue = +input.min;
var maxValue = +input.max;
if (minValue === 0 && maxValue === 0) {
maxValue = 100;
}
var middle = (minValue + maxValue) / 2;
var value = input.value !== undefined ? input.value : middle;
var valueAsPercent = ((value - minValue) * 100) / (maxValue - minValue);
sliderEl.style.width = (valueAsPercent * inputWidth) / 100 + 'px'
}
}
};

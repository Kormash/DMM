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


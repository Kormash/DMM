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
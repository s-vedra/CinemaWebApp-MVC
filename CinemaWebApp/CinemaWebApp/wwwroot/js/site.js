
$(document).ready(function () {
    $('.carousel').carousel();
});

var rangeslider = document.getElementById("sliderRange");
var output = document.getElementById("value");
output.innerHTML = rangeslider.value;

rangeslider.oninput = function () {
    output.innerHTML = this.value;
}

var snackRangeSlider = document.getElementsByClassName("snack-sliderRange");
var snackOutput = document.getElementsByClassName("snack-value");
snackOutput.innerHTML = snackRangeSlider.value;
for (let i = 0; i < snackOutput.length; i++) {
    snackRangeSlider[i].oninput = function () {
        snackOutput[i].innerHTML = this.value;
    }
}

// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// When the user scrolls down 50px from the top of the document, resize the header's font size

//window.onscroll = function () { scrollFunction() };

//function scrollFunction() {
//    if (document.body.scrollTop > 50 || document.documentElement.scrollTop > 50) {
//        document.getElementById("header").style.fontSize = "30px";
//    } else {
//        document.getElementById("header").style.fontSize = "90px";
//    }
//}

function ratingRangeChanged(val) {

    var element = document.getElementById('rangevalue');
    if (val == 1)
        element.value = "1 - Really bad"
    else if (val == 2)
        element.value = "2 - Bad"
    else if (val == 3)
        element.value = "3 - Okay"
    else if (val == 4)
        element.value = "4 - Good"
    else if (val == 5)
        element.value = "5 - Really good!"
}

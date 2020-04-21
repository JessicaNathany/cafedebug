
let link = window.location.href;
let homePage = window.location.protocol + "//" + window.location.host + "/";

var navbar = document.getElementById("header");
var sticky = navbar.offsetTop;

window.onscroll = function () { fixedNavbar() };
if (link === homePage) {
    navbar.classList.remove("scroll");
    $(".body-content").css("padding-top", "0");
    navbar.classList.add("sticky");
}
if (link.includes('Episode')) {
    SetActiveClass(document.querySelector("#episods"));
    $('.header').addClass('scroll');

}

function SetActiveClass(selector) {
    let navItems = document.querySelectorAll(".nav-item");
    navItems.forEach(item => item.classList.remove("selected"));
    selector.classList.toggle("selected");
}

function fixedNavbar() {
    console.log(sticky);
    if (window.pageYOffset >= sticky) {
        navbar.classList.add("sticky");
        navbar.classList.add("scroll");
        if (link === homePage && window.pageYOffset <= 10) {
            console.log(sticky + " the cindition");
            navbar.classList.remove("scroll");
        }
    } else {
        navbar.classList.remove("sticky");

    }
}

$('.Toggle-button').on('click', function () {
    $('.animated-icon1').toggleClass('open');
});

$(".owl-carousel-banner ").css("position", "relative");
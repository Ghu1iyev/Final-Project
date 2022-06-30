

var mapCanvas = document.getElementById("map");
var mapOptions = {
    center: new google.maps.LatLng(51.5, -0.2), zoom: 10
}
var map = new google.maps.Map(mapCanvas, mapOptions);

let item = document.querySelectorAll(".item");
let btn = document.querySelector(".btn-active");
let hamburgerPage = document.querySelector(".hamburger-page");
let hamburgerIcon = document.querySelector(".nav-hamburger");

let nav = document.querySelector("nav")
btn.addEventListener("click", function(){
    alert("sddd")
})

hamburgerIcon.addEventListener('click',function(e){
    e.preventDefault()
    hamburgerPage.style.display="block";
})
hamburgerIcon.addEventListener('dblclick',function(e){
    e.preventDefault()
    hamburgerPage.classList.remove(".hamburger-page");
})
// function showHide(hamburgerIcon,hamburgerPage) {
//     var hamburgerIcon = document.getElementById("content");
//     var hamburgerPage = document.getElementById("text");
//     if (hamburgerIcon.style.display === "none") {
//         hamburgerIcon.style.display = "block";
//         hamburgerPage.innerHTML = 'See Less Benefits';
//     } else {
//         hamburgerPage.innerHTML = 'See More Benefits';
//       hamburgerIcon.style.display = "none";
//     }
//   }


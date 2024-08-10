const join = document.querySelector(".join"),
    overlay = document.querySelector(".overlay"),
    closeBtn = document.querySelector(".overlay .close");

join.addEventListener("click", () => {
    overlay.classList.add("active");
});

closeBtn.addEventListener("click", () => {
    overlay.classList.remove("active");
});
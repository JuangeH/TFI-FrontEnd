function expandCollapseBody() {
    const expand_btn = document.querySelector(".expand-btn");
    if (expand_btn) {
        expand_btn.addEventListener("click", () => {
            document.body.classList.toggle("collapsed");
        });
    }
}
function activateLinks() {
    const allLinks = document.querySelectorAll(".sidebar-links a");
    allLinks.forEach((elem) => {
        elem.addEventListener('click', function () {
            const hrefLinkClick = elem.href;
            allLinks.forEach((link) => {
                if (link.href == hrefLinkClick) {
                    link.classList.add("active");
                } else {
                    link.classList.remove('active');
                }
            });
        });
    });
}

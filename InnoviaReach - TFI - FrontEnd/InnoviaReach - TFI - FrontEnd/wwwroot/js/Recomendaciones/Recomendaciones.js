$(document).ready(function () {
    // sidebar toggle
    $("#navbar-show-btn").click(() => $('.navbar-collapse').removeClass('translate-x-full'));
    $('#navbar-hide-btn').click(() => $('.navbar-collapse').addClass('translate-x-full'));

    // stop transitin on resize
    let resizeTimer;
    $(window).on('resize', () => {
        $(document.body).addClass('resize-animation-stopper');
        clearTimeout(resizeTimer);
        resizeTimer = setTimeout(() => {
            $(document.body).removeClass('resize-animation-stopper');
        }, 400);
    });

    // game slider
    $('.game-slider').slick({
        className: "center",
        arrows: true,
        centerMode: true,
        infinite: true,
        centerPadding: "60px",
        slidesToShow: 3,
        slidesToScroll: 1,
        speed: 500,
        autoplay: true,
        dots: true,
        responsive: [
            {
                breakpoint: 1400,
                settings: {
                    slidesToShow: 3,
                }
            },
            {
                breakpoint: 992,
                settings: {
                    slidesToShow: 2,
                    initialSlide: 2
                }
            },
            {
                breakpoint: 768,
                settings: {
                    slidesToShow: 1,
                    dots: false
                }
            }
        ]
    });
});
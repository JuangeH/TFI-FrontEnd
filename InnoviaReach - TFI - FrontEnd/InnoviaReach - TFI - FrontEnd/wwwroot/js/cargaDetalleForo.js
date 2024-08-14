$('.newPost button[data-func]').click(function () {
    document.execCommand($(this).data('func'), false);
});

$('.newPost select[data-func]').change(function () {
    var $value = $(this).find(':selected').val();
    document.execCommand($(this).data('func'), false, $value);
});

if (typeof (Storage) !== "undefined") {

    $('.editor').keypress(function () {
        $(this).find('.saved').detach();
    });
    $('.editor').html(localStorage.getItem("wysiwyg"));

    $('button[data-func="save"]').click(function () {
        $content = $('.editor').html();
        localStorage.setItem("wysiwyg", $content);
        $('.editor').append('<span class="saved"><i class="fa fa-check"></i></span>').fadeIn(function () {
            $(this).find('.saved').fadeOut(500);
        });
    });

    $('button[data-func="clear"]').click(function () {
        $('.editor').html('');
        localStorage.removeItem("wysiwyg");
    });


} 

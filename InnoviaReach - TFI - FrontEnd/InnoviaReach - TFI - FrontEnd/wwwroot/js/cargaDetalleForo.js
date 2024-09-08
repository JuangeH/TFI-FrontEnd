$('.newPost button[data-func]').click(function () {
    document.execCommand($(this).data('func'), false);
});

// Guardar contenido en localStorage
$('button[data-func="save"]').click(function () {
    var $content = $('.editor').html();
    localStorage.setItem("wysiwyg", $content);
    $('.editor').append('<span class="saved"><i class="fa fa-check"></i></span>').fadeIn(function () {
        $(this).find('.saved').fadeOut(500);
    });
});

// Limpiar el contenido del editor
$('button[data-func="clear"]').click(function () {
    $('.editor').html('');
    localStorage.removeItem("wysiwyg");
});
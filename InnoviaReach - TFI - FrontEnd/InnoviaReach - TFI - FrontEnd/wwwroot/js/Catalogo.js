$(document).ready(function () {
    // categorywise filtering
    let buttonGroup = $('.cat-button-group .cat-button');
    let categoryItemsList = $('.category-item');
    let initialActiveCategory = $($(buttonGroup)[0]).data('filter');

    const setActiveButton = (categoryName) => {
        jQuery.each(buttonGroup, function (index, buttonItem) {
            if ($(buttonItem).data('filter') == categoryName) {
                $(buttonItem).addClass('cat-active-filter-button');
            } else {
                $(buttonItem).removeClass('cat-active-filter-button');
            }
        })
    }

    const filterItems = (categoryName) => {
        jQuery.each(categoryItemsList, function (index, categoryItem) {
            if ($(categoryItem).hasClass(categoryName)) {
                $(categoryItem).css('display', 'block');
            } else {
                $(categoryItem).css('display', 'none');
            }
        })
    }

    setActiveButton(initialActiveCategory);
    filterItems(initialActiveCategory);

    jQuery.each(buttonGroup, function (index, buttonItem) {
        $(buttonItem).click(function () {
            let categoryName = $(buttonItem).data('filter');
            setActiveButton(categoryName);
            filterItems(categoryName);
        });
    })
});
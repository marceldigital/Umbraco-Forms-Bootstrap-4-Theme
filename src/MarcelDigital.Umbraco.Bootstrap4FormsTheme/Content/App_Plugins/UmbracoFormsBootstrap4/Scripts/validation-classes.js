(function ($) {
    var defaultOptions = {
        validClass: '',
        errorClass: 'is-invalid'
    };

    $.validator.setDefaults(defaultOptions);

    $.validator.unobtrusive.options = {
        errorClass: defaultOptions.errorClass,
        validClass: defaultOptions.validClass,
    };
})(jQuery);
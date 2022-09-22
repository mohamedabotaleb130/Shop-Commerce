
$(document).on('click', '#show-icon', function () {
    $(this).toggleClass('fa-eye');
    $(this).toggleClass('fa-eye-slash');

    var passwordInput = $("input[name='password']");
    if (passwordInput.attr('type') === 'password') {
        passwordInput.prop('type', 'text');;
    } else {
        passwordInput.prop('type', 'password');;
    }
})
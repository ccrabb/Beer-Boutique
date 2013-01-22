window.bootstrap_alert = function () {
};
window.bootstrap_alert.info = function (message) {
    if ($('#alert').length) {
        $('#alert').html('<div class="alert alert-info"><a class="close" data-dismiss="alert">×</a><span>' + message + '</span></div>');
    } else {
        alert('#alert doesn\'t exist');
    }
};

window.bootstrap_alert.success = function (message) {
    if ($('#alert').length) {
        $('#alert').html('<div class="alert alert-success"><a class="close" data-dismiss="alert">×</a><span>' + message + '</span></div>');
    } else {
        alert('#alert doesn\'t exist');
    }
};

window.bootstrap_alert.error = function (message) {
    if ($('#alert').length) {
        $('#alert').html('<div class="alert alert-error"><a class="close" data-dismiss="alert">×</a><span>' + message + '</span></div>');
    } else {
        alert('#alert doesn\'t exist');
    }
};
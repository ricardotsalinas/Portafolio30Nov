$(document).ready(function () {



    $('[id$=txtRutLU]').keypress(function (event) {
        if (event.keyCode >= 48 && event.keyCode <= 57 || event.keyCode === 75 || event.keyCode === 107) {
            return;
        }
        return false;
    });

    $('[id$=rut_infr]').keypress(function (event) {
        if (event.keyCode >= 48 && event.keyCode <= 57 || event.keyCode === 75 || event.keyCode === 107) {
            return;
        }
        return false;
    });

});
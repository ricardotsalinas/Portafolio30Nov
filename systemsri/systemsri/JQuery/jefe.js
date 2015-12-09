$(document).ready(function () {




    /*Keypress validación de campos formulario 'datosJefe'*/

    $('[id$=txtTelefonoDJ]').keypress(function (event) {
        if (event.keyCode >= 48 && event.keyCode <= 57 || event.keyCode === 45) {
            return;
        }
        return false;
    });


    /*Keypress validación de campos formulario 'adminApelacion'*/

    $('[id$=txtRutAA]').keypress(function (event) {
        if (event.keyCode >= 48 && event.keyCode <= 57 || event.keyCode === 75 || event.keyCode === 107) {
            return;
        }
        return false;
    });

    /*Keypress validación de campos formulario 'casosApelacion'*/
    $('[id$=txtComentarioCA]').keypress(function (event) {
        if (event.keyCode >= 65 && event.keyCode <= 90 || event.keyCode >= 97 && event.keyCode <= 122 || event.keyCode >= 48 && event.keyCode <= 57) {
            return;
        }
        return false;
    });

    /*Keypress validación de campos formulario 'ConfigRestricciones'*/

    $('[id$=txtGravisimaCR]').keypress(function (event) {
        if (event.keyCode >= 48 && event.keyCode <= 57) {
            return;
        }
        return false;
    });

    $('[id$=txtGraveCR]').keypress(function (event) {
        if (event.keyCode >= 48 && event.keyCode <= 57) {
            return;
        }
        return false;
    });

    $('[id$=txtLeveCR]').keypress(function (event) {
        if (event.keyCode >= 48 && event.keyCode <= 57) {
            return;
        }
        return false;
    });

    $('[id$=txtDiasTempCR]').keypress(function (event) {
        if (event.keyCode >= 48 && event.keyCode <= 57) {
            return;
        }
        return false;
    });







});

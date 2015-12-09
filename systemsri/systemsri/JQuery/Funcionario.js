$(document).ready(function () {



    /*Keypress validación de campos formulario 'admFun'*/

    $('[id$=rut_infr]').keypress(function (event) {
        if (event.keyCode >= 48 && event.keyCode <= 57 || event.keyCode === 75 || event.keyCode === 107) {
            return;
        }
        return false;
    });

    /*Keypress validación de campos formulario 'admFun'*/

    $('[id$=txtRutAF]').keypress(function (event) {
        if (event.keyCode >= 48 && event.keyCode <= 57 || event.keyCode === 75 || event.keyCode === 107) {
            return;
        }
        return false;
    });

    $('[id$=txtFonoAF]').keypress(function (event) {
        if (event.keyCode >= 48 && event.keyCode <= 57 || event.keyCode === 45) {
            return;
        }
        return false;
    });

    /*Keypress validación de campos formulario 'generaFUn'*/

    $('[id$=txtRutGF]').keypress(function (event) {
        if (event.keyCode >= 48 && event.keyCode <= 57 || event.keyCode === 75 || event.keyCode === 107) {
            return;
        }
        return false;
    });

    $('[id$=txtDetAdicGF]').keypress(function (event) {
        if (event.keyCode >= 65 && event.keyCode <= 90 || event.keyCode >= 97 && event.keyCode <= 122 || event.keyCode >= 48 && event.keyCode <= 57) {
            return;
        }
        return false;
    });





});

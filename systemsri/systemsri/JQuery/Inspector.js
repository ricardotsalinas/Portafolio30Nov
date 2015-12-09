$(document).ready(function () {


    /*Keypress validación de campos formulario 'datosInspector'*/


    $('[id$=txtTelefonoDIn]').keypress(function (event) {
        if (event.keyCode >= 48 && event.keyCode <= 57 || event.keyCode === 45) {
            return;
        }
        return false;
    });

    /*Keypress validación de campos formulario 'ingresoMulta'*/
    $('[id$=txtPatIM]').keypress(function (event) {
        if (event.keyCode >= 65 && event.keyCode <= 90 || event.keyCode >= 97 && event.keyCode <= 122 || event.keyCode >= 48 && event.keyCode <= 57) {
            return;
        }
        return false;
    });


    


});







$(document).ready(function () {



    //NO ES OBLIGATORIO QUE EL INFRACTOR GUARDE SU TELEFONO O EMAIL



    /*Keypress validación de campos formulario 'admFun'*/

    $('[id$=fono_infractor]').keypress(function (event) {
        if (event.keyCode >= 48 && event.keyCode <= 57) {
            return;
        }
        return false;
    });



});

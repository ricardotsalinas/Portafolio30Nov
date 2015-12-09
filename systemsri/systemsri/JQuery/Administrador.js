$(document).ready(function () {




    /*Keypress validación de campos formulario 'formAdminUsuarios'*/

    $('[id$=txtRutAU]').keypress(function (event) 
    {
        if (event.keyCode >= 48 && event.keyCode <= 57 || event.keyCode === 75 || event.keyCode === 107) 
        {
            return;
        }
        return false;
    });

    $('[id$=txtNomAU]').keypress(function (event) {
        if (event.keyCode >= 65 && event.keyCode <= 90 || event.keyCode >= 97 && event.keyCode <= 122) {
            return;
        }
        return false;
    });

    $('[id$=txtAppatAU]').keypress(function (event) {
        if (event.keyCode >= 65 && event.keyCode <= 90 || event.keyCode >= 97 && event.keyCode <= 122) {
            return;
        }
        return false;
    });

    $('[id$=txtApmatAU]').keypress(function (event) {
        if (event.keyCode >= 65 && event.keyCode <= 90 || event.keyCode >= 97 && event.keyCode <= 122) {
            return;
        }
        return false;
    });
 
    $('[id$=txtDireccion]').keypress(function (event) 
    {
        if (event.keyCode >= 65 && event.keyCode <= 90 || event.keyCode >= 97 && event.keyCode <= 122 || event.keyCode >= 48 && event.keyCode <= 57) {
            return;
        }
        return false;
    });

    $('[id$=txtTelefono]').keypress(function (event) {
        if (event.keyCode >= 48 && event.keyCode <= 57 || event.keyCode === 45) {
            return;
        }
        return false;
    });



    /*Keypress validación de campos formulario 'adminCalles'*/

    $('[id$=txtNombreCalle]').keypress(function (event) {
        if (event.keyCode >= 65 && event.keyCode <= 90 || event.keyCode >= 97 && event.keyCode <= 122 || event.keyCode >= 48 && event.keyCode <= 57) {
            return;
        }
        return false;
    });



    /*Keypress validación de campos formulario 'adminInfracciones'*/

    $('[id$=txtValorAI]').keypress(function (event) 
        {
         if (event.keyCode >= 48 && event.keyCode <= 57 || event.keyCode === 44 || event.keyCode === 46) 
            {
             return;
            }
            return false;
    });
});


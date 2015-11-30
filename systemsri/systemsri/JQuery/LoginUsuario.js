$(document).ready(function () {

    $('[id$=bot_logUsuario]').click(function () {

        var n = 0;
        if ($('[id$=input_RutUsuario]').val() === '' || $('[id$=input_RutUsuario]').val() === null) {
            $('[id$=input_RutUsuario]').removeClass().addClass('cr_iusuario');
            n = 1;
        }
        else
            $('[id$=input_RutUsuario]').removeClass().addClass('input_usuario');


        if ($('[id$=input_ConUsuario]').val() === '' || $('[id$=input_ConUsuario]').val() === null) {
            $('[id$=input_ConUsuario]').removeClass().addClass('cr_iusuario');
            n = 1;
        }
        else
            $('[id$=input_ConUsuario]').removeClass().addClass('input_usuario');

        if (n === 1) {
            $('[id$=label_campos_usuarios]').show();
            alert("Ingrese su Rut y Contraseña");
            return false;
        }
        else {

            $('[id$=input_RutUsuario]').val('');
            $('[id$=input_ConUsuario]').val('');
            $('[id$=label_campos_usuarios]').hide();
        }
    });


    $('[id$=input_RutUsuario]').keypress(function (event) {
        if (event.keyCode >= 48 && event.keyCode <= 57 || event.keyCode === 75 || event.keyCode === 107) {
            return;
        }
        return false;
    });

});
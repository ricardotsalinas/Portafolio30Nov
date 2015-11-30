$(document).ready(function () {


    //*Boton click borrar formulario 'admFun' ; 'generFun'

    $('[id$=bot_borrar_multa]').click(function (event) {
        $('[id$=formIngresaMulta]').trigger("reset");
    });



    //*Boton bot_guardar_datos validación de campos del formulario 'ingresaMulta'

    $('[id$=bot_guardar_multa]').click(function (event) {

        var n = 0;

        if ($('[id$=patente_multa]').val() === '' || $('[id$=patente_multa]').val() === null) {
            $('[id$=patente_multa]').removeClass().addClass('er_input1');
            n = 1;
        }
        else
            $('[id$=patente_multa]').removeClass().addClass('input1');


        if ($('[id$=motivo_multa]').val() === '' || $('[id$=motivo_multa]').val() === null) {
            $('[id$=motivo_multa]').removeClass().addClass('er_input1');
            n = 1;
        }
        else
            $('[id$=motivo_multa]').removeClass().addClass('input1');


        if ($('[id$=lug_inf]').val() === '' || $('[id$=lug_inf]').val() === null) {
            $('[id$=lug_inf]').removeClass().addClass('er_input1');
            n = 1;
        }
        else
            $('[id$=lug_inf]').removeClass().addClass('input1');



        if (n === 1) {
            alert("Los campos marcados en rojo son oligatorios");
            return false;
        }
        else {
            $('[id$=formIngresaMulta]').trigger("reset");
            alert("Los datos han sido guardados exitosamente");

        }
    });




    //*Keypress validación de campos formulario 'admFun'


    $('[id$=patente_multa]').keypress(function (event) {
        if (event.keyCode >= 48 && event.keyCode <= 57 || event.keyCode >= 65 && event.keyCode <= 90 || event.keyCode >= 97 && event.keyCode <= 122) {
            return;
        }
        return false;
    });




});







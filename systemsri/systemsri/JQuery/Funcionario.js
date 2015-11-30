$(document).ready(function () {

    //* pendiente validar email 08-11-2015 / 22:50



    //*Boton click borrar formulario 'admFun' ; 'generFun'

    $('[id$=bot_borrar_infractor]').click(function () {
        $('[id$=formAdmfun]').trigger("reset");
    });

    $('[id$=bot_borrar_turno]').click(function () {
        $('[id$=formGeneraFun]').trigger("reset");
    });






    //*Boton bot_buscar_infractor validación del campo Rut Infractor

    $('[id$=bot_buscar_infractor]').click(function (event) {
        var n = 0;


        if ($('[id$=rut_infr]').val() === '' || $('[id$=rut_infr]').val() === null) {
            n = 1
        }


        if (n == 1) {
            alert("Por favor, ingrese el número de Rut para búsqueda ");
            return false;
        }

    });




    //*Boton bot_guardar_datos validación de campos del formulario 'admFun'

    $('[id$=bot_guardar_datos]').click(function (event) {

        var n = 0;

        if ($('[id$=rut_infr]').val() === '' || $('[id$=rut_infr]').val() === null) {
            $('[id$=rut_infr]').removeClass().addClass('er_input1');
            n = 1;
        }
        else
            $('[id$=rut_infr]').removeClass().addClass('input1');



        if ($('[id$=nom_infr]').val() === '' || $('[id$=nom_infr]').val() === null) {
            $('[id$=nom_infr]').removeClass().addClass('er_input1');
            n = 1;
        }
        else
            $('[id$=nom_infr]').removeClass().addClass('input1');


        if ($('[id$=fnac_inf]').val() === '' || $('[id$=fnac_inf]').val() === null) {
            $('[id$=fnac_inf]').removeClass().addClass('er_input1');
            n = 1;
        }
        else
            $('[id$=fnac_inf]').removeClass().addClass('input1');


        if ($('[id$=fono_infr]').val() === '' || $('[id$=fono_infr]').val() === null) {
            $('[id$=fono_infr]').removeClass().addClass('er_input1');
            n = 1;
        }
        else
            $('[id$=fono_infr]').removeClass().addClass('input1');


        if ($('[id$=dir_infr]').val() === '' || $('[id$=dir_infr]').val() === null) {
            $('[id$=dir_infr]').removeClass().addClass('er_input1');
            n = 1;
        }
        else
            $('[id$=dir_infr]').removeClass().addClass('input1');

        if ($('[id$=appat_infr]').val() === '' || $('[id$=appat_infr]').val() === null) {
            $('[id$=appat_infr]').removeClass().addClass('er_input1');
            n = 1;
        }
        else
            $('[id$=appat_infr]').removeClass().addClass('input1');


        if ($('[id$=apmat_infr]').val() === '' || $('[id$=apmat_infr]').val() === null) {
            $('[id$=apmat_infr]').removeClass().addClass('er_input1');
            n = 1;
        }
        else
            $('[id$=apmat_infr]').removeClass().addClass('input1');


        if ($('[id$=email_infr]').val() === '' || $('[id$=email_infr]').val() === null) {
            $('[id$=email_infr]').removeClass().addClass('er_input1');
            n = 1;
        }
        else
            $('[id$=email_infr]').removeClass().addClass('input1');

        if ($('[id$=fnac_infr]').val() === '' || $('[id$=fnac_infr]').val() === null) {
            $('[id$=fnac_infr]').removeClass().addClass('er_input1');
            n = 1;
        }
        else
            $('[id$=fnac_infr]').removeClass().addClass('input1');



        if (n === 1) {
            alert("Los campos marcados en rojo son oligatorios");
            return false;
        }
        else {
            $('[id$=formAdmfun]').trigger("reset");
            alert("Los datos han sido guardados exitosamente");

        }
    });





    $('[id$=bot_buscar_turno]').click(function (event) {
        var n = 0;
        if ($('[id$=rut_gt]').val() === '' || $('[id$=rut_gt]').val() === null) {
            n = n + 1
        }
        if ($('[id$=sector_gt]').val() === '' || $('[id$=sector_gt]').val() === null) {
            n = n + 1
        }
        if ($('[id$=sector_gt]').val() === '' || $('[id$=sector_gt]').val() === null) {
            n = n + 1
        }
        if ($('[id$=fec_gt]').val() === '' || $('[id$=fec_gt]').val() === null) {
            n = n + 1
        }
        if ($('[id$=hit_gt]').val() === '' || $('[id$=hit_gt]').val() === null) {
            n = n + 1
        }
        if ($('[id$=htt_gt]').val() === '' || $('[id$=htt_gt]').val() === null) {
            n = n + 1
        }

        if (n >= 6) {
            alert("Por favor, ingrese al menos el número de Rut, para búsqueda ");
            return false;
        }

    });


    //*Boton bot_guardar_turno validación de campos del formulario 'generaFun'

    $('[id$=bot_guardar_turno]').click(function (event) {
        var n = 0;

        if ($('[id$=rut_gt]').val() === '' || $('[id$=rut_gt]').val() === null) {
            $('[id$=rut_gt]').removeClass().addClass('er_input1');
            n = 1;
        }
        else
            $('[id$=rut_gt]').removeClass().addClass('input1');

        if ($('[id$=sector_gt]').val() === '' || $('[id$=sector_gt]').val() === null) {
            $('[id$=sector_gt]').removeClass().addClass('er_ddlist');
            n = 1;
        }
        else
            $('[id$=sector_gt]').removeClass().addClass('ddlist');

        if ($('[id$=fec_gt]').val() === '' || $('[id$=fec_gt]').val() === null) {
            $('[id$=fec_gt]').removeClass().addClass('er_input1');
            n = 1;
        }
        else
            $('[id$=fec_gt]').removeClass().addClass('input1');

        if ($('[id$=hit_gt]').val() === '' || $('[id$=hit_gt]').val() === null) {
            $('[id$=hit_gt]').removeClass().addClass('er_input4');
            n = 1;
        }
        else
            $('[id$=hit_gt]').removeClass().addClass('input4');

        if ($('[id$=htt_gt]').val() === '' || $('[id$=htt_gt]').val() === null) {
            $('[id$=htt_gt]').removeClass().addClass('er_input4');
            n = 1;
        }
        else
            $('[id$=htt_gt]').removeClass().addClass('input4');


        if (n === 1) {
            alert("Los campos marcados en rojo son oligatorios");
            return false;
        }
        else {
            $('[id$=formGeneraFun]').trigger("reset");
            alert("Los datos han sido guardados exitosamente");

        }
    });





    //*Keypress validación de campos formulario 'admFun'

    $('[id$=rut_gt]').keypress(function (event) {
        if (event.keyCode >= 48 && event.keyCode <= 57 || event.keyCode === 75 || event.keyCode === 107) {
            return;
        }
        return false;
    });


    $('[id$=nom_infr]').keypress(function (event) {
        if (event.keyCode >= 65 && event.keyCode <= 90 || event.keyCode >= 97 && event.keyCode <= 122) {
            return;
        }
        return false;
    });

    /* 
    $('[id$=email_infr]').keypress(function (event) {
    if (event.keyCode === /^[a-zA-Z0-9\._-]+@[a-zA-Z0-9-]{2,}[.][a-zA-Z]{2,4}$/)
    {
    return;
    }
    return false;
    });*/


    $('[id$=fono_infr]').keypress(function (event) {
        if (event.keyCode >= 48 && event.keyCode <= 57) {
            return;
        }
        return false;
    });

    $('[id$=dir_infr]').keypress(function (event) {
        if (event.keyCode >= 48 && event.keyCode <= 57 || event.keyCode >= 65 && event.keyCode <= 90 || event.keyCode >= 97 && event.keyCode <= 122) {
            return;
        }
        return false;
    });


    //*Keypress validación de campos formulario 'admFun'

    $('[id$=rut_infr]').keypress(function (event) {
        if (event.keyCode >= 48 && event.keyCode <= 57 || event.keyCode === 75 || event.keyCode === 107) {
            return;
        }
        return false;
    });


});









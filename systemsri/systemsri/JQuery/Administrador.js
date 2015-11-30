
$(document).ready(function () {


    //*Boton click buscar formulario 'inicioAdmin'
    $('[id$=bot_buscar_adm]').click(function (event) {
        var n = 0;


        if ($('[id$=rut_admin]').val() === '' || $('[id$=rut_admin]').val() === null) {

            n = 1;
        }

        if (n === 1) {
            alert("Ingrese el Rut a Consultar");

            return false;
        }
    });
    //*Boton click borrar formulario 'inicioAdmin' ; 'adminCalles' ; 'adminInfracciones'

    $('[id$=bot_borrar_adm]').click(function () {
        $('[id$=formAdminUsuarios]').trigger("reset");
    });

    $('[id$=bot_borrar_calles]').click(function () {
        $('[id$=formAdminCalles]').trigger("reset");
    });

    $('[id$=bot_borrar_infraccion]').click(function () {
        $('[id$=formAdminInfracciones]').trigger("reset");
    });


  


    //*Boton click buscar calles 'adminCalles'
    $('[id$=bot_buscar_calles]').click(function (event) {
        var n = 0;

        if ($('[id$=nombre_calle]').val() === '' || $('[id$=nombre_calle]').val() === null) {

            n = n + 1;
        }
        if ($('[id$=numero_pistas]').val() === '' || $('[id$=numero_pistas]').val() === null) {

            n = n + 1;
        }
        if ($('[id$=orientacion]').val() === '' || $('[id$=orientacion]').val() === null) {

            n = n + 1;
        }
        if ($('[id$=vel_maxima]').val() === '' || $('[id$=vel_maxima]').val() === null) {

            n = n + 1;
        }
        if ($('[id$=sentido]').val() === '' || $('[id$=sentido]').val() === null) {

            n = n + 1;
        }
        if ($('[id$=sector]').val() === '' || $('[id$=sector]').val() === null) {

            n = n + 1;
        }

        if (n >= 6) {
            alert("Por favor, ingrese al menos el nombre de la calle, para búsqueda ");
            return false;
        }

    });




    //*Boton bot_guardar_calles validación de campos del formulario 'adminCalles'

    $('[id$=bot_guardar_calles]').click(function (event) {
        var n = 0;

        if ($('[id$=nombre_calle]').val() === '' || $('[id$=nombre_calle]').val() === null) {
            $('[id$=nombre_calle]').removeClass().addClass('er_input1');
            n = 1;
        }
        else
            $('[id$=nombre_calle]').removeClass().addClass('input1');


        if ($('[id$=numero_pistas]').val() === '' || $('[id$=numero_pistas]').val() === null) {
            $('[id$=numero_pistas]').removeClass().addClass('er_ddlist');
            n = 1;
        }
        else
            $('[id$=numero_pistas]').removeClass().addClass('ddlist');


        if ($('[id$=orientacion]').val() === '' || $('[id$=orientacion]').val() === null) {
            $('[id$=orientacion]').removeClass().addClass('er_ddlist');
            n = 1;
        }
        else
            $('[id$=orientacion]').removeClass().addClass('ddlist');


        if ($('[id$=vel_maxima]').val() === '' || $('[id$=vel_maxima]').val() === null) {
            $('[id$=vel_maxima]').removeClass().addClass('er_ddlist');
            n = 1;
        }
        else
            $('[id$=vel_maxima]').removeClass().addClass('ddlist');


        if ($('[id$=sentido]').val() === '' || $('[id$=sentido]').val() === null) {
            $('[id$=sentido]').removeClass().addClass('er_ddlist');
            n = 1;
        }
        else
            $('[id$=sentido]').removeClass().addClass('ddlist');


        if ($('[id$=sector]').val() === '' || $('[id$=sector]').val() === null) {
            $('[id$=sector]').removeClass().addClass('er_ddlist');
            n = 1;
        }
        else
            $('[id$=sector]').removeClass().addClass('ddlist');


        if (n === 1) {
            alert("Los campos marcados en rojo son oligatorios");
            return false;
        }
        else {
            $('[id$=formAdminCalles]').trigger("reset");
            alert("Los datos han sido guardados exitosamente");

        }
    });


    //*Boton click buscar calles 'adminInfracciones'
    $('[id$=bot_buscar_infraccion]').click(function (event) {
        var n = 0;

        if ($('[id$=grav_infr]').val() === '' || $('[id$=grav_infr]').val() === null) {
            alert("Ingrese al menos, la gravedad de infracción a Consultar");
            n = 1;
        }

        if (n === 1) {
            return false;
        }

    });

    //*Boton bot_guardar_infraccion validación de campos del formulario 'adminInfracciones'

    $('[id$=bot_guardar_infraccion]').click(function (event) {
        var n = 0;

        if ($('[id$=grav_infr]').val() === '' || $('[id$=grav_infr]').val() === null) {
            $('[id$=grav_infr]').removeClass().addClass('er_ddlist');
            n = 1;
        }
        else
            $('[id$=grav_infr]').removeClass().addClass('ddlist');


        if ($('[id$=tipo_moneda]').val() === '' || $('[id$=tipo_moneda]').val() === null) {
            $('[id$=tipo_moneda]').removeClass().addClass('er_ddlist');
            n = 1;
        }
        else
            $('[id$=tipo_moneda]').removeClass().addClass('ddlist');


        if ($('[id$=valor_infr]').val() === '' || $('[id$=valor_infr]').val() === null) {
            $('[id$=valor_infr]').removeClass().addClass('er_input1');
            n = 1;
        }
        else
            $('[id$=valor_infr]').removeClass().addClass('input1');


        if ($('[id$=desc_infr]').val() === '' || $('[id$=desc_infr]').val() === null) {
            $('[id$=desc_infr]').removeClass().addClass('er_input2');
            n = 1;
        }
        else
            $('[id$=desc_infr]').removeClass().addClass('input2');


        if (n === 1) {
            alert("Los campos marcados en rojo son oligatorios");
            return false;
        }

    });




    //*Keypress validación de campos formulario 'adminUsuarios'

    $('[id$=rut_admin]').keypress(function (event) {
        if (event.keyCode >= 48 && event.keyCode <= 57 || event.keyCode === 75 || event.keyCode === 107) {
            return;
        }
        return false;
    });

    $('[id$=nom_admin]').keypress(function (event) {
        if (event.keyCode >= 65 && event.keyCode <= 90 || event.keyCode >= 97 && event.keyCode <= 122) {
            return;
        }
        return false;
    });

    $('[id$=pat_admin]').keypress(function (event) {
        if (event.keyCode >= 65 && event.keyCode <= 90 || event.keyCode >= 97 && event.keyCode <= 122) {
            return;
        }
        return false;
    });

    $('[id$=mat_admin]').keypress(function (event) {
        if (event.keyCode >= 65 && event.keyCode <= 90 || event.keyCode >= 97 && event.keyCode <= 122) {
            return;
        }
        return false;
    });



    //*Keypress validación de campos formulario 'adminCalles'

    $('[id$=nombre_calle]').keypress(function (event) {
        if (event.keyCode >= 48 && event.keyCode <= 57 || event.keyCode >= 65 && event.keyCode <= 90 || event.keyCode >= 97 && event.keyCode <= 122) {
            return;
        }
        return false;
    });



    //*Keypress validación de campos formulario 'adminInfracciones'

    $('[id$=valor_infr]').keypress(function (event) {
        if (event.keyCode >= 48 && event.keyCode <= 57 || event.keyCode === 44 || event.keyCode === 46) {
            return;
        }
        return false;
    });

    $('[id$=desc_infr]').keypress(function (event) {
        if (event.keyCode >= 48 && event.keyCode <= 57 || event.keyCode >= 65 && event.keyCode <= 90 ||
            event.keyCode >= 97 && event.keyCode <= 122) {
            return;
        }
        return false;
    });


    // Validador de Rut
    /*
    function revisarDigito(dvr) {
    dv = dvr + ""
    if (dv != '0' && dv != '1' && dv != '2' && dv != '3' && dv != '4' && dv != '5' && dv != '6' && dv != '7' && dv != '8' && dv != '9' && dv != 'k' && dv != 'K') {
    alert("Debe ingresar un digito verificador valido");
    window.document.form1.rut.focus();
    window.document.form1.rut.select();
    return false;
    }
    return true;
    }
    */
    /*
    function revisarDigito2(crut) {
    largo = crut.length;
    if (largo < 5) {
    alert("Debe ingresar el rut completo")
    window.document.form1.rut.focus();
    window.document.form1.rut.select();
    return false;
    }
    if (largo > 5)
    rut = crut.substring(0, largo - 1);
    else
    rut = crut.charAt(0);
    dv = crut.charAt(largo - 1);
    revisarDigito(dv);

    if (rut == null || dv == null)
    return 0

    var dvr = '0'
    suma = 0
    mul = 2

    for (i = rut.length - 1; i >= 0; i--) {
    suma = suma + rut.charAt(i) * mul
    if (mul == 7)
    mul = 2
    else
    mul++
    }
    res = suma % 11
    if (res == 1)
    dvr = 'k'
    else if (res == 0)
    dvr = '0'
    else {
    dvi = 11 - res
    dvr = dvi + ""
    }
    if (dvr != dv.toLowerCase()) {
    alert("EL rut es incorrecto")
    window.document.form1.rut.focus();
    window.document.form1.rut.select();
    return false
    }

    return true
    }

    function Rut(texto) {
    var tmpstr = "";
    for (i = 0; i < texto.length; i++)
    if (texto.charAt(i) != ' ' && texto.charAt(i) != '.' && texto.charAt(i) != '-')
    tmpstr = tmpstr + texto.charAt(i);
    texto = tmpstr;
    largo = texto.length;

    if (largo < 2) {
    alert("Debe ingresar el rut completo")
    window.document.form1.rut.focus();
    window.document.form1.rut.select();
    return false;
    }

    for (i = 0; i < largo; i++) {
    if (texto.charAt(i) != "0" && texto.charAt(i) != "1" && texto.charAt(i) != "2" && texto.charAt(i) != "3" && texto.charAt(i) != "4" && texto.charAt(i) != "5" && texto.charAt(i) != "6" && texto.charAt(i) != "7" && texto.charAt(i) != "8" && texto.charAt(i) != "9" && texto.charAt(i) != "k" && texto.charAt(i) != "K") {
    alert("El valor ingresado no corresponde a un R.U.T valido");
    window.document.form1.rut.focus();
    window.document.form1.rut.select();
    return false;
    }
    }

    var invertido = "";
    for (i = (largo - 1), j = 0; i >= 0; i--, j++)
    invertido = invertido + texto.charAt(i);
    var dtexto = "";
    dtexto = dtexto + invertido.charAt(0);
    dtexto = dtexto + '-';
    cnt = 0;

    for (i = 1, j = 2; i < largo; i++, j++) {
    //alert("i=[" + i + "] j=[" + j +"]" );		
    if (cnt == 3) {
    dtexto = dtexto + '.';
    j++;
    dtexto = dtexto + invertido.charAt(i);
    cnt = 1;
    }
    else {
    dtexto = dtexto + invertido.charAt(i);
    cnt++;
    }
    }

    invertido = "";
    for (i = (dtexto.length - 1), j = 0; i >= 0; i--, j++)
    invertido = invertido + dtexto.charAt(i);

    window.document.form1.rut.value = invertido.toUpperCase()

    if (revisarDigito2(texto))
    return true;

    return false;
    }
    */


});


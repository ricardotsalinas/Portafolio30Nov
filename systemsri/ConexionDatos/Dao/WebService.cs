using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConexionDatos.Dao
{
    public class WebService
    {

        public static WebService instancia = new WebService();

        RegistroCivil.RegistroCivilWS registroCivil = new RegistroCivil.RegistroCivilWS();


        public ArrayList datosRegistroCivil(String patente)
        {
            ArrayList datosRegistros = new ArrayList();
            var datos = registroCivil.Registro(patente);

            if (datos != null)
            {
                foreach (var item in datos)
                {
                    datosRegistros.Add(item);
                }
            }
            else
            {
                datosRegistros.Add("error");
            }

            return datosRegistros;
        }


         
    }
}

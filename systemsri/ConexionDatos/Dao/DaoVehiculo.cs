using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConexionDatos.Entity;
using System.Data.Entity;

namespace ConexionDatos.Dao
{
    public class DaoVehiculo
    {
        public static DaoVehiculo Instancia= new DaoVehiculo();
        public VEHICULO buscarPatente(String pat)
        {
            using (SRI contex = new SRI())
            {
                VEHICULO lbuscar = new VEHICULO();
                lbuscar = contex.VEHICULO.Where(a => a.PATENTE == pat).FirstOrDefault();
                return lbuscar;
            }
        }


    }
}

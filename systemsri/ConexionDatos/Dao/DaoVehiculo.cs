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
        private int retornarNuevoId()
        {
            int id = 0;
            using (SRI sri = new SRI())
            {
                id = (int)sri.VEHICULO.DefaultIfEmpty().Max(p => p == null ? 0 : p.ID_VEHICULO) + 1;
                return id;
            }
        }


        public int existeVehiculo(String patente)
        {
            int id = 0;
            List<VEHICULO> ve = new List<VEHICULO>();
            using (SRI con = new SRI())
            {
                ve = con.VEHICULO.Where(v => v.PATENTE == patente).ToList();
            }
            foreach(var item in ve)
            {
                id = (int)item.ID_VEHICULO;
            }
            return id;
        }

        public int crearVehiculo(String patente)
        {
            try
            {
                using (SRI con = new SRI())
                {
                    VEHICULO v = new VEHICULO();
                    v.ID_VEHICULO = retornarNuevoId();
                    v.PATENTE = patente;
                    v.ID_TIPO_VEHICULO = 16;
                    con.VEHICULO.AddObject(v);
                    con.SaveChanges();
                    return (int)v.ID_VEHICULO;
                }
            }
            catch (Exception e)
            {
                return 0;
            }
        }


    }
}

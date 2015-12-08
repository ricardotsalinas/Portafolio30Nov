using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess;
using ConexionDatos.Entity;
using ClasesESpeciales;


namespace ConexionDatos.Dao
{
    public class DaoInfraccion
    {
        public static DaoInfraccion instancia = new DaoInfraccion();

        public int tipoMoneda(int idMotivo)
        {
            using (SRI con = new SRI())
            {
                INFRACCION objinf = new INFRACCION();
                objinf = con.INFRACCION.Where(i => i.ID_DETALLE_INFRACCION == idMotivo).FirstOrDefault();
                return (int)objinf.ID_TIPO_MONEDA;
            }
        }

        public int idInfraccion(int idMotivo)
        {
            using (SRI con = new SRI())
            {
                INFRACCION objinf = new INFRACCION();
                objinf = con.INFRACCION.Where(i => i.ID_DETALLE_INFRACCION == idMotivo).FirstOrDefault();
                return (int)objinf.ID_INFRACCION;
            }
        }

        private int retornarNuevoId()
        {
            int id = 0;
            using (SRI sri = new SRI())
            {
                id = (int)sri.INFRACCION.DefaultIfEmpty().Max(p => p == null ? 0 : p.ID_INFRACCION) + 1;
                return id;
            }
        }

        public int crearInfraccion(INFRACCION objinfrac, String descripcion, int tipo)
        {
            try
            {
                using (SRI con = new SRI())
                {
                    if (tipo > 0)
                    {
                        INFRACCION infra = new INFRACCION();
                        infra = con.INFRACCION.Where(i => i.ID_INFRACCION == tipo).FirstOrDefault();
                        infra.ID_GRAVEDAD = objinfrac.ID_GRAVEDAD;
                        infra.MONTO = objinfrac.MONTO;
                        infra.ID_TIPO_MONEDA = objinfrac.ID_TIPO_MONEDA;
                        infra.PUNTAJE_GRAV = objinfrac.PUNTAJE_GRAV;
                        con.SaveChanges();
                        DETALLE_CARACTERISTICA deta = new DETALLE_CARACTERISTICA();
                        deta = con.DETALLE_CARACTERISTICA.Where(d => d.ID_DETCAR == infra.ID_DETALLE_INFRACCION).FirstOrDefault();
                        deta.DETALLE_CAR = descripcion;
                        con.SaveChanges();
                        return 2;
                    }
                    else
                    {
                        DETALLE_CARACTERISTICA objdetalle = new DETALLE_CARACTERISTICA();
                        objdetalle.DETALLE_CAR = descripcion;
                        objdetalle.ID_CARACTERISTICA = 9;
                        objinfrac.ID_DETALLE_INFRACCION = DaoDetalleCaracteristica.instancia.CrearDetalleCaracteristica(objdetalle);
                        objinfrac.ID_INFRACCION = retornarNuevoId();
                        con.INFRACCION.AddObject(objinfrac);
                        con.SaveChanges();
                        return 1;
                    }
                }
            }
            catch (Exception e)
            {
                return 0;
            }
        
        }
    }
}

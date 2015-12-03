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
    }
}

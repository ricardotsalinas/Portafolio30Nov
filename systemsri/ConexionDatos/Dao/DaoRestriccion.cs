using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConexionDatos.Entity;
using ClasesESpeciales;
using Oracle.DataAccess;

namespace ConexionDatos.Dao
{
    public class DaoRestriccion
    {
        public static DaoRestriccion instancia = new DaoRestriccion();

        public int idRestriccion()
        {
            using(SRI con = new SRI())
            {
                return (int)con.RESTRICCION.DefaultIfEmpty().Max(r => r==null ? 0 : r.ID_RESTRICCION);
            }
        }
    }
}

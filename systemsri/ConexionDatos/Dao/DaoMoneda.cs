using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess;
using ConexionDatos.Entity;
using ClasesESpeciales;


namespace ConexionDatos.Dao
{
    public class DaoMoneda
    {
        public static DaoMoneda instancia = new DaoMoneda();


        public int idMoneda(int tipo)
        {
            int id = 0;

            using(SRI con = new SRI())
            {
               id = (int)con.MONEDA.Where(m => m.ID_TIPO_MONEDA == tipo).Max(m => m.ID_MONEDA);

            }
            return id;
        
        }
    }
}

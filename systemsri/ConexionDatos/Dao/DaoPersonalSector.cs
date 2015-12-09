using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess;
using ConexionDatos.Entity;
using ClasesESpeciales;


namespace ConexionDatos.Dao
{
    public class DaoPersonalSector
    {
        public static DaoPersonalSector instancia = new DaoPersonalSector();

        private int retornarNuevoId()
        {
            int id = 0;
            using (SRI sri = new SRI())
            {
                id = (int)sri.PERSONAL_SECTOR.DefaultIfEmpty().Max(p => p == null ? 0 : p.ID_PERSONAL_SECTOR) + 1;
                return id;
            }
        }

        public void creaPersonalSector(PERSONAL_SECTOR perso)
        {
            try
            {
                using (SRI con = new SRI())
                {
                    perso.ID_PERSONAL_SECTOR = retornarNuevoId();
                    con.PERSONAL_SECTOR.AddObject(perso);
                    con.SaveChanges();

                }
            }
            catch (Exception e)
            { 
               
            }
        }





    }
}

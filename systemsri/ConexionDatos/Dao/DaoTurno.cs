using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConexionDatos.Entity;
using ClasesESpeciales;

namespace ConexionDatos.Dao
{
    public class DaoTurno
    {
        public static DaoTurno instanacia = new DaoTurno();

        private int retornarNuevoId()
        {
            int id = 0;
            using (SRI sri = new SRI())
            {
                id = (int)sri.TURNO.DefaultIfEmpty().Max(p => p == null ? 0 : p.ID_TURNO) + 1;
                return id;
            }
        }


        public int grabarTurno(TURNO tur)
        {
            try
            {
                using (SRI con = new SRI())
                {
                    tur.ID_TURNO = retornarNuevoId();
                    con.TURNO.AddObject(tur);
                    con.SaveChanges();
                    return 1;
                }
            
            }
            catch
            {
                return 0;
            }
        
        }

        public int buscarSector(int sector)
        {
            using (SRI con = new SRI())
            {
                SECTOR sec = new SECTOR();

                sec = con.SECTOR.Where(s => s.ID_NOMBRE_SECTOR == sector).FirstOrDefault();
                return (int)sec.ID_SECTOR;

            }

            
        
        }

    }
}


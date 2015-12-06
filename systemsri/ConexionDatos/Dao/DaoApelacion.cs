using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess;
using ConexionDatos.Entity;

namespace ConexionDatos.Dao
{
    public class DaoApelacion
    {
        public static DaoApelacion instancia = new DaoApelacion();

        private int RetornarNuevoId()
        {
            int id = 0;
            using (SRI sri = new SRI())
            {
                id = (int)sri.APELACION.DefaultIfEmpty().Max(p => p ==null ? 0 :  p.ID_APELACION)+1;
    
                return id;
            }
        }


        public int crearApelacion(APELACION ape,int idAdjunto)
        {
            try
            {
                using (SRI sri = new SRI())
                {
                    int id = RetornarNuevoId();
                    ape.ID_APELACION = id;
                    ape.ACEPTADO = "9";

                        if(idAdjunto!=-99)
                            ape.ID_ADJUNTO = idAdjunto;

                    sri.APELACION.AddObject(ape);
                    sri.SaveChanges();
                    return id;
                }
            }
            catch (Exception e)
            {
                return 0;
            }
            
        }

        public int traeAdjunto(int idAdjunto)
        {
            int nombreAdjunto = 0;
            using (SRI con = new SRI())
            {
                APELACION adjunto = new APELACION();

                adjunto = con.APELACION.Where(a => a.ID_MULTA == idAdjunto).FirstOrDefault();
                nombreAdjunto = Convert.ToInt32(adjunto.ID_ADJUNTO);
            }
            return nombreAdjunto;
        }

    }
}

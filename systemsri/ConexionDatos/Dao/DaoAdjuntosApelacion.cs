using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess;
using ConexionDatos.Entity;

namespace ConexionDatos.Dao
{
    public class DaoAdjuntosApelacion
    {
        public static DaoAdjuntosApelacion instancia = new DaoAdjuntosApelacion();

        private int RetornarNuevoId()
        {
            int id = 0;
            using (SRI sri = new SRI())
            {
                id = (int)sri.ADJUNTOS_APELACION.DefaultIfEmpty().Max(p => p ==null ? 0 :  p.ID_ADJUNTO)+1;
    
                return id;
            }
        }


        public int  crearAdjunto (ADJUNTOS_APELACION adjunto)
        {
            try
            {
                using (SRI sri = new SRI())
                {
                    adjunto.ID_ADJUNTO = RetornarNuevoId();
                    adjunto.ADJUNTO = adjunto.ID_ADJUNTO.ToString() + "_" + adjunto.ADJUNTO;
                    sri.ADJUNTOS_APELACION.AddObject(adjunto);
                    sri.SaveChanges();
                    return Convert.ToInt32(adjunto.ID_ADJUNTO);
                }
            }
            catch (Exception e)
            {
                return 0;
            }

        }
    }
}

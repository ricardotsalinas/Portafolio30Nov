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

        public void actualizaEstado(int id, int estado)
        { 
            using(SRI con = new SRI())
            {
                APELACION ape = new APELACION();
                ape = con.APELACION.Where(a => a.ID_APELACION == id ).FirstOrDefault();
                if(ape.ESTADO==1142)
                {
                    ape.ESTADO = estado;
                    con.SaveChanges();
                }
            
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


        public int apelacion(int id, String descripcion, int aceptado, int monto)
        {
            try
            {
                using (SRI con = new SRI())
                {
                    APELACION objAple = new APELACION();
                    objAple = con.APELACION.Where(a => a.ID_APELACION == id).FirstOrDefault();
                    objAple.ESTADO = 1143;
                    objAple.ACEPTADO = aceptado.ToString();
                    objAple.DESCRIPCION_AP = descripcion;
                    con.SaveChanges();
                    if (aceptado == 1)
                    {
                        MULTA objMulta = new MULTA();
                        objMulta = con.MULTA.Where(m => m.ID_MULTA == objAple.ID_MULTA).FirstOrDefault();
                        objMulta.MONTO_ADICIONAL = (monto * -1);
                        con.SaveChanges();
                    }
                    return 1;
                
                }
            }
            catch (Exception e)
            {
                return 0;
            }
            
        }
    }
}

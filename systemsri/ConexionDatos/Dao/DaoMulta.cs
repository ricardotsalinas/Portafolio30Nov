using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess;
using ConexionDatos.Entity;
using ClasesESpeciales;

namespace ConexionDatos.Dao
{
    public class DaoMulta
    {
        public static DaoMulta instancia = new DaoMulta();

        private int retornarNuevoId()
        {
            int id = 0;
            using (SRI sri = new SRI())
            {
                id = (int)sri.MULTA.DefaultIfEmpty().Max(p => p == null ? 0 : p.ID_MULTA) + 1;
                return id;
            }
        }

        public int grabaMulta(MULTA objMulta)
        {
            try
            {
                using(SRI con = new SRI())
                {
                    objMulta.ID_MULTA = retornarNuevoId();
                    objMulta.ADJUNTO = objMulta.ID_MULTA + '_' + objMulta.ADJUNTO;
                    con.MULTA.AddObject(objMulta);
                    con.SaveChanges();
                    return (int)objMulta.ID_MULTA;

                }

            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int pagarMulta(int idMulta)
        {
            try
            {
                using (SRI con = new SRI())
                {
                    MULTA objmulta = new MULTA();

                    objmulta = con.MULTA.Where(m => m.ID_MULTA == idMulta).FirstOrDefault();
                    objmulta.PAGADA = "1";
                    objmulta.ID_TIPO_PAGO = 1148;
                    objmulta.FECHA_PAGO = DateTime.Now;
                    con.SaveChanges();
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


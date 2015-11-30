using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConexionDatos.Entity;
using ClasesESpeciales;
using Oracle.DataAccess;

namespace ConexionDatos.Dao
{
    public class DaoLoginUsuario
    {

        public static DaoLoginUsuario instanacia =  new DaoLoginUsuario();

        public List<LoginUsuario> sessionUsuario(String rut, String clave)
        {
            List<LoginUsuario> lsession = new List<LoginUsuario>();
                      using (SRI con = new SRI())
                      {
                          lsession = (from d in con.DETALLE_CARACTERISTICA
                                      join p in con.PERSONAL on d.ID_DETCAR equals p.ID_TIPO_FUNCIONARIO
                                      where p.RUT_PER == rut && p.PASSWORD_PER == clave
                                      select new LoginUsuario
                                      {
                                          NOMBRE = d.DETALLE_CAR,
                                          RUT = p.RUT_PER,
                                          CLAVE = p.PASSWORD_PER
                                      }).ToList();
                      }
                      return lsession;
        }

        public List<INFRACTOR> sessionInfractor(String rut, String clave)
        {
            List<INFRACTOR> lsession = new List<INFRACTOR>();
            using (SRI contex = new SRI())
            {
                lsession = contex.INFRACTOR.Where(i => i.RUT_INFR == rut && i.PASSWORD_INFR == clave).ToList();
            }

            return lsession;
        }



        public Boolean verificaPaginaInfractor(String rut)
        {
            List<INFRACTOR> lsession = new List<INFRACTOR>();
            using (SRI contex = new SRI())
            {
                lsession = contex.INFRACTOR.Where(i => i.RUT_INFR == rut).ToList();
                if (lsession.Count > 0)
                    return true;
                else
                    return false;
            }
        }



        public Boolean verificaPagina(String rut , int tipo)
        {
            List<PERSONAL> lp = new List<PERSONAL>();

            using (SRI con = new SRI())
            {
                lp = con.PERSONAL.Where(p => p.ID_TIPO_FUNCIONARIO == tipo && p.RUT_PER == rut).ToList();

                if (lp.Count > 0)
                    return true;
                else
                    return false;
            }
        }
    }
}

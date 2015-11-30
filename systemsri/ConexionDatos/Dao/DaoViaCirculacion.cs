using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess;
using ConexionDatos.Entity;
using System.Data.Entity;



namespace ConexionDatos.Dao
{
    public class DaoViaCirculacion
    {
        public static DaoViaCirculacion instancia = new DaoViaCirculacion();
        
        private int RetornarNuevoId()
        {
            int id = 0;
            using (SRI sri = new SRI())
            {
                id = (int)sri.VIA_CIRCULACION.DefaultIfEmpty().Max(p => p == null ? 0 : p.ID_VIA_CIRCULACION) + 1;
                return id;
            }
        }
        public int CrearViaCirculacion(VIA_CIRCULACION dto) 
        {
            try
            {
                using (SRI sri = new SRI())
                {
                    dto.ID_VIA_CIRCULACION = RetornarNuevoId();
                    sri.VIA_CIRCULACION.AddObject(dto);
                    sri.SaveChanges();
                    return 1;
                }
            }
            catch (Exception e)
            {
                return 0;
            }
        }
        public List<VIA_CIRCULACION> BuscarCalleVC(int idcalle)
        {
            using (SRI contex = new SRI())
            {
                List<VIA_CIRCULACION> lbuscar = new List<VIA_CIRCULACION>();
                lbuscar = contex.VIA_CIRCULACION.Where(a => a.ID_NOMBRE_CALLE == idcalle).ToList();
                return lbuscar;
            }
        }
    }
}

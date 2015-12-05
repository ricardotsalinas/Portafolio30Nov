using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConexionDatos.Entity;

namespace ConexionDatos.Dao
{
    public class RestriccionDao
    {
        public static RestriccionDao Instancia = new RestriccionDao();

        public int Crear(RESTRICCION dto)
        {
            int idRestriccion = 0;

            using (SRI con   = new SRI()) 
            {
                dto.ID_RESTRICCION = NuevoID();
                con.RESTRICCION.AddObject(dto);
                con.SaveChanges();
                
            }



            return idRestriccion;

        }



        private int NuevoID()
        {
            decimal id = 0;

            using (SRI con = new SRI())
            {
                id = con.RESTRICCION.Max(r => r.ID_RESTRICCION);
                if (id == null) { id = 0; }
                else { id = id + 1; }
            }

            return Convert.ToInt32(  id.ToString());
        }
    }
}

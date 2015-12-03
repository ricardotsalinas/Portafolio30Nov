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

        public Boolean existeCalle(String calle)
        {

            List<DETALLE_CARACTERISTICA> list = new List<DETALLE_CARACTERISTICA>();
            using (SRI sri = new SRI())
            {
                list = sri.DETALLE_CARACTERISTICA.Where(p => p.DETALLE_CAR == calle).ToList();
            }

            if (list.Count > 0)
                return false;
            else
            return true;

        
        }

        public int grabarCalle(DETALLE_CARACTERISTICA objDetalle, int pistas, int orientacion, int velocidadMaxima, int sentido, int sector, int tipoCalle, int tipo, String estado)
        {
            int validacion = 0;
            int idCalle = 0;
            using (SRI con = new SRI())
            {
                try
                {
                    if (tipo > 0)
                    {
                        VIA_CIRCULACION via = new VIA_CIRCULACION();
                        via = con.VIA_CIRCULACION.Where(v => v.ID_VIA_CIRCULACION == tipo).FirstOrDefault();
                        via.ACTIVO = estado;
                        via.CANT_PISTAS = pistas;
                        via.ID_ORIENTACION = orientacion;
                        via.ID_VELOC_MAXIMA = velocidadMaxima;
                        via.ID_SENTIDO = sentido;
                        via.ID_SECTOR = sector;
                        via.ID_TIPO_CALLE = tipoCalle;
                        con.SaveChanges();
                         idCalle =  DaoDetalleCaracteristica.instancia.actualizarCalle((int)via.ID_NOMBRE_CALLE,objDetalle.DETALLE_CAR);
                        validacion = 2;
                    }
                    else
                    {
                        idCalle = DaoDetalleCaracteristica.instancia.CrearDetalleCaracteristica(objDetalle);


                        VIA_CIRCULACION objVia = new VIA_CIRCULACION();
                        int idVia = RetornarNuevoId();
                        objVia.ACTIVO = estado;
                        objVia.CANT_PISTAS = pistas;
                        objVia.ID_ORIENTACION = orientacion;
                        objVia.ID_VELOC_MAXIMA = velocidadMaxima;
                        objVia.ID_SENTIDO = sentido;
                        objVia.ID_SECTOR = sector;
                        objVia.ID_TIPO_CALLE = tipoCalle;
                        objVia.ID_VIA_CIRCULACION = idVia;
                        objVia.ID_NOMBRE_CALLE = idCalle;
                        con.VIA_CIRCULACION.AddObject(objVia);
                        con.SaveChanges();
                        validacion = 1;
                    }
                  }
                
                catch (Exception e)
                {
                    validacion = 0;
                }
                
            
            }
            return validacion;
        
        }



    }
}

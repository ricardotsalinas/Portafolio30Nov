using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess;
using ConexionDatos.Entity;
using ClasesESpeciales;

namespace ConexionDatos.Dao
{
   public class DaoDetalleCaracteristica
    {
       public static DaoDetalleCaracteristica instancia = new DaoDetalleCaracteristica();

       public List<DETALLE_CARACTERISTICA> listarCategoria()
       {

        using (SRI contex = new SRI())
         {
            List<DETALLE_CARACTERISTICA> lCategoria = new List<DETALLE_CARACTERISTICA>();
            lCategoria = contex.DETALLE_CARACTERISTICA.Where(a => a.ID_CARACTERISTICA ==8 ).ToList();
         
            return lCategoria;
         }
       }

       public List<DETALLE_CARACTERISTICA> listarOrientacion()
       { 
        using(SRI contex = new SRI())
        {
            List<DETALLE_CARACTERISTICA> lOrientacion = new List<DETALLE_CARACTERISTICA>();
            lOrientacion = contex.DETALLE_CARACTERISTICA.Where(a => a.ID_CARACTERISTICA ==5).ToList();
            return lOrientacion;
        
        }
       }

       public List<DETALLE_CARACTERISTICA> listarVelocidad()
       {
           using (SRI contex = new SRI())
           {
               List<DETALLE_CARACTERISTICA> lVelocidad = new List<DETALLE_CARACTERISTICA>();
               lVelocidad = contex.DETALLE_CARACTERISTICA.Where(a => a.ID_CARACTERISTICA == 11).ToList();
               return lVelocidad;

           }
       }
       public List<DETALLE_CARACTERISTICA> listarSentido()
       {
           using (SRI contex = new SRI())
           {
               List<DETALLE_CARACTERISTICA> lSentido = new List<DETALLE_CARACTERISTICA>();
               lSentido = contex.DETALLE_CARACTERISTICA.Where(a => a.ID_CARACTERISTICA == 4).ToList();
               return lSentido;

           }
       }

       public List<DETALLE_CARACTERISTICA> listarTipoCalle()
       {
           using (SRI contex = new SRI())
           {
               List<DETALLE_CARACTERISTICA> lTipo = new List<DETALLE_CARACTERISTICA>();
               lTipo = contex.DETALLE_CARACTERISTICA.Where(a => a.ID_CARACTERISTICA == 6).ToList();
               return lTipo;

           }
       }

     

       private int RetornarNuevoId()
       {
           int id = 0;
           using (SRI sri = new SRI())
           {
               id = (int)sri.DETALLE_CARACTERISTICA.DefaultIfEmpty().Max(p => p == null ? 0 : p.ID_DETCAR) + 1;
               return id;
           }
       }
       public int CrearDetalleCaracteristica(DETALLE_CARACTERISTICA dto)
       {
           try
           {
               using (SRI sri = new SRI())
               {
                   int idCaracteristica = RetornarNuevoId();
                   dto.ID_DETCAR = idCaracteristica;
                   sri.DETALLE_CARACTERISTICA.AddObject(dto);
                   sri.SaveChanges();
                   return idCaracteristica;
               }
           }
           catch (Exception e)
           {
               return 0;
           }
       }

       public int actualizarCalle(int tipo, String nombreCalle)
       {
           try
           {
               using (SRI sri = new SRI())
               {
                   DETALLE_CARACTERISTICA objDetalle = new DETALLE_CARACTERISTICA();
                   objDetalle = sri.DETALLE_CARACTERISTICA.Where(d => d.ID_DETCAR == tipo).FirstOrDefault();
                   objDetalle.DETALLE_CAR = nombreCalle;
                   sri.SaveChanges();
                   return 1;

               }
           }
           catch (Exception e)
           {
               return 0;
           }
       
       }

       public List<DETALLE_CARACTERISTICA> listarGravedad()
       {
           using (SRI contex = new SRI())
           {
               List<DETALLE_CARACTERISTICA> lGravedad = new List<DETALLE_CARACTERISTICA>();
               lGravedad = contex.DETALLE_CARACTERISTICA.Where(a => a.ID_CARACTERISTICA == 3).ToList();
               return lGravedad;

           }
       }
       public List<DETALLE_CARACTERISTICA> listarTipoMoneda()
       {
           using (SRI contex = new SRI())
           {
               List<DETALLE_CARACTERISTICA> lTipoMoneda = new List<DETALLE_CARACTERISTICA>();
               lTipoMoneda = contex.DETALLE_CARACTERISTICA.Where(a => a.ID_CARACTERISTICA == 12).ToList();
               return lTipoMoneda;
           }
       
       }


       public List<DETALLE_CARACTERISTICA> listarSector()
       {
           using (SRI contex = new SRI())
           {
               List<DETALLE_CARACTERISTICA> lSector = new List<DETALLE_CARACTERISTICA>();
               lSector = contex.DETALLE_CARACTERISTICA.Where(a => a.ID_CARACTERISTICA == 7).ToList();
               return lSector;
           }
       
       }
       public List<DETALLE_CARACTERISTICA> BuscarCalle(String nomCalle)
       {
           using (SRI contex = new SRI())
           {
               List<DETALLE_CARACTERISTICA> lbuscar = new List<DETALLE_CARACTERISTICA>();
               lbuscar = contex.DETALLE_CARACTERISTICA.Where(a => a.DETALLE_CAR.Equals(nomCalle)).ToList();
               return lbuscar;
           }
       }

     


       public List<DETALLE_CARACTERISTICA> ListarCalle()
       { 
        using (SRI contex = new SRI())
        {
            List<DETALLE_CARACTERISTICA> lCalle = new List<DETALLE_CARACTERISTICA>();
            lCalle = contex.DETALLE_CARACTERISTICA.Where(a => a.ID_CARACTERISTICA == 10).ToList();
            return lCalle;
        }
       }

     

       public List<DETALLE_CARACTERISTICA> ListarMotivo()
       {
           using (SRI contex = new SRI())
           {
               List<DETALLE_CARACTERISTICA> lMotivo = new List<DETALLE_CARACTERISTICA>();
               lMotivo = contex.DETALLE_CARACTERISTICA.Where(a => a.ID_CARACTERISTICA == 9).ToList();
               return lMotivo;
           }
       }

       public List<DETALLE_CARACTERISTICA> BuscarInfraccion(int idinfr)
       {
           using (SRI contex = new SRI())
           {
               List<DETALLE_CARACTERISTICA> lbuscar = new List<DETALLE_CARACTERISTICA>();
               lbuscar = contex.DETALLE_CARACTERISTICA.Where(a => a.ID_DETCAR == idinfr).ToList();
               return lbuscar;
           }
       }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConexionDatos.Entity;
using ClasesESpeciales;

namespace ConexionDatos.Dao
{
    class DaoTurno
    {
        //public int crearTurno(DetalleTurno dt, String rut, int tipo)
        //{
        //    try
        //    {
        //        using (SRI con = new SRI())
        //        {
        //            if (tipo > 0)
        //            {
        //               // DetalleTurno dt= new DetalleTurno();
        //                TURNO turn = new TURNO();
        //                turn = con.TURNO.Where(i => i.ID_TURNO == tipo).FirstOrDefault();
        //                turn.FECHA_TURNO = dt.FECHA_TUR;
        //                turn.HORA_INICIO = dt.HORA_INICIO;
        //                turn.HORA_FIN = dt.HORA_FIN;
        //                turn.DETALLE_TURNO = dt.DETALLE_TUR;
        //                con.SaveChanges();
        //                PERSONAL per = new PERSONAL();
        //                per = con.PERSONAL.Where(p => p.ID_PERSONAL==turn.ID_PERSONAL).FirstOrDefault();
        //                per.RUT_PER = dt.RUT_PER;
        //                dt.RUT_PER = rut;
        //                per.NOMBRE_PER = dt.NOMBRE_PER;
        //                per.APPAT_PER = dt.APPAT_PER;
        //                PERSONAL_SECTOR ps = new PERSONAL_SECTOR();
        //                ps = con.PERSONAL_SECTOR.Where(p => p.ID_PERSONAL == per.ID_PERSONAL).FirstOrDefault();
        //                SECTOR sec = new SECTOR();
        //                sec = con.SECTOR.Where(s => s.ID_SECTOR == ps.ID_SECTOR).FirstOrDefault();
        //                DETALLE_CARACTERISTICA dc = new DETALLE_CARACTERISTICA();
        //                dc = con.DETALLE_CARACTERISTICA.Where(d => d.ID_DETCAR== sec.ID_NOMBRE_SECTOR).FirstOrDefault();
        //                dc.DETALLE_CAR = dt.SECTOR;
        //                con.SaveChanges();
        //               // return 2;
        //            //}
        //            //else
        //            //{
        //            //    DETALLE_CARACTERISTICA objdetalle = new DETALLE_CARACTERISTICA();
        //            //    objdetalle.DETALLE_CAR = descripcion;
        //            //    objdetalle.ID_CARACTERISTICA = 9;
        //            //    objinfrac.ID_DETALLE_INFRACCION = DaoDetalleCaracteristica.instancia.CrearDetalleCaracteristica(objdetalle);
        //            //    objinfrac.ID_INFRACCION = retornarNuevoId();
        //            //    con.INFRACCION.AddObject(objinfrac);
        //            //    con.SaveChanges();
        //                return 1;
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        return 0;
        //    }

        }
    }


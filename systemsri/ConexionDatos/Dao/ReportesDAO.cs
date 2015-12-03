using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConexionDatos.Entity;
using System.Data;
using ClasesESpeciales;

namespace ConexionDatos.Dao
{
    public class ReportesDAO
    {
        public static ReportesDAO Instancia = new ReportesDAO();

        public List<ReporteInfractor> ReporteInfractores(String rut, int tipo)
        {

            using (SRI con = new SRI())
            {

                List<ReporteInfractor> lista = new List<ReporteInfractor>();

                switch (tipo)
                {
                    case 0:
                        lista = (from m in con.MULTA
                                 join a in con.APELACION on m.ID_MULTA equals a.ID_MULTA
                                 join i in con.INFRACTOR on m.ID_INFRACTOR equals i.ID_INFRACTOR
                                 join mm in con.MONEDA on m.ID_MONEDA equals mm.ID_MONEDA
                                 join inf in con.INFRACCION on m.ID_INFRACCION equals inf.ID_INFRACCION
                                 where i.RUT_INFR == rut 
                                 select new ReporteInfractor
                                 {
                                     RESUELTO = a.ESTADO ?? 0,
                                     CASO_LEIDO = a.ESTADO ?? 0,
                                     RUT_INF = i.RUT_INFR,
                                     INFR = i.NOMBRE_INFR + " " + i.APPAT_INFR + " " + i.APMAT_INFR,
                                     GRAVEDAD = inf.ID_GRAVEDAD,
                                     VALOR = m.MONTO_ADICIONAL ?? 0 + mm.VALOR_PESOS * inf.MONTO,
                                     FECHA = m.FECHA_CREACION
                                 }).ToList();
                        break;
                    case 1:
                        lista = (from m in con.MULTA
                                 join a in con.APELACION on m.ID_MULTA equals a.ID_MULTA
                                 join i in con.INFRACTOR on m.ID_INFRACTOR equals i.ID_INFRACTOR
                                 join mm in con.MONEDA on m.ID_MONEDA equals mm.ID_MONEDA
                                 join inf in con.INFRACCION on m.ID_INFRACCION equals inf.ID_INFRACCION
                                 where a.ESTADO == (int)1141 && a.ESTADO == (int)1143 && i.RUT_INFR == rut 
                                 select new ReporteInfractor
                                 {
                                     RESUELTO = a.ESTADO ?? 0,
                                     CASO_LEIDO = a.ESTADO ?? 0,
                                     RUT_INF = i.RUT_INFR,
                                     INFR = i.NOMBRE_INFR + " " + i.APPAT_INFR + " " + i.APMAT_INFR,
                                     GRAVEDAD = inf.ID_GRAVEDAD,
                                     VALOR = m.MONTO_ADICIONAL ?? 0 + mm.VALOR_PESOS * inf.MONTO,
                                     FECHA = m.FECHA_CREACION
                                 }).ToList();
                        break;
                    case 11:
                        lista = (from m in con.MULTA
                                 join a in con.APELACION on m.ID_MULTA equals a.ID_MULTA
                                 join i in con.INFRACTOR on m.ID_INFRACTOR equals i.ID_INFRACTOR
                                 join mm in con.MONEDA on m.ID_MONEDA equals mm.ID_MONEDA
                                 join inf in con.INFRACCION on m.ID_INFRACCION equals inf.ID_INFRACCION
                                 where a.ESTADO == (int)1141 && i.RUT_INFR == rut 
                                 select new ReporteInfractor
                                 {
                                     RESUELTO = a.ESTADO ?? 0,
                                     CASO_LEIDO = a.ESTADO ?? 0,
                                     RUT_INF = i.RUT_INFR,
                                     INFR = i.NOMBRE_INFR + " " + i.APPAT_INFR + " " + i.APMAT_INFR,
                                     GRAVEDAD = inf.ID_GRAVEDAD,
                                     VALOR = m.MONTO_ADICIONAL ?? 0 + mm.VALOR_PESOS * inf.MONTO,
                                     FECHA = m.FECHA_CREACION
                                 }).ToList();
                        break;
                    case 2:
                        lista = (from m in con.MULTA
                                 join a in con.APELACION on m.ID_MULTA equals a.ID_MULTA
                                 join i in con.INFRACTOR on m.ID_INFRACTOR equals i.ID_INFRACTOR
                                 join mm in con.MONEDA on m.ID_MONEDA equals mm.ID_MONEDA
                                 join inf in con.INFRACCION on m.ID_INFRACCION equals inf.ID_INFRACCION
                                 where a.ESTADO == (int)1142 && i.RUT_INFR == rut 
                                 select new ReporteInfractor
                                 {
                                     RESUELTO = a.ESTADO ?? 0,
                                     CASO_LEIDO = a.ESTADO ?? 0,
                                     RUT_INF = i.RUT_INFR,
                                     INFR = i.NOMBRE_INFR + " " + i.APPAT_INFR + " " + i.APMAT_INFR,
                                     GRAVEDAD = inf.ID_GRAVEDAD,
                                     VALOR = m.MONTO_ADICIONAL ?? 0 + mm.VALOR_PESOS * inf.MONTO,
                                     FECHA = m.FECHA_CREACION
                                 }).ToList();
                        break;
                    case 3:
                        lista = (from m in con.MULTA
                                 join a in con.APELACION on m.ID_MULTA equals a.ID_MULTA
                                 join i in con.INFRACTOR on m.ID_INFRACTOR equals i.ID_INFRACTOR
                                 join mm in con.MONEDA on m.ID_MONEDA equals mm.ID_MONEDA
                                 join inf in con.INFRACCION on m.ID_INFRACCION equals inf.ID_INFRACCION
                                 where a.ESTADO == (int)1143 && i.RUT_INFR == rut 
                                 select new ReporteInfractor
                                 {
                                     RESUELTO = a.ESTADO ?? 0,
                                     CASO_LEIDO = a.ESTADO ?? 0,
                                     RUT_INF = i.RUT_INFR,
                                     INFR = i.NOMBRE_INFR + " " + i.APPAT_INFR + " " + i.APMAT_INFR,
                                     GRAVEDAD = inf.ID_GRAVEDAD,
                                     VALOR = m.MONTO_ADICIONAL ?? 0 + mm.VALOR_PESOS * inf.MONTO,
                                     FECHA = m.FECHA_CREACION
                                 }).ToList();
                        break;

                }
                return lista;


            }
        }

            public List<ReporteInfractor> ReporteInfractoresSinRut(String dato, int tipo)
        {
            
            using (SRI con = new SRI())
            {
                List<ReporteInfractor> lista = new List<ReporteInfractor>();

                switch (tipo)
                {
                    case 0:
                        lista = (from m in con.MULTA
                                 join a in con.APELACION on m.ID_MULTA equals a.ID_MULTA
                                 join i in con.INFRACTOR on m.ID_INFRACTOR equals i.ID_INFRACTOR
                                 join mm in con.MONEDA on m.ID_MONEDA equals mm.ID_MONEDA
                                 join inf in con.INFRACCION on m.ID_INFRACCION equals inf.ID_INFRACCION
                                 select new ReporteInfractor
                                 {
                                     RESUELTO = a.ESTADO ?? 0,
                                     CASO_LEIDO = a.ESTADO ?? 0,
                                     RUT_INF = i.RUT_INFR,
                                     INFR = i.NOMBRE_INFR + " " + i.APPAT_INFR + " " + i.APMAT_INFR,
                                     GRAVEDAD = inf.ID_GRAVEDAD,
                                     VALOR = m.MONTO_ADICIONAL ?? 0 + mm.VALOR_PESOS * inf.MONTO,
                                     FECHA = m.FECHA_CREACION
                                 }).ToList();
                        break;
                    case 1:
                        lista = (from m in con.MULTA
                                 join a in con.APELACION on m.ID_MULTA equals a.ID_MULTA
                                 join i in con.INFRACTOR on m.ID_INFRACTOR equals i.ID_INFRACTOR
                                 join mm in con.MONEDA on m.ID_MONEDA equals mm.ID_MONEDA
                                 join inf in con.INFRACCION on m.ID_INFRACCION equals inf.ID_INFRACCION
                                 where a.ESTADO == (int)1141 && a.ESTADO == (int)1143
                                 select new ReporteInfractor
                                 {
                                     RESUELTO = a.ESTADO ?? 0,
                                     CASO_LEIDO = a.ESTADO ?? 0,
                                     RUT_INF = i.RUT_INFR,
                                     INFR = i.NOMBRE_INFR + " " + i.APPAT_INFR + " " + i.APMAT_INFR,
                                     GRAVEDAD = inf.ID_GRAVEDAD,
                                     VALOR = m.MONTO_ADICIONAL ?? 0 + mm.VALOR_PESOS * inf.MONTO,
                                     FECHA = m.FECHA_CREACION
                                 }).ToList();
                        break;
                        case 11:
                        lista = (from m in con.MULTA
                                 join a in con.APELACION on m.ID_MULTA equals a.ID_MULTA
                                 join i in con.INFRACTOR on m.ID_INFRACTOR equals i.ID_INFRACTOR
                                 join mm in con.MONEDA on m.ID_MONEDA equals mm.ID_MONEDA
                                 join inf in con.INFRACCION on m.ID_INFRACCION equals inf.ID_INFRACCION
                                 where a.ESTADO == (int)1141
                                 select new ReporteInfractor
                                 {
                                     RESUELTO = a.ESTADO ?? 0,
                                     CASO_LEIDO = a.ESTADO ?? 0,
                                     RUT_INF = i.RUT_INFR,
                                     INFR = i.NOMBRE_INFR + " " + i.APPAT_INFR + " " + i.APMAT_INFR,
                                     GRAVEDAD = inf.ID_GRAVEDAD,
                                     VALOR = m.MONTO_ADICIONAL ?? 0 + mm.VALOR_PESOS * inf.MONTO,
                                     FECHA = m.FECHA_CREACION
                                 }).ToList();
                        break;
                        case 2:
                        lista = (from m in con.MULTA
                                 join a in con.APELACION on m.ID_MULTA equals a.ID_MULTA
                                 join i in con.INFRACTOR on m.ID_INFRACTOR equals i.ID_INFRACTOR
                                 join mm in con.MONEDA on m.ID_MONEDA equals mm.ID_MONEDA
                                 join inf in con.INFRACCION on m.ID_INFRACCION equals inf.ID_INFRACCION
                                 where a.ESTADO == (int)1142
                                 select new ReporteInfractor
                                 {
                                     RESUELTO = a.ESTADO ?? 0,
                                     CASO_LEIDO = a.ESTADO ?? 0,
                                     RUT_INF = i.RUT_INFR,
                                     INFR = i.NOMBRE_INFR + " " + i.APPAT_INFR + " " + i.APMAT_INFR,
                                     GRAVEDAD = inf.ID_GRAVEDAD,
                                     VALOR = m.MONTO_ADICIONAL ?? 0 + mm.VALOR_PESOS * inf.MONTO,
                                     FECHA = m.FECHA_CREACION
                                 }).ToList();
                        break;
                        case 3:
                        lista = (from m in con.MULTA
                                 join a in con.APELACION on m.ID_MULTA equals a.ID_MULTA
                                 join i in con.INFRACTOR on m.ID_INFRACTOR equals i.ID_INFRACTOR
                                 join mm in con.MONEDA on m.ID_MONEDA equals mm.ID_MONEDA
                                 join inf in con.INFRACCION on m.ID_INFRACCION equals inf.ID_INFRACCION
                                 where a.ESTADO == (int)1143
                                 select new ReporteInfractor
                                 {
                                     RESUELTO = a.ESTADO ?? 0,
                                     CASO_LEIDO = a.ESTADO ?? 0,
                                     RUT_INF = i.RUT_INFR,
                                     INFR = i.NOMBRE_INFR + " " + i.APPAT_INFR + " " + i.APMAT_INFR,
                                     GRAVEDAD = inf.ID_GRAVEDAD,
                                     VALOR = m.MONTO_ADICIONAL ?? 0 + mm.VALOR_PESOS * inf.MONTO,
                                     FECHA = m.FECHA_CREACION
                                 }).ToList();
                        break;
                
                }

                    
               


                return lista;


            }

        }


        public List<ReporteCalles> ReporteCalles()
        {
            using (SRI con = new SRI())
            {
                List<ReporteCalles> lista = (from vc in con.VIA_CIRCULACION
                                             join nomdc in con.DETALLE_CARACTERISTICA on vc.ID_NOMBRE_CALLE equals nomdc.ID_DETCAR
                                             join oridc in con.DETALLE_CARACTERISTICA on vc.ID_ORIENTACION equals oridc.ID_DETCAR
                                             join velmaxdc in con.DETALLE_CARACTERISTICA on vc.ID_VELOC_MAXIMA equals velmaxdc.ID_DETCAR
                                             join sendc in con.DETALLE_CARACTERISTICA on vc.ID_SENTIDO equals sendc.ID_DETCAR
                                             join secdc in con.DETALLE_CARACTERISTICA on vc.ID_SECTOR equals secdc.ID_DETCAR
                                             join tcdc in con.DETALLE_CARACTERISTICA on vc.ID_TIPO_CALLE equals tcdc.ID_DETCAR

                                             where
                                             nomdc.ID_CARACTERISTICA == 10 &&
                                             oridc.ID_CARACTERISTICA == 5 &&
                                             velmaxdc.ID_CARACTERISTICA == 11 &&
                                             sendc.ID_CARACTERISTICA == 4 &&
                                             secdc.ID_CARACTERISTICA == 7 &&
                                             tcdc.ID_CARACTERISTICA == 6 
                                             select new ReporteCalles
                                             {
                                                 ID_CALLE = vc.ID_VIA_CIRCULACION,
                                                 NOMBRE_CALLE = nomdc.DETALLE_CAR,
                                                 NUM_PISTAS = vc.CANT_PISTAS ?? 0,
                                                 ORIENTACION = oridc.DETALLE_CAR,
                                                 VEL_MAX = velmaxdc.DETALLE_CAR,
                                                 SENTIDO = sendc.DETALLE_CAR,
                                                 SECTOR = secdc.DETALLE_CAR,
                                                 TIPO = tcdc.DETALLE_CAR,
                                             }
                             ).ToList();
                return lista;


            }

        }

        public List<ReporteInfracciones> ReporteInfracciones()
        {
            using (SRI con = new SRI())
            {
                List<ReporteInfracciones> lista = (from inf in con.INFRACCION
                                                   join dc in con.DETALLE_CARACTERISTICA on inf.ID_DETALLE_INFRACCION equals dc.ID_DETCAR
                                                   join dcg in con.DETALLE_CARACTERISTICA on inf.ID_GRAVEDAD equals dcg.ID_DETCAR
                                                   join dcm in con.DETALLE_CARACTERISTICA on inf.ID_TIPO_MONEDA equals dcm.ID_DETCAR
                                                   where
                                                            dc.ID_CARACTERISTICA == 9 &&
                                                            dcg.ID_CARACTERISTICA == 3 &&
                                                            dcm.ID_CARACTERISTICA == 12
                                                   select new ReporteInfracciones
                                                   {
                                                       ID_INF = inf.ID_INFRACCION,
                                                       GRAVEDAD = dcg.DETALLE_CAR,
                                                       TIPO_MONEDA = dcm.DETALLE_CAR,
                                                       VALOR = inf.MONTO,
                                                       DESCR_INF = dc.DETALLE_CAR
                                                   }
                             ).ToList();
                return lista;


            }
        }

        public List<ReporteTurnos> ReporteTurnos()
        {
            {
                using (SRI con = new SRI())
                {
                    List<ReporteTurnos> lista = (from tu in con.TURNO
                                                 join pe in con.PERSONAL on tu.ID_PERSONAL equals pe.ID_PERSONAL
                                                 join ps in con.PERSONAL_SECTOR on pe.ID_PERSONAL equals ps.ID_PERSONAL
                                                 join se in con.SECTOR on ps.ID_SECTOR equals se.ID_SECTOR
                                                 join dc in con.DETALLE_CARACTERISTICA on se.ID_NOMBRE_SECTOR equals dc.ID_DETCAR

                                                
                                                 select new ReporteTurnos
                                                 {
                                                     ID_TUR = tu.ID_TURNO,
                                                     RUT_PER = pe.RUT_PER,
                                                     NOMBRE_PER = pe.NOMBRE_PER+ " " + pe.APPAT_PER,
                                                     SECTOR = dc.DETALLE_CAR,
                                                     FECHA_TUR = tu.FECHA_TURNO,
                                                     DESCRIPCION_TUR = tu.DETALLE_TURNO

                                                 }
                                 ).ToList();
                    return lista;



                }
            }

        }

    }

                  

            
            }




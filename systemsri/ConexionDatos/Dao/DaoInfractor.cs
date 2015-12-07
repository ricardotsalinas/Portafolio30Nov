using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess;
using ConexionDatos.Entity;
using ClasesESpeciales;


namespace ConexionDatos.Dao
{
    public class DaoInfractor
    {
        public static DaoInfractor Instancia = new DaoInfractor();



        private int RetornarNuevoId()
        {
            int id = 0;
            using (SRI sri = new SRI())
            {
                id = (int)sri.INFRACTOR.DefaultIfEmpty().Max(p => p == null ? 0 : p.ID_INFRACTOR) + 1;
                return id;
            }
        }
        public int CrearInfractor(INFRACTOR dto)
        {
            try
            {
                using (SRI sri = new SRI())
                {
                    dto.ID_INFRACTOR = RetornarNuevoId();
                    sri.INFRACTOR.AddObject(dto);
                    sri.SaveChanges();
                    return 1;
                }
            }
            catch (Exception e)
            {
                return 0;
            }
        }





        public List<INFRACTOR> buscarInfractor(String rut)
        {
            using (SRI contex = new SRI())
            {
                List<INFRACTOR> lbuscar = new List<INFRACTOR>();
                lbuscar = contex.INFRACTOR.Where(a => a.RUT_INFR == rut).ToList();
                return lbuscar;
            }
        }

        public INFRACTOR buscarInfractorPat(int rut)
        {
            using (SRI contex = new SRI())
            {
                INFRACTOR lbuscar = new INFRACTOR();
                lbuscar = contex.INFRACTOR.Where(a => a.ID_VEHICULO == rut).FirstOrDefault();
                return lbuscar;
            }
        }



        public List<INFRACTOR> BuscarInfractor(String rut)
        {
            using (SRI contex = new SRI())
            {
                List<INFRACTOR> lbuscar = new List<INFRACTOR>();
                lbuscar = contex.INFRACTOR.Where(a => a.RUT_INFR == rut).ToList();
                return lbuscar;
            }
        }

        public int ReiniciarClave(string clave, int id)
        {
            throw new NotImplementedException();
        }



        public List<DatosPersonalesInfractor> datosPersonales(String rut)
        {
            List<DatosPersonalesInfractor> lista = new List<DatosPersonalesInfractor>();

            using (SRI con = new SRI())
            {
                lista = (from i in con.INFRACTOR
                         join d in con.DETALLE_CARACTERISTICA
                         on i.ID_CLASE_LICENCIA equals d.ID_DETCAR
                         where i.RUT_INFR == rut
                         select new DatosPersonalesInfractor
                         {
                             RUT = i.RUT_INFR,
                             NOMBRE = i.NOMBRE_INFR + " " + i.APMAT_INFR,
                             FECHA_NACIMIENTO = i.FECHA_NAC,
                             DIRECCION = i.DIRECCION_INFR,
                             EMAIL = i.EMAIL_INFR,
                             TELEFONO = i.TELEFONO_INFR,
                             LICENCIA = d.DETALLE_CAR
                         }
                     ).ToList();
                return lista;
            }
        }
        public int actualizaClaveInfr(String newClave, String rut)
        {
            using (SRI contex = new SRI())
            {
                try
                {
                    INFRACTOR lista = new INFRACTOR();
                    lista = contex.INFRACTOR.Where(a => a.RUT_INFR == rut).FirstOrDefault();
                    lista.PASSWORD_INFR = newClave;
                    contex.SaveChanges();
                    return 1;
                }
                catch (Exception e)
                {
                    return 0;
                }

            }
        }


        public int actualizaClavePropia(String newClave, String rut)
        {
            using (SRI contex = new SRI())
            {
                try
                {
                    INFRACTOR lista = new INFRACTOR();
                    lista = contex.INFRACTOR.Where(a => a.RUT_INFR == rut).FirstOrDefault();
                    lista.PASSWORD_INFR = newClave;
                    contex.SaveChanges();
                    return 1;
                }
                catch (Exception e)
                {
                    return 0;
                }

            }
        }
        public int actualizaDatosPersonales(String email, String telefono, String rut)
        {

            using (SRI contex = new SRI())
            {
                try
                {
                    INFRACTOR objInfractor = new INFRACTOR();
                    objInfractor = contex.INFRACTOR.Where(a => a.RUT_INFR == rut).FirstOrDefault();
                    objInfractor.EMAIL_INFR = email;
                    objInfractor.TELEFONO_INFR = telefono;
                    contex.SaveChanges();
                    return 1;
                }
                catch (Exception e)
                {
                    return 0;
                }

            }
        }




        public List<HistorialInfractor> listaHistorial(String rut)
        {
            List<HistorialInfractor> historial = new List<HistorialInfractor>();

            using (SRI con = new SRI())
            {
                historial = (from m in con.MULTA
                             join i in con.INFRACCION on m.ID_INFRACCION equals i.ID_INFRACCION
                             join e in con.MONEDA on m.ID_MONEDA equals e.ID_MONEDA
                             join f in con.INFRACTOR on m.ID_INFRACTOR equals f.ID_INFRACTOR
                             join v in con.VEHICULO on f.ID_VEHICULO equals v.ID_VEHICULO
                             where f.RUT_INFR == rut
                             select new HistorialInfractor
                              {
                                  ID_MULTA = m.ID_MULTA,
                                  PATENTE = v.PATENTE,
                                  FECHA = m.FECHA_CREACION,
                                  TIPO_MULTA = (m.CARABINERO_OPC.Value == 0 ? "EMPADRONADO" :
                                                  m.CARABINERO_OPC.Value == 1 ? "CONDUCTOR" : ""),
                                  VALOR_PESO = (e.VALOR_PESOS * i.MONTO) + m.MONTO_ADICIONAL ?? 0,
                                  PAGADA = m.PAGADA
                              }
                            ).ToList();
                return historial;
            }


        }


        public List<DetalleMultaInfractor> detalleInfractor(String idMulta)
        {
            List<DetalleMultaInfractor> detalle = new List<DetalleMultaInfractor>();
            decimal decimalMulta = Convert.ToDecimal(idMulta);

            using (SRI con = new SRI())
            {

                detalle = (from m in con.MULTA
                           join i in con.INFRACTOR on m.ID_INFRACTOR equals i.ID_INFRACTOR
                           join v in con.VEHICULO on i.ID_VEHICULO equals v.ID_VEHICULO
                           join f in con.INFRACCION on m.ID_INFRACCION equals f.ID_INFRACCION
                           join d in con.DETALLE_CARACTERISTICA on f.ID_GRAVEDAD equals d.ID_DETCAR
                           join dc in con.DETALLE_CARACTERISTICA on f.ID_DETALLE_INFRACCION equals dc.ID_DETCAR
                           join o in con.MONEDA on m.ID_MONEDA equals o.ID_MONEDA
                           join vc in con.VIA_CIRCULACION on m.ID_VIA_CIRCULACION equals vc.ID_VIA_CIRCULACION
                           join dv in con.DETALLE_CARACTERISTICA on vc.ID_NOMBRE_CALLE equals dv.ID_DETCAR
                           where m.ID_MULTA == decimalMulta
                           select new DetalleMultaInfractor
                           {
                               ID_MULTA = m.ID_MULTA,
                               GRAVEDAD = d.DETALLE_CAR,
                               MONTO = ((f.MONTO * o.VALOR_PESOS) + m.MONTO_ADICIONAL ?? 0),
                               FECHA_MULTA = m.FECHA_CREACION,
                               HORA_MULTA = m.HORA_MULTA,
                               MOTIVO_MULTA = dc.DETALLE_CAR,
                               DETALLE_ADICIONAL = m.DETALLE_ADICIONAL,
                               LUGAR_INFRACCION = dv.DETALLE_CAR,
                               NOMBRE = i.NOMBRE_INFR + " " + i.APPAT_INFR + " " + i.APMAT_INFR,
                               RUT = i.RUT_INFR,
                               PATENTE = v.PATENTE
                           }
                    ).ToList();

                return detalle;
            }


        }


        public int CrearFuncionario(INFRACTOR dto, int tipo)
        {
            try
            {
                using (SRI sri = new SRI())
                {
                    if (!existeRut(dto.RUT_INFR.ToString()) && tipo == 2)
                    {
                        INFRACTOR per = new INFRACTOR();
                        per = sri.INFRACTOR.Where(a => a.RUT_INFR == dto.RUT_INFR).FirstOrDefault();
                        per.RUT_INFR = dto.RUT_INFR;
                        per.NOMBRE_INFR = dto.NOMBRE_INFR;
                        per.ACTIVO = dto.ACTIVO;
                        per.APMAT_INFR = dto.APMAT_INFR;
                        per.APPAT_INFR = dto.APPAT_INFR;
                        per.TELEFONO_INFR = dto.TELEFONO_INFR;
                        per.DIRECCION_INFR = dto.DIRECCION_INFR;
                        per.EMAIL_INFR = dto.EMAIL_INFR;
                        sri.SaveChanges();
                        return 2;
                    }
                    else
                    {
                        if (tipo == 1)
                        {
                            dto.ID_INFRACTOR = RetornarNuevoId();
                            sri.INFRACTOR.AddObject(dto);
                            sri.SaveChanges();
                            return 1;
                        }
                        else
                            return 0;
                    }
                }
            }
            catch (Exception e)
            {
                return 0;
            }
        }


        public Boolean existeRut(String rut)
        {
            List<INFRACTOR> list = new List<INFRACTOR>();
            using (SRI sri = new SRI())
            {
                list = sri.INFRACTOR.Where(p => p.RUT_INFR == rut).ToList();
            }

            if (list.Count > 0)
                return false;
            else
                return true;

        }


        public int idInfractor(String rut)
        {
            INFRACTOR objInfrac = new INFRACTOR();
            using (SRI sri = new SRI())
            {
                objInfrac = sri.INFRACTOR.Where(p => p.RUT_INFR == rut).FirstOrDefault();
                return (int)objInfrac.ID_INFRACTOR;

            }
        }

        public int ReiniciarClave(String clave, String rut)
        {
            try
            {
                using (SRI contex = new SRI())
                {
                    INFRACTOR infr = new INFRACTOR();
                    infr = contex.INFRACTOR.Where(p => p.RUT_INFR == rut).FirstOrDefault();
                    infr.PASSWORD_INFR = clave;
                    contex.SaveChanges();
                    return 1;
                }

            }
            catch (Exception e)
            {
                return 0;
            }

        }



        public int funcionarioId(INFRACTOR dto)
        {
            try
            {
                using (SRI sri = new SRI())
                {
                    dto.ID_INFRACTOR = RetornarNuevoId();
                    sri.INFRACTOR.AddObject(dto);
                    sri.SaveChanges();
                    return (int)dto.ID_INFRACTOR;
                }
            }
            catch (Exception e)
            {
                return 0;
            }




        }
    }
}

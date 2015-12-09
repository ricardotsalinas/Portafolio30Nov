using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess;
using ConexionDatos.Entity;
using ClasesESpeciales;

namespace ConexionDatos.Dao
{
    public class DaoPersonal
    {
        public static DaoPersonal instancia = new DaoPersonal();

        private int retornarNuevoId()
        {
            int id = 0;
            using (SRI sri = new SRI())
            {
                id = (int)sri.PERSONAL.DefaultIfEmpty().Max(p => p == null ? 0 : p.ID_PERSONAL) + 1;
                return id;
            }
        }

        public  Boolean existeRut(String rut)
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


        public Boolean existeRut2(String rut)
        {
            List<PERSONAL> list = new List<PERSONAL>();
            using (SRI sri = new SRI())
            {
                list = sri.PERSONAL.Where(p => p.RUT_PER == rut).ToList();
            }

            if (list.Count > 0)
                return false;
            else
                return true;

        }


        public int CrearPersonal(PERSONAL dto,int tipo)
        {
            try
            {
                using (SRI sri = new SRI())
                {
                    if (!existeRut2(dto.RUT_PER.ToString()) && tipo ==2)
                    {
                        PERSONAL per = new PERSONAL();
                        per = sri.PERSONAL.Where(a => a.RUT_PER == dto.RUT_PER).FirstOrDefault();
                        per.RUT_PER = dto.RUT_PER;
                        per.NOMBRE_PER = dto.NOMBRE_PER;
                        per.ACTIVO = dto.ACTIVO;
                        per.APMAT_PER = dto.APMAT_PER;
                        per.APPAT_PER = dto.APPAT_PER;
                        per.TELEFONO_PER = dto.TELEFONO_PER;
                        per.DIRECCION_PER = dto.DIRECCION_PER;
                        per.EMAIL_PER = dto.EMAIL_PER;
                        per.ID_TIPO_FUNCIONARIO = dto.ID_TIPO_FUNCIONARIO;
                        sri.SaveChanges();
                        return 2;
                    }
                    else
                    {
                        if (tipo == 1)
                        {
                            dto.ID_PERSONAL = retornarNuevoId();
                            sri.PERSONAL.AddObject(dto);
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

        public int ReiniciarClave(String clave, String rut)
        {
            try
            {
                using (SRI contex = new SRI())
                {
                    PERSONAL per = new PERSONAL();
                    per = contex.PERSONAL.Where(p => p.RUT_PER == rut).FirstOrDefault();
                    per.PASSWORD_PER = clave;
                    contex.SaveChanges();
                    return 1;
                }

            }
            catch (Exception e)
            {
                return 0;
            }
        }




        public List<PERSONAL> BuscarUsuario(String rut)
        {
            using (SRI contex = new SRI())
            {
                List<PERSONAL> lbuscar = new List<PERSONAL>();
                lbuscar = contex.PERSONAL.Where(a => a.RUT_PER== rut).ToList();
                return lbuscar;
            }
        }

        public List<DatosPersonalesFuncionario> datosPersonales(String rut)
        {
            List<DatosPersonalesFuncionario> lista = new List<DatosPersonalesFuncionario>();

            using (SRI con = new SRI())
            {
                lista = (from i in con.PERSONAL
                         join d in con.DETALLE_CARACTERISTICA
                         on i.ID_PERSONAL equals d.ID_DETCAR
                         where i.RUT_PER == rut
                         select new DatosPersonalesFuncionario
                         {
                             RUT = i.RUT_PER,
                             NOMBRE = i.NOMBRE_PER + " " + i.APPAT_PER,
                             DIRECCION = i.DIRECCION_PER,
                             EMAIL = i.EMAIL_PER,
                             TELEFONO = i.TELEFONO_PER,
                             }
                     ).ToList();
                return lista;
            }
        }

      
        public int actualizaDatosPersonales(String email, String telefono, String rut)
        {

            using (SRI contex = new SRI())
            {
                try
                {
                    PERSONAL objInfractor = new PERSONAL();
                    objInfractor = contex.PERSONAL.Where(a => a.RUT_PER == rut).FirstOrDefault();
                    objInfractor.EMAIL_PER = email;
                    objInfractor.TELEFONO_PER = telefono;
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
                    PERSONAL lista = new PERSONAL();
                    lista = contex.PERSONAL.Where(a => a.RUT_PER == rut).FirstOrDefault();
                    lista.PASSWORD_PER = newClave;
                    contex.SaveChanges();
                    return 1;
                }
                catch (Exception e)
                {
                    return 0;
                }

            }
        }



        public Boolean existeCalle(String calle)
        {
            List<DETALLE_CARACTERISTICA> list = new List<DETALLE_CARACTERISTICA>();
            using (SRI sri = new SRI())
            {
                list = sri.DETALLE_CARACTERISTICA.Where(p => p.DETALLE_CAR== calle).ToList();
            }

            if (list.Count > 0)
                return false;
            else
                return true;
        }


        public int buscarInspector(String rut)
        {
            using (SRI con = new SRI())
            {
                PERSONAL pe = new PERSONAL();
                pe = con.PERSONAL.Where(p => p.RUT_PER == rut).FirstOrDefault();
                return (int)pe.ID_PERSONAL;
            }
        }

        
        public List<DetalleApelacion> detalleApelacion(String rut)
        {
            List<DetalleApelacion> detalle = new List<DetalleApelacion>();

            using (SRI con = new SRI())
            {
                detalle = ( from inft in con.INFRACTOR
                            join  dc in con.DETALLE_CARACTERISTICA on inft.ID_CLASE_LICENCIA  equals dc.ID_DETCAR                                 
                            join mu in con.MULTA on inft.ID_INFRACTOR equals mu.ID_INFRACTOR
                            join pers in con.PERSONAL on mu.ID_PERSONAL equals pers.ID_PERSONAL
                            join incc in con.INFRACCION on mu.ID_INFRACCION equals incc.ID_INFRACCION
                            join dci in con.DETALLE_CARACTERISTICA on incc.ID_GRAVEDAD equals dci.ID_DETCAR
                            join mon in con.MONEDA on mu.ID_MONEDA equals mon.ID_MONEDA
                            join dcin in con.DETALLE_CARACTERISTICA on incc.ID_DETALLE_INFRACCION equals dcin.ID_DETCAR
                            join vc in con.VIA_CIRCULACION on mu.ID_VIA_CIRCULACION equals vc.ID_VIA_CIRCULACION
                            join dcvc in con.DETALLE_CARACTERISTICA on vc.ID_NOMBRE_CALLE equals dcvc.ID_DETCAR
                            join ma in con.APELACION on mu.ID_MULTA equals ma.ID_MULTA
                            join indc in con.DETALLE_CARACTERISTICA on incc.ID_TIPO_MONEDA equals indc.ID_DETCAR
                            join cadc in con.DETALLE_CARACTERISTICA on vc.ID_TIPO_CALLE equals cadc.ID_DETCAR
                            
                               where inft.RUT_INFR==rut 
 
                           select new DetalleApelacion
                           {
                               NOMBRE = inft.NOMBRE_INFR,
                               APPAT = inft.APPAT_INFR,
                               APMAT = inft.APMAT_INFR,
                               RUT = inft.RUT_INFR,
                               DIRECCION= inft.DIRECCION_INFR,
                               EMAIL = inft.EMAIL_INFR,
                               FONO  =inft.TELEFONO_INFR,
                               CLASE_LIC =  dc.DETALLE_CAR,
                               INSPECTOR = pers.NOMBRE_PER+" "+pers.APPAT_PER+" "+pers.APMAT_PER,
                               COD_MULTA = mu.ID_MULTA,
                               GRAVEDAD = dci.DETALLE_CAR,
                               VALOR  = incc.MONTO,
                               TIPO_MONEDA = indc.DETALLE_CAR,
                               ID_MULTA = mu.ID_MULTA,
                               MONTO  = (incc.MONTO*mon.VALOR_PESOS+mu.MONTO_ADICIONAL)??0,
                               FECHA_MULTA = mu.FECHA_CREACION,
                               HORA_MULTA = mu.HORA_MULTA,
                               MOTIVO_MULTA = dcin.DETALLE_CAR,
                               DETALLE_ADICIONAL= mu.DETALLE_ADICIONAL,
                               LUGAR_INFRACCION =dcvc.DETALLE_CAR,
                               TIPO_CALLE=cadc.DETALLE_CAR,
                               ESTADO_MULTA = mu.PAGADA,
                               MENSAJE = ma.SOLICITUD_APELACION

                                   }
                            ).ToList();
                return detalle;
            }
        }

        public List<DetalleInfractorPagar> detalleInfractorPagar(String rut)
        {
            List<DetalleInfractorPagar> detalle = new List<DetalleInfractorPagar>();

            using (SRI con = new SRI())
            {
                detalle = (from inf in con.INFRACTOR
                           join mu in con.MULTA on inf.ID_INFRACTOR equals mu.ID_INFRACTOR
                           join incc in con.INFRACCION on mu.ID_INFRACCION equals incc.ID_INFRACCION
                           join mumo in con.MONEDA on mu.ID_MONEDA equals mumo.ID_MONEDA
                           where inf.RUT_INFR == rut

                           select new DetalleInfractorPagar
                           {
                               RUT = inf.RUT_INFR,
                               NOMBRE = inf.NOMBRE_INFR,
                               APPAT = inf.APPAT_INFR,
                               APMAT = inf.APMAT_INFR,
                               MONTO = (incc.MONTO * mumo.VALOR_PESOS + mu.MONTO_ADICIONAL) ?? 0,
                               ESTADO = mu.PAGADA,
                               NUMMULTA = mu.ID_MULTA

                           }
                            ).ToList();
                return detalle;
            }
        }


    }
    }


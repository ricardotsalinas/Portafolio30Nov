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


        public Boolean existeCalle(String nombre)
        {
            List<DETALLE_CARACTERISTICA> list = new List<DETALLE_CARACTERISTICA>();
            using (SRI sri = new SRI())
            {
                list = sri.DETALLE_CARACTERISTICA.Where(p => p.DETALLE_CAR== nombre).ToList();
            }

            if (list.Count > 0)
                return false;
            else
                return true;

        }

       /* public int CrearPersonal(PERSONAL dto, int tipo)
        {
            try
            {
                using (SRI sri = new SRI())
                {
                    if (!existeRut(dto.RUT_PER.ToString()) && tipo == 2)
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
                        per.EMAIL_PER = per.EMAIL_PER;
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
        }*/

    }
}

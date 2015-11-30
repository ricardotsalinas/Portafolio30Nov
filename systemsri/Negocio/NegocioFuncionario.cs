using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConexionDatos;
using ConexionDatos.Entity;
using ConexionDatos.Dao;
using Oracle.DataAccess;
using ClasesESpeciales.Helper;

namespace Negocio
{
   public class NegocioFuncionario
    {
        public static NegocioFuncionario instancia = new NegocioFuncionario();

        public int CrearInfractor(INFRACTOR dto)
        {
            dto.PASSWORD_INFR =  GeneraMd5.instancia.md5(dto.RUT_INFR.ToString().Substring(0, 5));
            return DaoInfractor.Instancia.CrearInfractor(dto);
        }
        public List<DETALLE_CARACTERISTICA> listarSector()
        {
            return DaoDetalleCaracteristica.instancia.listarSector();
        }

        public List<INFRACTOR> buscarInfractor(String rut)
        {
            return DaoInfractor.Instancia.buscarInfractor(rut);
        }
       

        public int ReiniciarClave(String clave, int id)
        {
            clave = GeneraMd5.instancia.md5(clave);
            return DaoInfractor.Instancia.ReiniciarClave(clave, id);

        }
        public List<PERSONAL> buscarPersona(String rut)
        {
            return DaoPersonal.instancia.BuscarUsuario(rut);
        }
        public int actualizaClaveInfr(String clave, String rut)
        {
            clave = GeneraMd5.instancia.md5(clave);
            return DaoInfractor.Instancia.actualizaClaveInfr(clave, rut);
        }


        public List<DatosPersonalesFuncionario> datosPersonales(String rut)
        {
            return DaoPersonal.instancia.datosPersonales(rut);

        }

        public int actualizaDatosPersonales(String email, String telefono, String rut)
        {
            return DaoPersonal.instancia.actualizaDatosPersonales(email, telefono, rut);
        }
        public int actualizaClavePropia(String clave, String rut)
        {
            clave = GeneraMd5.instancia.md5(clave);
            return DaoPersonal.instancia.actualizaClavePropia(clave, rut);
        }
   }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConexionDatos;
using ConexionDatos.Entity;
using ConexionDatos.Dao;
using Oracle.DataAccess;
using ClasesESpeciales.Helper;
using ClasesESpeciales;

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

        public int CrearFuncionario(INFRACTOR p, int p_2)
        {
            if(p_2==1)
                p.PASSWORD_INFR = GeneraMd5.instancia.md5(p.RUT_INFR.ToString().Substring(0,5));

            return DaoInfractor.Instancia.CrearFuncionario(p, p_2);
        }

        public Boolean existeRut(String rut)
        {
            return DaoInfractor.Instancia.existeRut(rut);
        }

       
        public int ReiniciarClave(String clave, String rut)
        {
            clave = GeneraMd5.instancia.md5(clave);
            return DaoInfractor.Instancia.ReiniciarClave(clave, rut);

        }


        public List<DetalleInfractorPagar> detalleInfractorPagar(String rut)
        {
            return DaoPersonal.instancia.detalleInfractorPagar(rut);

        }


        public int buscarID(String rut)
        {

            return DaoPersonal.instancia.buscarID(rut);
        }


        public void creaPersonalSector(PERSONAL_SECTOR perso)
        {
            DaoPersonalSector.instancia.creaPersonalSector(perso);
        }


        public int grabarTurno(TURNO tur)
        {
            return DaoTurno.instanacia.grabarTurno(tur);
        }

        public int buscarSector(int sector)
        {
            return DaoTurno.instanacia.buscarSector(sector);
        }
    }

}

﻿using System;
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
    public class NegocioAdministrador
    {
        public static NegocioAdministrador instancia = new NegocioAdministrador();

        public List<DETALLE_CARACTERISTICA> listar()
        {

            return DaoDetalleCaracteristica.instancia.listarCategoria();
        }
        public int  CrearPersonal(PERSONAL dto,int tipo)
        {
            if(tipo==1)
                dto.PASSWORD_PER = GeneraMd5.instancia.md5(dto.RUT_PER.ToString().Substring(0,5));

            return DaoPersonal.instancia.CrearPersonal(dto,tipo);
        }

        public List<PERSONAL> buscarPersona(String rut)
        {
            return DaoPersonal.instancia.BuscarUsuario(rut);
        }

        public int ReiniciarClave(String clave, String rut)
        {
            clave = GeneraMd5.instancia.md5(clave);
            return DaoPersonal.instancia.ReiniciarClave(clave, rut);
            
        }

        public List<DETALLE_CARACTERISTICA> listarOrientacion()
        {
            return DaoDetalleCaracteristica.instancia.listarOrientacion();
        }

        public List<DETALLE_CARACTERISTICA> listarVelocidad()
        {
            return DaoDetalleCaracteristica.instancia.listarVelocidad();
        }

        public List<DETALLE_CARACTERISTICA> listarSentido()
        {
            return DaoDetalleCaracteristica.instancia.listarSentido();
        }

        public List<DETALLE_CARACTERISTICA> listarTipoCalle()
        {
            return DaoDetalleCaracteristica.instancia.listarTipoCalle();
        }


        public Boolean existeCalle(String calle)
        {
            return DaoPersonal.instancia.existeCalle(calle);
        }

       public int CreaCalle(DETALLE_CARACTERISTICA dto, int pista, int orientacion, int velocidadMaxima, int sentido, int sector, int tipoCalle, int tipo, String estado)
       {
           return DaoViaCirculacion.instancia.grabarCalle(dto, pista, orientacion, velocidadMaxima, sentido, sector, tipoCalle,tipo, estado);
       }

        public int CreaDetalleCaracteristica(DETALLE_CARACTERISTICA dto)
        {
            return DaoDetalleCaracteristica.instancia.CrearDetalleCaracteristica(dto);
        }

        public List<DETALLE_CARACTERISTICA> listarGravedad()
        {
            return DaoDetalleCaracteristica.instancia.listarGravedad();
        }

        public List<DETALLE_CARACTERISTICA> listarTipoMoneda()
        {
            return DaoDetalleCaracteristica.instancia.listarTipoMoneda();
        }

        public List<DETALLE_CARACTERISTICA> listarSector()
        {
            return DaoDetalleCaracteristica.instancia.listarSector();
        }

        public List<DETALLE_CARACTERISTICA> buscarCalle(String calle)
        {
            return DaoDetalleCaracteristica.instancia.BuscarCalle(calle);
        }
       
       

        public Boolean existeRut(String rut)
        {
            return DaoPersonal.instancia.existeRut(rut);
        }

        public Boolean existeRut2(String rut)
        {
            return DaoPersonal.instancia.existeRut2(rut);
        }


        public List<DETALLE_CARACTERISTICA> listarCalle()
        {
            return DaoDetalleCaracteristica.instancia.ListarCalle();
        }
        public List<DETALLE_CARACTERISTICA> listarMotivo()
        {
            return DaoDetalleCaracteristica.instancia.ListarMotivo();
        }

        public List<DETALLE_CARACTERISTICA> listarMotivoddl()
        {
            List<DETALLE_CARACTERISTICA> lista = DaoDetalleCaracteristica.instancia.ListarMotivo();

            foreach (DETALLE_CARACTERISTICA d in lista)
            {
                if (d.DETALLE_CAR.Length > 30)
                d.DETALLE_CAR = d.DETALLE_CAR.Substring(0, 29) + "..."; 
            }
            return  lista;
        }

        

        public List<DETALLE_CARACTERISTICA> buscarInfraccion(int idinfr)
        {
            return DaoDetalleCaracteristica.instancia.BuscarInfraccion(idinfr);
        }


        public int crearInfraccion(INFRACCION objinfra, String descripcion, int tipo)
        {

            return DaoInfraccion.instancia.crearInfraccion(objinfra, descripcion,tipo);
        }

       

        //public int CrearCalle(VIA_CIRCULACION vcir, int tipo)
        //{

        //  //  return DaoPersonal.instancia.CrearCalle(vcir, tipo);
        //}
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConexionDatos;
using ConexionDatos.Entity;
using ConexionDatos.Dao;
using ClasesESpeciales.Helper;
using ClasesESpeciales;
namespace Negocio
{
    public class NegocioJefeTransito
    {

        public static NegocioJefeTransito instancia = new NegocioJefeTransito();

        public int actualizaClavePropia(String clave, String rut)
        {
            clave = GeneraMd5.instancia.md5(clave);
            return DaoPersonal.instancia.actualizaClavePropia(clave, rut);
        }
        public List<DetalleApelacion> detalleApelacion(String rut)
        {
            return DaoPersonal.instancia.detalleApelacion(rut);
        }

        public String trarAdjunto(int idAdjunto)
        {
           
            return DaoAdjuntosApelacion.instancia.traeAdjunto(DaoApelacion.instancia.traeAdjunto(idAdjunto));
        }

        public void actualizaEstado(int id, int estado)
        {
            DaoApelacion.instancia.actualizaEstado(id,estado);    
        }

        public int apelacion(int id, String descripcion, int aceptado, int monto)
        {
            return DaoApelacion.instancia.apelacion(id,descripcion,aceptado, monto);
        }


        public int apelacion0(int id, String descripcion, int aceptado)
        {
            return DaoApelacion.instancia.apelacion0(id, descripcion, aceptado);
        }
    }

}

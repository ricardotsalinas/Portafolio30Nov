using System;
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

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConexionDatos;
using ConexionDatos.Entity;
using ConexionDatos.Dao;
using ClasesESpeciales;
using ClasesESpeciales.Helper;

namespace Negocio
{
    public class NegocioInfractor
    {
        public static NegocioInfractor instancia = new NegocioInfractor();
       
        public List<INFRACTOR> buscarInfractor(String rut)
        {
            return  DaoInfractor.Instancia.buscarInfractor(rut);
        }

        public int actualizaClave(String clave, String rut)
        {
            clave = GeneraMd5.instancia.md5(clave);
            return DaoInfractor.Instancia.actualizaClave(clave, rut);
        }


        public List<DatosPersonalesInfractor> datosPersonales(String rut)
        {
            return DaoInfractor.Instancia.datosPersonales(rut);
        
        }

        public int actualizaDatosPersonales(String email, String telefono, String rut)
        {
            return DaoInfractor.Instancia.actualizaDatosPersonales(email, telefono, rut);
        }


        public List<HistorialInfractor> historiInfractor(String rut)
        {
            return DaoInfractor.Instancia.listaHistorial(rut);
        }

        public List<DetalleMultaInfractor> detalleInfractor(String idMulta)
        {
            return DaoInfractor.Instancia.detalleInfractor(idMulta);
        }

        public String  crearApelacion(ADJUNTOS_APELACION adjApelacion, APELACION ape,Boolean adjunto)
        {
            int idApelacion=-99;
            if (adjunto)
                idApelacion = DaoAdjuntosApelacion.instancia.crearAdjunto(adjApelacion);

            int apelacion =DaoApelacion.instancia.crearApelacion(ape,idApelacion);

            if (apelacion == 0)
                return "ERROR";
            else
                return idApelacion.ToString();
        }

    }
}

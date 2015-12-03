using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConexionDatos;
using ConexionDatos.Entity;
using ConexionDatos.Dao;
using System.Collections;
using ClasesESpeciales.Helper;

namespace Negocio
{
   public class NegocioInspector
    {
       public static NegocioInspector instancia = new NegocioInspector();

       public VEHICULO buscarPatente(String pat)
       {
          return DaoVehiculo.Instancia.buscarPatente(pat);
       }

      /* public INFRACTOR buscarInfractor(int rut)
       {
           return DaoInfractor.Instancia.buscarInfractorPat(rut);
       }*/

       public ArrayList datosRegistroCivil(String patente)
       {
           return WebService.instancia.datosRegistroCivil(patente);
       }

       public int actualizaClavePropia(String clave, String rut)
       {
           clave = GeneraMd5.instancia.md5(clave);
           return DaoPersonal.instancia.actualizaClavePropia(clave, rut);
       }

       public int buscaInspector(String rut)
       {
           return DaoPersonal.instancia.buscarInspector(rut);
       
       }

       public int idViaN(int lugar)
       {
           return DaoViaCirculacion.instancia.idVia(lugar);

       }

       public int moneda(int idInfraccion)
       {
           int tipoMoneda = DaoInfraccion.instancia.tipoMoneda(idInfraccion);
           return DaoMoneda.instancia.idMoneda(tipoMoneda);
       
       }

       public int idRestriccion()
       {
           return DaoRestriccion.instancia.idRestriccion();
       }

       public int grabaMulta(MULTA objMulta)
       {
           return DaoMulta.instancia.grabaMulta(objMulta);
       }
       public int creaVehiculo(String patente)
       {
           return DaoVehiculo.Instancia.crearVehiculo(patente);
       }

       public int existeVehiculo(String patente)
       {
           return DaoVehiculo.Instancia.existeVehiculo(patente);
       }


       public int idInfraccion(int idMotivo)
       {
           return DaoInfraccion.instancia.tipoMoneda(idMotivo);
       }
       public int idInfraccion2(int idMotivo)
       {
           return DaoInfraccion.instancia.idInfraccion(idMotivo);
       }
    }
}

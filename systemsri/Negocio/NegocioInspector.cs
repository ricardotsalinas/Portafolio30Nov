using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConexionDatos;
using ConexionDatos.Entity;
using ConexionDatos.Dao;
using System.Collections;

namespace Negocio
{
   public class NegocioInspector
    {
       public static NegocioInspector instancia = new NegocioInspector();

       public VEHICULO buscarPatente(String pat)
       {
          return DaoVehiculo.Instancia.buscarPatente(pat);
       }

       public INFRACTOR buscarInfractor(int rut)
       {
           return DaoInfractor.Instancia.buscarInfractorPat(rut);
       }

       public ArrayList datosRegistroCivil(String patente)
       {
           return WebService.instancia.datosRegistroCivil(patente);
       }
    }
}

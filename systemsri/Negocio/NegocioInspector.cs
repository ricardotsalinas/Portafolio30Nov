using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConexionDatos;
using ConexionDatos.Entity;
using ConexionDatos.Dao;

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

      

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConexionDatos;
using ConexionDatos.Entity;
using ClasesESpeciales;
using ConexionDatos.Dao;
using ClasesESpeciales.Helper;

namespace Negocio
{
   public  class NegocioLoginUsuario
    {
       public static NegocioLoginUsuario instancia = new NegocioLoginUsuario();


       public String urlUsuario(String rut, String clave)
       {
           clave = clave = GeneraMd5.instancia.md5(clave);
           String url = "";
           String TipoUsuario = "";
           String password = "";
           String usuario = "";
           List<LoginUsuario> loginUsuario = new List<LoginUsuario>();
           loginUsuario = DaoLoginUsuario.instanacia.sessionUsuario(rut, clave);
           foreach (var item in loginUsuario)
           {
               TipoUsuario = item.NOMBRE;
               usuario = item.RUT;
               password = item.CLAVE;
           }
           if (password.Equals(clave) && usuario.Equals(rut))
           {
               switch (TipoUsuario)
               {
                   case "INSPECTOR MUNICIPAL":
                       url = "../Inspector/datosInspector.aspx";
                       break;
                   case "JEFE DE TRANSITO":
                       url = "../JefeTransito/inicioJefe.aspx";
                       break;
                   case "FUNCIONARIO":
                       url = "../Funcionario/inicioFun.aspx";
                       break;
                   case "ADMINISTRADOR DEL SISTEMA":
                       url ="../Administrador/inicioAdmin.aspx";
                   break;
                   default:
                       url = "../LoginUsuario/loginUsuario.aspx";
                       break;
               }

           }
           else
               url = "../LoginUsuario/loginUsuario.aspx";

           return url;
       }


       public Boolean sessionInfractor(String rut, String clave)
       {
           clave = GeneraMd5.instancia.md5(clave);
           String validacion = "";

           List<INFRACTOR> linfractor = new List<INFRACTOR>();
           linfractor = DaoLoginUsuario.instanacia.sessionInfractor(rut, clave);

           foreach (var item in linfractor)
           {
               validacion = item.PASSWORD_INFR;
           }

           if (validacion.Equals(clave))
               return true;
           else
               return false;

       }
       public Boolean validaPagina(String rut, int tipo)
       {
           return DaoLoginUsuario.instanacia.verificaPagina(rut, tipo);
       }

      public Boolean validaPaginaInfractor(String rut)
       {
           return DaoLoginUsuario.instanacia.verificaPaginaInfractor(rut);
       }





       
    }
}

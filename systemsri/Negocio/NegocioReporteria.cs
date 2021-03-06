﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesESpeciales;
using ConexionDatos.Dao;
using ClasesESpeciales.Helper;
using System.Collections;
using ClasesESpeciales;

namespace Negocio
{
    public class NegocioReporteria
    {
        public static NegocioReporteria Instancia = new NegocioReporteria();

        public List<ReporteInfractor> ListarInfractores(string rut, int tipo)
        {
            return ReportesDAO.Instancia.ReporteInfractores(rut,tipo);
        }


        public object ListarInfractoresSinRut(string dato,int tipo)
        {
            return ReportesDAO.Instancia.ReporteInfractoresSinRut(dato,tipo);
        }

        public List<ReporteCalles> ListarCalles()
        {
            return ReportesDAO.Instancia.ReporteCalles();
        }
        public List<ReporteInfracciones> listarInfracciones()
        {
            return ReportesDAO.Instancia.ReporteInfracciones();
        }

     
        public List<ReporteTurnos> ListarTurnos()
        {
            return ReportesDAO.Instancia.ReporteTurnos();
        }

      

        public List<ReporteMultas> ListarMulta(String rut)
        {
            return ReportesDAO.Instancia.ReporteMultas(rut);
        }

        
    }
}

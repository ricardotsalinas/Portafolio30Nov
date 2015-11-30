using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConexionDatos.Dao
{
    public class WebService
    {

        public static WebService instancia = new WebService();

        Indicadores.TipoCambio indicador = new Indicadores.TipoCambio();


        public int IndicadorEconomico(String tipo)
        {
            decimal valorTipo = Convert.ToDecimal(indicador.Indicador(tipo));
            int  valorPeso = (int)Math.Round(valorTipo);
            return valorPeso;
        }


         
    }
}

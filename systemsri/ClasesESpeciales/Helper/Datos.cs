using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesESpeciales.Helper
{
    public class Datos
    {
        public static bool IsNumeric(object Expression)
        {
            bool isNum;
            double retNum;

            isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        public static string GetGuid()
        {
            int valorMinimo = 1000000;
            int valorMaximo = 9999999;

            Random rand1 = new Random(DateTime.Now.Millisecond + (int)DateTime.Now.Ticks);
            int valorAleatorio1 = rand1.Next(valorMinimo, valorMaximo);

            Random rand2 = new Random(DateTime.Now.Millisecond + DateTime.Now.Millisecond);
            int valorAleatorio2 = rand2.Next(valorMinimo, valorMaximo);

            Random rand3 = new Random(DateTime.Now.Millisecond + (int)DateTime.Now.Ticks + DateTime.Now.Millisecond);
            int valorAleatorio3 = rand3.Next(valorMinimo, valorMaximo);

            return string.Concat(valorAleatorio1.ToString(), valorAleatorio2.ToString(), valorAleatorio3.ToString());
        }
    }
}

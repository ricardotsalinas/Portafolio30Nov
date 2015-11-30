using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesESpeciales
{
    public class HistorialInfractor
    {
        public decimal ID_MULTA  { set;get; }
        public String PATENTE   { set;get; }
        public DateTime FECHA   { set;get; }
        public String TIPO_MULTA{ set;get; }
        public decimal VALOR_PESO   { set;get; }
        public String PAGADA    { set;get; }
        
    }
}

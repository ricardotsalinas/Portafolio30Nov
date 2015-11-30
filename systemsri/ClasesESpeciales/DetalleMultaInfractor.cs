using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesESpeciales
{
    public class DetalleMultaInfractor
    {
        public decimal ID_MULTA         { set;get; }
        public String GRAVEDAD          { set;get; }
        public decimal MONTO            { set;get; }
        public DateTime FECHA_MULTA     { set;get; }
        public String HORA_MULTA        { set;get; }
        public String MOTIVO_MULTA      { set;get; }
        public String DETALLE_ADICIONAL { set;get; }
        public String LUGAR_INFRACCION  { set;get; }
        public String RUT               { set;get; }  
        public String NOMBRE            { set;get; }
        public String PATENTE           { set;get; }
    }
}

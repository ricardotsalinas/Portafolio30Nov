using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConexionDatos.Dao
{
    public class ReporteInfracciones
    {
        public decimal ID_INF { set; get; }
        public String GRAVEDAD { set; get; }
        public String TIPO_MONEDA { set; get; }
        public decimal VALOR { set; get; }
        public String DESCR_INF { set; get; }


    }
}

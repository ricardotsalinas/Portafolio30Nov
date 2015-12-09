using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesESpeciales
{
    public class ReporteTurnos
    {
        public decimal    ID_TUR            { set; get; }
        public String     RUT_PER           { set; get; }
        public String     NOMBRE_PER        { set; get; }
        public String     SECTOR            { set; get; }
        public DateTime   FECHA_TUR         { set; get; }
        public String     HORA_INICIO       { set; get; }
        public String     HORA_FIN          { set; get; }
        public String     DESCRIPCION_TUR   { set; get; }
    }
}

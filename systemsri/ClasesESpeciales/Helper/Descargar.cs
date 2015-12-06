using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace ClasesESpeciales.Helper
{
    public class Descargar
    {
        public static Descargar instancia = new Descargar();

        public void Download(string sFileName, string sFilePath)
        {
            HttpContext.Current.Response.ContentType = "APPLICATION/OCTET-STREAM";
            String Header = "Attachment; Filename=" + sFileName;
            HttpContext.Current.Response.AppendHeader("Content-Disposition", Header);
            System.IO.FileInfo Dfile = new System.IO.FileInfo(HttpContext.Current.Server.MapPath(sFilePath));
            HttpContext.Current.Response.WriteFile(Dfile.FullName);
            HttpContext.Current.Response.End();
        }
    }
}

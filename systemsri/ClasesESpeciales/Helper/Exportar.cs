using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI;

namespace ClasesESpeciales.Helper
{
    public class Exportar
    {

        public static void ExportarExcelGrilla(GridView grilla, Page pag)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            Page pagina = new Page();
            HtmlForm form = new HtmlForm();
            grilla.EnableViewState = false;
            pagina.EnableEventValidation = false;
            pagina.DesignerInitialize();
            pagina.Controls.Add(form);
            form.Controls.Add(grilla);
            pagina.RenderControl(htw);


            pag.Response.Clear();
            pag.Response.Buffer = true;
            pag.Response.ContentType = "application/vnd.ms-excel";
            pag.Response.AddHeader("Content-Disposition", "attachment;filename=data.xls");
            pag.Response.Charset = "UTF-8";

            pag.Response.ContentEncoding = Encoding.Default;
            pag.Response.Output.Write(sb.ToString());
            pag.Response.End();
        }


        public static void ExportarExcelDataTable(DataTable dt)
        {
            Page pag = new Page();
            try
            {
                const string FIELDSEPARATOR = ";";
                const string ROWSEPARATOR = "\n";
                StringBuilder output = new StringBuilder();
                // Escribir encabezados    
                foreach (DataColumn dc in dt.Columns)
                {
                    output.Append(dc.ColumnName);
                    output.Append(FIELDSEPARATOR);
                }
                output.Append(ROWSEPARATOR);
                foreach (DataRow item in dt.Rows)
                {
                    foreach (object value in item.ItemArray)
                    {
                        if (Datos.IsNumeric(value.ToString()) && value.ToString().Length > 11)
                        {
                            output.Append("'");
                            output.Append(value.ToString().Replace('\n', ' ').Replace('\r', ' ').Replace('.', ','));
                        }
                        else
                        {
                            output.Append(value.ToString().Replace('\n', ' ').Replace('\r', ' ').Replace('.', ','));
                        }
                        //output.Append(');
                        output.Append(FIELDSEPARATOR);
                    }
                    // Escribir una línea de registro        
                    output.Append(ROWSEPARATOR);
                }
                // Valor de retorno    
                // output.ToString();
                pag.Response.Clear();
                pag.Response.Buffer = true;
                pag.Response.ContentType = "application/vnd.ms-excel";
                pag.Response.AddHeader("Content-Disposition", "attachment;filename=data.xls");
                pag.Response.Charset = "UTF-8";

                pag.Response.ContentEncoding = Encoding.UTF8;
                pag.Response.Write(output.ToString());
                pag.Response.End();
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
            }
        }



        public static void ExportarExcelDataTable(DataTable dt, string RutaExcel)
        {
            try
            {
                const string FIELDSEPARATOR = ";";
                const string ROWSEPARATOR = "\n";
                StringBuilder output = new StringBuilder();
                // Escribir encabezados    
                foreach (DataColumn dc in dt.Columns)
                {
                    output.Append(dc.ColumnName);
                    output.Append(FIELDSEPARATOR);
                }
                output.Append(ROWSEPARATOR);
                foreach (DataRow item in dt.Rows)
                {
                    foreach (object value in item.ItemArray)
                    {
                        if (Datos.IsNumeric(value.ToString()) && value.ToString().Length > 11)
                        {
                            output.Append("'");
                            output.Append(value.ToString().Replace('\n', ' ').Replace('\r', ' ').Replace('.', ','));
                        }
                        else
                        {
                            output.Append(value.ToString().Replace('\n', ' ').Replace('\r', ' ').Replace('.', ','));
                        }
                        //output.Append(');
                        output.Append(FIELDSEPARATOR);
                    }
                    // Escribir una línea de registro        
                    output.Append(ROWSEPARATOR);
                }
                // Valor de retorno    
                // output.ToString();
                StreamWriter sw = new StreamWriter(RutaExcel, false, Encoding.UTF8);
                sw.Write(output.ToString());
                sw.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

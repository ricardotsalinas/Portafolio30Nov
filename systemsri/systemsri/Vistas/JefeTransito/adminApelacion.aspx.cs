using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using ClasesESpeciales.Helper;

namespace systemsri.Vistas.JefeTransito
{
    public partial class adminApelacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"].Equals("") || Session["usuario"] == null ||
                !NegocioLoginUsuario.instancia.validaPagina(Session["usuario"].ToString(), 44))
            {
                Response.Redirect("../LoginUsuario/loginUsuario.aspx");
            }
        }

        protected void btnBuscarAA_Click(object sender, EventArgs e)
        {

            gvReporte.DataSource = NegocioReporteria.Instancia.ListarInfractores(txtRutAA.Text);
            gvReporte.DataBind();
        }

        protected void gvReporte_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Image img = (Image)e.Row.Cells[4].FindControl("imgGrilla");
                if (e.Row.Cells[1].Text == "hola loko")
                {
                    img.ImageUrl= "";
                }
                img.Attributes.Add("onclick", "ventana(" + e.Row.RowIndex + ")");
            }
        }

        protected void btnMagico_Click(object sender, EventArgs e)
        {
            int num = 0;
            num = 4;
        }

        protected void ddlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvReporte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnErxporta_Click(object sender, EventArgs e)
        {
            GridView gv = gvReporte;
            gv.Columns.RemoveAt(4);

            Exportar.ExportarExcelGrilla(gv, this.Page);
        }

       

       

       
    }
}
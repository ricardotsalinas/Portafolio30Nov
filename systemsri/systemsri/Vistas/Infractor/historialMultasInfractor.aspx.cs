using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using System.Drawing;
using System.Collections.Specialized;
using ClasesESpeciales.Helper;

namespace systemsri.Vistas.Infractor
{
    public partial class historialMultasInfractor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["usuario"].Equals("") || Session["usuario"] == null)
            {
                Response.Redirect("../LoginUsuario/loginInfractor.aspx");
            }

            if (!Page.IsPostBack)
            {
                GvHistMultasHMI.DataSource = NegocioInfractor.instancia.historiInfractor(Session["usuario"].ToString());
                GvHistMultasHMI.DataBind();

            }
        }

        protected void GvHistMultasHMI_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GvHistMultasHMI_RowDataBound(object sender, GridViewRowEventArgs e)
        {

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (e.Row.Cells[5].Text == "0")
                {
                    e.Row.Cells[5].Text = "NO PAGADO";
                    e.Row.Cells[5].ForeColor = Color.Red;
                    e.Row.Cells[5].Font.Bold = true;

                }
                else
                {
                    if (e.Row.Cells[5].Text == "1")
                    {
                        e.Row.Cells[5].Text = "PAGADO";

                    }

                }
            }

        }

        protected void GvHistMultasHMI_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "detalle")
            {
                int index = Convert.ToInt32(e.CommandArgument);

                NameValueCollection data = new NameValueCollection();
                GridViewRow row = GvHistMultasHMI.Rows[index];
                String post = row.Cells[0].Text;
                data.Add("idMulta", post);
                if (row.Cells[5].Text.Equals("NO PAGADO"))
                {
                    HttpHelper.RedirectAndPOST(this.Page, "detallePagarMulta.aspx", data);
                }
                else
                {
                    if (row.Cells[5].Text.Equals("PAGADO"))
                    {
                        HttpHelper.RedirectAndPOST(this.Page, "detalleMultasInfractor.aspx", data);
                    }
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Exportar.ExportarExcelGrilla(GvHistMultasHMI, this.Page);
        }




    }
}
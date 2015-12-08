using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using ClasesESpeciales.Helper;
using System.Collections.Specialized;
using System.Drawing;

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
            btnErxporta.Visible = false;
        }

        protected void btnBuscarAA_Click(object sender, EventArgs e)
        {
            if (txtRutAA.Text == "" || txtRutAA.Text == null)
            {

                switch (Convert.ToInt32(ddlistFiltro.SelectedValue))
                {
                    case 0:
                        gvReporte.DataSource = NegocioReporteria.Instancia.ListarInfractoresSinRut(txtRutAA.Text, 0);
                        gvReporte.DataBind();
                        break;
                    case 1:
                        if (CheckBox1.Checked)
                        {
                            gvReporte.DataSource = NegocioReporteria.Instancia.ListarInfractoresSinRut(txtRutAA.Text, 11);
                            gvReporte.DataBind();
                        }
                        else
                        {
                            gvReporte.DataSource = NegocioReporteria.Instancia.ListarInfractoresSinRut(txtRutAA.Text, 1);
                            gvReporte.DataBind();
                        }
                        break;
                    case 2:
                        gvReporte.DataSource = NegocioReporteria.Instancia.ListarInfractoresSinRut(txtRutAA.Text, 2);
                        gvReporte.DataBind();
                        break;
                    case 3:
                        gvReporte.DataSource = NegocioReporteria.Instancia.ListarInfractoresSinRut(txtRutAA.Text, 3);
                        gvReporte.DataBind();
                        break;
                    case 4:
                        gvReporte.DataSource = NegocioReporteria.Instancia.ListarInfractoresSinRut(txtRutAA.Text, 4);
                        gvReporte.DataBind();
                        break;
                }
            }

                if (txtRutAA.Text.Length > 7)
                {
                switch (Convert.ToInt32(ddlistFiltro.SelectedValue))
                {
                    case 0:
                        gvReporte.DataSource = NegocioReporteria.Instancia.ListarInfractores(txtRutAA.Text, 0);
                        gvReporte.DataBind();
                        break;
                    case 1:
                        if (CheckBox1.Checked)
                        {
                            gvReporte.DataSource = NegocioReporteria.Instancia.ListarInfractores(txtRutAA.Text, 11);
                            gvReporte.DataBind();
                        }
                        else
                        {
                            gvReporte.DataSource = NegocioReporteria.Instancia.ListarInfractores(txtRutAA.Text, 1);
                            gvReporte.DataBind();
                        }
                        break;
                    case 2:
                        gvReporte.DataSource = NegocioReporteria.Instancia.ListarInfractores(txtRutAA.Text, 2);
                        gvReporte.DataBind();
                        break;
                    case 3:
                        gvReporte.DataSource = NegocioReporteria.Instancia.ListarInfractores(txtRutAA.Text, 3);
                        gvReporte.DataBind();
                        break;
                    case 4:
                        gvReporte.DataSource = NegocioReporteria.Instancia.ListarInfractores(txtRutAA.Text, 4);
                        gvReporte.DataBind();
                        break;
                }
                }
            
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

        protected void gvReporte_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "botonGV")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                NameValueCollection data = new NameValueCollection();
                GridViewRow row = gvReporte.Rows[index];
                String post = row.Cells[3].Text;
                data.Add("rut_infr", post);
                HttpHelper.RedirectAndPOST(this.Page, "CasosApelacion.aspx", data);

            }
        }

        protected void gvReporte_RowDataBound1(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (e.Row.Cells[1].Text == "1142")
                {
                    e.Row.Cells[1].Text = "NO LEIDO";
                    e.Row.Cells[1].ForeColor = Color.Red;
                }
                else
                {   e.Row.Cells[1].Text = "LEIDO";
                    e.Row.Cells[1].ForeColor = Color.Green;
                }
                if (e.Row.Cells[0].Text == "1143")
                {
                    e.Row.Cells[0].Text = "RESUELTO";
                    e.Row.Cells[0].ForeColor = Color.Green;
                }
                else                 
                {
                    e.Row.Cells[0].Text = "NO RESUELTO";
                    e.Row.Cells[0].ForeColor = Color.Red;
                }
                


                }






            }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using ConexionDatos.Entity;
using System.Collections.Specialized;

namespace systemsri.Vistas.Administrador
{
    public partial class adminInfracciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          /*  if (Session["usuario"].Equals("") || Session["usuario"] == null ||
    !NegocioLoginUsuario.instancia.validaPagina(Session["usuario"].ToString(), 47))
            {
                Response.Redirect("../LoginUsuario/loginUsuario.aspx");

            }*/
            if (!Page.IsPostBack)
            {
                
                ddlistGravedadAI.DataSource = NegocioAdministrador.instancia.listarGravedad();
               ddlistGravedadAI.DataBind();
               ddlistGravedadAI.Items.Insert(0, new ListItem("Seleccionar", ""));
               
                
                ddlistTipoMonedaAI.DataSource = NegocioAdministrador.instancia.listarTipoMoneda();
               ddlistTipoMonedaAI.DataBind();
               ddlistTipoMonedaAI.Items.Insert(0, new ListItem("Seleccionar", ""));
                lblInfoAdI.Visible = false;
                chkActivoAIn.Checked = true;
            }
        }


        protected void btnBuscarAI_Click(object sender, EventArgs e)
        {


        }

        protected void btnGuardarAI_Click(object sender, EventArgs e)
        {

          
                int n = 0;
                if (txtDescrInfraccionAI.Text == "" || txtDescrInfraccionAI.Text == null)
                {
                    txtDescrInfraccionAI.BorderColor = System.Drawing.Color.Red;
                    txtDescrInfraccionAI.BorderWidth = 1;
                    n = 1;
                }
                else
                {
                    txtDescrInfraccionAI.BorderColor = System.Drawing.Color.LightGray;
                    txtDescrInfraccionAI.BorderWidth = 1;
                    n = 0;
                }

                if (txtValorAI.Text == "" || txtValorAI.Text == null)
                {
                    txtValorAI.BorderColor = System.Drawing.Color.Red;
                    txtValorAI.BorderWidth = 1;
                    n = 1;
                }
                else
                {
                    txtValorAI.BorderColor = System.Drawing.Color.LightGray;
                    txtValorAI.BorderWidth = 1;
                    n = 0;
                }
                if (ddlistGravedadAI.SelectedIndex == 0)
                {

                    ddlistGravedadAI.BorderColor = System.Drawing.Color.Red;
                    n = 1;
                }
                else
                {
                    ddlistGravedadAI.BorderColor = System.Drawing.Color.LightGray;
                    ddlistGravedadAI.BorderWidth = 1;
                    n = 0;
                }

                if (ddlistGravedadAI.SelectedIndex == 0)
                {

                    ddlistTipoMonedaAI.BorderColor = System.Drawing.Color.Red;
                    n = 1;
                }
                else
                {
                    ddlistTipoMonedaAI.BorderColor = System.Drawing.Color.LightGray;
                    ddlistTipoMonedaAI.BorderWidth = 1;
                    n = 0;
                }

                if (n == 1)
                {
                    lblInfoAdI.Visible = true;
                    lblInfoAdI.Text = "Los campos en Rojo son obligatorios";
                    lblInfoAdI.ForeColor = System.Drawing.Color.Red;


                }
                else
                {
                    lblInfoAdI.Visible = true;
                    lblInfoAdI.Text = "Datos guardados";
                    lblInfoAdI.ForeColor = System.Drawing.Color.Gray;
                }

   


        }

        protected void ddlistGravedad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlistTipoMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void txtDescrInfraccion_TextChanged(object sender, EventArgs e)
        {

        }

        protected void gvInfrAI_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        protected void gvInfrAI_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvInfrAI.PageIndex = e.NewPageIndex;
            gvInfrAI.DataSource = NegocioReporteria.Instancia.listarInfracciones();
            gvInfrAI.DataBind();
        }

        protected void gvInfrAI_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void gvInfrAI_DataBound(object sender, EventArgs e)
        {

        }

        protected void btnListar_Click(object sender, EventArgs e)
        {
            gvInfrAI.DataSource = NegocioReporteria.Instancia.listarInfracciones();
            gvInfrAI.DataBind();
            gvInfrAI.Visible = true;
        }

        protected void btnBorrarAI_Click(object sender, EventArgs e)
        {
            lblInfoAdI.Visible = false;
            ddlistGravedadAI.SelectedIndex = 0;
            ddlistTipoMonedaAI.SelectedIndex = 0;

            txtDescrInfraccionAI.Text = "";
            TxtID.Text = String.Empty;
            txtValorAI.Text = "";
            ddlistGravedadAI.Items.Insert(0, new ListItem("Seleccione", ""));

            ddlistGravedadAI.BorderColor = System.Drawing.Color.LightGray;
            ddlistTipoMonedaAI.BorderColor = System.Drawing.Color.LightGray;
            txtValorAI.BorderColor = System.Drawing.Color.LightGray;
            txtDescrInfraccionAI.BorderColor = System.Drawing.Color.LightGray;

            gvInfrAI.Visible = false;

            ddlistGravedadAI.BorderWidth = 1;
            ddlistTipoMonedaAI.BorderWidth = 1;
            txtValorAI.BorderWidth = 1;
            txtDescrInfraccionAI.BorderWidth = 1;

        }



        protected void chkActivoAIn_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void ddlistGravedadAI_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlistTipoMonedaAI_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        protected void gvInfrAI_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            
            int contador = 0;
            if (e.CommandName == "BotonGV")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gvInfrAI.Rows[index];
                txtDescrInfraccionAI.Text = row.Cells[4].Text;
                txtValorAI.Text = row.Cells[2].Text;
                TxtID.Text = row.Cells[0].Text;


                foreach (var item in ddlistGravedadAI.Items)
                {
                    if (item.ToString().Equals(row.Cells[1].Text))
                        ddlistGravedadAI.SelectedIndex = contador;
                    contador = contador + 1;
                }
                contador = 0;
                foreach (var item in ddlistTipoMonedaAI.Items)
                {
                    if (item.ToString().Equals(row.Cells[3].Text))
                        ddlistTipoMonedaAI.SelectedIndex = contador;
                    contador = contador + 1;
                }
                contador = 0;
            }



        }
    }
}
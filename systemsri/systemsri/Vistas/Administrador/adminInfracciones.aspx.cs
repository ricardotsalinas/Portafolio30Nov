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
            ddlistGravedadAI.Items.Clear();
            ddlistGravedadAI.Items.Insert(0, new ListItem("Seleccionar", ""));
            ddlistGravedadAI.DataSource = NegocioAdministrador.instancia.listarGravedad();
            ddlistGravedadAI.DataBind();
            ddlistTipoMonedaAI.Items.Insert(0, new ListItem("Seleccionar", ""));
            ddlistTipoMonedaAI.DataSource = NegocioAdministrador.instancia.listarTipoMoneda();
            ddlistTipoMonedaAI.DataBind();
            lblInfoAdI.Visible = false;
            chkActivoAIn.Checked = true;
        }


        protected void btnBuscarAI_Click(object sender, EventArgs e)
        {
            
           
        }

        protected void btnGuardarAI_Click(object sender, EventArgs e)
        {

            lblInfoAdI.Visible = true;
            lblInfoAdI.Text = "Los campos en Rojo son obligatorios";
            lblInfoAdI.ForeColor = System.Drawing.Color.Red;
            ddlistGravedadAI.BorderColor = System.Drawing.Color.Red;
            ddlistTipoMonedaAI.BorderColor = System.Drawing.Color.Red;
            txtValorAI.BorderColor = System.Drawing.Color.Red;
            txtValorAI.BorderWidth = 1;
            txtDescrInfraccionAI.BorderColor = System.Drawing.Color.Red;

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
        }

        protected void btnBorrarAI_Click(object sender, EventArgs e)
        {
            lblInfoAdI.Visible = false;
            ddlistGravedadAI.SelectedIndex = 0;
            ddlistTipoMonedaAI.SelectedIndex = 0;
          
            txtDescrInfraccionAI.Text = "";
            txtValorAI.Text = "";
            ddlistGravedadAI.Items.Insert(0,new ListItem("Seleccione",""));
           
            ddlistGravedadAI.BorderColor = System.Drawing.Color.LightGray;
            ddlistTipoMonedaAI.BorderColor = System.Drawing.Color.LightGray;
            txtValorAI.BorderColor = System.Drawing.Color.LightGray;
            txtDescrInfraccionAI.BorderColor = System.Drawing.Color.LightGray;

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
            String dato = "";
            int index = Convert.ToInt32(e.CommandArgument);
            List<DETALLE_CARACTERISTICA> buscar = NegocioAdministrador.instancia.buscarInfraccion(A);
            GridViewRow row = gvInfrAI.Rows[index];
            String post = row.Cells[0].Text;
           txtDescrInfraccionAI.Text =post;
           
            
               


            if (row.Cells[5].Text.Equals("NO PAGADO"))
            {
                HttpHelper.RedirectAndPOST(this.Page, "detallePagarMulta.aspx", data);
            }



            if (e.CommandName == "detalle")
            {
                int index = Convert.ToInt32(e.CommandArgument);

                NameValueCollection data = new NameValueCollection();
                //GridViewRow row = gvInfrAI.Rows[index];
                //String post = row.Cells[0].Text;
               // data.Add("idInfraccion", post);
                txtDescrInfraccionAI.Text = "Aqui ta";


            }
        }

      
        
    }
}
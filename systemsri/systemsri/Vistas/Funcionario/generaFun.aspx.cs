using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using ConexionDatos.Entity;
using ClasesESpeciales;

namespace systemsri.Vistas.Funcionario
{
    public partial class generaFun : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlistSectorGF.DataSource = NegocioFuncionario.instancia.listarSector();
            ddlistSectorGF.DataBind();
            ddlistSectorGF.Items.Insert(0, new ListItem("Seleccionar", ""));
        }

        protected void btnGuardarGF_Click(object sender, EventArgs e)
        {
            DetalleTurno dt = new DetalleTurno();
            dt.ID_TUR= Convert.ToInt32(ddlistSectorGF.SelectedValue);
         //   int newTurno = NegocioFuncionario.instancia.crearTurno()


//    int newInfraccion = NegocioAdministrador.instancia.crearInfraccion(objinfra, txtDescrInfraccionAI.Text, tipo);
            //    switch (newInfraccion)
            //    {
            //        case 1:
            //            lblInfoAdI.Visible = true;
            //            lblInfoAdI.Text = "Datos guardados";
            //            lblInfoAdI.ForeColor = System.Drawing.Color.Gray;
            //            ddlistGravedadAI.SelectedIndex = 0;
            //            ddlistTipoMonedaAI.SelectedIndex = 0;

            //            txtDescrInfraccionAI.Text = "";
            //            TxtID.Text = String.Empty;
            //            txtValorAI.Text = "";
            //            ddlistGravedadAI.Items.Insert(0, new ListItem("Seleccione", ""));

            //            ddlistGravedadAI.BorderColor = System.Drawing.Color.LightGray;
            //            ddlistTipoMonedaAI.BorderColor = System.Drawing.Color.LightGray;
            //            txtValorAI.BorderColor = System.Drawing.Color.LightGray;
            //            txtDescrInfraccionAI.BorderColor = System.Drawing.Color.LightGray;

            //            gvInfrAI.Visible = false;

            //            ddlistGravedadAI.BorderWidth = 1;
            //            ddlistTipoMonedaAI.BorderWidth = 1;
            //            txtValorAI.BorderWidth = 1;
            //            txtDescrInfraccionAI.BorderWidth = 1;
            //            btnGuardarAI.Text = "GUARDAR";
            //            break;
            //        case 2:
            //            lblInfoAdI.Visible = true;
            //            lblInfoAdI.Text = "Datos actualizados";
            //            lblInfoAdI.ForeColor = System.Drawing.Color.Gray;
            //            gvInfrAI.Visible = false;
            //            btnGuardarAI.Text = "GUARDAR";
            //            lblInfoAdI.ForeColor = System.Drawing.Color.Gray;
            //            ddlistGravedadAI.SelectedIndex = 0;
            //            ddlistTipoMonedaAI.SelectedIndex = 0;

            //            txtDescrInfraccionAI.Text = "";
            //            TxtID.Text = String.Empty;
            //            txtValorAI.Text = "";
            //            ddlistGravedadAI.Items.Insert(0, new ListItem("Seleccione", ""));

            //            ddlistGravedadAI.BorderColor = System.Drawing.Color.LightGray;
            //            ddlistTipoMonedaAI.BorderColor = System.Drawing.Color.LightGray;
            //            txtValorAI.BorderColor = System.Drawing.Color.LightGray;
            //            txtDescrInfraccionAI.BorderColor = System.Drawing.Color.LightGray;

            //            gvInfrAI.Visible = false;

            //            ddlistGravedadAI.BorderWidth = 1;
            //            ddlistTipoMonedaAI.BorderWidth = 1;
            //            txtValorAI.BorderWidth = 1;
            //            txtDescrInfraccionAI.BorderWidth = 1;
            //            btnGuardarAI.Text = "GUARDAR";
            //            break;
            //        default:
            //            lblInfoAdI.Visible = true;
            //            lblInfoAdI.Text = "Datos no guardados";
            //            lblInfoAdI.ForeColor = System.Drawing.Color.Red;
            //            break;

            //    }
            //    }
            //    catch (Exception)
            //    {
            //        lblInfoAdI.Visible = true;
            //        lblInfoAdI.Text = "Monto no valido";
            //        lblInfoAdI.ForeColor = System.Drawing.Color.Red;
            //    }
            //}




            lblInfoGF.Text = txtHoraIniGF.Text;
            lblInfoGF.ForeColor = System.Drawing.Color.Red;
            lblInfoGF.Visible = true;

           
        }

        protected void btnBuscarGF_Click(object sender, EventArgs e)
        {
            List<PERSONAL> buscar = NegocioAdministrador.instancia.buscarPersona(txtRutGF.Text);

            if (buscar.Count == 0)
            {
                lblInfoGF.Text = "El rut consultado no existe";
                lblInfoGF.Visible = true;
                lblInfoGF.ForeColor = System.Drawing.Color.Red;
                ddlistSectorGF.Items.Insert(0, new ListItem("Seleccionar", ""));
            
            }
            
            foreach (var list in buscar)
            {
                txtRutGF.Text = list.RUT_PER.ToString();
                txtNomGF.Text = list.NOMBRE_PER + " " + list.APPAT_PER;
                ddlistSectorGF.Enabled = true;
                txtFechaGF.Enabled = true;
                txtHoraIniGF.Enabled = true;
                txtHoraTermGF.Enabled = true;
                txtDetAdicGF.Enabled = true;

            }

        }

        protected void ddlistSectorGF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnBorrarGF_Click(object sender, EventArgs e)
        {
            txtRutGF.Text = "";
            txtNomGF.Text = "";
            ddlistSectorGF.SelectedIndex = 0;
            txtFechaGF.Text = "";
            txtHoraIniGF.Text = "";
            txtHoraTermGF.Text = "";
            txtDetAdicGF.Text = "";
        }

        protected void btnListarGF_Click(object sender, EventArgs e)
        {
            gvTurnos.DataSource = NegocioReporteria.Instancia.ListarTurnos();
            gvTurnos.DataBind();
        }

        protected void gvTurnos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvTurnos_DataBound(object sender, EventArgs e)
        {

        }

        protected void gvTurnos_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void gvTurnos_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void gvTurnos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //gvTurnos.PageIndex = e.NewPageIndex;
            //gvTurnos.DataSource = NegocioReporteria.Instancia.ListarTurnos();
            //gvTurnos.DataBind();
        }

       
    }
}
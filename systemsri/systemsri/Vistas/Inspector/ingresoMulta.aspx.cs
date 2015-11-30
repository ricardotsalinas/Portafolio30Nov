using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using ConexionDatos.Entity;
using System.Data;

namespace systemsri.Vistas.Inspector
{
    public partial class ingresoMulta : System.Web.UI.Page
    {
        public List<DETALLE_CARACTERISTICA> lts = new List<DETALLE_CARACTERISTICA>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"].Equals("") || Session["usuario"] == null ||
                !NegocioLoginUsuario.instancia.validaPagina(Session["usuario"].ToString(), 42))
            {
                Response.Redirect("../LoginUsuario/loginUsuario.aspx");

            }

           lts = NegocioAdministrador.instancia.listarMotivo();
           if (!Page.IsPostBack)
           {

               
                ddlistLugarInfIM.Items.Clear();
                ddlistLugarInfIM.DataSource = NegocioAdministrador.instancia.listarCalle();
                ddlistLugarInfIM.DataBind();
                
                ddlistMotivoIM.DataSource = NegocioAdministrador.instancia.listarMotivoddl();
                ddlistMotivoIM.DataTextField = "DETALLE_CAR";
                ddlistMotivoIM.DataValueField = "ID_DETCAR";
                ddlistMotivoIM.DataBind();
  
           }

           txtHoraMultaIM.Text = DateTime.Now.ToShortTimeString();
           txtFechaMultaIM.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        protected void bot_guardar_multa_Click(object sender, EventArgs e)
        {

        }

        protected void txtPatIM_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnGuardarIM_Click(object sender, EventArgs e)
        {

        }

        protected void ddlistMotivoIM_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //txtDetCompleto.Text = ddlistMotivoIM.SelectedItem.ToString();
            string val = ddlistMotivoIM.SelectedItem.Value;

          


            foreach (DETALLE_CARACTERISTICA d in lts)
            {
                if (val == d.ID_DETCAR.ToString())
                {
                    txtDetCompleto.Text = d.DETALLE_CAR;
                    break;
                }

            }
        }

        protected void txtHoraMultaIM_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtDetCompleto_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnmotivo_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnBuscarRut_Click(object sender, EventArgs e)
        {
            VEHICULO vh = NegocioInspector.instancia.buscarPatente(txtPatIM.Text);
            INFRACTOR inf = NegocioInspector.instancia.buscarInfractor(Convert.ToInt32(vh.ID_VEHICULO));
            txtRutIM.Text = inf.RUT_INFR;
            txtNomIM.Text = inf.NOMBRE_INFR;
            txtAppatIM.Text = inf.APPAT_INFR;
            txtApmatIM.Text = inf.APMAT_INFR;

        }

      
        protected void btnLimpiarIM_Click(object sender, EventArgs e)
        {
            
            txtPatIM.Text = "";
            txtDetCompleto.Text = "";
            txtDetalleAdicIM.Text = "";
           
        }

        protected void btnGuardarIM_Click1(object sender, EventArgs e)
        {

        }

        protected void txtFechaMultaIM_TextChanged(object sender, EventArgs e)
        {

        }

        
     
    }
}
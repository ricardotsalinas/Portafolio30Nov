using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using ConexionDatos.Entity;
using System.Data;
using System.Collections;

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
                ddlistLugarInfIM.Items.Insert(0, new ListItem("Seleccionar", ""));
                
                ddlistMotivoIM.DataSource = NegocioAdministrador.instancia.listarMotivoddl();
                ddlistMotivoIM.DataTextField = "DETALLE_CAR";
                ddlistMotivoIM.DataValueField = "ID_DETCAR";
                ddlistMotivoIM.DataBind();
                ddlistMotivoIM.Items.Insert(0, new ListItem("Seleccionar", ""));
  
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
            
            if (!String.IsNullOrEmpty(txtPatIM.Text))
            {
                ArrayList datos = new ArrayList();
                datos = NegocioInspector.instancia.datosRegistroCivil(txtPatIM.Text);
                if (!datos[0].ToString().Equals("error"))
                {
                    txtRutIM.Text = datos[0].ToString();
                    txtNomIM.Text = datos[1].ToString();
                    txtPatIM.Text = datos[2].ToString();
                    txtAppatIM.Text = datos[3].ToString();
                    txtApmatIM.Text = datos[4].ToString();
                    txtFechaNacimientoIM.Text = datos[5].ToString();
                }
                //error datos no encotrados
            }
            ///////// agregar un errro al momento de no tener nada escrito 


        }

      
        protected void btnLimpiarIM_Click(object sender, EventArgs e)
        {

            txtPatIM.Text = String.Empty;
            txtDetCompleto.Text = String.Empty;
            txtDetalleAdicIM.Text = String.Empty;
           
        }

        protected void btnGuardarIM_Click1(object sender, EventArgs e)
        {

        }

        protected void txtFechaMultaIM_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlistLugarInfIM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConexionDatos.Entity;
using Negocio;



namespace systemsri.Vistas.LoginUsuario
{
    public partial class loginInfractor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
                 Session.Abandon();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            if (NegocioLoginUsuario.instancia.sessionInfractor(rut_infr.Text, clave.Text))
            {
                Session["usuario"] = rut_infr.Text;
                Response.Redirect("../Infractor/datosInfractor.aspx");
            
            }
        }



        protected void clave_TextChanged(object sender, EventArgs e)
        {

        }

        protected void rut_infr_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
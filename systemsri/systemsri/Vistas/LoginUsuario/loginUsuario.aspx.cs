using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;


namespace systemsri.Vistas.LoginUsuario
{
    public partial class loginUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                Session.Abandon();

        }

        protected void btnEntrarLU_Click(object sender, EventArgs e)
        {
            String url = NegocioLoginUsuario.instancia.urlUsuario(txtRutLU.Text, txtPassLU.Text);
            Session["usuario"] = txtRutLU.Text;
                Response.Redirect(url);

        }

        protected void txtRutLU_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtPassLU_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
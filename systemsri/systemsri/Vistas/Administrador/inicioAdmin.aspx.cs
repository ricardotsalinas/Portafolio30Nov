using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace systemsri.Vistas.Administrador
{
    public partial class inicioAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"].Equals("") || Session["usuario"] == null ||
                !NegocioLoginUsuario.instancia.validaPagina(Session["usuario"].ToString(), 47))
            {
                Response.Redirect("../LoginUsuario/loginUsuario.aspx");

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
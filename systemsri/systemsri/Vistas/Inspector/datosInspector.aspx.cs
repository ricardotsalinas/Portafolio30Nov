using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace systemsri.Vistas.Inspector
{
    public partial class datosInspector : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"].Equals("") || Session["usuario"] == null ||
                !NegocioLoginUsuario.instancia.validaPagina(Session["usuario"].ToString(), 42))
            {
                Response.Redirect("../LoginUsuario/loginUsuario.aspx");

            }
        }

        protected void btnModificaPassDIn_Click(object sender, EventArgs e)
        {
            tblPassDIn.Style.Add("display", "yes");
        }
    }
}
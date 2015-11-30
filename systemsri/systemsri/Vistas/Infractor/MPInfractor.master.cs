using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace systemsri.Vistas.Infractor
{
    public partial class MPInfractor : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"].Equals("") || Session["usuario"]==null)
            {
                Response.Redirect("../LoginUsuario/loginInfractor.aspx");
            }
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace systemsri.Vistas.JefeTransito
{
    public partial class infoInfracciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"].Equals("") || Session["usuario"] == null ||
                !NegocioLoginUsuario.instancia.validaPagina(Session["usuario"].ToString(), 44))
            {
                Response.Redirect("../LoginUsuario/loginUsuario.aspx");
            }



            

           
        }

        protected void Button1_Click(object sender, System.EventArgs e)
        {


            ReportViewer1.LocalReport.Refresh();
    

        }

        protected void Fecha1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Fecha2_TextChanged(object sender, EventArgs e)
        {

        }




    }
}
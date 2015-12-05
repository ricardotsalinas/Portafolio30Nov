using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using ConexionDatos.Entity;

namespace systemsri.Vistas.JefeTransito
{
    public partial class ConfigRestriciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"].Equals("") || Session["usuario"] == null ||
                !NegocioLoginUsuario.instancia.validaPagina(Session["usuario"].ToString(), 44))
            {
                Response.Redirect("../LoginUsuario/loginUsuario.aspx");
            }
        }

        protected void btnGenerarRestrCR_Click(object sender, EventArgs e)
        {
            RESTRICCION restriccion = new RESTRICCION();


            restriccion.TIPO_GRAVE = Convert.ToInt32(txtGraveCR.Text);


            int idRestriccion = NegocioRestriccion.Instancia.InsertarRestriccion(restriccion);
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void calculo()
        {
            int intGravisima = 0;
            int intGrave = 0;
            int intLeve = 0;
            int Total = 0;

            int.TryParse(txtGravisimaCR.Text, out intGravisima);
            int.TryParse(txtGraveCR.Text, out intGrave);
            int.TryParse(txtLeveCR.Text, out intLeve);

            intGravisima = intGravisima * 3;
            intGrave = intGrave * 2;
            Total = intGravisima + intGrave + intLeve;

            lblPuntosLeve.Text = Total.ToString();

        }

        protected void txtGravisimaCR_TextChanged(object sender, EventArgs e)
        {
            calculo();
        }

        protected void txtGraveCR_TextChanged(object sender, EventArgs e)
        {
            calculo();
        }

        protected void txtLeveCR_TextChanged(object sender, EventArgs e)
        {
            calculo();
        }
    }
}
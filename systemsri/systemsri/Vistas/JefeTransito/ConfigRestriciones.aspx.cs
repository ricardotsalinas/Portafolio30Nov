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

            if (RadioButtonList1.SelectedValue.ToString().Equals("Temporal"))
            {
                restriccion.TIPO_PROHIBICION = 1144;
            }
            else if (RadioButtonList1.SelectedValue.ToString().Equals("Permanente"))
            {
                restriccion.TIPO_PROHIBICION = 1145;
            }

            restriccion.TIPO_GRAVISIMA = Convert.ToInt32(txtGravisimaCR.Text);
            restriccion.TIPO_GRAVE = Convert.ToInt32(txtGraveCR.Text);
            restriccion.TIPO_LEVE = Convert.ToInt32(txtLeveCR.Text);
            if (txtDiasTempCR.Text == null || txtDiasTempCR.Text == "")
            {
                restriccion.DIAS_PROH = 0;
            }
            else
            {
                restriccion.DIAS_PROH = Convert.ToInt32(txtDiasTempCR.Text);
            }


            int idRestriccion = NegocioRestriccion.Instancia.InsertarRestriccion(restriccion);
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (RadioButtonList1.SelectedIndex == 0)
                Panel1.Visible = true;
            else if (RadioButtonList1.SelectedIndex == 1)
                Panel1.Visible = false;
           
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

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
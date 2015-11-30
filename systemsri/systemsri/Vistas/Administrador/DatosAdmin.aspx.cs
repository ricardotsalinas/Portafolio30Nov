using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace systemsri.Vistas.Administrador
{
    public partial class DatosAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"].Equals("") || Session["usuario"] == null ||
                !NegocioLoginUsuario.instancia.validaPagina(Session["usuario"].ToString(), 47))
            {
                Response.Redirect("../LoginUsuario/loginUsuario.aspx");

            }
        }

        protected void btnGuardarDA_Click(object sender, EventArgs e)
        {
            if (txtCambiaPass1DA.Text.Equals(txtCambiaPass2DA.Text))
            {
                if (txtCambiaPass1DA.Text.Length > 3)
                {
                    int cambio = Negocio.NegocioAdministrador.instancia.ReiniciarClave(txtCambiaPass1DA.Text, Session["usuario"].ToString());
                    if (cambio == 1)
                    {
                        validar.Text = "La Contraseña ha sido cambiada exitosamente";
                        validar.ForeColor = System.Drawing.Color.LightGray;
                        validar.Visible = true;
                        Response.AddHeader("REFRESH", "1;URL=../LoginUsuario/loginUsuario.aspx");
                    }
                }
                else
                {
                    validar.Text = "La Contraseña es demasiado corta";
                    validar.ForeColor = System.Drawing.Color.Red;
                    validar.Visible = true;
                }
            }
            else
            {
                validar.Text = "Las Contraseñas no coinciden";
                validar.ForeColor = System.Drawing.Color.Red;
                validar.Visible = true;
            }
        }
    }
}
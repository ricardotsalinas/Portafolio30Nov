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

          
                if (txtCambiaPass1DA.Text.Length > 3 && txtCambiaPass2DA.Text.Length > 3)
                {
                    if (txtCambiaPass1DA.Text.Length < 25 && txtCambiaPass2DA.Text.Length < 25)
                    {

                        if (txtCambiaPass1DA.Text.Equals(txtCambiaPass2DA.Text))
                        {
                            int resultado = Negocio.NegocioAdministrador.instancia.ReiniciarClave(txtCambiaPass1DA.Text, Session["usuario"].ToString());
                            if (resultado == 1)
                            {
                               
                                lblInfoDA.ForeColor = System.Drawing.Color.Gray;
                                lblInfoDA.Visible = true;
                                lblInfoDA.Text = "La contraseña ha sido ingresada correctamente";
                                btnGuardarDA.Text = "MODIFICAR";
                                txtCambiaPass1DA.Text = String.Empty;
                                txtCambiaPass2DA.Text = String.Empty;
                                txtCambiaPass1DA.BorderColor = System.Drawing.Color.LightGray;
                                txtCambiaPass2DA.BorderColor = System.Drawing.Color.LightGray;
                                txtCambiaPass1DA.BorderWidth = 1;
                                txtCambiaPass2DA.BorderWidth = 1;



                            }
                        }
                        else
                        {
                            lblInfoDA.ForeColor = System.Drawing.Color.Red;
                            lblInfoDA.Visible = true;
                            lblInfoDA.Text = "Las contraseñas no coinciden";
                            txtCambiaPass1DA.BorderColor = System.Drawing.Color.Red;
                            txtCambiaPass2DA.BorderColor = System.Drawing.Color.Red;
                            txtCambiaPass1DA.BorderWidth = 1;
                            txtCambiaPass2DA.BorderWidth = 1;
                        }
                    }
                    else
                    {
                        lblInfoDA.ForeColor = System.Drawing.Color.Red;
                        lblInfoDA.Visible = true;
                        lblInfoDA.Text = "La Contraseña debe contener menos de 25 caracteres";
                        txtCambiaPass1DA.BorderColor = System.Drawing.Color.Red;
                        txtCambiaPass2DA.BorderColor = System.Drawing.Color.Red;
                        txtCambiaPass1DA.BorderWidth = 1;
                        txtCambiaPass2DA.BorderWidth = 1;
                    }
                }
                else
                {
                    lblInfoDA.ForeColor = System.Drawing.Color.Red;
                    lblInfoDA.Visible = true;
                    lblInfoDA.Text = "La contraseña debe contener al menos 4 caracteres";
                    txtCambiaPass1DA.BorderColor = System.Drawing.Color.Red;
                    txtCambiaPass2DA.BorderColor = System.Drawing.Color.Red;
                    txtCambiaPass1DA.BorderWidth = 1;
                    txtCambiaPass2DA.BorderWidth = 1;
                }

            



        }

        protected void txtCambiaPass1DA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
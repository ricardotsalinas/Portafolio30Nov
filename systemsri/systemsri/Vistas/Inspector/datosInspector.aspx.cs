using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using ConexionDatos.Dao;

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
            if (!Page.IsPostBack)
            {
                tblPassDIn.Visible = false;

                List<DatosPersonalesFuncionario> listaPersonal = new List<DatosPersonalesFuncionario>();
                listaPersonal = NegocioFuncionario.instancia.datosPersonales(Session["usuario"].ToString());

                if (listaPersonal.Count() > 0)
                {
                    foreach (var item in listaPersonal)
                    {
                        txtRutDIn.Text = item.RUT;
                        txtNomDIn.Text = item.NOMBRE;
                        txtDirDIn.Text = item.DIRECCION;
                        txtEmailDIn.Text = item.EMAIL;
                        txtTelefonoDIn.Text = item.TELEFONO;

                    }
                }
                else
                {


                }

            }
        }

        protected void btnModificaPassDIn_Click(object sender, EventArgs e)
        {
            if (tblPassDIn.Visible)
            {
                btnModificaPassDIn.Text = "MODIFICAR";
                this.tblPassDIn.Visible = false;
            }
            else
            {
                if (tblPassDIn.Visible == false)
                {
                    btnModificaPassDIn.Text = "NO MODIFICAR";
                    this.tblPassDIn.Visible = true;
                }
            }
            lblInfoDIn.Visible = false;
        }

        protected void btnGuardarDIn_Click(object sender, EventArgs e)
        {

            if (tblPassDIn.Visible)
            {
               if (txtCambiaPassDIn1.Text.Length > 3 && txtCambiaPassDIn2.Text.Length > 3)
                    {
                        if (txtCambiaPassDIn1.Text.Length < 25 && txtCambiaPassDIn2.Text.Length < 25)
                        {

                            if (txtCambiaPassDIn1.Text.Equals(txtCambiaPassDIn2.Text))
                            {
                                int resultado = NegocioInspector.instancia.actualizaClavePropia(txtCambiaPassDIn1.Text, txtRutDIn.Text);
                                if (resultado == 1)
                                {
                                    tblPassDIn.Visible = false;
                                    lblInfoDIn.ForeColor = System.Drawing.Color.Gray;
                                    lblInfoDIn.Visible = true;
                                    lblInfoDIn.Text = "La contraseña ha sido ingresada correctamente";
                                    btnModificaPassDIn.Text = "MODIFICAR";
                                    txtCambiaPassDIn1.Text = String.Empty;
                                    txtCambiaPassDIn2.Text = String.Empty;
                                    txtCambiaPassDIn1.BorderColor = System.Drawing.Color.LightGray;
                                    txtCambiaPassDIn2.BorderColor = System.Drawing.Color.LightGray;
                                    txtCambiaPassDIn1.BorderWidth = 1;
                                    txtCambiaPassDIn2.BorderWidth = 1;



                                }
                            }
                            else
                            {
                                lblInfoDIn.ForeColor = System.Drawing.Color.Red;
                                lblInfoDIn.Visible = true;
                                lblInfoDIn.Text = "Las contraseñas no coinciden";
                                txtCambiaPassDIn1.BorderColor = System.Drawing.Color.Red;
                                txtCambiaPassDIn2.BorderColor = System.Drawing.Color.Red;
                                txtCambiaPassDIn1.BorderWidth = 1;
                                txtCambiaPassDIn2.BorderWidth = 1;
                            }
                        }
                        else
                        {
                            lblInfoDIn.ForeColor = System.Drawing.Color.Red;
                            lblInfoDIn.Visible = true;
                            lblInfoDIn.Text = "La Contraseña debe contener menos de 25 caracteres";
                            txtCambiaPassDIn1.BorderColor = System.Drawing.Color.Red;
                            txtCambiaPassDIn2.BorderColor = System.Drawing.Color.Red;
                            txtCambiaPassDIn1.BorderWidth = 1;
                            txtCambiaPassDIn2.BorderWidth = 1;
                        }
                    }
                    else
                    {
                        lblInfoDIn.ForeColor = System.Drawing.Color.Red;
                        lblInfoDIn.Visible = true;
                        lblInfoDIn.Text = "La contraseña debe contener al menos 4 caracteres";
                        txtCambiaPassDIn1.BorderColor = System.Drawing.Color.Red;
                        txtCambiaPassDIn2.BorderColor = System.Drawing.Color.Red;
                        txtCambiaPassDIn1.BorderWidth = 1;
                        txtCambiaPassDIn2.BorderWidth = 1;
                    }

                }

            

            if (txtEmailDIn.Enabled || txtTelefonoDIn.Enabled)
            {
                int resul = NegocioFuncionario.instancia.actualizaDatosPersonales(txtEmailDIn.Text, txtTelefonoDIn.Text, txtRutDIn.Text);
                if (resul == 1)
                {

                    txtEmailDIn.Enabled = false;
                    txtTelefonoDIn.Enabled = false;
                    lblInfoDIn.Text = "Los datos han sido actualizados";
                    lblInfoDIn.ForeColor = System.Drawing.Color.Gray;
                    lblInfoDIn.Visible = true;
                }
                else
                {

                    lblInfoDIn.Visible = true;
                    lblInfoDIn.Text = "Ha habido un error al actualizar los datos";
                    lblInfoDIn.ForeColor = System.Drawing.Color.Red;
                    lblInfoDIn.Visible = true;


                }

            }
        }

        protected void ImageEmail_Click(object sender, ImageClickEventArgs e)
        {
            txtEmailDIn.Enabled = true;
        }

        protected void ImageTelefono_Click(object sender, ImageClickEventArgs e)
        {
            txtTelefonoDIn.Enabled = true;
        }
    }
}
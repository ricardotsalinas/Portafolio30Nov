using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using ClasesESpeciales;
using ConexionDatos.Dao;

namespace systemsri.Vistas.Funcionario
{
    public partial class datosFun : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"].Equals("") || Session["usuario"] == null)
            {
                Response.Redirect("../LoginUsuario/loginInfractor.aspx");
            }

            if (!Page.IsPostBack)
            {
                tblPassDF.Visible = false;

                List<DatosPersonalesFuncionario> listaPersonal = new List<DatosPersonalesFuncionario>();
                listaPersonal = NegocioFuncionario.instancia.datosPersonales(Session["usuario"].ToString());

                if (listaPersonal.Count() > 0)
                {
                    foreach (var item in listaPersonal)
                    {
                        txtRutDF.Text = item.RUT;
                        txtNomDF.Text = item.NOMBRE;
                        txtDirDF.Text = item.DIRECCION;
                        txtEmailDF.Text = item.EMAIL;
                        txtTelefonoDF.Text = item.TELEFONO;
                  
                    }
                }
                else
                {


                }

            }
        }

      
        protected void btnModificaPassDF_Click(object sender, EventArgs e)
        {
            if (tblPassDF.Visible)
            {
                btnModificaPassDF.Text = "MODIFICAR";
                this.tblPassDF.Visible = false;
            }
            else
            {
                if (tblPassDF.Visible == false)
                {
                    btnModificaPassDF.Text = "NO MODIFICAR";
                    this.tblPassDF.Visible = true;
                }

            }
        }

        protected void ImageEmail_Click(object sender, ImageClickEventArgs e)
        {
            txtEmailDF.Enabled = true;
        }

        protected void ImageTelefono_Click(object sender, ImageClickEventArgs e)
        {
            txtTelefonoDF.Enabled = true;
        }

        protected void btnGuardarDF_Click(object sender, EventArgs e)
        {

            if (tblPassDF.Visible)
            {
                if (txtCambiaPassDF1.Text.Length > 25 && txtCambiaPassDF2.Text.Length > 25)
                {
                    if (txtCambiaPassDF1.Text.Length > 3 && txtCambiaPassDF2.Text.Length > 3)
                    {
                        if (txtCambiaPassDF1.Text.Equals(txtCambiaPassDF2.Text))
                        {
                            int resultado = NegocioFuncionario.instancia.actualizaClavePropia(txtCambiaPassDF1.Text, txtRutDF.Text);
                            if (resultado == 1)
                            {
                                tblPassDF.Visible = false;
                                lblInfoDF.ForeColor = System.Drawing.Color.Gray;
                                lblInfoDF.Visible = true;
                                lblInfoDF.Text = "La contraseña ha sido ingresada correctamente";
                                btnModificaPassDF.Text = "MODIFICAR";
                                txtCambiaPassDF1.Text = String.Empty;
                                txtCambiaPassDF2.Text = String.Empty;
                                txtCambiaPassDF1.BorderColor = System.Drawing.Color.LightGray;
                                txtCambiaPassDF2.BorderColor = System.Drawing.Color.LightGray;
                                txtCambiaPassDF1.BorderWidth = 1;
                                txtCambiaPassDF2.BorderWidth = 1;



                            }
                        }
                        else
                        {
                            lblInfoDF.ForeColor = System.Drawing.Color.Red;
                            lblInfoDF.Visible = true;
                            lblInfoDF.Text = "Las contraseñas no coinciden";
                            txtCambiaPassDF1.BorderColor = System.Drawing.Color.Red;
                            txtCambiaPassDF2.BorderColor = System.Drawing.Color.Red;
                            txtCambiaPassDF1.BorderWidth = 1;
                            txtCambiaPassDF2.BorderWidth = 1;
                        }

                    }
                    else
                    {
                        lblInfoDF.ForeColor = System.Drawing.Color.Red;
                        lblInfoDF.Visible = true;
                        lblInfoDF.Text = "La contraseña es demasiado corta";
                        txtCambiaPassDF1.BorderColor = System.Drawing.Color.Red;
                        txtCambiaPassDF2.BorderColor = System.Drawing.Color.Red;
                        txtCambiaPassDF1.BorderWidth = 1;
                        txtCambiaPassDF2.BorderWidth = 1;
                    }
                }
                else
                {
                    lblInfoDF.ForeColor = System.Drawing.Color.Red;
                    lblInfoDF.Visible = true;
                    lblInfoDF.Text = "La contraseña es demasiado larga";
                    txtCambiaPassDF1.BorderColor = System.Drawing.Color.Red;
                    txtCambiaPassDF2.BorderColor = System.Drawing.Color.Red;
                    txtCambiaPassDF1.BorderWidth = 1;
                    txtCambiaPassDF2.BorderWidth = 1;
                }
            }

            if (txtEmailDF.Enabled || txtTelefonoDF.Enabled)
            {
                int resul = NegocioFuncionario.instancia.actualizaDatosPersonales(txtEmailDF.Text, txtTelefonoDF.Text, txtRutDF.Text);
                if (resul == 1)
                {

                    txtEmailDF.Enabled = false;
                    txtTelefonoDF.Enabled = false;
                    lblInfoDF.Text = "Los datos han sido actualizados";
                    lblInfoDF.ForeColor = System.Drawing.Color.Gray;
                }
                else
                {

                    lblInfoDF.Visible = true;
                    lblInfoDF.Text = "Ha habido un error al actualizar los datos";
                    lblInfoDF.ForeColor = System.Drawing.Color.Red;


                }

            }
        }
    }
}
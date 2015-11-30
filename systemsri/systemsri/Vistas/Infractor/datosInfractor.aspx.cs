using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClasesESpeciales;
using Negocio;
using ConexionDatos.Entity;

namespace systemsri.Vistas.Infractor
{
    public partial class datosInfractor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"].Equals("") || Session["usuario"] == null)
            {
                Response.Redirect("../LoginUsuario/loginInfractor.aspx");
            }

            if (!Page.IsPostBack)
            {
                tblPassDI.Visible = false;

                List<DatosPersonalesInfractor> listaPersonal = new List<DatosPersonalesInfractor>();
                listaPersonal = NegocioInfractor.instancia.datosPersonales(Session["usuario"].ToString());

                if (listaPersonal.Count() > 0)
                {
                    foreach (var item in listaPersonal)
                    {
                        txtRutDI.Text = item.RUT;
                        txtNomDI.Text = item.NOMBRE;
                        txtFNacDI.Text = Convert.ToDateTime(item.FECHA_NACIMIENTO).ToShortDateString();
                        txtDirDI.Text = item.DIRECCION;
                        txtEmailDI.Text = item.EMAIL;
                        txtTelefonoDI.Text = item.TELEFONO;
                        txtClaseLicDI.Text = item.LICENCIA;
                    }
                }
                else
                {


                }

            }
        }



        protected void btnModificaPassDI_Click(object sender, EventArgs e)
        {

            if (tblPassDI.Visible)
            {
                btnModificaPassDI.Text = "MODIFICAR";
                this.tblPassDI.Visible = false;
            }
            else
            {
                if (tblPassDI.Visible == false)
                {
                    btnModificaPassDI.Text = "NO MODIFICAR";
                    this.tblPassDI.Visible = true;
                }

            }
        }

        protected void btnGuardarDI_Click(object sender, EventArgs e)
        {

            if (tblPassDI.Visible)
            {
                if (txtCambiaPassDI1.Text.Length > 3 && txtCambiaPassDI2.Text.Length > 3)
                {
                    if (txtCambiaPassDI1.Text.Equals(txtCambiaPassDI2.Text))
                    {
                        int resultado = NegocioInfractor.instancia.actualizaClave(txtCambiaPassDI1.Text, txtRutDI.Text);
                        if (resultado == 1)
                        {
                            tblPassDI.Visible = false;
                            lblInfoDI.ForeColor = System.Drawing.Color.Gray;
                            lblInfoDI.Visible = true;
                            lblInfoDI.Text = "La contraseña ha sido ingresada correctamente";
                            btnModificaPassDI.Text = "MODIFICAR";
                            txtCambiaPassDI1.Text = String.Empty;
                            txtCambiaPassDI2.Text = String.Empty;
                            txtCambiaPassDI1.BorderColor = System.Drawing.Color.LightGray;
                            txtCambiaPassDI2.BorderColor = System.Drawing.Color.LightGray;
                            txtCambiaPassDI1.BorderWidth = 1;
                            txtCambiaPassDI2.BorderWidth = 1;



                        }
                    }
                    else
                    {
                        lblInfoDI.ForeColor = System.Drawing.Color.Red;
                        lblInfoDI.Visible = true;
                        lblInfoDI.Text = "Las contraseñas no coinciden";
                        txtCambiaPassDI1.BorderColor = System.Drawing.Color.Red;
                        txtCambiaPassDI2.BorderColor = System.Drawing.Color.Red;
                        txtCambiaPassDI1.BorderWidth = 1;
                        txtCambiaPassDI2.BorderWidth = 1;
                    }

                }
                else
                {
                    lblInfoDI.ForeColor = System.Drawing.Color.Red;
                    lblInfoDI.Visible = true;
                    lblInfoDI.Text = "La contraseña es demasiado corta";
                    txtCambiaPassDI1.BorderColor = System.Drawing.Color.Red;
                    txtCambiaPassDI2.BorderColor = System.Drawing.Color.Red;
                    txtCambiaPassDI1.BorderWidth=1;
                    txtCambiaPassDI1.BorderWidth = 1;
                }
            }



            if (txtEmailDI.Enabled || txtTelefonoDI.Enabled)
            {
                int resul = NegocioInfractor.instancia.actualizaDatosPersonales(txtEmailDI.Text, txtTelefonoDI.Text, txtRutDI.Text);
                if (resul == 1)
                {

                    txtEmailDI.Enabled = false;
                    txtTelefonoDI.Enabled = false;
                    lblInfoDI.Visible = true;
                    lblInfoDI.Text = "Los datos han sido actualizados";
                    lblInfoDI.ForeColor = System.Drawing.Color.LightGray;
                }
                else
                {

                    lblInfoDI.Visible = true;
                    lblInfoDI.Text = "Ha habido un error al actualizar los datos";
                    lblInfoDI.ForeColor = System.Drawing.Color.Red;


                }

            }



        }


        protected void ImageEmail_Click(object sender, ImageClickEventArgs e)
        {
            txtEmailDI.Enabled = true;
        }

        protected void ImageTelefono_Click(object sender, ImageClickEventArgs e)
        {
            txtTelefonoDI.Enabled = true;
        }
    }
}
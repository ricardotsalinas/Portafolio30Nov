using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using ConexionDatos.Dao;

namespace systemsri.Vistas.JefeTransito
{
    public partial class datosJefe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"].Equals("") || Session["usuario"] == null)
            {
                Response.Redirect("../LoginUsuario/loginInfractor.aspx");
            }

            if (!Page.IsPostBack)
            {
                tblPassDJ.Visible = false;

                List<DatosPersonalesFuncionario> listaPersonal = new List<DatosPersonalesFuncionario>();
                listaPersonal = NegocioFuncionario.instancia.datosPersonales(Session["usuario"].ToString());

                if (listaPersonal.Count() > 0)
                {
                    foreach (var item in listaPersonal)
                    {
                        txtRutDJ.Text = item.RUT;
                        txtNomDJ.Text = item.NOMBRE;
                        txtDirDJ.Text = item.DIRECCION;
                        txtEmailDJ.Text = item.EMAIL;
                        txtTelefonoDJ.Text = item.TELEFONO;

                    }
                }
                else
                {


                }

            }
        }

        protected void btnModificaPassDJ_Click(object sender, EventArgs e)
        {
           if (tblPassDJ.Visible)
            {
                btnModificaPassDJ.Text = "MODIFICAR";
                this.tblPassDJ.Visible = false;
            }
            else
            {
                if (tblPassDJ.Visible == false)
                {
                    btnModificaPassDJ.Text = "NO MODIFICAR";
                    this.tblPassDJ.Visible = true;
                }

            }



        }

        protected void btnGuardarDJ_Click(object sender, EventArgs e)
        {
             if (tblPassDJ.Visible)
            {
                if (txtCambiaPassDJ1.Text.Length > 3 && txtCambiaPassDJ2.Text.Length > 3)
                {
                    if (txtCambiaPassDJ1.Text.Equals(txtCambiaPassDJ2.Text))
                    {
                        int resultado = NegocioFuncionario.instancia.actualizaClavePropia(txtCambiaPassDJ1.Text, txtRutDJ.Text);
                        if (resultado == 1)
                        {
                            tblPassDJ.Visible = false;
                            lblInfoDJ.ForeColor = System.Drawing.Color.Gray;
                            lblInfoDJ.Visible = true;
                            lblInfoDJ.Text = "La contraseña ha sido ingresada correctamente";
                            btnModificaPassDJ.Text = "MODIFICAR";
                            txtCambiaPassDJ1.Text = String.Empty;
                            txtCambiaPassDJ2.Text = String.Empty;
                            txtCambiaPassDJ1.BorderColor = System.Drawing.Color.LightGray;
                            txtCambiaPassDJ2.BorderColor = System.Drawing.Color.LightGray;
                            txtCambiaPassDJ1.BorderWidth = 1;
                            txtCambiaPassDJ2.BorderWidth = 1;



                        }
                    }
                    else
                    {
                        lblInfoDJ.ForeColor = System.Drawing.Color.Red;
                        lblInfoDJ.Visible = true;
                        lblInfoDJ.Text = "Las contraseñas no coinciden";
                        txtCambiaPassDJ1.BorderColor = System.Drawing.Color.Red;
                        txtCambiaPassDJ2.BorderColor = System.Drawing.Color.Red;
                        txtCambiaPassDJ1.BorderWidth = 1;
                        txtCambiaPassDJ2.BorderWidth = 1;
                    }

                }
                else
                {
                    lblInfoDJ.ForeColor = System.Drawing.Color.Red;
                    lblInfoDJ.Visible = true;
                    lblInfoDJ.Text = "La contraseña es demasiado corta";
                    txtCambiaPassDJ1.BorderColor = System.Drawing.Color.Red;
                    txtCambiaPassDJ2.BorderColor = System.Drawing.Color.Red;
                    txtCambiaPassDJ1.BorderWidth = 1;
                    txtCambiaPassDJ2.BorderWidth = 1;
                }
            }



            if (txtEmailDJ.Enabled || txtTelefonoDJ.Enabled)
            {
                int resul = NegocioFuncionario.instancia.actualizaDatosPersonales(txtEmailDJ.Text, txtTelefonoDJ.Text, txtRutDJ.Text);
                if (resul == 1)
                {

                    txtEmailDJ.Enabled = false;
                    txtTelefonoDJ.Enabled = false;
                    lblInfoDJ.Text = "Los datos han sido actualizados";
                    lblInfoDJ.ForeColor = System.Drawing.Color.Gray;
                }
                else
                {

                    lblInfoDJ.Visible = true;
                    lblInfoDJ.Text = "Ha habido un error al actualizar los datos";
                    lblInfoDJ.ForeColor = System.Drawing.Color.Red;


                }

            }
        }

        protected void ImageEmail_Click(object sender, ImageClickEventArgs e)
        {
            txtEmailDJ.Enabled = true;
        }

        protected void imgTelefonoDJ_Click(object sender, ImageClickEventArgs e)
        {
            txtTelefonoDJ.Enabled = true;
        }
        }


    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConexionDatos.Entity;
using Negocio;
using ClasesESpeciales.Helper;

namespace systemsri.Vistas.Administrador
     // prar imprimir un alert para probar lo que devuelven las cosas 
     //Response.Write("<script language=javascript>alert('mensaje');</script>");
{

    public partial class adminUsuarios : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlistCategoria.Items.Clear();
                ddlistCategoria.DataSource = NegocioAdministrador.instancia.listar();
                ddlistCategoria.DataBind();
                ddlistCategoria.Items.Insert(0, new ListItem("Seleccionar", ""));
                chkActivoAU.Checked = true;
            }
        }



        protected void btnGuardarAU_Click(object sender, EventArgs e)
        {
            if (ValidaRut.instancia.VerificaRut(txtRutAU.Text))
            {
                if (NegocioAdministrador.instancia.existeRut(txtRutAU.Text))
                {
                    PERSONAL p = new PERSONAL();
                    p.RUT_PER = txtRutAU.Text;
                    p.NOMBRE_PER = txtNomAU.Text;
                    p.APPAT_PER = txtAppatAU.Text;
                    p.APMAT_PER = txtApmatAU.Text;
                    p.DIRECCION_PER = txtDireccion.Text;
                    p.TELEFONO_PER = txtTelefono.Text;
                    p.EMAIL_PER = txtEmail.Text;

                    if (chkActivoAU.Checked)
                        p.ACTIVO = "1";
                    else
                        p.ACTIVO = "0";

                    p.ID_TIPO_FUNCIONARIO = Convert.ToDecimal(ddlistCategoria.SelectedValue);

                    int newPersonal = NegocioAdministrador.instancia.CrearPersonal(p, 1);
                    if (newPersonal == 1)
                    {
                        txtRutAU.Text = "";
                        txtNomAU.Text = "";
                        txtAppatAU.Text = "";
                        txtApmatAU.Text = "";
                        txtDireccion.Text = "";
                        txtTelefono.Text = "";
                        txtEmail.Text = "";
                        chkActivoAU.Checked = true;
                        p.ID_TIPO_FUNCIONARIO = Convert.ToDecimal(ddlistCategoria.SelectedValue);
                        lblInfoAU.Text = "Los Datos han sido guardados exitosamente";


                    }
                    else
                        lblInfoAU.Text = "Los Datos no han sido guardados exitosamente";

                }
                else
                    lblInfoAU.Text = "El Usuario ya existe";
            }
            else
            {
                int n = 0;
                if (txtRutAU.Text == "" || txtRutAU.Text == null)
                {
                    txtRutAU.BorderColor = System.Drawing.Color.Red;
                    txtRutAU.BorderWidth = 1;
                    n = 1;
                }
                else
                {
                    txtRutAU.BorderColor = System.Drawing.Color.LightGray;
                    txtRutAU.BorderWidth = 1;
                    n = 0;
                }

                if (txtNomAU.Text == "" || txtNomAU.Text == null)
                {
                    txtNomAU.BorderColor = System.Drawing.Color.Red;
                    txtNomAU.BorderWidth = 1;
                    n = 1;
                }
                else
                {
                    txtNomAU.BorderColor = System.Drawing.Color.LightGray;
                    txtNomAU.BorderWidth = 1;
                    n = 0;
                }
                if (txtAppatAU.Text == "" || txtAppatAU.Text == null)
                {

                    txtAppatAU.BorderColor = System.Drawing.Color.Red;
                    txtAppatAU.BorderWidth = 1;
                    n = 1;
                }
                else
                {
                    txtAppatAU.BorderColor = System.Drawing.Color.LightGray;
                    txtAppatAU.BorderWidth = 1;
                    n = 0;
                }
                if (txtApmatAU.Text == "" || txtApmatAU.Text == null)
                {
                    txtApmatAU.BorderColor = System.Drawing.Color.Red;
                    txtApmatAU.BorderWidth = 1;
                    n = 1;
                }
                else
                {
                    txtApmatAU.BorderColor = System.Drawing.Color.LightGray;
                    txtApmatAU.BorderWidth = 1;
                    n = 0;
                }
                if (txtDireccion.Text == "" || txtDireccion.Text == null)
                {

                    txtDireccion.BorderColor = System.Drawing.Color.Red;
                    txtDireccion.BorderWidth = 1;
                    n = 1;
                }
                else
                {
                    txtDireccion.BorderColor = System.Drawing.Color.LightGray;
                    txtDireccion.BorderWidth = 1;
                    n = 0;
                }
                if (ddlistCategoria.SelectedIndex == 0)
                {

                    ddlistCategoria.BorderColor = System.Drawing.Color.Red;
                    n = 1;
                }
                else
                {
                    ddlistCategoria.BorderColor = System.Drawing.Color.LightGray;
                    ddlistCategoria.BorderWidth = 1;
                    n = 0;
                }

                if (n == 1)
                {
                    lblInfoAU.Visible = true;
                    lblInfoAU.Text = "Los campos en Rojo son obligatorios";
                    lblInfoAU.ForeColor = System.Drawing.Color.Red;


                }
            }

        }

        protected void btnBorrarAU_Click(object sender, EventArgs e)
        {
            lblInfoAU.Visible = false;
            reiniciarClave.Style.Add("display", "none");
            txtRutAU.Text = String.Empty;
            txtNomAU.Text = String.Empty;
            txtAppatAU.Text = String.Empty;
            txtApmatAU.Text = String.Empty;
            txtDireccion.Text = String.Empty;
            txtTelefono.Text = String.Empty;
            txtEmail.Text = String.Empty;
            chkActivoAU.Checked = true;
            btnGuardarAU.Visible = true;
            btnActualizarAU.Visible = false;
            ddlistCategoria.SelectedIndex = 0;


            txtRutAU.BorderColor = System.Drawing.Color.LightGray;
            txtNomAU.BorderColor = System.Drawing.Color.LightGray;
            txtAppatAU.BorderColor = System.Drawing.Color.LightGray;
            txtApmatAU.BorderColor = System.Drawing.Color.LightGray;
            txtDireccion.BorderColor = System.Drawing.Color.LightGray;
            txtTelefono.BorderColor = System.Drawing.Color.LightGray;
            txtEmail.BorderColor = System.Drawing.Color.LightGray;
            ddlistCategoria.BorderColor = System.Drawing.Color.LightGray;

            txtRutAU.BorderWidth = 1;
            txtNomAU.BorderWidth = 1;
            txtAppatAU.BorderWidth = 1;
            txtApmatAU.BorderWidth = 1;
            txtDireccion.BorderWidth = 1;
            txtTelefono.BorderWidth = 1;
            txtEmail.BorderWidth = 1;
            ddlistCategoria.BorderWidth = 1;

        }

        protected void btnBuscarAU_Click(object sender, EventArgs e)
        {


            List<PERSONAL> buscar = NegocioAdministrador.instancia.buscarPersona(txtRutAU.Text);

            lblInfoAU.Visible = false;

            if (txtRutAU.Text == "" || txtRutAU.Text == null)
            {
                lblInfoAU.Visible = true;
                lblInfoAU.ForeColor = System.Drawing.Color.Red;
                lblInfoAU.Text = "Debe introducir el rut para la búsqueda";
                txtRutAU.BorderColor = System.Drawing.Color.Red;
                txtRutAU.BorderWidth = 1;
            }
            else
            {
                if (buscar.Count == 0)
                {
                    txtRutAU.Text = "";
                    txtNomAU.Text = "";
                    txtAppatAU.Text = "";
                    txtApmatAU.Text = "";
                    txtDireccion.Text = "";
                    txtTelefono.Text = "";
                    txtEmail.Text = "";
                    ddlistCategoria.SelectedIndex = 0;
                }
                else
                    if (buscar.Count > 0)
                    {
                        reiniciarClave.Style.Add("display", "yes");
                        btnActualizarAU.Visible = true;
                        btnGuardarAU.Visible = false;

                    }

                foreach (var list in buscar)
                {
                    txtRutAU.Text = list.RUT_PER.ToString();
                    txtNomAU.Text = list.NOMBRE_PER;
                    txtAppatAU.Text = list.APPAT_PER;
                    txtApmatAU.Text = list.APMAT_PER;
                    txtDireccion.Text = list.DIRECCION_PER;
                    txtTelefono.Text = list.TELEFONO_PER;
                    txtEmail.Text = list.EMAIL_PER;
                    if (list.ACTIVO == "1")
                        chkActivoAU.Checked = true;
                    else
                        chkActivoAU.Checked = false;

                    ddlistCategoria.SelectedValue = list.ID_TIPO_FUNCIONARIO.ToString();
                    txtRutAU.BorderColor = System.Drawing.Color.LightGray;
                    txtNomAU.BorderColor = System.Drawing.Color.LightGray;
                    txtAppatAU.BorderColor = System.Drawing.Color.LightGray;
                    txtApmatAU.BorderColor = System.Drawing.Color.LightGray;
                    txtDireccion.BorderColor = System.Drawing.Color.LightGray;
                    txtTelefono.BorderColor = System.Drawing.Color.LightGray;
                    txtEmail.BorderColor = System.Drawing.Color.LightGray;
                    ddlistCategoria.BorderColor = System.Drawing.Color.LightGray;
                    txtRutAU.BorderWidth = 1;
                    txtNomAU.BorderWidth = 1;
                    txtAppatAU.BorderWidth = 1;
                    txtApmatAU.BorderWidth = 1;
                    txtDireccion.BorderWidth = 1;
                    txtTelefono.BorderWidth = 1;
                    txtEmail.BorderWidth = 1;
                    ddlistCategoria.BorderWidth = 1;


                }
            }
        }

        protected void btnPassAU_Click1(object sender, EventArgs e)
        {
            String rut = txtRutAU.Text;
            if (!NegocioAdministrador.instancia.existeRut(txtRutAU.Text))
            {
                int Actualizar = NegocioAdministrador.instancia.ReiniciarClave(rut.Substring(0, 5), txtRutAU.Text);
                if (Actualizar == 1)
                {
                    lblInfoAU.Visible = true;
                    lblInfoAU.Text = "La clave ha sido reiniciada";
                    lblInfoAU.ForeColor = System.Drawing.Color.Gray;
                }
                else
                {
                    lblInfoAU.Visible = true;
                    lblInfoAU.Text = "La clave No ha sido reiniciada";
                    lblInfoAU.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                lblInfoAU.Visible = true;
                lblInfoAU.Text = "El Rut no es Válido";
                lblInfoAU.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void chkActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void ddlistCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnActualizarAU_Click(object sender, EventArgs e)
        {
            if (ValidaRut.instancia.VerificaRut(txtRutAU.Text))
            {

                bool dv = false;
                PERSONAL p = new PERSONAL();
                p.RUT_PER = txtRutAU.Text;
                p.NOMBRE_PER = txtNomAU.Text;
                p.APPAT_PER = txtAppatAU.Text;
                p.APMAT_PER = txtApmatAU.Text;
                p.DIRECCION_PER = txtDireccion.Text;
                p.TELEFONO_PER = txtTelefono.Text;
                p.EMAIL_PER = txtEmail.Text;
                p.ID_TIPO_FUNCIONARIO = Convert.ToDecimal(ddlistCategoria.SelectedValue);

                if (chkActivoAU.Checked)
                    p.ACTIVO = "1";
                else
                    p.ACTIVO = "0";


                txtRutAU.BorderColor = System.Drawing.Color.LightGray;
                txtNomAU.BorderColor = System.Drawing.Color.LightGray;
                txtAppatAU.BorderColor = System.Drawing.Color.LightGray;
                txtApmatAU.BorderColor = System.Drawing.Color.LightGray;
                txtDireccion.BorderColor = System.Drawing.Color.LightGray;
                txtTelefono.BorderColor = System.Drawing.Color.LightGray;
                txtEmail.BorderColor = System.Drawing.Color.LightGray;
                ddlistCategoria.BorderColor = System.Drawing.Color.LightGray;
                txtRutAU.BorderWidth = 1;
                txtNomAU.BorderWidth = 1;
                txtAppatAU.BorderWidth = 1;
                txtApmatAU.BorderWidth = 1;
                txtDireccion.BorderWidth = 1;
                txtTelefono.BorderWidth = 1;
                txtEmail.BorderWidth = 1;
                ddlistCategoria.BorderWidth = 1;
                if (chkActivoAU.Checked)
                {
                    dv = true;
                }

                p.ACTIVO = dv.ToString();
                lblInfoAU.Visible = true;
                lblInfoAU.Text = "1111111111111111";
                lblInfoAU.ForeColor = System.Drawing.Color.Red;


                if (ddlistCategoria.SelectedIndex == 0)
                {
                    ddlistCategoria.BorderColor = System.Drawing.Color.Red;
                    lblInfoAU.Visible = true;
                }
                else
                {
                    p.ID_TIPO_FUNCIONARIO = Convert.ToDecimal(ddlistCategoria.SelectedValue);
                    ddlistCategoria.BorderColor = System.Drawing.Color.LightGray;
                    ddlistCategoria.BorderWidth = 1;
                    lblInfoAU.Visible = true;
                    lblInfoAU.Text = "Los campos en rojo son obligatorios";
                    lblInfoAU.ForeColor = System.Drawing.Color.Red;

                }

                int newPersonal = NegocioAdministrador.instancia.CrearPersonal(p, 2);
                if (newPersonal == 2)
                {
                    txtRutAU.Text = "";
                    txtNomAU.Text = "";
                    txtAppatAU.Text = "";
                    txtApmatAU.Text = "";
                    txtDireccion.Text = "";
                    txtTelefono.Text = "";
                    txtEmail.Text = "";
                    ddlistCategoria.SelectedIndex = 0;
                    chkActivoAU.Checked = true;
                    lblInfoAU.Text = "Los datos han sido guardados correctamente";
                }
                else
                {
                    int n = 0;
                    if (txtRutAU.Text == "" || txtRutAU.Text == null)
                    {
                        txtRutAU.BorderColor = System.Drawing.Color.Red;
                        n = 1;
                    }
                    else
                    {
                        txtRutAU.BorderColor = System.Drawing.Color.LightGray;
                        txtRutAU.BorderWidth = 1;
                        n = 0;
                    }

                    if (txtNomAU.Text == "" || txtNomAU.Text == null)
                    {
                        txtNomAU.BorderColor = System.Drawing.Color.Red;
                        n = 1;
                    }
                    else
                    {
                        txtNomAU.BorderColor = System.Drawing.Color.LightGray;
                        txtNomAU.BorderWidth = 1;
                        n = 0;
                    }
                    if (txtAppatAU.Text == "" || txtAppatAU.Text == null)
                    {

                        txtAppatAU.BorderColor = System.Drawing.Color.Red;
                        n = 1;
                    }
                    else
                    {
                        txtAppatAU.BorderColor = System.Drawing.Color.LightGray;
                        txtAppatAU.BorderWidth = 1;
                        n = 0;
                    }
                    if (txtApmatAU.Text == "" || txtApmatAU.Text == null)
                    {
                        txtApmatAU.BorderColor = System.Drawing.Color.Red;
                        n = 1;
                    }
                    else
                    {
                        txtApmatAU.BorderColor = System.Drawing.Color.LightGray;
                        txtApmatAU.BorderWidth = 1;
                        n = 0;
                    }
                    if (txtDireccion.Text == "" || txtDireccion.Text == null)
                    {

                        txtDireccion.BorderColor = System.Drawing.Color.Red;
                        n = 1;
                    }
                    else
                    {
                        txtDireccion.BorderColor = System.Drawing.Color.LightGray;
                        txtDireccion.BorderWidth = 1;
                        n = 0;
                    }
                    if (ddlistCategoria.SelectedIndex == 0)
                    {

                        ddlistCategoria.BorderColor = System.Drawing.Color.Red;
                        n = 1;
                    }
                    else
                    {
                        ddlistCategoria.BorderColor = System.Drawing.Color.LightGray;
                        ddlistCategoria.BorderWidth = 1;
                        n = 0;
                    }

                    if (n == 1)
                    {
                        lblInfoAU.Visible = true;
                        lblInfoAU.Text = "Los campos en Rojo son obligatorios";
                    }
                }
            }
            else { }
        }

        }

}
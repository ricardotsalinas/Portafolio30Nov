﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConexionDatos.Entity;
using Negocio;
using ClasesESpeciales.Helper;
using System.Collections.Specialized;
using System.Drawing;

namespace systemsri.Vistas.Funcionario
{
    public partial class admFun : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"].Equals("") || Session["usuario"] == null ||
              !NegocioLoginUsuario.instancia.validaPagina(Session["usuario"].ToString(), 43))
            {
                Response.Redirect("../LoginUsuario/loginUsuario.aspx");

            }
            if (!Page.IsPostBack)
            {
                txtRutAF.Enabled = true;
                txtEmailAF.Enabled = true;
                txtFonoAF.Enabled = true;
                chkActivoAF.Enabled = true;
            
            
            }
        }

        protected void btnGuardarAF_Click(object sender, EventArgs e)
        {
            lblInfoAF.Visible = false;
            if (ValidaRut.instancia.VerificaRut(txtRutAF.Text))
            {
                if (NegocioInfractor.instancia.existeRut(txtRutAF.Text))
                {
                    INFRACTOR p = new INFRACTOR();
                    p.RUT_INFR = txtRutAF.Text;
                    p.NOMBRE_INFR = txtNomAF.Text;
                    p.APPAT_INFR = txtAppatAF.Text;
                    p.APMAT_INFR = txtApmatAF.Text;
                    p.DIRECCION_INFR = txtDirAF.Text;
                    p.TELEFONO_INFR = txtFonoAF.Text;
                    p.EMAIL_INFR = txtEmailAF.Text;
                    if (chkActivoAF.Checked)
                        p.ACTIVO = "1";
                    else
                        p.ACTIVO = "0";


                    int newPersonal = NegocioFuncionario.instancia.CrearFuncionario(p, 1);
                    if (newPersonal == 1)
                    {
                        txtRutAF.Text = "";
                        txtNomAF.Text = "";
                        txtAppatAF.Text = "";
                        txtApmatAF.Text = "";
                        txtDirAF.Text = "";
                        txtFonoAF.Text = "";
                        txtEmailAF.Text = "";
                        chkActivoAF.Checked = true;
                        lblInfoAF.Text = "Los Datos han sido guardados exitosamente";
                        lblInfoAF.Visible = true;
                        lblInfoAF.ForeColor = System.Drawing.Color.Gray;


                    }
                    else

                        lblInfoAF.Text = "Los Datos no han sido guardados";
                    lblInfoAF.Visible = true;
                    lblInfoAF.ForeColor = System.Drawing.Color.Red;

                }
                else
                    lblInfoAF.Text = "El Usuario ya existe";
            }
            else
            {
                int n = 0;
                if (txtRutAF.Text == "" || txtRutAF.Text == null)
                {
                    txtRutAF.BorderColor = System.Drawing.Color.Red;
                    txtRutAF.BorderWidth = 1;
                    n = 1;
                }
                else
                {
                    txtRutAF.BorderColor = System.Drawing.Color.LightGray;
                    txtRutAF.BorderWidth = 1;
                    n = 0;
                }

                if (txtNomAF.Text == "" || txtNomAF.Text == null)
                {
                    txtNomAF.BorderColor = System.Drawing.Color.Red;
                    txtNomAF.BorderWidth = 1;
                    n = 1;
                }
                else
                {
                    txtNomAF.BorderColor = System.Drawing.Color.LightGray;
                    txtNomAF.BorderWidth = 1;
                    n = 0;
                }
                if (txtAppatAF.Text == "" || txtAppatAF.Text == null)
                {

                    txtAppatAF.BorderColor = System.Drawing.Color.Red;
                    txtAppatAF.BorderWidth = 1;
                    n = 1;
                }
                else
                {
                    txtAppatAF.BorderColor = System.Drawing.Color.LightGray;
                    txtAppatAF.BorderWidth = 1;
                    n = 0;
                }
                if (txtApmatAF.Text == "" || txtApmatAF.Text == null)
                {
                    txtApmatAF.BorderColor = System.Drawing.Color.Red;
                    txtApmatAF.BorderWidth = 1;
                    n = 1;
                }
                else
                {
                    txtApmatAF.BorderColor = System.Drawing.Color.LightGray;
                    txtApmatAF.BorderWidth = 1;
                    n = 0;
                }
                if (txtDirAF.Text == "" || txtDirAF.Text == null)
                {

                    txtDirAF.BorderColor = System.Drawing.Color.Red;
                    txtDirAF.BorderWidth = 1;
                    n = 1;
                }
                else
                {
                    txtDirAF.BorderColor = System.Drawing.Color.LightGray;
                    txtDirAF.BorderWidth = 1;
                    n = 0;
                }


                if (n == 1)
                {
                    lblInfoAF.Visible = true;
                    lblInfoAF.Text = "No se pueden guardar datos sin agregar el Rut";
                    lblInfoAF.ForeColor = System.Drawing.Color.Red;
                }
            }





        }

        protected void btnBuscarAF_Click(object sender, EventArgs e)
        {
            List<INFRACTOR> buscar = NegocioInfractor.instancia.buscarPersona(txtRutAF.Text); 


            lblInfoAF.Visible = false;

            if (txtRutAF.Text == "" || txtRutAF.Text == null)
            {
                lblInfoAF.Visible = true;
                lblInfoAF.ForeColor = System.Drawing.Color.Red;
                lblInfoAF.Text = "Debe introducir el rut para la búsqueda";
                txtRutAF.BorderColor = System.Drawing.Color.Red;
                txtRutAF.BorderWidth = 1;
                txtRutAF.Enabled = true;
                gvMultas.Visible = false;
            }
            else
            {
                if (buscar.Count == 0)
                {
                    lblInfoAF.Visible = true;
                    lblInfoAF.Text = "El rut consultado no existe o se encuentra mal escrito";
                    lblInfoAF.ForeColor = System.Drawing.Color.Red;
                    txtRutAF.Text = "";
                    txtNomAF.Text = "";
                    txtAppatAF.Text = "";
                    txtApmatAF.Text = "";
                    txtDirAF.Text = "";
                    txtEmailAF.Text = "";
                    txtFonoAF.Text = "";
                    txtRutAF.Enabled = true;
                    gvMultas.Visible = false;

                }
                else
                    if (buscar.Count > 0)
                    {
                        btnPassAF.Style.Add("display", "yes");
                        btnGuardarAF.Text = "ACTUALIZAR";
                        btnRevMultasAF.Visible = true;
                        txtEmailAF.Enabled = true;
                        txtFonoAF.Enabled = true;
                        btnPassAF.Visible = true;
                        chkActivoAF.Visible = true;
                        btnGuardarAF.Visible = true;
                        btnLimpiarAF.Visible= true;
                        txtRutAF.Enabled = true;
                        txtEmailAF.Enabled = true;
                        txtFonoAF.Enabled = true;
                        chkActivoAF.Enabled = true;
                        gvMultas.Visible = false;
                    }

                foreach (var list in buscar)
                {
                    txtRutAF.Text = list.RUT_INFR.ToString();
                    txtNomAF.Text = list.NOMBRE_INFR;
                    txtAppatAF.Text = list.APPAT_INFR;
                    txtApmatAF.Text = list.APMAT_INFR;
                    txtDirAF.Text = list.DIRECCION_INFR;
                    txtFonoAF.Text = list.TELEFONO_INFR;
                    txtEmailAF.Text = list.EMAIL_INFR;
                    if (list.ACTIVO == "1")
                        chkActivoAF.Checked = true;
                    else
                        chkActivoAF.Checked = false;

                    txtRutAF.BorderColor = System.Drawing.Color.LightGray;
                    txtNomAF.BorderColor = System.Drawing.Color.LightGray;
                    txtAppatAF.BorderColor = System.Drawing.Color.LightGray;
                    txtApmatAF.BorderColor = System.Drawing.Color.LightGray;
                    txtDirAF.BorderColor = System.Drawing.Color.LightGray;
                    txtFonoAF.BorderColor = System.Drawing.Color.LightGray;
                    txtEmailAF.BorderColor = System.Drawing.Color.LightGray;
                    txtRutAF.BorderWidth = 1;
                    txtNomAF.BorderWidth = 1;
                    txtAppatAF.BorderWidth = 1;
                    txtApmatAF.BorderWidth = 1;
                    txtDirAF.BorderWidth = 1;
                    txtFonoAF.BorderWidth = 1;
                    txtEmailAF.BorderWidth = 1;
                    gvMultas.Visible = false;


                }
            }
        }


        protected void btnPassAF_Click(object sender, EventArgs e)
        {
            String rut = txtRutAF.Text;
            if (!NegocioFuncionario.instancia.existeRut(txtRutAF.Text))
            {
                int Actualizar = NegocioFuncionario.instancia.ReiniciarClave(rut.Substring(0, 5), txtRutAF.Text);
                if (Actualizar == 1)
                {
                    lblInfoAF.Visible = true;
                    lblInfoAF.Text = "La clave ha sido reiniciada";
                    lblInfoAF.ForeColor = System.Drawing.Color.Gray;
                }
                else
                {
                    lblInfoAF.Visible = true;
                    lblInfoAF.Text = "La clave No ha sido reiniciada";
                    lblInfoAF.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                lblInfoAF.Visible = true;
                lblInfoAF.Text = "El Rut no es Válido";
                lblInfoAF.ForeColor = System.Drawing.Color.Red;
            }
        }



        protected void btnLimpiarAF_Click(object sender, EventArgs e)
        {
            lblInfoAF.Visible = false;
            btnRevMultasAF.Visible = true;
            btnPassAF.Style.Add("display", "none");
            txtRutAF.Text = String.Empty;
            txtNomAF.Text = String.Empty;
            txtAppatAF.Text = String.Empty;
            txtApmatAF.Text = String.Empty;
            txtDirAF.Text = String.Empty;
            txtFonoAF.Text = String.Empty;
            txtEmailAF.Text = String.Empty;
            chkActivoAF.Checked = true;
            btnGuardarAF.Visible = true;




            txtRutAF.BorderColor = System.Drawing.Color.LightGray;
            txtNomAF.BorderColor = System.Drawing.Color.LightGray;
            txtAppatAF.BorderColor = System.Drawing.Color.LightGray;
            txtApmatAF.BorderColor = System.Drawing.Color.LightGray;
            txtDirAF.BorderColor = System.Drawing.Color.LightGray;
            txtFonoAF.BorderColor = System.Drawing.Color.LightGray;
            txtEmailAF.BorderColor = System.Drawing.Color.LightGray;


            txtRutAF.BorderWidth = 1;
            txtNomAF.BorderWidth = 1;
            txtAppatAF.BorderWidth = 1;
            txtApmatAF.BorderWidth = 1;
            txtDirAF.BorderWidth = 1;
            txtFonoAF.BorderWidth = 1;
            txtEmailAF.BorderWidth = 1;


        }

        protected void btnRevMultasAF_Click(object sender, EventArgs e)
        {
            gvMultas.DataSource = NegocioReporteria.Instancia.ListarMulta(txtRutAF.Text);
            gvMultas.DataBind();
            gvMultas.Visible = true;




        }

        protected void gvMultas_DataBound(object sender, EventArgs e)
        {

        }

        protected void gvMultas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvMultas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "BotonGV")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                NameValueCollection data = new NameValueCollection();
                GridViewRow row = gvMultas.Rows[index];
                int pagarMUlta = NegocioInfractor.instancia.pagarMulta(Convert.ToInt32(row.Cells[0].Text));
                lblPagoExitosoAF.Text = "La multa codigo "+row.Cells[0].Text+" ha sido exitosamente pagada";
                lblPagoExitosoAF.Visible = true;
                lblPagoExitosoAF.ForeColor = System.Drawing.Color.Gray;
                btnDeshPagoaF.Visible = true;
                gvMultas.Visible = false;
                lblNumMulta.Text = row.Cells[0].Text;
                btnOKAF.Visible = true;
                
            }
        }

        protected void gvMultas_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (e.Row.Cells[6].Text == "0")
                {
                    e.Row.Cells[6].Text = "SI";
                }
                else
                {
                    e.Row.Cells[6].Text = "NO";

                }
                if (e.Row.Cells[7].Text == "0")
                {
                    e.Row.Cells[7].Text = "NO PAGADA";
                    e.Row.Cells[7].ForeColor = Color.Red;
                }
                else
                {
                    e.Row.Cells[7].Text = "PAGADA";
                }
                if (e.Row.Cells[8].Text == "0")
                {
                    e.Row.Cells[8].Text = "NO ENTREGADA";
                    e.Row.Cells[8].ForeColor = Color.Red;
                }
                else
                {
                    e.Row.Cells[8].Text = "ENTREGADA";
                }
                if (e.Row.Cells[7].Text == "PAGADA")
                {
                    e.Row.Cells[9].Visible = false;

                }
                else
                {
                    e.Row.Cells[9].Visible = true; ;
                }




            }

        }

        protected void btnDeshPagoaF_Click(object sender, EventArgs e)
        {
            int DeshpagarMUlta = NegocioInfractor.instancia.deshacerPagarMulta(Convert.ToInt32(lblNumMulta.Text));
            lblInfoAF.Text = "La deuda ha quedado como impaga nuevamente";
            lblInfoAF.ForeColor=System.Drawing.Color.Gray;
            lblInfoAF.Visible = true;
            btnDeshPagoaF.Visible = false;
            lblNumMulta.Visible = false;
            lblPagoExitosoAF.Visible = false;

            btnRevMultasAF.Visible = true;
            btnPassAF.Style.Add("display", "none");
            txtRutAF.Text = String.Empty;
            txtNomAF.Text = String.Empty;
            txtAppatAF.Text = String.Empty;
            txtApmatAF.Text = String.Empty;
            txtDirAF.Text = String.Empty;
            txtFonoAF.Text = String.Empty;
            txtEmailAF.Text = String.Empty;
            chkActivoAF.Checked = true;
            btnGuardarAF.Visible = true;
            
            txtRutAF.BorderColor = System.Drawing.Color.LightGray;
            txtNomAF.BorderColor = System.Drawing.Color.LightGray;
            txtAppatAF.BorderColor = System.Drawing.Color.LightGray;
            txtApmatAF.BorderColor = System.Drawing.Color.LightGray;
            txtDirAF.BorderColor = System.Drawing.Color.LightGray;
            txtFonoAF.BorderColor = System.Drawing.Color.LightGray;
            txtEmailAF.BorderColor = System.Drawing.Color.LightGray;


            txtRutAF.BorderWidth = 1;
            txtNomAF.BorderWidth = 1;
            txtAppatAF.BorderWidth = 1;
            txtApmatAF.BorderWidth = 1;
            txtDirAF.BorderWidth = 1;
            txtFonoAF.BorderWidth = 1;
            txtEmailAF.BorderWidth = 1;

            txtRutAF.Enabled= true;
            txtEmailAF.Enabled = false;
            txtFonoAF.Enabled = false;
            chkActivoAF.Enabled = false;
            btnOKAF.Visible = false;

            btnGuardarAF.Visible = false;
            btnLimpiarAF.Visible = false;
            btnRevMultasAF.Visible = false;

        }

        protected void btnOKAF_Click(object sender, EventArgs e)
        {
            lblInfoAF.Visible = false;
            btnRevMultasAF.Visible = true;
            btnPassAF.Style.Add("display", "none");
            txtRutAF.Text = String.Empty;
            txtNomAF.Text = String.Empty;
            txtAppatAF.Text = String.Empty;
            txtApmatAF.Text = String.Empty;
            txtDirAF.Text = String.Empty;
            txtFonoAF.Text = String.Empty;
            txtEmailAF.Text = String.Empty;
            chkActivoAF.Checked = true;
            btnGuardarAF.Visible = true;
            btnDeshPagoaF.Visible = false;
            lblPagoExitosoAF.Visible = false;
            lblNumMulta.Visible = false;

            txtRutAF.BorderColor = System.Drawing.Color.LightGray;
            txtNomAF.BorderColor = System.Drawing.Color.LightGray;
            txtAppatAF.BorderColor = System.Drawing.Color.LightGray;
            txtApmatAF.BorderColor = System.Drawing.Color.LightGray;
            txtDirAF.BorderColor = System.Drawing.Color.LightGray;
            txtFonoAF.BorderColor = System.Drawing.Color.LightGray;
            txtEmailAF.BorderColor = System.Drawing.Color.LightGray;


            txtRutAF.BorderWidth = 1;
            txtNomAF.BorderWidth = 1;
            txtAppatAF.BorderWidth = 1;
            txtApmatAF.BorderWidth = 1;
            txtDirAF.BorderWidth = 1;
            txtFonoAF.BorderWidth = 1;
            txtEmailAF.BorderWidth = 1;

            txtRutAF.Enabled = true;
            txtEmailAF.Enabled = true;
            txtFonoAF.Enabled = true;
            chkActivoAF.Enabled = true;

            btnOKAF.Visible = false;
            btnGuardarAF.Visible = false;
            btnLimpiarAF.Visible = false;
            btnRevMultasAF.Visible = false;
        }

       

        
    }
}
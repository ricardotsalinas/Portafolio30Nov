﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using ConexionDatos.Entity;
using ClasesESpeciales;

namespace systemsri.Vistas.Administrador
{
    public partial class adminCalles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"].Equals("") || Session["usuario"] == null ||
     !NegocioLoginUsuario.instancia.validaPagina(Session["usuario"].ToString(), 47))
            {
                Response.Redirect("../LoginUsuario/loginUsuario.aspx");

            }
            if (!Page.IsPostBack)
            {
                ddlistNumPistas.Items.Insert(0, new ListItem("Seleccionar", ""));
                ddlistOrient.DataSource = NegocioAdministrador.instancia.listarOrientacion();
                ddlistOrient.DataBind();
                ddlistOrient.Items.Insert(0, new ListItem("Seleccionar", ""));
                ddlistVelMax.DataSource = NegocioAdministrador.instancia.listarVelocidad();
                ddlistVelMax.DataBind();
                ddlistVelMax.Items.Insert(0, new ListItem("Seleccionar", ""));
                ddlistSentido.DataSource = NegocioAdministrador.instancia.listarSentido();
                ddlistSentido.DataBind();
                ddlistSentido.Items.Insert(0, new ListItem("Seleccionar", ""));
                ddlistSector.DataSource = NegocioAdministrador.instancia.listarSector();
                ddlistSector.DataBind();
                ddlistSector.Items.Insert(0, new ListItem("Seleccionar", ""));
                chkActivoACa.Checked = true;
                ddlistTipoCalle.DataSource = NegocioAdministrador.instancia.listarTipoCalle();
                ddlistTipoCalle.DataBind();
                ddlistTipoCalle.Items.Insert(0, new ListItem("Seleccionar", ""));
                chkActivoACa.Checked = true;
            }
        }



        /*protected void btnBuscarAC_Click(object sender, EventArgs e)
        {

            VIA_CIRCULACION v = new VIA_CIRCULACION();


            List<DETALLE_CARACTERISTICA> datos = NegocioAdministrador.instancia.buscarCalle(txtNombreCalle.Text);


            foreach (var item in datos)
            {


                v.CANT_PISTAS = Convert.ToInt32(ddlistNumPistas.SelectedItem.Value);
                v.ID_ORIENTACION = Convert.ToInt32(ddlistOrient.SelectedItem.Value);
                v.ID_VELOC_MAXIMA = Convert.ToInt32(ddlistVelMax.SelectedItem.Value);
                v.ID_SENTIDO = Convert.ToInt32(ddlistSentido.SelectedItem.Value);
                v.ID_SECTOR = Convert.ToInt32(ddlistSector.SelectedItem.Value);
                v.ID_TIPO_CALLE = Convert.ToInt32(ddlistTipoCalle.SelectedItem.Value);
                ddlistNumPistas.SelectedItem.Value = v.CANT_PISTAS.ToString();


            }

        }*/

        protected void btnBorrarAC_Click(object sender, EventArgs e)
        {
            lblInfoAC.Visible = false;
            txtNombreCalle.Text = "";
            ddlistNumPistas.SelectedIndex = 0;
            ddlistOrient.SelectedIndex = 0;
            ddlistVelMax.SelectedIndex = 0;
            ddlistSentido.SelectedIndex = 0;
            ddlistSector.SelectedIndex = 0;
            ddlistTipoCalle.SelectedIndex = 0;
            btnGuardarAC.Text = "GUARDAR";
            txtNuevo.Text = "0";

            txtNombreCalle.BorderColor = System.Drawing.Color.LightGray;
            ddlistNumPistas.BorderColor = System.Drawing.Color.LightGray;
            ddlistOrient.BorderColor = System.Drawing.Color.LightGray;
            ddlistVelMax.BorderColor = System.Drawing.Color.LightGray;
            ddlistSentido.BorderColor = System.Drawing.Color.LightGray;
            ddlistSector.BorderColor = System.Drawing.Color.LightGray;
            ddlistTipoCalle.BorderColor = System.Drawing.Color.LightGray;

            txtNombreCalle.BorderWidth = 1;
            ddlistNumPistas.BorderWidth = 1;
            ddlistOrient.BorderWidth = 1;
            ddlistVelMax.BorderWidth = 1;
            ddlistSentido.BorderWidth = 1;
            ddlistSector.BorderWidth = 1;
            ddlistTipoCalle.BorderWidth = 1;

        }

        protected void txtNombreCalle_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlistNumPistas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlistOrient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlistVelMax_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlistSentido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlistSector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        protected void gvCalles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvCalles_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvCalles.PageIndex = e.NewPageIndex;
            gvCalles.DataSource = NegocioReporteria.Instancia.ListarCalles();
            gvCalles.DataBind();
        }

        protected void gvCalles_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        //protected void btnListarAC_Click(object sender, EventArgs e)
        //{
        //    gvCalles.DataSource = NegocioReporteria.Instancia.ListarCalles();
        //    gvCalles.DataBind();
        //}

        protected void chkActivoACa_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void gvCalles_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int contador = 0;
            if (e.CommandName == "botonGV")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gvCalles.Rows[index];
                txtNombreCalle.Text = row.Cells[1].Text;
                txtNuevo.Text = row.Cells[0].Text;
                foreach (var item in ddlistOrient.Items)
                {
                    if (item.ToString().Equals(row.Cells[3].Text))
                        ddlistOrient.SelectedIndex = contador;
                    contador = contador + 1;
                }
                contador = 0;
                foreach (var item in ddlistVelMax.Items)
                {
                    if (item.ToString().Equals(row.Cells[4].Text))
                        ddlistVelMax.SelectedIndex = contador;
                    contador = contador + 1;
                }
                contador = 0;
                foreach (var item in ddlistSentido.Items)
                {
                    if (item.ToString().Equals(row.Cells[5].Text))
                        ddlistSentido.SelectedIndex = contador;
                    contador = contador + 1;
                }
                contador = 0;
                foreach (var item in ddlistSector.Items)
                {
                    if (item.ToString().Equals(row.Cells[6].Text))
                        ddlistSector.SelectedIndex = contador;
                    contador = contador + 1;
                }
                contador = 0;
                foreach (var item in ddlistTipoCalle.Items)
                {
                    if (item.ToString().Equals(row.Cells[7].Text))
                        ddlistTipoCalle.SelectedIndex = contador;
                    contador = contador + 1;
                }
                contador = 0;

                ddlistNumPistas.SelectedIndex = Convert.ToInt32(row.Cells[2].Text);
                btnGuardarAC.Text = "ACTUALIZAR";


            }

        }

        protected void btnGuardarAC_Click(object sender, EventArgs e)
        {

            int n = 0;
            if (txtNombreCalle.Text == "" || txtNombreCalle.Text == null)
            {
                txtNombreCalle.BorderColor = System.Drawing.Color.Red;
                txtNombreCalle.BorderWidth = 1;
                n = 1;
            }
            else
            {
                txtNombreCalle.BorderColor = System.Drawing.Color.LightGray;
                txtNombreCalle.BorderWidth = 1;
                n = 0;
            }
            if (ddlistNumPistas.SelectedIndex == 0)
            {

                ddlistNumPistas.BorderColor = System.Drawing.Color.Red;
                n = 1;
            }
            else
            {
                ddlistNumPistas.BorderColor = System.Drawing.Color.LightGray;
                ddlistNumPistas.BorderWidth = 1;
                n = 0;
            }
            if (ddlistOrient.SelectedIndex == 0)
            {

                ddlistOrient.BorderColor = System.Drawing.Color.Red;
                n = 1;
            }
            else
            {
                ddlistOrient.BorderColor = System.Drawing.Color.LightGray;
                ddlistOrient.BorderWidth = 1;
                n = 0;
            }
            if (ddlistVelMax.SelectedIndex == 0)
            {

                ddlistVelMax.BorderColor = System.Drawing.Color.Red;
                n = 1;
            }
            else
            {
                ddlistVelMax.BorderColor = System.Drawing.Color.LightGray;
                ddlistVelMax.BorderWidth = 1;
                n = 0;
            }
            if (ddlistSentido.SelectedIndex == 0)
            {

                ddlistSentido.BorderColor = System.Drawing.Color.Red;
                n = 1;
            }
            else
            {
                ddlistSentido.BorderColor = System.Drawing.Color.LightGray;
                ddlistSentido.BorderWidth = 1;
                n = 0;
            }
            if (ddlistSector.SelectedIndex == 0)
            {

                ddlistSector.BorderColor = System.Drawing.Color.Red;
                n = 1;
            }
            else
            {
                ddlistSector.BorderColor = System.Drawing.Color.LightGray;
                ddlistSector.BorderWidth = 1;
                n = 0;
            }
            if (ddlistTipoCalle.SelectedIndex == 0)
            {

                ddlistTipoCalle.BorderColor = System.Drawing.Color.Red;
                n = 1;
            }
            else
            {
                ddlistTipoCalle.BorderColor = System.Drawing.Color.LightGray;
                ddlistTipoCalle.BorderWidth = 1;
                n = 0;
            }

            if (n == 1)
            {
                lblInfoAC.Visible = true;
                lblInfoAC.Text = "Los campos en Rojo son obligatorios";
                lblInfoAC.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                if (NegocioAdministrador.instancia.existeCalle(txtNombreCalle.Text) || Convert.ToInt32(txtNuevo.Text) > 0)
                {
                    DETALLE_CARACTERISTICA objCarac = new DETALLE_CARACTERISTICA();
                    int newPersonal = 0;
                    objCarac.DETALLE_CAR = txtNombreCalle.Text;
                    objCarac.ID_CARACTERISTICA = 10;
                    String estado = "1";
                    if (chkActivoACa.Checked)
                        estado = "1";
                    else
                        estado = "0";

                        newPersonal = NegocioAdministrador.instancia.CreaCalle(objCarac, Convert.ToInt32(ddlistNumPistas.SelectedValue), Convert.ToInt32(ddlistOrient.SelectedValue), Convert.ToInt32(ddlistVelMax.SelectedValue), Convert.ToInt32(ddlistSentido.SelectedValue), Convert.ToInt32(ddlistSector.SelectedValue), Convert.ToInt32(ddlistTipoCalle.SelectedValue), Convert.ToInt32(txtNuevo.Text), estado);
                   

                    if (newPersonal == 1 || newPersonal == 2)
                    {
                        txtNombreCalle.Text = "";
                        ddlistSector.SelectedIndex = 0;
                        ddlistNumPistas.SelectedIndex = 0;
                        ddlistOrient.SelectedIndex = 0;
                        ddlistSentido.SelectedIndex = 0;
                        ddlistTipoCalle.SelectedIndex = 0;
                        ddlistVelMax.SelectedIndex = 0;
                        chkActivoACa.Checked = true;
                        txtNuevo.Text = "0";
                        lblInfoAC.ForeColor = System.Drawing.Color.Gray;
                        if (newPersonal == 2)
                            lblInfoAC.Text = "Los Datos han sido actualizado exitosamente";
                        if (newPersonal == 1)
                            lblInfoAC.Text = "Los Datos han sido guardados exitosamente";

                        lblInfoAC.Visible = true;

                        gvCalles.DataSource = NegocioReporteria.Instancia.ListarCalles();
                        gvCalles.DataBind();

                    }
                    else
                    {
                        lblInfoAC.ForeColor = System.Drawing.Color.Red;
                        lblInfoAC.Text = "Los Datos no han sido guardados";
                        lblInfoAC.Visible = true;
                    }

                }
            }

        }

        protected void btnListarAC_Click(object sender, EventArgs e)
        {
            gvCalles.DataSource = NegocioReporteria.Instancia.ListarCalles();
            gvCalles.DataBind();
        }

        protected void ddlistTipoCalle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void txtNuevo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
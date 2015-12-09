using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using ClasesESpeciales;
using ClasesESpeciales.Helper;
using ConexionDatos.Entity;

namespace systemsri.Vistas.JefeTransito
{
    public partial class CasosApelacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"].Equals("") || Session["usuario"] == null ||
                !NegocioLoginUsuario.instancia.validaPagina(Session["usuario"].ToString(), 44))
            {
                Response.Redirect("../LoginUsuario/loginUsuario.aspx");
            }
            if (!Page.IsPostBack)
            {

                String infractor = Request.Form["rut_infr"];

                List<DetalleApelacion> detalleApelacion = new List<DetalleApelacion>();
                detalleApelacion = NegocioJefeTransito.instancia.detalleApelacion(infractor);
                int idmulta = 0;
                foreach (var item in detalleApelacion)
                {
                    lblNomCA.Text = item.NOMBRE + " " + item.APPAT + " " + item.APMAT;
                    lblRutCA.Text = item.RUT;
                    lbldirCA.Text = item.DIRECCION.ToString();
                    lblFonoAC.Text = item.FONO;
                    lblEmailCA.Text = item.EMAIL;
                    lblClaseLicCA.Text = item.CLASE_LIC;
                    lblCodMulCA.Text = item.COD_MULTA.ToString();
                    lblInfractorCA.Text = item.INSPECTOR;
                    idmulta = Convert.ToInt32(item.COD_MULTA.ToString());
                    lblGravCA.Text = item.GRAVEDAD;
                    lblValorCA.Text = item.VALOR.ToString() + " " + item.TIPO_MONEDA;
                    lblMontoPesosCA.Text = "$" + item.MONTO.ToString();
                    lblFechaMultaCA.Text = item.FECHA_MULTA.ToString();
                    lblMotMultaCA.Text = item.MOTIVO_MULTA;
                    lblHoraMultaCA.Text = item.HORA_MULTA;
                    lblLugarInfrCA.Text = item.TIPO_CALLE + " " + item.LUGAR_INFRACCION;
                    if (item.ESTADO_MULTA.Equals("0"))
                    {
                        lblEstadoMultaCA.Text = "NO PAGADA";
                    }
                    else if (item.ESTADO_MULTA.Equals("1"))
                    {
                        lblEstadoMultaCA.Text = "PAGADA";
                    }
                    txtMjeApelCA.Text = item.MENSAJE;

                    txtAdjunto.Text = NegocioJefeTransito.instancia.trarAdjunto(Convert.ToInt32(item.ID_MULTA));


                }
                NegocioJefeTransito.instancia.actualizaEstado(idmulta, 1141);

            }

        }

        protected void btnGuardarCA_Click(object sender, EventArgs e)
        {
            Descargar.instancia.Download(txtAdjunto.Text, "~/Upload/" + txtAdjunto.Text);
        }

        protected void txtMjeApelCA_TextChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedIndex == 0)
            {
                pnlRebaja.Visible = true;
            }

            else if (RadioButtonList1.SelectedIndex == 1)
            {
                pnlRebaja.Visible = false;
            }
        }

        protected void btnEnviarCA_Click(object sender, EventArgs e)
        {
            int aceptado = 0;
            if (RadioButtonList1.SelectedValue.Equals("Aprobar"))
            {
                if (txtRebajaCA.Text == "" || txtRebajaCA.Text == null)
                {
                    txtRebajaCA.BorderColor = System.Drawing.Color.Red;
                    txtRebajaCA.BorderWidth = 1;
                    lblInfoCA.ForeColor = System.Drawing.Color.Red;
                    lblInfoCA.Text = "Si aprueba la apelación debe añadir la cantidad a descontar";
                    lblInfoCA.Visible = true;
                   
                }
                else
                {
                    aceptado = 1;
                    int apelacion = NegocioJefeTransito.instancia.apelacion(Convert.ToInt32(lblCodMulCA.Text), txtComentarioCA.Text, aceptado, Convert.ToInt32(txtRebajaCA.Text));
                    txtRebajaCA.BorderColor = System.Drawing.Color.Red;
                    txtRebajaCA.BorderWidth = 1;
                    lblInfoCA.Text = "La apelación ha sido resuelta";
                    lblInfoCA.ForeColor = System.Drawing.Color.Gray;
                    lblInfoCA.Visible = true;
                    txtRebajaCA.Text = "";
                    txtComentarioCA.Text = "";
                }

            }
            if (RadioButtonList1.SelectedValue.Equals("Rechazar"))
            {
                aceptado = 0;
                int apelacion = NegocioJefeTransito.instancia.apelacion0(Convert.ToInt32(lblCodMulCA.Text), txtComentarioCA.Text, aceptado);
                txtComentarioCA.Text = "";
                lblInfoCA.Text = "La apelación ha sido resuelta";
                lblInfoCA.ForeColor = System.Drawing.Color.Gray;
                lblInfoCA.Visible = true;
            }



        }
    }
}
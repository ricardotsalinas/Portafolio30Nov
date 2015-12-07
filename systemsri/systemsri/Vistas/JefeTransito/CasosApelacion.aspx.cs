using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using ClasesESpeciales;
using ClasesESpeciales.Helper;

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
                foreach (var item in detalleApelacion)
                {
                    lblNomCA.Text = item.NOMBRE;
                    lblRutCA.Text = item.RUT;
                   // lbldirCA.Text = item.DIRECCION.ToString();
                    lblEmailCA.Text = item.EMAIL;
                    lblClaseLicCA.Text = item.CLASE_LIC;
                    lblCodMulCA.Text = item.COD_MULTA.ToString();
                    lblGravCA.Text = item.GRAVEDAD;
                    lblValorCA.Text = item.VALOR.ToString();
                    lblMontoPesosCA.Text = item.MONTO.ToString();
                    lblFechaMultaCA.Text = item.FECHA_MULTA.ToString();
                    lblHoraMultaCA.Text = item.HORA_MULTA;
                    lblLugarInfrCA.Text = item.LUGAR_INFRACCION;
                    lblEstadoMultaCA.Text = item.ESTADO_MULTA;

                    txtAdjunto.Text = NegocioJefeTransito.instancia.trarAdjunto(Convert.ToInt32(item.ID_MULTA));
                   // txtComentarioCA.Text = item.MENSAJE.ToString();
              
                }
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

        }
    }
}
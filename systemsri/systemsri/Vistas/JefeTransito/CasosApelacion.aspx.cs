using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using ClasesESpeciales;

namespace systemsri.Vistas.JefeTransito
{
    public partial class CasosApelacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["usuario"].Equals("") || Session["usuario"] == null ||
            //    !NegocioLoginUsuario.instancia.validaPagina(Session["usuario"].ToString(), 44))
            //{
            //    Response.Redirect("../LoginUsuario/loginUsuario.aspx");
            //}
             if (!Page.IsPostBack)
            {

                String infractor = Request.Form["rut_infr"];

                List<DetalleApelacion> detalleApelacion = new List<DetalleApelacion>();
                detalleApelacion = NegocioJefeTransito.instancia.detalleApelacion(infractor);
                foreach (var item in detalleApelacion)
                {
                    lblNomCA.Text = item.NOMBRE.ToString();
                    lblRutCA.Text = item.RUT.ToString();
                   // lbldirCA.Text = item.DIRECCION.ToString();
                    lblEmailCA.Text = item.EMAIL.ToString();
                    lblClaseLicCA.Text = item.CLASE_LIC.ToString();
                    lblCodMulCA.Text = item.COD_MULTA.ToString();
                    lblGravCA.Text = item.GRAVEDAD.ToString();
                    lblValorCA.Text = item.VALOR.ToString();
                    lblMontoPesosCA.Text = item.MONTO.ToString();
                    lblFechaMultaCA.Text = item.FECHA_MULTA.ToString();
                    lblHoraMultaCA.Text = item.HORA_MULTA.ToString();
                    lblLugarInfrCA.Text = item.LUGAR_INFRACCION.ToString();
                    lblEstadoMultaCA.Text = item.ESTADO_MULTA.ToString();
                   // txtComentarioCA.Text = item.MENSAJE.ToString();
              
                }
            }     
        
        }

        protected void btnGuardarCA_Click(object sender, EventArgs e)
        {

        }

        protected void txtMjeApelCA_TextChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
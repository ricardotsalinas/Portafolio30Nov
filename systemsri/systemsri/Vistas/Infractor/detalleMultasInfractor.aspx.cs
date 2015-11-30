using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClasesESpeciales;
using Negocio;

namespace systemsri.Vistas.Infractor
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"].Equals("") || Session["usuario"] == null ||
               !NegocioLoginUsuario.instancia.validaPaginaInfractor(Session["usuario"].ToString()))
            {
                Response.Redirect("../LoginUsuario/loginInfractor.aspx");
            }

            if (!Page.IsPostBack)
            {

                String test = Request.Form["idMulta"];

                List<DetalleMultaInfractor> detalleInfractor = new List<DetalleMultaInfractor>();

                detalleInfractor = Negocio.NegocioInfractor.instancia.detalleInfractor(test);

                foreach (var item in detalleInfractor)
                {
                    txtCodMultaDMI.Text      = item.ID_MULTA.ToString();
                    txtGravDMI.Text          = item.GRAVEDAD;
                    txtMontoDMI.Text         = item.MONTO.ToString();
                    txtFecMultaDMI.Text      = item.FECHA_MULTA.ToShortDateString();
                    txtHoraMultaDMI.Text     = item.HORA_MULTA;
                    txtMotivoMultaDMI.Text   = item.MOTIVO_MULTA;
                    txtDetAdicDMI.Text       = item.DETALLE_ADICIONAL;
                    txtLugarInfrDMI.Text     = item.LUGAR_INFRACCION;
                    lblNombreDMI.Text        = item.NOMBRE;
                    lblPatDMI.Text           = item.PATENTE;
                    lblRutDMI.Text           = item.RUT;
                }


            }

        }

       
       
    }
}
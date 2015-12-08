using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClasesESpeciales;
using Negocio;
using ConexionDatos.Entity;
using ClasesESpeciales.Helper;
using System.Collections.Specialized;

namespace systemsri.Vistas.Infractor
{
    public partial class detallePagarMulta : System.Web.UI.Page
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

                String multaID = Request.Form["idMulta"];

                List<DetalleMultaInfractor> infractorPagar = new List<DetalleMultaInfractor>();

                infractorPagar = NegocioInfractor.instancia.detalleInfractor(multaID);
                DateTime fechaParaApelar = DateTime.MinValue;
                foreach (var item in infractorPagar)
                {
                    lblCodMultaDMI.Text = item.ID_MULTA.ToString();
                    lblRutDPM.Text = item.RUT;
                    lblNombreDPM.Text = item.NOMBRE;
                    lblPatDPM.Text = item.PATENTE;
                    lblMontoDMI.Text = item.MONTO.ToString();
                    lblFecMultaDMI.Text = item.FECHA_MULTA.ToShortDateString();
                    lblHoraMultaDMI.Text = item.HORA_MULTA;
                    lblMotivoMultaDMI.Text = item.MOTIVO_MULTA;
                    lblDetAdicDMI.Text = item.DETALLE_ADICIONAL;
                    lblLugarInfrDMI.Text = item.LUGAR_INFRACCION;
                    lblGravDMI.Text = item.GRAVEDAD;
                    fechaParaApelar = item.FECHA_MULTA;
                }
                TimeSpan ts = DateTime.Now - fechaParaApelar;
                if (ts.Days<=3)
                {
                    Panel1.Visible = true;
                    Panel1.Enabled = true;
                    noPuedeApelar.Visible = false;
                    noPuedeApelar.Text = String.Empty;
                }
                else
                {
                    Panel1.Visible = false;
                    Panel1.Enabled = false;

                    noPuedeApelar.Text = "Supera los dias maximos para apelar";
                    noPuedeApelar.ForeColor = System.Drawing.Color.Red;
                    noPuedeApelar.Visible = true;
                }
            }
        }

        protected void btnPagarDPM_Click1(object sender, EventArgs e)
        {
            NameValueCollection data = new NameValueCollection();
            String multa = lblCodMultaDMI.Text;
            data.Add("idMulta", multa);
            HttpHelper.RedirectAndPOST(this.Page, "../Paypal/InicioPaypal.aspx", data);
        }

        protected void btnEnviarDPM_Click(object sender, EventArgs e)
        {
            Boolean adjunto = false;
            ADJUNTOS_APELACION adjApelacion = new ADJUNTOS_APELACION();
            APELACION ape = new APELACION();
            if (FileUpload1.HasFile)
            {
                String Extension = System.IO.Path.GetExtension(FileUpload1.FileName);
                int peso = FileUpload1.PostedFile.ContentLength;
                if (Extension.ToLower() != ".doc"  &&
                    Extension.ToLower() != ".docx" &&
                    Extension.ToLower() != ".pdf"  &&
                    Extension.ToLower() != ".jpg"  &&
                    Extension.ToLower() != ".png"  &&
                    Extension.ToLower() != ".zip"  &&
                    Extension.ToLower() != ".rar")
                {
                    //TEXTO/**********
                }
                else
                {
                    if (peso <= 5242880)
                    {
                        if (FileUpload1.FileName.Length < 50)
                        {
                                adjApelacion.ADJUNTO = lblRutDPM.Text +"_"+ FileUpload1.FileName;
                                adjunto = true;
                        }
                        else
                        {
                           ///////
                        }
                    }
                    else
                    {
                        // TEXTO DE MAXIMO DE PESO 
                    }

                }
            }
            else
            {
                // TEXTO NO EXISTE EL ARCHIVO
            }


            if (!txtApelDPM.Text.Equals("") || txtApelDPM.Text != null)
            {
                ape.SOLICITUD_APELACION = txtApelDPM.Text.Trim();
                ape.ID_MULTA = Convert.ToDecimal(lblCodMultaDMI.Text);
           
                // 1142 CORRESPONDE A NO LEIDO ****
                ape.ESTADO = 1142;
                String  nuevaApleacion = NegocioInfractor.instancia.crearApelacion(adjApelacion, ape, adjunto);

                if (adjunto)
                {
                    if (nuevaApleacion.Equals("ERROR"))
                    {
                        FileUpload1.SaveAs(Server.MapPath("~/Upload/" + "ERROR" + nuevaApleacion + "_" + lblRutDPM.Text + "_" + FileUpload1.FileName));
                        // ERROR AL GENERAR LA APELACION
                    }
                    else
                    {
                        FileUpload1.SaveAs(Server.MapPath("~/Upload/" + nuevaApleacion + "_" + lblRutDPM.Text + "_" + FileUpload1.FileName));

                    }
                    txtApelDPM.Text = String.Empty;
                }
            }
            else
            { 
                ///error
            }
           
        }

        
    }
}

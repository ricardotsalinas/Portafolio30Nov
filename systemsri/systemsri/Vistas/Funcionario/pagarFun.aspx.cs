using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using ClasesESpeciales;

namespace systemsri.Vistas.Funcionario
{
    public partial class pagarFun : System.Web.UI.Page
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
                
                            String infractor = Request.Form["rut_infr"];

                List<DetalleInfractorPagar> detallePagar = new List<DetalleInfractorPagar>();
                detallePagar= NegocioFuncionario.instancia.detalleInfractorPagar(infractor);
                foreach (var item in detallePagar)
                {
                    lblNombrePF.Text = item.NOMBRE+" "+item.APPAT+" "+item.APMAT;
                    lblRutPF.Text = item.RUT;
                    lblMontoPF.Text = Convert.ToString(item.MONTO);
                    lblEstadoPago.Text = item.ESTADO;
                    lblNumMulta.Text = item.NUMMULTA.ToString();
                }
            }     
            
        }

      


        protected void btnPagarPF_Click(object sender, EventArgs e)
        {
           // int resul = NegocioInfractor.instancia.actualizaPago(lblFechaPagoPF.Text, txtTelefonoDI.Text, txtRutDI.Text);
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if (RadioButtonList1.SelectedIndex==0)
                lblTipoPago.Text = "1146";
            else if (RadioButtonList1.SelectedIndex == 1)
                lblTipoPago.Text = "1147";
           
           
        }


      
    
    }
}
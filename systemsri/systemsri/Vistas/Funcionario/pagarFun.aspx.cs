using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using ClasesESpeciales;
using System.Collections.Specialized;

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
            int pagarMUlta = NegocioInfractor.instancia.pagarMulta(Convert.ToInt32(lblNumMulta.Text));
            lblInfoPF.Text = "El pago se ha realizado Correctamente";
            lblInfoPF.ForeColor = System.Drawing.Color.Gray;
            lblInfoPF.Visible = true;

            
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
          
        }


      
    
    }
}
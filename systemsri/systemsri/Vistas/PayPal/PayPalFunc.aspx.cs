using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace systemsri.Vistas.PayPal
{
    public partial class PayPalFunc : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!Page.IsPostBack)
            
                {
                    String multaID = Request.Form["idMulta"];
                    lblIdmulta2.Text = "Multa a pagar : " + multaID;
                    lblID2.Text = multaID;
                }


        }

        protected void bot_LogPayPal2_Click(object sender, EventArgs e)
        {

            int pagarMUlta = NegocioInfractor.instancia.pagarMulta(Convert.ToInt32(lblID2.Text));
            lblInfoPPF.ForeColor = System.Drawing.Color.Black;
            lblInfoPPF.Visible = true;
        }
        

        protected void btnVolver2_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Funcionario/admFun.aspx");
        }
    }
}
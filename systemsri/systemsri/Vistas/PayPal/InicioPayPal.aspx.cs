﻿using System;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace systemsri.Vistas.PayPal
{
    public partial class InicioPayPal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!Page.IsPostBack)
            {
                String multaID = Request.Form["idMulta"];
                lblIdmulta.Text = "Multa a pagar : "+multaID;
                lblID.Text = multaID;
            }
        }

        protected void bot_LogPayPal_Click(object sender, EventArgs e)
        {

            int pagarMUlta = NegocioInfractor.instancia.pagarMulta(Convert.ToInt32(lblID.Text));
            lblInfoIPP.ForeColor = System.Drawing.Color.Black;
            lblInfoIPP.Text = "El pago ha sido realizado correctamente";
            lblInfoIPP.Visible = true;

        }
        

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Infractor/datosInfractor.aspx");
        }
    }
}
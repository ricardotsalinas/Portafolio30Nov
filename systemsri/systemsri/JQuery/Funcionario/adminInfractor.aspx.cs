using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConexionDatos.Entity;
using Negocio;

namespace systemsri.Vistas.Funcionario
{
    public partial class adminInfractor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardarAIn_Click(object sender, EventArgs e)
        {
            INFRACTOR p = new INFRACTOR();
            p.RUT_INFR = txtRutAIn.Text;
            p.NOMBRE_INFR= txtNomAIn.Text;
            p.APPAT_INFR= txtAppatAIn.Text;
            p.APMAT_INFR = txtApmatAIn.Text;
            p.ACTIVO = "1";
            p.DIRECCION_INFR= txtDirAIn.Text;
            p.TELEFONO_INFR= txtTelAIn.Text;
            p.EMAIL_INFR = txtEmailAIn.Text;
            p.PASSWORD_INFR = "aa";
            p.NUM_LICENCIA = Convert.ToDecimal("3");
            p.ID_VEHICULO = Convert.ToDecimal("2");
            int newInfractor = NegocioFuncionario.instancia.CrearInfractor(p);
            if (newInfractor == 1)
            {
                Response.Write("<script language=javascript>alert('Los datos han sido guardados exitosamente');</script>");
                txtRutAIn.Text = "";
                txtNomAIn.Text = "";
                txtAppatAIn.Text = "";
                txtApmatAIn.Text = "";
                txtDirAIn.Text = "";
                txtTelAIn.Text = "";
                txtEmailAIn.Text = "";
            }
            else
                Response.Write("<script language=javascript>alert('Datos no guardados');</script>");
        
        }

        protected void btnBuscarAIn_Click(object sender, EventArgs e)
        {
            List<INFRACTOR> buscar = NegocioFuncionario.instancia.buscarInfractor(txtRutAIn.Text);

            if (buscar.Count == 0)
            {
                Response.Write("<script language=javascript>alert('El rut consultado no existe');</script>");
                txtRutAIn.Text = "";
                txtNomAIn.Text = "";
                txtAppatAIn.Text = "";
                txtApmatAIn.Text = "";
                txtDirAIn.Text = "";
                txtTelAIn.Text = "";
                txtEmailAIn.Text = "";
            }
            else
              
            foreach (var list in buscar)
            {
                txtRutAIn.Text = list.RUT_INFR.ToString();
                txtNomAIn.Text = list.NOMBRE_INFR;
                txtAppatAIn.Text = list.APPAT_INFR;
                txtApmatAIn.Text = list.APMAT_INFR;
                txtDirAIn.Text = list.DIRECCION_INFR;
                txtTelAIn.Text = list.TELEFONO_INFR;
                txtEmailAIn.Text = list.EMAIL_INFR;
                
            }

        }

        protected void bot_reset_clave_Click(object sender, EventArgs e)
        {

        }

        protected void bot_pass_infr_Click(object sender, EventArgs e)
        {

        }

       
    }
}
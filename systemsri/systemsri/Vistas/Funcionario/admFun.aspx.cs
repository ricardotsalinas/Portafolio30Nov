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
    public partial class admFun : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardarAF_Click(object sender, EventArgs e)
        {
            INFRACTOR p = new INFRACTOR();
            p.RUT_INFR = txtRutAF.Text;
            p.NOMBRE_INFR = txtNomAF.Text;
            p.APPAT_INFR = txtAppatAF.Text;
            p.APMAT_INFR = txtApmatAF.Text;
            p.ACTIVO = "1";
            p.DIRECCION_INFR = txtDirAF.Text;
            p.TELEFONO_INFR = txtFonoAF.Text;
            p.EMAIL_INFR = txtEmailAF.Text;
            p.PASSWORD_INFR = "aa";
            p.NUM_LICENCIA = Convert.ToDecimal("3");
            p.ID_VEHICULO = Convert.ToDecimal("2");
            int newInfractor = NegocioFuncionario.instancia.CrearInfractor(p);
            if (newInfractor == 1)
            {
                lblInfoAF.Visible = true;
                lblInfoAF.Text = "Los datos han sido guardados exitosamente";

                txtRutAF.Text = "";
                txtNomAF.Text = "";
                txtAppatAF.Text = "";
                txtApmatAF.Text = "";
                txtDirAF.Text = "";
                txtFonoAF.Text = "";
                txtFnacAF.Text = "";
            }
            else
                Response.Write("<script language=javascript>alert('Datos no guardados');</script>");

        }

        protected void btnBuscarAF_Click(object sender, EventArgs e)
        {
            List<INFRACTOR> buscar = NegocioFuncionario.instancia.buscarInfractor(txtRutAF.Text);

            if (buscar.Count == 0)
            {
                lblInfoAF.Visible = true;
                lblInfoAF.Text = "El rut consultado no existe";

                txtRutAF.Text = "";
                txtNomAF.Text = "";
                txtAppatAF.Text = "";
                txtApmatAF.Text = "";
                txtDirAF.Text = "";
                txtFonoAF.Text = "";
                txtFnacAF.Text = "";
            }
            else

                foreach (var list in buscar)
                {
                    txtRutAF.Text = list.RUT_INFR.ToString();
                    txtNomAF.Text = list.NOMBRE_INFR;
                    txtAppatAF.Text = list.APPAT_INFR;
                    txtApmatAF.Text = list.APMAT_INFR;
                    txtDirAF.Text = list.DIRECCION_INFR;
                    txtFonoAF.Text = list.TELEFONO_INFR;
                    txtFnacAF.Text = list.EMAIL_INFR;

                }

        }

  
        protected void btnPassAF_Click(object sender, EventArgs e)
        {

        }
    }
}
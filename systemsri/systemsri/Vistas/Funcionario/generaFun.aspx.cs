using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using ConexionDatos.Entity;

namespace systemsri.Vistas.Funcionario
{
    public partial class generaFun : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlistSectorGF.DataSource = NegocioFuncionario.instancia.listarSector();
            ddlistSectorGF.DataBind();
            ddlistSectorGF.Items.Insert(0, new ListItem("Seleccionar", ""));
        }

        protected void btnGuardarGF_Click(object sender, EventArgs e)
        {

        }

        protected void btnBuscarGF_Click(object sender, EventArgs e)
        {
            List<PERSONAL> buscar = NegocioAdministrador.instancia.buscarPersona(txtRutGF.Text);

            if (buscar.Count == 0)
            {
                lblInfoGF.Text = "El rut consultado no existe";
                lblInfoGF.Visible = true;
                lblInfoGF.ForeColor = System.Drawing.Color.Red;
                txtRutGF.Text = "";
                txtNomGF.Text = "";
                ddlistSectorGF.Items.Insert(0, new ListItem("Seleccionar", ""));
                txtFechaGF.Text = "";
                txtHoraIniGF.Text = "";
                txtHoraTermGF.Text = "";
                txtDetAdicGF.Text = "";

            }


            foreach (var list in buscar)
            {
                txtRutGF.Text = list.RUT_PER.ToString();
                txtNomGF.Text = list.NOMBRE_PER + " " + list.APPAT_PER;

            }

        }

        protected void ddlistSectorGF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
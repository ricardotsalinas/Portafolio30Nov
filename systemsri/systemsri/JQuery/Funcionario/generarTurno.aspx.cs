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
    public partial class generarTurno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlistSectorGT.DataSource = NegocioFuncionario.instancia.listarSector();
            ddlistSectorGT.DataBind();
        }



        protected void btnBuscarGT_Click(object sender, EventArgs e)
        {
        }

        protected void ddlistSectorGT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnGuardarGT_Click(object sender, EventArgs e)
        {

        }

        protected void btnBorrarGT_Click(object sender, EventArgs e)
        {

        }
    }
}
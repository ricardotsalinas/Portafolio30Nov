using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using ConexionDatos.Entity;
using ClasesESpeciales;

namespace systemsri.Vistas.Funcionario
{
    public partial class generaFun : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlistSectorGF.DataSource = NegocioFuncionario.instancia.listarSector();
                ddlistSectorGF.DataBind();
                ddlistSectorGF.Items.Insert(0, new ListItem("Seleccionar", ""));
            }
        }

        protected void btnGuardarGF_Click(object sender, EventArgs e)
        {

         
            int encontrarID =  NegocioFuncionario.instancia.buscarID(txtRutGF.Text);

            PERSONAL_SECTOR perso = new PERSONAL_SECTOR();
            perso.ID_PERSONAL = encontrarID;
            int sector = NegocioFuncionario.instancia.buscarSector(Convert.ToInt32(ddlistSectorGF.SelectedValue));
            perso.ID_SECTOR = sector;
            perso.FECHA_INICIO =  Convert.ToDateTime(txtFechaGF.Text);
            perso.FECHA_TERMINO = Convert.ToDateTime(FechaFin.Text);

            NegocioFuncionario.instancia.creaPersonalSector(perso);

            TURNO tur = new TURNO();
            tur.FECHA_TURNO = Convert.ToDateTime(txtFechaGF.Text);
            tur.HORA_INICIO = txtHoraIniGF.Text;
            tur.HORA_FIN = txtHoraTermGF.Text;
            tur.DETALLE_TURNO = txtDetAdicGF.Text;
            tur.ID_PERSONAL = encontrarID;

            int grabarTurno = NegocioFuncionario.instancia.grabarTurno(tur);

 

           
        }

        protected void btnBuscarGF_Click(object sender, EventArgs e)
        {
            List<PERSONAL> buscar = NegocioAdministrador.instancia.buscarPersona(txtRutGF.Text);

            if (buscar.Count == 0)
            {
                lblInfoGF.Text = "El rut consultado no existe";
                lblInfoGF.Visible = true;
                lblInfoGF.ForeColor = System.Drawing.Color.Red;
                ddlistSectorGF.Items.Insert(0, new ListItem("Seleccionar", ""));


            }
            else
            {
                btnGuardarGF.Visible = true;
            }


                foreach (var list in buscar)
                {
                    txtRutGF.Text = list.RUT_PER.ToString();
                    txtNomGF.Text = list.NOMBRE_PER + " " + list.APPAT_PER;
                    ddlistSectorGF.Enabled = true;
                    txtFechaGF.Enabled = true;
                    txtHoraIniGF.Enabled = true;
                    txtHoraTermGF.Enabled = true;
                    txtDetAdicGF.Enabled = true;

                }

           
        }

        protected void ddlistSectorGF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnBorrarGF_Click(object sender, EventArgs e)
        {
            txtRutGF.Text = "";
            txtNomGF.Text = "";
            ddlistSectorGF.SelectedIndex = 0;
            txtFechaGF.Text = "";
            txtHoraIniGF.Text = "";
            txtHoraTermGF.Text = "";
            txtDetAdicGF.Text = "";
            btnGuardarGF.Visible = false;
        }

        protected void btnListarGF_Click(object sender, EventArgs e)
        {
            gvTurnos.DataSource = NegocioReporteria.Instancia.ListarTurnos();
            gvTurnos.DataBind();
        }

        protected void gvTurnos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvTurnos_DataBound(object sender, EventArgs e)
        {

        }

        protected void gvTurnos_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void gvTurnos_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void gvTurnos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //gvTurnos.PageIndex = e.NewPageIndex;
            //gvTurnos.DataSource = NegocioReporteria.Instancia.ListarTurnos();
            //gvTurnos.DataBind();
        }

       
    }
}
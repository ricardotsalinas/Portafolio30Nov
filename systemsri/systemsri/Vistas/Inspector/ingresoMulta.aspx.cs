using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using ConexionDatos.Entity;
using System.Data;
using System.Collections;

namespace systemsri.Vistas.Inspector
{
    public partial class ingresoMulta : System.Web.UI.Page
    {
        public List<DETALLE_CARACTERISTICA> lts = new List<DETALLE_CARACTERISTICA>();
        protected void Page_Load(object sender, EventArgs e)
        {
          if (Session["usuario"].Equals("") || Session["usuario"] == null ||
                !NegocioLoginUsuario.instancia.validaPagina(Session["usuario"].ToString(), 42))
            {
                Response.Redirect("../LoginUsuario/loginUsuario.aspx");
            }
     
           lts = NegocioAdministrador.instancia.listarMotivo();
           if (!Page.IsPostBack)
           {
                ddlistLugarInfIM.Items.Clear();
                ddlistLugarInfIM.DataSource = NegocioAdministrador.instancia.listarCalle();
                ddlistLugarInfIM.DataBind();
                ddlistLugarInfIM.Items.Insert(0, new ListItem("Seleccionar", ""));
                
                ddlistMotivoIM.DataSource = NegocioAdministrador.instancia.listarMotivoddl();
                ddlistMotivoIM.DataTextField = "DETALLE_CAR";
                ddlistMotivoIM.DataValueField = "ID_DETCAR";
                ddlistMotivoIM.DataBind();
                ddlistMotivoIM.Items.Insert(0, new ListItem("Seleccionar", ""));
  
           }

           txtHoraMultaIM.Text = DateTime.Now.ToShortTimeString();
           txtFechaMultaIM.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        protected void bot_guardar_multa_Click(object sender, EventArgs e)
        {

        }

        protected void txtPatIM_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnGuardarIM_Click(object sender, EventArgs e)
        {

        }

        protected void ddlistMotivoIM_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //txtDetCompleto.Text = ddlistMotivoIM.SelectedItem.ToString();
            string val = ddlistMotivoIM.SelectedItem.Value;
            foreach (DETALLE_CARACTERISTICA d in lts)
            {
                if (val == d.ID_DETCAR.ToString())
                {
                    txtDetCompleto.Text = d.DETALLE_CAR;
                    break;
                }

            }
        }

        protected void txtHoraMultaIM_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtDetCompleto_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnmotivo_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnBuscarRut_Click(object sender, EventArgs e)
        {

                if (!String.IsNullOrEmpty(txtPatIM.Text))
                {
                    ArrayList datos = new ArrayList();
                    datos = NegocioInspector.instancia.datosRegistroCivil(txtPatIM.Text);
                    if (!datos[0].ToString().Equals("error"))
                    {
                        txtRutIM.Text = datos[0].ToString();
                        txtNomIM.Text = datos[1].ToString();
                        txtPatIM.Text = datos[2].ToString();
                        txtAppatIM.Text = datos[3].ToString();
                        txtApmatIM.Text = datos[4].ToString();
                        txtFechaNacimientoIM.Text = datos[5].ToString();
                        txtDireccion.Text = datos[6].ToString();
                    }
                    //error datos no encotrados
                }
                ///////// agregar un errro al momento de no tener nada escrito 
        }

      
        protected void btnLimpiarIM_Click(object sender, EventArgs e)
        {

            txtPatIM.Text = String.Empty;
            txtDetCompleto.Text = String.Empty;
            txtDetalleAdicIM.Text = String.Empty;
           
        }

        protected void btnGuardarIM_Click1(object sender, EventArgs e)
        {
            String rut = "";
            String NOMBRE_INFR = "";
            String APPAT_INFR = "";
            String APMAT_INFR = "";
            String DIRECCION_INFR = "";
            String FECHANACIMIENTO = "";
            String patente ="";
            ArrayList datos = new ArrayList();
            datos = NegocioInspector.instancia.datosRegistroCivil(txtPatIM.Text);
            if (!datos[0].ToString().Equals("error"))
            {
                rut = datos[0].ToString();
                NOMBRE_INFR = datos[1].ToString();
                patente = datos[2].ToString();
                APPAT_INFR = datos[3].ToString();
                APMAT_INFR = datos[4].ToString();
                FECHANACIMIENTO = datos[5].ToString();
                DIRECCION_INFR = datos[6].ToString();
            }

            MULTA objM = new MULTA();
            objM.FECHA_CREACION =Convert.ToDateTime(txtFechaMultaIM.Text);
            objM.FECHA_INTEGRACION = Convert.ToDateTime(txtFechaMultaIM.Text);
            objM.HORA_MULTA = txtHoraMultaIM.Text;
            objM.MONTO_ADICIONAL = 0;
            objM.PAGADA = "0";
            objM.ACTIVO = "1";
            objM.LICENCIA_ENTREGADA = "0";
            if (chkCarabIM.Checked)
            {
                if (!String.IsNullOrEmpty(txtLicCarabIM.Text))
                {
                    objM.CARABINERO_OPC = 1;
                    objM.ID_LIC_CARAB = Convert.ToInt32(txtLicCarabIM.Text);
                        if(chkRetLicIM.Checked)
                            objM.RETENCION_LICENCIA = "1";
                        else
                            objM.RETENCION_LICENCIA = "0";
                }
               

            }
            objM.ID_PERSONAL = NegocioInspector.instancia.buscaInspector(Session["usuario"].ToString());
            if (!NegocioInfractor.instancia.existeRut(txtRutIM.Text))
            {
                objM.ID_INFRACTOR = NegocioInfractor.instancia.idInfractor(txtRutIM.Text);
            }
            else
            { 
                    INFRACTOR inf = new INFRACTOR();
                    inf.RUT_INFR = rut;
                    inf.NOMBRE_INFR = NOMBRE_INFR;
                    inf.APPAT_INFR = APPAT_INFR;
                    inf.APMAT_INFR = APMAT_INFR;
                    inf.DIRECCION_INFR = DIRECCION_INFR;
                    inf.FECHA_NAC = Convert.ToDateTime(FECHANACIMIENTO);
                    inf.TELEFONO_INFR = "";
                    if (NegocioInspector.instancia.existeVehiculo(patente) > 0)
                        inf.ID_VEHICULO = NegocioInspector.instancia.existeVehiculo(patente);
                    else
                        inf.ID_VEHICULO = NegocioInspector.instancia.creaVehiculo(patente);

                    inf.ID_CLASE_LICENCIA = 6;
                    int largoRut = rut.Length;
                    rut = rut.Substring(0, largoRut - 1);
                    inf.NUM_LICENCIA = Convert.ToInt32(rut);
                    inf.ACTIVO = "1";

                
                    objM.ID_INFRACTOR = NegocioInfractor.instancia.FunConId(inf);
            }

            objM.ID_VIA_CIRCULACION = NegocioInspector.instancia.idViaN(Convert.ToInt32(ddlistLugarInfIM.SelectedValue));
            int idMOneda = NegocioInspector.instancia.idInfraccion(Convert.ToInt32(ddlistMotivoIM.SelectedValue));
            int idInfraccion = NegocioInspector.instancia.idInfraccion2(Convert.ToInt32(ddlistMotivoIM.SelectedValue));
            objM.ID_INFRACCION = idInfraccion; 
            objM.ID_MONEDA = NegocioInspector.instancia.moneda(idMOneda);
            objM.DETALLE_ADICIONAL = txtDetalleAdicIM.Text;
            objM.ID_RESTRICCION = NegocioInspector.instancia.idRestriccion();

            if (FileUpload.HasFile)
            {
                String Extension = System.IO.Path.GetExtension(FileUpload.FileName);
                int peso = FileUpload.PostedFile.ContentLength;

                if (Extension.ToLower() != ".doc" &&
                    Extension.ToLower() != ".docx" &&
                    Extension.ToLower() != ".pdf" &&
                    Extension.ToLower() != ".jpg" &&
                    Extension.ToLower() != ".png" &&
                    Extension.ToLower() != ".zip" &&
                    Extension.ToLower() != ".rar")
                {
                    //TEXTO ERROR EXTENCION
                }
                else
                {
                    if (peso <= 5242880)
                    {
                        if (FileUpload.FileName.Length < 50)
                        {
                            objM.ADJUNTO = txtRutIM.Text +"_multa_"+ "_" + FileUpload.FileName;
                            int grabado = NegocioInspector.instancia.grabaMulta(objM);
                            FileUpload.SaveAs(Server.MapPath("~/Upload/" + grabado + "_" + txtRutIM.Text + "_multa_" + FileUpload.FileName));
                            
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
                objM.ADJUNTO = "ARCHIVO EN BLANCO O NO ADJUNTADO";
                int grabado = NegocioInspector.instancia.grabaMulta(objM);
               
            }

        }

        protected void txtFechaMultaIM_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlistLugarInfIM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
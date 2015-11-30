<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Inspector/MPInspector.master" AutoEventWireup="true" CodeBehind="datosInspector.aspx.cs" Inherits="systemsri.Vistas.Inspector.datosInspector" %>
 <%@ OutputCache Location="None" NoStore="true"%>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoAdmin" runat="server">
    <form id="formDatosInfractor" runat="server">
         <div class="alinInicial">
             <h2>Datos Personales</h2>

              <table style="width: 70%">
                <tr>
                    <td class="c1g">RUT:</td> 
                    <td class="c1b"> <asp:TextBox runat="server" id="txtRutDIn" CssClass="input1" Enabled="False" ></asp:TextBox></td>
                </tr>
                <tr>
                <!-- Se integrarán todos los nombres para solo informacion-->
                    <td class="c1g">NOMBRE:</td> 
                    <td class="c1b"><asp:TextBox runat="server" id="txtNomDIn" CssClass="input1" Enabled="False" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="c1g">FECHA DE<br/>NACIMIENTO:</td> 
                    <td class="c1b"><asp:TextBox runat="server" id="txtFNacDIn" CssClass="input1" Enabled="False" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="c1g">DIRECCIÓN:</td> 
                    <td class="c1b"><asp:TextBox runat="server" id="txtDirDIn" CssClass="input1" Enabled="False" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="c1g">EMAIL:</td> 
                    <td class="c1b"><asp:TextBox runat="server" id="txtEmailDIn" CssClass="input1"></asp:TextBox></td>
                   <td><img src="../../Recursos/Imagenes/editar.PNG" /></td>
                </tr>
                <tr>
                    <td class="c1g">TELÉFONO:</td> 
                    <td class="c1b"><asp:TextBox runat="server" id="txtTelefonoDIn" CssClass="input1"></asp:TextBox></td>
                    <td><img src="../../Recursos/Imagenes/editar.PNG" /></td>
                </tr>
                <tr>
                    <td class="c1g">CLASE DE<br />LICENCIA:</td> 
                    <td class="c1b"><asp:TextBox runat="server" id="txtClaseLicDIn" Enabled="False" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="c1g">CONTRASEÑA:</td> 
                    <td class="c1b">
                        <asp:Button id="btnModificaPassDIn" CssClass="boton" runat="server" 
                            Text="MODIFICAR" onclick="btnModificaPassDIn_Click" /></td>
                </tr>
            </table>
            <table id="tblPassDIn" runat="server" style="display:none" width="70%">
                 <tr>
                     <td class="c3g" colspan="2">GENERE SU NUEVA CONTRASEÑA</td>
                 </tr>
                 <tr>
                    <td class="ctxt2" >
                        <asp:TextBox runat="server" id="txtCambiaPassDIn1" CssClass="input1"  />
                        <h5 style="margin:auto">*Ingrese nueva contraseña</h5>

                    </td>
                    <td class="ctxt2">
                       <asp:TextBox runat="server" id="txtCambiaPassDIn2" CssClass="input1"  />
                        <h5 style="margin:auto">*Confirme nueva contraseña</h5>
                    </td>
                </tr>
             </table>
             <div><br /></div>
             <table style="margin: 0 auto;">
                <tr>
                    <td><asp:Button ID="btnGuardarDIn" CssClass="boton" runat="server" Text="GUARDAR" /></td>
                </tr>
             </table>
          </div>  
        </form>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Funcionario/MPFuncionario.master" AutoEventWireup="true" CodeBehind="datosFuncionario.aspx.cs" Inherits="systemsri.Vistas.Funcionario.datosFuncionario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoAdmin" runat="server">
  <form id="formDatosInfractor" runat="server">
         <div class="alinInicial">
             <h2>Datos Personales</h2>

              <table style="width: 70%">
                <tr>
                    <td class="c1g">RUT:</td> 
                    <td class="c1b"> <asp:TextBox runat="server" id="txtRutDF" CssClass="input1" Enabled="False" ></asp:TextBox></td>
                </tr>
                <tr>
                <!-- Se integrarán todos los nombres para solo informacion-->
                    <td class="c1g">NOMBRE:</td> 
                    <td class="c1b"><asp:TextBox runat="server" id="txtNomDF" CssClass="input1" Enabled="False" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="c1g">FECHA DE<br />NACIMIENTO:</td> 
                    <td class="c1b"><asp:TextBox runat="server" id="txtFNacDF" CssClass="input1" Enabled="False" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="c1g">DIRECCIÓN:</td> 
                    <td class="c1b"><asp:TextBox runat="server" id="txtDirDF" CssClass="input1" Enabled="False" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="c1g">EMAIL:</td> 
                    <td class="c1b"><asp:TextBox runat="server" id="txtEmailDF" CssClass="input1"></asp:TextBox></td>
                   <td><img src="../../Recursos/Imagenes/editar.PNG" /></td>
                </tr>
                <tr>
                    <td class="c1g">TELÉFONO:</td> 
                    <td class="c1b"><asp:TextBox runat="server" id="txtTelefonoDF" CssClass="input1"></asp:TextBox></td>
                    <td><img src="../../Recursos/Imagenes/editar.PNG" /></td>
                </tr>
                <tr>
                    <td class="c1g">CLASE DE<br />LICENCIA:</td> 
                    <td class="c1b"><asp:TextBox runat="server" id="txtClaseLicDF" Enabled="False" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="c1g">CONTRASEÑA:</td> 
                    <td class="c1b">
                        <asp:Button id="btnModificaPassDF" CssClass="boton" runat="server" 
                            Text="MODIFICAR" onclick="btnModificaPassDF_Click" /></td>
                </tr>
            </table>
            <div><br /></div>  
            <div><br /></div>  
            

            <table id="tblPassDF" runat="server" style="display:none" width="70%">
                 <tr>
                     <td class="c3g" colspan="2">GENERE SU NUEVA CONTRASEÑA</td>
                 </tr>
                 <tr>
                    <td class="ctxt2" >
                        <asp:TextBox runat="server" id="txtCambiaPass1DF" CssClass="input1" TextMode="Password" />
                        <h5 style="margin:auto">*Ingrese nueva contraseña</h5>

                    </td>
                    <td class="ctxt2">
                       <asp:TextBox runat="server" id="txtCambiaPassDF" CssClass="input1" TextMode="Password" />
                        <h5 style="margin:auto">*Confirme nueva contraseña</h5>
                    </td>
                </tr>
             </table>
             <div><br /></div>
             <table style="margin: 0 auto;">
                <tr>
                    <td><asp:Button ID="btnGuardarDF" CssClass="boton" runat="server" Text="GUARDAR" /></td>
                </tr>
             </table>
          </div>  
        </form>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Infractor/MPInfractor.master" AutoEventWireup="true" CodeBehind="datosInfractor.aspx.cs" Inherits="systemsri.Vistas.Infractor.datosInfractor" %>
 <%@ OutputCache Location="None" NoStore="true"%>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoAdmin" runat="server">
    <form id="formDatosInfractor" runat="server">
         <div class="alinInicial">
           <h2>Datos Personales</h2>

              <table style="width: 70%">
                <tr>
                    <td class="c1g">RUT:</td> 
                    <td class="c1b"> <asp:TextBox runat="server" id="txtRutDI" CssClass="input1" Enabled="False" ></asp:TextBox></td>
                </tr>
                <tr>
                <!-- Se integrarán todos los nombres para solo informacion-->
                    <td class="c1g">NOMBRE:</td> 
                    <td class="c1b"><asp:TextBox runat="server" id="txtNomDI" CssClass="input1" Enabled="False" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="c1g">FECHA DE<br />NACIMIENTO:</td> 
                    <td class="c1b"><asp:TextBox runat="server" id="txtFNacDI" CssClass="input1" Enabled="False" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="c1g">DIRECCIÓN:</td> 
                    <td class="c1b"><asp:TextBox runat="server" id="txtDirDI" CssClass="input1" Enabled="False" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="c1g">EMAIL:</td> 
                    <td class="c1b">
                     <asp:TextBox runat="server" id="txtEmailDI" CssClass="input1" 
                            Enabled="False" MaxLength="70"></asp:TextBox></td>
                           
                   <td>
                   
                       <asp:ImageButton ID="ImageEmail" runat="server" Height="24px" 
                           ImageUrl="~/Recursos/Imagenes/editar.PNG"  
                           Width="24px" onclick="ImageEmail_Click" />
                                          
                    </td>

                </tr>
              
                <tr>
                    <td class="c1g">TELÉFONO:</td> 
                    <td class="c1b">
                        <asp:TextBox runat="server" id="txtTelefonoDI" CssClass="input1" 
                            Enabled="False" MaxLength="15"></asp:TextBox></td>
                    <td>
                        <asp:ImageButton ID="ImageTelefono" runat="server" 
                            ImageUrl="~/Recursos/Imagenes/editar.PNG" onclick="ImageTelefono_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="c1g">CLASE DE<br />LICENCIA:</td> 
                    <td class="c1b"><asp:TextBox runat="server" id="txtClaseLicDI" Enabled="False" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="c1g">CONTRASEÑA:</td> 
                    <td class="c1b">
                        <asp:Button id="btnModificaPassDI" CssClass="boton" runat="server" 
                            Text="MODIFICAR" onclick="btnModificaPassDI_Click" /></td>
                </tr>
            </table>
                <br/>
                  <asp:Label ID="lblInfoDI" runat="server" CssClass="lbl" 
                    Text="label" Visible="False" 
                    Font-Underline="False" />
                <br/> 

            <table id="tblPassDI" runat="server" width="70%">
                 <tr>
                     <td class="c3g" colspan="2">GENERE SU NUEVA CONTRASEÑA</td>
                 </tr>
                 <tr>
                    <td class="ctxt2" >
                        <asp:TextBox runat="server" id="txtCambiaPassDI1" CssClass="input1" 
                            TextMode="Password" MaxLength="25"  />
                        <h5 style="margin:auto">*Ingrese nueva contraseña</h5>

                    </td>
                    <td class="ctxt2">
                       <asp:TextBox runat="server" id="txtCambiaPassDI2" CssClass="input1" 
                            TextMode="Password" MaxLength="25"  />
                        <h5 style="margin:auto">*Confirme nueva contraseña</h5>
                    </td>
                </tr>
             </table>
          <br/>
             <table style="margin: 0 auto;">
                <tr>
                    <td><asp:Button ID="btnGuardarDI" CssClass="boton" runat="server" Text="GUARDAR" 
                            onclick="btnGuardarDI_Click" /></td>
                </tr>
             </table>
             </div>
        </form>
</asp:Content>
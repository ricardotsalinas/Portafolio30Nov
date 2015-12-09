<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Inspector/MPInspector.master" AutoEventWireup="true" CodeBehind="datosInspector.aspx.cs" Inherits="systemsri.Vistas.Inspector.datosInspector" %>
 <%@ OutputCache Location="None" NoStore="true"%>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoAdmin" runat="server">
    <form id="formDatosInfractor" runat="server">
         <div class="alinInicial">
             <h2>Datos Personales</h2>
            <asp:Label ID="lblInfoDI" runat="server" CssClass="lbl" Text="label" Visible="False" 
                    Font-Underline="False" />

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
                    <td class="c1g">DIRECCIÓN:</td> 
                    <td class="c1b"><asp:TextBox runat="server" id="txtDirDIn" CssClass="input1" Enabled="False" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="c1g">EMAIL:</td> 
                    <td class="c1b"><asp:TextBox runat="server" id="txtEmailDIn" CssClass="input1"  
                            Enabled="False" MaxLength="70" ></asp:TextBox></td>
                    <td>
                   
                       <asp:ImageButton ID="imgTEmailDI" runat="server" Height="24px" 
                           ImageUrl="~/Recursos/Imagenes/editar.PNG"  
                           Width="24px" onclick="ImageEmail_Click" />
                                          
                    </td>

                </tr>
                <tr>
                    <td class="c1g">TELÉFONO:</td> 
                    <td class="c1b"><asp:TextBox runat="server" id="txtTelefonoDIn" CssClass="input1"  
                            Enabled="False" MaxLength="15"></asp:TextBox></td>
                    <td>
                        <asp:ImageButton ID="imgTelefonoDI" runat="server" 
                        ImageUrl="~/Recursos/Imagenes/editar.PNG" onclick="ImageTelefono_Click" />
                    </td>
                </tr>
               
                <tr>
                    <td class="c1g">CONTRASEÑA:</td> 
                    <td class="c1b">
                        <asp:Button id="btnModificaPassDIn" CssClass="boton" runat="server" 
                            Text="MODIFICAR" onclick="btnModificaPassDIn_Click" /></td>
                </tr>
            </table>
               <asp:Label ID="lblInfoDIn" runat="server" CssClass="lbl" Text="label" Visible="False" 
                    Font-Underline="False" />
                <br/> 

             <br/>
               <table id="tblPassDIn" runat="server" width="70%">
                 <tr>
                     <td class="c3g" colspan="2">GENERE SU NUEVA CONTRASEÑA</td>
                 </tr>
                 <tr>
                    <td class="ctxt2" >
                        <asp:TextBox runat="server" id="txtCambiaPassDIn1" CssClass="input1" 
                            TextMode="Password" MaxLength="25"  />
                        <h5 style="margin:auto">*Ingrese nueva contraseña</h5>

                    </td>
                    <td class="ctxt2">
                       <asp:TextBox runat="server" id="txtCambiaPassDIn2" CssClass="input1" 
                            TextMode="Password" MaxLength="25"  />
                        <h5 style="margin:auto">*Confirme nueva contraseña</h5>
                    </td>
                </tr>
             </table>
             <table style="margin: 0 auto;">
                <tr>
                    <td><asp:Button ID="btnGuardarDIn" CssClass="boton" runat="server" Text="GUARDAR" 
                            onclick="btnGuardarDIn_Click" /></td>
                </tr>
             </table>
          </div>  
        </form>
</asp:Content>

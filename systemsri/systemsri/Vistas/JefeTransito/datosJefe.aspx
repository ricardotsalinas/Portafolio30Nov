<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/JefeTransito/MPJefe.master" AutoEventWireup="true" CodeBehind="datosJefe.aspx.cs" Inherits="systemsri.Vistas.JefeTransito.datosJefe" %>
 <%@ OutputCache Location="None" NoStore="true"%>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoAdmin" runat="server">
<form id="formDatosInfractor" runat="server">
         <div class="alinInicial">
             <h2>Datos Personales</h2>

              <table style="width: 70%">
                <tr>
                    <td class="c1g">RUT:</td> 
                    <td class="c1b"> <asp:TextBox runat="server" id="txtRutDJ" CssClass="input1" Enabled="False" ></asp:TextBox></td>
                </tr>
                <tr>
                <!-- Se integrarán todos los nombres para solo informacion-->
                    <td class="c1g">NOMBRE:</td> 
                    <td class="c1b"><asp:TextBox runat="server" id="txtNomDJ" CssClass="input1" Enabled="False" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="c1g">DIRECCIÓN:</td> 
                    <td class="c1b"><asp:TextBox runat="server" id="txtDirDJ" CssClass="input1" Enabled="False" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="c1g">EMAIL:</td> 
                    <td class="c1b"><asp:TextBox runat="server" id="txtEmailDJ" CssClass="input1" Enabled="False"></asp:TextBox></td>
                   <td>
                        <asp:ImageButton ID="imgEmailDJ" runat="server" 
                            ImageUrl="~/Recursos/Imagenes/editar.PNG" onclick="ImageEmail_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="c1g">TELÉFONO:</td> 
                    <td class="c1b"><asp:TextBox runat="server" id="txtTelefonoDJ" CssClass="input1" Enabled="False"></asp:TextBox></td>
                   <td>
                        <asp:ImageButton ID="imgTelefonoDJ" runat="server" 
                            ImageUrl="~/Recursos/Imagenes/editar.PNG" onclick="imgTelefonoDJ_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="c1g">CONTRASEÑA:</td> 
                    <td class="c1b">
                        <asp:Button id="btnModificaPassDJ" CssClass="boton" runat="server" 
                            Text="MODIFICAR" onclick="btnModificaPassDJ_Click" /></td>
                </tr>
            </table>
             <br/>
           <asp:Label ID="lblInfoDJ" runat="server" CssClass="lbl" Text="label" Visible="False" 
                    Font-Underline="False" />
                <br/> </div>  

            <table id="tblPassDJ" runat="server"  width="70%">
                 <tr>
                     <td class="c3g" colspan="2">GENERE SU NUEVA CONTRASEÑA</td>
                 </tr>
                 <tr>
                    <td class="ctxt2" >
                        <asp:TextBox runat="server" id="txtCambiaPassDJ1" CssClass="input1" TextMode="Password"  />
                        <h5 style="margin:auto">*Ingrese nueva contraseña</h5>

                    </td>
                    <td class="ctxt2">
                       <asp:TextBox runat="server" id="txtCambiaPassDJ2" CssClass="input1" TextMode="Password"  />
                        <h5 style="margin:auto">*Confirme nueva contraseña</h5>
                    </td>
                </tr>
             </table>
             <div><br /></div>
             <table style="margin: 0 auto;">
                <tr>
                    <td><asp:Button ID="btnGuardarDJ" CssClass="boton" runat="server" Text="GUARDAR" 
                            onclick="btnGuardarDJ_Click" /></td>
                </tr>
             </table>
          
        </form>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Administrador/MPAdministrador.master" AutoEventWireup="true" CodeBehind="DatosAdmin.aspx.cs" Inherits="systemsri.Vistas.Administrador.DatosAdmin" %>
 <%@ OutputCache Location="None" NoStore="true"%>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoAdmin" runat="server">

     <form id="formDatosAdmin" runat="server">
         <div class="alinInicial">
             <h2>Datos Personales</h2>
             <asp:Label ID="lblInfoDA" runat="server" Visible="False" CssClass="lbl"></asp:Label>
                   
               <table id="tblPassDA" runat="server" width="70%">
                 <tr>
                     <td class="c3g" colspan="2">GENERE SU NUEVA CONTRASEÑA</td>
                 </tr>
                 <tr>
                    <td class="ctxt2" >
                        <asp:TextBox runat="server" id="txtCambiaPass1DA" CssClass="input1" 
                            TextMode="Password" MaxLength="25" 
                            ontextchanged="txtCambiaPass1DA_TextChanged"  />
                        <h5 style="margin:auto">*Ingrese nueva contraseña</h5>

                    </td>
                    <td class="ctxt2">
                       <asp:TextBox runat="server" id="txtCambiaPass2DA" CssClass="input1" 
                            TextMode="Password" MaxLength="25"  />
                        <h5 style="margin:auto">*Confirme nueva contraseña</h5>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                </tr>
                   
             </table>
             
             <table style="margin: 0 auto;">
                <tr>
                    <td><asp:Button ID="btnGuardarDA" CssClass="boton" runat="server" Text="GUARDAR" 
                            onclick="btnGuardarDA_Click" /></td>
                </tr>
             </table>
          </div>  
        </form>



</asp:Content>

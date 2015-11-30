<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/JefeTransito/MPJefe.master" AutoEventWireup="true" CodeBehind="ConfigRestriciones.aspx.cs" Inherits="systemsri.Vistas.JefeTransito.ConfigRestriciones" %>
 <%@ OutputCache Location="None" NoStore="true"%>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoAdmin" runat="server">
   <form id="contact_form" runat="server">
           <div class="alinInicial"> 
             <h2 >Configurar Restricciones</h2>
            <table>
                <tr>
                    <td  class="ctxt">En este apartado se configura la condicion para prohibición temporal o permanente </td>
                </tr>
            </table>
            <table style="font-family:Arial; font-size:small">
                <tr>
                    <td><asp:Panel ID="pnlTipoProh" runat="server">Tipo de Prohibición<br />
                        &nbsp;<asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="46px" 
                            onselectedindexchanged="RadioButtonList1_SelectedIndexChanged">
                            <asp:ListItem>Temporal</asp:ListItem>
                            <asp:ListItem>Permanente</asp:ListItem>
                        </asp:RadioButtonList>
                        </asp:Panel></td>
                </tr>               
            </table>
               <h3 style="font-style:italic">Limite Cantidad de Multas por gravedad</h3>
            <table style="font-family:Arial; font-size:small">
                <tr>
                   <td> Gravísima </td><td><input type="text" class="input4" id="txtGravisimaCR"/></td>
                   
                </tr>
                <tr>
                    <td>Grave </td><td><input type="text" class="input4" id="txtGraveCR"/></td>
                  
                </tr>
                 <tr>
                    <td>Leve </td><td><input type="text" class="input4" id="txtLeveCR"/></td>
                   
                </tr>
               <tr><td> Por lo tanto se consideran </td><td><asp:Label runat="server" id="lblPuntosLeve" Text="0"/> Puntos para la prohibición definida</td>
                 </tr>
                 <tr> 
                   <td class="cbtn"><asp:Button ID="btnGenerarRestrCR" class="boton" runat="server" 
                           Text="GENERAR" onclick="btnGenerarRestrCR_Click" /></td>

                </tr>
            </table>
                <h5 style="font-style:italic; text-align:center">Para el caso de las multas impagas, se considera una tolerancia de hasta 60 días a partir de la última multa,<br/>
                   de lo contrario, la multa se considera impaga y la prohibición será PERMANENTE</h5>    
           </div> 
        </form> 

</asp:Content>

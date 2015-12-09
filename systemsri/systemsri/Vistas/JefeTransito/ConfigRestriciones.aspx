<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/JefeTransito/MPJefe.master" AutoEventWireup="true" CodeBehind="ConfigRestriciones.aspx.cs" Inherits="systemsri.Vistas.JefeTransito.ConfigRestriciones" %>
 <%@ OutputCache Location="None" NoStore="true"%>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoAdmin" runat="server">
   <form id="contact_form" runat="server">
           <div class="alinInicial"> 
             <h2 >Configurar Restricciones</h2>
             <asp:Label runat="server" ID="lblInfoCR" CssClass="lbl" Visible="false"></asp:Label>


            <table>
                <tr>
                    <td  class="ctxt">En este apartado se configura la condicion para prohibición temporal o permanente </td>
                </tr>
            </table>
            <table style="font-family:Arial; font-size:small; width: 360px;">
                <tr>
                    <td style="width: 84px">Tipo de Prohibición<br />
                        &nbsp;
                        </a>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="46px" 
                            onselectedindexchanged="RadioButtonList1_SelectedIndexChanged" 
                            Width="127px" AutoPostBack="True">
                            <asp:ListItem>Temporal</asp:ListItem>
                            <asp:ListItem>Permanente</asp:ListItem>
                        </asp:RadioButtonList>
                       </td>
                       <td style="width: 111px">&nbsp;<asp:Panel ID="Panel1" runat="server" Height="62px" 
                               Width="217px" Visible="False">
                           La prohibición será establecida en:<br />&nbsp;
                           <asp:TextBox ID="txtDiasTempCR" runat="server" ontextchanged="TextBox1_TextChanged" 
                               style="margin-bottom: 0px" Width="61px"></asp:TextBox> &nbsp;días</asp:Panel>
                    </td><td>&nbsp;</td>
                </tr>               
            </table>
               <h3 style="font-style:italic">Límite Cantidad de Multas por gravedad</h3>
            <table style="font-family:Arial; font-size:small">
                <tr>
                   <td style="height: 26px"> Gravísima </td><td style="height: 26px">
                    <asp:TextBox runat="server"  ID="txtGravisimaCR" AutoPostBack="True" 
                        ontextchanged="txtGravisimaCR_TextChanged" CssClass="input4" ></asp:TextBox></td>
                   
                </tr>
                <tr>
                    <td>Grave </td><td><asp:TextBox runat="server" ID="txtGraveCR" 
                        AutoPostBack="True" ontextchanged="txtGraveCR_TextChanged" CssClass="input4"></asp:TextBox></td>
                  
                </tr>
                 <tr>
                    <td>Leve </td><td><asp:TextBox runat="server" ID="txtLeveCR" AutoPostBack="True" 
                         ontextchanged="txtLeveCR_TextChanged" CssClass="input4" ></asp:TextBox></td>
                   
                </tr>
               <tr><td> Por lo tanto se consideran&nbsp; </td><td><asp:Label runat="server" id="lblPuntosLeve" Text="0"/> &nbsp; Puntos para la prohibición definida</td>
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

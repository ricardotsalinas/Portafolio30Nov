<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/JefeTransito/MPJefe.master" AutoEventWireup="true" CodeBehind="CasosApelacion.aspx.cs" Inherits="systemsri.Vistas.JefeTransito.CasosApelacion" %>
 <%@ OutputCache Location="None" NoStore="true"%>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoAdmin" runat="server">
        <form id="formIngresaMulta" runat="server">
             <div class="alinInicial">
                 <h2 >Casos Apelaciones</h2>
               
              <table>
                 <tr>
                    <td class="c5g">NOMBRE:</td> 
                    <td class="c5b"><asp:Label id="lblNomCA" runat="server" CssClass="input1" Text="Prueba"/></td>
                    <td style="width:2%"></td>
                    <td class="c5g">CODIGO MULTA:</td> 
                    <td class="c5b"><asp:Label runat="server" id="lblCodMulCA" CssClass="input1" Text="Prueba" /></td>
                 </tr>
                 <tr>                    
                    <td class="c5g">RUT:</td> 
                    <td class="c5b"><asp:Label id="lblRutCA" runat="server" CssClass="input1" Text="Prueba" /></td>
                    <td style="width:2%"></td>
                    <td class="c5g">GRAVEDAD:</td> 
                    <td class="c5b"><asp:Label runat="server" id="lblGravCA" CssClass="input1" Text="Prueba" /></td>
                 </tr>
                 <tr>
                    <td class="c5g">EDAD:</td> 
                    <td class="c5b"><asp:Label runat="server" id="lblEdadCA" CssClass="input1" Text="Prueba" /></td>
                    <td style="width:2%"></td>
                     <td class="c5g">VALOR:</td> 
                    <td class="c5b"><asp:Label runat="server" id="lblValorCA" CssClass="input1" Text="Prueba" /></td>
                 </tr>
                 <tr>
                    <td class="c5g">DIRECCIÓN:</td> 
                    <td class="c5b"><asp:Label runat="server" id="lbldirCA" CssClass="input1" Text="Prueba"/></td>
                    <td style="width:2%"></td>
                    <td class="c5g">MONTO EN PESOS:</td> 
                    <td class="c5b"><asp:Label runat="server" id="lblMontoPesosCA" CssClass="input1" Text="Prueba" /></td>
                    <td style="width:2%"></td>
                 </tr>
                 <tr>
                    <td class="c5g">EMAIL:</td> 
                    <td class="c5b"><asp:Label runat="server" id="lblEmailCA" CssClass="input1" Text="Prueba"/></td>
                    <td style="width:2%"></td>
                    <td class="c5g">FECHA MULTA:</td> 
                    <td class="c5b"><asp:Label id="lblFechaMultaCA" runat="server" CssClass="input1" Text="Prueba"/></td>
                 </tr>
                 <tr>
                <td class="c5g">TELÉFONO:</td> 
                    <td class="c5b"><asp:Label runat="server" id="txtDetCompletoCA" CssClass="input1" Text="Prueba"/></td>
                             <td style="width:2%"></td>
                <td class="c5g">HORA MULTA:</td> 
                    <td class="c5b"><asp:Label runat="server" id="lblHoraMultaCA" CssClass="input1" Text="Prueba"/></td>
              </tr>
              
              <tr>
                <td class="c5g">CLASE LICENCIA:</td> 
                    <td class="c5b">
                        <asp:Label runat="server" id="lblClaseLicCA" CssClass="input1" Text="Prueba"/></td>
                             <td style="width:2%"></td>
                            <td class="c5g">MOTIVO MULTA:</td> 
                    <td class="c5b"><asp:Label runat="server" id="lblMotMultaCA" CssClass="input1" Text="Prueba"/></td>
              </tr>
              
              <tr>
                <td class="c5g">PATENTE:</td> 
                    <td class="c5b">
                        <asp:Label runat="server" id="lblPatCA" CssClass="input1" Text="Prueba"/></td>
                             <td style="width:2%"></td>
                            <td class="c5g">LUGAR INFRACCION:</td> 
                    <td class="c5b"><asp:Label runat="server" id="lblLugarInfrCA" CssClass="input1" Text="Prueba"/></td>
              </tr>
              
              <tr>
                <td class="c5g">INFRACTOR:</td> 
                    <td class="c5b"><asp:Label runat="server" id="Label6" CssClass="input1" Text="Prueba"/></td>
                             <td style="width:2%"></td>
                <td class="c5g">ESTADO MULTA:</td> 
                    <td class="c5b"><asp:Label runat="server" id="lblEstadoMultaCA" CssClass="input1" Text="Prueba"/></td>
              </tr>
              </table>
              <table>
              <tr><td></td></tr>
                   <tr>
                    <td class="c3g">MENSAJE APELACIÓN:</td> 
                    <td class="c3b"><asp:TextBox ID="txtMjeApelCA" runat="server" CssClass="input2" 
                            Text="Prueba" Enabled="false" Font-Names="Arial" 
                            ontextchanged="txtMjeApelCA_TextChanged" TextMode="MultiLine"/>
                    </td>  
                    <td> <asp:Button ID="btnGuardarCA"  CssClass="boton" runat="server" Text="VER ADJUNTO"   onclick="btnGuardarCA_Click" />
                    </td>        
                    </tr>   
                    </table>
                    <table >
                    <tr align="right">
                    <td><h2>Resolución  Apelación</h2> </td></tr> 
                    </table>

                 <table><tr><td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server"
                     onselectedindexchanged="RadioButtonList1_SelectedIndexChanged" 
                     Font-Names="Arial" Font-Size="Small" Width="98px">
                     <asp:ListItem Value="Aprobar">Aprobar</asp:ListItem>
                     <asp:ListItem>Rechazar</asp:ListItem>
                 </asp:RadioButtonList>
                 </td>
                 <td style="font-family:Arial">
                 
                     <asp:Panel ID="pnlRebaja" runat="server" Height="49px" style="margin-top: 0px" Width="378px">
                         Rebaja: <asp:TextBox ID="txtRebajaCA" runat="server" CssClass="input4"></asp:TextBox>
                         Monto Final: <asp:TextBox ID="txtMontoFinalCA" runat="server" CssClass="input4" Enabled="false"></asp:TextBox>
                     </asp:Panel>
                 
                 </td>
                 </tr>
                 </table>
                <table>
                <tr>
                <td>
                  <h2 >Comentario</h2>
                </td>
                </tr>
                <tr><td style="width:600px">
                  <asp:TextBox ID="txtComentarioCA" runat="server" CssClass="input2" Placeholder="Ingrese Comentario Aquí" Font-Names="Arial" 
                            ontextchanged="txtMjeApelCA_TextChanged" TextMode="MultiLine"/></td>    
                            <td><asp:Button runat="server" Text="ENVIAR" ID="btnEnviarCA" CssClass="boton" /></td>
                 </tr>
            </table>
                 <br/> <br/>

            
          </div>
        </form>
</asp:Content>

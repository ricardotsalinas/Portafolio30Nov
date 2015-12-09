<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Infractor/MPInfractor.master" AutoEventWireup="true" CodeBehind="detallePagarMulta.aspx.cs" Inherits="systemsri.Vistas.Infractor.detallePagarMulta" %>
 <%@ OutputCache Location="None" NoStore="true"%>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoAdmin" runat="server">

    <form id="form1" runat="server">
<div class="alinInicial">    
                 <h2 >Pagar o Apelar a Multa&nbsp; </h2>
                 <asp:Label runat="server" ID="lblInfoDPM" CssClass="lbl" Visible="false"></asp:Label>

               <table width="70%">
                <tr>
                    <td class="c4g">CÓDIGO MULTA:</td> 
                    <td class="c4b"> <asp:Label runat="server" id="lblCodMultaDMI" CssClass="input1" 
                            Text=" " /></td>
                </tr>
                <tr>
                
                    <td class="c4g">RUT:</td> 
                    <td class="c4b">
                        <asp:Label ID="lblRutDPM" runat="server" Text=" "></asp:Label>
                    </td>
                </tr>
                <tr>
                
                    <td class="c4g">NOMBRE:&nbsp;</td> 
                    <td class="c4b">
                        <asp:Label ID="lblNombreDPM" runat="server" Text=" "></asp:Label>
                    </td>
                </tr>
                <tr>
                
                    <td class="c4g">PATENTE:</td> 
                    <td class="c4b">
                        <asp:Label ID="lblPatDPM" runat="server" Text=" "></asp:Label>
                    </td>
                </tr>
                <tr>
                
                    <td class="c4g">GRAVEDAD:</td> 
                    <td class="c4b"><asp:Label runat="server" id="lblGravDMI" CssClass="input1" 
                            Text=" " /></td>
                </tr>
                <tr>
                    <td class="c4g">MONTO:</td> 
                    <td class="c4b">$ <asp:Label runat="server" id="lblMontoDMI" CssClass="input1" Text=" " /></td>
                </tr>
                <tr>
                    <td class="c4g">FECHA MULTA:</td> 
                    <td class="c4b"><asp:Label runat="server" id="lblFecMultaDMI" CssClass="input1" Text=" " /></td>
                </tr>
                <tr>
                    <td class="c4g">HORA MULTA:</td> 
                    <td class="c4b"><asp:Label runat="server" id="lblHoraMultaDMI" CssClass="input1"  Text=" "/></td>
                   
                </tr>
                <tr>
                    <td class="c4g">MOTIVO MULTA:</td> 
                    <td class="c4b"><asp:Label runat="server" id="lblMotivoMultaDMI" CssClass="input1"  Text=" "/></td>
                   
                </tr>
                <tr>
                    <td class="c4g">DETALLE ADICIONAL:</td> 
                    <td class="c4b"><asp:Label runat="server" id="lblDetAdicDMI"  CssClass="input1" Text=" " /></td>
                </tr>
                <tr>
                    <td class="c4g">LUGAR INFRACCIÓN:</td> 
                    <td class="c4b"><asp:Label id="lblLugarInfrDMI" runat="server"  CssClass="input1" Text=" "/></td>
                </tr>
                              <tr>
                    <td>   <asp:Button id="btnPagarDPM" CssClass="boton" runat="server" 
                      Text="PAGAR" onclick="btnPagarDPM_Click1" /> 
                    </td>
             </tr>
             <tr>
                <td colspan="2">
                
                    <asp:Label ID="noPuedeApelar" runat="server" Text="" Visible="False" CssClass="lbl"></asp:Label>
                
                </td>
             </tr>
           </table>
                  
               
    <asp:Panel ID="Panel1" runat="server" Enabled="False" Visible="False">
    
              <table>

            <tr><td class="ctxt"> Si desea apelar a esta multa, puede ingresar el motivo (250 caracteres máximo)</td></tr>
            
            <tr><td><asp:TextBox id="txtApelDPM" runat="server" CssClass="input2" 
                    MaxLength="250" TextMode="MultiLine" /></td></tr>
            <tr><td><asp:FileUpload ID="FileUpload1" runat="server" /></td></tr>
            <tr>
                    <td class="ctxt"> 
                    Una vez que la situación sea estudiada por el encargado, llegará la información a su correo.
                            
                    </td>
               </tr>
               <tr>
                    <td align=right>
                         <asp:Button ID="btnEnviarDPM" runat="server" onclick="btnEnviarDPM_Click" Text="ENVIAR" 
                            CssClass="boton" />
                    </td>
               </tr>
            
            </table>
    
            </asp:Panel>



        
        </div>
    </form>
</asp:Content>

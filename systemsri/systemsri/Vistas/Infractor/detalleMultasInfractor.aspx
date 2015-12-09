<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Infractor/MPInfractor.master" AutoEventWireup="true" CodeBehind="detalleMultasInfractor.aspx.cs" Inherits="systemsri.Vistas.Infractor.Formulario_web1" %>
 <%@ OutputCache Location="None" NoStore="true"%>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoAdmin" runat="server">
    <form id="form1" runat="server">
      <div class="alinInicial">

                    <h2 >Detalles de Multa</h2>
                   <table style="width: 70%">
                <tr>
                    <td class="c4g">CÓDIGO MULTA:</td> 
                    <td class="c4b"> <asp:Label runat="server" id="txtCodMultaDMI" CssClass="input1"  
                            Text=" "/></td>
                </tr>
                <tr>
                    <td class="c4g">RUT:&nbsp;</td> 
                    <td class="c4b">
                        <asp:Label ID="lblRutDMI" runat="server" Text=" "></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="c4g">NOMBRE:</td> 
                    <td class="c4b">
                        <asp:Label ID="lblNombreDMI" runat="server" Text=" "></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="c4g">PATENTE:</td> 
                    <td class="c4b">
                        <asp:Label ID="lblPatDMI" runat="server" Text=" "></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="c4g">GRAVEDAD:</td> 
                    <td class="c4b"><asp:Label runat="server" id="txtGravDMI" CssClass="input1"  
                            Text=" " /></td>
                </tr>
                <tr>
                    <td class="c4g">MONTO:</td> 
                    <td class="c4b"><asp:Label runat="server" id="txtMontoDMI" CssClass="input1" 
                            Text=" " /></td>
                </tr>
                <tr>
                    <td class="c4g">FECHA MULTA:</td> 
                    <td class="c4b"><asp:Label runat="server" id="txtFecMultaDMI" CssClass="input1" 
                            Text=" "  /></td>
                </tr>
                <tr>
                    <td class="c4g">HORA MULTA:</td> 
                    <td class="c4b"><asp:Label runat="server" id="txtHoraMultaDMI" CssClass="input1" 
                            Text=" " /></td>
                   
                </tr>
                <tr>
                    <td class="c4g">MOTIVO MULTA:</td> 
                    <td class="c4b"><asp:Label runat="server" id="txtMotivoMultaDMI" CssClass="input1" 
                            Text=" " /></td>
                   
                </tr>
                <tr>
                    <td class="c4g">DETALLE ADICIONAL:</td> 
                    <td class="c4b"><asp:Label runat="server" id="txtDetAdicDMI"  CssClass="input1" 
                            Text=" " /></td>
                </tr>
                <tr>
                    <td class="c4g">LUGAR INFRACCIÓN:</td> 
                    <td class="c4b"><asp:Label  id="txtLugarInfrDMI" runat="server"  CssClass="input1" 
                            Text=" " /></td>
                </tr>

            </table>
            </div>
    </form>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Funcionario/MPFuncionario.master"
AutoEventWireup="true" CodeBehind="pagarFun.aspx.cs" Inherits="systemsri.Vistas.Funcionario.pagarFun" %>

<%@ OutputCache Location="None" NoStore="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoAdmin" runat="server">
        <form id="formAdminCalles" runat="server">
    <div class="alinInicial">
        <h2>
            Pagar</h2>
        <asp:Label runat="server" ID="lblInfoPF" Text="" CssClass="input1" Visible="false" />
        <table>
            <tr>
                <td class="c1g" style="height: 36px">
                    NOMBRE:
                </td>
                <td class="c1b" style="height: 36px">
                    <asp:Label ID="lblNombrePF" runat="server" CssClass="input1" Font-Names="Arial" 
                        Font-Size="Small"/>
                </td>
            </tr>
            <tr>
                <td class="c1g">
                    RUT:
                </td>
                <td class="c1b">
                    <asp:Label ID="lblRutPF" runat="server" CssClass="input1" Font-Names="Arial" 
                        Font-Size="Small" />
                </td>
            </tr>
            <tr>
                <td class="c1g">
                    MONTO:
                </td>
                <td class="c1b">
                    $<asp:Label ID="lblMontoPF" runat="server" CssClass="input1" Font-Names="Arial" Font-Size="Small"/>
                </td>
            </tr>
            <tr>
                <td class="c1g">
                    FECHA MULTA:
                </td>
                 <td class="c1b">
                    <asp:Label ID="lblFechaPagoPF" runat="server" CssClass="input1" Font-Names="Arial" Font-Size="Small"/>
                </td>
            </tr>
            <tr>
                <td class="c1g">
                    TIPO DE PAGO:
                </td>
                <td class="c1b">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" Font-Names="Arial" 
                        Font-Size="Small" Width="201px" CssClass="c1b" AutoPostBack="True" 
                        onselectedindexchanged="RadioButtonList1_SelectedIndexChanged">
                        <asp:ListItem Value="0">Por Caja</asp:ListItem>
                        <asp:ListItem Value="1">Por Tarjeta</asp:ListItem>
                    </asp:RadioButtonList>
                
                    <asp:Label ID="lblTipoPago" runat="server" Font-Names="Arial"   Visible="false" />
                    <asp:Label ID="lblEstadoPago" runat="server" Font-Names="Arial" Visible="false" />
                    <asp:Label ID="lblNumMulta" runat="server" Font-Names="Arial"    />    
                    </td>
            </tr>
            
        </table>
        <table>
            <tr>
                <td class="cbtn">
                    <asp:Button ID="btnPagarPF" CssClass="boton" runat="server" Text="PAGAR" 
                        OnClick="btnPagarPF_Click" style="height: 26px" />
                </td>
            </tr>
        </table>
        
        


    </div>
    </form>
</asp:Content>

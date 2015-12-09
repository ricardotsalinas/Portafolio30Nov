<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/JefeTransito/MPJefe.master"
    AutoEventWireup="true" CodeBehind="CasosApelacion.aspx.cs" Inherits="systemsri.Vistas.JefeTransito.CasosApelacion" %>

<%@ OutputCache Location="None" NoStore="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoAdmin" runat="server">
    <form id="formIngresaMulta" runat="server">
    <div class="alinInicial">
        <h2>
            Casos Apelaciones<asp:TextBox 
                ID="txtAdjunto" runat="server" Enabled="False" Visible="False"></asp:TextBox>
        </h2>
        <table>
            <tr>
                <td class="c5g">
                    NOMBRE:
                </td>
                <td class="c5b">
                    <asp:Label ID="lblNomCA" runat="server" CssClass="input1" Text="No Tiene" />
                </td>
                <td style="width: 2%">
                </td>
                <td class="c5g">
                    CODIGO MULTA:
                </td>
                <td class="c5b">
                    <asp:Label runat="server" ID="lblCodMulCA" CssClass="input1" Text="No Tiene" />
                </td>
            </tr>
            <tr>
                <td class="c5g">
                    RUT:
                </td>
                <td class="c5b">
                    <asp:Label ID="lblRutCA" runat="server" CssClass="input1" Text="No Tiene" />
                </td>
                <td style="width: 2%">
                </td>
                <td class="c5g">
                    GRAVEDAD:
                </td>
                <td class="c5b">
                    <asp:Label runat="server" ID="lblGravCA" CssClass="input1" Text="No Tiene" />
                </td>
            </tr>
            <tr>
                <td class="c5g">
                    DIRECCIÓN:
                </td>
                <td class="c5b">
                    <asp:Label runat="server" ID="lbldirCA" CssClass="input1" Text="No Tiene" />
                </td>
                <td style="width: 2%">
                </td>
                <td class="c5g">
                    VALOR:
                </td>
                <td class="c5b">
                    <asp:Label runat="server" ID="lblValorCA" CssClass="input1" Text="No Tiene" />
                </td>
            </tr>
            <tr>
                <td class="c5g">
                    EMAIL:
                </td>
                <td class="c5b">
                    <asp:Label runat="server" ID="lblEmailCA" CssClass="input1" Text="No Tiene" />
                </td>
                <td style="width: 2%">
                </td>
                <td class="c5g">
                    MONTO EN PESOS:
                </td>
                <td class="c5b">
                    <asp:Label runat="server" ID="lblMontoPesosCA" CssClass="input1" Text="No Tiene" />
                </td>
                <td style="width: 2%">
                </td>
            </tr>
            <tr>
                <td class="c5g">
                    TELÉFONO:
                </td>
                <td class="c5b">
                    <asp:Label runat="server" ID="txtDetCompletoCA" CssClass="input1" Text="No Tiene" />
                </td>
                <td style="width: 2%">
                </td>
                <td class="c5g">
                    FECHA MULTA:
                </td>
                <td class="c5b">
                    <asp:Label ID="lblFechaMultaCA" runat="server" CssClass="input1" Text="No Tiene" />
                </td>
            </tr>
            <tr>
                <td class="c5g">
                    CLASE LICENCIA:
                </td>
                <td class="c5b">
                    <asp:Label runat="server" ID="lblClaseLicCA" CssClass="input1" Text="No Tiene" />
                </td>
                <td style="width: 2%">
                </td>
                <td class="c5g">
                    HORA MULTA:
                </td>
                <td class="c5b">
                    <asp:Label runat="server" ID="lblHoraMultaCA" CssClass="input1" Text="No Tiene" />
                </td>
            </tr>
            <tr>
                <td class="c5g">
                    INFRACTOR:
                </td>
                <td class="c5b">
                    <asp:Label runat="server" ID="Label6" CssClass="input1" Text="No Tiene" />
                </td>
                <td style="width: 2%">
                </td>
                <td class="c5g">
                    MOTIVO MULTA:
                </td>
                <td class="c5b">
                    <asp:Label runat="server" ID="lblMotMultaCA" CssClass="input1" Text="No Tiene" />
                </td>
            </tr>
            <tr>
                <td class="c5g">
                    LUGAR INFRACCION:
                </td>
                <td class="c5b">
                    <asp:Label runat="server" ID="lblLugarInfrCA" CssClass="input1" Text="No Tiene" />
                </td>
                <td style="width: 2%">
                </td>
                <td class="c5g">
                    ESTADO MULTA:
                </td>
                <td class="c5b">
                    <asp:Label runat="server" ID="lblEstadoMultaCA" CssClass="input1" Text="No Tiene" />
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td>
                </td>
            </tr>
            <tr>
                <td class="c3g">
                    MENSAJE APELACIÓN:
                </td>
                <td class="c3b">
                    <asp:TextBox ID="txtMjeApelCA" runat="server" CssClass="input2" Text="No Tiene" Enabled="false"
                        Font-Names="Arial" OnTextChanged="txtMjeApelCA_TextChanged" TextMode="MultiLine" />
                </td>
                <td>
                    <asp:Button ID="btnGuardarCA" CssClass="boton" runat="server" Text="VER ADJUNTO"
                        OnClick="btnGuardarCA_Click" />
                </td>
            </tr>
        </table>
        <table>
            <tr align="right">
                <td>
                    <h2>
                        Resolución Apelación</h2>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged"
                        Font-Names="Arial" Font-Size="Small" Width="98px">
                        <asp:ListItem Value="Aprobar">Aprobar</asp:ListItem>
                        <asp:ListItem>Rechazar</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td style="font-family: Arial">
                    <asp:Panel ID="pnlRebaja" runat="server" Height="49px" Style="margin-top: 0px" Width="378px">
                        Rebaja:
                        <asp:TextBox ID="txtRebajaCA" runat="server" CssClass="input4"></asp:TextBox>
                    </asp:Panel>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td>
                    <h2>
                        Comentario</h2>
                </td>
            </tr>
            <tr>
                <td style="width: 600px">
                    <asp:TextBox ID="txtComentarioCA" runat="server" CssClass="input2" Placeholder="Ingrese Comentario Aquí"
                        Font-Names="Arial" OnTextChanged="txtMjeApelCA_TextChanged" TextMode="MultiLine" />
                </td>
                <td>
                    <asp:Button runat="server" Text="ENVIAR" ID="btnEnviarCA" CssClass="boton" 
                        onclick="btnEnviarCA_Click" />
                </td>
            </tr>
        </table>
        <br />
        <br />
    </div>
    </form>
</asp:Content>

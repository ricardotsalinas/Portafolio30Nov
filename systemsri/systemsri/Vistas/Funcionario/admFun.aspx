<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Funcionario/MPFuncionario.master"
    AutoEventWireup="true" CodeBehind="admFun.aspx.cs" Inherits="systemsri.Vistas.Funcionario.admFun" %>

<%@ OutputCache Location="None" NoStore="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoAdmin" runat="server">
    <form id="formAdmfun" runat="server">
    <div class="alinInicial">
        <h2>
            Administrar Infractor</h2>
        <asp:Label ID="lblInfoAF" runat="server" CssClass="lbl" Text="" Visible="false" />
        <table>
            <tr>
                <td class="c1g">
                    RUT:
                </td>
                <td class="c1b">
                    <asp:TextBox type="text" ID="txtRutAF" runat="server" CssClass="input1" />
                </td>
                <td class="cbtn">
                    <asp:Button ID="btnBuscarAF" class="boton" runat="server" Text="BUSCAR" OnClick="btnBuscarAF_Click" />
                </td>
            </tr>
        </table>
        <table style="width: 700px">
            <tr>
                <td class="c2g">
                    NOMBRE:
                </td>
                <td class="c2b">
                    <asp:TextBox ID="txtNomAF" runat="server" CssClass="input1" Enabled="false" />
                </td>
                <td class="c2g">
                    EMAIL:
                </td>
                <td class="c2b">
                    <asp:TextBox ID="txtEmailAF" runat="server" CssClass="input1" TextMode="Email" />
               </td>
            </tr>
            <tr>
                <td class="c2g">
                    APELLIDO PATERNO:
                </td>
                <td class="c2b">
                    <asp:TextBox ID="txtAppatAF" runat="server" CssClass="input1" Enabled="false" />
                </td>
                <td class="c2g">
                    TELEFONO:
                </td>
                <td class="c2b">
                    <asp:TextBox ID="txtFonoAF" runat="server" CssClass="input1" TextMode="Phone" />
                </td>
            </tr>
            <tr>
                <td class="c2g">
                    APELLIDO MATERNO:
                </td>
                <td class="c2b">
                    <asp:TextBox ID="txtApmatAF" runat="server" CssClass="input1" Enabled="false" />
                </td>
                <td class="c2g">
                    DIRECCIÓN:
                </td>
                <td class="c2b">
                    <asp:TextBox ID="txtDirAF" runat="server" class="input1" Enabled="false" />
                </td>
            </tr>
            <tr>
                <td class="c2g">
                    ACTIVO:
                </td>
                <td class="c2b">
                    <asp:CheckBox ID="chkActivoAF" runat="server" Font-Names="Arial" Text="Activo" />
                </td>
                <td class="c2g">
                    CONTRASEÑA:
                </td>
                <td class="c2b">
                    <asp:Button ID="btnPassAF" runat="server" Text="REESTABLECER" CssClass="boton2" EnableTheming="True"
                        OnClick="btnPassAF_Click" />
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td class="cbtn">
                    <asp:Button ID="btnGuardarAF" CssClass="boton" runat="server" Text="GUARDAR" OnClick="btnGuardarAF_Click" />
                    &nbsp;&nbsp;<asp:Button ID="btnLimpiarAF" CssClass="boton" runat="server" Text="LIMPIAR"
                        OnClick="btnLimpiarAF_Click" />
                    &nbsp;&nbsp;<asp:Button ID="btnRevMultasAF" CssClass="boton2" runat="server" Text="REVISAR MULTAS"
                        OnClick="btnRevMultasAF_Click" Visible="False" />
                </td>
            </tr>
        </table>
        <asp:GridView ID="gvMultas" runat="server" OnSelectedIndexChanged="gvMultas_SelectedIndexChanged"
            AutoGenerateColumns="False" CssClass="Grilla" OnDataBound="gvMultas_DataBound"
            OnRowCommand="gvMultas_RowCommand" OnRowDataBound="gvMultas_RowDataBound">
            <Columns>
                <asp:BoundField HeaderText="FOLIO" DataField="FOLIO" />
                <asp:BoundField HeaderText="GRAVEDAD" DataField="GRAVEDAD" />
                <asp:BoundField HeaderText="VALOR" DataField="VALOR" />
                <asp:BoundField HeaderText="VALOR APELACIÓN" DataField="VALOR_APEL" DataFormatString="${0:N0}" />
                <asp:BoundField HeaderText="VALOR FINAL" DataField="VALOR_PESOS" DataFormatString="${0:N0}" />
                <asp:BoundField HeaderText="FECHA MULTA" DataField="FECHA_MULTA" DataFormatString="{0:M-dd-yyyy}" />
                <asp:BoundField HeaderText="LICENCIA RETENIDA" DataField="LIC_RET" />
                <asp:BoundField HeaderText="ESTADO DE PAGO" DataField="EST_PAGO" />
                <asp:BoundField HeaderText="LICENCIA ENTREGADA" DataField="LIC_ENTR" />
                <asp:ButtonField ButtonType="Button" CommandName="BotonGV" HeaderText="PAGAR" 
                    Text="PAGAR" >
                <ControlStyle BackColor="#528204" Font-Bold="True" ForeColor="White" />
                </asp:ButtonField>
            </Columns>
        </asp:GridView>
        <br />
    </div>
    </form>
</asp:Content>

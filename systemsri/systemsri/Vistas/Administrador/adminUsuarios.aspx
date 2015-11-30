<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Administrador/MPAdministrador.master" AutoEventWireup="true" CodeBehind="adminUsuarios.aspx.cs" Inherits="systemsri.Vistas.Administrador.adminUsuarios" %>
 <%@ OutputCache Location="None" NoStore="true"%>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoAdmin" runat="server">
<form id="formAdminUsuarios" runat="server">
    <div class="alinInicial">
        <h2>
            Crear y/o Editar Usuario</h2>
        <asp:Label ID="lblInfoAU" runat="server" Text="Label" Visible="False" Font-Size="Medium"
            CssClass="lbl" />
        <table>
            <tr>
                <td class="c1g">
                    RUT:
                </td>
                <td class="c1b">
                    <asp:TextBox ID="txtRutAU" runat="server" MaxLength="12" CssClass="input1" />
                </td>
                <td class="cbtn">
                    <asp:Button ID="btnBuscarAU" runat="server" Text="BUSCAR" CssClass="boton" OnClick="btnBuscarAU_Click" />
                </td>
            </tr>
            <tr>
                <td class="c1g">
                    NOMBRES:
                </td>
                <td class="c1b">
                    <asp:TextBox ID="txtNomAU" runat="server" CssClass="input1"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="c1g">
                    APELLIDO PATERNO:
                </td>
                <td class="c1b">
                    <asp:TextBox ID="txtAppatAU" runat="server" CssClass="input1"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="c1g">
                    APELLIDO MATERNO:
                </td>
                <td class="c1b">
                    <asp:TextBox ID="txtApmatAU" runat="server" CssClass="input1"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="c1g">
                    DIRECCIÓN:
                </td>
                <td class="c1b">
                    <asp:TextBox ID="txtDireccion" runat="server" CssClass="input1"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="c1g">
                    TELEFONO:
                </td>
                <td class="c1b">
                    <asp:TextBox ID="txtTelefono" runat="server" CssClass="input1"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="c1g">
                    EMAIL:
                </td>
                <td class="c1b">
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="input1"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="c1g">
                    CATEGORIA:
                </td>
                <td class="c1b">
                    <asp:DropDownList ID="ddlistCategoria" runat="server" CssClass="ddlist" DataTextField="DETALLE_CAR"
                        DataValueField="ID_DETCAR" OnSelectedIndexChanged="ddlistCategoria_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="c1g">
                    ESTADO
                </td>
                <td class="c1b">
                    <asp:CheckBox ID="chkActivoAU" runat="server" Font-Names="Arial" OnCheckedChanged="chkActivo_CheckedChanged"
                        Text="Activo" />
                </td>
            </tr>
            <tr id="reiniciarClave" style="display: none" runat="server">
                <td class="c1g">
                    CONTRASEÑA:
                </td>
                <td class="c1b">
                    <asp:Button ID="btnPassAU" runat="server" Text="REESTABLECER" CssClass="boton2" EnableTheming="True"
                        OnClick="btnPassAU_Click1" Height="33px" />
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td class="ctxt">
                    *Al guardar un Usuario nuevo, la contraseña se genera automaticamente<br />
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td style="text-align: center; width: 22%;">
                </td>
                <td class="cbtn">
                    <asp:Button ID="btnGuardarAU" runat="server" Text="GUARDAR" CssClass="boton" OnClick="btnGuardarAU_Click" />
                </td>
                <td class="cbtn">
                    <asp:Button ID="btnActualizarAU" runat="server" Text="ACTUALIZAR" CssClass="boton"
                        OnClick="btnActualizarAU_Click" Visible="False" />
                </td>
                <td class="cbtn">
                    <asp:Button ID="btnBorrarAU" runat="server" Text="LIMPIAR" CssClass="boton" OnClick="btnBorrarAU_Click" />
                </td>
            </tr>
        </table>
    </div>
    </form>
    </asp:Content>
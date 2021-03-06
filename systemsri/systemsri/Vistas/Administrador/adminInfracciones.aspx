﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Administrador/MPAdministrador.master"
    AutoEventWireup="true" CodeBehind="adminInfracciones.aspx.cs" Inherits="systemsri.Vistas.Administrador.adminInfracciones" %>

<%@ OutputCache Location="None" NoStore="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoAdmin" runat="server">
    <form id="formAdminInfracciones" runat="server">
    
    <div class="alinInicial">
        <h2>
            Crear y/o Editar Infracciones<asp:TextBox 
                ID="TxtID" runat="server" 
                Enabled="False" ontextchanged="TxtID_TextChanged" Visible="False"></asp:TextBox>
        </h2>
        <asp:Label ID="lblInfoAdI" runat="server" Text="" CssClass="lbl" Visible="false"></asp:Label>
        <asp:Label ID="lblcodInfraccionAI" runat="server" Text="" CssClass="lbl" Visible="false"></asp:Label>

        <table>
            <tr>
                <td class="c1g">
                    DESCRIPCION<br />
                    INFRACCIÓN:
                </td>
                <td class="c1b">
                    <asp:TextBox runat="server" ID="txtDescrInfraccionAI" CssClass="input2" placeholder="Escriba descripcion de la infracción"
                        class="input2" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="c1g">
                    GRAVEDAD:
                </td>
                <td class="c1b">
                    <asp:DropDownList ID="ddlistGravedadAI" runat="server" CssClass="ddlist" DataTextField="DETALLE_CAR"
                        DataValueField="ID_DETCAR" OnSelectedIndexChanged="ddlistGravedadAI_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="c1g">
                    TIPO MONEDA:
                </td>
                <td class="c1b">
                    <asp:DropDownList ID="ddlistTipoMonedaAI" runat="server" CssClass="ddlist" DataTextField="DETALLE_CAR"
                        DataValueField="ID_DETCAR" OnSelectedIndexChanged="ddlistTipoMonedaAI_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="c1g">
                    VALOR:
                </td>
                <td class="c1b">
                    <asp:TextBox type="text" ID="txtValorAI" runat="server" CssClass="input1" 
                        ontextchanged="txtValorAI_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="c1g">
                    ESTADO
                </td>
                <td class="c1b">
                    <asp:CheckBox ID="chkActivoAIn" runat="server" Font-Names="Arial" OnCheckedChanged="chkActivoAIn_CheckedChanged"
                        Text="Activo" />
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td class="cbtn">
                    <asp:Button ID="btnGuardarAI" class="boton" runat="server" Text="GUARDAR" OnClick="btnGuardarAI_Click" />
                </td>
                <td class="cbtn" style="width: 104px">
                    <asp:Button ID="btnBorrarAI" class="boton" runat="server" Text="BORRAR" OnClick="btnBorrarAI_Click" />
                </td>
                <td class="cbtn" style="width: 104px">
                    <asp:Button ID="btnListar" class="boton" runat="server" Text="LISTAR" OnClick="btnListar_Click" />
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <asp:GridView ID="gvInfrAI" runat="server" CssClass="Grilla" OnSelectedIndexChanged="gvInfrAI_SelectedIndexChanged"
                    AutoGenerateColumns="False" OnDataBound="gvInfrAI_DataBound" OnPageIndexChanging="gvInfrAI_PageIndexChanging"
                    OnRowDataBound="gvInfrAI_RowDataBound" AllowPaging="True" PageSize="20" 
                    onrowcommand="gvInfrAI_RowCommand">
                    <Columns>
                        <asp:BoundField HeaderText="ID" DataField="ID_INF" />
                        <asp:BoundField HeaderText="GRAVEDAD" DataField="GRAVEDAD" />
                        <asp:BoundField HeaderText="VALOR" DataField="VALOR" />
                        <asp:BoundField HeaderText="TIPO MONEDA" DataField="TIPO_MONEDA" />
                        <asp:BoundField HeaderText="DESCRIPCION INFRACCION" DataField="DESCR_INF" />
                        <asp:ButtonField HeaderText="VER" ButtonType="Image" ImageUrl="../../Recursos/Imagenes/buscar.jpg"
                            CommandName="BotonGV">
                            <ItemStyle Width="10%"></ItemStyle>
                        </asp:ButtonField>
                    </Columns>
                </asp:GridView>
            </tr>
        </table>
    </div>
    </form>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Funcionario/MPFuncionario.master" AutoEventWireup="true" CodeBehind="generaFun.aspx.cs" Inherits="systemsri.Vistas.Funcionario.generaFun" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoAdmin" runat="server">
<form id="formGeneraFun" runat="server">
     <div class="alinInicial"> 
        <h2>Generar Turnos</h2>
        <asp:Label runat="server" ID="lblInfoGF" CssClass="lbl" Text="" Visible="false"/>
            <table> 
                  <tr>
                    <td class="c1g">RUT:</td> 
                    <td class="c1b"><asp:TextBox ID="txtRutGF" runat="server" CssClass="input1" /></td>
                    <td class="cbtn"><asp:Button ID="btnBuscarGF" CssClass="boton" runat="server" Text="BUSCAR" onclick="btnBuscarGF_Click" /></td>
                   </tr>
                 <tr>
                    <td class="c1g">NOMBRE:</td> 
                    <td class="c1b"><asp:TextBox ID="txtNomGF" runat="server" CssClass="input1" disabled="disabled" ReadOnly="True"/></td>
                 </tr>
                 <tr>
                    <td class="c1g">SECTOR:</td> 
                    <td class="c1b"><asp:DropDownList ID="ddlistSectorGF" runat="server" CssClass="ddlist" 
                            DataTextField="DETALLE_CAR" DataValueField="ID_DETCAR" 
                            onselectedindexchanged="ddlistSectorGF_SelectedIndexChanged"/></td>
                 </tr>
                 <tr>
                    <td class="c1g">FECHA DEL TURNO:</td> 
                    <td class="c1b"><asp:TextBox ID="txtFechaGF" runat="server" CssClass="input1"/></td>
                 </tr>
                 <tr>
                    <td class="c1g">HORA INICIO TURNO:</td> 
                    <td class="c1b"><asp:TextBox ID="txtHoraIniGF" runat="server" CssClass="input3"/></td>
                 </tr>
                 <tr>
                    <td class="c1g">HORA TÉRMINO TURNO:</td>
                    <td class="c1b"><asp:TextBox ID="txtHoraTermGF" runat="server" CssClass="input3"/></td>
                 </tr>
                 <tr>
                    <td class="c1g">DETALLE ADICIONAL <br/> (OPCIONAL):</td> 
                    <td class="c1b"><asp:TextBox ID="txtDetAdicGF" CssClass="input2" runat="server" placeholder="Ingrese detalle adicional"/></td>
                 </tr>
              </table>
              <table>
                 <tr>
                    <td style="text-align: center; width: 22%;"></td>
                    <td class="cbtn">
                    <asp:Button ID="btnGuardarGF" class="boton" runat="server" Text="GUARDAR" onclick="btnGuardarGF_Click"/></td>
                    <td class="cbtn">
                    <asp:Button ID="btnBorrarGF" class="boton" runat="server" Text="BORRAR"  /></td>
                 </tr>
              </table>
           </div> 
        </form>
</asp:Content>

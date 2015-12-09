<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Funcionario/MPFuncionario.master" AutoEventWireup="true" CodeBehind="generaFun.aspx.cs" Inherits="systemsri.Vistas.Funcionario.generaFun" %>
<%@ OutputCache Location="None" NoStore="true" %>
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
                    <td class="c1b"><asp:TextBox ID="txtNomGF" runat="server" CssClass="input1" disabled="disabled" ReadOnly="True" /></td>
                 </tr>
                 <tr>
                    <td class="c1g">SECTOR:</td> 
                    <td class="c1b"><asp:DropDownList ID="ddlistSectorGF" runat="server" CssClass="ddlist" 
                            DataTextField="DETALLE_CAR" DataValueField="ID_DETCAR" 
                            onselectedindexchanged="ddlistSectorGF_SelectedIndexChanged" Enabled="false"/></td>
                 </tr>
                 <tr>
                    <td class="c1g">FECHA DEL TURNO:</td> 
                    <td class="c1b"><asp:TextBox ID="txtFechaGF" runat="server" CssClass="input1" 
                            TextMode="Date" Enabled="false"/></td>
                 </tr>
                                  <tr>
                    <td class="c1g">FECHA FIN:</td> 
                    <td class="c1b">
                        <asp:TextBox ID="FechaFin" runat="server" CssClass="input1" 
                            TextMode="Date"/></td>
                 </tr>
                 <tr>
                    <td class="c1g">HORA INICIO TURNO:</td> 
                    <td class="c1b"><asp:TextBox ID="txtHoraIniGF" runat="server" CssClass="input3" 
                            TextMode="Time" Enabled="false"/></td>
                 </tr>
                 <tr>
                    <td class="c1g">HORA TÉRMINO TURNO:</td>
                    <td class="c1b"><asp:TextBox ID="txtHoraTermGF" runat="server" CssClass="input3" 
                            TextMode="Time" Enabled="false"/></td>
                 </tr>
                 <tr>
                    <td class="c1g">DETALLE ADICIONAL <br/> (OPCIONAL):</td> 
                    <td class="c1b"><asp:TextBox ID="txtDetAdicGF" CssClass="input2" runat="server" 
                            placeholder="Ingrese detalle adicional" MaxLength="2" TextMode="MultiLine"  Enabled="false"/></td>
                 </tr>
              </table>
              <table style="height: 61px">
                 <tr>
                    <td style="text-align: center; width: 22%;"></td>
                    <td class="cbtn">
                    <asp:Button ID="btnGuardarGF" class="boton" runat="server" Text="GUARDAR" 
                            onclick="btnGuardarGF_Click" Visible="False"/></td>
                    <td class="cbtn">
                    <asp:Button ID="btnBorrarGF" class="boton" runat="server" Text="BORRAR" onclick="btnBorrarGF_Click"  /></td>
                             <td class="cbtn">
                    <asp:Button ID="btnListarGF" class="boton2" runat="server" Text="LISTAR TURNOS" onclick="btnListarGF_Click"  /></td>
                 </tr>
              </table>
              <asp:GridView ID="gvTurnos" runat="server" AutoGenerateColumns="False" 
             CssClass="Grilla" OnSelectedIndexChanged="gvTurnos_SelectedIndexChanged" 
             AllowPaging="True" ondatabound="gvTurnos_DataBound"
             OnPageIndexChanging="gvTurnos_PageIndexChanging" 
             onrowcommand="gvTurnos_RowCommand" onrowdatabound="gvTurnos_RowDataBound" 
             PageSize="20" CellPadding="5">
                  <Columns>
                      <asp:BoundField HeaderText="ID"          DataField="ID_TUR"/>
                      <asp:BoundField HeaderText="RUT"         DataField="RUT_PER"/>
                      <asp:BoundField HeaderText="NOMBRE"      DataField="NOMBRE_PER"/>
                      <asp:BoundField HeaderText="SECTOR"      DataField="SECTOR"/>
                      <asp:BoundField HeaderText="FECHA"       DataField="FECHA_TUR"/>
                      <asp:BoundField HeaderText="HORA INICIO" DataField="HORA_INICIO"/>
                      <asp:BoundField HeaderText="HORA FIN"    DataField="HORA_FIN"/>
                      <asp:BoundField HeaderText="DESCRIPCION" DataField="DESCRIPCION_TUR"/>
                  </Columns>
                    <PagerSettings Mode="NumericFirstLast" PageButtonCount="30" />
         </asp:GridView>

                          <br/>

           </div> 
        </form>
</asp:Content>

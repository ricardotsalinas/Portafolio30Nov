<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Funcionario/MPFuncionario.master" AutoEventWireup="true" CodeBehind="generarTurno.aspx.cs" Inherits="systemsri.Vistas.Funcionario.generarTurno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoAdmin" runat="server">
 <form id="formGenerarTurno" runat="server">
     <div class="alinInicial"> 
        <h2>Generar Turnos</h2>
            <table>
                  <tr>
                    <td class="c1g">RUT:</td> 
                    <td class="c1b"><asp:TextBox  id="txtRutGT" runat="server" CssClass="input1" /></td>
                    <td class="cbtn"><asp:Button ID="btnBuscarGT" class="boton" runat="server" 
                            Text="BUSCAR" onclick="btnBuscarGT_Click" /></td>
                   </tr>
                 <tr>
                    <td class="c1g">NOMBRE:</td> 
                    <td class="c1b"><asp:TextBox  id="txtNomGT" runat="server" CssClass="input1" disabled="disabled" ReadOnly="True"/></td>
                 </tr>
                 <tr>
                    <td class="c1g">SECTOR:</td> 
                    <td class="c1b"><asp:DropDownList ID="ddlistSectorGT" runat="server" CssClass="ddlist" 
                            DataTextField="DETALLE_CAR" DataValueField="ID_DETCAR" 
                            onselectedindexchanged="ddlistSectorGT_SelectedIndexChanged"></asp:DropDownList></td>
                 </tr>
                 <tr>
                    <td class="c1g">FECHA DEL TURNO:</td> 
                    <td class="c1b"><asp:TextBox type="date" id="txtFechaGT" runat="server" name="fec_gt" CssClass="input1" /></td>
                 </tr>
                 <tr>
                    <td class="c1g">HORA INICIO TURNO:</td> 
                    <td class="c1b"><asp:TextBox type="time" id="txtHrInicioGT" runat="server" name="hit_gt" CssClass="input4" /></td>
                 </tr>
                 <tr>
                    <td class="c1g">HORA TÉRMINO TURNO:</td>
                    <td class="c1b"><asp:TextBox type="time" id="txtHrTermGT" runat="server" name="htt_gt" CssClass="input4" /></td>
                 </tr>
                 <tr>
                    <td class="c1g">DETALLE ADICIONAL <br/> (OPCIONAL):</td> 
                    <td class="c1b"><asp:TextBox runat="server" id="txtDetAdicGT" CssClass="input2" 
                            placeholder="Ingrese detalle adicional" TextMode="MultiLine"/></td>
                 </tr>
              </table>
              <table>
                 <tr>
                    <td style="text-align: center; width: 22%;"></td>
                    <td class="cbtn"><asp:Button ID="btnGuardarGT" class="boton" runat="server" Text="GUARDAR" onclick="btnGuardarGT_Click"/></td>
                    <td class="cbtn"><asp:Button ID="btnBorrarGT" class="boton" runat="server" 
                            Text="BORRAR" onclick="btnBorrarGT_Click"  /></td>
                 </tr>
              </table>
           </div> 
        </form>

</asp:Content>

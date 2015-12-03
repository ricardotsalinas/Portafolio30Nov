<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Inspector/MPInspector.master" AutoEventWireup="true" CodeBehind="ingresoMulta.aspx.cs" Inherits="systemsri.Vistas.Inspector.ingresoMulta" %>
 <%@ OutputCache Location="None" NoStore="true"%>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoAdmin" runat="server">
        <form id="formIngresaMulta" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">   </asp:ScriptManager>
             <div class="alinInicial">
                 <h2 >Ingresar Multa</h2>
               
              <table>
                 <tr>
                    <td class="c2g">PATENTE:</td> 
                    <td class="c2b"><asp:TextBox id="txtPatIM" runat="server" CssClass="input3" MaxLength="6" 
                    ontextchanged="txtPatIM_TextChanged"></asp:TextBox> <asp:Button runat="server" id="btnBuscarRut" CssClass="boton3" Text="i"
                            onclick="btnBuscarRut_Click"  />
                    </td>
                    <td style="width:2%"></td>
                    <td class="c2g">RUT:</td> 
                    <td class="c2b"><asp:TextBox runat="server" id="txtRutIM" CssClass="input1" disabled="disabled" /></td>
                 </tr>
                 <tr>                    
                    <td class="c2g">FECHA:</td> 
                    <td class="c2b"><asp:TextBox id="txtFechaMultaIM" runat="server" CssClass="input3" disabled="disabled" ontextchanged="txtFechaMultaIM_TextChanged"/></td>
                    <td style="width:2%"></td>
                    <td class="c2g">NOMBRES:</td> 
                    <td class="c2b"><asp:TextBox runat="server" id="txtNomIM" CssClass="input1" 
                            disabled="disabled"/></td>
                    
                 </tr>
                 <tr>
                    <td class="c2g">HORA:</td> 
                    <td class="c2b"><asp:TextBox runat="server" id="txtHoraMultaIM" CssClass="input3" 
                            disabled="disabled" ontextchanged="txtHoraMultaIM_TextChanged"/></td>
                    <td style="width:2%"></td>
                     <td class="c2g">APELLIDO PATERNO:</td> 
                    <td class="c2b"><asp:TextBox runat="server" id="txtAppatIM" CssClass="input1" 
                            disabled="disabled"/></td>
                 </tr>
                 <tr>
                     <td> </td> 
                    <td >
                        <asp:TextBox ID="txtFechaNacimientoIM" runat="server"></asp:TextBox>
                     </td>
                    <td style="width:2%"></td>
                    <td class="c2g">APELLIDO MATERNO:</td> 
                    <td class="c2b"><asp:TextBox runat="server" id="txtApmatIM" CssClass="input1" disabled="disabled" /></td>
                    <td style="width:2%"></td>
                 </tr>
                 <tr>
                    <td class="c2g">MOTIVO:</td> 
                    <td class="c2b"> 
                    
                  <asp:DropDownList runat="server" id="ddlistMotivoIM" AutoPostBack="true" 
                            CssClass="input1" OnSelectedIndexChanged="ddlistMotivoIM_SelectedIndexChanged"></asp:DropDownList></td>
                             <td style="width:2%"></td>
                    <td class="c2g">LUGAR DE <br/> LA INFRACCIÓN:</td> 
                    <td class="c2b"><asp:DropDownList id="ddlistLugarInfIM" runat="server" 
                    CssClass="input1" DataTextField="DETALLE_CAR" DataValueField="ID_DETCAR" 
                            onselectedindexchanged="ddlistLugarInfIM_SelectedIndexChanged"></asp:DropDownList></td>
                 </tr>
                  
              </table>
              <table>
            
              <tr>
                <td class="c2g">DETALLE COMPLETO:</td> 
                    <td class="c2b"><asp:UpdatePanel ID="UpdatePanel1" runat="server"> <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="ddlistMotivoIM" EventName="SelectedIndexChanged" />
                    </Triggers>
                    <ContentTemplate>
                        <asp:TextBox runat="server" id="txtDetCompleto" CssClass="input2" disabled="disabled"
                             TextMode="MultiLine" ontextchanged="txtDetCompleto_TextChanged"></asp:TextBox></ContentTemplate></asp:UpdatePanel></td>
                            <td class="c2g">DETALLE ADICIONAL <br/> (OPCIONAL):</td> 
                    <td class="c2b"><asp:TextBox runat="server" id="txtDetalleAdicIM" CssClass="input2" 
                            placeholder="P.Ej: Altura calle, lugar referencial, etc" TextMode="MultiLine" ></asp:TextBox></td>

                           
              </tr>
              </table>
              <table><tr><td>
              <asp:Button runat="server" Text="LIMPIAR" CssClass="boton" ID="btnLimpiarIM" 
                      onclick="btnLimpiarIM_Click"/>
              </td>
              <td>
              <asp:Button runat="server" Text="GUARDAR" CssClass="boton" ID="btnGuardarIM" 
                      onclick="btnGuardarIM_Click1"/>
              </td>
              <td>
                  <asp:FileUpload ID="FileUpload" runat="server" />
              </td>
              </tr></table>
     
          </div>
        </form>
     
</asp:Content>

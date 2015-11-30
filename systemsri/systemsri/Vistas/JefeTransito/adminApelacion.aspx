<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/JefeTransito/MPJefe.master" AutoEventWireup="true" CodeBehind="adminApelacion.aspx.cs" Inherits="systemsri.Vistas.JefeTransito.adminApelacion" %>
 <%@ OutputCache Location="None" NoStore="true"%>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoAdmin" runat="server">
            <script type="text/ecmascript">
                function ventana(dato) {
                    alert(dato);
                    document.getElementById('<%= btnMagico.ClientID %>').click();
                }
            
            </script>

           <form id="contact_form" runat="server">
         <div class="alinInicial" > 
         <asp:Button runat="server" ID="btnMagico" onclick="btnMagico_Click" />

           <table style="width:100%; font-family:Arial; font-size:small" class="table">
               <tr>
                   <td style="width:42%"> <h2>Administrar Apelación</h2></td>
                   <td style="width:42%"><asp:TextBox runat="server"  id="txtRutAA"  CssClass="input4" placeholder="Ej:12345678-9"/>
                       <asp:DropDownList ID="ddlistFiltro" runat="server" class="ddlist2" 
                           onselectedindexchanged="ddlist_SelectedIndexChanged">
                           <asp:ListItem>Ver Todo</asp:ListItem>
                           <asp:ListItem>Ver Leídos</asp:ListItem>
                           <asp:ListItem>Ver No Leidos</asp:ListItem>
                       </asp:DropDownList>
                       <br /> Buscar Por Rut&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                       <asp:CheckBox ID="CheckBox1" runat="server" />
                        &nbsp;Omitir Resueltos</td>
                    <td style="width:16%; text-align:left"><asp:Button ID="btnBuscarAA" 
                            class="boton" runat="server" Text="FILTRAR" onclick="btnBuscarAA_Click" />
                            <asp:Button ID="btnErxporta" 
                            class="boton" runat="server" Text="Exportar" 
                            onclick="btnErxporta_Click"  />
                            
                            </td>
               </tr>   
            </table>
            <asp:GridView runat="server" ID="gvReporte" CssClass="Grilla" 
                 AutoGenerateColumns="false" 
                 onselectedindexchanged="gvReporte_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField  HeaderText="RESUELTO" DataField="ESTADO" ItemStyle-Width="10%"/>
                    <asp:BoundField  HeaderText="CASO LEIDO" DataField="ESTADO" ItemStyle-Width="10%"/>   
                      <asp:TemplateField HeaderText="REVISAR"> <ItemTemplate>
                            <asp:Image   ItemStyle-Width="10%" runat="server" ID="imgGrilla" src="../../Recursos/Imagenes/ver.jpg"/>
                        </ItemTemplate>
                    </asp:TemplateField>             
                    <asp:BoundField  HeaderText="RUT" DataField="RUT_INF" ItemStyle-Width="10%"/>
                    <asp:BoundField  HeaderText="NOMBRE" DataField="INFR" ItemStyle-Width="30%"/>
                    <asp:BoundField  HeaderText="GRAVEDAD" DataField="GRAVEDAD" ItemStyle-Width="10%"/>
                    <asp:BoundField  HeaderText="MONTO" DataField="VALOR" ItemStyle-Width="10%"/>
                    <asp:BoundField  HeaderText="FECHA MULTA" DataField="FECHA" ItemStyle-Width="10%"/>
                   
                </Columns>
            </asp:GridView>


         </div> 
        </form>
</asp:Content>
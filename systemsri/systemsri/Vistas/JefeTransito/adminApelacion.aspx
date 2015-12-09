<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/JefeTransito/MPJefe.master" AutoEventWireup="true" CodeBehind="adminApelacion.aspx.cs" Inherits="systemsri.Vistas.JefeTransito.adminApelacion" %>
 <%@ OutputCache Location="None" NoStore="true"%>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoAdmin" runat="server">
           
       <form id="contact_form" runat="server">
         <div class="alinInicial" > 

           <table style="width:100%; font-family:Arial; font-size:small" class="table">
               <tr>
                   <td style="width:42%"> <h2>Administrar Apelación</h2></td>
                   <td style="width:42%"><asp:TextBox runat="server"  id="txtRutAA"  CssClass="input4" 
                           placeholder="Ej:12345678-9" Width="93px"/>
                       <asp:DropDownList ID="ddlistFiltro" runat="server" class="ddlist2" 
                           onselectedindexchanged="ddlist_SelectedIndexChanged">
                           <asp:ListItem Value="0">Ver Todo</asp:ListItem>
                           <asp:ListItem Value="1">Ver Leídos</asp:ListItem>
                           <asp:ListItem Value="2">Ver No Leidos</asp:ListItem>
                           <asp:ListItem Value="3">Solo Resueltos</asp:ListItem>
                           <asp:ListItem Value="4">Omitir Resueltos</asp:ListItem>
                       </asp:DropDownList>
                       <br /> Buscar Por Rut&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      
                    <td style="width:16%; text-align:left"><asp:Button ID="btnBuscarAA" 
                            class="boton" runat="server" Text="FILTRAR" onclick="btnBuscarAA_Click" />
                            
                            </td>
               </tr>   
            </table>
            <asp:GridView runat="server" ID="gvReporte" CssClass="Grilla" 
                 AutoGenerateColumns="False" 
                 onselectedindexchanged="gvReporte_SelectedIndexChanged" 
                 onrowcommand="gvReporte_RowCommand" 
                 onrowdatabound="gvReporte_RowDataBound1">
                <Columns>
                    <asp:BoundField  HeaderText="RESUELTO" DataField="RESUELTO" 
                        ItemStyle-Width="10%">
<ItemStyle Width="10%"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField  HeaderText="CASO LEIDO" DataField="CASO_LEIDO" 
                        ItemStyle-Width="10%">   
<ItemStyle Width="10%"></ItemStyle>
                    </asp:BoundField>
                    <asp:ButtonField ButtonType="Image" CommandName="botonGV" HeaderText="REVISAR" 
                        ImageUrl="~/Recursos/Imagenes/buscar.jpg" />
                    <asp:BoundField  HeaderText="RUT" DataField="RUT_INF" ItemStyle-Width="10%">
<ItemStyle Width="10%"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField  HeaderText="NOMBRE" DataField="INFR" ItemStyle-Width="30%">
<ItemStyle Width="30%"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField  HeaderText="GRAVEDAD" DataField="GRAVEDAD" 
                        ItemStyle-Width="10%">
<ItemStyle Width="10%"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField  HeaderText="MONTO" DataField="VALOR" DataFormatString="${0:N0}" ItemStyle-Width="10%">
<ItemStyle Width="10%"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField  HeaderText="FECHA MULTA" DataField="FECHA" 
                        ItemStyle-Width="10%" DataFormatString="{0:M-dd-yyyy}">
                   
<ItemStyle Width="10%"></ItemStyle>
                    </asp:BoundField>
                   
                </Columns>
            </asp:GridView>


                <a href="../homeSanBernardo.aspx"/>
                            <asp:Button ID="btnErxporta" 
                            class="boton" runat="server" Text="Exportar" 
                            onclick="btnErxporta_Click"  />
                            
                            
         </div> 
        </form>
</asp:Content>
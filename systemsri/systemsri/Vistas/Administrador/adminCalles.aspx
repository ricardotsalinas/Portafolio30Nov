<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Administrador/MPAdministrador.master" AutoEventWireup="true" CodeBehind="adminCalles.aspx.cs" Inherits="systemsri.Vistas.Administrador.adminCalles" %>
 <%@ OutputCache Location="None" NoStore="true"%>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoAdmin" runat="server">

 
 <form id="formAdminCalles" runat="server">

         <div class="alinInicial" > 
            <h2>Crear y/o Editar Calles</h2>

            <asp:Label runat="server" ID="lblInfoAC" Text="" CssClass="lbl" Visible="false"/>
             <table>
                <tr>
                    <td class="c1g">NOMBRE CALLE:</td> 
                    <td class="c1b">
                            <asp:TextBox id="txtNombreCalle" runat="server"  CssClass="input1" 
                            ontextchanged="txtNombreCalle_TextChanged" ></asp:TextBox>


                    </td>
                             
                </tr>
                <tr>
                    <td class="c1g">NUMERO DE PISTAS:</td> 
                    <td class="c1b"><asp:DropDownList ID="ddlistNumPistas" runat="server" 
                            CssClass="ddlist" onselectedindexchanged="ddlistNumPistas_SelectedIndexChanged">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem>7</asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                        </asp:DropDownList>
                        
                    </td>
                </tr>
                <tr>
                    <td class="c1g">ORIENTACIÓN:</td> 
                    <td class="c1b"><asp:DropDownList ID="ddlistOrient" runat="server"  
                            CssClass="ddlist" DataTextField="DETALLE_CAR" DataValueField="ID_DETCAR" 
                            onselectedindexchanged="ddlistOrient_SelectedIndexChanged"></asp:DropDownList></td>


                </tr>
                <tr>
                    <td class="c1g">VELOCIDAD MÁXIMA:</td>
                    <td class="c1b"><asp:DropDownList ID="ddlistVelMax" runat="server"  CssClass="ddlist" 
                            DataTextField="DETALLE_CAR" DataValueField="ID_DETCAR" 
                            onselectedindexchanged="ddlistVelMax_SelectedIndexChanged"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td class="c1g">SENTIDO:</td>
                    <td class="c1b"><asp:DropDownList ID="ddlistSentido" runat="server"  CssClass="ddlist" 
                            DataTextField="DETALLE_CAR" DataValueField="ID_DETCAR" 
                            onselectedindexchanged="ddlistSentido_SelectedIndexChanged"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td class="c1g">SECTOR:</td>
                    <td class="c1b"><asp:DropDownList ID="ddlistSector" runat="server"  CssClass="ddlist" 
                            DataTextField="DETALLE_CAR" DataValueField="ID_DETCAR" 
                            onselectedindexchanged="ddlistSector_SelectedIndexChanged"></asp:DropDownList></td>
                </tr>
                   <tr>  
                    <td class="c1g">ESTADO:</td>
                    <td class="c1b">
                    <asp:CheckBox ID="chkActivoACa" runat="server" Font-Names="Arial" OnCheckedChanged="chkActivoACa_CheckedChanged"
                        Text="Activo" />
                   </td>
                </tr>
            </table>
            <table>
                <tr>
                 <td class="cbtn"><asp:Button ID="btnGuardarAC" CssClass="boton" 
                            runat="server" Text="GUARDAR" onclick="btnGuardarAC_Click" /></td>
                   <td class="cbtn"><asp:Button ID="btnBorrarAC"  CssClass="boton" runat="server" 
                            Text="BORRAR" onclick="btnBorrarAC_Click"  />
                   </td>
                   <td> <asp:Button ID="btnListarAC" runat="server" Text="LISTAR" onclick="btnListarAC_Click" CssClass="boton" />
                   </td>
                </tr>
            </table>
             <br />
             <asp:GridView ID="gvCalles" runat="server" AutoGenerateColumns="False" CssClass="Grilla"
                 onselectedindexchanged="gvCalles_SelectedIndexChanged" AllowPaging="True" 
                 PageSize="20" ondatabound="gvCalles_SelectedIndexChanged" 
                 onpageindexchanging="gvCalles_PageIndexChanging"  
                 onrowdatabound="gvCalles_RowDataBound">
                 <Columns>
                     <asp:BoundField HeaderText="ID"            DataField="ID_CALLE"/>
                     <asp:BoundField HeaderText="NOMBRE"        DataField="NOMBRE_CALLE" />
                     <asp:BoundField HeaderText="NUM PISTAS"    DataField="NUM_PISTAS" />
                     <asp:BoundField HeaderText="ORIENTACION"   DataField="ORIENTACION"/>
                     <asp:BoundField HeaderText="VEL_MAX"       DataField="VEL_MAX"/>
                     <asp:BoundField HeaderText="SENTIDO"       DataField="SENTIDO"/>
                     <asp:BoundField HeaderText="SECTOR"        DataField="SECTOR"/>
                    
                      <asp:ButtonField ButtonType="Image" ImageUrl="~/Recursos/Imagenes/buscar.jpg" 
                         Text="REVISAR" />
              
                 </Columns>
                 <PagerSettings Mode="NumericFirstLast" PageButtonCount="30" />
             </asp:GridView>
          </div>
       
        </form>
         
         
</asp:Content>

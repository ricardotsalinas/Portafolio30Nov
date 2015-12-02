<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Infractor/MPInfractor.master" AutoEventWireup="true" CodeBehind="historialMultasInfractor.aspx.cs" Inherits="systemsri.Vistas.Infractor.historialMultasInfractor" %>
 <%@ OutputCache Location="None" NoStore="true"%>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoAdmin" runat="server">
     <form id="contact_form" runat="server">

    <div class="alinInicial">
        <h2>Historial de Multas</h2>
 
        <p>
            
            <asp:GridView ID="GvHistMultasHMI" runat="server" CssClass="Grilla"
                onselectedindexchanged="GvHistMultasHMI_SelectedIndexChanged" 
                onrowcommand="GvHistMultasHMI_RowCommand" 
                onrowdatabound="GvHistMultasHMI_RowDataBound"  
                AutoGenerateColumns="False" >
                <Columns>
                    <asp:BoundField HeaderText="FOLIO" DataField="ID_MULTA" ItemStyle-Width="16%">
<ItemStyle Width="16%"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField HeaderText="PATENTE" DataField="PATENTE" ItemStyle-Width="10%">
<ItemStyle Width="10%"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField HeaderText="FECHA EMISION" DataField="FECHA" 
                        ItemStyle-Width="16%" DataFormatString="{0:M-dd-yyyy}">
<ItemStyle Width="16%"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField HeaderText="TIPO MULTA" DataField="TIPO_MULTA" 
                        ItemStyle-Width="16%">
<ItemStyle Width="16%"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField HeaderText="VALOR" DataField="VALOR_PESO" ItemStyle-Width="16%" DataFormatString="${0:N0}" HtmlEncode="false">
<ItemStyle Width="16%"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField HeaderText="ESTADO" DataField="PAGADA" ItemStyle-Width="16%">
<ItemStyle Width="16%"></ItemStyle>
                    </asp:BoundField>
                    <asp:ButtonField HeaderText="VER" ButtonType="Image" 
                        ImageUrl="../../Recursos/Imagenes/buscar.jpg" CommandName="detalle" 
                        ItemStyle-Width="10%">
<ItemStyle Width="10%"></ItemStyle>
                    </asp:ButtonField>
                </Columns>
            </asp:GridView>
        </p>
        <p>&nbsp;</p>
    </div>   
        
    </form>
    
</asp:Content>

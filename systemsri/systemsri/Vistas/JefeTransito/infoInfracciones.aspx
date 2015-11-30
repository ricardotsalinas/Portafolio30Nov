<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/JefeTransito/MPJefe.master" AutoEventWireup="true" CodeBehind="infoInfracciones.aspx.cs" Inherits="systemsri.Vistas.JefeTransito.infoInfracciones" %>
 <%@ OutputCache Location="None" NoStore="true"%>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoAdmin" runat="server">
        <form id="contact_form" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager> <div class="alinInicial"> 
             <h2 >Informe de Infracciones</h2>
              <table>
                <tr>
                    <td  class="ctxt">Seleccione Datos a Filtrar para generar informe </td>
                </tr>
             </table>
             <table>
                <tr>
                    <td><h5>Fecha Desde </h5></td>
                    <td>
                        <asp:TextBox ID="Fecha1" runat="server" ontextchanged="Fecha1_TextChanged" 
                            TextMode="Date">1</asp:TextBox>
                    </td>
                    <td style="width:10%"></td>
                    <td><h5>Fecha Hasta</h5></td>
                    <td>
                        <asp:TextBox ID="Fecha2" runat="server" ontextchanged="Fecha2_TextChanged" 
                            TextMode="Date">1</asp:TextBox>
                    </td>
                 </tr>               
            </table>
             <table style="width:90%; font-family:Arial; font-size:small">
                   <tr>
                    <td style= "height:30px; background-color:#bfbfbf; text-align:center"> 
                        <input type="checkbox"> Gravedad de la Infracción  
                        <input type="checkbox"> Pagado
                        <input type="checkbox"> Sector  |
                        <input type="checkbox"> Seleccionar Todo</td>
                    </tr>
                
             </table>

          
     

          
             asd&nbsp;<asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                 Text="Button" />
           
             <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="664px" 
                 Font-Names="Verdana" Font-Size="8pt" InteractiveDeviceInfos="(Colección)" 
                 WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" 
                 Enabled="True" Visible="True">
                 <LocalReport ReportPath="Vistas\JefeTransito\Report1.rdlc">
                     <DataSources>
                         <rsweb:ReportDataSource DataSourceId="SqlDataSource1" Name="DataSet1" />
                     </DataSources>
                 </LocalReport>
             </rsweb:ReportViewer>
  
             <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                 ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                 ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" 
                 
                 SelectCommand="SELECT RUT, NOMBRE, GRAVEDAD, ESTADO, SECTOR, FECHA_MULTA, INSPECTOR, RETENCION_LICENCIA, TIPO_INFRACCION, CANTIDAD FROM SRI.INFORMEINFRACCION WHERE (FECHA_MULTA &gt;= :PARAM1 AND FECHA_MULTA &lt;= :PARAM2)">
                 <SelectParameters>
                     <asp:ControlParameter ControlID="Fecha1" Name="FECHAINI" PropertyName="Text" />
                     <asp:ControlParameter ControlID="Fecha2" Name="FECHAFIN" PropertyName="Text" />
                 </SelectParameters>
             </asp:SqlDataSource>
          </div> 
        </form> 
    <script language="javascript" type="text/javascript">
// <![CDATA[

        function fec_desde_onclick() {

        }

// ]]>
    </script>
</asp:Content>


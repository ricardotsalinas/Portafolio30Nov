<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pagoPayPal.aspx.cs" Inherits="systemsri.Vistas.PayPal.pagoPayPal" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body id="BodypagoPaypal" class="BodypagoPaypal">
    <form id="pagoPaypal" class="pagoPaypal" runat="server">
    <div>
        <div id="cabeceraPagoPayPal" class="cabeceraPagoPayPal">
            <img src="../../Recursos/Home/paypalLogo.png" />
            <br />
            <center>
            <table id="tablaTarjeta" class="tablaTarjeta">
                 <tr>
                    <td class="visa">
                        <img src="../../Recursos/Home/visa.jpg" />
                    </td>
                    <td>
                        <asp:RadioButton ID="visaBoton" class="visaBoton" runat="server"/>
                    </td>
                    <td class="master">
                        <img src="../../Recursos/Home/mastercar.png" class="master"/>
                    </td>
                    <td>
                        <asp:RadioButton ID="masterboton" class="visaBoton" runat="server" />
                    </td>
                 </tr>       
             </table>
             </center>  
             <br />
             <center>  
              <table id="tablaProducto" class="tablaProducto" cellpadding="20" width="70%">
                 <tr >
                    <td style="text-align:center;">
                        Seleccionar <br />Pago
                    </td>
                    <td style="text-align:center;">
                        Nombre del Producto
                    </td>
                    <td style="text-align:center;">
                        Folio
                    </td>
                    <td style="text-align:center;">
                        Cantidad
                    </td>
                    <td style="text-align:center;">
                        Total
                    </td>
                 </tr>
                 <tr>
                    <td style="text-align:center;">
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                 </tr>
                 <tr>
                    <td style="text-align:center;">
                        <asp:CheckBox ID="CheckBox2" runat="server" />
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                 </tr>
                 <tr>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                        Total:
                    </td>
                    <td>
                    </td>
                 </tr>
                </table>    
             </center>      
        </div>
        <div>
             <asp:Button ID="bot_confirmarPago" class="bot_confirmarPago" runat="server" Text="Confirmar Pago" />
        </div>  
        
    </div>
    </form>
</body>
</html>

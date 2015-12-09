<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PayPalFunc.aspx.cs" Inherits="systemsri.Vistas.PayPal.PayPalFunc" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body id="BodyinicioPayPal" class="BodyinicioPayPal">
    <form id="logPaypal" runat="server">
    <div>
        <div id="cabeceraInPayPal" class="cabeceraInPayPal">
            <img src="../../Recursos/Home/paypalLogo.png" /><asp:Label ID="lblID2" 
                runat="server" Visible="False"></asp:Label>
&nbsp;<center>
            <table>
                 <tr>
                    <td>
                        <asp:Label ID="lblIdmulta2" runat="server"></asp:Label>
                    </td>
                 </tr>
                 <tr>
                    <td>
                        <asp:Label ID="lblMonto2" runat="server"></asp:Label>
                    </td>
                 </tr>
                 <tr>
                    <td>
                        &nbsp;</td>
                 </tr>
                 <tr>
                   <td><asp:Button ID="bot_LogPayPal2" class="bot_LogPayPal" runat="server" 
                           Text="Pagar" onclick="bot_LogPayPal2_Click" Width="209px"/>
                   </td>
                 </tr>
               
                 <tr>
                   <td><asp:Label ID="lblInfoPPF" class="lbl" runat="server" Visible="false"
                           Text="El pago ha sido realizado correctamente"/>
                   </td>
                 </tr>
                 <tr>
                    <td>
                        <asp:Button ID="btnVolver2" runat="server" CssClass="boton" 
                            onclick="btnVolver2_Click" Text="Volver" />
                    </td>
                 </tr>
             </table>     
             </center>          
        </div>
    </div>
    </form>
</body>
</html>

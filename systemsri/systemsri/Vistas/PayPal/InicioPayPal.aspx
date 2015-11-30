<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InicioPayPal.aspx.cs" Inherits="systemsri.Vistas.PayPal.InicioPayPal" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body id="BodyinicioPayPal" class="BodyinicioPayPal">
    <form id="logPaypal" runat="server">
    <div>
        <div id="cabeceraInPayPal" class="cabeceraInPayPal">
            <img src="../../Recursos/Home/paypalLogo.png" />
            <center>
            <table>
                 <tr>
                    <td>
                        <asp:TextBox ID="casillaEmail"  class="casillaEmail" type="email" runat="server" placeholder="Email"></asp:TextBox>
                    </td>
                 </tr>
                 <tr>
                    <td>
                        <asp:TextBox ID="casillaPass"  class="casillaPass" runat="server" placeholder="Password"></asp:TextBox>
                    </td>
                 </tr>
                 <tr>
                   <td><asp:Button ID="bot_LogPayPal" class="bot_LogPayPal" runat="server" 
                           Text="Iniciar sesión"/>
                   </td>
                 </tr>
                 <tr>
                    <td>
                        <asp:Label ID="forgotPass"  class="forgotPass" runat="server" Text="¿Olvidaste tu correo electrónico o contraseña?"></asp:Label>
                    </td>
                 </tr>
             </table>     
             </center>          
        </div>
    </div>
    </form>
</body>
</html>

<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Maestro/Login.Master" AutoEventWireup="true" CodeBehind="loginUsuario.aspx.cs" Inherits="systemsri.Vistas.LoginUsuario.loginUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoLogin" runat="server">
    <br />
    <div style="text-align: center">
        <img src="../../Recursos/Imagenes/sri%20colores.png" style="width: 190px; height: 180px; " />
    </div>
     <form id="form1" runat="server">
    <h5 style="text-align: center" dir="rtl">Ingrese Rut y Contraseña <br />para consultar si tiene multas impagas.</h5>
      <table style= "width:100%" >
                     <tr>
                       <td style="width:26%"></td>
                       <td style="height:150px; background-color:#5a5a5a; text-align:center"> 
                           <br />
                           <br />
                           <asp:TextBox ID="txtRutLU" runat="server" 
                               ontextchanged="txtRutLU_TextChanged"  ></asp:TextBox>
                          <h6 style="font-style:italic">*Rut sin puntos ni guiones</h6>
                           <asp:TextBox ID="txtPassLU" runat="server" ontextchanged="txtPassLU_TextChanged" 
                               TextMode="Password"></asp:TextBox>
                           <br />  
                            <br />
                           <asp:Button ID="btnEntrarLU" runat="server" onclick="btnEntrarLU_Click" Text="ENTRAR" CssClass="boton"/>
                           <br />
                           <br />
                           <br />
                       </td>
                       <td style="width:26%"></td>
                     </tr>
                </table>
     </form>
</asp:Content>

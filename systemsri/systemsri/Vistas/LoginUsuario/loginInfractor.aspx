<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Maestro/Login.Master" AutoEventWireup="true" CodeBehind="loginInfractor.aspx.cs" Inherits="systemsri.Vistas.LoginUsuario.loginInfractor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 241px;
            height: 106px;
        }
     
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoLogin" runat="server">
     <form id="form1" runat="server">
     <br />
     <br />
    <div style="text-align: center">
        
        <img class="style1" src="../../Recursos/Imagenes/consulta.jpg" /></div>
    <h5 style="text-align: center">Ingrese Rut y Contraseña <br />para consultar si tiene multas impagas.</h5>
      <table style= "width:100%" >
                     <tr>
                       <td style="width:26%"></td>
                       <td style="height:150px; background-color:#5a5a5a; text-align:center"> 
                           <br />
                           <br />
                           <asp:TextBox ID="rut_infr" runat="server" 
                               ontextchanged="rut_infr_TextChanged"  ></asp:TextBox>
                          <h6 style="font-style:italic">*Rut sin puntos ni guiones</h6>
                           <asp:TextBox ID="clave" runat="server" ontextchanged="clave_TextChanged" 
                               TextMode="Password"></asp:TextBox>
                           <br />  
                            <br />
                           <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="ENTRAR" CssClass="boton"/>
                           <br />
                           <br />
                           <br />
                       </td>
                       <td style="width:26%"></td>
                     </tr>
                </table>
     </form>
</asp:Content>
<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Funcionario/MPFuncionario.master" AutoEventWireup="true" CodeBehind="datosFun.aspx.cs" Inherits="systemsri.Vistas.Funcionario.datosFun" %>
<%@ OutputCache Location="None" NoStore="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoAdmin" runat="server">
    <form id="formDatosInfractor" runat="server">
         <div class="alinInicial">
           <h2>Datos Personales</h2>

              <table style="width: 70%">
                <tr>
                    <td class="c1g">RUT:</td> 
                    <td class="c1b"> <asp:TextBox runat="server" id="txtRutDF" CssClass="input1" Enabled="False" ></asp:TextBox></td>
                </tr>
                <tr>
                <!-- Se integrarán todos los nombres para solo informacion-->
                    <td class="c1g">NOMBRE:</td> 
                    <td class="c1b"><asp:TextBox runat="server" id="txtNomDF" CssClass="input1" Enabled="False" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="c1g">DIRECCIÓN:</td> 
                    <td class="c1b"><asp:TextBox runat="server" id="txtDirDF" CssClass="input1" Enabled="False" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="c1g">EMAIL:</td> 
                    <td class="c1b">
                     <asp:TextBox runat="server" id="txtEmailDF" CssClass="input1" 
                            Enabled="False" MaxLength="70"></asp:TextBox></td>
                           
                   <td>
                   
                       <asp:ImageButton ID="ImageEmail" runat="server" Height="24px" 
                           ImageUrl="~/Recursos/Imagenes/editar.PNG"  
                           Width="24px" onclick="ImageEmail_Click" />
                                          
                    </td>

                </tr>
              
                <tr>
                    <td class="c1g">TELÉFONO:</td> 
                    <td class="c1b">
                        <asp:TextBox runat="server" id="txtTelefonoDF" CssClass="input1" 
                            Enabled="False" MaxLength="15"></asp:TextBox></td>
                    <td>
                        <asp:ImageButton ID="ImageTelefono" runat="server" 
                            ImageUrl="~/Recursos/Imagenes/editar.PNG" onclick="ImageTelefono_Click" />
                    </td>
                </tr>
              
                <tr>
                    <td class="c1g">CONTRASEÑA:</td> 
                    <td class="c1b">
                        <asp:Button id="btnModificaPassDF" CssClass="boton" runat="server" 
                            Text="MODIFICAR" onclick="btnModificaPassDF_Click" /></td>
                </tr>
            </table>
                <br/>
                  <asp:Label ID="lblInfoDF" runat="server" CssClass="lbl" 
                    Text="label" Visible="False" 
                    Font-Underline="False" />
                <br/> 

            <table id="tblPassDF" runat="server" width="70%">
                 <tr>
                     <td class="c3g" colspan="2" style="height: 33px">GENERE SU NUEVA CONTRASEÑA</td>
                 </tr>
                 <tr>
                    <td class="ctxt2" >
                        <asp:TextBox runat="server" id="txtCambiaPassDF1" CssClass="input1" 
                            TextMode="Password" MaxLength="25"  />
                        <h5 style="margin:auto">*Ingrese nueva contraseña</h5>

                    </td>
                    <td class="ctxt2">
                       <asp:TextBox runat="server" id="txtCambiaPassDF2" CssClass="input1" 
                            TextMode="Password" MaxLength="25"  />
                        <h5 style="margin:auto">*Confirme nueva contraseña</h5>
                    </td>
                </tr>
             </table>
            <br/>
             <table style="margin: 0 auto;">
                <tr>
                    <td><asp:Button ID="btnGuardarDF" CssClass="boton" runat="server" Text="GUARDAR" 
                            onclick="btnGuardarDF_Click" /></td>
                </tr>
             </table>
             </div>  
        </form>
</asp:Content>
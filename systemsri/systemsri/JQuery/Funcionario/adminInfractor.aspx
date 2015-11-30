<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Funcionario/MPFuncionario.master" AutoEventWireup="true" CodeBehind="adminInfractor.aspx.cs" Inherits="systemsri.Vistas.Funcionario.adminInfractor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoAdmin" runat="server">
  <form id="formAdmInfr" runat="server" >
     <div class="alinInicial"> 
        <h2>Administrar Infractor</h2>
            <table>
               <tr>
                 <td class="c1g">RUT :</td> 
                   <td class="c1b"><asp:TextBox type="text" id="txtRutAIn" runat="server" name="rut_infr" class="input1" ></asp:TextBox></td>
                  <td class="cbtn"><asp:Button ID="btnBuscarAIn" class="boton" runat="server" 
                          Text="BUSCAR" onclick="btnBuscarAIn_Click" /></td>
                    
                   </tr>
                </table>
               
              <table style="width: 700px">
                <tr>
                    <td class="c2g" style="width: 24%">NOMBRE:</td> 
                    <td class="c2b" style="width: 28%"><asp:TextBox type="text" id="txtNomAIn" runat="server" name="nom_infr" class="input1" ></asp:TextBox></td>
                 

                    <td class="c2g" style="width: 24%">EMAIL:</td> 
                    <td class="c2b" ><asp:TextBox type="email" id="txtEmailAIn" runat="server" Cssclass="input1" ></asp:TextBox></td>
                    <td style="width:3%"></td>
                </tr>
                <tr>
                    <td class="c2g" style="width: 24%">APELLIDO PATERNO:</td> 
                    <td class="c2b" style="width: 28%"><asp:TextBox type="text" id="txtAppatAIn" runat="server" CssClass="input1"></asp:TextBox></td>
              

                    <td class="c2g" style="width: 24%">TELÉFONO:</td> 
                    <td class="c2b" ><asp:TextBox type="text" id="txtTelAIn" runat="server" name="txtTelAIn" class="input1" ></asp:TextBox></td>
                    <td style="width:3%"></td>
                </tr>
                 <tr>
                    <td class="c2g" style="width: 24%">APELLIDO MATERNO:</td> 
                    <td class="c2b" style="width: 28%" ><asp:TextBox type="text" id="txtApmatAIn" runat="server" Cssclass="input1" ></asp:TextBox></td>
                  
                                      
                    <td class="c2g" style="width: 24%">FECHA DE <br/>NACIMIENTO:</td> 
                    <td class="c2b"><asp:TextBox type="date" id="txtFnacAIn" runat="server" class="input1"></asp:TextBox></td>
                    <td style="width:1%"></td>
                                       
                </tr>
                <tr>
                    <td class="c2g" style="width: 24%">DIRECCIÓN:</td> 
                    <td class="c2b" style="width: 28%"><asp:TextBox type="text" id="txtDirAIn" runat="server" class="input1" ></asp:TextBox></td>
                    
                    
                    <td class="c1g" style="width: 24%">CONTRASEÑA:</td> 
                    <td class="c1b">
                        <asp:Button ID="btnPassAIn"  runat="server" Text="REESTABLECER" CssClass="boton2" EnableTheming="True" onclick="btnPassAIn_Click" 
                            /></td>
               
               
                </tr>
                <tr>
                    <td colspan="1" style="text-align: center; width: 24%;"></td>
                    <td class="cbtn" style="width: 28%">
                    <asp:Button ID="btnGuardarAIn" class="boton" runat="server" Text="GUARDAR" onclick="btnGuardarAIn_Click" /></td>
                </tr>
              </table>
            </div> 
        </form>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Funcionario/MPFuncionario.master" AutoEventWireup="true" CodeBehind="admFun.aspx.cs" Inherits="systemsri.Vistas.Funcionario.admFun" %>
<%@ OutputCache Location="None" NoStore="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoAdmin" runat="server">
<form id="formAdmfun" runat="server" >
     <div class="alinInicial"> 
        <h2>Administrar Infractor</h2>
        <asp:Label ID="lblInfoAF" runat="server" CssClass="lbl" Text="" Visible="false" />
            <table>
               <tr>
                 <td class="c1g">RUT :</td> 
                   <td class="c1b"><asp:TextBox type="text" id="txtRutAF" runat="server" CssClass="input1" /></td>
                  <td class="cbtn"><asp:Button ID="btnBuscarAF" class="boton" runat="server" 
                          Text="BUSCAR" onclick="btnBuscarAF_Click" /></td>
                    
                   </tr>
                </table>
               
              <table style="width: 700px">
                <tr>
                    <td class="c2g">NOMBRE:</td> 
                    <td class="c2b"><asp:TextBox ID="txtNomAF" runat="server" CssClass="input1"/></td>
                 

                    <td class="c2g">EMAIL:</td> 
                    <td class="c2b" ><asp:TextBox ID="txtEmailAF" runat="server" Cssclass="input1" /></td>
                    <td style="width:3%"></td>
                </tr>
                <tr>
                    <td class="c2g">APELLIDO PATERNO:</td> 
                    <td class="c2b"><asp:TextBox ID="txtAppatAF" runat="server" CssClass="input1"/></td>
              

                    <td class="c2g">TELEFONO:</td> 
                    <td class="c2b" ><asp:TextBox ID="txtFonoAF" runat="server" CssClass="input1"/></td>
                    <td style="width:3%"></td>
                </tr>
                 <tr>
                    <td class="c2g">APELLIDO MATERNO:</td> 
                    <td class="c2b"><asp:TextBox ID="txtApmatAF" runat="server" Cssclass="input1" /></td>
                  
                                      
                    <td class="c2g">FECHA DE <br/>NACIMIENTO:</td> 
                    <td class="c2b"><asp:TextBox ID="txtFnacAF" runat="server" CssClass="input1"/></td>
                    <td style="width:1%"></td>
                                       
                </tr>
                <tr>
                    <td class="c2g">DIRECCIÓN:</td> 
                    <td class="c2b"><asp:TextBox ID="txtDirAF" runat="server" class="input1"/></td>
                    
                    
                    <td class="c1g">CONTRASEÑA:</td> 
                    <td class="c1b">
                        <asp:Button ID="btnPassAF"  runat="server" 
                            Text="REESTABLECER" CssClass="boton2" EnableTheming="True" onclick="btnPassAF_Click" 
                            /></td>
               
               
                </tr>
                <tr>
                    <td colspan="1" style="text-align: center; width: 24%;"></td>
                    <td class="cbtn"><asp:Button ID="btnGuardarAF" CssClass="boton" runat="server" 
                            Text="GUARDAR" onclick="btnGuardarAF_Click" /></td>
                </tr>
              </table>
            </div> 
        </form>


</asp:Content>
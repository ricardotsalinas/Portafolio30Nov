<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homeSanBernardo.aspx.cs" Inherits="systemsri.Vistas.homeSanBernardo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>San Bernardo</title>
</head>
<link rel="shortcut icon" href="../Recursos/Home/faviconmuni"/>
<body id="homeSanbeca" class="homeSanbeca">
 <div id="container" class="container">
        <div id="loginUser" class="loginUser">
              <asp:HyperLink ID="HyperLink1" runat="server" Font-Names="Arial"
                 NavigateUrl="LoginUsuario/loginUsuario.aspx" ForeColor="#FFFFFF" style="margin-right:30px; margin-top:5px;">Iniciar Sesión</asp:HyperLink>
        </div>
        <div id="cabecerahome" class="cabecerahome">
            <div id="contenidoCabecerahome" class="contenidoCabecerahome">
              <img src="../Recursos/Home/imagenCabecera.jpg"/>         
            </div>
        </div>

        <div id="menuHome" class="menuHome">
             <asp:Label ID="contenido" runat="server" 
                 Text="Contacto | Actividades | Web Mail | Radio San Bernardo Online" style="margin-right:30px; "></asp:Label>        
        </div>
        <div>
             <marquee class="textMov" behavior="scroll" direction="left" loop="infinite" scrolldelay="100">
                &iexcl;&iexcl;San Bernardo Crece Con Todos!! &ndash;&nbsp;Fono Municipal 927 0000 - Fono Emergencias 800 202 840 - &iexcl;&iexcl;San Bernardo Crece Con Todos!!
             </marquee>
        </div>
            
        <div id="bajoHome" class="bajoHome" >

             <div id="columIzqHome" class="columIzqHome">
             <br />
                <img src="../Recursos/Home/imagizq.png"/>
             </div>

             <div id="columCentroHome" class="columCentroHome">
             <br />
                   <div id="direcLog" class="direcLog">
                        <a href="LoginUsuario/loginInfractor.aspx"><img src="../Recursos/Home/imaglink.png"/></a>
                   </div>
                   <br /><br />
                    <div id="noticias" class="noticias">
                        <img src="../Recursos/Home/imagCentro.png"/>
                    </div>
             </div>

             <div id="columDerHome" class="columDerHome">
             <br />
                <img src="../Recursos/Home/imagDer.png"/>

             </div>
         </div>
        
        <div id="pieHome" class="pieHome">
             Ilustre Municipalidad de San Bernardo - Edificio Consistorial Eyzaguirre 450 - Fono +56(2) 2927 0000
             <br />
             Todos los derechos reservados de este sitio perteneciente a la Ilustre 
             Municipalidad de San Bernardo</div>       
</div>
</body>
</html>
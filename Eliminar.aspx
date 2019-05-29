<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Eliminar.aspx.cs" Inherits="Eliminar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
 <style type="text/css">
        body{
            background:url('Resources/blacky.png');
            padding:15% 20%;
        }
        .label{
            color:goldenrod;
            padding:5% 3%;
            font-size:medium;
        }
        .labelM{
            color:gold;
            padding:5%;
            font-size:x-large;

        }
        .button{
            background-color:gold;
            padding:5%;
            font-size:medium;     
        }
        .list{
            background-color:black;
            color:goldenrod;
            padding:5%;
            font-size:large;
        }
        .HyperLink1{
            color:gold;
            padding:5%;
            font-size:x-large;
        }
        a{
            color:gold;
        }
    </style> 
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="Label1" class="labelM" runat="server" Text="Que desea eliminar?:"></asp:Label>
    <br />
        <table align="center">
    <tr>
    <td><asp:Label ID="Label2" class="label" runat="server" Text="Nombre de Videojuego:"></asp:Label></td>
    <td><asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox></td>
    <td align="center"><asp:Button ID="beliminar1" Text="Eliminar por Nombre" runat="server"></asp:Button></td>
    </tr>
    <tr>
    <td><asp:Label ID="Label3" class="label" runat="server" Text="Categoria:"></asp:Label></td>
    <td><asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox></td>
        <td align="center"><asp:Button ID="beliminar2" Text="Eliminar por Categoria" runat="server"></asp:Button></td>
    </tr>
    </table>    <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Index.aspx">Regresar</asp:HyperLink>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:Label ID="lbleliminado" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registro.aspx.cs" Inherits="Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<form id="form1" runat="server">
<div>
<table width="60%" align="center">
<tr>
<td><asp:Label ID="Label1" runat="server" Text="Nombre usuario:"></asp:Label></td>
<td><asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox></td>
</tr>
<tr>
<td><asp:Label ID="Label2" runat="server" Text="Contraseña:"></asp:Label></td>
<td><asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox></td>
</tr>
<tr>
<td><asp:Label ID="Label3" runat="server" Text="Correo electrónico:"></asp:Label></td>
<td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
</tr>
<tr>
<td><asp:Label ID="Label4" runat="server" Text="Teléfono:"></asp:Label></td>
<td><asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox><br /></td>
</tr>
<tr>
<td colspan="2" align="center"><asp:Button ID="Button1" runat="server" Text="Registrar" OnClick="Button1_Click" /></td>
</tr>
</table>
</div>
<br />
<asp:Label ID="lblresultado" runat="server"></asp:Label>
&nbsp; &nbsp;<br />
<br />
<br />
<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Login.aspx">Login</asp:HyperLink>
</form>
</body>
</html>

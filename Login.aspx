<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<form id="form1" runat="server">
<div>
<div style="text-align: center">
<br />
<br />
<br />
<br />
<br />
<table style="width: 75%">
<tr>
<td style="width: 100px" align="right">
<asp:Label ID="Label1" runat="server" Text="Usuario:" Font-Size="X-Large"></asp:Label></td>
<td style="width: 100px">
<asp:TextBox ID="txtusuario" runat="server"></asp:TextBox></td>
</tr>
<tr>
<td style="width: 100px" align="right">
<asp:Label ID="Label2" runat="server" Text="Password:" Font-Size="X-Large"></asp:Label></td>
<td style="width: 100px">
<asp:TextBox ID="txtpassword" runat="server" TextMode="Password"></asp:TextBox></td>
</tr>
<tr>
<td colspan="2">
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Validar" /></td>
</tr>
</table>
</div>
</div>
<br />
<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Registro.aspx">Registrese</asp:HyperLink>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:Label ID="lblnoregistrado"
runat="server"></asp:Label>
</form>
</body>
</html>

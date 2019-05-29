<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Temas.aspx.cs" Inherits="Temas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<form id="form1" runat="server">
<div>
<br />
<br />
<asp:Label ID="Label1" runat="server" Text="Seleccione Tema:"></asp:Label>
&nbsp;
<asp:DropDownList ID="lsttemas" runat="server">
</asp:DropDownList><br />
<br />
<asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Ver libros</asp:LinkButton></div>
</form>

</body>
</html>

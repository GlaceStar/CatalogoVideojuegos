<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Libros.aspx.cs" Inherits="Libros" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<form id="form1" runat="server">
<div>
<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Listado de libros:"></asp:Label><br />
<br />
<asp:GridView ID="gridlibros" runat="server" >
<Columns>
<asp:CommandField SelectText="Comprar" ShowSelectButton="True" />
</Columns>
</asp:GridView>
<br />
<br />
<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Temas.aspx">Otro tema</asp:HyperLink>&nbsp;<br />
<br />
<br />
<asp:Label ID="lblcesta" runat="server" Text="Cesta de la compra:" Font-Bold="True" Font-Size="Large" Visible="False"></asp:Label><br />
<br />
<asp:GridView ID="gridcesta" runat="server">
<Columns>
<asp:CommandField SelectText="Eliminar" ShowSelectButton="True" />
</Columns>
</asp:GridView>
<br />
<br />
&nbsp;<br />
<asp:LinkButton ID="lkejecutar" runat="server" OnClick="LinkButton1_Click" Visible="False">Ejecutar Compra</asp:LinkButton></div>
</form>
</body>
</html>

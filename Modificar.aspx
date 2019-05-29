<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Modificar.aspx.cs" Inherits="Modificar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <style type="text/css">
        body{
            background:url('Resources/blacky.png');
            padding:15% 20%;
        }
        .label{
            color:goldenrod;
            padding:5% 5%;
            font-size:medium;
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
        .labelM{
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
        <asp:Label ID="Label5" class="labelM" runat="server" Text="Modifica informacion:"></asp:Label>
    <table align="center" >
    <tr>
    <!--td><asp:Label ID="Label1" class="label" runat="server" Text="Tema:"></asp:Label></--td>
    <td><asp:DropDownList ID="pkTema" runat="server" class="list">
        <asp:ListItem Value="0"> --Elije tema-- </asp:ListItem>
        <asp:ListItem Value="1">Plataformas</asp:ListItem>
        <asp:ListItem Value="2">Aventura</asp:ListItem>
        <asp:ListItem Value="3">RPG</asp:ListItem>
        <asp:ListItem Value="4">Estrategia</asp:ListItem>
        <asp:ListItem Value="5">Carreras</asp:ListItem>
        <asp:ListItem Value="6">Hit and Run</asp:ListItem>
        <asp:ListItem Value="7">Habilidad</asp:ListItem>
        <asp:ListItem Value="8">Disparos</asp:ListItem>
        <asp:ListItem Value="9">Supervivencia</asp:ListItem>
        <asp:ListItem Value="10">Simulador</asp:ListItem>
        <asp:ListItem Value="11">Deportes</asp:ListItem>
        <asp:ListItem Value="12">Peleas</asp:ListItem>
        <asp:ListItem Value="13">Hack and Slash</asp:ListItem>
        <asp:ListItem Value="14">Otro</asp:ListItem>
        </asp:DropDownList></td-->

        <td><asp:Label ID="Label1" class="label" runat="server" Text="Que clase de campo deseas alterar?:"></asp:Label></td>
    <td><asp:DropDownList ID="DropDownList1" runat="server" class="list">
        <asp:ListItem Value="1">Titulo</asp:ListItem>
        <asp:ListItem Value="2">Precio</asp:ListItem>
        <asp:ListItem Value="3">Autor</asp:ListItem>
        <asp:ListItem Value="4">Tema</asp:ListItem>
        <asp:ListItem Value="5">Descripcion</asp:ListItem>
        </asp:DropDownList></td>
    </tr>
    <tr>
    <td><asp:Label ID="Label2" class="label" runat="server" Text="Valor que se desea alterar:"></asp:Label></td>
    <td><asp:TextBox ID="txtAlter" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
    <td><asp:Label ID="Label3" class="label" runat="server" Text="Nuevo dato:"></asp:Label></td>
    <td><asp:TextBox ID="txtNuevo" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
    <td colspan="2" align="center"><asp:Button ID="Button1" class="button" runat="server" Text="Hacer" OnClick="Button1_Click" /></td>
    </tr>
    </table>    <br />
         <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Index.aspx">Regresar</asp:HyperLink>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:Label ID="lblcambiado" runat="server"></asp:Label>

    </div>
    </form>
</body>
</html>

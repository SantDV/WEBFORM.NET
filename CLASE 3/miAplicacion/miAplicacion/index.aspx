<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="miAplicacion.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        

        <asp:Label ID="lblNombre" runat="server" Text="Label">Ingrese su nombre</asp:Label>
        <br />
        <asp:TextBox ID="txtNombre" runat="server" Width="227px"></asp:TextBox>
        <br />
        <asp:Label ID="lblProducto" runat="server" Text="Label">Seleccione su producto</asp:Label>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
        <asp:Button ID="btnAgregar" runat="server" Text="Button" OnClick="btnAgregar_Click" />
        <br />

        <asp:Label ID="lblCarrito" runat="server" Text="Label">Mi carrito de compra</asp:Label>
        <br />
        <asp:ListBox ID="lstBCarrito" runat="server" Width="232px"></asp:ListBox>
        <br />
        <asp:Button ID="btnComprar" runat="server" Text="Button" OnClick="btnComprar_Click" />

        
    </form>
</body>
</html>

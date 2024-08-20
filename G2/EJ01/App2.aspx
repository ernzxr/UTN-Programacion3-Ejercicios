<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="App2.aspx.cs" Inherits="EJ01.App2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Introduce un numero: 
            <asp:TextBox ID="txtNumber" runat="server"></asp:TextBox>
            <asp:Button ID="btnMultiply" runat="server" Text="Ver Tabla de Multiplicar" OnClick="btnMultiply_Click" />
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>

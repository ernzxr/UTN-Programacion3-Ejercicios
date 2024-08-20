<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="App1.aspx.cs" Inherits="EJ01.App1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Ingrese su nombre: 
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:Button ID="btnAccept" runat="server" Text="Aceptar" OnClick="btnAccept_Click" />
            <asp:Label ID="lblName" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>

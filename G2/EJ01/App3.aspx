<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="App3.aspx.cs" Inherits="EJ01.App3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Seleccione un color:
            <asp:DropDownList ID="ddlColors" runat="server">
                <asp:ListItem Text="Azul" Value="Azul"></asp:ListItem>
                <asp:ListItem Text="Rojo" Value="Rojo" Selected="True"></asp:ListItem>
                <asp:ListItem Text="Verde" Value="Verde"></asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="btnAccept" runat="server" Text="Aceptar" OnClick="btnAccept_Click" />
            Usted seleciono:
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>

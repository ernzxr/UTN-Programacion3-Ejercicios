<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="App4.aspx.cs" Inherits="EJ01.App4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Selecciona un color:
            <asp:DropDownList ID="ddlColors" runat="server" OnSelectedIndexChanged="ddlColors_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem Text="Rojo" Value="red"></asp:ListItem>
                <asp:ListItem Text="Verde" Value="green"></asp:ListItem>
                <asp:ListItem Text="Azul" Value="blue"></asp:ListItem>
            </asp:DropDownList>
            Usted selecciono:
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>

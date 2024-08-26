<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EjercicioDos.aspx.cs" Inherits="TP2.EjercicioDos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblName" runat="server" Text="Nombre: "></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblLastName" runat="server" Text="Apellido: "></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblCity" runat="server" Text="Ciudad: "></asp:Label>
            <asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="True">
                <asp:ListItem Value="zona norte">Gral. Pacheco</asp:ListItem>
                <asp:ListItem Value="zona oeste">San Miguel</asp:ListItem>
                <asp:ListItem Value="zona sur">Boedo</asp:ListItem>
            </asp:DropDownList>
        </div>
        <asp:Label ID="lblThemes" runat="server" Text="Temas: "></asp:Label>
        <div>
            <asp:CheckBoxList ID="cblThemes" runat="server" AutoPostBack="True">
                <asp:ListItem>Ciencias</asp:ListItem>
                <asp:ListItem>Literatura</asp:ListItem>
                <asp:ListItem>Historia</asp:ListItem>
            </asp:CheckBoxList>
        </div>
        <asp:Button ID="btnPreview" runat="server" Text="Ver resumen" OnClick="btnPreview_Click" />
    </form>
</body>
</html>

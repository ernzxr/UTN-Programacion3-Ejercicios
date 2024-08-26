<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EjercicioDosB.aspx.cs" Inherits="TP2.EjercicioDosB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblTitle" runat="server" Text="Resumen"></asp:Label>
        <div>
            <asp:Label ID="lblNameTitle" runat="server" Text="Nombre: "></asp:Label><asp:Label ID="lblName" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="lblLastNameTitle" runat="server" Text="Apellido: "></asp:Label><asp:Label ID="lblLastName" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="lblZoneTitle" runat="server" Text="Zona: "></asp:Label><asp:Label ID="lblZone" runat="server" Text=""></asp:Label>
        </div>
        <asp:Label ID="lblSelectedThemesTittle" runat="server" Text="Los temas elegidos son:"></asp:Label>
        <div>
            <asp:Label ID="lblSelectedThemes" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>

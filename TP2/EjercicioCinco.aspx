<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EjercicioCinco.aspx.cs" Inherits="TP2.EjercicioCinco1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTitle" runat="server" Text="Elija su configuración"></asp:Label>
        </div>
        <div>
            <asp:Label ID="lblRAM" runat="server" Text="Seleccione cantidad de memoria:"></asp:Label>
        </div>
        <div>
            <asp:DropDownList ID="ddlRAM" runat="server" AutoPostBack="True">
                <asp:ListItem Value="200">2 GB</asp:ListItem>
                <asp:ListItem Value="375">4 GB</asp:ListItem>
                <asp:ListItem Value="500">6 GB</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div>
            <asp:Label ID="lblAccesories" runat="server" Text="Seleccione accesorios:"></asp:Label>
        </div>
        <div>
            <asp:CheckBoxList ID="cblAccesories" runat="server" AutoPostBack="True">
                <asp:ListItem Value="2000.5">Monitor LCD</asp:ListItem>
                <asp:ListItem Value="550.5">HD 500 GB</asp:ListItem>
                <asp:ListItem Value="1200">Grabador DVD</asp:ListItem>
            </asp:CheckBoxList>
        </div>
        <div>
            <asp:Button ID="btnCalculatePrice" runat="server" Text="Calcular Precio" OnClick="btnCalculatePrice_Click" />
        </div>
        <div>
            <asp:Label ID="lblPrice" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>

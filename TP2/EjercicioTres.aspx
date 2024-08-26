<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EjercicioTres.aspx.cs" Inherits="TP2.EjercicioTres" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="lbtnRed" runat="server" OnClick="lbtnRed_Click">Rojo</asp:LinkButton>
        </div>
        <div>
            <asp:LinkButton ID="lbtnBlue" runat="server" OnClick="lbtnBlue_Click">Azul</asp:LinkButton>
        </div>
        <div>
            <asp:LinkButton ID="lbtnGreen" runat="server" OnClick="lbtnGreen_Click">Verde</asp:LinkButton>
        </div>
        <div>
            <asp:Label ID="lblTextColor" runat="server" Text="Texto coloreado"></asp:Label>
        </div>
    </form>
</body>
</html>

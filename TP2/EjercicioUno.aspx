<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EjercicioUno.aspx.cs" Inherits="TP2.EjercicioCinco" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formEjercicioUno" runat="server">
        <div>
            <asp:Label ID="lblProductOne" runat="server" Text="Ingrese nombre del producto:"></asp:Label>
            <asp:TextBox ID="txtProductOneName" runat="server"></asp:TextBox>
            <asp:Label ID="lblUnitsProductOne" runat="server" Text="Cantidad"></asp:Label>
            <asp:TextBox ID="txtProductOneUnits" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblProductTwo" runat="server" Text="Ingrese nombre del producto:"></asp:Label>
            <asp:TextBox ID="txtProductTwoName" runat="server"></asp:TextBox>
            <asp:Label ID="lblUnitsProductTwo" runat="server" Text="Cantidad"></asp:Label>
            <asp:TextBox ID="txtProductTwoUnits" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="btnCreateTable" runat="server" Text="Generar Tabla" OnClick="btnCreateTable_Click" />
        <div>
            <asp:Label ID="lblTable" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>

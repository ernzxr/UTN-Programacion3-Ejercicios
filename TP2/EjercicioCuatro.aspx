<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EjercicioCuatro.aspx.cs" Inherits="TP2.EjercicioCuatro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" aria-multiline="False">
        <table>
            <tr>
                <td>
                    <asp:Label ID="lblUser" runat="server" Text="Usuario: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPassword" runat="server" Text="Clave: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnValidate" runat="server" Text="Validar" OnClick="btnValidate_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>

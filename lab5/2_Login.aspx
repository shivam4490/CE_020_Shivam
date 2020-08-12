<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2_Login.aspx.cs" Inherits="WebApplication5._2_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>user:</td>
                    <td><asp:TextBox ID="username" runat="server"></asp:TextBox></td>
                </tr>
                <br />
                <tr>
                    <td>password:</td>
                    <td><asp:TextBox ID="password"  TextMode="Password" runat="server"></asp:TextBox></td>
                </tr>
            </table>

            <br />
            <asp:Button ID="submit" Text="submit" runat="server" OnClick="Convert" />
            <br />
            <asp:Label ID="Label3" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1_coockie.aspx.cs" Inherits="WebApplication5._1_coockie" %>

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
                    <td>username</td>
                    <td><asp:TextBox ID="username1" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>age</td>
                    <td><asp:TextBox ID="age1" TextMode="Number" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Button ID="button1" OnClick="Button_1" Text="submit" runat="server" /></td>
                </tr>
            </table>
            <asp:Button ID="resetbtn1" OnClick="Delete_btn1" Text="Delete coockie" runat="server" />
            <br />
            <asp:Button ID="showbtn1" OnClick="Show_btn1" Text="show" runat="server" />
            <br />
            <asp:Label ID="showcockie" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert.aspx.cs" Inherits="Lab7_4.Insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 709px;
        }
        .auto-style4 {
            width: 102px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4">Name:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="name" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Semester:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="sem" runat="server" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Cpi:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="cpi" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Contact No:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="cno" runat="server" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Email:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="email" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
        &nbsp;
        <asp:Button ID="Insert_Record" runat="server" OnClick="Insert_Record_Click" Text="Insert" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </form>
</body>
</html>

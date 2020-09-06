<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1_Edit.aspx.cs" Inherits="Lab6.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            margin-left: 0px;
        }
        .auto-style4 {
            width: 241px;
            height: 29px;
        }
        .auto-style5 {
            height: 29px;
        }
        .auto-style6 {
            width: 241px;
        }
        .auto-style7 {
            width: 241px;
            height: 22px;
        }
        .auto-style8 {
            height: 22px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Student ID :
            <asp:TextBox ID="sid" runat="server" Width="38px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Fetch Details" Width="111px" />
            <br />
            <br />
            <br />
            <br />
            <asp:Panel ID="Panel1" runat="server">
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style7">Name :</td>
                        <td class="auto-style8">
                            <asp:TextBox ID="name" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">Semester :</td>
                        <td class="auto-style5">
                            <asp:TextBox ID="sem" runat="server" CssClass="auto-style3"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">Mobile No : </td>
                        <td>
                            <asp:TextBox ID="mob" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">Email :</td>
                        <td>
                            <asp:TextBox ID="email" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update Record" />
&nbsp;&nbsp;&nbsp;<br />
            <br />
&nbsp;<asp:Label ID="Label1" runat="server" ForeColor="Black"></asp:Label>
        </div>
    </form>
</body>
</html>

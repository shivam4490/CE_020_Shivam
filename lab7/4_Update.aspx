<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="Lab7_4.Update" %>

<!DOCTYPE html>
<script runat="server">

    
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 100%;
        }
        .auto-style7 {
            width: 171px;
            height: 22px;
        }
        .auto-style8 {
            height: 22px;
        }
        .auto-style5 {
            height: 29px;
        }
        .auto-style3 {
            margin-left: 0px;
        }
        .auto-style9 {
            margin-bottom: 0px;
        }
        .auto-style10 {
            margin-left: 40px;
        }
        .auto-style11 {
            width: 171px;
            height: 29px;
        }
        .auto-style12 {
            width: 171px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            Student&nbsp; ID:
            <asp:TextBox ID="student_id" runat="server" Width="47px"></asp:TextBox>
        </div>
        <asp:Button ID="FetchRecord" runat="server"  Text="Fetch" OnClick="FetchRecord_Click" Width="110px" />
&nbsp;&nbsp;&nbsp;<br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Panel ID="Panel1" runat="server" CssClass="auto-style9">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style7">Name :</td>
                    <td class="auto-style8">
                        <asp:TextBox ID="name" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11">Semester :</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="sem" runat="server" CssClass="auto-style3"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11">Cpi:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="cpi" runat="server" CssClass="auto-style3"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">Contact&nbsp; Number : </td>
                    <td>
                        <asp:TextBox ID="mob" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">Email :</td>
                    <td>
                        <asp:TextBox ID="email" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <div>
            <br />
        </div>
        <div class="auto-style10">
            <asp:Button ID="RecordUpdated" runat="server" Text="Update" OnClick="RecordUpdated_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            &nbsp;
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>

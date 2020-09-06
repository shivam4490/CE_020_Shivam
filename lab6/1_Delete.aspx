<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1_Delete.aspx.cs" Inherits="Lab6.Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form2" runat="server">
        <div>
            Student ID :
            <asp:TextBox ID="sid" runat="server" Width="25px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Delete Record" />
&nbsp;&nbsp;&nbsp;<br />
            <br />
&nbsp;<asp:Label ID="Label1" runat="server" ForeColor="Black"></asp:Label>
        </div>
    </form>
    
</body>
</html>

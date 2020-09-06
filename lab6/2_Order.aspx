<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2_Order.aspx.cs" Inherits="Lab6_2.Order" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            </div>
        <p>
            Ordered Items:
        </p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="pname" HeaderText="Product" />
                <asp:BoundField DataField="cost" HeaderText="Price" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
        <br />
        <asp:Label ID="bill" runat="server"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Button ID="logout" runat="server" OnClick="LogOut_Click" Text="LogOut" />
    <p>
        <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
    </form>
    </body>
</html>

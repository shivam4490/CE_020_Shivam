<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2_Product.aspx.cs" Inherits="Lab6_2.Product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Products:</p>
        <p>
            <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" >
                <Columns>
                    <asp:BoundField DataField="pname" HeaderText="Product" SortExpression="pname" />
                    <asp:BoundField DataField="description" HeaderText="Description" SortExpression="description" />
                    <asp:BoundField DataField="cost" HeaderText="Cost" SortExpression="cost" />
                </Columns>
            </asp:GridView>
        </p>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [pname], [description], [cost] FROM [Product]"></asp:SqlDataSource>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:ListBox ID="itemList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="itemList_SelectedIndexChanged" SelectionMode="Multiple"></asp:ListBox>
        </p>
        <p>
            Ordered Items:</p>
        <p>
            <asp:ListBox ID="orderList" runat="server" AutoPostBack="True" ></asp:ListBox>
        </p>
        <p>
            <asp:Button ID="Place_Order" runat="server" OnClick="Place_Order_Click" Text="Place Order" />
        </p>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2_Home.aspx.cs" Inherits="WebApplication5._2_Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label5" runat="server"></asp:Label>
            <br />
            <br />
            <asp:RadioButtonList ID="RadioButtonList1" AutoPostBack="true" OnSelectedIndexChanged="Select_Items" RepeatDirection="Horizontal" runat="server">
                <asp:ListItem>Electronics</asp:ListItem>
                <asp:ListItem Value="Books">Books</asp:ListItem>
            </asp:RadioButtonList>
	    <br />
	    use 'ctrl +' to select multiple iteams
            <br />
            <asp:ListBox ID="ListBox1" Height="300" Width="300" SelectionMode="Multiple" runat="server">
                <asp:ListItem Value="52000">Laptop</asp:ListItem>
                <asp:ListItem Value="20000">Mobile</asp:ListItem>
                <asp:ListItem Value="18000">Tablets</asp:ListItem>
                <asp:ListItem Value="5000">headphones</asp:ListItem>
                <asp:ListItem Value="300">zero to one</asp:ListItem>
                <asp:ListItem Value="150">Autobiography of yogi</asp:ListItem>
                <asp:ListItem Value="800">Inteligent investor</asp:ListItem>
                <asp:ListItem Value="350">The Rudest book ever</asp:ListItem>
            </asp:ListBox>
            <br />
            <br /> 
            <asp:Button ID="Order_Button" OnClick="Place_Order"  runat="server" Text="Place Order" />
           
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Lab7_4.Show" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" DataKeyNames="sid">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="sid" HeaderText="sid" ReadOnly="True" SortExpression="sid" InsertVisible="False" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StudentDBConnectionString %>" DeleteCommand="DELETE FROM [Student] WHERE [sid] = @sid" InsertCommand="INSERT INTO [Student] ([name]) VALUES (@name)" SelectCommand="SELECT [sid], [name] FROM [Student]" UpdateCommand="UPDATE [Student] SET [name] = @name WHERE [sid] = @sid">
            <DeleteParameters>
                <asp:Parameter Name="sid" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="name" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="name" Type="String" />
                <asp:Parameter Name="sid" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False" DataKeyNames="sid" DataSourceID="SqlDataSource2" Height="50px" Width="125px">
            <Fields>
                <asp:BoundField DataField="sid" HeaderText="sid" InsertVisible="False" ReadOnly="True" SortExpression="sid" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                <asp:BoundField DataField="sem" HeaderText="sem" SortExpression="sem" />
                <asp:BoundField DataField="cpi" HeaderText="cpi" SortExpression="cpi" />
                <asp:BoundField DataField="contactno" HeaderText="contactno" SortExpression="contactno" />
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
            </Fields>
        </asp:DetailsView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:StudentDBConnectionString %>" DeleteCommand="DELETE FROM [Student] WHERE [sid] = @sid" InsertCommand="INSERT INTO [Student] ([name], [sem], [cpi], [contactno], [email]) VALUES (@name, @sem, @cpi, @contactno, @email)" SelectCommand="SELECT * FROM [Student] WHERE ([sid] = @sid)" UpdateCommand="UPDATE [Student] SET [name] = @name, [sem] = @sem, [cpi] = @cpi, [contactno] = @contactno, [email] = @email WHERE [sid] = @sid">
            <DeleteParameters>
                <asp:Parameter Name="sid" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="name" Type="String" />
                <asp:Parameter Name="sem" Type="Int32" />
                <asp:Parameter Name="cpi" Type="Double" />
                <asp:Parameter Name="contactno" Type="Int64" />
                <asp:Parameter Name="email" Type="String" />
            </InsertParameters>
            <SelectParameters>
                <asp:ControlParameter ControlID="GridView1" Name="sid" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="name" Type="String" />
                <asp:Parameter Name="sem" Type="Int32" />
                <asp:Parameter Name="cpi" Type="Double" />
                <asp:Parameter Name="contactno" Type="Int64" />
                <asp:Parameter Name="email" Type="String" />
                <asp:Parameter Name="sid" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="webapp4.home" %>

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
                    <td>Full Name</td>
                    <td><asp:TextBox id="fullname1" runat="server"  ></asp:TextBox> </td>
                    <td><asp:RequiredFieldValidator ID="requiredfieldvalidator1" 
                        ForeColor="red"
                        ErrorMessage="name required" 
                        runat="server" 
                        ControlToValidate="fullname1" ></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>Age</td>
                    <td><asp:TextBox ID="age1" runat="server" TextMode="Number"></asp:TextBox></td>
                    <td><asp:RangeValidator ID="rangevalidator1" 
                        ErrorMessage="enter age between 18 to 50" 
                        ForeColor="Red"
                        runat="server" 
                        ControlToValidate="age1" 
                        Display="Dynamic" 
                        SetFocusOnError="true" 
                        Type="Integer" 
                        MinimumValue="18" 
                        MaximumValue="50"></asp:RangeValidator> </td>
                </tr>
                <tr>
                    <td>password</td>
                    <td><asp:TextBox ID="password1" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>confirm password</td>
                    <td><asp:TextBox ID="password2" runat="server" TextMode="Password"></asp:TextBox></td>
                    <td><asp:CompareValidator ID="comparevalidator1" 
                        runat="server" 
                        ControlToCompare="password1" 
                        ControlToValidate="password2" 
                        ForeColor="Red"
                        Display="Dynamic" 
                        ErrorMessage="password and confirm password must be same"></asp:CompareValidator> </td>
                </tr>
                <tr>
                    <td>Gender</td>
                    <td>
                        <asp:RadioButtonList ID="RadioButtonList1" RepeatDirection="Horizontal" runat="server">
                            <asp:ListItem>male</asp:ListItem>
                            <asp:ListItem>female</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>Mobile no.</td>
                    <td><asp:TextBox ID="mobile1" TextMode="Number" runat="server"></asp:TextBox></td>
                    <td><asp:RegularExpressionValidator ID="regexvalidator1" 
                        runat="server" 
                        ForeColor="Red"
                        ControlToValidate="mobile1" 
                        ErrorMessage="mobile no must be of 10 digit"  
                        ValidationExpression="\d{10}" 
                        Display="Dynamic"></asp:RegularExpressionValidator> </td>
                </tr>
                <tr>
                    <td>Hobbies</td>
                    <td>
                        <asp:CheckBoxList ID="CheckBoxList1" RepeatDirection="Horizontal" runat="server">
                            <asp:ListItem>reading</asp:ListItem>
                            <asp:ListItem>football</asp:ListItem>
                            <asp:ListItem>drawing</asp:ListItem>
                            <asp:ListItem>traveling</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>State</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" AutoPostBack="true" OnSelectedIndexChanged="Drop_Load" runat="server">
                            <asp:ListItem Value="">--Select State--</asp:ListItem>
                            <asp:ListItem>Gujarat</asp:ListItem>
                            <asp:ListItem>Maharastra</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>City</td>
                    <td>
                        <asp:DropDownList ID="DropDownList2" runat="server">
                            <asp:ListItem Value="">--Select City--</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>PAN number</td>
                    <td><asp:TextBox ID="pan1" runat="server"></asp:TextBox></td>
                    <td><asp:CustomValidator ID="customvalidator1"
                        runat="server"
                        ForeColor="Red"
                        ErrorMessage="pan number should be 10 digit and first character should be A or B"
                        ControlToValidate="pan1"
                        OnServerValidate="PanServerValidate1"></asp:CustomValidator></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="submit1" Text="submit" OnClick="Submit_Click1" runat="server" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
    <br />
    <asp:Label ID="label21" runat="server"></asp:Label>
    <br />
    <asp:Label ID="username2" runat="server"></asp:Label>
    <br />
    <asp:Label ID="age2" runat="server"></asp:Label>
    <br />
    <asp:Label ID="password3" runat="server"></asp:Label>
    <br />
    <asp:Label ID="gender2" runat="server"></asp:Label>
    <br />
    <asp:Label ID="mobile2" runat="server"></asp:Label>
    <br />
    <asp:Label ID="hobbie2" runat="server"></asp:Label>
    <br />
    <asp:Label ID="state2" runat="server"></asp:Label>
    <br />
    <asp:Label ID="city2" runat="server"></asp:Label>
    <br />
    <asp:Label ID="pan2" runat="server"></asp:Label>



</body>
</html>

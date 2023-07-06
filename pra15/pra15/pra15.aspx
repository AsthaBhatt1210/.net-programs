<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="pra15.aspx.vb" Inherits="pra15.pra15" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Table1]"></asp:SqlDataSource>
        <br />
        <br />
        <br />
        <br />
        Name:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Email:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        PhoneNo:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        Password:
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>

<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="session.aspx.vb" Inherits="sessionpra11.session" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="Label1" runat="server" Text="Enter Your Name" />
    <asp:TextBox ID="TextBox1" runat="server" />
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Enter Your Password" />
    <asp:TextBox ID="TextBox2" runat="server" />
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Store Value" />
    <br />
    </div>
    </form>
</body>
</html>

<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Hidden Field.aspx.vb" Inherits="Hidden_Field.Hidden_Field" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Click here" />
        <br />
        <br />
    
        <asp:HiddenField ID="HiddenField1" runat="server" />
        <asp:Button ID="Button2" runat="server" Text="Get Text" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>

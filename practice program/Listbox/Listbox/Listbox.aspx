<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Listbox.aspx.vb" Inherits="Listbox.Listbox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Height="71px">
            <asp:ListItem>Mango</asp:ListItem>
            <asp:ListItem>Banana</asp:ListItem>
            <asp:ListItem>Graps</asp:ListItem>
        </asp:ListBox>
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>

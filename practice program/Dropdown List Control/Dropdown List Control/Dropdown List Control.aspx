<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Dropdown List Control.aspx.vb" Inherits="Dropdown_List_Control.Dropdown_List_Control" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
            <asp:ListItem>Apple</asp:ListItem>
            <asp:ListItem>Mango</asp:ListItem>
            <asp:ListItem>Banana</asp:ListItem>
            <asp:ListItem>Orange</asp:ListItem>
            <asp:ListItem>Grapes</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Submit" />
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
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

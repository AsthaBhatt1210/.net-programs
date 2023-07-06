<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Viewstate.aspx.vb" Inherits="Viewstate.Viewstate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:View ID="View1" runat="server" EnableViewState="False" />
      <br />
     Enter Your Name:&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" EnableViewState="False" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" EnableViewState="False" Text="Store" />
        <br />
        Show Your Name:&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" EnableViewState="False" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" EnableViewState="False" Text="Fetch" />
        &nbsp;
    </div>
    </form>
</body>
</html>

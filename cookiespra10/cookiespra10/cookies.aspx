<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="cookies.aspx.vb" Inherits="cookiespra10.cookies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Enter Name:" />
        <asp:TextBox ID="TextBox1" runat="server" />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Enter Password:" />

        <asp:TextBox ID="TextBox2" runat="server" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Store"/>
        <br />
        <br />

        <asp:Label ID="Label3" runat="server" Text="Name:" />
        <asp:TextBox ID="TextBox3" runat="server" />
        <br />

        <asp:Label ID="Label4" runat="server" Text="Password:" />
        <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 30px; margin-bottom: 0px" />
        <br />

        <asp:Label ID="Label5" runat="server" Text="Expire Date:" />
        <asp:TextBox ID="TextBox5" runat="server" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Fetch"/>
        <br />
        <br />
        <br />
     <br />
    </div>
    </form>
</body>
</html>

<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="pra6.aspx.vb" Inherits="pra6.pra6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="Myformat.css" />
    <title>Pratical 6</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Enter Roll No:" BorderStyle="Dotted" BackColor="Coral"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="TxtStyle" BackColor="Maroon" BorderColor="Goldenrod"></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="Enter Name:" CssClass="Common"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" CssClass="TxtStyle" BackColor="Maroon" BorderColor="Goldenrod"></asp:TextBox><br />
         <asp:Label ID="Label3" runat="server" Text="Enter Marks:" CssClass="Common"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" CssClass="TxtStyle" BackColor="Maroon" BorderColor="Goldenrod"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="Submit" CssClass="BtnStyle" />
        <asp:Button ID="Button2" runat="server" Text="Clear" CssClass="BtnStyle" />
    </div>
    </form>
    <p>
        <a href="pra6.aspx">pra6.aspx</a></p>
</body>
</html>

<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="QueryString.aspx.vb" Inherits="pra9QueryString.QueryString" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Enter Your Name :        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Enter Your Age :
        <asp:TextBox ID="TextBox2" runat="server" MaxLength="100" TextMode ="Number"></asp:TextBox>
          <br />
          <br />
          <asp:Button ID="Button1" runat="server" Text="Query String" />
    </div>
    </form>
</body>
</html>

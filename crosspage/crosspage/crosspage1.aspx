<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="crosspage1.aspx.vb" Inherits="crosspage.crosspage1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cross Page Posting Example</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <asp:Label ID="Label1" runat="server" Text="Enter The Value" />
        <asp:TextBox ID="TextBox1" runat="server" />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Post_Back" PostBackUrl="~/Crosspage2.aspx" />
    </div>
    </form>
</body>
</html>

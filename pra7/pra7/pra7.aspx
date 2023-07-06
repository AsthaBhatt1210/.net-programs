<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="pra7.aspx.vb" Inherits="pra7.pra7" StylesheetTheme="Myskin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>practical 7</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <p><asp:Label ID="label1" runat="server" Text="Label1" SkinID="11"></asp:Label></p>
     <p><asp:TextBox ID="TextBox1" runat="server" SkinID="t1">Textbox1</asp:TextBox></p>
     <p><asp:TextBox ID="TextBox2" runat="server" SkinID="t2">Textbox2</asp:TextBox></p>
     <p><asp:TextBox ID="TextBox3" runat="server" SkinID="t3">Textbox3</asp:TextBox></p>
     <p><asp:button ID="Button1" runat="server" Text="Submit" SkinID="b3" /></p>

    </div>
    </form>
</body>
</html>

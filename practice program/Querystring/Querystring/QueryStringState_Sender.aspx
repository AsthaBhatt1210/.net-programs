<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="QueryStringState_Sender.aspx.vb" Inherits="Querystring.QueryStringState_Sender" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        City:<asp:TextBox ID="txtcity" runat="server" />
        <br />
        Country:<asp:TextBox ID="txtcountry" runat="server" />
        <br />
        <asp:Button ID="btnGO" runat="server" Text="Button" />
    </div>
    </form>
</body>
</html>

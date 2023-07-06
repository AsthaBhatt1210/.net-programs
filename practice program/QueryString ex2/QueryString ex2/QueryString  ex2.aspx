<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="QueryString  ex2.aspx.vb" Inherits="QueryString_ex2.QueryString__ex2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>First Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         QueryStringExample <asp:HyperLink ID="HpyerLink1" runat="server" NavigateUrl="~/Image.aspx?ImageID=1" Text="Test QueryString" />

    </div>
    </form>
</body>
</html>

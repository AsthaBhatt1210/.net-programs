<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="pra2.aspx.vb" Inherits="pra2.pra2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ASP .NET</title>
</head>
<body>
    
    
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Click me" 
        
        onmouseover="this.style.backgroundColor='yellow'" onmouseout="this.style.backgroundColor='lightgreen'" />
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

<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="pra3.aspx.vb" Inherits="pra3.pra3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Enter Name:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:CheckBox ID="chkbold" runat="server" Text="BOLD" />
&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="chkitalic" runat="server" Text="ITALIC" />
&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="chkunderline" runat="server" Text="UNDERLINE" />
        <br />
        <br />
        <asp:RadioButton ID="rbred" runat="server" Text="RED" GroupName="color" />
&nbsp;&nbsp;
        <asp:RadioButton ID="rbgreen" runat="server" Text="GREEN" GroupName="color" />
&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="rbpink" runat="server" Text="PINK" GroupName="color" />
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Enter Message:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtmessage" runat="server" TextMode="MultiLine"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="lblDisplay" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BtnDisplay" runat="server" Text="Display" />
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

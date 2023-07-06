<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Database.aspx.vb" Inherits="Database.Database" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Table1]"></asp:SqlDataSource>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Insert" />
        <br />
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server">Empid</asp:TextBox>
&nbsp;
        <asp:TextBox ID="TextBox2" runat="server">Empname</asp:TextBox>
&nbsp;
        <asp:TextBox ID="TextBox3" runat="server">Empage</asp:TextBox>
        <br />
        <asp:Button ID="Button2" runat="server" Text="Insert" />
        <br />
        <br />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button3" runat="server" Text="Delete" />
        <br />
        <br />
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button4" runat="server" Text="Update" />
        <br />
        <br />
        <asp:Button ID="Button5" runat="server" Text="Show" />
        <br />
        <br />
        <asp:Button ID="Button6" runat="server" Text="No of record" />
        <br />
        <br />
        <asp:Button ID="Button7" runat="server" Text="Max age" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="Empid" HeaderText="Empid" SortExpression="Empid" />
                <asp:BoundField DataField="Empname" HeaderText="Empname" SortExpression="Empname" />
                <asp:BoundField DataField="Empage" HeaderText="Empage" SortExpression="Empage" />
            </Columns>
        </asp:GridView>
        <br />
        <br />
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
        <asp:Button ID="Button8" runat="server" Text="Gridview" />
        <br />
        <br />
        <br />
        <br />
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

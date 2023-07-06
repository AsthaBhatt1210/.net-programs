<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="Order.aspx.vb" Inherits="pra19.Order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        &nbsp;</p>
<p>
    Orderid:&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="RequiredFieldValidator" ForeColor="Red" >* Order id must required</asp:RequiredFieldValidator>
</p>
<p>
    Ordername:&nbsp;
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
</p>
<p>
    Nooforder:&nbsp; &nbsp;
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button1" runat="server" Text="InsertOrder" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" Text="UpdateOrder" />
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button3" runat="server" Text="DeleteOrder" />
</p>
<p>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Table1]"></asp:SqlDataSource>
</p>
<p>
    &nbsp;</p>
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Orderid" DataSourceID="SqlDataSource1">
    <Columns>
        <asp:BoundField DataField="Orderid" HeaderText="Orderid" ReadOnly="True" SortExpression="Orderid" />
        <asp:BoundField DataField="Ordername" HeaderText="Ordername" SortExpression="Ordername" />
        <asp:BoundField DataField="Nooforder" HeaderText="Nooforder" SortExpression="Nooforder" />
    </Columns>
</asp:GridView>
<p>
    &nbsp;</p>
</asp:Content>

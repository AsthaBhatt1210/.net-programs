Public Class Login1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Write("<BR> NAME: " & Request.QueryString("Name"))
        Response.Write("<BR> EMAIL: " & Request.QueryString("Email"))
        Response.Write("<BR> PHONENO: " & Request.QueryString("PhoneNo"))
        Response.Write("<BR> PASSWORD: " & Request.QueryString("Password"))
        Response.Write("<BR>")
        Response.Write("connection with database is successful")
    End Sub
End Class
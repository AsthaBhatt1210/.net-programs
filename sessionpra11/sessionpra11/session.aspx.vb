Public Class session
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Session("name") = TextBox1.Text
        Session("pass") = TextBox2.Text
        Response.Redirect("session2.aspx")
    End Sub

End Class
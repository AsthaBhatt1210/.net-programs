Public Class QueryString
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("QueryString2.aspx?Name=abc&Age=18")
        Response.Redirect("QueryString2.aspx? Name = " & TextBox1.Text & "Age is= " & TextBox2.Text)
    End Sub
End Class
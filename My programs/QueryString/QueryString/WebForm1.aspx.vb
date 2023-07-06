Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("WebForm2.aspx?Name=astha&Age=17")
        Response.Redirect("WebForm2.aspx" & TextBox1.Text & "Age is= " & TextBox2.Text)
    End Sub
End Class
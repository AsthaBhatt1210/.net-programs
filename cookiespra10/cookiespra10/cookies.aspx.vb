Public Class cookies
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load    End Sub

    Protected Sub Button1_Click(sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim tmpcookie As New HttpCookie("VisitUser")
        tmpcookie.Values("Name") = TextBox1.Text
        tmpcookie.Values("Pwd") = TextBox2.Text
        tmpcookie.Values("Dt") = DateTime.Now.ToString
        tmpcookie.Expires = DateTime.Now.AddDays(1)
        Response.Cookies.Add(tmpcookie)
        Response.Write("cookie generate")
    End Sub

    Protected Sub Button2_Click(sender As Object, ByVal e As EventArgs) Handles Button2.Click
        TextBox3.Text = Request.Cookies("VisitUser").Values("Name").ToString
        TextBox4.Text = Request.Cookies("VisitUser").Values("Pwd").ToString
        TextBox5.Text = Request.Cookies("VisitUser").Values("Dt").ToString
    End Sub


End Class
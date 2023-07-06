Public Class Crosspage2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Label1.Text = PreviousPage.Title.ToString
        Dim ename As TextBox = DirectCast(PreviousPage.FindControl("TextBox1"), TextBox)
        Label2.Text = ename.Text
    End Sub

End Class
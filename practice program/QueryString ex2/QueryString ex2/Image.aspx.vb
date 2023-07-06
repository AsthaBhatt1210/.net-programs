Public Class Image
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ID As String = Request.QueryString("ImageID")
        Label1.Text = "ImageID: " & ID
    End Sub

End Class
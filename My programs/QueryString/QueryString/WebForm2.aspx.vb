Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.Write("Name is: " & Request.QueryString("Name"))
        Response.Write("Age is: " & Request.QueryString("Age"))
    End Sub

End Class
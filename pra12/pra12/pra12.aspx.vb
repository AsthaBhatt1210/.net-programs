Public Class pra12
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cnt As Integer
        cnt = Application("NoOfVisitors")
        Response.Write("Total visitors: " & cnt)
    End Sub

End Class
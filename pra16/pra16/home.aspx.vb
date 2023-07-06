Public Class home
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim sid, spass As String
        sid = Session("USERNAME")
        spass = Session("PASSWORD")
        Response.Write("YOUR NAME IS :" & sid)
        Response.Write("<br>YOUR PASSWORD IS :" & spass)
    End Sub

End Class
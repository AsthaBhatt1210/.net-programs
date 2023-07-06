Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Sname As String
        Dim Stuid As String

        Sname = ConfigurationManager.AppSettings("Sname")
        Stuid = ConfigurationManager.AppSettings("Stuid")

        Response.Write("My name is: " & Sname)
        Response.Write("<BR>My Enrollno : " & Stuid)
    End Sub

End Class
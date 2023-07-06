Public Class Orderdetails
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim oname As String
        Dim ono As Integer
        oname = Session("Ordername")
        ono = Session("Nooforder")
        Response.Write("NAME OF ORDER :" & oname)
        Response.Write("<br>NO OF ORDER :" & ono)
    End Sub

End Class
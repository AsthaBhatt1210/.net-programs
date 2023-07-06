Partial Class QueryStringState_Recive
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtcity.Text = Request.QueryString("city")
        txtcountry.Text = Request.QueryString("country")
    End Sub

End Class
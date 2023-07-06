Partial Class QueryStringState_Sender
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnGO_Click(sender As Object, e As EventArgs) Handles btnGO.Click
        Response.Redirect("QueryStringState_Recive.aspx?city=" & txtcity.Text & "&country=" & txtcountry.Text)
    End Sub
End Class
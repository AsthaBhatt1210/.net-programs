Public Class Hidden_Field
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        HiddenField1.Value = TextBox1.Text
    End Sub

    Protected Sub HiddenField1_ValueChanged(sender As Object, e As EventArgs) Handles HiddenField1.ValueChanged

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text = HiddenField1.Value
    End Sub
End Class
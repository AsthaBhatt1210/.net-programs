Public Class checkbox
    Inherits System.Web.UI.Page

    Protected Sub Check1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Check1_SelectedIndexChanged

        Dim i As String
        Label1.Text = "Selected Items"
        For i = 0 To Check1.Items.Count - 1
            If Check1.Items(i).Selected Then
                Label1.Text += Check1.Items(i).Text + "<br/>"
            End If
        Next
    End Sub

End Class
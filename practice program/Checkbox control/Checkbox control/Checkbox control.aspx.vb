Public Class Checkbox_control
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles check1.SelectedIndexChanged
        Dim i As Integer
        Label1mess.Text = "<p>Selected Items(s):</p>"
        For i = 0 To check1.Items.Count - 1
            If check1.Items(i).Selected Then
                Label1.Text += check1.Items(i).Text + "<br/>"

            End If
        Next
    End Sub

End Class
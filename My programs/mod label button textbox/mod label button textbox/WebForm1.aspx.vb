Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim no As Integer
        no = TextBox1.Text

        If no Mod 2 = 0 Then
            Label2.Text = "No is even"
        Else
            Label2.Text = "No is odd"
        End If
    End Sub
End Class
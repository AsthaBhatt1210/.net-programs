Public Class Radiobutton
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Protected Sub Submit(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            {
             Response.Write("Color"+RedRadioButton "<br/>"
            }


        End If
    End Sub

    Protected Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub
End Class
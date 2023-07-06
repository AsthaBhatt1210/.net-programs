Public Class pra3
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnDisplay.Click
        Response.Write("Enter Name = " & txtname.Text)

        If chkbold.Checked = True Then
            lblDisplay.Font.Bold = True
        Else
            lblDisplay.Font.Bold = False
        End If

        If chkitalic.Checked = True Then
            lblDisplay.Font.Italic = True
        Else
            lblDisplay.Font.Italic = False
        End If

        If chkunderline.Checked = True Then
            lblDisplay.Font.Underline = True
        Else
            lblDisplay.Font.Underline = False
        End If

        If rbred.Checked = True Then
            lblDisplay.ForeColor = System.Drawing.Color.Red
        ElseIf rbgreen.Checked = True Then
            lblDisplay.ForeColor = System.Drawing.Color.Green
        ElseIf rbpink.Checked = True Then
            lblDisplay.ForeColor = System.Drawing.Color.Pink
        End If

        lblDisplay.Text = "Name:" & txtname.Text & "<br/>" & "Message:" & txtmessage.Text

    End Sub
End Class
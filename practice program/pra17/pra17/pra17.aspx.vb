Imports System.Data.SqlClient
Public Class pra17
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cnn As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True")
        Dim str As String
        str = "Insert into Table1 values('" & TextBox1.Text & "','" & TextBox2.Text & "')"
        Dim cmd As New SqlCommand(str, cnn)
        cnn.Open()
        cmd.ExecuteNonQuery()
        cnn.Close()
        MsgBox("Password ADD successfully")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cnn As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True")
        Dim str As String
        str = "update Table1 set USERPASSWORD= '" & TextBox2.Text & "' where USERNAME= '" & TextBox1.Text & "' "
        Dim cmd As New SqlCommand(str, cnn)
        cnn.Open()
        cmd.ExecuteNonQuery()
        cnn.Close()
        MsgBox("Password UPDATE successfully")
    End Sub
End Class
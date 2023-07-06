Imports System.Data.SqlClient

Public Class DatabaseInsert
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cnn As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True")
        Dim str As String
        str = "Insert into Table1 values(4,'Puja')"
        Dim cmd As New SqlCommand(str, cnn)
        cnn.Open()
        If cmd.ExecuteNonQuery Then
            MsgBox("Record insert successfully")
        End If
        cnn.Close()
    End Sub


    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Sid As Integer
        Dim Sname As String
        Sid = TextBox1.Text
        Sname = TextBox2.Text
        Dim cnn As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True")
        Dim str As String
        str = "Insert into Table1 values(" & Sid & ",'" & Sname & "')"
        Dim cmd As New SqlCommand(str, cnn)
        cnn.Open()
        If cmd.ExecuteNonQuery Then
            MsgBox("Record insert successfully")
        End If
        cnn.Close()
    End Sub
End Class
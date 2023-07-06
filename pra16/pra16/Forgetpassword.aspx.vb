Imports System.Data.SqlClient
Public Class Forgetpassword
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connect As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True")
        Dim str As String
        str = "update Table1 set PASSWORD= '" & TextBox2.Text & "' where USERNAME= '" & TextBox1.Text & "' "
        Dim command As New SqlCommand(str, connect)
        connect.Open()
        command.ExecuteNonQuery()
        connect.Close()
        MsgBox("Password is successfully changed")
        Response.Redirect("Login.aspx")
    End Sub
End Class
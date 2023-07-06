Imports System.Data.SqlClient

Public Class pra15
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim name, email, phoneno, password As String
        name = TextBox1.Text
        email = TextBox2.Text
        phoneno = TextBox3.Text
        password = TextBox4.Text
        Dim cnn As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True")
        Dim str As String
        str = "Insert into Table1 values('" & name & "','" & email & "','" & phoneno & "','" & password & "')"
        Dim cmd As New SqlCommand(str, cnn)
        cnn.Open()
        If cmd.ExecuteNonQuery() Then
            MsgBox("Connection successfully")
        End If
        cnn.Close()
        Response.Redirect("Login.aspx?name=" & name & "&Email=" & email & "&PhoneNo=" & phoneno & "&Password=" & password)
    End Sub
End Class
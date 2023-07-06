Imports System.Data.SqlClient
Public Class Login1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim str As String
        str = "select * from Table1 where USERNAME='" & TextBox1.Text & "' and PASSWORD='" & TextBox2.Text & "'"
        Dim cnn As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand(str, cnn)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            Session("USERNAME") = TextBox1.Text
            Session("PASSWORD") = TextBox2.Text
            Response.Redirect("home.aspx")
        Else
            Response.Write("Either Name or Password is wrong")
        End If
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect("Forgetpassword.aspx")
    End Sub
End Class
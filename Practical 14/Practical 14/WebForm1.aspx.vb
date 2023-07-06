Imports System.Data.SqlClient
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String
        str = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True"
        Dim cn As New SqlConnection(str)
        Dim q As String = "select * from Table1 where Sname = ' " + TextBox1.Text.Trim() + " ' "
        Dim cmd As New SqlCommand(q, cn)
        cn.Open()

        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader()

        If dr.Read() Then
            Label1.Text = dr("Sname").ToString()
            Label2.Text = dr("Sid").ToString()
            cn.Close()
        Else
            Response.Write("No Such Data Found")
            cn.Close()
        End If
    End Sub
End Class
   
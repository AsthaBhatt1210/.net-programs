Imports System.Data.SqlClient

Public Class Database
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cnn As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True")
        Dim str As String
        str = "Insert into Table1 values(4,'Puja',20)"
        Dim cmd As New SqlCommand(str, cnn)
        cnn.Open()
        If cmd.ExecuteNonQuery Then
            MsgBox("Record insert successfully")
        End If
        cnn.Close()

    End Sub


    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim eno, eage As Integer
        Dim ename As String
        eno = TextBox1.Text
        ename = TextBox2.Text
        eage = TextBox3.Text
        Dim cnn As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True")
        Dim str As String
        str = "Insert into Table1 values(" & eno & ",'" & ename & "'," & eage & ")"
        Dim cmd As New SqlCommand(str, cnn)
        cnn.Open()
        If cmd.ExecuteNonQuery Then
            MsgBox("Record insert successfully")
        End If
        cnn.Close()

    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim eno As Integer
        eno = TextBox4.Text
        Dim str As String
        Dim cnn As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True")
        str = "delete from Table1 where eno=" & eno
        Dim cmd As New SqlCommand(str, cnn)
        cnn.Open()
        cmd.ExecuteNonQuery()
        cnn.Close()
        MsgBox("Record Deleted")

    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim eno As Integer, ename As String
        eno = TextBox5.Text
        ename = TextBox6.Text
        Dim str As String
        Dim cnn As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True")
        str = "update Table1 set Empname = '" & ename & "'where Empid=" & eno
        Dim cmd As New SqlCommand(str, cnn)
        cnn.Open()
        If cmd.ExecuteNonQuery Then
            MsgBox("Record updated")
        End If
        cnn.Close()
    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim cnn As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True")
        Dim str As String
        str = "select * from Table1"
        Dim cmd As New SqlCommand(str, cnn)
        cnn.Open()
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            Response.Write("<BR>" & dr.Item(0) & "," & dr.Item(1) & "," & dr.Item(2))
        End While
        cnn.Close()
    End Sub

    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim tr As Integer
        Dim cnn As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True")
        Dim str As String
        str = "select count(*) from Table1"
        Dim cmd As New SqlCommand(str, cnn)
        cnn.Open()
        tr = cmd.ExecuteScalar()
        Response.Write("Total Records are: " & tr)
        cnn.Close()
    End Sub

    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim cnn As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True")
        Dim str As String, ans As Integer
        str = "select max(Empage) from Table1"
        Dim cmd As New SqlCommand(str, cnn)
        cnn.Open()
        ans = cmd.ExecuteScalar()
        MsgBox("Maximum age: " & ans)
        cnn.Close()
    End Sub


    Protected Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim cnn As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True")
        Dim str As String
        str = "select * from Table1"
        Dim cmd As New SqlCommand(str, cnn)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New Data.DataSet
        da.Fill(ds)
        GridView2.DataSource = ds.Tables(0)
        GridView2.DataBind()
    End Sub
End Class
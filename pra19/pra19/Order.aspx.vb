Imports System.Data.SqlClient
Public Class Order
    Inherits System.Web.UI.Page

    Public Sub cleardata()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oid, ono As Integer
        Dim oname As String
        oid = TextBox1.Text
        oname = TextBox2.Text
        ono = TextBox3.Text
        Dim cnn As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True")
        Dim str As String
        str = "Insert into Table1 values(" & oid & ",'" & oname & "'," & ono & ")"
        Dim cmd As New SqlCommand(str, cnn)
        cnn.Open()
        If cmd.ExecuteNonQuery Then
            MsgBox("Order insert successfully")
        End If
        cnn.Close()


        Session("Ordername") = TextBox2.Text
        Session("Nooforder") = TextBox3.Text
        Response.Redirect("Orderdetails.aspx")

        GridView1.DataBind()
        cleardata()

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim oid As Integer, oname As String
        oid = TextBox1.Text
        oname = TextBox2.Text
        Dim str As String
        Dim cnn As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True")
        str = "update Table1 set Ordername = '" & oname & "'where Orderid=" & oid
        Dim cmd As New SqlCommand(str, cnn)
        cnn.Open()
        If cmd.ExecuteNonQuery Then
            MsgBox("Order updated")
        End If
        cnn.Close()

        GridView1.DataBind()
        cleardata()
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim oid As Integer
        oid = TextBox1.Text
        Dim str As String
        Dim cnn As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True")
        str = "delete from Table1 where Orderid=" & oid
        Dim cmd As New SqlCommand(str, cnn)
        cnn.Open()
        cmd.ExecuteNonQuery()
        cnn.Close()
        MsgBox("Order Deleted")

        GridView1.DataBind()
        cleardata()

    End Sub
End Class
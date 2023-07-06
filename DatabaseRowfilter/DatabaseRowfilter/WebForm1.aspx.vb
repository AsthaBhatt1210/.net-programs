Imports System.Data.SqlClient
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String
        str = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True"
        Dim cn As New SqlConnection(str)
        Dim q As String = "select * from Table1"
        Dim da As New SqlDataAdapter(q, cn)
        Dim ds As New DataSet
        da.Fill(ds)
        Dim dv As New DataView(ds.Tables(0))
        dv.Sort = "Sname"
        dv.RowFilter = "Sid>2"
        GridView1.DataSource = dv
        GridView1.DataBind()
    End Sub
End Class
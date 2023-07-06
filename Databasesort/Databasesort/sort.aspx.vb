Imports System.Data.SqlClient
Public Class sort
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim str As String
        str = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True"
        Dim cn As New SqlConnection(str)
        Dim q As String = "select * from Table1"
        Dim da As New SqlDataAdapter(q, cn)
        Dim ds As New DataSet
        da.Fill(ds)
        Dim dv As New DataView(ds.Tables(0))
        dv.Sort = "Sid"
        GridView1.DataSource = dv
        GridView1.DataBind()
    End Sub

End Class
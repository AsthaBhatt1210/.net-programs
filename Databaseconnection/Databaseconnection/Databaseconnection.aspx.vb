Imports System.Data.SqlClient
Public Class Databaseconnection
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim str As String
        str = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True"
        Dim cnn As New SqlConnection(str)
        cnn.open()
        Response.Write("Connection successfull")
        cnn.close()

    End Sub

End Class
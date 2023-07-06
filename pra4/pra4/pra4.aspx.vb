Public Class pra4
    Inherits System.Web.UI.Page

    Protected Sub  RegularExpressionValidator3(ByVal sender As Object, ByVal e As System.EventArgs) Handles RegularExpressionValidator3
    IfLen(args.Value)<7 Or Len(args.Value)>20 Then
        Ad()



    End Sub
End Class
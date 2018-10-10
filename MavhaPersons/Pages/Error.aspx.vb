Public Class _Error
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Sub btnToList_Click(sender As Object, e As EventArgs)
        Response.Redirect("PersonIndex.aspx")
    End Sub

End Class
Imports MavhaPersonsModel
Imports MavhaPersonsSOAP

Public Class WebForm1
    Inherits System.Web.UI.Page
    Private personService As PersonService

    Public Sub New()
        personService = New PersonService()
    End Sub

    Public Sub GetAllPersons()
        Dim persons As List(Of PersonClass) = personService.GetAllPersons()
        For Each person As PersonClass In persons
            Dim row As TableRow = New TableRow()
            row.Cells.Add(CreateCell(person.GetNombreCompleto))
            row.Cells.Add(CreateCell(person.GetFechaDeNacimiento.ToShortDateString))
            row.Cells.Add(CreateCell(person.GetEdad.ToString))
            row.Cells.Add(CreateCell(person.GetSexo))
            Dim EditButton As Button = New Button()
            EditButton.Text = "Editar"
            EditButton.ID = "EditButton_" + person.GetPersonId.ToString
            EditButton.CssClass = "btn btn-primary"
            AddHandler EditButton.Click, AddressOf Me.btnEditPerson_Click
            Dim DeleteButton As Button = New Button()
            DeleteButton.Text = "Eliminar"
            DeleteButton.ID = "DeleteButton_" + person.GetPersonId.ToString
            DeleteButton.CssClass = "btn btn-danger"
            AddHandler DeleteButton.Click, AddressOf Me.btnDeletePerson_Click
            row.Cells.Add(CreateCell(""))
            row.Cells(4).Controls.Add(EditButton)
            row.Cells(4).Controls.Add(DeleteButton)
            TablePersons.Rows.Add(row)
        Next
    End Sub

    Public Sub btnAdd_Click(sender As Object, e As EventArgs)
        Response.Redirect("AddPerson.aspx")
    End Sub

    Public Sub btnEditPerson_Click(sender As Object, e As EventArgs)
        Try
            Dim button As Button = sender
            Dim id As Integer = Convert.ToInt64(button.ID.Replace("EditButton_", ""))
            Session("PersonId") = id.ToString
            Response.Redirect("EditPerson.aspx", False)
        Catch ex As Exception
            Response.Redirect("Error.aspx")
        End Try
    End Sub

    Public Sub btnDeletePerson_Click(sender As Object, e As EventArgs)
        Try
            Dim button As Button = sender
            Dim id As Integer = Convert.ToInt64(button.ID.Replace("DeleteButton_", ""))
            Session("PersonId") = id.ToString
            ModalTitleLbl.Text = "Eliminar Usuario"
            ModalBodyLbl.Text = "¿Eliminar Usuario: " + personService.GetPersonById(id).GetNombreCompleto() + "?"
            Page.ClientScript.RegisterStartupScript(Me.GetType(), "none", "<script type='text/javascript'>openDeleteModal();</script>", False)
        Catch ex As Exception
            Response.Redirect("Error.aspx")
        End Try
    End Sub

    Public Sub btnDelete_Click(sender As Object, e As EventArgs)
        ErasePerson()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GetAllPersons()
    End Sub

    Private Function CreateCell(value As String) As TableCell
        Dim cell As TableCell = New TableCell() With {
            .Text = value,
            .CssClass = "text-center border"
        }
        Return cell
    End Function

    Private Sub ErasePerson()
        Try
            Dim id As Integer = CType(Session.Item("PersonId"), Integer)
            If personService.DeletePerson(id) Then
                Response.Redirect(Request.RawUrl, False)
            Else
                Response.Redirect("Error.aspx")
            End If
        Catch ex As Exception
            Response.Redirect("Error.aspx")
        End Try
    End Sub
End Class
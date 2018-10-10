Imports MavhaPersonsSOAP
Imports MavhaPersonsModel
Imports System.Windows.Forms

Public Class AddPerson
    Inherits System.Web.UI.Page
    Private personService As PersonService

    Public Sub New()
        personService = New PersonService()
    End Sub

    Public Sub btnAddPerson_Click(sender As Object, e As EventArgs)
        NewPerson()
    End Sub

    Public Sub btnToList_Click(sender As Object, e As EventArgs)
        Response.Redirect("PersonIndex.aspx")
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Page_LoadComplete(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadDropDownList(1, 31, DayDropDownList)
        LoadDropDownList(1, 12, MonthDropDownList)
        LoadDropDownList(1900, Date.Now.Year, YearDropDownList)
        EdadTxt.Text = ""
    End Sub

    Private Sub LoadDropDownList(min As Integer, max As Integer, dropDown As DropDownList)
        For index = min To max
            dropDown.Items.Add(New ListItem(index.ToString(), index.ToString()))
        Next
    End Sub

    Private Function ContainsNumber(value As String) As Boolean
        Const numbers = "0123456789"
        If value.IndexOfAny(numbers.ToArray) >= 0 Then
            Return True
        End If
        Return False
    End Function

    Private Sub NewPerson()
        Try
            Dim nombreCompleto As String = NombreTxt.Text.Trim
            If ContainsNumber(nombreCompleto) Or nombreCompleto = "" Then
                ' volver a la pagina con mensaje de error
                NombreTxt.CssClass = "form-control col-md-8 col-lg-8 col-sm-10 col-xs-10 lettersOnly is-invalid"
                ErrorLabel.Text = "Error al Adicionar Nueva Persona, por favor revisa la data e intenta nuevamente."
                Return
            End If

            Dim fechaNacimiento As Date = New Date(Convert.ToInt16(YearDropDownList.Text), Convert.ToInt16(MonthDropDownList.Text), Convert.ToInt16(DayDropDownList.Text))
            Dim edad As Integer = Date.Now.Year - Convert.ToInt16(YearDropDownList.Text)
            Dim sexo As String = SexDropDownList.SelectedValue
            If (personService.CreatePerson(New PersonClass(0, nombreCompleto, fechaNacimiento, edad, sexo))) Then
                ' volver a la pagina con mensaje de error
                Response.Redirect("PersonIndex.aspx")
            Else
                ' volver a la pagina con mensaje de error
                ErrorLabel.Text = "Error al Adicionar Nueva Persona, por favor revisa la data e intenta nuevamente."
                Return
            End If
        Catch ex As Exception
            ' volver a la pagina con mensaje de error
            ErrorLabel.Text = "Error al Adicionar Nueva Persona, por favor revisa la data e intenta nuevamente."
            Return
        End Try
    End Sub
End Class
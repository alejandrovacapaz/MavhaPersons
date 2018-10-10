Imports MavhaPersonsSOAP
Imports MavhaPersonsModel

Public Class EditPerson
    Inherits System.Web.UI.Page
    Private personService As PersonService
    Public Sub New()
        personService = New PersonService()
    End Sub

    Public Sub btnEditPerson_Click(sender As Object, e As EventArgs)
        UpdatePerson()
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
        'cargar elementos
        If Not IsPostBack Then
            Dim id As Integer = CType(Session.Item("PersonId"), Integer)
            Dim person = personService.GetPersonById(id)
            NombreTxt.Text = person.GetNombreCompleto
            Dim fechaNacimiento = person.GetFechaDeNacimiento
            DayDropDownList.Text = fechaNacimiento.Day.ToString
            MonthDropDownList.Text = fechaNacimiento.Month.ToString
            YearDropDownList.Text = fechaNacimiento.Year.ToString
            EdadTxt.Text = person.GetEdad
            If person.GetSexo = "M" Then
                SexDropDownList.DataValueField = "Masculino"
            Else
                SexDropDownList.DataValueField = "Femenino"
            End If
        End If
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

    Private Sub UpdatePerson()
        Try
            Dim nombreCompleto As String = NombreTxt.Text.Trim
            If ContainsNumber(nombreCompleto) Or nombreCompleto = "" Then
                ' volver a la pagina con mensaje de error
                NombreTxt.CssClass = "form-control col-md-8 col-lg-8 col-sm-10 col-xs-10 lettersOnly is-invalid"
                ErrorLabel.Text = "Error al Editar Persona, por favor revisa la data e intenta nuevamente."
                Return
            End If

            Dim fechaNacimiento As Date = New Date(Convert.ToInt16(YearDropDownList.Text), Convert.ToInt16(MonthDropDownList.Text), Convert.ToInt16(DayDropDownList.Text))
            Dim edad As Integer = Date.Now.Year - Convert.ToInt16(YearDropDownList.Text)
            Dim sexo As String = SexDropDownList.SelectedValue
            Dim id As Integer = CType(Session.Item("PersonId"), Integer)
            If (personService.UpdatePerson(New PersonClass(id, nombreCompleto, fechaNacimiento, edad, sexo))) Then
                ' volver a la pagina con mensaje de error
                Response.Redirect("PersonIndex.aspx")
            Else
                ' volver a la pagina con mensaje de error
                ErrorLabel.Text = "Error al Editar Persona, por favor revisa la data e intenta nuevamente."
                Return
            End If
        Catch ex As Exception
            ' volver a la pagina con mensaje de error
            ErrorLabel.Text = "Error al Editar Persona, por favor revisa la data e intenta nuevamente."
            Return
        End Try
    End Sub
End Class
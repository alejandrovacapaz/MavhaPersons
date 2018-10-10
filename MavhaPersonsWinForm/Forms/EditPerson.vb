Imports MavhaPersonsModel
Imports MavhaPersonsSOAP

Public Class EditPerson
    Private personService As PersonService

    Public Sub New()
        InitializeComponent()
        FormBorderStyle = FormBorderStyle.FixedSingle
        MinimizeBox = False
        MaximizeBox = False
        LoadCombo(1, 31, DayBirthDate)
        LoadCombo(1, 12, MonthBirthDate)
        LoadCombo(1900, Date.Now.Year, YearBirthDate)
        Cursor = Cursors.Default
        UseWaitCursor = False
        personService = New PersonService()
    End Sub

    Private Sub LoadCombo(initialValue As Integer, endValue As Integer, combo As ComboBox)
        For index = initialValue To endValue
            combo.Items.Add(index.ToString)
        Next
    End Sub

    Private Sub YearBirthDate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles YearBirthDate.SelectedIndexChanged
        Age.Text = (Date.Now.Year - Convert.ToInt32(YearBirthDate.Text)).ToString
    End Sub

    Private Function ContainsNumber(value As String) As Boolean
        Const numbers = "0123456789"
        If value.IndexOfAny(numbers.ToArray) >= 0 Then
            Return True
        End If
        Return False
    End Function

    Private Sub EditPerson_Click(sender As Object, e As EventArgs) Handles AddPerson.Click
        Try
            Dim nombreCompleto As String = FullName.Text.Trim
            If ContainsNumber(nombreCompleto) Or nombreCompleto = "" Then
                ' volver a la pagina con mensaje de error  
                FullName.BackColor = Color.LightCoral
                MessageBox.Show("Error al Editar Persona, por favor revisa la data e intenta nuevamente.", "Mavha", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim fechaNacimiento As Date = New Date(Convert.ToInt32(YearBirthDate.Text), Convert.ToInt32(MonthBirthDate.Text), Convert.ToInt32(DayBirthDate.Text))
            Dim edad As Integer = Date.Now.Year - Convert.ToInt16(YearBirthDate.Text)
            Dim sexo As String = Sex.Text(0)
            Dim id As Integer = CType(PersonId.Text, Integer)
            If (personService.UpdatePerson(New PersonClass(id, nombreCompleto, fechaNacimiento, edad, sexo))) Then
                Close()
            Else
                ' volver a la pagina con mensaje de error
                MessageBox.Show("Error al Editar Persona, por favor revisa la data e intenta nuevamente.", "Mavha", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Catch ex As Exception
            MessageBox.Show("Error al Editar Persona, por favor revisa la data e intenta nuevamente.", "Mavha", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EditPerson_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim Parent As PersonsList = Owner
        Parent.Reload()
    End Sub

    Private Sub FullName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FullName.KeyPress
        If (Convert.ToInt32(e.KeyChar) < 65 Or Convert.ToInt32(e.KeyChar) > 122) And Convert.ToInt32(e.KeyChar) <> 8 And
            Convert.ToInt32(e.KeyChar) <> 32 And e.KeyChar.ToString.ToLower <> "ñ" Then
            e.Handled = True
        End If
    End Sub
End Class
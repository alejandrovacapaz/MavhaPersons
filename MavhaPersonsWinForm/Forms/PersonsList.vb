Imports MavhaPersonsModel
Imports MavhaPersonsSOAP

Public Class PersonsList
    Private personService As PersonService
    Private NumberOfPages As Integer
    Private Page As Integer
    Private PersonsList As List(Of PersonClass)

    Public Sub New()
        InitializeComponent()
        FormBorderStyle = FormBorderStyle.FixedDialog
        WindowState = FormWindowState.Maximized
        MinimizeBox = False
        MaximizeBox = False
        UseWaitCursor = False
        NumberOfPages = 0
        Page = 0
        personService = New PersonService()
    End Sub

    Public Sub Reload()
        PersonsGridView.Rows.Clear()
        PersonsList = personService.GetAllPersons()
        NumberOfPages = PersonsList.Count / 20
        Dim persons = PersonsList.Skip(0).Take(20).ToList
        For Each person As PersonClass In persons
            PersonsGridView.Rows.Add(person.GetPersonId, person.GetNombreCompleto, person.GetFechaDeNacimiento.ToShortDateString, person.GetEdad.ToString, person.GetSexo)
        Next
    End Sub

    Private Sub PersonsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim colorConverter = New ColorConverter()
        'alinear texto de las cabeceras al medio
        For Each item As DataGridViewColumn In PersonsGridView.Columns
            item.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

        ' agregar columnas para editar y eliminar
        Dim EditButton As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        EditButton.Name = "EditButton"
        EditButton.HeaderText = ""
        EditButton.Text = "Editar"
        EditButton.FlatStyle = FlatStyle.Flat
        EditButton.DefaultCellStyle.BackColor = colorConverter.ConvertFromString("#337ab7")
        EditButton.UseColumnTextForButtonValue = True
        PersonsGridView.Columns.Add(EditButton)

        Dim DeleteButton As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        DeleteButton.Name = "DeleteButton"
        DeleteButton.HeaderText = ""
        DeleteButton.Text = "Eliminar"
        DeleteButton.FlatStyle = FlatStyle.Flat
        DeleteButton.DefaultCellStyle.BackColor = colorConverter.ConvertFromString("#d9534f")
        DeleteButton.UseColumnTextForButtonValue = True
        PersonsGridView.Columns.Add(DeleteButton)

        'centrar el grid de personas
        PersonsGridView.SuspendLayout()
        'PersonsGridView.Height = ClientSize.Height - 150
        PersonsGridView.Height = PersonsGridView.RowTemplate.Height * 21
        PersonsGridView.Width = PersonsGridView.Width - 15
        PersonsGridView.Top = ((ClientSize.Height - PersonsGridView.Height) / 2) - 20
        PersonsGridView.Left = (ClientSize.Width - PersonsGridView.Width) / 2
        PersonsGridView.ResumeLayout()

        'botones de la paginacion
        Dim top = PersonsGridView.Top + PersonsGridView.Height + 5
        Dim left = PersonsGridView.Left + PersonsGridView.Width - Last.Width
        Dim width = Last.Width

        Last.Top = top
        Last.Left = left

        left = left - width
        NextB.Top = top
        NextB.Left = left

        left = left - width
        Previous.Top = top
        Previous.Left = left

        left = left - width
        First.Top = top
        First.Left = left

        'boton adicionar persona
        AddPerson.Left = (ClientSize.Width - AddPerson.Width) / 2

        'recargar
        Reload()
    End Sub

    Private Sub AddPerson_Click(sender As Object, e As EventArgs) Handles AddPerson.Click
        Dim addPerson = New AddNewPerson With {
            .Owner = Me
        }
        addPerson.ShowDialog()
    End Sub

    Private Sub PersonsGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PersonsGridView.CellContentClick
        'Editar
        If e.ColumnIndex = 5 And e.RowIndex >= 0 Then
            Dim EditPerson = New EditPerson With {
           .Owner = Me
       }
            'cargar datos de la persona a editar
            Dim person = personService.GetPersonById(PersonsGridView.Rows(e.RowIndex).Cells(0).Value)
            EditPerson.FullName.Text = person.GetNombreCompleto
            Dim fechaNac = person.GetFechaDeNacimiento
            EditPerson.DayBirthDate.Text = fechaNac.Day.ToString
            EditPerson.MonthBirthDate.Text = fechaNac.Month.ToString
            EditPerson.YearBirthDate.Text = fechaNac.Year.ToString
            EditPerson.Age.Text = (Date.Now.Year - Convert.ToInt32(EditPerson.YearBirthDate.Text)).ToString
            EditPerson.Sex.Text = person.GetSexo(0)
            EditPerson.PersonId.Text = person.GetPersonId
            EditPerson.ShowDialog()
        End If
        'Eliminar
        If e.ColumnIndex = 6 And e.RowIndex >= 0 Then
            Dim person = personService.GetPersonById(PersonsGridView.Rows(e.RowIndex).Cells(0).Value)
            If MessageBox.Show("¿Eliminar Usuario: " + person.GetNombreCompleto() + "?",
               "Mavha Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    personService.DeletePerson(person.GetPersonId)
                    Reload()
                Catch ex As Exception
                    MessageBox.Show("Error al Eliminar persona", "Mavha", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End If
        End If
    End Sub

    Private Sub PersonsList_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("¿ Desear Salir de la aplicación?",
               "Mavha Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dispose()
            Application.Exit()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Paginate()
        PersonsGridView.Rows.Clear()
        Dim persons = PersonsList.Skip(Page * 20).Take(20).ToList
        For Each person As PersonClass In persons
            PersonsGridView.Rows.Add(person.GetPersonId, person.GetNombreCompleto, person.GetFechaDeNacimiento.ToShortDateString, person.GetEdad.ToString, person.GetSexo)
        Next
    End Sub

    Private Sub FirstPage()
        Page = 0
        Paginate()
    End Sub

    Private Sub LastPage()
        Page = NumberOfPages
        Paginate()
    End Sub

    Private Sub First_Click(sender As Object, e As EventArgs) Handles First.Click
        FirstPage()
    End Sub

    Private Sub Previous_Click(sender As Object, e As EventArgs) Handles Previous.Click
        If Page = 0 Then
            FirstPage()
        Else
            Page = Page - 1
            Paginate()
        End If
    End Sub

    Private Sub NextB_Click(sender As Object, e As EventArgs) Handles NextB.Click
        If Page = NumberOfPages Then
            LastPage()
        Else
            Page = Page + 1
            Paginate()
        End If
    End Sub

    Private Sub Last_Click(sender As Object, e As EventArgs) Handles Last.Click
        LastPage()
    End Sub
End Class

Imports MavhaPersonsModel

Public Class PersonBLL
    Private _db As MavhaPersonsEntities

    Public Sub New()
        _db = New MavhaPersonsEntities()
    End Sub

    Public Function GetAllPersons() As List(Of PersonClass)
        Try
            Using database As New MavhaPersonsEntities
                Dim persons As List(Of Person) = database.Persons.OrderBy(Function(x) x.Id).ToList
                Dim result As List(Of PersonClass) = New List(Of PersonClass)
                For Each person As Person In persons
                    result.Add(New PersonClass(person.Id, person.Nombre_Completo, person.Fecha_de_Nacimiento, person.Edad, person.Sexo))
                Next
                Return result
            End Using
        Catch ex As Exception
            Return New List(Of PersonClass)
        End Try

    End Function

    Private Function GetPerson(personId As Integer) As Person
        Return _db.Persons.First(Function(x) x.Id = personId)
    End Function

    Public Function GetPersonById(personId As Integer) As PersonClass
        Dim person = GetPerson(personId)
        Return New PersonClass(person.Id, person.Nombre_Completo, person.Fecha_de_Nacimiento, person.Edad, person.Sexo)
    End Function

    Public Function CreatePerson(person As PersonClass) As Boolean
        Try
            _db.AddToPersons(New Person With {.Nombre_Completo = person.GetNombreCompleto,
                         .Fecha_de_Nacimiento = person.GetFechaDeNacimiento,
                         .Edad = person.GetEdad,
                         .Sexo = person.GetSexo
                         })
            _db.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Sub UpdatePerson(person As PersonClass)
        Dim personToUpdate As Person = GetPerson(person.GetPersonId)
        personToUpdate.Nombre_Completo = person.GetNombreCompleto
        personToUpdate.Fecha_de_Nacimiento = person.GetFechaDeNacimiento
        personToUpdate.Edad = person.GetEdad
        personToUpdate.Sexo = person.GetSexo
        _db.SaveChanges()
    End Sub

    Public Sub DeletePerson(personId As Integer)
        Dim personToDelete As Person = GetPerson(personId)
        _db.DeleteObject(personToDelete)
        _db.SaveChanges()
    End Sub
End Class

Imports MavhaPersonsBussinesLogic
Imports MavhaPersonsModel

Public Class PersonService
    Private personBll As PersonBLL

    Public Sub New()
        personBll = New PersonBLL()
    End Sub

    Public Function GetAllPersons() As List(Of PersonClass)
        Try
            Return personBll.GetAllPersons
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function CreatePerson(person As PersonClass) As Boolean
        Try
            Return personBll.CreatePerson(person)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function UpdatePerson(person As PersonClass) As Boolean
        Try
            personBll.UpdatePerson(person)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function DeletePerson(personId As Integer) As Boolean
        Try
            personBll.DeletePerson(personId)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function GetPersonById(personId As Integer) As PersonClass
        Return personBll.GetPersonById(personId)
    End Function

End Class

Imports System.Web.Services
Imports MavhaPersonsModel
Imports MavhaPersonsSOAP

Public Class PersonWebMethods
    Private personService As PersonService

    Public Sub New()
        personService = New PersonService()
    End Sub

    '<WebMethod()>
    'Public Function GetAllPersons() As IEnumerable(Of PersonClass)
    '    Return personService.GetAllPersons()
    'End Function

End Class

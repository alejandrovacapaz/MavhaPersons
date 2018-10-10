Public Class PersonClass
    Private Id As Integer
    Private NombreCompleto As String
    Private FechaDeNacimiento As Date
    Private Edad As Integer
    Private Sexo As String

    Public Sub New(Id As Integer, Nm As String, Fn As Date, Edad As Integer, Sexo As String)
        SetPersonId(Id)
        SetNombreCompleto(Nm)
        SetFechaDeNacimiento(Fn)
        SetEdad(Edad)
        SetSexo(Sexo)
    End Sub

    Public Function GetSexo() As String
        Return Sexo
    End Function

    Public Sub SetSexo(value As String)
        Sexo = value
    End Sub

    Public Function GetEdad() As Integer
        Return Edad
    End Function

    Public Sub SetEdad(value As Integer)
        Edad = value
    End Sub

    Public Function GetFechaDeNacimiento() As Date
        Return FechaDeNacimiento
    End Function

    Public Sub SetFechaDeNacimiento(value As Date)
        FechaDeNacimiento = value
    End Sub

    Public Function GetNombreCompleto() As String
        Return NombreCompleto
    End Function

    Public Sub SetNombreCompleto(value As String)
        NombreCompleto = value
    End Sub

    Public Function GetPersonId() As Integer
        Return Id
    End Function

    Public Sub SetPersonId(value As Integer)
        Id = value
    End Sub
End Class

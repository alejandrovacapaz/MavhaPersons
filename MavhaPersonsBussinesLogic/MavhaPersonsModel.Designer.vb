﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

<Assembly: Global.System.Data.Objects.DataClasses.EdmSchemaAttribute("ccebe69e-6210-480f-a783-83d118307478")> 

'Original file name:
'Generation date: 10/4/2018 10:51:47 AM
'''<summary>
'''There are no comments for MavhaPersonsModel.Person in the schema.
'''</summary>
'''<KeyProperties>
'''Id
'''</KeyProperties>
<Global.System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName:="MavhaPersonsModel", Name:="Person"),  _
 Global.System.Runtime.Serialization.DataContractAttribute(IsReference:=true),  _
 Global.System.Serializable()>  _
Partial Public Class Person
    Inherits Global.System.Data.Objects.DataClasses.EntityObject
    '''<summary>
    '''Create a new Person object.
    '''</summary>
    '''<param name="id">Initial value of Id.</param>
    '''<param name="nombre_Completo">Initial value of Nombre_Completo.</param>
    '''<param name="fecha_de_Nacimiento">Initial value of Fecha_de_Nacimiento.</param>
    '''<param name="sexo">Initial value of Sexo.</param>
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Public Shared Function CreatePerson(ByVal id As Integer, ByVal nombre_Completo As String, ByVal fecha_de_Nacimiento As Date, ByVal sexo As String) As Person
        Dim person As Person = New Person()
        person.Id = id
        person.Nombre_Completo = nombre_Completo
        person.Fecha_de_Nacimiento = fecha_de_Nacimiento
        person.Sexo = sexo
        Return person
    End Function
    '''<summary>
    '''There are no comments for property Id in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false),  _
     Global.System.Runtime.Serialization.DataMemberAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Public Property Id() As Integer
        Get
            Return Me._Id
        End Get
        Set
            Me.OnIdChanging(value)
            Me.ReportPropertyChanging("Id")
            Me._Id = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
            Me.ReportPropertyChanged("Id")
            Me.OnIdChanged
        End Set
    End Property
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Private _Id As Integer
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Partial Private Sub OnIdChanging(ByVal value As Integer)
        End Sub
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Partial Private Sub OnIdChanged()
        End Sub
    '''<summary>
    '''There are no comments for property Nombre_Completo in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=false),  _
     Global.System.Runtime.Serialization.DataMemberAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Public Property Nombre_Completo() As String
        Get
            Return Me._Nombre_Completo
        End Get
        Set
            Me.OnNombre_CompletoChanging(value)
            Me.ReportPropertyChanging("Nombre_Completo")
            Me._Nombre_Completo = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false)
            Me.ReportPropertyChanged("Nombre_Completo")
            Me.OnNombre_CompletoChanged
        End Set
    End Property
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Private _Nombre_Completo As String
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Partial Private Sub OnNombre_CompletoChanging(ByVal value As String)
        End Sub
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Partial Private Sub OnNombre_CompletoChanged()
        End Sub
    '''<summary>
    '''There are no comments for property Fecha_de_Nacimiento in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=false),  _
     Global.System.Runtime.Serialization.DataMemberAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Public Property Fecha_de_Nacimiento() As Date
        Get
            Return Me._Fecha_de_Nacimiento
        End Get
        Set
            Me.OnFecha_de_NacimientoChanging(value)
            Me.ReportPropertyChanging("Fecha_de_Nacimiento")
            Me._Fecha_de_Nacimiento = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
            Me.ReportPropertyChanged("Fecha_de_Nacimiento")
            Me.OnFecha_de_NacimientoChanged
        End Set
    End Property
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Private _Fecha_de_Nacimiento As Date
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Partial Private Sub OnFecha_de_NacimientoChanging(ByVal value As Date)
        End Sub
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Partial Private Sub OnFecha_de_NacimientoChanged()
        End Sub
    '''<summary>
    '''There are no comments for property Edad in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(),  _
     Global.System.Runtime.Serialization.DataMemberAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Public Property Edad() As Global.System.Nullable(Of Integer)
        Get
            Return Me._Edad
        End Get
        Set
            Me.OnEdadChanging(value)
            Me.ReportPropertyChanging("Edad")
            Me._Edad = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
            Me.ReportPropertyChanged("Edad")
            Me.OnEdadChanged
        End Set
    End Property
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Private _Edad As Global.System.Nullable(Of Integer)
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Partial Private Sub OnEdadChanging(ByVal value As Global.System.Nullable(Of Integer))
        End Sub
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Partial Private Sub OnEdadChanged()
        End Sub
    '''<summary>
    '''There are no comments for property Sexo in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=false),  _
     Global.System.Runtime.Serialization.DataMemberAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Public Property Sexo() As String
        Get
            Return Me._Sexo
        End Get
        Set
            Me.OnSexoChanging(value)
            Me.ReportPropertyChanging("Sexo")
            Me._Sexo = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false)
            Me.ReportPropertyChanged("Sexo")
            Me.OnSexoChanged
        End Set
    End Property
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Private _Sexo As String
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Partial Private Sub OnSexoChanging(ByVal value As String)
        End Sub
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Partial Private Sub OnSexoChanged()
        End Sub
End Class
'''<summary>
'''There are no comments for MavhaPersonsEntities in the schema.
'''</summary>
Partial Public Class MavhaPersonsEntities
    Inherits Global.System.Data.Objects.ObjectContext
    '''<summary>
    '''Initializes a new MavhaPersonsEntities object using the connection string found in the 'MavhaPersonsEntities' section of the application configuration file.
    '''</summary>
    Public Sub New()
        MyBase.New("name=MavhaPersonsEntities", "MavhaPersonsEntities")
        Me.OnContextCreated
    End Sub
    '''<summary>
    '''Initialize a new MavhaPersonsEntities object.
    '''</summary>
    Public Sub New(ByVal connectionString As String)
        MyBase.New(connectionString, "MavhaPersonsEntities")
        Me.OnContextCreated
    End Sub
    '''<summary>
    '''Initialize a new MavhaPersonsEntities object.
    '''</summary>
    Public Sub New(ByVal connection As Global.System.Data.EntityClient.EntityConnection)
        MyBase.New(connection, "MavhaPersonsEntities")
        Me.OnContextCreated
    End Sub
    Partial Private Sub OnContextCreated()
        End Sub
    '''<summary>
    '''There are no comments for Persons in the schema.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Public ReadOnly Property Persons() As Global.System.Data.Objects.ObjectQuery(Of Person)
        Get
            If (Me._Persons Is Nothing) Then
                Me._Persons = MyBase.CreateQuery(Of Person)("[Persons]")
            End If
            Return Me._Persons
        End Get
    End Property
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Private _Persons As Global.System.Data.Objects.ObjectQuery(Of Person)
    '''<summary>
    '''There are no comments for Persons in the schema.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Public Sub AddToPersons(ByVal person As Person)
        MyBase.AddObject("Persons", person)
    End Sub
End Class

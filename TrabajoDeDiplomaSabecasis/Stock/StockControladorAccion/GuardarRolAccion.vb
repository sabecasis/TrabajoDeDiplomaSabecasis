Imports StockModelo

Public Class GuardarRolAccion
	Implements Accion

    Public Sub New(id As Integer, nombre As String, descripcion As String, modulo As Modulo, grupos As List(Of ElementoDeSeguridad), permisos As List(Of Permiso))
        Me.descripcion = descripcion
        Me.permisos = permisos
        Me.nombre = nombre
        Me.id = id
        Me.grupos = grupos
        Me.modulo = modulo
    End Sub


    Private _permsos As List(Of Permiso)
    Public Property permisos() As List(Of Permiso)
        Get
            Return _permsos
        End Get
        Set(ByVal value As List(Of Permiso))
            _permsos = value
        End Set
    End Property


    Private _grupos As List(Of ElementoDeSeguridad)
    Public Property grupos() As List(Of ElementoDeSeguridad)
        Get
            Return _grupos
        End Get
        Set(ByVal value As List(Of ElementoDeSeguridad))
            _grupos = value
        End Set
    End Property


    Private _modulo As Modulo
    Public Property modulo() As Modulo
        Get
            Return _modulo
        End Get
        Set(ByVal value As Modulo)
            _modulo = value
        End Set
    End Property


    Private _descripcion As String
    Public Property descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property


    Private _nombre As String
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property


    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property


End Class

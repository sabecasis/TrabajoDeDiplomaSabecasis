Imports StockModelo

Public Class GuardarUsuarioAccion
	Implements Accion

    Public Sub New(bloqueado As Boolean, idUsuario As Integer, passwordUno As String, passwordDos As String, usuario As String, pregunta As String, respuesta As String, empleados As List(Of Empleado))
        Me.bloqueado = bloqueado
        Me.idUsuario = idUsuario
        Me.passwordUno = passwordUno
        Me.passwordDos = passwordDos
        Me.usuario = usuario
        Me.pregunta = pregunta
        Me.respuesta = respuesta
        Me.empleados = empleados
    End Sub

    Private _empleados As List(Of Empleado)
    Public Property empleados() As List(Of Empleado)
        Get
            Return _empleados
        End Get
        Set(ByVal value As List(Of Empleado))
            _empleados = value
        End Set
    End Property


    Private _respuesta As String
    Public Property respuesta() As String
        Get
            Return _respuesta
        End Get
        Set(ByVal value As String)
            _respuesta = value
        End Set
    End Property


    Private _pregunta As String
    Public Property pregunta() As String
        Get
            Return _pregunta
        End Get
        Set(ByVal value As String)
            _pregunta = value
        End Set
    End Property


    Private _usuario As String
    Public Property usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property


    Private _passwordDos As String
    Public Property passwordDos() As String
        Get
            Return _passwordDos
        End Get
        Set(ByVal value As String)
            _passwordDos = value
        End Set
    End Property


    Private _bloqueado As Boolean
    Public Property bloqueado() As Boolean
        Get
            Return _bloqueado
        End Get
        Set(ByVal value As Boolean)
            _bloqueado = value
        End Set
    End Property

    Private _idUsuario As Integer
    Public Property idUsuario() As Integer
        Get
            Return _idUsuario
        End Get
        Set(ByVal value As Integer)
            _idUsuario = value
        End Set
    End Property

    Private _passwordUno As String
    Public Property passwordUno() As String
        Get
            Return _passwordUno
        End Get
        Set(ByVal value As String)
            _passwordUno = value
        End Set
    End Property





End Class

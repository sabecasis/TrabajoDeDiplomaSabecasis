Imports StockModelo

Public Class GuardarGrupoAccion
	Implements Accion

    Public Sub New(idGrupo As Integer, nombre As String, elementos As List(Of ElementoDeSeguridad))
        Me.elementos = elementos
        Me.idGrupo = idGrupo
        Me.nombre = nombre
    End Sub

    Private _elementos As List(Of ElementoDeSeguridad)
    Public Property elementos() As List(Of ElementoDeSeguridad)
        Get
            Return _elementos
        End Get
        Set(ByVal value As List(Of ElementoDeSeguridad))
            _elementos = value
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


    Private _idGrupo As Integer
    Public Property idGrupo() As Integer
        Get
            Return _idGrupo
        End Get
        Set(ByVal value As Integer)
            _idGrupo = value
        End Set
    End Property


End Class

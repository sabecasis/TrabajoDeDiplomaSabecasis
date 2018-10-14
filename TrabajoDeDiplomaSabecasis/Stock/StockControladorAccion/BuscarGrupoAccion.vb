Imports StockModelo

Public Class BuscarGrupoAccion
    Implements Accion


    Public Sub New(nombre As String)
        Me.grupo = nombre
    End Sub

    Private _nombreGrupo As String
    Public Property grupo() As String
        Get
            Return _nombreGrupo
        End Get
        Set(ByVal value As String)
            _nombreGrupo = value
        End Set
    End Property

End Class

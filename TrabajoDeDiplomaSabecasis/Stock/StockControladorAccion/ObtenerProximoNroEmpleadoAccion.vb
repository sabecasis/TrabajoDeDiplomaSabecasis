Imports StockModelo

Public Class ObtenerProximoNroEmpleadoAccion
	Implements Accion

    Public Sub New(puestoId As Integer)
        Me.idPuesto = puestoId
    End Sub

    Private _idPuesto As String
    Public Property idPuesto() As String
        Get
            Return _idPuesto
        End Get
        Set(ByVal value As String)
            _idPuesto = value
        End Set
    End Property


End Class

Imports StockModelo

Public Class GuardarPuestosAccion
	Implements Accion

    Public Sub New(puestosLista As List(Of Puesto))
        Me.puestos = puestosLista
    End Sub

    Private _puestos As List(Of Puesto)
    Public Property puestos() As List(Of Puesto)
        Get
            Return _puestos
        End Get
        Set(ByVal value As List(Of Puesto))
            _puestos = value
        End Set
    End Property


End Class

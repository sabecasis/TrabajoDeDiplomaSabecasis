Imports StockModelo

Public Class GuardarMonedaAccion
	Implements Accion

    Public Sub New(pid As Integer, pmon As String)
        Me.id = pid
        Me.moneda = pmon
    End Sub


    Property id As Integer
    Property moneda As String
End Class

Imports StockModelo

Public Class BuscarDepositoAccion
    Implements Accion

    Public Sub New(pid As Integer, pnombre As String)
        Me.id = pid
        Me.nombre = pnombre
    End Sub

    Property id As Integer
    Property nombre As String
End Class

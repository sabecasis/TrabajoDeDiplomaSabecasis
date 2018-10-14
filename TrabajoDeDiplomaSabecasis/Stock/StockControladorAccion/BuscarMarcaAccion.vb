Imports StockModelo

Public Class BuscarMarcaAccion
    Implements Accion

    Public Sub New(pid As Integer, pmarca As String)
        Me.id = pid
        Me.marca = pmarca
    End Sub

    Property id As Integer
    Property marca As String
End Class

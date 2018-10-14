Imports StockModelo

Public Class BuscarDescuentoAccion
    Implements Accion

    Public Sub New(id As Integer, nombre As String)
        Me.id = id
        Me.nombre = nombre
    End Sub

    Property nombre As String
    Property id As Integer
End Class

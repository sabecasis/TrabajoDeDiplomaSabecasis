Imports StockModelo

Public Class BuscarProductoAccion
    Implements Accion

    Public Sub New(id As Integer, nombre As String)
        Me.id = id
        Me.nombre = nombre
    End Sub
    Property id As Integer
    Property nombre As String
End Class

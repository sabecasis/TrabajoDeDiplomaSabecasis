Imports StockModelo

Public Class BuscarProveedorAccion
    Implements Accion

    Public Sub New(id As Integer, nombre As String, cuit As String)
        Me.id = id
        Me.cuit = cuit
        Me.nombre = nombre
    End Sub
    Property nombre As String
    Property id As Integer
    Property cuit As String
End Class

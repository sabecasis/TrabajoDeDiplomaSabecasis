Imports StockModelo

Public Class BuscarFamiliaProductoAccion
    Implements Accion

    Public Sub New(id As Integer, familia As String)
        Me.id = id
        Me.familia = familia
    End Sub

    Property id As Integer
    Property familia As String

End Class

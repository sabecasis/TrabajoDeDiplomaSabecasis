Imports StockModelo

Public Class GuardarFamiliaProductoAccion
	Implements Accion

    Public Sub New(id As Integer, familia As String)
        Me.familia = familia
        Me.id = id
    End Sub

    Property id As Integer
    Property familia As String

End Class

Imports StockModelo

Public Class ObtenerTodosLosErroresConFiltroAccion
    Implements Accion

    Public Sub New()

    End Sub

    Public Sub New(id As Integer, clase As String, query As String, fecha As DateTime, tipoExcepcion As TipoDeExcepcion)
        Me.idError = id
        Me.fecha = fecha
        Me.clase = clase
        Me.query = query
        Me.tipoExcepcion = tipoExcepcion
    End Sub

    Property idError As Integer = 0
    Property clase As String = ""
    Property query As String = ""
    Property fecha As DateTime = Nothing
    Property tipoExcepcion As TipoDeExcepcion = New TipoDeExcepcion

End Class

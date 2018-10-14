Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class ObtenerTodosLosErroresConFiltroCmd
    Inherits Comando(Of List(Of ErrorLog), ObtenerTodosLosErroresConFiltroAccion)

    Public Overrides Function execute(accion As ObtenerTodosLosErroresConFiltroAccion) As List(Of ErrorLog)
        Try
            If accion Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            Dim dao As AbstractDao(Of ErrorLog) = DaoFactory(Of ErrorLog).obtenerInstancia().crear(GetType(ErrorLog))
            Dim criteria As New LogErroresQueryCriteria
            criteria.fecha = accion.fecha
            criteria.clase = accion.clase
            criteria.idError = accion.idError
            criteria.query = accion.query
            criteria.tipoExcepcion = accion.tipoExcepcion.id
            Return dao.obtenerMuchos(criteria)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class

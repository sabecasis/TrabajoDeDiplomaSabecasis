Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class BuscarDescuentoCmd
    Inherits Comando(Of Descuento, BuscarDescuentoAccion)


    Public Overrides Function execute(accion As BuscarDescuentoAccion) As Descuento
        Try
            Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.BUSCAR)
            If accion Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            Dim dao As AbstractDao(Of Descuento) = DaoFactory(Of Descuento).obtenerInstancia().crear(GetType(Descuento))
            Dim criteria As New GenericQueryCriteria
            criteria.integerCriteria = accion.id
            criteria.stringCriteria = accion.nombre
            Return dao.obtenerUno(criteria)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class

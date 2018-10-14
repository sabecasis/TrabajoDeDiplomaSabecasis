Imports StockModelo
Imports StockControladorAccion
Imports StockDatos
Imports ElementosTransversales

Public Class GuardarMovimientoDeStockCmd
    Inherits Comando(Of String, GuardarMovimientoDeStockAccion)


    Public Overrides Function execute(accion As GuardarMovimientoDeStockAccion) As String
        Try
            Dim oAut As Autorizador = Autorizador.obtenerInstancia()
            Dim oSesion As Sesion = Sesion.obtenerInstancia()
            If accion Is Nothing Then
                Throw New Exception(oSesion.correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            Dim dao As AbstractDao(Of MovimientoDeStock) = DaoFactory(Of MovimientoDeStock).obtenerInstancia().crear(GetType(MovimientoDeStock))
            If accion.oMovimiento.id = 0 Then
                oAut.autorizar(ConstantesDePermisos.CREAR)
                dao.guardar(accion.oMovimiento)
                Return oSesion.correlacionElementoIdioma.Item(ConstantesDeMensaje.MOVIMIENTO_GUARDADO) + accion.oMovimiento.id.ToString
            Else
                oAut.autorizar(ConstantesDePermisos.ACTUALIZAR)
                dao.actualizar(accion.oMovimiento)
                Return oSesion.correlacionElementoIdioma.Item(ConstantesDeMensaje.MOVIMIENTO_GUARDADO) + accion.oMovimiento.id.ToString
            End If

        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class

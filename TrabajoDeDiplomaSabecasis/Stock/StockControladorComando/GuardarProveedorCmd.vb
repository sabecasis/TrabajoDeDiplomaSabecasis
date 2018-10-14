Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class GuardarProveedorCmd
    Inherits Comando(Of String, GuardarProveedorAccion)

    Public Overrides Function execute(accion As GuardarProveedorAccion) As String
        Try
            If accion Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            If accion.oProveedor.nombre Is Nothing Or accion.oProveedor.cuit Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ELEMENTOS_NULOS))
            End If
            If "".Equals(accion.oProveedor.nombre) Or "".Equals(accion.oProveedor.nombre) Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ELEMENTOS_NULOS))
            End If

            Dim dao As AbstractDao(Of Proveedor) = DaoFactory(Of Proveedor).obtenerInstancia().crear(GetType(Proveedor))
            If accion.oProveedor.id = 0 Then
                Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.CREAR)
                dao.guardar(accion.oProveedor)
                Return Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.PROVEEDOR_GUARDADO_CON_EXITO)
            Else
                Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.ACTUALIZAR)
                dao.actualizar(accion.oProveedor)
                Return Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.PROVEEDOR_GUARDADO_CON_EXITO)
            End If

        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try

    End Function
End Class

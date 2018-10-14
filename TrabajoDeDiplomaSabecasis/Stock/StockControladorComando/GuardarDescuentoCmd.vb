Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class GuardarDescuentoCmd
    Inherits Comando(Of String, GuardarDescuentoAccion)

    Public Overrides Function execute(accion As GuardarDescuentoAccion) As String
        Try
            If accion Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            Dim dao As AbstractDao(Of Descuento) = DaoFactory(Of Descuento).obtenerInstancia().crear(GetType(Descuento))
            Dim desc As New Descuento
            desc.id = accion.id
            desc.descripcion = accion.descripcion
            desc.monto = accion.monto
            desc.nombre = accion.nombre
            desc.porcentaje = accion.porcentaje

            If accion.id = 0 Then
                Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.CREAR)
                dao.guardar(desc)
            Else
                Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.ACTUALIZAR)
                dao.actualizar(desc)
            End If

            Return Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.DESCUENTO_GUARDADO)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class

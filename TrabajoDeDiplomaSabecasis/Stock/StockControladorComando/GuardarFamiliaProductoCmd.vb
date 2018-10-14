Imports StockModelo
Imports StockControladorAccion
Imports StockDatos
Imports ElementosTransversales

Public Class GuardarFamiliaProductoCmd
    Inherits Comando(Of String, GuardarFamiliaProductoAccion)


    Public Overrides Function execute(accion As GuardarFamiliaProductoAccion) As String
        Try

            Dim dao As AbstractDao(Of FamiliaDeProducto) = DaoFactory(Of FamiliaDeProducto).obtenerInstancia.crear(GetType(FamiliaDeProducto))
            Dim oFam As New FamiliaDeProducto
            oFam.id = accion.id
            oFam.familia = accion.familia
            If accion.id = 0 Then
                Autorizador.obtenerInstancia.autorizar(ConstantesDePermisos.CREAR)
                dao.guardar(oFam)
                Return Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.FAMILIA_PROD_GUARDADA)
            Else
                Autorizador.obtenerInstancia.autorizar(ConstantesDePermisos.ACTUALIZAR)
                dao.actualizar(oFam)
                Return Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.FAMILIA_PROD_GUARDADA)
            End If
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class

Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class BuscarProveedorCmd
    Inherits Comando(Of Proveedor, BuscarProveedorAccion)


    Public Overrides Function execute(accion As BuscarProveedorAccion) As Proveedor
        Try
            Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.BUSCAR)
            Dim dao As AbstractDao(Of Proveedor) = DaoFactory(Of Proveedor).obtenerInstancia.crear(GetType(Proveedor))
            If accion Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            Dim criteria As New GenericQueryCriteria
            Dim proveedor As New Proveedor
            proveedor.id = accion.id
            proveedor.nombre = accion.nombre
            proveedor.cuit = accion.cuit
            criteria.oObject = proveedor
            Dim oProveedor As Proveedor = dao.obtenerUno(criteria)
            Return oProveedor
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class

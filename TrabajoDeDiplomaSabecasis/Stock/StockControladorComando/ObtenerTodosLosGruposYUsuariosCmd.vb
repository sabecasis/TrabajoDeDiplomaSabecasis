Imports StockModelo
Imports StockControladorAccion
Imports StockDatos
Imports ElementosTransversales

Public Class ObtenerTodosLosGruposYUsuariosCmd
    Inherits Comando(Of List(Of ElementoDeSeguridad), ObtenerTodosAccion)

    Public Overrides Function execute(accion As ObtenerTodosAccion) As List(Of ElementoDeSeguridad)
        Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.BUSCAR)
        Dim dao As AbstractDao(Of ElementoDeSeguridad) = DaoFactory(Of ElementoDeSeguridad).obtenerInstancia().crear(GetType(ElementoDeSeguridad))
        Dim elementos As List(Of ElementoDeSeguridad) = dao.obtenerMuchos(Nothing)
        If Not elementos Is Nothing And elementos.Count > 0 Then
            For Each elemento As ElementoDeSeguridad In elementos
                elemento.nombre = Criptografia.ObtenerInstancia().DecypherTripleDES(elemento.nombre, Sesion.obtenerInstancia().DESSEED, True)
            Next
        End If
        Return elementos
    End Function
End Class

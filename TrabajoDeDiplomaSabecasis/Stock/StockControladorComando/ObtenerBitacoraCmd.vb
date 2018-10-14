Imports StockModelo
Imports StockControladorAccion
Imports StockDatos
Imports ElementosTransversales

Public Class ObtenerBitacoraCmd
    Inherits Comando(Of List(Of ElementoDeBitacora), ObtenerBitacoraAccion)


    Public Overrides Function execute(accion As ObtenerBitacoraAccion) As List(Of ElementoDeBitacora)
        Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.BUSCAR)
        Dim dao As AbstractDao(Of ElementoDeBitacora) = DaoFactory(Of ElementoDeBitacora).obtenerInstancia().crear(GetType(ElementoDeBitacora))
        Dim criteria As ElementoDeBitacoraQueryCriteria = New ElementoDeBitacoraQueryCriteria()
        criteria.evento = accion.evento
        criteria.fecha = accion.fecha
        criteria.usuario = Criptografia.ObtenerInstancia().CypherTripleDES(accion.usuario, Sesion.obtenerInstancia().DESSEED, True)
        Dim listaDeElementos As List(Of ElementoDeBitacora) = dao.obtenerMuchos(criteria)
        Return listaDeElementos
    End Function
End Class

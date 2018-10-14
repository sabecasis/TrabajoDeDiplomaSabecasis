Public MustInherit Class AbstractDao(Of T)

    Public MustOverride Function obtenerUno(queryCriteria As QueryCriteria) As T
    Public MustOverride Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of T)
    Public MustOverride Function guardar(oEntity As T) As Boolean
    Public MustOverride Function guardarMuchos(oEntityList As List(Of T)) As Boolean
    Public MustOverride Function eliminar(oEntity As T) As Boolean
    Public MustOverride Function elminarMuchos(oEntityList As List(Of T)) As Boolean
    Public MustOverride Function actualizar(oEntity As T) As Boolean
    Public MustOverride Function actualizarMuchos(oEntityList As List(Of T)) As Boolean
    Public MustOverride Function checkearVerificadorVertical() As Boolean
    Public MustOverride Sub calcularVerificadorVertical()
    Public MustOverride Sub calcularVerificadorHoriontal()

End Class

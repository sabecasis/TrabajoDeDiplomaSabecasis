Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class GenerarEgresoPorReglaDeComposicionCmd
    Inherits Comando(Of String, GenerarEgresoPorReglaDeComposicionAccion)

    Public Overrides Function execute(accion As GenerarEgresoPorReglaDeComposicionAccion) As String
        Try
            Autorizador.obtenerInstancia.autorizar(ConstantesDePermisos.CREAR)
            Dim oSesion As Sesion = Sesion.obtenerInstancia
            If accion Is Nothing Then
                Throw New Exception(oSesion.correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            If "".Equals(accion.reglaDeComposicion) Then
                Return Nothing
            End If
            Dim componentesDeFormula() As String = accion.reglaDeComposicion.Split("+")

            Dim cantIds() As String
            Dim oProducto As Producto
            Dim dao As AbstractDao(Of Producto) = DaoFactory(Of Producto).obtenerInstancia().crear(GetType(Producto))
            Dim criteria As New GenericQueryCriteria
            Dim listaEgresosGenerados As New List(Of EgresoDeStock)

            Dim egrDao As AbstractDao(Of EgresoDeStock) = DaoFactory(Of EgresoDeStock).obtenerInstancia().crear(GetType(EgresoDeStock))
            Dim egreso As EgresoDeStock
            If componentesDeFormula.Count > 0 Then
                For i As Integer = 0 To componentesDeFormula.Count - 1
                    cantIds = componentesDeFormula.ElementAt(i).Split("*")
                    oProducto = Nothing
                    criteria.integerCriteria = CType(cantIds.ElementAt(1), Integer)
                    criteria.stringCriteria = ""
                    oProducto = dao.obtenerUno(criteria)
                    If Not oProducto Is Nothing Then
                        egreso = New EgresoDeStock
                        egreso.id = 0
                        egreso.producto = oProducto
                        egreso.deposito = accion.deposito
                        egreso.empleado = oSesion.usuarioActual.empleados.Item(0)
                        egreso.motivo = "Egreso por regla de composición. Producto ID: " & accion.productoId.ToString
                        egreso.listaInstanciasDeProducto = CalculadorInstanciasAEgresar.calcular(oProducto.instanciasDeProductoActivas, oProducto.metodoDeValoracion, CType(cantIds.ElementAt(0), Integer))
                        If egreso.listaInstanciasDeProducto.Count = 0 Then
                            For Each egr As EgresoDeStock In listaEgresosGenerados
                                egrDao.eliminar(egr)
                            Next
                            Throw New Exception(oSesion.correlacionElementoIdioma.Item(ConstantesDeMensaje.NO_HAY_ARTICULOS_SUFICIENTES) & accion.reglaDeComposicion)
                        End If
                        egrDao.guardar(egreso)
                        listaEgresosGenerados.Add(egreso)
                        GeneradorDeComprobantes.oGlobalWord.Documents.Close()
                        GeneradorDeComprobantes.oGlobalWord.Visible = False
                    End If
                Next
            End If

        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
        Return Nothing
    End Function
End Class

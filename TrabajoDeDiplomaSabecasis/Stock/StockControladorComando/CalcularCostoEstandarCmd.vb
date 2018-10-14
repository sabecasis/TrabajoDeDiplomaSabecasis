Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class CalcularCostoEstandarCmd
    Inherits Comando(Of Double, CalcularCostoEstandarAccion)


    Public Overrides Function execute(accion As CalcularCostoEstandarAccion) As Double
        Try
            If accion Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            Dim costo As Double = 0
            Dim componentesDeFormula() As String = accion.formulaDeComposicion.Split("+")

            Dim cantIds() As String
            Dim oProducto As Producto
            Dim dao As AbstractDao(Of Producto) = DaoFactory(Of Producto).obtenerInstancia().crear(GetType(Producto))
            Dim criteria As New GenericQueryCriteria

            For i As Integer = 0 To componentesDeFormula.Count - 1
                cantIds = componentesDeFormula.ElementAt(i).Split("*")
                oProducto = Nothing
                criteria.integerCriteria = CType(cantIds.ElementAt(1), Integer)
                criteria.stringCriteria = ""
                oProducto = dao.obtenerUno(criteria)
                If Not oProducto Is Nothing Then
                    costo = costo + ((oProducto.precioCompra + oProducto.precioCosteAdquisicion + oProducto.costeDePosecion + oProducto.costeDePosecion + oProducto.costeFinanciero) * CType(cantIds.ElementAt(0), Integer))
                End If
            Next

            Return Math.Round(costo, 2)

        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try

    End Function
End Class

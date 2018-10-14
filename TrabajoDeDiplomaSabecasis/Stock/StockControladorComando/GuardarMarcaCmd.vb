Imports StockModelo
Imports StockControladorAccion
Imports StockDatos
Imports ElementosTransversales

Public Class GuardarMarcaCmd
    Inherits Comando(Of String, GuardarMarcaAccion)

    Public Overrides Function execute(accion As GuardarMarcaAccion) As String
        Try
            Dim dao As AbstractDao(Of Marca) = DaoFactory(Of Marca).obtenerInstancia().crear(GetType(Marca))
            If accion Is Nothing Then
                Throw New ExcepcionDeComando(New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA)), Me.GetType.ToString, accion)
            Else
                Dim oMarca As New Marca
                oMarca.id = accion.id
                oMarca.marca = accion.marca
                If accion.id <> 0 Then
                    Autorizador.obtenerInstancia.autorizar(ConstantesDePermisos.ACTUALIZAR)
                    dao.actualizar(oMarca)
                Else
                    Autorizador.obtenerInstancia.autorizar(ConstantesDePermisos.CREAR)
                    dao.guardar(oMarca)
                End If
            End If
            Return Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.MARCA_CREADA_CORRECTAMENTE)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try

    End Function
End Class

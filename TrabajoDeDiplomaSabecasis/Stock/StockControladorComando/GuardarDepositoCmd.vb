Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class GuardarDepositoCmd
    Inherits Comando(Of String, GuardarDepositoAccion)

    Public Overrides Function execute(accion As GuardarDepositoAccion) As String
        Try
            If accion Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            Dim oDeposito As New Deposito
            oDeposito.id = accion.id
            oDeposito.nomber = accion.nombre
            oDeposito.contacto = New Contacto
            oDeposito.contacto.calle = accion.calle
            oDeposito.contacto.nroPuerta = accion.nro
            oDeposito.contacto.departamento = accion.departamento
            oDeposito.contacto.localidad = accion.localidad
            oDeposito.contacto.email = accion.email
            oDeposito.contacto.piso = accion.piso
            oDeposito.contacto.telefonos = New List(Of Telefono)
            Dim tel As New Telefono()
            tel.telefono = accion.telefono
            oDeposito.contacto.telefonos.Add(tel)

            Dim dao As AbstractDao(Of Deposito) = DaoFactory(Of Deposito).obtenerInstancia.crear(GetType(Deposito))
            If accion.id <> 0 Then
                Autorizador.obtenerInstancia.autorizar(ConstantesDePermisos.ACTUALIZAR)
                dao.actualizar(oDeposito)

            Else
                Autorizador.obtenerInstancia.autorizar(ConstantesDePermisos.CREAR)
                dao.guardar(oDeposito)
            End If

            Return Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.DEPOSITO_GUARDADO_CON_EXITO) & " id " & oDeposito.id
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class

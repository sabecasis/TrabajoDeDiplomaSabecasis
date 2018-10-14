Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class GuardarSucursalCmd
    Inherits Comando(Of String, GuardarSucursalAccion)


    Public Overrides Function execute(accion As GuardarSucursalAccion) As String
        Try
            If accion Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            Dim oSucursal As New Sucursal()
            oSucursal.id = accion.id
            oSucursal.depositos = accion.depositos
            oSucursal.estado = accion.estado
            oSucursal.fechaApertura = accion.fechaApertura
            oSucursal.fechaCierre = accion.fechaCierre
            oSucursal.horarioCierre = accion.horarioCierre
            oSucursal.horarioInicio = accion.horarioInicio
            oSucursal.contacto = New Contacto()
            oSucursal.contacto.localidad = accion.localidad
            oSucursal.contacto.calle = accion.calle
            oSucursal.contacto.departamento = accion.departamento
            oSucursal.contacto.email = accion.email
            oSucursal.contacto.nroPuerta = accion.nroPuerta
            oSucursal.contacto.piso = accion.piso
            oSucursal.contacto.telefonos = New List(Of Telefono)
            Dim tel As New Telefono
            tel.telefono = accion.telefono
            oSucursal.contacto.telefonos.Add(tel)
            Dim dao As AbstractDao(Of Sucursal) = DaoFactory(Of Sucursal).obtenerInstancia.crear(GetType(Sucursal))

            If accion.id = 0 Then
                Autorizador.obtenerInstancia.autorizar(ConstantesDePermisos.CREAR)
                dao.guardar(oSucursal)
                Return Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.SCURSAL_CREADA_CON_EXITO)
            Else
                Autorizador.obtenerInstancia.autorizar(ConstantesDePermisos.ACTUALIZAR)
                dao.actualizar(oSucursal)
                Return Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.SCURSAL_CREADA_CON_EXITO)
            End If

        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class

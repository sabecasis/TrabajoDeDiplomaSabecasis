﻿Imports StockModelo
Imports System.Threading
Imports System.Globalization

Public Class Sesion

    Private Shared oSesion As Sesion = New Sesion()

    Property usuarioActual As Usuario = New Usuario()
    Property correlacionElementoIdioma As Hashtable = New Hashtable()
    Property bloqueado As Boolean

    Public ReadOnly Property DESSEED() As String
        Get
            Return "estaquelasacas"
        End Get
    End Property


    Private Sub New()
        cargarIdiomaYCulturaPorDefecto()
        Me.bloqueado = False
    End Sub

    Public Shared Function obtenerInstancia() As Sesion
        Return oSesion
    End Function

    Public Sub cargarIdiomaYCulturaPorDefecto()
        Thread.CurrentThread.CurrentCulture = New CultureInfo("es-AR")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("es-AR")
        correlacionElementoIdioma.Clear()
        correlacionElementoIdioma.Add(ConstantesDeIdioma.LBLUsuario, "Usuario")
        correlacionElementoIdioma.Add(ConstantesDeIdioma.LBLPassword, "Contraseña")
        correlacionElementoIdioma.Add(ConstantesDeIdioma.LBLIdioma, "Idioma")
        correlacionElementoIdioma.Add(ConstantesDeIdioma.BTNLogin, "Iniciar Sesión")
        correlacionElementoIdioma.Add(ConstantesDeIdioma.BTNOlvidarPassword, "Olvidé mi contraseña")
        correlacionElementoIdioma.Add(ConstantesDeIdioma.TITULOIniciarSesion, "Iniciar Sesión")
        correlacionElementoIdioma.Add(ConstantesDeIdioma.BTNCerrarSesion, "Cerrar Sesión")
        correlacionElementoIdioma.Add(ConstantesDeIdioma.LBLPedidoDeReposicionInicio, "pedidos de reposición de stock pendientes")
        correlacionElementoIdioma.Add(ConstantesDeIdioma.TITULOINICIO, "Inicio")
        correlacionElementoIdioma.Add(ConstantesDeIdioma.MNAgregarIdioma, "Agregar Idioma")
        correlacionElementoIdioma.Add(ConstantesDeIdioma.MNAdministrarEmpleados, "Administrar Empleados")
        correlacionElementoIdioma.Add(ConstantesDeIdioma.MNAdministrarUsuarios, "Administrar Usuarios")
        correlacionElementoIdioma.Add(ConstantesDeIdioma.MNAdministrarGrupos, "Administrar Grupos")
        correlacionElementoIdioma.Add(ConstantesDeIdioma.MNBitacoraLogin, "Bitacora Login")
        correlacionElementoIdioma.Add(ConstantesDeIdioma.MNBackup, "Backup")
        correlacionElementoIdioma.Add(ConstantesDeIdioma.MNAdministrarDepositos, "Administrar Depositos")
        correlacionElementoIdioma.Add(ConstantesDeIdioma.MNAdministrarSucursales, "Administrar Sucursales")
        correlacionElementoIdioma.Add(ConstantesDeIdioma.MNAdministrarMarcas, "Administrar Marcas")
        correlacionElementoIdioma.Add(ConstantesDeIdioma.MNAdministrarMonedas, "Administrar Monedas")
        correlacionElementoIdioma.Add(ConstantesDeIdioma.MNAdministrarProveedores, "Administrar Proveedores")
        correlacionElementoIdioma.Add(ConstantesDeIdioma.MNConsultarLogDeErrores, "Log De Errores")
        correlacionElementoIdioma.Add(ConstantesDeIdioma.MNIngresarStock, "Ingreso De Stock")
        correlacionElementoIdioma.Add(ConstantesDeIdioma.MNEgresoDeStock, "Egreso De Stock")
        correlacionElementoIdioma.Add(ConstantesDeIdioma.MNTransferenciaDeStock, "Transferrencia De Stock")
        correlacionElementoIdioma.Add(ConstantesDeIdioma.MNAdminstrarProductos, "Administrar Productos")
        correlacionElementoIdioma.Add(ConstantesDeIdioma.MNConsultarStockFaltante, "Consultar Stock Faltante")
        correlacionElementoIdioma.Add(ConstantesDeIdioma.MNConsultarStockPorProducto, "Consultar Stock Por Producto")
        correlacionElementoIdioma.Add(ConstantesDeIdioma.MNConsultarMovimientosDeStock, "Consultar Movimientos De Stock")
        correlacionElementoIdioma.Add(ConstantesDeIdioma.MNAdministrarInstanciasDeProducto, "Administrar Instancias De Producto")
        correlacionElementoIdioma.Add(ConstantesDeIdioma.MNAdministrarDescuentos, "Administrar Descuentos")
        correlacionElementoIdioma.Add(ConstantesDeIdioma.MNAdmininistrarRoles, "Administrar Roles")
        correlacionElementoIdioma.Add(ConstantesDeIdioma.MNBitacora, "Bitácora")
        correlacionElementoIdioma.Add(ConstantesDeIdioma.MNNegocio, "Negocio")
        correlacionElementoIdioma.Add(ConstantesDeIdioma.MNSeguridad, "Seguridad")
        correlacionElementoIdioma.Add(ConstantesDeIdioma.MNUsuarios, "Usuarios")
        correlacionElementoIdioma.Add(ConstantesDeIdioma.MNStock, "Stock")
        cargarMensajesEnIdiomaPorDefecto()
    End Sub

    Private Sub cargarMensajesEnIdiomaPorDefecto()
        correlacionElementoIdioma.Add(ConstantesDeMensaje.ERROR_AL_CREAR_IDIOMA, "Ha ocurrido un error al crear el idioma")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.IDIOMA_GUARDADO_CON_EXITO, "El idioma ha sido agregado con éxito")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.PASSWORD_INCORRECTA, "La password ingresada es incorrecta")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.USUARIO_BLOQUEADO, "El usuario se encuentra bloqueado")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.USUARIO_INEXISTENTE, "No se ha podido encontrar el usuario")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.NO_HAY_NUEVO_PUESTO, "No hay ningun puesto nuevo para guardar")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.PUESTO_GUARDADO_CON_EXITO, "El puesto ha sido guardado correctamente")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.ERROR_AL_GUARDAR_PUESTO, "Ha ocurrido un error al gurdar el/los puestos")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.EMPLEADO_CREADO_CON_EXITO, "El empleado a sido creado con éxito")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.ERROR_AL_CREAR_EMPLEADO, "Ha ocurrido un error al crear el empleado, por favor revise los datos e intentelo nuevamente")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.ERROR_MAS_DE_UN_PUESTO_POR_EMPLEADO, "Por favor, revise el puesto del empleado. Un empleado solo puede tener un puesto y debe poseer al menos un puesto asociado")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.USUARIO_CREADO_CON_EXITO, "El usuario ha sido creado con éxito")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.ERROR_AL_CREAR_USUARIO, "Ha ocurrido un error al crear el usuario, por favor, revise los datos ingresados e intentelo nuevamente")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.CONTRASENIAS_DISTINTAS, "Las contraseñas ingresadas no coinciden")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.GRUPO_GUARDADO_CON_EXITO, "El grupo se ha guardado con éxito")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.ERROR_AL_GUARDAR_GRUPO, "Ha ocurrido un error al guardar el grupo")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.ROL_GUARDADO_CORRECTAMENTE, "El rol se ha guardado correctamente")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.ERROR_AL_GUARDAR_ROL, "Ha ocurrido un error al guardar el rol, por favor, revise los datos y vuelva a intentarlo")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.NO_TIENE_PERMISO, "No tiene permiso para realizar esta acción")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.ERROR_DGV_HORIZONTAL, "El digito verificador horizontal es incorrecto, se estima que se ha corrompido un registro de una tabla de la base de datos. A continuación, el nombre de la entidad asociada a la tabla y el id del registro: ")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.BACKUP_CREADO_CORRECTO, "Backup creado correctamente")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.BACKUP_RESTAURADO_CORRECTAMENTE, "La base de datos ha sido restaurada correctamente")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.NO_SE_ENCONTRO_EL_EMPLEADO, "El empleado no ha podido encontrarse en la base de datos, dada la siguiente condición de búsqueda: ")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.EMPLEADO_ACTUALIZADO_CORRECTAMENTE, "El empleado se ha actualizado correctamente")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.EMPLEADO_ELIMINADO_CORRECTAMENTE, "El empleado y todos sus usuarios han sido eliminado del sistema correctamente ")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.USUARIO_ELIMINADO_EXITOSAMENTE, "El usuario ha sido eliminado con exito ")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.GRUPO_ELIMINADO_EXITOSAMENTE, "El grupo ha sido eliminado con exito ")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.ROL_ELIMINADO_CORRECTAMENTE, "El rol fue eliminado correctamente")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.ERROR_DGV_VERTICAL, "El dígito verificador vertical es incorrecto")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.MARCA_NULA, "La marca no puede estar vacía")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.MONEDA_NULA, "La moneda no puede estar vacía")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.MARCA_CREADA_CORRECTAMENTE, "La marca fue guardada correctamente.")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.ID_NULA, "El id no puede estar vacío")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.MARCA_ELIMINADA_CORRECTAMENTE, "La marca especificada ha sido eliminada correctamente. id: ")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.CRITERIO_DE_BUSQUEDA_NULO, "El criterio de búsqueda no puede estar vacío")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.NO_SE_ENCONTRO_LA_MARCA, "No se ha podido encontrar la marca por los paámetros especificados")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.ACCION_NULA, "La accion es nula!")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.MONEDA_ELIMINADA_CORRECTAMENTE, "La moneda ha sido eliminada con exito. Id: ")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.MONEDA_GUARDADA_CON_EXITO, "La moneda ha sido GUARDADA con exito.")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.NO_SE_ENCONTRO_LA_MONEDA, "No se pudo encontrar ninguna moneda con los datos de busqueda ingresados")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.NO_SE_ENCONTRO_EL_DEPOSITO, "No se pudo encontrar ninguna deposito con los datos de busqueda ingresados")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.ELEMENTOS_NULOS, "No todos los elementos obligatorios han sido llenados")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.DEPOSITO_GUARDADO_CON_EXITO, "El deposito ha sido guardado con éxito")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.DEPOSITO_ELIMINADO_CON_EXITO, "El deposito ha sido eliminado con éxito. id: ")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.ERROR_AL_CREAR_SUCURSAL, "Error! La sucursal no ha podido crearse")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.SCURSAL_CREADA_CON_EXITO, "La sucursal se ha guardado exitosamente")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.SUCURSAL_ELIMINADA_CORRECTAMENTE, "La sucursal se ha eliminado exitosamente")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.NO_SE_ENCONTRO_LA_SUCURSAL, "No se ha podido encontrar una sucursal para la criteria de búsqueda especificada ")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.PROVEEDOR_GUARDADO_CON_EXITO, "El proveedor se ha guardado correctamente")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.PROVEEDOR_ELIMINADO_CORRECTAMENTE, "El proveedor se ha eliminado correctamente")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.ERROR_AL_CREAR_PRODUCTO, "Error al crear producto")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.PRODUCTO_GUARDADO_CON_EXITO, "El producto se guardó correctamente. Id ")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.NO_SE_ENCONTRO_PRODUCTO, "No se pudo encontrar el producto por los criterios de búsqueda especificados")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.INGRESO_CORRECTO, "El lote de stock se ha ingresado correctamente con id: ")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.INGRESO_ELIMINADO, "El lote de stock se ha eliminado con éxito")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.NO_SE_ENCONTRO_EL_INGRESO, "No se encontro ningun ingreso con los criterios de búsqueda ingresados")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.NO_SE_ENCONTRO_EL_PROVEEDOR, "No se encontro el proveedor por el criterio de búsqueda ingresado")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.DESCUENTO_NO_ENCONTRADO, "No se encontro ningún descuento por el criterio de búsqueda ingresado")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.DESCUENTO_ELIMINADO, "El descuento se eliminó exitosamente")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.DESCUENTO_GUARDADO, "El descuento se ha guardado correctamente")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.PRODUCTO_EN_USO, "No puede eliminar el producto porque ya está en uso, cambie el estado en su lugar")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.DEBE_INGRESAR_LA_FACTURA, "Debe ingresar la factura otorgada por su proveedor")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.NO_HAY_SUFICIENTES_ARTICULOS, "No existen suficientes instancias de productos para la cantidad seleccionada en el producto seleccionado, del proveedor seleccionado en el deposito seleccionado")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.EGRESO_STOCK_GUARDADO, "Egreso de stock guardado con exito con id ")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.NO_SE_ENCONTRO_EL_EGRESO, "No se encontró ningun egreso de stock por el id dado ")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.EGRESO_ELIMINADO, "El egreso de stock fue eliminado con éxito")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.MOVIMIENTO_GUARDADO, "El movimiento de stock se guardó con éxito con id ")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.NO_SE_ENCONTRO_EL_MOVIMIENTO, "No se encontró ningún movimiento de stock para el criterio de búsqueda ingresado")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.MOVIMIENTO_ELIMINADO, "El movimiento de stock fue eliminado con éxito")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.PEDIDO_GUARDADO, "El pedido de reposición de stock se guardó correctamente on id ")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.NO_SE_ENCONTRO_EL_PEDIDO, "No se encontró ningún pedido de stock por el id especificado")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.PEDIDO_ELIMINADO, "El pedido de stock ha sido eliminado con éxito")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.NO_HAY_ARTICULOS_SUFICIENTES, "Este producto consta de una cantidad de materias primas, una o varias de las existencias de materia prima no es suficiente para ingresar el stock  ")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.PASSWORD_CAMBIADA, "La password se cambió con éxito")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.FAMILIA_PROD_ELIMINADA, "La familia de productos fue eliminada con éxito")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.FAMILIA_PROD_GUARDADA, "La familia se guardó con éxito")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.NO_SE_ENCONTRO_LA_FAMILIA, "No se encontró ninguna familia de producto por los parámetros de búsqueda especificados")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.VERIFICADORES_VERTICALES_GENERADOS, "Los verificadores verticales han sido calculados con éxito")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.BASE_DE_DATOS_CREADA, "La base de datos ha sido generada correctamente")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.VERIFICADORES_HORIZONTALES_GENERADOS, "Verificadores horizontales correctamente generados")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.NO_SE_ENCONTRO_PEDIDO_ASOCIADO, "No se pudo encontrar un pedido de stock asociado a este producto, por favor cree una solicitud de stock antes de generar un ingreso")
        correlacionElementoIdioma.Add(ConstantesDeMensaje.IDIOMA_ELIMINADO, "El idioma ha sido eliminado correctamente")
    End Sub
End Class

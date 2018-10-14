Public Class ConstantesDeDatos


    Public Shared ReadOnly Property OBTENER_TODOS_LOS_USUARIOS_GRUPOS_SP() As String
        Get
            Return "obtener_todos_los_usuarios_grupos"
        End Get
    End Property
    Public Shared ReadOnly Property GUARDAR_DGV_HORIZONTAL_USUARIO_SP() As String
        Get
            Return "guardar_dgv_usuario"
        End Get
    End Property

    Public Shared ReadOnly Property ELIMINAR_IDIOMA_SP() As String
        Get
            Return "eliminar_idioma"
        End Get
    End Property



    Public Shared ReadOnly Property OBTENER_IDIOMA_POR_NOMBRE_SP() As String
        Get
            Return "obtener_idioma_por_nombre"
        End Get
    End Property


    Public Shared ReadOnly Property OBTENER_TODOS_LOS_ELEMENTOS_POR_IDIOMA_SP() As String
        Get
            Return "obtener_elementos_por_idioma"
        End Get
    End Property


    Public Shared ReadOnly Property OBTENER_TODOS_LOS_INGRESOS_DE_STOCK_POR_PEDIDO_SP() As String
        Get
            Return "obtener_todos_los_ingrsos_de_stock_por_pedido"
        End Get
    End Property




    Public Shared ReadOnly Property OBTENER_TODOS_LOS_ROLES_SP() As String
        Get
            Return "obtener_todos_los_roles"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_ENTIDAD_DAO_XREF_SP() As String
        Get
            Return "obtener_entidad_dao_xref"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_TODOS_LOS_ENTIDAD_DAO_XREF_SP() As String
        Get
            Return "obtener_todos_entidad_dao_xref"
        End Get
    End Property

    Public Shared ReadOnly Property BUSCAR_FAMILIA_DE_PRODUCTO_SP() As String
        Get
            Return "obtener_familia_de_producto"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_INSTANCIAS_DE_PRODUCTO_CON_FILTRO_SP() As String
        Get
            Return "filtrar_instancias_de_producto"
        End Get
    End Property


    Public Shared ReadOnly Property GUARDAR_EN_BITACORA_SP() As String
        Get
            Return "guardar_en_bitacora"
        End Get
    End Property




    Public Shared ReadOnly Property OBTENER_TODAS_LAS_FAMILIAS_DE_PRODUCTO_SP() As String
        Get
            Return "obtener_todas_las_familias_de_producto"
        End Get
    End Property

    Public Shared ReadOnly Property ACTUALIZAR_FAMILIA_DE_PRODUCTO_SP() As String
        Get
            Return "actualizar_familia_de_producto"
        End Get
    End Property

    Public Shared ReadOnly Property ELIMINAR_FAMILIA_DE_PRODUCTO_SP() As String
        Get
            Return "eliminar_familia_de_productos_sp"
        End Get
    End Property



    Public Shared ReadOnly Property CREAR_FAMILIA_DE_PRODUCTOS_SP() As String
        Get
            Return "crear_familia_de_productos"
        End Get
    End Property


    Public Shared ReadOnly Property ELIMINAR_PEDIDO_STOCK_SP() As String
        Get
            Return "eliminar_pedido_de_reposicion"
        End Get
    End Property
    Public Shared ReadOnly Property OBTENER_ULTIMA_FECHA_DE_INGRESO_EN_STOCK_SP() As String
        Get
            Return "obtener_fecha_ultimo_ingreso_de_stock_en_deposito_por_producto"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_TODAS_LAS_SUCURSALES_SP() As String
        Get
            Return "obtener_todas_las_sucursales"
        End Get
    End Property


    Public Shared ReadOnly Property ACTUALIZAR_PEDIDO_STOCK_SP() As String
        Get
            Return "actualizar_pedido_de_reposicion"
        End Get
    End Property
    Public Shared ReadOnly Property OBTENER_METODO_DE_REPOSICION_POR_PRODUCTO_SP() As String
        Get
            Return "obtener_metodo_de_reposicion_por_producto"
        End Get
    End Property



    Public Shared ReadOnly Property OBTENER_TODOS_LOS_MOVIMIENTOS_DE_STOCK_PENDIENTES_POR_DEPOSITO_SP() As String
        Get
            Return "obtener_movimientos_de_stock_pendientes_de_aceptacion"
        End Get
    End Property



    Public Shared ReadOnly Property ELIMINAR_DEPOSITO_POR_EMPLEADO() As String
        Get
            Return "eliminar_todos_los_depositos_por_empleado"
        End Get
    End Property

    Public Shared ReadOnly Property CREAR_RELACION_EMPLEADO_DEPOSITO() As String
        Get
            Return "guardar_relacion_empleado_deposito"
        End Get
    End Property


    Public Shared ReadOnly Property OBTENER_TODOS_LOS_DEPOSITOS_POR_EMPLEADO_SP() As String
        Get
            Return "OBTENER_TODOS_LOS_DEPOSITOS_POR_EMPLEADO_SP"
        End Get
    End Property

    Public Shared ReadOnly Property ACEPTAR_INGRESO_PEDIDO_DE_STOCK_SP() As String
        Get
            Return "aceptar_pedido_de_reposicion"
        End Get
    End Property



    Public Shared ReadOnly Property CREAR_PEDIDO_DE_STOCK_SP() As String
        Get
            Return "crear_pedido_de_reposicion"
        End Get
    End Property
    Public Shared ReadOnly Property OBTENER_TODOS_LOS_PEDIDOS_DE_STOCK_CON_FILTRO_SP() As String
        Get
            Return "obtener_todos_los_pedidos_de_reposicion_con_filtro"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_TODOS_LOS_PEDIDOS_DE_STOCK_NO_INGRESADOS_SP() As String
        Get
            Return "obtener_pedidos_de_reposicion_no_aceptados"
        End Get
    End Property



    Public Shared ReadOnly Property BUSCAR_PEDIDO_STOCK_SP() As String
        Get
            Return "obtener_pedido_de_reposicion_por_id"
        End Get
    End Property


    Public Shared ReadOnly Property GUARDAR_COMPROBANTE_PEDIDO_STOCK() As String
        Get
            Return "actualizar_comprobante_pedido_de_reposicion"
        End Get
    End Property


    Public Shared ReadOnly Property OBTENER_TODOS_LOS_INGRESOS_DE_STOCK_CON_FILTRO_SP() As String
        Get
            Return "obtener_todos_los_ingresos_de_stock_con_filtro"
        End Get
    End Property

    Public Shared ReadOnly Property GUARDAR_ERROR_SP() As String
        Get
            Return "guardar_log_de_errores"
        End Get
    End Property

    Public Shared ReadOnly Property CONSULTAR_LOG_DE_ERRORES_SP() As String
        Get
            Return "consultar_log_de_errores"
        End Get
    End Property


    Public Shared ReadOnly Property OBTENER_TODOS_LOS_TIPOS_DE_EXCEPCION_SP() As String
        Get
            Return "obtener_todos_los_tipos_de_excepcion"
        End Get
    End Property



    Public Shared ReadOnly Property OBTENER_TODOS_LOS_MOVIMIENTOS_DE_STOCK_CON_FILTRO() As String
        Get
            Return "obtener_todos_los_movimientos_de_stock_con_filtro"
        End Get
    End Property



    Public Shared ReadOnly Property OBTENER_TODOS_LOS_EGRESOS_DE_STOCK_CON_FILTRO_SP() As String
        Get
            Return "obtener_todos_los_egresos_de_stock_con_filtro"
        End Get
    End Property



    Public Shared ReadOnly Property OBTENER_TODAS_LAS_INSTANCIAS_PRODUCTO_POR_MOVIMIENTO_SP() As String
        Get
            Return "obtener_todas_las_instancias_producto_por_movimiento_de_stock"
        End Get
    End Property

    Public Shared ReadOnly Property OBTNER_TODAS_LAS_EXISTENCIAS_SP() As String
        Get
            Return "obtener_todas_las_existencias"
        End Get
    End Property



    Public Shared ReadOnly Property OBTENER_TODOS_LOS_METODOS_DE_REPOSICION_SP() As String
        Get
            Return "obtener_todos_los_metodos_de_reposicion"
        End Get
    End Property


    Public Shared ReadOnly Property ELIMINAR_MOVIMIENTO_DE_STOCK() As String
        Get
            Return "eliminar_movimiento_de_stock"
        End Get
    End Property



    Public Shared ReadOnly Property ACTUALIZAR_MOVIMIENTO_DE_STOCK_SP() As String
        Get
            Return "actualizar_movimiento_de_stock"
        End Get
    End Property


    Public Shared ReadOnly Property OBTENER_MOVIMIENTO_DE_STOCK_SP() As String
        Get
            Return "obtener_movimiento_de_stock"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_TODOS_LOS_MOVIMIENTOS_DE_STOCK_POR_INSTANCIA_SP() As String
        Get
            Return "obtener_movimientos_de_stock_por_instancia_de_producto"
        End Get
    End Property

    Public Shared ReadOnly Property GUARDAR_RELACION_INSTANCIA_MOVIMIENTO_SP() As String
        Get
            Return "guardar_relacion_instancia_movimiento_de_stock"
        End Get
    End Property

    Public Shared ReadOnly Property GUARDAR_COMPROBANTE_DE_MOVIMIENTO_SP() As String
        Get
            Return "guardar_comprobante_movimiento_stock"
        End Get
    End Property



    Public Shared ReadOnly Property OBTENER_TODOS_LOS_ESTADOS_INST_PROD_SP() As String
        Get
            Return "otener_todos_los_estados_instancia_de_producto"
        End Get
    End Property

    Public Shared ReadOnly Property CREAR_MOVIMIENTO_DE_STOCK_SP() As String
        Get
            Return "guardar_movimiento_de_stock"
        End Get
    End Property


    Public Shared ReadOnly Property ELIMINAR_EGRESO_DE_STOCK_SP() As String
        Get
            Return "eliminar_egreso_stock"
        End Get
    End Property


    Public Shared ReadOnly Property ACTUALIZAR_EGRESO_DE_STOCK_SP() As String
        Get
            Return "actualizar_egreso_stock"
        End Get
    End Property




    Public Shared ReadOnly Property BUSCAR_EGRESO_DE_STOCK_SP() As String
        Get
            Return "obtener_egreso_stock"
        End Get
    End Property



    Public Shared ReadOnly Property OBTENER_TODAS_LAS_INSTANCIAS_PRODUCTO_POR_EGRESO_SP() As String
        Get
            Return "obtener_todas_las_instancias_producto_por_egreso"
        End Get
    End Property


    Public Shared ReadOnly Property GUARDAR_COMPROBANTE_EGRESO_STOCK_SP() As String
        Get
            Return "guardar_comprobante_egreso_stock"
        End Get
    End Property



    Public Shared ReadOnly Property ACTUALIZAR_INSTANCIA_PRODUCTO_SP() As String
        Get
            Return "actualizar_instancia_de_producto"
        End Get
    End Property


    Public Shared ReadOnly Property CREAR_EGRESO_DE_STOCK_SP() As String
        Get
            Return "crear_egreso_stock"
        End Get
    End Property



    Public Shared ReadOnly Property OBTENER_TODOS_LOS_DEPOSITOS_POR_PRODUCTO_SP() As String
        Get
            Return "obtener_depositos_por_producto"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_INSTANCIAS_DE_PRODUCTO_PARA_EGRESO_SP() As String
        Get
            Return "obtener_instancias_producto_para_egreso"
        End Get
    End Property


    Public Shared ReadOnly Property ACTUALIZAR_INGRESO_STOCK_SP() As String
        Get
            Return "actualizar_ingreso_stock"
        End Get
    End Property

    Public Shared ReadOnly Property BUSCAR_PRODUCTO_SP() As String
        Get
            Return "buscar_producto"
        End Get
    End Property

    Public Shared ReadOnly Property ELIMINAR_DESCUENTO_SP() As String
        Get
            Return "eliminar_descuento"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_DESCUENTO_SP() As String
        Get
            Return "obtener_descuento"
        End Get
    End Property

    Public Shared ReadOnly Property CREAR_DESCUENTO_SP() As String
        Get
            Return "crear_descuento"
        End Get
    End Property

    Public Shared ReadOnly Property ACTUALIZAR_DESCUENTO_SP() As String
        Get
            Return "actualizar_descuento"
        End Get
    End Property


    Public Shared ReadOnly Property BUSCAR_INGRESO_STOCK_SP() As String
        Get
            Return "buscar_ingreso_stock"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_TODAS_LAS_INSTANCIAS_PRODUCTO_POR_INGRESO_SP() As String
        Get
            Return "obtener_instancias_producto_por_ingreso_stock"
        End Get
    End Property



    Public Shared ReadOnly Property GUARDAR_FACTURA_PROVEEDOR_STOCK_SP() As String
        Get
            Return "guardar_factura_proveedor"
        End Get
    End Property

    Public Shared ReadOnly Property ACTUALIZAR_FACTURA_PROVEEDOR_STOCK() As String
        Get
            Return "actualizar_factura_proveedor"
        End Get
    End Property



    Public Shared ReadOnly Property ELIMINAR_INGRESO_STOCK_SP() As String
        Get
            Return "eliminar_ingreso_stock"
        End Get
    End Property



    Public Shared ReadOnly Property CREAR_INSTANCIA_PRODUCTO_SP() As String
        Get
            Return "crear_instancia_producto"
        End Get
    End Property



    Public Shared ReadOnly Property CREAR_INGRESO_DE_STOCK_SP() As String
        Get
            Return "crear_ingreso_stock"
        End Get
    End Property

    Public Shared ReadOnly Property GUARDAR_COMPROBANTE_INGRESO_STOCK() As String
        Get
            Return "guardar_comprobante_ingreso_stock"
        End Get
    End Property



    Public Shared ReadOnly Property OBTENER_TODOS_LOS_PRODUCTOS_SP() As String
        Get
            Return "obtener_todos_los_productos"
        End Get
    End Property



    Public Shared ReadOnly Property OBTENER_TODAS_LAS_INSTANCIAS_PRODUCTO_POR_PROD_SP() As String
        Get
            Return "obtener_todas_las_instancias_prducto"
        End Get
    End Property

    Public Shared ReadOnly Property CREAR_RELACION_PRODUCTO_PROVEEDOR() As String
        Get
            Return "crear_releacion_producto_proveedor"
        End Get
    End Property


    Public Shared ReadOnly Property OBTENER_TODOS_PROVEEDORES_POR_PRODUCTO_SP() As String
        Get
            Return "obtener_todos_los_proveedores_por_producto"
        End Get
    End Property

    Public Shared ReadOnly Property ELIMINAR_RELACION_PRODUCTO_PROVEEDOR() As String
        Get
            Return "eliminar_relacion_producto_proveedor"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_TODOS_LOS_ESTADOS_DE_PRODUCTO_SP() As String
        Get
            Return "obtener_todos_los_estados_de_producto"
        End Get
    End Property

    Public Shared ReadOnly Property ELIMINAR_PRODUCTO_SP() As String
        Get
            Return "eliminar_producto"
        End Get
    End Property

    Public Shared ReadOnly Property CREAR_PRODUCTO_SP() As String
        Get
            Return "crear_producto"
        End Get
    End Property

    Public Shared ReadOnly Property ACTUALIZAR_PRODUCTO_SP() As String
        Get
            Return "actualizar_producto"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_TODAS_LAS_CLASIFICACIONES_PRODUCTO_SP() As String
        Get
            Return "obtener_todas_las_clasificaciones_de_producto"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_TODAS_LAS_MATERIAS_PRIMAS_SP() As String
        Get
            Return "obtener_materias_primas"
        End Get
    End Property


    Public Shared ReadOnly Property ELIMINAR_PROVEEDOR_SP() As String
        Get
            Return "eliminar_proveedor"
        End Get
    End Property
    Public Shared ReadOnly Property OBTENER_TODAS_LAS_MONEDAS_SP() As String
        Get
            Return "obtener_todas_las_monedas"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_TODAS_LAS_MARCAS_SP() As String
        Get
            Return "obtener_todas_las_marcas"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_TODOS_LOS_DESCUENTOS_SP() As String
        Get
            Return "obtener_todos_los_descuentos"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_TODOS_LOS_MODOS_DE_VALORACION_SP() As String
        Get
            Return "obtener_todos_los_metodos_valoracion"
        End Get
    End Property



    Public Shared ReadOnly Property OBTENER_TODOS_PROVEEDOR_SP() As String
        Get
            Return "obtener_todos_los_proveedores"
        End Get
    End Property


    Public Shared ReadOnly Property BUSCAR_PROVEEDOR_SP() As String
        Get
            Return "buscar_proveedor"
        End Get
    End Property


    Public Shared ReadOnly Property ELIMINAR_SUCURSAL_SP() As String
        Get
            Return "eliminar_sucursal"
        End Get
    End Property

    Public Shared ReadOnly Property ACTUALIZAR_PROVEEDOR_SP() As String
        Get
            Return "actualizar_proveedor"
        End Get
    End Property

    Public Shared ReadOnly Property CREAR_PROVEEDOR_SP() As String
        Get
            Return "crear_proveedor"
        End Get
    End Property


    Public Shared ReadOnly Property OBTENER_TODOS_LOS_ESTADOS_DE_PROVEEDOR_SP() As String
        Get
            Return "obtener_todos_estados_proveedor"
        End Get
    End Property

    Public Shared ReadOnly Property BUSCAR_SUCURSAL_SP() As String
        Get
            Return "buscar_sucursal"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_TODOS_LOS_ESTADOS_SUCURSAL_SP() As String
        Get
            Return "obtener_todos_los_estados_sucursal"
        End Get
    End Property

    Public Shared ReadOnly Property ACTUALIZAR_SUCURSAL_SP() As String
        Get
            Return "actualizar_sucursal"
        End Get
    End Property

    Public Shared ReadOnly Property ELIMINAR_RELACION_SUCURSAL_DEPOSITO_SP() As String
        Get
            Return "eliminar_relacion_sucursal_deposito"
        End Get
    End Property


    Public Shared ReadOnly Property CREAR_RELACION_SUCURSAL_DEPOSITO_SP() As String
        Get
            Return "crear_relacion_sucursal_deposito"
        End Get
    End Property



    Public Shared ReadOnly Property CREAR_SUCURSAL_SP() As String
        Get
            Return "crear_sucursal"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_TODOS_LOS_DEPOSITOS_SP() As String
        Get
            Return "obtener_todos_los_depositos"
        End Get
    End Property


    Public Shared ReadOnly Property OBTENER_TODOS_LOS_DEPOSITOS_POR_SUCURSAL_SP() As String
        Get
            Return "obtener_todos_los_depositos_por_sucursal"
        End Get
    End Property



    Public Shared ReadOnly Property ELIMINAR_MARCA_SP() As String
        Get
            Return "eliminar_marca"
        End Get
    End Property

    Public Shared ReadOnly Property BUSCAR_DEPOSITO_SP() As String
        Get
            Return "buscar_deposito"
        End Get
    End Property

    Public Shared ReadOnly Property ELIMINAR_DEPOSITO_SP() As String
        Get
            Return "eliminar_deposito"
        End Get
    End Property

    Public Shared ReadOnly Property ACTUALIZAR_DEPOSITO_SP() As String
        Get
            Return "actualizar_deposito"
        End Get
    End Property

    Public Shared ReadOnly Property ELIMINAR_MONEDA_SP() As String
        Get
            Return "eliminar_moneda"
        End Get
    End Property
    Public Shared ReadOnly Property CREAR_DEPOSITO_SP() As String
        Get
            Return "crear_deposito"
        End Get
    End Property

    Public Shared ReadOnly Property ACTUALIZAR_MARCA() As String
        Get
            Return "actualizar_marca"
        End Get
    End Property

    Public Shared ReadOnly Property ACTUALIZAR_MONEDA() As String
        Get
            Return "actualizar_moneda"
        End Get
    End Property



    Public Shared ReadOnly Property BUSCAR_MARCA_SP() As String
        Get
            Return "buscar_marca"
        End Get
    End Property

    Public Shared ReadOnly Property BUSCAR_MONEDA_SP() As String
        Get
            Return "buscar_moneda"
        End Get
    End Property


    Public Shared ReadOnly Property CREAR_MARCA_SP() As String
        Get
            Return "crear_marca"
        End Get
    End Property

    Public Shared ReadOnly Property CREAR_MONEDA_SP() As String
        Get
            Return "crear_moneda"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_PAIS_POR_ID_SP() As String
        Get
            Return "obtener_pais_por_id"
        End Get
    End Property

    Public Shared ReadOnly Property ELIMINAR_ROL_SP() As String
        Get
            Return "eliminar_rol"
        End Get
    End Property

    Public Shared ReadOnly Property ELIMINAR_USUARIO_SP() As String
        Get
            Return "eliminar_usuario"
        End Get
    End Property

    Public Shared ReadOnly Property ELIMINAR_EMPLEADO_SP() As String
        Get
            Return "eliminar_empleado"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_USUARIOS_DE_EMPLEADO_SP() As String
        Get
            Return "obtener_usuarios_de_empleado"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_NRO_EMPLEADO_POR_DNI_SP() As String
        Get
            Return "obtener_nro_empleado_por_dni"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_PROVINCIA_POR_ID_SP() As String
        Get
            Return "obtener_provincia_por_id"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_LOCALIDAD_POR_ID_SP() As String
        Get
            Return "obtener_localidad_por_id"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_PERSONA_POR_ID_SP() As String
        Get
            Return "obtener_persona_por_id"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_EMPLEADO_POR_NRO_EMPLEADO_SP() As String
        Get
            Return "obtener_empleado_por_nro_empleado"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_TODOS_LOS_ELEMENTOS_DE_BITACORA_SP() As String
        Get
            Return "obtener_elementos_de_bitacora"
        End Get
    End Property


    Public Shared ReadOnly Property OBTENER_TODOS_LOS_EVENTOS_DE_BITACORA_SP() As String
        Get
            Return "obtener_todos_los_eventos_de_bitacora"
        End Get
    End Property

    Public Shared ReadOnly Property RESTAURAR_BACKUP_SP() As String
        Get
            Return "restore_db"
        End Get
    End Property

    Public Shared ReadOnly Property CREAR_BACKUP_SP() As String
        Get
            Return "db_backup"
        End Get
    End Property




    Public Shared ReadOnly Property OBTENER_COMANDO_ACCION_RESULTADO_XREF_SP() As String
        Get
            Return "obtener_comando_accion_resultado_xref"
        End Get
    End Property

    Public Shared ReadOnly Property CHECKEAR_VERIFICADOR_VERTICAL_ROL_SP() As String
        Get
            Return "checkear_verificador_vetical_rol"
        End Get
    End Property

    Public Shared ReadOnly Property CHECKEAR_VERIFICADOR_VERTICAL_USUARIO_SP() As String
        Get
            Return "checkear_verificador_vetical_usuario"
        End Get
    End Property

    Public Shared ReadOnly Property ACTUALIZAR_ROL_SP() As String
        Get
            Return "actualizar_rol"
        End Get
    End Property

    Public Shared ReadOnly Property GUARDAR_DGV_VERTICAL_ROL() As String
        Get
            Return "guardar_dgv_vertical_rol"
        End Get
    End Property

    Public Shared ReadOnly Property GUARDAR_DGV_HORIZONTAL_ROL() As String
        Get
            Return "guardar_dgv_horizontal_rol"
        End Get
    End Property

    Public Shared ReadOnly Property GUARDAR_DGV_VERTICAL_USUARIO_SP() As String
        Get
            Return "guardar_dgv_vertical_usuario"
        End Get
    End Property

    Public Shared ReadOnly Property ELIMINAR_TODOS_LOS_PERMISOS_DE_ROL_SP() As String
        Get
            Return "eliminar_permisos_de_rol"
        End Get
    End Property

    Public Shared ReadOnly Property GUARDAR_DGV_USUARIO_SP() As String
        Get
            Return "guardar_dgv_usuario"
        End Get
    End Property


    Public Shared ReadOnly Property OBTENER_TODOS_LOS_PERMISOS_POR_ROL_SP() As String
        Get
            Return "obtener_permmisos_por_rol"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_TODOS_LOS_PERMISOS_SP() As String
        Get
            Return "obtener_todos_los_permisos_sp"
        End Get
    End Property

    Public Shared ReadOnly Property GUARDAR_ROL_SP() As String
        Get
            Return "guardar_rol"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_MODULO_POR_ROL_SP() As String
        Get
            Return "obtener_modulo_por_rol"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_ROL_POR_NOMBRE_SP() As String
        Get
            Return "obtener_rol_por_nombre_sp"
        End Get
    End Property

    Public Shared ReadOnly Property GUARDAR_RELACION_GRUPO_ROL_SP() As String
        Get
            Return "gurdar_relacion_grupo_rol"
        End Get
    End Property

    Public Shared ReadOnly Property GUARDAR_RELACION_PERMISO_ROL_SP() As String
        Get
            Return "gurdar_relacion_permiso_rol"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_GRUPOS_POR_ROL_SP() As String
        Get
            Return "obtener_grupos_por_rol"
        End Get
    End Property

    Public Shared ReadOnly Property ELIMINAR_TODOS_LOS_ROLES_DE_GRUPO_SP() As String
        Get
            Return "eliminar_roles_de_grupo"
        End Get
    End Property


    Public Shared ReadOnly Property OBTENER_TODOS_LOS_MODULOS_SP() As String
        Get
            Return "obtener_todos_los_modulos"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_ROLES_POR_GRUPO_SP() As String
        Get
            Return "obtener_roles_por_grupo"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_GRUPOS_USARIOS_POR_USUARIO_SP() As String
        Get
            Return "obtener_grupos_usarios_por_usuario"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_GRUPOS_USUARIOS_POR_GRUPO_SP() As String
        Get
            Return "obtener_grupos_usuarios_por_grupo"
        End Get
    End Property

    Public Shared ReadOnly Property ACTUALIZAR_GRUPO_SP() As String
        Get
            Return "actualizar_grupo"
        End Get
    End Property


    Public Shared ReadOnly Property ELIMINAR_TODOS_LOS_GRUPOS_DE_USUARIO_SP() As String
        Get
            Return "eliminar_todos_los_grupos_por_usuario_id"
        End Get
    End Property

    Public Shared ReadOnly Property GUARDAR_RELACION_USUARIO_GRUPO_SP() As String
        Get
            Return "guardar_relacion_usuario_grupo"
        End Get
    End Property

    Public Shared ReadOnly Property GUARDAR_GRUPO_SP() As String
        Get
            Return "guardar_grupo"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_TODOS_LOS_USUARIOS() As String
        Get
            Return "obtener_todos_los_usuarios"
        End Get
    End Property


    Public Shared ReadOnly Property ELMINAR_RELACION_EMPLEADO_USUARIO_SP() As String
        Get
            Return "eiminar_usuario_empleado_xref"
        End Get
    End Property


    Public Shared ReadOnly Property ACTUALIZAR_USUARIO_SP() As String
        Get
            Return "actualizar_usuario"
        End Get
    End Property
    Public Shared ReadOnly Property OBTENER_USUARIO_POR_NOMBRE_SP() As String
        Get
            Return "obtener_usuario_por_nombre_usuario"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_TODOS_LOS_EMPLEADOS_POR_USUARIO_SP() As String
        Get
            Return "obtener_empleados_por_usuario_id"
        End Get
    End Property

    Public Shared ReadOnly Property GUARDAR_RELACION_USUARIO_EMPLEADOS_SP() As String
        Get
            Return "guardar_relacion_usuario_empleados"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_TODOS_LOS_ELEMENTOS_SP() As String
        Get
            Return "obtener_todos_los_elementos"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_TODOS_LOS_EMPLEADOS_SP() As String
        Get
            Return "obtener_todos_los_empleados"
        End Get
    End Property


    Public Shared ReadOnly Property GUARDAR_USUARIO_SP() As String
        Get
            Return "crear_usuario"
        End Get
    End Property

    Public Shared ReadOnly Property GUARDAR_IDIOMA_SP() As String
        Get
            Return "guardar_idioma"
        End Get
    End Property

    Public Shared ReadOnly Property GUARDAR_RELACION_ELEMENTO_IDIOMA_SP() As String
        Get
            Return "guardar_elemento_de_idioma"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_RELACIONES_ELEMENTO_IDIOMA_POR_IDIOMA_SP() As String
        Get
            Return "obtener_elementos_de_idioma_por_idioma"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_TODOS_LOS_IDIOMAS_SP() As String
        Get
            Return "obtener_todos_los_idiomas"
        End Get
    End Property

    Public Shared ReadOnly Property CREAR_EMPLEADO_SP() As String
        Get
            Return "crear_empleado"
        End Get
    End Property

    Public Shared ReadOnly Property ACTUALIZAR_EMPLEADO_SP() As String
        Get
            Return "actualizar_empleado"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_PROXIMO_NRO_EMPLEADO_SP() As String
        Get
            Return "obtener_proximo_nro_empleado"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_TODOS_LOS_PUESTOS_SP() As String
        Get
            Return "obtener_todos_los_puestos"
        End Get
    End Property

    Public Shared ReadOnly Property CREAR_PUESTO_SP() As String
        Get
            Return "crear_puesto_empleado"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_TODOS_LOS_TIPOS_DE_DOCUMENTO_SP() As String
        Get
            Return "obtener_todos_los_tipos_de_docuemento"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_TODOS_LOS_PAISES_SP() As String
        Get
            Return "obtener_todos_los_paises_sp"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_TODAS_LAS_PROVINCIAS_POR_PAIS_SP() As String
        Get
            Return "obtener_provincias_por_pais_id"
        End Get
    End Property

    Public Shared ReadOnly Property OBTENER_TODAS_LAS_LOCALIDADES_POR_PROVINCIA_SP() As String
        Get
            Return "obtener_localidades_por_provincia_id"
        End Get
    End Property

End Class

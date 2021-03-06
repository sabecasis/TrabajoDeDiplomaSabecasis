USE [stock_db]
GO
/****** Object:  StoredProcedure [dbo].[aceptar_pedido_de_reposicion]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[aceptar_pedido_de_reposicion] 
	@pedido_id numeric(18,0),
	@empleado_id numeric(18,0),
	@estado bit
AS
BEGIN
	update pedido_de_reposicion set flag_completado=@estado, empleado_id=@empleado_id where pedido_id=@pedido_id;
END


GO
/****** Object:  StoredProcedure [dbo].[actualizar_comprobante_pedido_de_reposicion]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[actualizar_comprobante_pedido_de_reposicion]
	@pedido_id numeric(18,0),
	@comprobante varbinary(MAX)
AS
BEGIN
	update pedido_de_reposicion set comprobante=@comprobante where pedido_id=@pedido_id;
END


GO
/****** Object:  StoredProcedure [dbo].[actualizar_contacto]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[actualizar_contacto]
	-- Add the parameters for the stored procedure here
	@calle varchar(100), 
	@nro_puerta varchar(10),
	@piso integer=null,
	@departamento varchar(4)=null,
	@localidad_id numeric(18,0),
	@email varchar(200),
	@telefonos varchar(2000),
	@ids_tipo_telefono varchar(2000),
	@id_contacto numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	update contacto set calle=@calle, nro_puerta = @nro_puerta, piso =@piso, departamento =@departamento, localidad_id =@localidad_id, email = @email where contacto_id=@id_contacto;
	 
END


GO
/****** Object:  StoredProcedure [dbo].[actualizar_deposito]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[actualizar_deposito]
	@nombre_deposito varchar(50),
	@calle varchar(100),
	@nro_puerta varchar(10),
	@piso int,
	@departamento varchar(4),
	@localidad_id numeric(18,0),
	@email varchar(200),
	@telefono varchar(30),
	@deposito_id numeric(18,0)
AS
BEGIN
	declare @contacto_id numeric(18,0);
	declare @telefonos varchar(2000) = @telefono + ',';
	declare @telefonos_ids varchar(2000) = '1,';

	select @contacto_id=contacto_id from deposito where deposito_id=@deposito_id;
	exec actualizar_contacto @calle, @nro_puerta, @piso, @departamento, @localidad_id, @email, @telefonos, @telefonos_ids, @contacto_id;
	 
	 update deposito set nombre_deposito = @nombre_deposito where deposito_id=@deposito_id;
END


GO
/****** Object:  StoredProcedure [dbo].[actualizar_descuento]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[actualizar_descuento]
	@nombre varchar(50),
	@descripcion varchar(400),
	@porcentaje numeric(18,2),
	@monto numeric(18,2),
	@descuento_id numeric(18,0)
AS
BEGIN
	update descuento set nombre_descuento=@nombre, porcentaje=@porcentaje, monto=@monto, descripcion_descuento=@descripcion where descuento_id=@descuento_id;
END


GO
/****** Object:  StoredProcedure [dbo].[actualizar_egreso_stock]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[actualizar_egreso_stock] 
	@egreso_id numeric(18,0),
	@fecha date,
	@motivo varchar(300),
	@empleado_id numeric(18,0)
AS
BEGIN
	update egreso_de_stock set fecha=@fecha, motivo= @motivo, empleado_id=@empleado_id where egreso_id=@egreso_id;
END


GO
/****** Object:  StoredProcedure [dbo].[actualizar_empleado]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[actualizar_empleado] 
	-- Add the parameters for the stored procedure here
	@calle varchar(100), 
	@nro_puerta varchar(10),
	@piso integer=null,
	@departamento varchar(4)=null,
	@localidad_id numeric(18,0),
	@email varchar(200),
	@telefonos varchar(2000),
	@ids_tipo_telefono varchar(2000),
	@id_empleado numeric(18,0) OUTPUT, 
	@nro_empleado varchar(50),
	@puesto_empleado_id numeric(18,0),
	@nombre varchar(100),
	@apellido varchar(100),
	@nro_documento varchar(50),
	@tipo_documento_id numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	begin transaction

	declare @contacto_id numeric(18,0);
	declare @persona_id numeric(18,0);
	
	select @persona_id= persona_id  from empleado where empleado_id=@id_empleado;
	select @contacto_id = contacto_id from persona where persona_id = @persona_id;

	exec actualizar_contacto @calle, @nro_puerta, @piso, @departamento, @localidad_id, @email, @telefonos, @ids_tipo_telefono, @contacto_id;
	exec actualizar_persona @nombre, @apellido, @nro_documento, @tipo_documento_id, @contacto_id, @persona_id;

	update empleado set puesto_empleado_id=@puesto_empleado_id, nro_empleado=@nro_empleado where empleado_id=@id_empleado;

	commit transaction;
END


GO
/****** Object:  StoredProcedure [dbo].[actualizar_factura_proveedor]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[actualizar_factura_proveedor] 
	@proveedor_id numeric(18,0),
	@ingeso_id numeric(18,0),
	@factura varbinary(MAX),
	@extension_archivo varchar(6)
AS
BEGIN
	update facturas_de_proveedor set factura=@factura, extension_archivo=@extension_archivo where ingreso_id=@ingeso_id;
END


GO
/****** Object:  StoredProcedure [dbo].[actualizar_familia_de_producto]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[actualizar_familia_de_producto]
	@familia_id numeric(18,0),
	@familia varchar(100)
AS
BEGIN
	update familia_de_producto set familia=@familia where familia_id=@familia;
END


GO
/****** Object:  StoredProcedure [dbo].[actualizar_grupo]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[actualizar_grupo]
	@nombre varchar(200),
	@id_grupo numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	update usuario_grupo set nombre_usuario=@nombre where usuario_id=@id_grupo;
END


GO
/****** Object:  StoredProcedure [dbo].[actualizar_ingreso_stock]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[actualizar_ingreso_stock]
	@fecha date,
	@deposito_id numeric(18,0),
	@ingreso_id numeric(18,0)
AS
BEGIN
	update Ingreso_de_stock set fecha_ingreso=@fecha,  deposito_id=@deposito_id where ingreso_id=@ingreso_id;
END


GO
/****** Object:  StoredProcedure [dbo].[actualizar_instancia_de_producto]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[actualizar_instancia_de_producto]
	@deposito_id numeric(18,0),
	@estado_inst_producto_id numeric(18,0),
	@precio_compra numeric(18,2),
	@precio_venta numeric(18,2),
	@fecha_ultima_modificacion date,
	@motivo_modificacion varchar(300),
	@egreso_id numeric(18,0),
	@inst_prod_id numeric(18,0)
AS
BEGIN
	update instancia_producto set deposito_id=@deposito_id, estado_inst_prod_id=@estado_inst_producto_id, precio_compra=@precio_compra, precio_venta=@precio_venta, fecha_ultima_modificacion=@fecha_ultima_modificacion, motivo_modificacion=@motivo_modificacion, egreso_id=@egreso_id where instancia_producto_id=@inst_prod_id;
END


GO
/****** Object:  StoredProcedure [dbo].[actualizar_marca]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[actualizar_marca]
	@marca_id numeric(18,0),
	@marca varchar(50)
as
BEGIN
	
	update marca set marca=@marca where marca_id=@marca_id;
END


GO
/****** Object:  StoredProcedure [dbo].[actualizar_moneda]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[actualizar_moneda]
	@moneda_id numeric(18,0),
	@moneda varchar(50)
AS
BEGIN
	update moneda set moneda=@moneda where moneda_id=@moneda_id;
END


GO
/****** Object:  StoredProcedure [dbo].[actualizar_movimiento_de_stock]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[actualizar_movimiento_de_stock]
	@movimiento_id numeric(18,0),
	@fecha date,
	@deposito_dest_id numeric(18,0),
	@fecha_aceptacion date,
	@motivo varchar(200),
	@empleado_id numeric(18,0)
AS
BEGIN
	update movimiento_de_stock set motivo=@motivo, fecha=@fecha, fecha_aceptacion=@fecha_aceptacion, deposito_destino_id = @deposito_dest_id, empleado_id=@empleado_id where movimiento_id=@movimiento_id;
END


GO
/****** Object:  StoredProcedure [dbo].[actualizar_pedido_de_reposicion]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[actualizar_pedido_de_reposicion]
	@fecha date,
	@producto_id numeric(18,0),
	@deposito_id numeric(18,0),
	@cantidad int,
	@pedido_id numeric(18,0),
	@empleado_id numeric(18,0)
AS
BEGIN
	update pedido_de_reposicion set fecha=@fecha, producto_id=@producto_id, deposito_id=@deposito_id, cantidad=@cantidad, empleado_id=@empleado_id where pedido_id=@pedido_id;
END


GO
/****** Object:  StoredProcedure [dbo].[actualizar_persona]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[actualizar_persona]
	@nombre varchar(100),
	@apellido varchar(100),
	@nro_documento varchar(50),
	@tipo_documento_id numeric(18,0),
	@contacto_id numeric(18,0),
	@id_persona numeric(18,0) OUTPUT
As
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	update persona set nombre = @nombre, apellido = @apellido, nro_documento =@nro_documento, tipo_documento_id = @tipo_documento_id, contacto_id =@contacto_id where persona_id=@id_persona;
END


GO
/****** Object:  StoredProcedure [dbo].[actualizar_producto]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[actualizar_producto]
	@nombre varchar(200),
	@descripcion varchar(500),
	@precio_venta numeric(18,2),
	@precio_compra numeric(18,2),
	@moneda_id numeric(18,0),
	@estado_id numeric(18,0),
	@marca_id numeric(18,0),
	@clasificacion_id numeric(18,0),
	@regla_de_composicion varchar(1000),
	@porcentaje_de_ganancia decimal,
	@metodo_de_valoracion_id numeric(18,0),
	@precio_coste_adquisicion numeric(18,2),
	@coste_de_posesion numeric(18,2),
	@coste_financiero numeric(18,2),
	@producto_id numeric(18,0),
	@descuento_global_id numeric(18,0),
	@precio_ultima_compra numeric(18,2),
	@stock_minimo int,
	@stock_maximo int,
	@ciclo int,
	@metodo_de_reposicion_id numeric(8,0),
	@familia_id numeric(18,0),
	@unidad varchar(10),
	@pedido_automatico bit
AS
BEGIN
	update producto set nombre_producto=@nombre, descripcion_producto=@descripcion, precio_compra =@precio_compra, precio_venta=@precio_venta, 
	moneda_id =@moneda_id, estado_producto_id=@estado_id, marca_id=@marca_id, clasificacion_id=@clasificacion_id, regla_de_composicion=@regla_de_composicion,
	porcentaje_de_ganancia=@porcentaje_de_ganancia, metodo_valoracion_id = @metodo_de_valoracion_id, precio_coste_adquisicion =@precio_coste_adquisicion,
	coste_posesion=@coste_de_posesion, coste_financiero = @coste_financiero, descuento_global_id=@descuento_global_id, precio_ultima_compra=@precio_ultima_compra, 
	metodo_de_reposicion_id=@metodo_de_reposicion_id, punto_de_reposicion_minimo=@stock_minimo, punto_de_reposicion_maximo=@stock_maximo, ciclo=@ciclo, familia_de_producto_id=@familia_id, unidad=@unidad, pedido_automatico=@pedido_automatico
	where producto_id=@producto_id;
END


GO
/****** Object:  StoredProcedure [dbo].[actualizar_proveedor]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[actualizar_proveedor]
	@calle varchar(100),
@nro_puerta varchar(10),
            @piso int, 
            @departamento varchar(4), 
            @localidad_id numeric(18,0), 
            @email varchar(200), 
            @telefonos varchar(30), 
            @nombre varchar(100), 
            @cuit varchar(100),
			@estado_id numeric(18,0),
			@proveedor_id numeric(18,0)
AS
BEGIN
	declare @id_contacto numeric(18,0);
	declare @telefon as varchar(2000) = @telefonos +',';
	declare @id_tel as varchar(2000) ='1,';

	select @id_contacto=contacto_id from proveedor where proveedor.proveedor_id=@proveedor_id;
	
	exec actualizar_contacto @calle, @nro_puerta, @piso, @departamento, @localidad_id, @email, @telefon, @id_tel, @id_contacto ;

	update proveedor set proveedor_nombre =@nombre, proveedor_estado_id = @estado_id, cuit=@cuit;
END


GO
/****** Object:  StoredProcedure [dbo].[actualizar_rol]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[actualizar_rol]
	@nombre varchar(30),
	@descripcion varchar(300),
	@id_modulo numeric(18,0),
	@id_rol numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	update rol set rol=@nombre, rol_descripcion=@descripcion, modulo_id=@id_modulo where rol_id=@id_rol;
END


GO
/****** Object:  StoredProcedure [dbo].[actualizar_sucursal]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[actualizar_sucursal] 
	@estado_sucursal_id int,
	@horario_inicio_actividad varchar(5),
	@horario_cierre_actividad varchar(5),
	@fecha_apertura date,
	@fecha_cierre date,
	@calle varchar(100), 
	@nro_puerta varchar(10),
	@piso integer=null,
	@departamento varchar(4)=null,
	@localidad_id numeric(18,0),
	@email varchar(200),
	@telefono varchar(30),
	@id_sucursal numeric(18,0)
AS
BEGIN
	declare @telefonos varchar(2000)=@telefono+',';
	declare @id_tel varchar(2000) ='1,';
	declare @contacto_id numeric(18,0);

	select @contacto_id = c.contacto_id from contacto c, sucursal s where c.contacto_id=s.contacto_id  and s.sucursal_id=@id_sucursal;

	exec actualizar_contacto @calle, @nro_puerta, @piso, @departamento, @localidad_id, @email, @telefonos, @id_tel, @contacto_id;

	update sucursal set estado_sucursal_id = @estado_sucursal_id, horario_inicio_actividad=@horario_inicio_actividad, horario_cierre_actividad=@horario_cierre_actividad, fecha_apertura=@fecha_apertura, fecha_cierre=@fecha_cierre;

END


GO
/****** Object:  StoredProcedure [dbo].[actualizar_usuario]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[actualizar_usuario]
	@usuario_nombre varchar(200),
	@pregunta varchar(200),
	@respuesta varchar(200),
	@bloqueado bit,
	@contador integer,
	@usuario_id numeric(18,0),
	@password varchar(200),
	@cambiar_password bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    update usuario_grupo set nombre_usuario=@usuario_nombre, pregunta_secreta=@pregunta, respuesta_secreta=@respuesta, bloqueado=@bloqueado, contador_mala_password=@contador where usuario_id=@usuario_id;

	if (@cambiar_password=1)
	begin
		update usuario_grupo set password=@password where usuario_id=@usuario_id;
	end;

END


GO
/****** Object:  StoredProcedure [dbo].[buscar_deposito]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[buscar_deposito]
	@nombre_deposito varchar(50),
	@deposito_id numeric(18,0)
AS
BEGIN
	if(@deposito_id<>0)
	begin
		select d.deposito_id, d.nombre_deposito, c.contacto_id, c.calle, c.nro_puerta, c.departamento, c.piso, c.localidad_id, c.email, t.telefono, t.tipo_telefono_id  from deposito d inner join contacto c on d.contacto_id=c.contacto_id and deposito_id=@deposito_id left join  telefono_contacto_xref tc on tc.contacto_id= c.contacto_id left join telefono t on tc.telefono_id=t.telefono_id;
	end;
	else 
	begin
		select d.deposito_id, d.nombre_deposito, c.contacto_id, c.calle, c.nro_puerta, c.departamento, c.piso, c.localidad_id, c.email, t.telefono, t.tipo_telefono_id  from deposito d inner join contacto c on d.contacto_id=c.contacto_id and d.nombre_deposito=@nombre_deposito left join  telefono_contacto_xref tc on tc.contacto_id= c.contacto_id left join telefono t on tc.telefono_id=t.telefono_id;
	end;
END


GO
/****** Object:  StoredProcedure [dbo].[buscar_ingreso_stock]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[buscar_ingreso_stock]
	@ingreso_id numeric(18,0),
	@fecha date,
	@producto_id numeric(18,0),
	@deposito_id numeric(18,0)
AS
BEGIN
	if(@ingreso_id<>0)
	begin
		select i.ingreso_id, i.fecha_ingreso, fp.factura, i.empleado_id, i.deposito_id, i.comprobante_de_ingreso, i.producto_id, fp.proveedor_id, fp.extension_archivo, i.pedido_de_reposicion_id  from ingreso_de_stock i, facturas_de_proveedor fp where i.ingreso_id=@ingreso_id and fp.ingreso_id=i.ingreso_id;
	end;
	else if (@fecha is not null and @producto_id is not null and @deposito_id is not null)
	begin
	select i.ingreso_id, i.fecha_ingreso, fp.factura, i.empleado_id, i.deposito_id, i.comprobante_de_ingreso, i.producto_id, fp.proveedor_id, fp.extension_archivo, i.pedido_de_reposicion_id  from ingreso_de_stock i, facturas_de_proveedor fp where i.fecha_ingreso=@fecha and i.producto_id=@producto_id and i.deposito_id=@deposito_id and fp.ingreso_id=i.ingreso_id;
	end;
END


GO
/****** Object:  StoredProcedure [dbo].[buscar_marca]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[buscar_marca]
	@marca_id numeric(18,0),
	@marca varchar(50)
AS
BEGIN
	
	if (@marca_id<>0)
	begin
		select marca_id, marca from marca where marca_id=@marca_id; 
	end;

	else if (@marca is not null and @marca <>'')
	begin
		select marca_id, marca from marca where marca=@marca;
	end;

END


GO
/****** Object:  StoredProcedure [dbo].[buscar_moneda]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[buscar_moneda]
	@moneda_id numeric(18,0),
	@moneda varchar(50)
AS
BEGIN
	if (@moneda_id <>0)
	begin
		select moneda_id, moneda from moneda where moneda_id=@moneda_id;
	end;
	else if (@moneda is not null and @moneda <>'')
	begin
		select moneda_id, moneda from moneda where moneda = @moneda; 
	end;
END


GO
/****** Object:  StoredProcedure [dbo].[buscar_producto]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[buscar_producto]
	@producto_id numeric(18,0),
	@nombre varchar(500)
AS
BEGIN
if (@producto_id<>0)
begin
	select producto_id, nombre_producto, descripcion_producto, precio_compra, precio_venta, clasificacion_id, coste_posesion, 
	coste_financiero, descuento_global_id, estado_producto_id, marca_id, metodo_valoracion_id, moneda_id, porcentaje_de_ganancia, precio_coste_adquisicion, 
	regla_de_composicion, precio_ultima_compra, metodo_de_reposicion_id, punto_de_reposicion_minimo, punto_de_reposicion_maximo, ciclo, familia_de_producto_id, unidad, pedido_automatico from producto where producto_id=@producto_id;
	end;
	else if(@nombre is not null and @nombre<>'')
	begin
		select producto_id, nombre_producto, descripcion_producto, precio_compra, precio_venta, clasificacion_id, coste_posesion, 
	coste_financiero, descuento_global_id, estado_producto_id, marca_id, metodo_valoracion_id, moneda_id, porcentaje_de_ganancia, precio_coste_adquisicion, 
	regla_de_composicion, precio_ultima_compra, metodo_de_reposicion_id, punto_de_reposicion_minimo, punto_de_reposicion_maximo, ciclo, familia_de_producto_id, unidad, pedido_automatico from producto where nombre_producto=@nombre;
	end;
END


GO
/****** Object:  StoredProcedure [dbo].[buscar_proveedor]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[buscar_proveedor]
	@proveedor_id numeric(18,0),
	@cuit varchar(20),
	@nombre varchar(100)
AS
BEGIN
	if (@proveedor_id<>0 ) 
	begin
		select p.proveedor_id, p.proveedor_nombre, c.contacto_id, c.calle, c.nro_puerta, c.departamento, c.piso, c.localidad_id, c.email, t.telefono, p.cuit, p.proveedor_estado_id from proveedor p inner join contacto c on p.contacto_id = c.contacto_id and p.proveedor_id=@proveedor_id left join telefono_contacto_xref tc on tc.contacto_id=c.contacto_id left join telefono t on tc.telefono_id=t.telefono_id;
	end;
	else if (@cuit is not null and @cuit<>'')
	begin
		select p.proveedor_id, p.proveedor_nombre, c.contacto_id, c.calle, c.nro_puerta, c.departamento, c.piso, c.localidad_id, c.email, t.telefono, p.cuit, p.proveedor_estado_id from proveedor p inner join contacto c on p.contacto_id = c.contacto_id and p.cuit=@cuit left join telefono_contacto_xref tc on tc.contacto_id=c.contacto_id left join telefono t on tc.telefono_id=t.telefono_id;
	end;
	else if (@nombre is not null and @nombre<>'')
	begin
		select p.proveedor_id, p.proveedor_nombre, c.contacto_id, c.calle, c.nro_puerta, c.departamento, c.piso, c.localidad_id, c.email, t.telefono, p.cuit, p.proveedor_estado_id from proveedor p inner join contacto c on p.contacto_id = c.contacto_id and p.proveedor_nombre=@nombre left join telefono_contacto_xref tc on tc.contacto_id=c.contacto_id left join telefono t on tc.telefono_id=t.telefono_id;
	end;
END


GO
/****** Object:  StoredProcedure [dbo].[buscar_sucursal]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[buscar_sucursal]
	@sucursal_id numeric(18,0)
AS
BEGIN
	select s.sucursal_id, s.estado_sucursal_id, c.contacto_id, c.calle, c.nro_puerta, c.departamento, c.piso, c.localidad_id, c.email, t.telefono, t.tipo_telefono_id, s.fecha_apertura, s.fecha_cierre, s.horario_inicio_actividad, s.horario_cierre_actividad from sucursal s inner join contacto c on s.sucursal_id=@sucursal_id and s.contacto_id=c.contacto_id left join  telefono_contacto_xref tc  on tc.contacto_id=c.contacto_id left join  telefono t on  t.telefono_id=tc.telefono_id;
END


GO
/****** Object:  StoredProcedure [dbo].[checkear_verificador_vetical_rol]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[checkear_verificador_vetical_rol] 
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	declare @suma numeric(25,0);
	declare @verificador numeric(25,0);
	select @suma=sum(verificador_horizontal) from rol;
	select @verificador=verificador from verificador_vertical where entidad='Rol';

	set @suma=@suma+3
	if @suma=@verificador or @suma is null
		select 1;
	else
		select 0;

END


GO
/****** Object:  StoredProcedure [dbo].[checkear_verificador_vetical_usuario]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[checkear_verificador_vetical_usuario] 
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	declare @suma numeric(25,0);
	declare @verificador numeric(25,0);
	select @suma=sum(verificador_horizontal) from usuario_grupo;
	select @verificador=verificador from verificador_vertical where entidad='Usuario';

	set @suma=@suma+7
	if @suma=@verificador or @suma is null
		select 1;
	else
		select 0;

END


GO
/****** Object:  StoredProcedure [dbo].[consultar_log_de_errores]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[consultar_log_de_errores] 
	@fecha as varchar(20),
	@id_error as numeric(18,0),
	@tipo_excepcion_id numeric(18,0),
	@query varchar(300),
	@clase varchar(300)
AS
BEGIN
	declare @querystring nvarchar(Max);
	declare @parametros nvarchar(Max);
	set @parametros='@fecha Datetime, @id_error numeric(18,0), @tipo_excepcion_id numeric(18,0), @query varchar(300), @clase varchar(300)';
	set @querystring='select e.error_id, e.fecha_y_hora, e.mensaje_error, e.excepcion, te.tipo_excepcion_id, te.tipo_excepcion, e.clase, e.accion, e.query from log_de_errores e inner join tipo_excepcion te on te.tipo_excepcion_id=e.tipo_exepcion_id '
	
	if(@tipo_excepcion_id <> 0)
	begin
		set @querystring=@querystring + ' and te.tipo_excepcion_id=@tipo_excepcion_id ';	
	end;

	if(@id_error <> 0)
	begin
		set @querystring = @querystring + ' and e.error_id=@id_error';
	end;

	if(@query <> '')
	begin
		set @querystring = @querystring + ' and e.query=@query';
	end;

	if(@clase <> '')
	begin
		set @querystring = @querystring + ' and e.clase=@clase';
	end;

	if(@fecha <> '')
	begin
		set @querystring = @querystring + ' and e.fecha_y_hora like ''' + @fecha + '%''';
	end;

	set @querystring = @querystring + ' order by e.error_id desc ';

	execute sp_executesql @querystring, @parametros, @fecha, @id_error, @tipo_excepcion_id, @query, @clase;

	
END


GO
/****** Object:  StoredProcedure [dbo].[crear_contacto]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[crear_contacto]
	-- Add the parameters for the stored procedure here
	@calle varchar(100), 
	@nro_puerta varchar(10),
	@piso integer=null,
	@departamento varchar(4)=null,
	@localidad_id numeric(18,0),
	@email varchar(200),
	@telefonos varchar(2000),
	@ids_tipo_telefono varchar(2000),
	@id_contacto numeric(18,0) OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	Begin transaction
	insert into contacto (calle, nro_puerta, piso, departamento, localidad_id, email) values (@calle, @nro_puerta, @piso, @departamento, @localidad_id, @email);
	select @id_contacto= contacto_id from contacto where calle=@calle and nro_puerta=@nro_puerta and piso=@piso and departamento=@departamento and localidad_id=@localidad_id and email=@email;
	DECLARE @posicion_telefono integer;
	DECLARE @posicion_id_tipo_telefono integer;
	DECLARE @telefono varchar(30);
	DECLARE @id_tipo_telefono varchar(30);
	DECLARE @ids_de_telefonos varchar(2000);
	declare @id_telefono numeric(18,0);
	declare @posicion_id_telefono integer;

	WHILE patindex('%,%' , @telefonos) <> 0
	BEGIN
		SELECT @posicion_telefono =  patindex('%,%' , @telefonos);
		SELECT @posicion_id_tipo_telefono =  patindex('%,%' , @ids_tipo_telefono);
		SELECT @telefono = left(@telefonos, @posicion_telefono - 1);
		SELECT @id_tipo_telefono = left(@ids_tipo_telefono, @posicion_id_tipo_telefono - 1);
		INSERT INTO telefono (telefono, tipo_telefono_id) values (@telefono, cast(@id_tipo_telefono as numeric(18,0)));
		select @id_telefono=telefono_id from telefono where telefono=@telefono and @id_tipo_telefono=cast(@id_tipo_telefono as numeric(18,0));
		insert into telefono_contacto_xref (telefono_id, contacto_id) values (@id_telefono, @id_contacto);
		
		SELECT @telefonos = stuff(@telefonos, 1, @posicion_telefono, '');
		SELECT @ids_tipo_telefono = stuff(@ids_tipo_telefono, 1, @posicion_id_tipo_telefono, '');
	End;

	Commit transaction;
  
END


GO
/****** Object:  StoredProcedure [dbo].[crear_deposito]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[crear_deposito]
	@nombre_deposito varchar(50),
	@calle varchar(100),
	@nro_puerta varchar(10),
	@piso int,
	@departamento varchar(4),
	@localidad_id numeric(18,0),
	@email varchar(200),
	@telefono varchar(30)
AS
BEGIN
	declare @ids_tipo_tel varchar(2000) ='1,';
	declare @telefonos varchar(2000) = @telefono + ',';
	declare @id_contacto numeric(18,0);

	exec crear_contacto @calle, @nro_puerta, @piso, @departamento, @localidad_id, @email, @telefonos, @ids_tipo_tel, @id_contacto=@id_contacto output;

	insert into deposito (contacto_id, nombre_deposito)output inserted.deposito_id values(@id_contacto, @nombre_deposito);
END


GO
/****** Object:  StoredProcedure [dbo].[crear_descuento]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[crear_descuento]
	@descuento_nombre varchar(50),
	@descripcion varchar(400),
	@monto numeric(18,2),
	@porcentaje numeric(18,2)
AS
BEGIN
	insert into descuento(nombre_descuento, descripcion_descuento, monto, porcentaje, flag_eliminado) values (@descuento_nombre, @descripcion, @monto, @porcentaje, 0);

END


GO
/****** Object:  StoredProcedure [dbo].[crear_egreso_stock]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[crear_egreso_stock]
	@producto_id numeric(18,0),
	@cantidad int,
	@fecha date,
	@deposito_id numeric(18,0),
	@motivo varchar(300),
	@empleado_id numeric(18,0)
AS
BEGIN
	insert into egreso_de_stock(producto_id, cantidad, fecha, deposito_id, motivo, empleado_id) output inserted.egreso_id values(@producto_id, @cantidad, @fecha, @deposito_id, @motivo, @empleado_id);
END


GO
/****** Object:  StoredProcedure [dbo].[crear_empleado]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[crear_empleado] 
	-- Add the parameters for the stored procedure here
	@calle varchar(100), 
	@nro_puerta varchar(10),
	@piso integer=null,
	@departamento varchar(4)=null,
	@localidad_id numeric(18,0),
	@email varchar(200),
	@telefonos varchar(2000),
	@ids_tipo_telefono varchar(2000),
	@id_empleado numeric(18,0) OUTPUT, 
	@nro_empleado varchar(50),
	@puesto_empleado_id numeric(18,0),
	@nombre varchar(100),
	@apellido varchar(100),
	@nro_documento varchar(50),
	@tipo_documento_id numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	begin transaction

	declare @contacto_id numeric(18,0);
	declare @persona_id numeric(18,0);
	
	exec crear_contacto @calle, @nro_puerta, @piso, @departamento, @localidad_id, @email, @telefonos, @ids_tipo_telefono, @id_contacto=@contacto_id output;
	exec crear_persona @nombre, @apellido, @nro_documento, @tipo_documento_id, @contacto_id, @id_persona=@persona_id output;

	insert into empleado (nro_empleado, persona_id, puesto_empleado_id, flag_eliminado) values (@nro_empleado, @persona_id, @puesto_empleado_id, 0);
	select @id_empleado=empleado_id from empleado where nro_empleado=@nro_empleado and persona_id=@persona_id;

	commit transaction;
	    
END


GO
/****** Object:  StoredProcedure [dbo].[crear_familia_de_productos]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[crear_familia_de_productos]
	@familia varchar(100)
AS
BEGIN
	insert into familia_de_producto(familia) values(@familia);
END


GO
/****** Object:  StoredProcedure [dbo].[crear_ingreso_stock]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[crear_ingreso_stock]
	@fecha date,
	@empleado_id numeric(18,0),
	@cantidad int,
	@producto_id numeric(18,0),
	@deposito_id numeric(18,0),
	@pedido_id numeric(18,0)
AS
BEGIN

insert into ingreso_de_stock(fecha_ingreso, cantidad, empleado_id, producto_id, deposito_id, pedido_de_reposicion_id) OUTPUT INSERTED.ingreso_id values(@fecha, @cantidad,  @empleado_id, @producto_id, @deposito_id, @pedido_id) ;


END


GO
/****** Object:  StoredProcedure [dbo].[crear_instancia_producto]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[crear_instancia_producto]
	@producto_id numeric(18,0),
	@deposito_id numeric(18,0),
	@estado_inst_producto_id numeric(18,0),
	@precio_compra numeric(18,2),
	@precio_venta numeric(18,2),
	@fecha_ultima_modificacion date,
	@motivo_modificacion varchar(200),
	@ingreso_id numeric(18,0)
AS
BEGIN
	insert into instancia_producto(producto_id, estado_inst_prod_id, fecha_ultima_modificacion, ingreso_id, motivo_modificacion, precio_compra, precio_venta, deposito_id) OUTPUT INSERTED.instancia_producto_id
	values (@producto_id, @estado_inst_producto_id, @fecha_ultima_modificacion, @ingreso_id, @motivo_modificacion, @precio_compra, @precio_venta, @deposito_id)

END


GO
/****** Object:  StoredProcedure [dbo].[crear_marca]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[crear_marca]
	@marca varchar(50)
AS
BEGIN
	insert into marca(marca) values(@marca);
END


GO
/****** Object:  StoredProcedure [dbo].[crear_moneda]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[crear_moneda]
	@moneda varchar(50)
AS
BEGIN
	insert into moneda (moneda) values (@moneda);
END


GO
/****** Object:  StoredProcedure [dbo].[crear_pedido_de_reposicion]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[crear_pedido_de_reposicion]
	@fecha date,
	@cantidad int,
	@producto_id numeric(18,0),
	@deposito_id numeric(18,0),
	@empleado_id numeric(18,0)
AS
BEGIN
	insert into pedido_de_reposicion(fecha, cantidad, producto_id, deposito_id, flag_completado,  empleado_id) output inserted.pedido_id values(@fecha, @cantidad, @producto_id, @deposito_id, 0, @empleado_id);
END


GO
/****** Object:  StoredProcedure [dbo].[crear_persona]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[crear_persona]
	@nombre varchar(100),
	@apellido varchar(100),
	@nro_documento varchar(50),
	@tipo_documento_id numeric(18,0),
	@contacto_id numeric(18,0),
	@id_persona numeric(18,0) OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    Begin transaction
		insert into persona (nombre, apellido, nro_documento, tipo_documento_id, contacto_id) values (@nombre, @apellido, @nro_documento, @tipo_documento_id, @contacto_id);
		
	commit transaction;
	select @id_persona= persona_id from Persona where nombre=@nombre and apellido=@apellido and nro_documento=@nro_documento and tipo_documento_id=@tipo_documento_id;
END


GO
/****** Object:  StoredProcedure [dbo].[crear_producto]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[crear_producto]
	@nombre varchar(200),
	@descripcion varchar(500),
	@precio_venta numeric(18,2),
	@precio_compra numeric(18,2),
	@moneda_id numeric(18,0),
	@estado_id numeric(18,0),
	@marca_id numeric(18,0),
	@clasificacion_id numeric(18,0),
	@regla_de_composicion varchar(1000),
	@porcentaje_de_ganancia numeric(18,2),
	@metodo_de_valoracion_id numeric(18,0),
	@precio_coste_adquisicion numeric(18,2),
	@coste_de_posesion numeric(18,2),
	@coste_financiero numeric(18,2),
	@descuento_global_id numeric(18,0),
	@precio_ultima_compra numeric(18,2),
	@metodo_de_reposicion_id numeric(8,0),
	@stock_minimo int,
	@stock_maximo int,
	@ciclo int,
	@familia_id numeric(18,0),
	@unidad varchar(10),
	@pedido_automatico bit
AS
BEGIN
	insert into producto(unidad, familia_de_producto_id, nombre_producto, descripcion_producto, precio_venta, precio_compra, moneda_id, estado_producto_id, marca_id, clasificacion_id, regla_de_composicion, porcentaje_de_ganancia, metodo_valoracion_id, precio_coste_adquisicion, coste_posesion, coste_financiero, descuento_global_id, precio_ultima_compra, metodo_de_reposicion_id, punto_de_reposicion_minimo, punto_de_reposicion_maximo, ciclo, pedido_automatico) output inserted.producto_id
	 values (@unidad, @familia_id, @nombre, @descripcion, @precio_venta, @precio_compra, @moneda_id, @estado_id, @marca_id, @clasificacion_id, @regla_de_composicion, @porcentaje_de_ganancia, @metodo_de_valoracion_id, @precio_coste_adquisicion, @coste_de_posesion, @coste_financiero, @descuento_global_id, @precio_ultima_compra, @metodo_de_reposicion_id, @stock_minimo, @stock_maximo, @ciclo, @pedido_automatico);
END


GO
/****** Object:  StoredProcedure [dbo].[crear_proveedor]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[crear_proveedor]
@calle varchar(100),
@nro_puerta varchar(10),
            @piso int, 
            @departamento varchar(4), 
            @localidad_id numeric(18,0), 
            @email varchar(200), 
            @telefonos varchar(30), 
            @nombre varchar(100), 
            @cuit varchar(100),
			@estado_id numeric(18,0)
AS
BEGIN
	declare @telefonostemp varchar(2000)=@telefonos+',';
	declare @tel_id varchar(2000)= '1,';
	declare @contacto_id numeric(18,0);


	exec crear_contacto @calle, @nro_puerta, @piso, @departamento, @localidad_id, @email, @telefonostemp, @tel_id, @id_contacto=@contacto_id;
	select @contacto_id= contacto_id from contacto where calle=@calle and nro_puerta=@nro_puerta and piso=@piso and departamento=@departamento and localidad_id=@localidad_id and email=@email;
	insert into proveedor (proveedor_nombre, contacto_id, proveedor_estado_id, cuit, flag_eliminado) values(@nombre, @contacto_id, @estado_id, @cuit, 0);

END


GO
/****** Object:  StoredProcedure [dbo].[crear_puesto_empleado]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[crear_puesto_empleado] 
	-- Add the parameters for the stored procedure here
	@puesto varchar(200), 
	@codigo varchar(4)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    insert into puesto_empleado (puesto_empleado, codigo_identificador) values (@puesto, @codigo);
END


GO
/****** Object:  StoredProcedure [dbo].[crear_relacion_sucursal_deposito]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[crear_relacion_sucursal_deposito]
	@id_sucursal numeric(18,0),
	@id_deposito numeric(18,0)
AS
BEGIN
	insert into sucursal_deposito_xref(sucursal_id, deposito_id) values(@id_sucursal, @id_deposito);
END


GO
/****** Object:  StoredProcedure [dbo].[crear_releacion_producto_proveedor]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[crear_releacion_producto_proveedor]
	@producto_id numeric(18,0),
	@proveedor_id numeric(18,0)
AS
BEGIN
	insert into producto_proveedor_xref(producto_id, proveedor_id) values(@producto_id, @proveedor_id);
END


GO
/****** Object:  StoredProcedure [dbo].[crear_sucursal]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[crear_sucursal]
	@estado_sucursal_id int,
	@horario_inicio_actividad varchar(5),
	@horario_cierre_actividad varchar(5),
	@fecha_apertura date,
	@fecha_cierre date,
	@calle varchar(100), 
	@nro_puerta varchar(10),
	@piso integer=null,
	@departamento varchar(4)=null,
	@localidad_id numeric(18,0),
	@email varchar(200),
	@telefono varchar(30)
AS
BEGIN
	declare @telefonos varchar(2000)=@telefono +',';
	declare @id_tel varchar(2000) ='1,';
	declare @contacto_id numeric(18,0);

	exec crear_contacto  @calle, @nro_puerta, @piso, @departamento, @localidad_id, @email, @telefonos, @id_tel, @id_contacto=@contacto_id output;

	insert into sucursal(fecha_apertura, fecha_cierre, horario_inicio_actividad, horario_cierre_actividad, estado_sucursal_id, contacto_id) values (@fecha_apertura, @fecha_cierre, @horario_inicio_actividad, @horario_cierre_actividad, @estado_sucursal_id, @contacto_id);

	select sucursal_id from sucursal where fecha_apertura=@fecha_apertura and fecha_cierre=@fecha_cierre and horario_inicio_actividad=@horario_inicio_actividad and horario_cierre_actividad=@horario_cierre_actividad and contacto_id=@contacto_id;
END


GO
/****** Object:  StoredProcedure [dbo].[crear_usuario]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[crear_usuario]
	@usuario_nombre as varchar(200),
	@password as varchar(200),
	@pregunta as varchar(200),
	@respuesta as varchar(200),
	@usuario_id as numeric(18,0) out
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    insert into usuario_grupo (nombre_usuario, password, contador_mala_password, bloqueado, pregunta_secreta, respuesta_secreta, flag_eliminado)
	values (@usuario_nombre, @password, 0, 0, @pregunta, @respuesta,0);
	select @usuario_id = usuario_id from usuario_grupo where nombre_usuario=@usuario_nombre and password=@password and pregunta_secreta=@pregunta and respuesta_secreta=@respuesta;
END

GO
/****** Object:  StoredProcedure [dbo].[db_backup]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[db_backup]
  @folder varchar(255),
  @file varchar(255)
  AS
  SET NOCOUNT ON 
  
  declare @Destination varchar(255)
 
 if (@file = '' or @file is NULL)
 begin
  SET @File = convert( varchar(10), getdate(), 108 ) + '.stock_db.bak'
 end;

  SET @Destination = @folder + '\' + @File

  BACKUP DATABASE stock_db TO  DISK = @Destination


GO
/****** Object:  StoredProcedure [dbo].[eiminar_usuario_empleado_xref]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[eiminar_usuario_empleado_xref]
	@id_usuario numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	delete from usuario_empleado_xref where usuario_id=@id_usuario;

END


GO
/****** Object:  StoredProcedure [dbo].[eliminar_deposito]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[eliminar_deposito] 
@deposito_id numeric(18,0)
AS
BEGIN
	delete from deposito where deposito_id = @deposito_id;
END


GO
/****** Object:  StoredProcedure [dbo].[eliminar_descuento]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[eliminar_descuento]
	@id numeric(18,0)
AS
BEGIN
	update descuento set flag_eliminado=1 where descuento_id=@id;
END


GO
/****** Object:  StoredProcedure [dbo].[eliminar_egreso_stock]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[eliminar_egreso_stock]
	@egreso_id numeric(18,0)
AS
BEGIN
	delete from egreso_de_stock where egreso_id=@egreso_id;
END


GO
/****** Object:  StoredProcedure [dbo].[eliminar_empleado]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[eliminar_empleado] 
	@id_empleado numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	update empleado set flag_eliminado=1 where empleado_id=@id_empleado;
	 
END


GO
/****** Object:  StoredProcedure [dbo].[eliminar_familia_de_productos_sp]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[eliminar_familia_de_productos_sp]
	@familia_id numeric(18,0)
AS
BEGIN
	delete from familia_de_producto where familia_id=@familia_id;
END


GO
/****** Object:  StoredProcedure [dbo].[eliminar_idioma]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[eliminar_idioma] 
	@idioma_id numeric(18,0)
AS
BEGIN
	delete from elementos_de_Idioma where idioma_id=@idioma_id;
	delete from Idioma where idioma_id=@idioma_id;
END

GO
/****** Object:  StoredProcedure [dbo].[eliminar_ingreso_stock]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[eliminar_ingreso_stock]
	@ingreso_id numeric(18,0)
AS
BEGIN
	delete from instancia_producto where ingreso_id=@ingreso_id;
	delete from facturas_de_proveedor where ingreso_id = @ingreso_id;
	delete from Ingreso_de_stock where ingreso_id=@ingreso_id;

END


GO
/****** Object:  StoredProcedure [dbo].[eliminar_marca]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[eliminar_marca]
	@marca_id numeric(18,0)
AS
BEGIN

delete from marca where marca_id=@marca_id;
END


GO
/****** Object:  StoredProcedure [dbo].[eliminar_moneda]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[eliminar_moneda]
	@moneda_id numeric(18,0)
AS
BEGIN
	delete from moneda where moneda_id=@moneda_id;
END


GO
/****** Object:  StoredProcedure [dbo].[eliminar_movimiento_de_stock]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[eliminar_movimiento_de_stock]
	@movimiento_id as numeric(18,0)
AS
BEGIN
	delete from movimiento_de_stock_instancia_de_producto_xref where movimiento_id=@movimiento_id;
	delete from movimiento_de_stock where movimiento_id=@movimiento_id;
END


GO
/****** Object:  StoredProcedure [dbo].[eliminar_pedido_de_reposicion]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[eliminar_pedido_de_reposicion] 
	@pedido_id numeric(18,0)
AS
BEGIN
	delete from pedido_de_reposicion where pedido_id=@pedido_id;
END


GO
/****** Object:  StoredProcedure [dbo].[eliminar_permisos_de_rol]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[eliminar_permisos_de_rol]
	@id_rol numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    delete from permiso_rol_xref where rol_id=@id_rol;
END


GO
/****** Object:  StoredProcedure [dbo].[eliminar_producto]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[eliminar_producto] 
	@producto_id numeric(18,0)
AS
BEGIN
	delete from producto_proveedor_xref where producto_id=@producto_id;
	delete from producto where producto_id=@producto_id;
END


GO
/****** Object:  StoredProcedure [dbo].[eliminar_proveedor]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[eliminar_proveedor]
	@proveedor_id numeric(18,0)
AS
BEGIN
	update proveedor set flag_eliminado=1 where proveedor_id=@proveedor_id;
	
END


GO
/****** Object:  StoredProcedure [dbo].[eliminar_relacion_producto_proveedor]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[eliminar_relacion_producto_proveedor]
	@producto_id numeric(18,0)
AS
BEGIN
	delete from producto_proveedor_xref where producto_id=@producto_id;
END


GO
/****** Object:  StoredProcedure [dbo].[eliminar_relacion_sucursal_deposito]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[eliminar_relacion_sucursal_deposito]
	@id_sucursal numeric(18,0)
AS
BEGIN
	delete from sucursal_deposito_xref where sucursal_id = @id_sucursal;
END


GO
/****** Object:  StoredProcedure [dbo].[eliminar_rol]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[eliminar_rol] 
	@id_rol numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	delete from rol where rol_id=@id_rol;
END


GO
/****** Object:  StoredProcedure [dbo].[eliminar_roles_de_grupo]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[eliminar_roles_de_grupo]
	@id_rol  numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   delete from grupo_rol_xref where rol_id=@id_rol;
END


GO
/****** Object:  StoredProcedure [dbo].[eliminar_sucursal]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[eliminar_sucursal]
	@sucursal_id numeric(18,0)
AS
BEGIN
	declare @contato_id numeric(18,0);
	select @contato_id=contacto_id from sucursal where sucursal_id=@sucursal_id;

	delete from sucursal_deposito_xref where sucursal_id=@sucursal_id;
	delete from telefono_contacto_xref where contacto_id = @contato_id;
	delete from sucursal where sucursal_id=@sucursal_id;
	delete from contacto where contacto_id=@contato_id;
	
END


GO
/****** Object:  StoredProcedure [dbo].[eliminar_todos_los_depositos_por_empleado]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[eliminar_todos_los_depositos_por_empleado]
	@empleado_id numeric(18,0)
AS
BEGIN
	delete from empleado_deposito_xref where empleado_id=@empleado_id;
END


GO
/****** Object:  StoredProcedure [dbo].[eliminar_todos_los_grupos_por_usuario_id]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[eliminar_todos_los_grupos_por_usuario_id] 
	@usuario_id numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	delete from usuario_grupo_xref where grupo_id=@usuario_id;
END


GO
/****** Object:  StoredProcedure [dbo].[eliminar_usuario]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[eliminar_usuario] 
	@id_usuario numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	update usuario_grupo set flag_eliminado=1 where usuario_id=@id_usuario;
END


GO
/****** Object:  StoredProcedure [dbo].[filtrar_instancias_de_producto]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[filtrar_instancias_de_producto]
	@deposito_id numeric(18,0),
	@producto_id numeric(18,0),
	@sucursal_id numeric(18,0),
	@familia_id numeric(18,0)
AS
BEGIN
	declare @query nvarchar(Max);
	declare @parametros nvarchar(Max);
	set @parametros='@producto_id numeric(18,0), @deposito_id numeric(18,0), @sucursal_id numeric(18,0), @familia_id numeric(18,0) ';
	set @query='select ip.instancia_producto_id, ip.deposito_id, ip.egreso_id, ip.estado_inst_prod_id, ei.estado_inst_prod, ip.fecha_ultima_modificacion, ip.ingreso_id, ip.motivo_modificacion, ip.precio_compra, ip.precio_venta, ip.producto_id  from instancia_producto ip inner join estado_instancia_producto ei on ei.estado_inst_prod_id=ip.estado_inst_prod_id '
	
	if(@sucursal_id <>0)
	begin
		set @query=@query + ' inner join sucursal_deposito_xref sd on ip.deposito_id=sd.deposito_id and sd.sucursal_id=@sucursal_id  ';	
	end;

	if(@familia_id  <> 0)
	begin
		set @query = @query + ' inner join producto p on p.producto_id=ip.producto_id and p.familia_de_producto_id=@familia_id ';
	end;

	if(@deposito_id <>0)
	begin
		set @query = @query + ' and ip.deposito_id=@deposito_id ';
	end;
	if(@producto_id <> 0)
	begin
		set @query = @query + ' and ip.producto_id=@producto_id';
	end;

	
	execute sp_executesql @query, @parametros, @producto_id, @deposito_id, @sucursal_id, @familia_id;
END


GO
/****** Object:  StoredProcedure [dbo].[guardar_comprobante_egreso_stock]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[guardar_comprobante_egreso_stock]
	@comprobante varbinary(MAX),
	@egreso_de_stock_id numeric(8,0)
AS
BEGIN
	update egreso_de_stock set comprobante=@comprobante where egreso_id=@egreso_de_stock_id;
END


GO
/****** Object:  StoredProcedure [dbo].[guardar_comprobante_ingreso_stock]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[guardar_comprobante_ingreso_stock]
	@comprobante varbinary(MAX),
	@ingreso_stock_id numeric(18,0)
AS
BEGIN
	update Ingreso_de_stock set comprobante_de_ingreso = @comprobante where ingreso_id=@ingreso_stock_id;
END


GO
/****** Object:  StoredProcedure [dbo].[guardar_comprobante_movimiento_stock]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[guardar_comprobante_movimiento_stock]
	@comprobante varbinary(MAX),
	@movimiento_id numeric(18,0)
AS
BEGIN
	update movimiento_de_stock set comprobante=@comprobante where movimiento_id=@movimiento_id;
END


GO
/****** Object:  StoredProcedure [dbo].[guardar_dgv_horizontal_rol]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[guardar_dgv_horizontal_rol]
@digito numeric(18,0),
	@id_rol numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	update rol set verificador_horizontal=@digito where rol_id=@id_rol;
END


GO
/****** Object:  StoredProcedure [dbo].[guardar_dgv_usuario]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[guardar_dgv_usuario]
	@digito numeric(25,0),
	@id_usuario numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	update usuario_grupo set verificador_horizontal=@digito where usuario_id=@id_usuario;
END


GO
/****** Object:  StoredProcedure [dbo].[guardar_dgv_vertical_rol]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[guardar_dgv_vertical_rol]
	@semilla integer,
	@entidad varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	declare @suma numeric(25,0);
	select @suma=sum(verificador_horizontal) from rol;
	select @suma=@suma+@semilla;
	if (@suma is not null)
	begin
		update verificador_vertical set verificador=@suma where Entidad=@entidad; 
	end;
	else
	begin
		update verificador_vertical set verificador=3 where Entidad=@entidad;
	end;
END


GO
/****** Object:  StoredProcedure [dbo].[guardar_dgv_vertical_usuario]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[guardar_dgv_vertical_usuario] 
	@semilla integer,
	@entidad varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	declare @suma numeric(25,0);
	select @suma=sum(verificador_horizontal) from usuario_grupo;
	select @suma=@suma+@semilla;
	update verificador_vertical set verificador=@suma where Entidad=@entidad; 
END


GO
/****** Object:  StoredProcedure [dbo].[guardar_elemento_de_idioma]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[guardar_elemento_de_idioma]
	-- Add the parameters for the stored procedure here
	@elemento_id numeric(18,0), 
	@texto text,
	@idioma_id numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into elementos_de_Idioma (elemento_id, texto, idioma_id) values (@elemento_id, @texto, @idioma_id);
END


GO
/****** Object:  StoredProcedure [dbo].[guardar_en_bitacora]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[guardar_en_bitacora] 
	@idEvento numeric(18,0),
	@nombreUsuario varchar(200)
AS
BEGIN
		declare @usuarioId numeric(18,0);
		select @usuarioId=usuario_id from usuario_grupo where nombre_usuario=@nombreUsuario;
		if(@usuarioId is not NULL)
		begin
			insert into bitacora(evento_id, usuario_id, hora, fecha) values (@idEvento, @usuarioId, CONVERT(VARCHAR(10),GETDATE(),108), CONVERT(VARCHAR(10),GETDATE(),101));
		end;
END

GO
/****** Object:  StoredProcedure [dbo].[guardar_factura_proveedor]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[guardar_factura_proveedor]
	@ingreso_id numeric(18,0),
	@factura varbinary(MAX),
	@proveedor_id numeric(18,0),
	@extension_archivo varchar(6)
AS
BEGIN

insert into facturas_de_proveedor(proveedor_id, factura, ingreso_id, extension_archivo) values(@proveedor_id, @factura, @ingreso_id, @extension_archivo);

END


GO
/****** Object:  StoredProcedure [dbo].[guardar_grupo]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[guardar_grupo]
	@nombre varchar(200),
	@grupo_id numeric(18,0) out
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	insert into usuario_grupo (nombre_usuario, flag_eliminado) values (@nombre,0);
	select @grupo_id=usuario_id from usuario_grupo where nombre_usuario=@nombre;
END

GO
/****** Object:  StoredProcedure [dbo].[guardar_idioma]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[guardar_idioma]
	-- Add the parameters for the stored procedure here
	@idioma varchar(50), 
	@cultura varchar(10),
	@descripcion varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	delete from elementos_de_Idioma where idioma_id in (select idioma_id from Idioma where idioma=@idioma)
	delete from idioma where idioma=@idioma;
   insert into Idioma (idioma, cultura, idioma_descripcion) values (@idioma, @cultura, @descripcion);
   select idioma_id from Idioma where idioma=@idioma and idioma_descripcion=@descripcion and cultura=@cultura;
END


GO
/****** Object:  StoredProcedure [dbo].[guardar_log_de_errores]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[guardar_log_de_errores]
	@fecha_y_hora datetime,
	@mensaje_error nvarchar(MAX),
	@excepcion nvarchar(MAX),
	@tipo_excepcion_id	 numeric(18,0),
	@clase varchar(300),
	@accion nvarchar(MAX),
	@query varchar(300)
AS
BEGIN
	insert into log_de_errores(fecha_y_hora, mensaje_error, excepcion, tipo_exepcion_id, clase, accion, query) values (@fecha_y_hora, @mensaje_error, @excepcion, @tipo_excepcion_id, @clase, @accion, @query);
END


GO
/****** Object:  StoredProcedure [dbo].[guardar_movimiento_de_stock]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[guardar_movimiento_de_stock] 
	@producto_id numeric(18,0),
	@deposito_orig_id numeric(18,0),
	@deposito_dest_id numeric(18,0),
	@motivo varchar(200),
	@cantidad int,
	@fecha Date,
	@empleado_id numeric(18,0)

AS
BEGIN
	insert into movimiento_de_stock(motivo, fecha, cantidad, deposito_destino_id, deposito_origen_id, producto_id, empleado_id) output inserted.movimiento_id values(@motivo, @fecha, @cantidad, @deposito_dest_id, @deposito_orig_id, @producto_id, @empleado_id);
END


GO
/****** Object:  StoredProcedure [dbo].[guardar_relacion_empleado_deposito]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[guardar_relacion_empleado_deposito] 
	@empleado_id numeric(18,0),
	@deposito_id numeric(18,0)
AS
BEGIN
	insert into empleado_deposito_xref(empleado_id, deposito_id) values(@empleado_id, @deposito_id);
END


GO
/****** Object:  StoredProcedure [dbo].[guardar_relacion_instancia_movimiento_de_stock]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[guardar_relacion_instancia_movimiento_de_stock] 
	@instancia_id numeric(18,0),
	@movimiento_id numeric(18,0)
AS
BEGIN
	insert into movimiento_de_stock_instancia_de_producto_xref(movimiento_id, instancia_de_producto_id) values(@movimiento_id, @instancia_id);
END


GO
/****** Object:  StoredProcedure [dbo].[guardar_relacion_usuario_empleados]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[guardar_relacion_usuario_empleados]
	@id_usuario numeric(18,0),
	@id_empleado numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	insert into usuario_empleado_xref (usuario_id, empleado_id) values (@id_usuario, @id_empleado);
END


GO
/****** Object:  StoredProcedure [dbo].[guardar_relacion_usuario_grupo]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[guardar_relacion_usuario_grupo] 
	@usuario_id numeric(18,0),
	@grupo_id numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    insert into usuario_grupo_xref (usuario_id, grupo_id) values (@usuario_id, @grupo_id);
END


GO
/****** Object:  StoredProcedure [dbo].[guardar_rol]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[guardar_rol]
	@nombre varchar(30),
	@descripcion varchar(300),
	@id_modulo numeric(18,0),
	@rol_id numeric(18,0) out
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	insert into rol (rol, rol_descripcion, modulo_id) values (@nombre, @descripcion, @id_modulo);
	select @rol_id= rol_id from rol where rol=@nombre and rol_descripcion=@descripcion and modulo_id=@id_modulo;

END


GO
/****** Object:  StoredProcedure [dbo].[gurdar_relacion_grupo_rol]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[gurdar_relacion_grupo_rol] 
	@rol_id numeric(18,0),
	@grupo_id numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	insert into grupo_rol_xref (rol_id, grupo_id) values (@rol_id, @grupo_id);
END


GO
/****** Object:  StoredProcedure [dbo].[gurdar_relacion_permiso_rol]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[gurdar_relacion_permiso_rol]
@rol_id numeric(18,0),
@permiso_id numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	insert into permiso_rol_xref (permiso_id, rol_id) values (@permiso_id, @rol_id);
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_comando_accion_resultado_xref]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_comando_accion_resultado_xref]
	@accion varchar(200),
	@resultado varchar(200)
AS
BEGIN
	--declare @idEvento numeric(18,0)
	--select @idEvento=accion_comando_xref_id from accion_comando_xref where accion=@accion and resultado=@resultado and bitacora_activa=1;
	--if (@idEvento is not NULL)
	--begin
		--declare @usuarioId numeric(18,0);
		--select @usuarioId=usuario_id from usuario_grupo where nombre_usuario=@nombreUsuario;
		--if(@usuarioId is not NULL)
		--begin
		--	insert into bitacora(evento_id, usuario_id, hora, fecha) values (@idEvento, @usuarioId, CONVERT(VARCHAR(10),GETDATE(),108), CONVERT(VARCHAR(10),GETDATE(),101));
		--end;
	--end;
	select comando, accion_comando_xref_id from accion_comando_xref where accion=@accion and resultado=@resultado;

END

GO
/****** Object:  StoredProcedure [dbo].[obtener_depositos_por_producto]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_depositos_por_producto]
	@producto_id numeric(18,0)
AS
BEGIN
	select d.deposito_id, d.nombre_deposito, c.contacto_id, c.calle, c.nro_puerta, c.departamento, c.piso, c.localidad_id, c.email, t.telefono, t.tipo_telefono_id  from deposito d left join contacto c on d.contacto_id=c.contacto_id and d.deposito_id in (select d.deposito_id from deposito d inner join instancia_producto i on d.deposito_id=i.deposito_id and i.producto_id=@producto_id) left join  telefono_contacto_xref tc on tc.contacto_id= c.contacto_id left join telefono t on tc.telefono_id=t.telefono_id;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_descuento]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_descuento]
	@descuento_id numeric(18,0),
	@nombre varchar(50)
AS
BEGIN
if (@descuento_id<>0)
begin
	select descuento_id, monto, porcentaje, descripcion_descuento, nombre_descuento from descuento where descuento_id=@descuento_id and flag_eliminado=0;
	end;
	else if (@nombre is not null and @nombre<>'')
	begin
	select descuento_id, monto, porcentaje, descripcion_descuento, nombre_descuento from descuento where nombre_descuento=@nombre and flag_eliminado=0;
	end;
END

select * from descuento;

GO
/****** Object:  StoredProcedure [dbo].[obtener_egreso_stock]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_egreso_stock]
	@egreso_id numeric(18,0)
AS
BEGIN
	select egreso_id, producto_id, cantidad, fecha, deposito_id, motivo, empleado_id, comprobante  from egreso_de_stock where egreso_id=@egreso_id;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_elementos_de_bitacora]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_elementos_de_bitacora]
	@usuario varchar(200),
	@idEvento numeric(18,0),
	@fecha varchar(11)
AS
BEGIN
	declare @query nvarchar(Max);
	declare @parametros nvarchar(Max);
	set @parametros='@usuario varchar(200), @idEvento numeric(18,0), @fecha varchar(11)';
	set @query='select acx.evento, b.hora, b.fecha, b.bitacora_id, u.nombre_usuario from bitacora b, usuario_grupo u, accion_comando_xref acx where u.usuario_id=b.usuario_id and acx.accion_comando_xref_id=b.evento_id'
	
	if(@usuario <> 'LH5crGnfNQg=' and @usuario<>'' and @usuario<>'Q5MylwjTdDQ=' and @usuario is not NULL)
	begin
		set @query=@query + ' and u.nombre_usuario=''' + @usuario + '''';	
	end;

	if(@idEvento <> 0)
	begin
		set @query = @query + ' and b.evento_id=' + cast(@idEvento as Varchar(18));
	end;

	if(@fecha <> '0001-01-01')
	begin
		set @query = @query + ' and b.fecha=''' + @fecha + '''';
	end;
	
	execute sp_executesql @query, @parametros, @usuario, @idEvento, @fecha;
END



GO
/****** Object:  StoredProcedure [dbo].[obtener_elementos_de_idioma_por_idioma]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_elementos_de_idioma_por_idioma]
	@idioma_id numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select 
	ei.texto,
	e.elemento_id, 
	e.nombre_elemento, 
	i.idioma_id, 
	i.idioma_descripcion, 
	i.cultura 
	from 
	elementos_de_Idioma ei, 
	elemento e, 
	Idioma i 
	where 
	i.idioma_id=@idioma_id and 
	i.idioma_id=ei.idioma_id and 
	ei.elemento_id=e.elemento_id;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_empleado_por_nro_empleado]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_empleado_por_nro_empleado]
	@nro_empleado varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select empleado_id, nro_empleado, persona_id, puesto_empleado_id from empleado where nro_empleado=@nro_empleado and flag_eliminado not in (1);
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_empleados_por_usuario_id]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_empleados_por_usuario_id]
	@id_usuario numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select e.empleado_id, e.nro_empleado, e.persona_id, e.puesto_empleado_id from empleado e inner join usuario_empleado_xref uex on e.empleado_id=uex.empleado_id and e.flag_eliminado not in (1) and uex.usuario_id=@id_usuario;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_entidad_dao_xref]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_entidad_dao_xref]
	-- Add the parameters for the stored procedure here
	@entidad varchar(100) = 'nunguno'
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
    -- Insert statements for procedure here
	SELECT dao_nombre from entidad_dao_xref where entidad_nombre=@entidad;

END



GO
/****** Object:  StoredProcedure [dbo].[obtener_familia_de_producto]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_familia_de_producto]
	@familia_id numeric(18,0),
	@familia varchar(100)

AS
BEGIN
	if(@familia_id<>0)
	begin
		select familia_id, familia from familia_de_producto where familia_id=@familia_id;
	end;
	else if (@familia<>'')
	begin
		select familia_id, familia from familia_de_producto where familia=@familia;
	end;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_fecha_ultimo_ingreso_de_stock_en_deposito_por_producto]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_fecha_ultimo_ingreso_de_stock_en_deposito_por_producto]
	@producto_id numeric(18,0),
	@deposito_id numeric(18,0)
AS
BEGIN
declare @ultima_fecha_ingreso date;
declare @ultima_fecha_movimiento date;

select @ultima_fecha_ingreso = MAX(fecha_ingreso) from Ingreso_de_stock where producto_id=@producto_id and deposito_id=@deposito_id;
select  @ultima_fecha_movimiento=MAX(fecha_aceptacion) from movimiento_de_stock where producto_id=@producto_id and deposito_destino_id=@deposito_id;

if(@ultima_fecha_ingreso is null)
begin
	if (@ultima_fecha_movimiento is null)
	begin
		select @ultima_fecha_ingreso;
	end;
	else
	begin
		select @ultima_fecha_movimiento;
	end;
end;
else if(@ultima_fecha_movimiento is not null)
begin
	if (@ultima_fecha_ingreso>@ultima_fecha_movimiento)
	begin
		select @ultima_fecha_ingreso;
	end;
	else
	begin
		select @ultima_fecha_movimiento;
	end;
end;
else
begin
	select @ultima_fecha_ingreso;
end;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_grupos_por_rol]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_grupos_por_rol] 
	@rol_id numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	select usuario_id, nombre_usuario from usuario_grupo ug inner join grupo_rol_xref grx on grx.rol_id=@rol_id and ug.usuario_id=grx.grupo_id and ug.flag_eliminado not in (1);

END


GO
/****** Object:  StoredProcedure [dbo].[obtener_grupos_usarios_por_usuario]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_grupos_usarios_por_usuario]
	@usuario_id numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select ug.usuario_id, ug.nombre_usuario from usuario_grupo ug inner join usuario_grupo_xref ugx on ug.usuario_id=ugx.grupo_id and ugx.usuario_id=@usuario_id and ug.flag_eliminado not in (1); 
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_grupos_usuarios_por_grupo]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_grupos_usuarios_por_grupo]
	@id_grupo numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select ug.usuario_id, ug.nombre_usuario from usuario_grupo ug inner join usuario_grupo_xref ugx on ugx.grupo_id=@id_grupo and ug.usuario_id=ugx.usuario_id and ug.flag_eliminado not in (1);
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_idioma_por_nombre]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_idioma_por_nombre]
	@nombre varchar(50)
AS
BEGIN
	select idioma_id, idioma_descripcion, cultura from idioma where idioma=@nombre;
END

GO
/****** Object:  StoredProcedure [dbo].[obtener_instancias_producto_para_egreso]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_instancias_producto_para_egreso]
	@producto_id numeric(18,0),
	@deposito_id numeric(18,0)
AS
BEGIN
	select ip.instancia_producto_id, ip.estado_inst_prod_id, ip.deposito_id, ip.fecha_ultima_modificacion, ip.ingreso_id, ip.motivo_modificacion, ip.precio_compra, ip.precio_venta, ip.producto_id, eip.estado_inst_prod  from instancia_producto ip inner join estado_instancia_producto eip on eip.estado_inst_prod_id=ip.estado_inst_prod_id and ip.deposito_id= @deposito_id and ip.producto_id=@producto_id and ip.estado_inst_prod_id not in (3,4,5);
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_instancias_producto_por_ingreso_stock]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_instancias_producto_por_ingreso_stock]
@ingreso_id numeric(18,0)
AS
BEGIN
	select ip.instancia_producto_id, ip.producto_id, ip.deposito_id, eip.estado_inst_prod_id, eip.estado_inst_prod, ip.precio_compra, ip.precio_venta, ip.fecha_ultima_modificacion, ip.motivo_modificacion, ip.ingreso_id  from instancia_producto ip inner join estado_instancia_producto eip on ip.ingreso_id=@ingreso_id and eip.estado_inst_prod_id=ip.estado_inst_prod_id;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_localidad_por_id]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_localidad_por_id]
	@localidad_id numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select l.localidad_id, l.cp, l.localidad, l.provincia_id from localidad l where l.localidad_id=@localidad_id;
    
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_localidades_por_provincia_id]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_localidades_por_provincia_id]
	@provincia_id numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	select localidad_id, localidad, cp, provincia_id from localidad where provincia_id = @provincia_id;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_materias_primas]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_materias_primas]

AS
BEGIN
	select producto_id, nombre_producto from Producto p where p.clasificacion_id =1;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_modulo_por_rol]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_modulo_por_rol]
	@id_rol numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   select m.modulo_id, m.modulo_nombre, m.modulo_descripcion, m.modulo_url from modulo m inner join rol r on r.modulo_id=m.modulo_id and r.rol_id=@id_rol;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_movimiento_de_stock]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_movimiento_de_stock]
	@movimiento_id numeric(18,0)
AS
BEGIN
	select movimiento_id, cantidad, fecha, deposito_origen_id, deposito_destino_id, producto_id, comprobante, motivo, fecha_aceptacion from movimiento_de_stock where movimiento_id=@movimiento_id;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_movimientos_de_stock_pendientes_de_aceptacion]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_movimientos_de_stock_pendientes_de_aceptacion]
	@deposito_destino_id numeric(18,0)
AS
BEGIN
	select movimiento_id, cantidad, fecha, deposito_origen_id, deposito_destino_id, producto_id, motivo from movimiento_de_stock where deposito_destino_id=@deposito_destino_id and fecha_aceptacion is null;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_movimientos_de_stock_por_instancia_de_producto]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_movimientos_de_stock_por_instancia_de_producto]
	@instancia_id numeric(18,0)
AS
BEGIN
	select mx.movimiento_id, ms.cantidad, ms.comprobante, ms.deposito_destino_id, ms.deposito_origen_id, ms.fecha, ms.motivo, ms.producto_id from movimiento_de_stock_instancia_de_producto_xref mx inner join movimiento_de_stock ms on mx.movimiento_id=ms.movimiento_id and mx.instancia_de_producto_id=@instancia_id;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_nro_empleado_por_dni]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_nro_empleado_por_dni]
	@nro_documento varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select e.nro_empleado from persona p, empleado e where p.persona_id = e.persona_id and p.nro_documento = @nro_documento;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_pais_por_id]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_pais_por_id] 
	@pais_id numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	select p.pais_id, p.pais from pais p where p.pais_id = @pais_id;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_pedido_de_reposicion_por_id]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_pedido_de_reposicion_por_id]
	@id_pedido numeric(18,0)
AS
BEGIN
	select pedido_id, producto_id, deposito_id, cantidad, fecha, flag_completado, comprobante, empleado_id from pedido_de_reposicion where pedido_id=@id_pedido;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_pedidos_de_reposicion_no_aceptados]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_pedidos_de_reposicion_no_aceptados] 
	@deposito_id numeric(18,0)
AS
BEGIN
	if (@deposito_id <>0 ) 
	begin
		select pedido_id, producto_id, deposito_id, cantidad, fecha, flag_completado,  empleado_id from pedido_de_reposicion where flag_completado=0 and deposito_id=@deposito_id;
	end;
	else
	begin
		select pedido_id, producto_id, deposito_id, cantidad, fecha, flag_completado,  empleado_id from pedido_de_reposicion where flag_completado=0;
	end;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_permmisos_por_rol]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_permmisos_por_rol]
@id_rol numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select p.permiso_id, p.permiso_nombre, p.permiso_descripcion from Permiso p inner join permiso_rol_xref prx on p.permiso_id=prx.permiso_id and prx.rol_id=@id_rol;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_persona_por_id]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_persona_por_id] 
	@persona_id numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select p.persona_id, p.nombre, p.apellido, p.nro_documento, p.tipo_documento_id, p.contacto_id, c.calle, c.departamento, c.email, c.localidad_id, c.nro_puerta, c.piso from persona p, contacto c where p.contacto_id=c.contacto_id and p.persona_id = @persona_id;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_provincia_por_id]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_provincia_por_id] 
	@provincia_id numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select p.provincia_id, p.pais_id, p.provincia from provincia p where p.provincia_id=@provincia_id;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_provincias_por_pais_id]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_provincias_por_pais_id] 
	@pais_id numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select provincia_id, provincia, pais_id from provincia where pais_id=@pais_id;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_proximo_nro_empleado]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_proximo_nro_empleado] 
	@id_puesto numeric(18,0),
	@nro_empleado varchar(50) OUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	declare @empleado_id numeric(18,0);
	declare @codigo varchar(4);

	select top 1 @empleado_id=empleado_id from empleado order by empleado_id desc;
	select @codigo=codigo_identificador from puesto_empleado where puesto_empleado_id=@id_puesto;

	if @empleado_id is not null
	begin
		set @empleado_id=@empleado_id + 1
		set @nro_empleado= @codigo + '-' + cast(@empleado_id as varchar(18));
	end
	else
	begin
		set @nro_empleado= @codigo + '-' + '1';
	end

END


GO
/****** Object:  StoredProcedure [dbo].[obtener_rol_por_nombre_sp]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_rol_por_nombre_sp]
	@nombre varchar(30)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	select rol_id, rol, rol_descripcion, modulo_id, verificador_horizontal from rol where rol=@nombre;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_roles_por_grupo]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_roles_por_grupo]
	@id_grupo numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	select r.rol_id, r.rol, r.rol_descripcion, r.verificador_horizontal from rol r inner join grupo_rol_xref grx on r.rol_id=grx.rol_id and grx.grupo_id=@id_grupo; 
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todas_las_clasificaciones_de_producto]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todas_las_clasificaciones_de_producto]
	
AS
BEGIN
	select clasificacion_id, clasificacion from clasificacion_de_producto;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todas_las_existencias]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todas_las_existencias]
	@producto numeric(18,0),
	@deposito numeric(18,0)
AS
BEGIN

	declare @query nvarchar(Max);
	declare @parametros nvarchar(Max);
	declare @countquery nvarchar(Max);
	set @parametros='@producto numeric(18,0), @deposito numeric(18,0)';
	set @countquery='(select count(*) from instancia_producto ip where p.producto_id=ip.producto_id ';
	set @query = 'select p.producto_id, '

	if(@deposito<>0)
	begin
		set @countquery = @countquery + ' and ip.deposito_id=@deposito';
	end;
	if(@producto<>0)
	begin
		set @countquery = @countquery + ' and ip.producto_id=@producto';
	end;


	set @countquery = @countquery + ' and ip.estado_inst_prod_id=1),';

	set @query = @query + @countquery;
	set @query = @query + ' p.punto_de_reposicion_maximo, p.punto_de_reposicion_minimo, mr.metodo_de_reposicion, p.nombre_producto, p.ciclo, mr.metodo_reposicion_id, p.pedido_automatico from producto p inner join metodo_de_reposicion mr on mr.metodo_reposicion_id=p.metodo_de_reposicion_id ';

	if(@producto<>0)
	begin
		set @query = @query + ' and p.producto_id=@producto ';
	end;
	

	execute sp_executesql @query, @parametros, @producto, @deposito;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todas_las_familias_de_producto]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todas_las_familias_de_producto]
AS
BEGIN
	select familia_id, familia from familia_de_producto;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todas_las_instancias_prducto]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todas_las_instancias_prducto]
	@producto_id numeric(18,0)
AS
BEGIN
	select instancia_producto_id, producto_id, deposito_id, estado_inst_prod_id, precio_compra, precio_venta, fecha_ultima_modificacion, motivo_modificacion, ingreso_id, deposito_id, estado_inst_prod_id from instancia_producto where producto_id=@producto_id and estado_inst_prod_id not in (2,3,4) order by ingreso_id asc;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todas_las_instancias_producto_por_egreso]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todas_las_instancias_producto_por_egreso]
	@egreso_id numeric(18,0)
AS
BEGIN
	select instancia_producto_id, producto_id, deposito_id, estado_inst_prod_id, precio_compra, precio_venta, fecha_ultima_modificacion, motivo_modificacion, ingreso_id, egreso_id, deposito_id from instancia_producto where egreso_id=@egreso_id;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todas_las_instancias_producto_por_movimiento_de_stock]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todas_las_instancias_producto_por_movimiento_de_stock]
	@movimiento_id numeric(18,0)
AS
BEGIN
	select ip.instancia_producto_id, ip.producto_id, ip.deposito_id, ip.estado_inst_prod_id, ip.precio_compra, ip.precio_venta, ip.fecha_ultima_modificacion, ip.motivo_modificacion, ip.ingreso_id, ip.egreso_id, ip.deposito_id  from instancia_producto ip inner join movimiento_de_stock_instancia_de_producto_xref mix on mix.instancia_de_producto_id = ip.instancia_producto_id and mix.movimiento_id=@movimiento_id;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todas_las_marcas]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todas_las_marcas]
	
AS
BEGIN
select marca_id, marca from marca;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todas_las_monedas]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todas_las_monedas]
	
AS
BEGIN
	select moneda_id, moneda from moneda;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todas_las_sucursales]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todas_las_sucursales]
AS
BEGIN
	select s.sucursal_id, s.estado_sucursal_id, s.fecha_apertura, s.fecha_cierre, s.horario_inicio_actividad, s.horario_cierre_actividad, s.contacto_id from sucursal s where s.estado_sucursal_id=1;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_entidad_dao_xref]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todos_entidad_dao_xref] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT dao_nombre, entidad_nombre from entidad_dao_xref
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_estados_proveedor]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todos_estados_proveedor] 
AS
BEGIN
	select estado_proveedor_id, estado_proveedor from estado_proveedor;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_los_depositos]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todos_los_depositos]
AS
BEGIN
	select d.deposito_id, d.nombre_deposito, c.contacto_id, c.calle, c.nro_puerta, c.departamento, c.piso, c.localidad_id, c.email, t.telefono, t.tipo_telefono_id  from deposito d, contacto c, telefono_contacto_xref tc, telefono t where d.contacto_id=c.contacto_id and tc.contacto_id= c.contacto_id and tc.telefono_id=t.telefono_id;
END


GO
/****** Object:  StoredProcedure [dbo].[OBTENER_TODOS_LOS_DEPOSITOS_POR_EMPLEADO_SP]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[OBTENER_TODOS_LOS_DEPOSITOS_POR_EMPLEADO_SP]
	@empleado_id numeric(18,0)
AS
BEGIN
	select d.deposito_id, d.nombre_deposito, c.contacto_id, c.calle, c.nro_puerta, c.departamento, c.piso, c.localidad_id, c.email, t.telefono, t.tipo_telefono_id  from deposito d inner join contacto c on d.contacto_id=c.contacto_id and d.deposito_id in (select deposito_id from empleado_deposito_xref where empleado_id=@empleado_id) left join  telefono_contacto_xref tc on tc.contacto_id= c.contacto_id left join telefono t on tc.telefono_id=t.telefono_id;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_los_depositos_por_sucursal]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todos_los_depositos_por_sucursal]
	@sucursal_id numeric(18,0)
AS
BEGIN
	select d.deposito_id, d.nombre_deposito, c.contacto_id, c.calle, c.nro_puerta, c.departamento, c.piso, c.localidad_id, c.email, t.telefono, t.tipo_telefono_id from deposito d, sucursal_deposito_xref sd, contacto c, telefono t, telefono_contacto_xref tc where sd.sucursal_id=@sucursal_id and d.deposito_id = sd.deposito_id and c.contacto_id=d.contacto_id and tc.contacto_id=c.contacto_id and tc.telefono_id=t.telefono_id;
	end



GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_los_descuentos]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todos_los_descuentos]
AS
BEGIN

select descuento_id, monto, porcentaje, descripcion_descuento, nombre_descuento from descuento where flag_eliminado=0;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_los_egresos_de_stock_con_filtro]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todos_los_egresos_de_stock_con_filtro] 
	@fecha varchar(20),
	@deposito_id numeric(18,0),
	@producto_id numeric(18,0),
	@nro_empleado varchar(50),
	@instancia_id numeric(18,0)
AS
BEGIN
	declare @query nvarchar(Max);
	declare @parametros nvarchar(Max);
	set @parametros='@producto_id numeric(18,0), @nro_empleado varchar(50), @fecha varchar(20), @deposito_id numeric(18,0), @instancia_id numeric(18,0)';
	set @query='select i.egreso_id, i.producto_id, i.cantidad, i.fecha, i.deposito_id, i.motivo, i.empleado_id from egreso_de_stock i'
	
	if(@nro_empleado<>'')
	begin
		set @query=@query + ' inner join empleado e on e.nro_empleado=@nro_empleado and and e.empleado_id=i.empleado_id ';	
	end;

	if(@instancia_id  <> 0)
	begin
		set @query = @query + ' inner join instancia_producto ip on ip.egreso_id=i.egreso_id and ip.instancia_producto_id=@instancia_id ';
	end;

	if(@fecha <> '' and (@nro_empleado<>'' or @instancia_id  <> 0))
	begin
		set @query = @query + ' and i.fecha=''' + @fecha + '''';
	end;
	if(@fecha<>'' and @nro_empleado='' and @instancia_id=0)
	begin
		set @query = @query + ' where i.fecha=''' + @fecha + '''';
	end;


	if(@producto_id <> 0 and (@nro_empleado<>'' or @instancia_id  <> 0 or @fecha<>''))
	begin
		set @query = @query + ' and i.producto_id=@producto_id';
	end;
	if(@producto_id <> 0 and @nro_empleado='' and @instancia_id =0 and @fecha='')
	begin
		set @query = @query + ' where i.producto_id=@producto_id';
	end;

	if(@deposito_id <> 0 and (@nro_empleado<>'' or @instancia_id  <> 0 or @fecha<>'' or @producto_id<>0))
	begin
		set @query = @query + ' and i.deposito_id=@deposito_id';
	end;
	if(@deposito_id <> 0 and @nro_empleado='' and @instancia_id=0 and @fecha='' and @producto_id=0)
	begin
		set @query = @query + ' where i.deposito_id=@deposito_id';
	end;

	execute sp_executesql @query, @parametros, @producto_id, @nro_empleado, @fecha, @deposito_id, @instancia_id;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_los_elementos]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todos_los_elementos] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT elemento_id, nombre_elemento from elemento;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_los_empleados]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todos_los_empleados]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	select empleado_id, nro_empleado, persona_id, puesto_empleado_id from empleado where flag_eliminado not in (1);
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_los_estados_de_producto]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todos_los_estados_de_producto]
	

AS
BEGIN
	select estado_producto_id, estado_producto from estado_producto;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_los_estados_sucursal]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todos_los_estados_sucursal]

AS
BEGIN
	select estado_sucursal_id, estado_sucursal from estado_sucursal;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_los_eventos_de_bitacora]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todos_los_eventos_de_bitacora]
AS
BEGIN
	select accion_comando_xref_id, comando, accion, bitacora_activa, evento, resultado from accion_comando_xref where bitacora_activa=1;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_los_idiomas]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todos_los_idiomas]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   select idioma_id, idioma_descripcion, cultura from idioma 
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_los_ingresos_de_stock_con_filtro]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todos_los_ingresos_de_stock_con_filtro] 
	@fecha varchar(20),
	@deposito_id numeric(18,0),
	@producto_id numeric(18,0),
	@nro_empleado varchar(50),
	@instancia_id numeric(18,0)
AS
BEGIN
	declare @query nvarchar(Max);
	declare @parametros nvarchar(Max);
	set @parametros='@producto_id numeric(18,0), @nro_empleado varchar(50), @fecha varchar(20), @deposito_id numeric(18,0), @instancia_id numeric(18,0)';
	set @query='select i.ingreso_id, i.fecha_ingreso, i.empleado_id, i.deposito_id,  i.producto_id, i.cantidad  from ingreso_de_stock i'
	
	if(@nro_empleado<>'')
	begin
		set @query=@query + ' inner join empleado e on e.nro_empleado=@nro_empleado and and e.empleado_id=i.empleado_id ';	
	end;

	if(@instancia_id  <> 0)
	begin
		set @query = @query + ' inner join instancia_producto ip on ip.ingreso_id=i.ingreso_id and ip.instancia_producto_id=@instancia_id ';
	end;

	if(@fecha <> '' and (@nro_empleado<>'' or @instancia_id  <> 0))
	begin
		set @query = @query + ' and i.fecha_ingreso=''' + @fecha + '''';
	end;
	if(@fecha<>'' and @nro_empleado='' and @instancia_id=0)
	begin
		set @query = @query + ' where i.fecha_ingreso=''' + @fecha + '''';
	end;


	if(@producto_id <> 0 and (@nro_empleado<>'' or @instancia_id  <> 0 or @fecha<>''))
	begin
		set @query = @query + ' and i.producto_id=@producto_id';
	end;
	if(@producto_id <> 0 and @nro_empleado='' and @instancia_id =0 and @fecha='')
	begin
		set @query = @query + ' where i.producto_id=@producto_id';
	end;

	if(@deposito_id <> 0 and (@nro_empleado<>'' or @instancia_id  <> 0 or @fecha<>'' or @producto_id<>0))
	begin
		set @query = @query + ' and i.deposito_id=@deposito_id';
	end;
	if(@deposito_id <> 0 and @nro_empleado='' and @instancia_id=0 and @fecha='' and @producto_id=0)
	begin
		set @query = @query + ' where i.deposito_id=@deposito_id';
	end;

	execute sp_executesql @query, @parametros, @producto_id, @nro_empleado, @fecha, @deposito_id, @instancia_id;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_los_ingrsos_de_stock_por_pedido]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todos_los_ingrsos_de_stock_por_pedido] 
	@pedido_de_stock_id numeric(18,0)
AS
BEGIN
	
	select ingreso_id, fecha_ingreso, empleado_id, deposito_id, cantidad, producto_id from Ingreso_de_stock where pedido_de_reposicion_id=@pedido_de_stock_id;
END

GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_los_metodos_de_reposicion]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todos_los_metodos_de_reposicion]

AS
BEGIN
	select metodo_reposicion_id, metodo_De_reposicion from metodo_De_reposicion;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_los_metodos_valoracion]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todos_los_metodos_valoracion]
	
AS
BEGIN
	select metodo_valoracion_id, nombre_metodo, descripcion from metodo_de_valoracion;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_los_modulos]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todos_los_modulos]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	select modulo_id, modulo_nombre, modulo_descripcion, modulo_url from modulo;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_los_movimientos_de_stock_con_filtro]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todos_los_movimientos_de_stock_con_filtro]
	@fecha varchar(20),
	@deposito_id numeric(18,0),
	@producto_id numeric(18,0),
	@nro_empleado varchar(50),
	@instancia_id numeric(18,0)
AS
BEGIN
	declare @query nvarchar(Max);
	declare @parametros nvarchar(Max);
	set @parametros='@producto_id numeric(18,0), @nro_empleado varchar(50), @fecha varchar(20), @deposito_id numeric(18,0), @instancia_id numeric(18,0)';
	set @query='select i.movimiento_id, i.cantidad, i.fecha, i.deposito_origen_id, i.deposito_destino_id, i.producto_id, i.motivo, i.fecha_aceptacion, i.empleado_id from movimiento_de_stock i'
	
	if(@nro_empleado<>'')
	begin
		set @query=@query + ' inner join empleado e on e.nro_empleado=@nro_empleado and and e.empleado_id=i.empleado_id ';	
	end;

	if(@instancia_id  <> 0)
	begin
		set @query = @query + ' inner join movimiento_de_stock_instancia_de_producto_xref mix on mix.movimiento_id=i.movimiento_id and mix.instancia_de_producto_id=@instancia_id ';
	end;

	if(@fecha <> '' and (@nro_empleado<>'' or @instancia_id  <> 0))
	begin
		set @query = @query + ' and i.fecha=''' + @fecha + '''';
	end;
	if(@fecha<>'' and @nro_empleado='' and @instancia_id=0)
	begin
		set @query = @query + ' where i.fecha=''' + @fecha + '''';
	end;


	if(@producto_id <> 0 and (@nro_empleado<>'' or @instancia_id  <> 0 or @fecha<>''))
	begin
		set @query = @query + ' and i.producto_id=@producto_id';
	end;
	if(@producto_id <> 0 and @nro_empleado='' and @instancia_id =0 and @fecha='')
	begin
		set @query = @query + ' where i.producto_id=@producto_id';
	end;

	if(@deposito_id <> 0 and (@nro_empleado<>'' or @instancia_id  <> 0 or @fecha<>'' or @producto_id<>0))
	begin
		set @query = @query + ' and i.deposito_id=@deposito_id';
	end;
	if(@deposito_id <> 0 and @nro_empleado='' and @instancia_id=0 and @fecha='' and @producto_id=0)
	begin
		set @query = @query + ' where i.deposito_id=@deposito_id';
	end;

	execute sp_executesql @query, @parametros, @producto_id, @nro_empleado, @fecha, @deposito_id, @instancia_id;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_los_paises_sp]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todos_los_paises_sp]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select pais_id, pais from pais;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_los_pedidos_de_reposicion_con_filtro]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todos_los_pedidos_de_reposicion_con_filtro] 
	@fecha varchar(20),
	@deposito_id numeric(18,0),
	@producto_id numeric(18,0),
	@nro_empleado varchar(50),
	@instancia_id numeric(18,0),
	@ingresado bit
AS
BEGIN
	declare @query nvarchar(Max);
	declare @parametros nvarchar(Max);
	set @parametros='@producto_id numeric(18,0), @nro_empleado varchar(50), @fecha varchar(20), @deposito_id numeric(18,0), @instancia_id numeric(18,0), @ingresado bit';
	set @query='select i.pedido_id, i.producto_id, i.deposito_id, i.cantidad, i.fecha, i.flag_completado, i.empleado_id from pedido_de_reposicion i'
	
	if(@nro_empleado<>'')
	begin
		set @query=@query + ' inner join empleado e on e.nro_empleado=@nro_empleado and and e.empleado_id=i.empleado_id ';	
	end;

	if(@instancia_id  <> 0)
	begin
		set @query = @query + ' inner join instancia_producto ip on ip.ingreso_id=i.ingreso_id and ip.instancia_producto_id=@instancia_id ';
	end;

	if(@fecha <> '' and (@nro_empleado<>'' or @instancia_id  <> 0))
	begin
		set @query = @query + ' and i.fecha=''' + @fecha + '''';
	end;
	if(@fecha<>'' and @nro_empleado='' and @instancia_id=0)
	begin
		set @query = @query + ' where i.fecha=''' + @fecha + '''';
	end;


	if(@producto_id <> 0 and (@nro_empleado<>'' or @instancia_id  <> 0 or @fecha<>''))
	begin
		set @query = @query + ' and i.producto_id=@producto_id';
	end;
	if(@producto_id <> 0 and @nro_empleado='' and @instancia_id =0 and @fecha='')
	begin
		set @query = @query + ' where i.producto_id=@producto_id';
	end;

	if(@deposito_id <> 0 and (@nro_empleado<>'' or @instancia_id  <> 0 or @fecha<>'' or @producto_id<>0))
	begin
		set @query = @query + ' and i.deposito_id=@deposito_id';
	end;
	if(@deposito_id <> 0 and @nro_empleado='' and @instancia_id=0 and @fecha='' and @producto_id=0)
	begin
		set @query = @query + ' where i.deposito_id=@deposito_id';
	end;

	if(@ingresado <> 1 and (@nro_empleado<>'' or @instancia_id  <> 0 or @fecha<>'' or @producto_id<>0 or @deposito_id<>0))
	begin
		set @query = @query + ' and i.flag_completado=@ingresado';
	end;
	if(@ingresado <> 1 and @deposito_id = 0 and @nro_empleado='' and @instancia_id=0 and @fecha='' and @producto_id=0)
	begin
		set @query = @query + ' where i.flag_completado=@ingresado';
	end;

	execute sp_executesql @query, @parametros, @producto_id, @nro_empleado, @fecha, @deposito_id, @instancia_id, @ingresado;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_los_permisos_sp]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todos_los_permisos_sp] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select permiso_id, permiso_nombre, permiso_descripcion from permiso;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_los_productos]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todos_los_productos]
AS
BEGIN
	select p.producto_id, p.nombre_producto, p.descripcion_producto, p.precio_compra, p.precio_venta, p.clasificacion_id, p.coste_posesion, 
	p.coste_financiero, p.descuento_global_id, p.estado_producto_id, p.marca_id, p.metodo_valoracion_id, p.moneda_id, p.porcentaje_de_ganancia, p.precio_coste_adquisicion, 
	p.regla_de_composicion, p.precio_ultima_compra, mr.metodo_reposicion_id, mr.metodo_de_reposicion, p.punto_de_reposicion_minimo, p.punto_de_reposicion_maximo, p.ciclo, p.familia_de_producto_id, p.unidad, p.pedido_automatico
	 from producto p inner join metodo_De_reposicion mr on mr.metodo_reposicion_id=p.metodo_de_reposicion_id;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_los_proveedores]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todos_los_proveedores]
AS
BEGIN
	select p.proveedor_id, p.proveedor_nombre, c.calle, c.nro_puerta, c.departamento, c.piso, c.localidad_id, c.email, t.telefono, p.cuit, p.proveedor_estado_id from proveedor p, contacto c, telefono_contacto_xref tc, telefono t where p.contacto_id = c.contacto_id and tc.contacto_id=c.contacto_id and tc.telefono_id=t.telefono_id;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_los_proveedores_por_producto]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todos_los_proveedores_por_producto]
	@producto_id numeric(18,0)
AS
BEGIN
	select p.proveedor_id, p.proveedor_nombre from proveedor p, producto_proveedor_xref pp where p.proveedor_id=pp.proveedor_id and pp.producto_id=@producto_id;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_los_puestos]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todos_los_puestos] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT puesto_empleado_id, codigo_identificador, puesto_empleado from puesto_empleado;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_los_roles]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todos_los_roles]
AS
BEGIN
	select rol_id, rol,  rol_descripcion, verificador_horizontal from rol; 
END

GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_los_tipos_de_docuemento]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todos_los_tipos_de_docuemento] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	select tipo_documento_id, tipo_documento, descripcion from tipo_documento;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_los_tipos_de_excepcion]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todos_los_tipos_de_excepcion]
AS
BEGIN

select tipo_excepcion_id, tipo_excepcion from tipo_excepcion;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_los_usuarios]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todos_los_usuarios]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	select usuario_id, nombre_usuario from usuario_grupo where flag_eliminado not in (1);
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_los_usuarios_grupos]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_todos_los_usuarios_grupos]

AS
BEGIN
	select usuario_id, nombre_usuario, pregunta_secreta, respuesta_secreta, contador_mala_password, bloqueado, verificador_horizontal, password from usuario_grupo;
END

GO
/****** Object:  StoredProcedure [dbo].[obtener_usuario_por_nombre_usuario]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_usuario_por_nombre_usuario]
	@usuario_nombre varchar(200)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	select usuario_id, contador_mala_password, bloqueado, pregunta_secreta, respuesta_secreta, password,  nombre_usuario, verificador_horizontal from usuario_grupo where nombre_usuario=@usuario_nombre and flag_eliminado not in (1);
END

select * from usuario_grupo;

GO
/****** Object:  StoredProcedure [dbo].[obtener_usuarios_de_empleado]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_usuarios_de_empleado] 
	@id_empleado numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select usuario_id from usuario_empleado_xref where empleado_id=@id_empleado;
END


GO
/****** Object:  StoredProcedure [dbo].[obtener_usuarios_grupos_por_id_hijo]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtener_usuarios_grupos_por_id_hijo]
	@id_usuario numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select ug.nombre_usuario, ug.usuario_id, ugx.usuario_id from usuario_grupo ug inner join usuario_grupo_xref ugx on ug.usuario_id=ugx.grupo_id and ugx.usuario_id=@id_usuario and ug.flag_eliminado not in (1);
END


GO
/****** Object:  StoredProcedure [dbo].[otener_todos_los_estados_instancia_de_producto]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[otener_todos_los_estados_instancia_de_producto]
	
AS
BEGIN
	select estado_inst_prod_id, estado_inst_prod from estado_instancia_producto;
END


GO
/****** Object:  Table [dbo].[accion_comando_xref]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[accion_comando_xref](
	[accion_comando_xref_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[accion] [varchar](200) NOT NULL,
	[comando] [varchar](200) NOT NULL,
	[resultado] [varchar](200) NOT NULL,
	[evento] [varchar](200) NOT NULL,
	[bitacora_activa] [bit] NOT NULL,
 CONSTRAINT [PK_accion_comando_xref] PRIMARY KEY CLUSTERED 
(
	[accion_comando_xref_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bitacora](
	[bitacora_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[evento_id] [numeric](18, 0) NOT NULL,
	[usuario_id] [numeric](18, 0) NOT NULL,
	[fecha] [date] NOT NULL,
	[hora] [time](7) NOT NULL,
 CONSTRAINT [PK_Bitacora] PRIMARY KEY CLUSTERED 
(
	[bitacora_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[clasificacion_de_producto]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[clasificacion_de_producto](
	[clasificacion_id] [numeric](18, 0) NOT NULL,
	[clasificacion] [varchar](200) NOT NULL,
 CONSTRAINT [PK_clasificacion_de_producto] PRIMARY KEY CLUSTERED 
(
	[clasificacion_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[contacto]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[contacto](
	[contacto_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[calle] [varchar](100) NULL,
	[nro_puerta] [varchar](10) NULL,
	[piso] [int] NULL,
	[departamento] [varchar](4) NULL,
	[localidad_id] [numeric](18, 0) NOT NULL,
	[email] [varchar](200) NULL,
 CONSTRAINT [PK_contacto] PRIMARY KEY CLUSTERED 
(
	[contacto_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[deposito]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[deposito](
	[deposito_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[contacto_id] [numeric](18, 0) NOT NULL,
	[nombre_deposito] [varchar](50) NOT NULL,
 CONSTRAINT [PK_deposito] PRIMARY KEY CLUSTERED 
(
	[deposito_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[deposito_instancia_producto_xref]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[deposito_instancia_producto_xref](
	[deposito_id] [numeric](18, 0) NOT NULL,
	[instancia_productp_id] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_deposito_instancia_producto_xref] PRIMARY KEY CLUSTERED 
(
	[deposito_id] ASC,
	[instancia_productp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[descuento]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[descuento](
	[descuento_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[monto] [numeric](18, 2) NULL,
	[porcentaje] [numeric](18, 2) NULL,
	[descripcion_descuento] [varchar](400) NULL,
	[nombre_descuento] [varchar](50) NULL,
	[flag_eliminado] [bit] NOT NULL,
 CONSTRAINT [PK_descuento] PRIMARY KEY CLUSTERED 
(
	[descuento_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[descuento_instancia_producto_xref]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[descuento_instancia_producto_xref](
	[descuento_id] [numeric](18, 0) NOT NULL,
	[instancia_producto_id] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_descuento_instancia_producto_xref] PRIMARY KEY CLUSTERED 
(
	[descuento_id] ASC,
	[instancia_producto_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[egreso_de_stock]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[egreso_de_stock](
	[egreso_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[producto_id] [numeric](18, 0) NOT NULL,
	[cantidad] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[deposito_id] [numeric](18, 0) NOT NULL,
	[motivo] [varchar](300) NULL,
	[comprobante] [varbinary](max) NULL,
	[empleado_id] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_egreso_de_stock] PRIMARY KEY CLUSTERED 
(
	[egreso_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[egreso_de_stock_instancia_de_producto_xref]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[egreso_de_stock_instancia_de_producto_xref](
	[egreso_id] [numeric](18, 0) NOT NULL,
	[instancia_de_producto_id] [numeric](18, 0) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[elemento]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[elemento](
	[elemento_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[nombre_elemento] [varchar](50) NOT NULL,
 CONSTRAINT [PK_elemento] PRIMARY KEY CLUSTERED 
(
	[elemento_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[elementos_de_Idioma]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[elementos_de_Idioma](
	[elemento_id] [numeric](18, 0) NOT NULL,
	[texto] [text] NOT NULL,
	[idioma_id] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_elementos_de_Idioma] PRIMARY KEY CLUSTERED 
(
	[elemento_id] ASC,
	[idioma_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[empleado]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[empleado](
	[empleado_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[puesto_empleado_id] [numeric](18, 0) NOT NULL,
	[nro_empleado] [varchar](50) NULL,
	[persona_id] [numeric](18, 0) NOT NULL,
	[flag_eliminado] [bit] NULL,
 CONSTRAINT [PK_empleado] PRIMARY KEY CLUSTERED 
(
	[empleado_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[empleado_deposito_xref]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleado_deposito_xref](
	[deposito_id] [numeric](18, 0) NOT NULL,
	[empleado_id] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_empleado_reposito_xref] PRIMARY KEY CLUSTERED 
(
	[deposito_id] ASC,
	[empleado_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[entidad_dao_xref]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[entidad_dao_xref](
	[entidad_dao_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[entidad_nombre] [varchar](100) NOT NULL,
	[dao_nombre] [nchar](100) NOT NULL,
 CONSTRAINT [PK_entidad_dao_xref] PRIMARY KEY CLUSTERED 
(
	[entidad_dao_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[estado_instancia_producto]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[estado_instancia_producto](
	[estado_inst_prod_id] [int] NOT NULL,
	[estado_inst_prod] [varchar](50) NOT NULL,
 CONSTRAINT [PK_estado_instancia_producto] PRIMARY KEY CLUSTERED 
(
	[estado_inst_prod_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[estado_producto]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[estado_producto](
	[estado_producto_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[estado_producto] [varchar](50) NOT NULL,
 CONSTRAINT [PK_estado_producto] PRIMARY KEY CLUSTERED 
(
	[estado_producto_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[estado_proveedor]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[estado_proveedor](
	[estado_proveedor_id] [int] IDENTITY(1,1) NOT NULL,
	[estado_proveedor] [varchar](50) NOT NULL,
 CONSTRAINT [PK_estado_proveedor] PRIMARY KEY CLUSTERED 
(
	[estado_proveedor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[estado_sucursal]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[estado_sucursal](
	[estado_sucursal_id] [int] IDENTITY(1,1) NOT NULL,
	[estado_sucursal] [varchar](50) NOT NULL,
 CONSTRAINT [PK_estado_sucursal] PRIMARY KEY CLUSTERED 
(
	[estado_sucursal_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[facturas_de_proveedor]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[facturas_de_proveedor](
	[factura_proveedor_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[proveedor_id] [numeric](18, 0) NOT NULL,
	[factura] [varbinary](max) NOT NULL,
	[ingreso_id] [numeric](18, 0) NOT NULL,
	[extension_archivo] [varchar](6) NOT NULL,
 CONSTRAINT [PK_facturas_de_proveedor] PRIMARY KEY CLUSTERED 
(
	[factura_proveedor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[familia_de_producto]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[familia_de_producto](
	[familia_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[familia] [varchar](100) NOT NULL,
 CONSTRAINT [PK_familia_de_producto] PRIMARY KEY CLUSTERED 
(
	[familia_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[grupo_rol_xref]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[grupo_rol_xref](
	[rol_id] [numeric](18, 0) NOT NULL,
	[grupo_id] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_grupo_rol_xref] PRIMARY KEY CLUSTERED 
(
	[rol_id] ASC,
	[grupo_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Idioma]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Idioma](
	[idioma_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[idioma] [varchar](50) NOT NULL,
	[cultura] [varchar](10) NULL,
	[idioma_descripcion] [varchar](100) NULL,
 CONSTRAINT [PK_Idioma] PRIMARY KEY CLUSTERED 
(
	[idioma_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ingreso_de_stock]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ingreso_de_stock](
	[ingreso_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[fecha_ingreso] [date] NOT NULL,
	[empleado_id] [numeric](18, 0) NOT NULL,
	[comprobante_de_ingreso] [varbinary](max) NULL,
	[cantidad] [int] NOT NULL,
	[producto_id] [numeric](18, 0) NULL,
	[deposito_id] [numeric](18, 0) NULL,
	[pedido_de_reposicion_id] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_Ingreso_de_stock] PRIMARY KEY CLUSTERED 
(
	[ingreso_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[instancia_producto]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[instancia_producto](
	[instancia_producto_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[producto_id] [numeric](18, 0) NOT NULL,
	[deposito_id] [numeric](18, 0) NULL,
	[estado_inst_prod_id] [int] NOT NULL,
	[precio_compra] [numeric](18, 2) NULL,
	[precio_venta] [numeric](18, 2) NULL,
	[fecha_ultima_modificacion] [date] NULL,
	[motivo_modificacion] [varchar](200) NULL,
	[ingreso_id] [numeric](18, 0) NOT NULL,
	[egreso_id] [numeric](18, 0) NULL,
 CONSTRAINT [PK_instancia_producto] PRIMARY KEY CLUSTERED 
(
	[instancia_producto_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[localidad]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[localidad](
	[localidad_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[localidad] [varchar](100) NULL,
	[cp] [varchar](50) NULL,
	[provincia_id] [int] NOT NULL,
 CONSTRAINT [PK_localidad] PRIMARY KEY CLUSTERED 
(
	[localidad_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[log_de_errores]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[log_de_errores](
	[error_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[fecha_y_hora] [datetime] NOT NULL,
	[mensaje_error] [nvarchar](max) NOT NULL,
	[excepcion] [nvarchar](max) NOT NULL,
	[tipo_exepcion_id] [numeric](18, 0) NOT NULL,
	[clase] [varchar](300) NOT NULL,
	[accion] [nvarchar](max) NOT NULL,
	[query] [varchar](300) NOT NULL,
 CONSTRAINT [PK_log_de_errores] PRIMARY KEY CLUSTERED 
(
	[error_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[marca]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[marca](
	[marca_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[marca] [varchar](50) NOT NULL,
 CONSTRAINT [PK_marca] PRIMARY KEY CLUSTERED 
(
	[marca_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[metodo_de_reposicion]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[metodo_de_reposicion](
	[metodo_reposicion_id] [numeric](18, 0) NOT NULL,
	[metodo_de_reposicion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_metodo_de_reposicion] PRIMARY KEY CLUSTERED 
(
	[metodo_reposicion_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[metodo_de_valoracion]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[metodo_de_valoracion](
	[metodo_valoracion_id] [numeric](18, 0) NOT NULL,
	[nombre_metodo] [varchar](200) NOT NULL,
	[descripcion] [varchar](200) NULL,
 CONSTRAINT [PK_metodo_de_valoracion] PRIMARY KEY CLUSTERED 
(
	[metodo_valoracion_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[modulo]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[modulo](
	[modulo_id] [numeric](18, 0) NOT NULL,
	[modulo_nombre] [varchar](50) NOT NULL,
	[modulo_descripcion] [varchar](200) NULL,
	[modulo_url] [varchar](200) NULL,
 CONSTRAINT [PK_modulo] PRIMARY KEY CLUSTERED 
(
	[modulo_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[moneda]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[moneda](
	[moneda_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[moneda] [varchar](50) NOT NULL,
 CONSTRAINT [PK_moneda] PRIMARY KEY CLUSTERED 
(
	[moneda_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[movimiento_de_stock]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[movimiento_de_stock](
	[movimiento_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[deposito_origen_id] [numeric](18, 0) NOT NULL,
	[deposito_destino_id] [numeric](18, 0) NOT NULL,
	[producto_id] [numeric](18, 0) NOT NULL,
	[cantidad] [numeric](18, 0) NOT NULL,
	[fecha] [date] NOT NULL,
	[motivo] [varchar](200) NULL,
	[comprobante] [varbinary](max) NULL,
	[fecha_aceptacion] [date] NULL,
	[empleado_id] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_movimiento_de_stock] PRIMARY KEY CLUSTERED 
(
	[movimiento_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[movimiento_de_stock_instancia_de_producto_xref]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[movimiento_de_stock_instancia_de_producto_xref](
	[movimiento_id] [numeric](18, 0) NOT NULL,
	[instancia_de_producto_id] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_movimiento_de_stock_instancia_de_producto_xref] PRIMARY KEY CLUSTERED 
(
	[movimiento_id] ASC,
	[instancia_de_producto_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[pais]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[pais](
	[pais_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[pais] [varchar](50) NOT NULL,
 CONSTRAINT [PK_pais] PRIMARY KEY CLUSTERED 
(
	[pais_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[pedido_de_reposicion]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[pedido_de_reposicion](
	[pedido_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[flag_completado] [bit] NOT NULL,
	[producto_id] [numeric](18, 0) NOT NULL,
	[deposito_id] [numeric](18, 0) NOT NULL,
	[cantidad] [int] NOT NULL,
	[comprobante] [varbinary](max) NULL,
	[fecha] [date] NOT NULL,
	[empleado_id] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_pedido_de_reposicion] PRIMARY KEY CLUSTERED 
(
	[pedido_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Permiso]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Permiso](
	[permiso_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[permiso_nombre] [varchar](50) NOT NULL,
	[permiso_descripcion] [varchar](200) NULL,
 CONSTRAINT [PK_Permiso] PRIMARY KEY CLUSTERED 
(
	[permiso_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[permiso_rol_xref]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permiso_rol_xref](
	[permiso_id] [numeric](18, 0) NOT NULL,
	[rol_id] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_permiso_rol_xref] PRIMARY KEY CLUSTERED 
(
	[permiso_id] ASC,
	[rol_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Persona]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Persona](
	[persona_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NULL,
	[apellido] [varchar](100) NULL,
	[nro_documento] [varchar](50) NULL,
	[tipo_documento_id] [numeric](18, 0) NULL,
	[contacto_id] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[persona_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Producto](
	[producto_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[nombre_producto] [varchar](200) NOT NULL,
	[descripcion_producto] [varchar](500) NULL,
	[precio_venta] [numeric](18, 2) NULL,
	[moneda_id] [numeric](18, 0) NOT NULL,
	[marca_id] [numeric](18, 0) NOT NULL,
	[estado_producto_id] [numeric](18, 0) NOT NULL,
	[precio_compra] [numeric](18, 2) NOT NULL,
	[clasificacion_id] [numeric](18, 0) NOT NULL,
	[regla_de_composicion] [varchar](1000) NULL,
	[porcentaje_de_ganancia] [numeric](18, 2) NULL,
	[metodo_valoracion_id] [numeric](18, 0) NOT NULL,
	[precio_coste_adquisicion] [numeric](18, 2) NULL,
	[coste_posesion] [numeric](18, 2) NULL,
	[coste_financiero] [numeric](18, 2) NULL,
	[descuento_global_id] [numeric](18, 0) NOT NULL,
	[costo_estandar] [numeric](18, 2) NULL,
	[precio_ultima_compra] [numeric](18, 2) NULL,
	[metodo_de_reposicion_id] [numeric](18, 0) NOT NULL,
	[punto_de_reposicion_minimo] [int] NULL,
	[punto_de_reposicion_maximo] [int] NULL,
	[ciclo] [int] NULL,
	[familia_de_producto_id] [numeric](18, 0) NULL,
	[unidad] [varchar](10) NULL,
	[pedido_automatico] [bit] NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[producto_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[producto_proveedor_xref]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[producto_proveedor_xref](
	[producto_proveedor_xref_id] [int] IDENTITY(1,1) NOT NULL,
	[producto_id] [numeric](18, 0) NOT NULL,
	[proveedor_id] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_producto_proveedor_xref] PRIMARY KEY CLUSTERED 
(
	[producto_proveedor_xref_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[proveedor]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[proveedor](
	[proveedor_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[proveedor_nombre] [varchar](100) NOT NULL,
	[cuit] [varchar](20) NOT NULL,
	[proveedor_estado_id] [int] NOT NULL,
	[flag_eliminado] [bit] NOT NULL,
	[contacto_id] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_proveedor] PRIMARY KEY CLUSTERED 
(
	[proveedor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[provincia]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[provincia](
	[provincia_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[provincia] [varchar](50) NOT NULL,
	[pais_id] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_provincia] PRIMARY KEY CLUSTERED 
(
	[provincia_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[puesto_empleado]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[puesto_empleado](
	[puesto_empleado_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[puesto_empleado] [varchar](200) NOT NULL,
	[codigo_identificador] [varchar](4) NULL,
 CONSTRAINT [PK_puesto_empleado] PRIMARY KEY CLUSTERED 
(
	[puesto_empleado_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[rol]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[rol](
	[rol_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[rol] [varchar](30) NOT NULL,
	[rol_descripcion] [varchar](300) NULL,
	[modulo_id] [numeric](18, 0) NOT NULL,
	[verificador_horizontal] [numeric](25, 0) NULL,
 CONSTRAINT [PK_rol] PRIMARY KEY CLUSTERED 
(
	[rol_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[sucursal]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sucursal](
	[sucursal_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[estado_sucursal_id] [int] NOT NULL,
	[horario_inicio_actividad] [varchar](5) NULL,
	[horario_cierre_actividad] [varchar](5) NULL,
	[fecha_apertura] [date] NULL,
	[fecha_cierre] [date] NULL,
	[contacto_id] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_sucursal] PRIMARY KEY CLUSTERED 
(
	[sucursal_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[sucursal_deposito_xref]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sucursal_deposito_xref](
	[sucursal_id] [numeric](18, 0) NOT NULL,
	[deposito_id] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_sucursal_deposito_xref] PRIMARY KEY CLUSTERED 
(
	[sucursal_id] ASC,
	[deposito_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[telefono]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[telefono](
	[telefono_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[tipo_telefono_id] [numeric](18, 0) NOT NULL,
	[telefono] [varchar](30) NOT NULL,
 CONSTRAINT [PK_telefono] PRIMARY KEY CLUSTERED 
(
	[telefono_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[telefono_contacto_xref]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[telefono_contacto_xref](
	[telefono_id] [numeric](18, 0) NOT NULL,
	[contacto_id] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_telefono_contacto_xref] PRIMARY KEY CLUSTERED 
(
	[telefono_id] ASC,
	[contacto_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tipo_documento]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipo_documento](
	[tipo_documento_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[tipo_documento] [varchar](5) NOT NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_tipo_documento] PRIMARY KEY CLUSTERED 
(
	[tipo_documento_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipo_excepcion]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipo_excepcion](
	[tipo_excepcion_id] [numeric](18, 0) NOT NULL,
	[tipo_excepcion] [varchar](300) NOT NULL,
 CONSTRAINT [PK_tipo_excepcion] PRIMARY KEY CLUSTERED 
(
	[tipo_excepcion_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipo_telefono]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipo_telefono](
	[tipo_telefono_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[tipo_telefono] [varchar](10) NOT NULL,
 CONSTRAINT [PK_tipo_telefono] PRIMARY KEY CLUSTERED 
(
	[tipo_telefono_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuario_empleado_xref]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario_empleado_xref](
	[usuario_id] [numeric](18, 0) NOT NULL,
	[empleado_id] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_usuario_empleado_xref] PRIMARY KEY CLUSTERED 
(
	[usuario_id] ASC,
	[empleado_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[usuario_grupo]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuario_grupo](
	[usuario_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[nombre_usuario] [varchar](200) NOT NULL,
	[password] [varchar](200) NULL,
	[pregunta_secreta] [varchar](200) NULL,
	[respuesta_secreta] [varchar](200) NULL,
	[contador_mala_password] [int] NULL,
	[bloqueado] [bit] NULL,
	[verificador_horizontal] [numeric](25, 0) NULL,
	[flag_eliminado] [bit] NULL,
 CONSTRAINT [PK_usuario_grupo] PRIMARY KEY CLUSTERED 
(
	[usuario_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuario_grupo_xref]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario_grupo_xref](
	[usuario_id] [numeric](18, 0) NOT NULL,
	[grupo_id] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_usuario_grupo_xref] PRIMARY KEY CLUSTERED 
(
	[usuario_id] ASC,
	[grupo_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[usuario_historico]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuario_historico](
	[usuario_id] [numeric](18, 0) NULL,
	[nombre_usuario] [varchar](200) NULL,
	[historico_id] [numeric](18, 0) NOT NULL,
	[password] [varchar](200) NULL,
	[pregunta_secreta] [varchar](200) NULL,
	[respuesta_secreta] [varchar](200) NULL,
	[contador_mala_password] [int] NULL,
	[bloqueado] [bit] NULL,
	[verificador_horizontal] [numeric](25, 0) NULL,
	[fecha] [date] NULL,
 CONSTRAINT [PK_usuario_historico] PRIMARY KEY CLUSTERED 
(
	[historico_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Verificador_vertical]    Script Date: 03/08/2015 11:14:07 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Verificador_vertical](
	[verificador] [numeric](25, 0) NOT NULL,
	[Entidad] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Verificador_vertical_1] PRIMARY KEY CLUSTERED 
(
	[Entidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_accion_comando_xref] FOREIGN KEY([evento_id])
REFERENCES [dbo].[accion_comando_xref] ([accion_comando_xref_id])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_accion_comando_xref]
GO
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_usuario_grupo] FOREIGN KEY([usuario_id])
REFERENCES [dbo].[usuario_grupo] ([usuario_id])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_usuario_grupo]
GO
ALTER TABLE [dbo].[contacto]  WITH CHECK ADD  CONSTRAINT [FK_contacto_localidad] FOREIGN KEY([localidad_id])
REFERENCES [dbo].[localidad] ([localidad_id])
GO
ALTER TABLE [dbo].[contacto] CHECK CONSTRAINT [FK_contacto_localidad]
GO
ALTER TABLE [dbo].[deposito_instancia_producto_xref]  WITH CHECK ADD  CONSTRAINT [FK_deposito_instancia_producto_xref_deposito] FOREIGN KEY([deposito_id])
REFERENCES [dbo].[deposito] ([deposito_id])
GO
ALTER TABLE [dbo].[deposito_instancia_producto_xref] CHECK CONSTRAINT [FK_deposito_instancia_producto_xref_deposito]
GO
ALTER TABLE [dbo].[deposito_instancia_producto_xref]  WITH CHECK ADD  CONSTRAINT [FK_deposito_instancia_producto_xref_instancia_producto] FOREIGN KEY([instancia_productp_id])
REFERENCES [dbo].[instancia_producto] ([instancia_producto_id])
GO
ALTER TABLE [dbo].[deposito_instancia_producto_xref] CHECK CONSTRAINT [FK_deposito_instancia_producto_xref_instancia_producto]
GO
ALTER TABLE [dbo].[descuento_instancia_producto_xref]  WITH CHECK ADD  CONSTRAINT [FK_descuento_instancia_producto_xref_descuento] FOREIGN KEY([descuento_id])
REFERENCES [dbo].[descuento] ([descuento_id])
GO
ALTER TABLE [dbo].[descuento_instancia_producto_xref] CHECK CONSTRAINT [FK_descuento_instancia_producto_xref_descuento]
GO
ALTER TABLE [dbo].[descuento_instancia_producto_xref]  WITH CHECK ADD  CONSTRAINT [FK_descuento_instancia_producto_xref_instancia_producto] FOREIGN KEY([instancia_producto_id])
REFERENCES [dbo].[instancia_producto] ([instancia_producto_id])
GO
ALTER TABLE [dbo].[descuento_instancia_producto_xref] CHECK CONSTRAINT [FK_descuento_instancia_producto_xref_instancia_producto]
GO
ALTER TABLE [dbo].[egreso_de_stock]  WITH CHECK ADD  CONSTRAINT [FK_egreso_de_stock_deposito] FOREIGN KEY([deposito_id])
REFERENCES [dbo].[deposito] ([deposito_id])
GO
ALTER TABLE [dbo].[egreso_de_stock] CHECK CONSTRAINT [FK_egreso_de_stock_deposito]
GO
ALTER TABLE [dbo].[egreso_de_stock]  WITH CHECK ADD  CONSTRAINT [FK_egreso_de_stock_empleado] FOREIGN KEY([empleado_id])
REFERENCES [dbo].[empleado] ([empleado_id])
GO
ALTER TABLE [dbo].[egreso_de_stock] CHECK CONSTRAINT [FK_egreso_de_stock_empleado]
GO
ALTER TABLE [dbo].[egreso_de_stock]  WITH CHECK ADD  CONSTRAINT [FK_egreso_de_stock_empleado1] FOREIGN KEY([empleado_id])
REFERENCES [dbo].[empleado] ([empleado_id])
GO
ALTER TABLE [dbo].[egreso_de_stock] CHECK CONSTRAINT [FK_egreso_de_stock_empleado1]
GO
ALTER TABLE [dbo].[egreso_de_stock]  WITH CHECK ADD  CONSTRAINT [FK_egreso_de_stock_Producto] FOREIGN KEY([producto_id])
REFERENCES [dbo].[Producto] ([producto_id])
GO
ALTER TABLE [dbo].[egreso_de_stock] CHECK CONSTRAINT [FK_egreso_de_stock_Producto]
GO
ALTER TABLE [dbo].[egreso_de_stock_instancia_de_producto_xref]  WITH CHECK ADD  CONSTRAINT [FK_egreso_de_stock_instancia_de_producto_xref_egreso_de_stock] FOREIGN KEY([egreso_id])
REFERENCES [dbo].[egreso_de_stock] ([egreso_id])
GO
ALTER TABLE [dbo].[egreso_de_stock_instancia_de_producto_xref] CHECK CONSTRAINT [FK_egreso_de_stock_instancia_de_producto_xref_egreso_de_stock]
GO
ALTER TABLE [dbo].[egreso_de_stock_instancia_de_producto_xref]  WITH CHECK ADD  CONSTRAINT [FK_egreso_de_stock_instancia_de_producto_xref_instancia_producto] FOREIGN KEY([instancia_de_producto_id])
REFERENCES [dbo].[instancia_producto] ([instancia_producto_id])
GO
ALTER TABLE [dbo].[egreso_de_stock_instancia_de_producto_xref] CHECK CONSTRAINT [FK_egreso_de_stock_instancia_de_producto_xref_instancia_producto]
GO
ALTER TABLE [dbo].[elementos_de_Idioma]  WITH CHECK ADD  CONSTRAINT [FK_ElementosDeIdioma_elemento] FOREIGN KEY([elemento_id])
REFERENCES [dbo].[elemento] ([elemento_id])
GO
ALTER TABLE [dbo].[elementos_de_Idioma] CHECK CONSTRAINT [FK_ElementosDeIdioma_elemento]
GO
ALTER TABLE [dbo].[elementos_de_Idioma]  WITH CHECK ADD  CONSTRAINT [FK_ElementosDeIdioma_Idioma] FOREIGN KEY([idioma_id])
REFERENCES [dbo].[Idioma] ([idioma_id])
GO
ALTER TABLE [dbo].[elementos_de_Idioma] CHECK CONSTRAINT [FK_ElementosDeIdioma_Idioma]
GO
ALTER TABLE [dbo].[empleado]  WITH CHECK ADD  CONSTRAINT [FK_empleado_Persona] FOREIGN KEY([persona_id])
REFERENCES [dbo].[Persona] ([persona_id])
GO
ALTER TABLE [dbo].[empleado] CHECK CONSTRAINT [FK_empleado_Persona]
GO
ALTER TABLE [dbo].[empleado]  WITH CHECK ADD  CONSTRAINT [FK_empleado_puesto_empleado] FOREIGN KEY([puesto_empleado_id])
REFERENCES [dbo].[puesto_empleado] ([puesto_empleado_id])
GO
ALTER TABLE [dbo].[empleado] CHECK CONSTRAINT [FK_empleado_puesto_empleado]
GO
ALTER TABLE [dbo].[empleado_deposito_xref]  WITH CHECK ADD  CONSTRAINT [FK_empleado_reposito_xref_deposito] FOREIGN KEY([deposito_id])
REFERENCES [dbo].[deposito] ([deposito_id])
GO
ALTER TABLE [dbo].[empleado_deposito_xref] CHECK CONSTRAINT [FK_empleado_reposito_xref_deposito]
GO
ALTER TABLE [dbo].[empleado_deposito_xref]  WITH CHECK ADD  CONSTRAINT [FK_empleado_reposito_xref_empleado] FOREIGN KEY([empleado_id])
REFERENCES [dbo].[empleado] ([empleado_id])
GO
ALTER TABLE [dbo].[empleado_deposito_xref] CHECK CONSTRAINT [FK_empleado_reposito_xref_empleado]
GO
ALTER TABLE [dbo].[facturas_de_proveedor]  WITH CHECK ADD  CONSTRAINT [FK_facturas_de_proveedor_Ingreso_de_stock] FOREIGN KEY([ingreso_id])
REFERENCES [dbo].[Ingreso_de_stock] ([ingreso_id])
GO
ALTER TABLE [dbo].[facturas_de_proveedor] CHECK CONSTRAINT [FK_facturas_de_proveedor_Ingreso_de_stock]
GO
ALTER TABLE [dbo].[facturas_de_proveedor]  WITH CHECK ADD  CONSTRAINT [FK_facturas_de_proveedor_proveedor] FOREIGN KEY([proveedor_id])
REFERENCES [dbo].[proveedor] ([proveedor_id])
GO
ALTER TABLE [dbo].[facturas_de_proveedor] CHECK CONSTRAINT [FK_facturas_de_proveedor_proveedor]
GO
ALTER TABLE [dbo].[grupo_rol_xref]  WITH CHECK ADD  CONSTRAINT [FK_grupo_rol_xref_rol] FOREIGN KEY([rol_id])
REFERENCES [dbo].[rol] ([rol_id])
GO
ALTER TABLE [dbo].[grupo_rol_xref] CHECK CONSTRAINT [FK_grupo_rol_xref_rol]
GO
ALTER TABLE [dbo].[grupo_rol_xref]  WITH CHECK ADD  CONSTRAINT [FK_grupo_rol_xref_usuario_grupo1] FOREIGN KEY([grupo_id])
REFERENCES [dbo].[usuario_grupo] ([usuario_id])
GO
ALTER TABLE [dbo].[grupo_rol_xref] CHECK CONSTRAINT [FK_grupo_rol_xref_usuario_grupo1]
GO
ALTER TABLE [dbo].[Ingreso_de_stock]  WITH CHECK ADD  CONSTRAINT [FK_Ingreso_de_stock_deposito] FOREIGN KEY([deposito_id])
REFERENCES [dbo].[deposito] ([deposito_id])
GO
ALTER TABLE [dbo].[Ingreso_de_stock] CHECK CONSTRAINT [FK_Ingreso_de_stock_deposito]
GO
ALTER TABLE [dbo].[Ingreso_de_stock]  WITH CHECK ADD  CONSTRAINT [FK_Ingreso_de_stock_empleado] FOREIGN KEY([empleado_id])
REFERENCES [dbo].[empleado] ([empleado_id])
GO
ALTER TABLE [dbo].[Ingreso_de_stock] CHECK CONSTRAINT [FK_Ingreso_de_stock_empleado]
GO
ALTER TABLE [dbo].[Ingreso_de_stock]  WITH CHECK ADD  CONSTRAINT [FK_Ingreso_de_stock_pedido_de_reposicion] FOREIGN KEY([pedido_de_reposicion_id])
REFERENCES [dbo].[pedido_de_reposicion] ([pedido_id])
GO
ALTER TABLE [dbo].[Ingreso_de_stock] CHECK CONSTRAINT [FK_Ingreso_de_stock_pedido_de_reposicion]
GO
ALTER TABLE [dbo].[Ingreso_de_stock]  WITH CHECK ADD  CONSTRAINT [FK_Ingreso_de_stock_Producto] FOREIGN KEY([producto_id])
REFERENCES [dbo].[Producto] ([producto_id])
GO
ALTER TABLE [dbo].[Ingreso_de_stock] CHECK CONSTRAINT [FK_Ingreso_de_stock_Producto]
GO
ALTER TABLE [dbo].[Ingreso_de_stock]  WITH CHECK ADD  CONSTRAINT [FK_Ingreso_de_stock_Producto1] FOREIGN KEY([producto_id])
REFERENCES [dbo].[Producto] ([producto_id])
GO
ALTER TABLE [dbo].[Ingreso_de_stock] CHECK CONSTRAINT [FK_Ingreso_de_stock_Producto1]
GO
ALTER TABLE [dbo].[instancia_producto]  WITH CHECK ADD  CONSTRAINT [FK_instancia_producto_deposito] FOREIGN KEY([deposito_id])
REFERENCES [dbo].[deposito] ([deposito_id])
GO
ALTER TABLE [dbo].[instancia_producto] CHECK CONSTRAINT [FK_instancia_producto_deposito]
GO
ALTER TABLE [dbo].[instancia_producto]  WITH CHECK ADD  CONSTRAINT [FK_instancia_producto_estado_instancia_producto] FOREIGN KEY([estado_inst_prod_id])
REFERENCES [dbo].[estado_instancia_producto] ([estado_inst_prod_id])
GO
ALTER TABLE [dbo].[instancia_producto] CHECK CONSTRAINT [FK_instancia_producto_estado_instancia_producto]
GO
ALTER TABLE [dbo].[instancia_producto]  WITH CHECK ADD  CONSTRAINT [FK_instancia_producto_Ingreso_de_stock] FOREIGN KEY([ingreso_id])
REFERENCES [dbo].[Ingreso_de_stock] ([ingreso_id])
GO
ALTER TABLE [dbo].[instancia_producto] CHECK CONSTRAINT [FK_instancia_producto_Ingreso_de_stock]
GO
ALTER TABLE [dbo].[instancia_producto]  WITH CHECK ADD  CONSTRAINT [FK_instancia_producto_Producto] FOREIGN KEY([producto_id])
REFERENCES [dbo].[Producto] ([producto_id])
GO
ALTER TABLE [dbo].[instancia_producto] CHECK CONSTRAINT [FK_instancia_producto_Producto]
GO
ALTER TABLE [dbo].[localidad]  WITH CHECK ADD  CONSTRAINT [FK_localidad_provincia] FOREIGN KEY([localidad_id])
REFERENCES [dbo].[provincia] ([provincia_id])
GO
ALTER TABLE [dbo].[localidad] CHECK CONSTRAINT [FK_localidad_provincia]
GO
ALTER TABLE [dbo].[log_de_errores]  WITH CHECK ADD  CONSTRAINT [FK_log_de_errores_tipo_excepcion] FOREIGN KEY([tipo_exepcion_id])
REFERENCES [dbo].[tipo_excepcion] ([tipo_excepcion_id])
GO
ALTER TABLE [dbo].[log_de_errores] CHECK CONSTRAINT [FK_log_de_errores_tipo_excepcion]
GO
ALTER TABLE [dbo].[movimiento_de_stock]  WITH CHECK ADD  CONSTRAINT [FK_movimiento_de_stock_deposito] FOREIGN KEY([deposito_origen_id])
REFERENCES [dbo].[deposito] ([deposito_id])
GO
ALTER TABLE [dbo].[movimiento_de_stock] CHECK CONSTRAINT [FK_movimiento_de_stock_deposito]
GO
ALTER TABLE [dbo].[movimiento_de_stock]  WITH CHECK ADD  CONSTRAINT [FK_movimiento_de_stock_deposito1] FOREIGN KEY([deposito_destino_id])
REFERENCES [dbo].[deposito] ([deposito_id])
GO
ALTER TABLE [dbo].[movimiento_de_stock] CHECK CONSTRAINT [FK_movimiento_de_stock_deposito1]
GO
ALTER TABLE [dbo].[movimiento_de_stock]  WITH CHECK ADD  CONSTRAINT [FK_movimiento_de_stock_Producto] FOREIGN KEY([producto_id])
REFERENCES [dbo].[Producto] ([producto_id])
GO
ALTER TABLE [dbo].[movimiento_de_stock] CHECK CONSTRAINT [FK_movimiento_de_stock_Producto]
GO
ALTER TABLE [dbo].[movimiento_de_stock_instancia_de_producto_xref]  WITH CHECK ADD  CONSTRAINT [FK_movimiento_de_stock_instancia_de_producto_xref_instancia_producto] FOREIGN KEY([instancia_de_producto_id])
REFERENCES [dbo].[instancia_producto] ([instancia_producto_id])
GO
ALTER TABLE [dbo].[movimiento_de_stock_instancia_de_producto_xref] CHECK CONSTRAINT [FK_movimiento_de_stock_instancia_de_producto_xref_instancia_producto]
GO
ALTER TABLE [dbo].[movimiento_de_stock_instancia_de_producto_xref]  WITH CHECK ADD  CONSTRAINT [FK_movimiento_de_stock_instancia_de_producto_xref_movimiento_de_stock] FOREIGN KEY([movimiento_id])
REFERENCES [dbo].[movimiento_de_stock] ([movimiento_id])
GO
ALTER TABLE [dbo].[movimiento_de_stock_instancia_de_producto_xref] CHECK CONSTRAINT [FK_movimiento_de_stock_instancia_de_producto_xref_movimiento_de_stock]
GO
ALTER TABLE [dbo].[pedido_de_reposicion]  WITH CHECK ADD  CONSTRAINT [FK_pedido_de_reposicion_deposito] FOREIGN KEY([deposito_id])
REFERENCES [dbo].[deposito] ([deposito_id])
GO
ALTER TABLE [dbo].[pedido_de_reposicion] CHECK CONSTRAINT [FK_pedido_de_reposicion_deposito]
GO
ALTER TABLE [dbo].[pedido_de_reposicion]  WITH CHECK ADD  CONSTRAINT [FK_pedido_de_reposicion_empleado] FOREIGN KEY([empleado_id])
REFERENCES [dbo].[empleado] ([empleado_id])
GO
ALTER TABLE [dbo].[pedido_de_reposicion] CHECK CONSTRAINT [FK_pedido_de_reposicion_empleado]
GO
ALTER TABLE [dbo].[pedido_de_reposicion]  WITH CHECK ADD  CONSTRAINT [FK_pedido_de_reposicion_Producto] FOREIGN KEY([producto_id])
REFERENCES [dbo].[Producto] ([producto_id])
GO
ALTER TABLE [dbo].[pedido_de_reposicion] CHECK CONSTRAINT [FK_pedido_de_reposicion_Producto]
GO
ALTER TABLE [dbo].[permiso_rol_xref]  WITH CHECK ADD  CONSTRAINT [FK_permiso_rol_xref_Permiso] FOREIGN KEY([permiso_id])
REFERENCES [dbo].[Permiso] ([permiso_id])
GO
ALTER TABLE [dbo].[permiso_rol_xref] CHECK CONSTRAINT [FK_permiso_rol_xref_Permiso]
GO
ALTER TABLE [dbo].[permiso_rol_xref]  WITH CHECK ADD  CONSTRAINT [FK_permiso_rol_xref_rol] FOREIGN KEY([rol_id])
REFERENCES [dbo].[rol] ([rol_id])
GO
ALTER TABLE [dbo].[permiso_rol_xref] CHECK CONSTRAINT [FK_permiso_rol_xref_rol]
GO
ALTER TABLE [dbo].[Persona]  WITH CHECK ADD  CONSTRAINT [FK_Persona_contacto1] FOREIGN KEY([contacto_id])
REFERENCES [dbo].[contacto] ([contacto_id])
GO
ALTER TABLE [dbo].[Persona] CHECK CONSTRAINT [FK_Persona_contacto1]
GO
ALTER TABLE [dbo].[Persona]  WITH CHECK ADD  CONSTRAINT [FK_Persona_tipo_documento] FOREIGN KEY([tipo_documento_id])
REFERENCES [dbo].[tipo_documento] ([tipo_documento_id])
GO
ALTER TABLE [dbo].[Persona] CHECK CONSTRAINT [FK_Persona_tipo_documento]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_clasificacion_de_producto] FOREIGN KEY([clasificacion_id])
REFERENCES [dbo].[clasificacion_de_producto] ([clasificacion_id])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_clasificacion_de_producto]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_descuento] FOREIGN KEY([descuento_global_id])
REFERENCES [dbo].[descuento] ([descuento_id])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_descuento]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_estado_producto] FOREIGN KEY([estado_producto_id])
REFERENCES [dbo].[estado_producto] ([estado_producto_id])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_estado_producto]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_marca] FOREIGN KEY([marca_id])
REFERENCES [dbo].[marca] ([marca_id])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_marca]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_metodo_de_reposicion] FOREIGN KEY([metodo_de_reposicion_id])
REFERENCES [dbo].[metodo_de_reposicion] ([metodo_reposicion_id])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_metodo_de_reposicion]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_metodo_de_valoracion] FOREIGN KEY([metodo_valoracion_id])
REFERENCES [dbo].[metodo_de_valoracion] ([metodo_valoracion_id])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_metodo_de_valoracion]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_moneda] FOREIGN KEY([moneda_id])
REFERENCES [dbo].[moneda] ([moneda_id])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_moneda]
GO
ALTER TABLE [dbo].[producto_proveedor_xref]  WITH CHECK ADD  CONSTRAINT [FK_producto_proveedor_xref_Producto] FOREIGN KEY([producto_id])
REFERENCES [dbo].[Producto] ([producto_id])
GO
ALTER TABLE [dbo].[producto_proveedor_xref] CHECK CONSTRAINT [FK_producto_proveedor_xref_Producto]
GO
ALTER TABLE [dbo].[producto_proveedor_xref]  WITH CHECK ADD  CONSTRAINT [FK_producto_proveedor_xref_proveedor] FOREIGN KEY([proveedor_id])
REFERENCES [dbo].[proveedor] ([proveedor_id])
GO
ALTER TABLE [dbo].[producto_proveedor_xref] CHECK CONSTRAINT [FK_producto_proveedor_xref_proveedor]
GO
ALTER TABLE [dbo].[proveedor]  WITH CHECK ADD  CONSTRAINT [FK_proveedor_contacto1] FOREIGN KEY([contacto_id])
REFERENCES [dbo].[contacto] ([contacto_id])
GO
ALTER TABLE [dbo].[proveedor] CHECK CONSTRAINT [FK_proveedor_contacto1]
GO
ALTER TABLE [dbo].[proveedor]  WITH CHECK ADD  CONSTRAINT [FK_proveedor_estado_proveedor] FOREIGN KEY([proveedor_estado_id])
REFERENCES [dbo].[estado_proveedor] ([estado_proveedor_id])
GO
ALTER TABLE [dbo].[proveedor] CHECK CONSTRAINT [FK_proveedor_estado_proveedor]
GO
ALTER TABLE [dbo].[provincia]  WITH CHECK ADD  CONSTRAINT [FK_provincia_pais] FOREIGN KEY([pais_id])
REFERENCES [dbo].[pais] ([pais_id])
GO
ALTER TABLE [dbo].[provincia] CHECK CONSTRAINT [FK_provincia_pais]
GO
ALTER TABLE [dbo].[rol]  WITH CHECK ADD  CONSTRAINT [FK_rol_modulo] FOREIGN KEY([modulo_id])
REFERENCES [dbo].[modulo] ([modulo_id])
GO
ALTER TABLE [dbo].[rol] CHECK CONSTRAINT [FK_rol_modulo]
GO
ALTER TABLE [dbo].[sucursal]  WITH CHECK ADD  CONSTRAINT [FK_sucursal_contacto] FOREIGN KEY([contacto_id])
REFERENCES [dbo].[contacto] ([contacto_id])
GO
ALTER TABLE [dbo].[sucursal] CHECK CONSTRAINT [FK_sucursal_contacto]
GO
ALTER TABLE [dbo].[sucursal]  WITH CHECK ADD  CONSTRAINT [FK_sucursal_contacto1] FOREIGN KEY([contacto_id])
REFERENCES [dbo].[contacto] ([contacto_id])
GO
ALTER TABLE [dbo].[sucursal] CHECK CONSTRAINT [FK_sucursal_contacto1]
GO
ALTER TABLE [dbo].[sucursal]  WITH CHECK ADD  CONSTRAINT [FK_sucursal_estado_sucursal] FOREIGN KEY([estado_sucursal_id])
REFERENCES [dbo].[estado_sucursal] ([estado_sucursal_id])
GO
ALTER TABLE [dbo].[sucursal] CHECK CONSTRAINT [FK_sucursal_estado_sucursal]
GO
ALTER TABLE [dbo].[sucursal_deposito_xref]  WITH CHECK ADD  CONSTRAINT [FK_sucursal_deposito_xref_deposito] FOREIGN KEY([deposito_id])
REFERENCES [dbo].[deposito] ([deposito_id])
GO
ALTER TABLE [dbo].[sucursal_deposito_xref] CHECK CONSTRAINT [FK_sucursal_deposito_xref_deposito]
GO
ALTER TABLE [dbo].[sucursal_deposito_xref]  WITH CHECK ADD  CONSTRAINT [FK_sucursal_deposito_xref_sucursal] FOREIGN KEY([sucursal_id])
REFERENCES [dbo].[sucursal] ([sucursal_id])
GO
ALTER TABLE [dbo].[sucursal_deposito_xref] CHECK CONSTRAINT [FK_sucursal_deposito_xref_sucursal]
GO
ALTER TABLE [dbo].[telefono]  WITH CHECK ADD  CONSTRAINT [FK_telefono_tipo_telefono] FOREIGN KEY([tipo_telefono_id])
REFERENCES [dbo].[tipo_telefono] ([tipo_telefono_id])
GO
ALTER TABLE [dbo].[telefono] CHECK CONSTRAINT [FK_telefono_tipo_telefono]
GO
ALTER TABLE [dbo].[telefono_contacto_xref]  WITH CHECK ADD  CONSTRAINT [FK_telefono_contacto_xref_contacto] FOREIGN KEY([contacto_id])
REFERENCES [dbo].[contacto] ([contacto_id])
GO
ALTER TABLE [dbo].[telefono_contacto_xref] CHECK CONSTRAINT [FK_telefono_contacto_xref_contacto]
GO
ALTER TABLE [dbo].[telefono_contacto_xref]  WITH CHECK ADD  CONSTRAINT [FK_telefono_contacto_xref_telefono] FOREIGN KEY([telefono_id])
REFERENCES [dbo].[telefono] ([telefono_id])
GO
ALTER TABLE [dbo].[telefono_contacto_xref] CHECK CONSTRAINT [FK_telefono_contacto_xref_telefono]
GO
ALTER TABLE [dbo].[usuario_empleado_xref]  WITH CHECK ADD  CONSTRAINT [FK_usuario_empleado_xref_empleado] FOREIGN KEY([empleado_id])
REFERENCES [dbo].[empleado] ([empleado_id])
GO
ALTER TABLE [dbo].[usuario_empleado_xref] CHECK CONSTRAINT [FK_usuario_empleado_xref_empleado]
GO
ALTER TABLE [dbo].[usuario_empleado_xref]  WITH CHECK ADD  CONSTRAINT [FK_usuario_empleado_xref_usuario_grupo] FOREIGN KEY([usuario_id])
REFERENCES [dbo].[usuario_grupo] ([usuario_id])
GO
ALTER TABLE [dbo].[usuario_empleado_xref] CHECK CONSTRAINT [FK_usuario_empleado_xref_usuario_grupo]
GO
ALTER TABLE [dbo].[usuario_grupo_xref]  WITH CHECK ADD  CONSTRAINT [FK_usuario_grupo_xref_usuario_grupo2] FOREIGN KEY([usuario_id])
REFERENCES [dbo].[usuario_grupo] ([usuario_id])
GO
ALTER TABLE [dbo].[usuario_grupo_xref] CHECK CONSTRAINT [FK_usuario_grupo_xref_usuario_grupo2]
GO
ALTER TABLE [dbo].[usuario_grupo_xref]  WITH CHECK ADD  CONSTRAINT [FK_usuario_grupo_xref_usuario_grupo3] FOREIGN KEY([grupo_id])
REFERENCES [dbo].[usuario_grupo] ([usuario_id])
GO
ALTER TABLE [dbo].[usuario_grupo_xref] CHECK CONSTRAINT [FK_usuario_grupo_xref_usuario_grupo3]
GO

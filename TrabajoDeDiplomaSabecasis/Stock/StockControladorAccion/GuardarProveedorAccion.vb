Imports StockModelo

Public Class GuardarProveedorAccion
    Implements Accion

    Public Sub New(id As Integer, nombre As String, cuit As String, estado As EstadoProveedor, calle As String, nro As String, piso As Integer, dpto As String, email As String, localidad As Localidad, telefono As String)
        oProveedor.id = id
        oProveedor.estado = estado
        oProveedor.cuit = cuit
        oProveedor.contacto = New Contacto()
        oProveedor.contacto.calle = calle
        oProveedor.contacto.departamento = dpto
        oProveedor.contacto.email = email
        oProveedor.contacto.localidad = localidad
        oProveedor.contacto.nroPuerta = nro
        oProveedor.contacto.piso = piso
        oProveedor.contacto.telefonos = New List(Of Telefono)
        Dim tel As New Telefono()
        tel.telefono = telefono
        oProveedor.contacto.telefonos.Add(tel)
        oProveedor.nombre = nombre
    End Sub

    Property oProveedor As Proveedor = New Proveedor()
End Class

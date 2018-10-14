Imports StockModelo

Public Class GuardarDepositoAccion
    Implements Accion

    Public Sub New(id As Integer, nombre As String, calle As String, nro As String, piso As Integer, departamento As String, email As String, telefono As String, localidad As Localidad)
        Me.id = id
        Me.nombre = nombre
        Me.calle = calle
        Me.departamento = departamento
        Me.piso = piso
        Me.localidad = localidad
        Me.nro = nro
        Me.email = email
        Me.telefono = telefono
    End Sub

    Property id As Integer
    Property nombre As String
    Property calle As String
    Property nro As String
    Property piso As Integer
    Property departamento As String
    Property email As String
    Property telefono As String
    Property localidad As Localidad

End Class

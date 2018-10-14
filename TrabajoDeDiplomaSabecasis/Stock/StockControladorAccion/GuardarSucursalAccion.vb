Imports StockModelo

Public Class GuardarSucursalAccion
	Implements Accion

    Public Sub New(pid As Integer, horIn As String, horci As String, fechApt As Date, fechCir As Date, estado As EstadoSucursal, calle As String, nro As String, piso As Integer, depto As String, email As String, telefono As String, localidad As Localidad, depositos As List(Of Deposito))
        Me.calle = calle
        Me.departamento = depto
        Me.depositos = depositos
        Me.email = email
        Me.estado = estado
        Me.fechaApertura = fechApt
        Me.fechaCierre = fechCir
        Me.horarioCierre = horci
        Me.horarioInicio = horIn
        Me.id = pid
        Me.localidad = localidad
        Me.nroPuerta = nro
        Me.telefono = telefono
    End Sub

    Property id As Integer
    Property horarioInicio As String
    Property horarioCierre As String
    Property fechaApertura As Date
    Property fechaCierre As Date
    Property estado As EstadoSucursal
    Property calle As String
    Property nroPuerta As String
    Property piso As Integer
    Property departamento As String
    Property email As String
    Property telefono As String
    Property localidad As Localidad
    Property depositos As List(Of Deposito)
End Class

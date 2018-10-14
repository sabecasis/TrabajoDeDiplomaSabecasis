Public Class Sucursal
    Property id As Integer = 0
    Property horarioInicio As String
    Property horarioCierre As String
    Property fechaApertura As Date
    Property fechaCierre As Date
    Property estado As EstadoSucursal
    Property contacto As Contacto
    Property depositos As List(Of Deposito)

End Class

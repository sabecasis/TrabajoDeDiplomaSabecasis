'Esta clase tiene todas las constantes utilizadas por el autorizador para referirse a los permisos 
Public Class ConstantesDePermisos

    Public Shared ReadOnly Property ACTUALIZAR() As String
        Get
            Return "ACTUALIZAR"
        End Get
    End Property

    Public Shared ReadOnly Property BACKUP() As String
        Get
            Return "BACKUP"
        End Get
    End Property

    Public Shared ReadOnly Property RESTORE() As String
        Get
            Return "RESTORE"
        End Get
    End Property

    Public Shared ReadOnly Property CREAR() As String
        Get
            Return "CREAR"
        End Get
    End Property
    Public Shared ReadOnly Property ELIMINAR() As String
        Get
            Return "ELIMINAR"
        End Get
    End Property
    Public Shared ReadOnly Property BUSCAR() As String
        Get
            Return "BUSCAR"
        End Get
    End Property
    Public Shared ReadOnly Property ASIGNAR() As String
        Get
            Return "ASIGNAR"
        End Get
    End Property
    Public Shared ReadOnly Property DESASIGNAR() As String
        Get
            Return "DESASIGNAR"
        End Get
    End Property


End Class

Imports StockModelo

Public Class CrearEmpleadoAccion
    Implements Accion

    Public Sub New(empleadoEntidad As Empleado)
        Me.empleado = empleadoEntidad
    End Sub
    Private _empleado As Empleado
    Public Property empleado() As Empleado
        Get
            Return _empleado
        End Get
        Set(ByVal value As Empleado)
            _empleado = value
        End Set
    End Property


End Class

Public Class Funcionalidad
    Public nombre As String

    Public Shared IngresoAlSistema = "Ingreso al sistema"
    Public Shared ErrorDeAcceso = "Error de acceso"
    Public Shared GeneracionCodRecuperacion = "Generacion de codigo de recuperacion"

    Sub New(ByVal nombre As String)
        Me.nombre = nombre
    End Sub
End Class

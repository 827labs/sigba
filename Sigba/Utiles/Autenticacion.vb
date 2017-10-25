Class Autenticacion
    Public Shared usuario As String
    Public Shared clave As String

    Public Shared usuarioATM As Integer
    Public Shared pinATM As Integer
    Public Shared cuentaATM As String

    Public Shared idioma As String

    Public Shared sucursalCajaAbierta As Integer
    Public Shared cajaAbierta As Integer
    Public Shared estadoCaja As Integer

    Public Shared RolAdminstrador = "Administrador"
    Public Shared RolGerente = "Gerente"
    Public Shared RolEjecutivo = "Ejecutivo de cuentas"
    Public Shared RolAuxiliar = "Auxiliar de caja"

    Public Shared Function HayCajaAbierta() As Boolean
        Return sucursalCajaAbierta <> Nothing And cajaAbierta <> Nothing And estadoCaja <> Nothing
    End Function
End Class

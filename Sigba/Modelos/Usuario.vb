Imports System.Data.Odbc

Public Class Usuario
    Public Nombre As String
    Public Apellido As String
    Public NumDocU As Integer
    Public NomUsuarioSOU As String
    Public EmailU As String
    Public Suspendido As String

    Public Sub New(ByVal usuario As String)
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cm = New OdbcCommand
        cm.Connection = cx
        cm.CommandText = String.Format("SELECT NVL(nombre, '') nom, NVL(apellido, '') ape, numdocu, nomusuariosou, emailu, NVL(suspendido, '') sus from usuario WHERE nomusuariosou='{0}'", usuario)
        Dim lector = cm.ExecuteReader()

        Dim existe = False

        While lector.Read()
            existe = True

            Me.Nombre = lector("nom")
            Me.Apellido = lector("ape")
            Me.NumDocU = lector("numdocu")
            Me.NomUsuarioSOU = lector("nomusuariosou")
            Me.EmailU = lector("emailu")
            Me.Suspendido = lector("sus")
        End While

    End Sub

    Public Function EsValido() As Boolean
        ' Retorna True si un usuario ha sido seteado en la instancia
        Return Me.NumDocU > 0
    End Function

    Public Function EstaSuspendido() As Boolean
        Try
            Return Me.Suspendido.Length > 0
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function EsFuncionario() As Boolean
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cm = New OdbcCommand("SELECT COUNT(*) cargos FROM ejerce WHERE numdocu=" & Me.NumDocU, cx)
        Dim cantCargos = cm.ExecuteScalar()

        Return cantCargos <> "0"
    End Function

    Public Function Cargo() As String
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cm = New OdbcCommand("select FIRST 1 c.nombre from cargo as c INNER JOIN ejerce as e ON e.idcargo = c.idcargo where e.numdocu=" & Me.NumDocU, cx)

        Return cm.ExecuteScalar()
    End Function
End Class

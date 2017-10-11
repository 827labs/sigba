Imports System.Data.Odbc

Public Class ConexionBaseDatos
    Shared cxCompartida As OdbcConnection

    Private Shared Function CrearNuevaConexion(ByVal usuario As String, ByVal clave As String) As OdbcConnection
        Dim cx As New OdbcConnection

        cx.ConnectionString = String.Format("FileDsn=C:\sigba.dsn;UID={0};PWD={1}", usuario, clave)

        Try
            cx.Open()
        Catch ex As Exception
            Mensajes.ErrorSimple(String.Format("Ocurrió un error al intentarnos conectar con la base de datos. Asegurese de tiene conexión, que el archivo DSN esté presente en C:\sigba.dsn y que el mismo esté bien configurado. Error: {0}", ex.Message))
            Application.Exit()
        End Try

        Return cx
    End Function

    Shared Function ObtenerActual(Optional ByVal usuario As String = "informix", Optional ByVal clave As String = "informix") As OdbcConnection
        ' Si la conexión nunca fue abierta (Is Nothing) o no está abierta (.Open)
        ' la voy a crear de nuevo o abrirla respectivamente antes de retornarla.
        If (cxCompartida Is Nothing) Then
            cxCompartida = CrearNuevaConexion(usuario, clave)
        End If

        If (cxCompartida.State <> ConnectionState.Open) Then
            cxCompartida.Open()
        End If

        Return cxCompartida
    End Function
End Class


Imports System.Data.Odbc

Public Class ConexionBaseDatos
    Shared cxCompartida As OdbcConnection

    Private Shared Function CrearNuevaConexion(ByVal usuario As String, ByVal clave As String) As OdbcConnection
        Dim cx As New OdbcConnection

        cx.ConnectionString = String.Format("FileDsn=C:\sigba.dsn;UID={0};PWD={1}", usuario, clave)

        Try
            cx.Open()
        Catch ex As Exception
            If ex.Message.Contains("not known on the database server") Then
                Mensajes.ErrorSimple(T("El usuario o contraseña que ingresó no son válidos.", "The credentials you entered are invalid."))
            Else
                Mensajes.ErrorSimple(String.Format(T("Ocurrió un error al intentarnos conectar con la base de datos. Asegurese de tiene conexión, que el archivo DSN esté presente en C:\sigba.dsn y que el mismo esté bien configurado. Error: {0}", "An error occured while trying to connect to the database. Check the DSN file is in C:\ and is well configured. Details: {0}"), ex.Message))
            End If

            Application.Exit()
            Return Nothing
        End Try

        Return cx
    End Function

    Shared Function ObtenerActual(Optional ByVal usuario As String = "", Optional ByVal clave As String = "") As OdbcConnection
        ' Si la conexión nunca fue abierta (Is Nothing) o no está abierta (.Open)
        ' la voy a crear de nuevo o abrirla respectivamente antes de retornarla.

        If Autenticacion.usuario <> Nothing Then
            usuario = Autenticacion.usuario
        End If

        If Autenticacion.clave <> Nothing Then
            clave = Autenticacion.clave
        End If

        If (cxCompartida Is Nothing) Then
            cxCompartida = CrearNuevaConexion(usuario, clave)
        End If
        Try
            If (cxCompartida.State <> ConnectionState.Open) Then
                cxCompartida.Open()
            End If

            Return cxCompartida
        Catch ex As Exception
            Application.Exit()
            Return Nothing
        End Try


    End Function
End Class


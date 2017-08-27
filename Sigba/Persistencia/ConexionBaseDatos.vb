Imports System.Data.Odbc

Public Class ConexionBaseDatos
    Shared cxCompartida As OdbcConnection

    Private Shared Function CrearNuevaConexion() As OdbcConnection
        Dim cx As New OdbcConnection

        cx.ConnectionString = "FileDsn=C:\sigba.dsn;UID=informix;PWD=informix"

        Try
            cx.Open()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al intentarnos conectar con la base de datos.", "Error de datos")
        End Try

        Return cx
    End Function

    Shared Function ObtenerActual() As OdbcConnection
        ' Si la conexión nunca fue abierta (Is Nothing) o no está abierta (.Open)
        ' la voy a crear de nuevo o abrirla respectivamente antes de retornarla.
        If (cxCompartida Is Nothing) Then
            cxCompartida = CrearNuevaConexion()
        End If

        If (cxCompartida.State <> ConnectionState.Open) Then
            cxCompartida.Open()
        End If

        Return cxCompartida
    End Function
End Class


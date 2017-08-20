Imports System.Data.Odbc

Public Module ConexionBaseDatos
    Function ObtenerActual() As OdbcConnection
        Dim cx As New OdbcConnection

        cx.ConnectionString = "FileDsn=C:\sigba.dsn;UID=informix;PWD=informix"

        Try
            cx.Open()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al intentarnos conectar con la base de datos.", "Error de datos")
        End Try

        Return cx
    End Function
End Module


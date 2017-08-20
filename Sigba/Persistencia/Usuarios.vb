Imports System.Data.Odbc

Module Usuarios
    Public Function ValidarUsuario(ByVal cedula As String, ByVal clave As String) As Boolean
        Dim cm As New OdbcCommand
        Dim da As New OdbcDataAdapter
        Dim ds As New DataSet

        cm.Connection = ConexionBaseDatos.ObtenerActual()
        cm.CommandText = "SELECT * FROM usuario WHERE numdocu=" & cedula & " AND claveu='" & clave & "'"
        da = New OdbcDataAdapter(cm)
        da.Fill(ds, "usuario")

        da.Dispose()
        cm.Dispose()

        Dim usuarioEncontrado As Boolean = False
        For Each row In ds.Tables("usuario").Rows
            If (row("numdocu") = cedula) Then
                usuarioEncontrado = True
            End If
        Next

        Return usuarioEncontrado
    End Function
End Module

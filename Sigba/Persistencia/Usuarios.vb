Imports System.Data.Odbc

Module Usuarios
    Public Function ValidarUsuario(ByVal cedula As String, ByVal clave As String) As Boolean
        Dim cm As New OdbcCommand
        Dim ds As New DataSet

        cm.Connection = ConexionBaseDatos.ObtenerActual()
        cm.CommandText = "SELECT numdocu FROM usuario WHERE numdocu=" & cedula & " AND claveu='" & clave & "'"
        Dim da = New OdbcDataAdapter(cm)
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

    Sub ListarUsuarios(ByRef dgv As DataGridView, Optional ByVal cedula As Integer = 0)
        Dim cm As New OdbcCommand
        Dim ds As New DataSet

        cm.Connection = ConexionBaseDatos.ObtenerActual()
        cm.CommandText = "SELECT numdocu, emailu FROM usuario"

        If cedula <> 0 Then
            cm.CommandText = String.Format("SELECT numdocu, emailu FROM usuario WHERE numdocu={0}", cedula)
        End If

        Dim da = New OdbcDataAdapter(cm)
        da.Fill(ds, "usuario")

        da.Dispose()
        cm.Dispose()

        dgv.DataSource = ds.Tables("usuario")
        With dgv
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Cédula"
            .Columns(1).HeaderCell.Value = "Correo electrónico"
        End With
    End Sub
End Module

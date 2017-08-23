Imports System.Data.Odbc

Module Usuarios
    Public Function ValidarUsuario(ByVal cedula As String, ByVal clave As String) As Boolean
        Dim usuario = New Usuario(cedula)

        Return usuario.ClaveU = clave
    End Function

    Sub ListarUsuarios(ByRef dgv As DataGridView, Optional ByVal cedula As Integer = 0)
        Dim cm As New OdbcCommand
        Dim ds As New DataSet

        cm.Connection = ConexionBaseDatos.ObtenerActual()
        cm.CommandText = "SELECT numdocu, emailu, apellido, nombre FROM usuario"

        If cedula <> 0 Then
            cm.CommandText += String.Format(" WHERE numdocu={0}", cedula)
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
            .Columns(2).HeaderCell.Value = "Apellidos"
            .Columns(3).HeaderCell.Value = "Nombres"
        End With
    End Sub
End Module

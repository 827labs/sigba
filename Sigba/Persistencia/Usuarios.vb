Imports System.Data.Odbc

Module Usuarios

    Public Function CrearUsuario(ByVal cedula As Integer, ByVal correo As String, ByVal nombres As String, ByVal apellidos As String) As Integer
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cm As New OdbcCommand
        Dim codInicial = Generadores.CodigoRecuperacionAleatorio()
        cm.Connection = cx
        cm.CommandText = String.Format("INSERT INTO usuario (numdocu, claveu, emailu, codrecuperacionu, nombre, apellido) VALUES ({0}, '{1}', '{2}', {3}, '{4}', '{5}')", cedula, codInicial, correo, codInicial, nombres, apellidos)

        Try
            cm.ExecuteNonQuery()
            Return codInicial
        Catch ex As Exception
            Mensajes.ErrorSimple("Error al crear el usuario. Detalles: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function ValidarUsuario(ByVal cedula As String, ByVal clave As String) As Boolean
        Dim usuario = New Usuario(cedula)

        Return usuario.ClaveU = clave And (Not usuario.EstaSuspendido()) And usuario.EsFuncionario()
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

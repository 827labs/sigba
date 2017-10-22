Imports System.Data.Odbc

Module Usuarios

    Public Function CrearUsuario(ByVal cedula As Integer, ByVal correo As String, ByVal nombres As String, ByVal apellidos As String, ByVal nomUsuarioSOU As String) As Integer
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cm As New OdbcCommand
        cm.Connection = cx
        cm.CommandText = String.Format("INSERT INTO usuario (numdocu, nomusuariosou, emailu, nombre, apellido) VALUES ({0}, '{1}', '{2}', '{3}', '{4}')", cedula, nomUsuarioSOU, correo, nombres, apellidos)

        Try
            cm.ExecuteNonQuery()
            Return 1
        Catch ex As Exception
            Mensajes.ErrorSimple(T("Error al crear el usuario. Detalles: ", "Error while creating the user. Details:") & ex.Message)
            Return False
        End Try
    End Function

    Public Function ValidarUsuario(ByVal nomusuario As String, ByVal clave As String) As Boolean
        Autenticacion.usuario = nomusuario
        Autenticacion.clave = clave
        Dim usuario = New Usuario(nomusuario)

        Dim Condicion = usuario.NomUsuarioSOU = nomusuario And Not usuario.EstaSuspendido()

        If Condicion = False Then
            Autenticacion.usuario = Nothing
            Autenticacion.clave = Nothing
        End If

        Return Condicion
    End Function

    Sub ListarUsuarios(ByRef dgv As DataGridView, Optional ByVal cedula As Integer = 0)
        Dim cm As New OdbcCommand
        Dim ds As New DataSet

        cm.Connection = ConexionBaseDatos.ObtenerActual()
        cm.CommandText = "SELECT numdocu, emailu, apellido, nombre, nomusuariosou, NVL(suspendido, 'No') FROM usuario"

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
            .Columns(0).HeaderCell.Value = T("Cédula", "ID")
            .Columns(1).HeaderCell.Value = T("Correo electrónico", "E-mail address")
            .Columns(2).HeaderCell.Value = T("Apellidos", "Surnames")
            .Columns(3).HeaderCell.Value = T("Nombres", "Names")
            .Columns(4).HeaderCell.Value = T("Nom. Usuario", "Username")
            .Columns(5).HeaderCell.Value = T("Suspendido", "Suspended")
        End With
    End Sub
End Module

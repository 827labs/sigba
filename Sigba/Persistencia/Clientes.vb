Imports System.Data.Odbc

Module Clientes
    Public Enum TipoCliente
        Persona = 0
        Empresa = 1
    End Enum

    Public Function AltaCliente(ByVal CalleDirC As String, ByVal CiudadC As String, ByVal CodPostalC As String, ByVal NroDirC As String, ByVal TelefonoC As String, ByVal BlockDirC As String, ByVal ApDirC As String, ByVal AclaracionDirC As String) As Integer
        Dim cx = ConexionBaseDatos.ObtenerActual()

        ' Insertar cliente
        Dim sql = String.Format("INSERT INTO cliente (calledirc, ciudadc, codpostalc, nrodirc, telefonoc, blockdirc," & If(ApDirC <> "", "apdirc,", "") & "aclaraciondirc) VALUES ('{0}', '{1}', '{2}', {3}, '{4}', '{5}', " & If(ApDirC <> "", "{6},", "") & "'{7}');", CalleDirC, CiudadC, CodPostalC, NroDirC, TelefonoC, BlockDirC, ApDirC, AclaracionDirC)
        Dim cm = New OdbcCommand(sql, cx)

        Try
            cm.ExecuteNonQuery()
        Catch ex As Exception
            Return 0
        End Try

        ' Obtener ID del cliente recien creado
        Dim cmr = New OdbcCommand(String.Format("SELECT MAX(id) FROM cliente WHERE telefonoc={0}", TelefonoC), cx)
        Dim id = cmr.ExecuteScalar()
        RegistrarAccion("Nuevo Cliente", String.Format("idcliente={0}", id))
        Return id
    End Function

    Public Function ObtenerIdCliente(ByVal pk As String, ByVal tipo As TipoCliente) As Integer
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim tabla = If(tipo = TipoCliente.Persona, "persona", "empresa")
        Dim clavePk = If(tipo = TipoCliente.Persona, "numdocp", "rut")
        Dim cm = New OdbcCommand(String.Format("SELECT FIRST 1 id FROM {0} WHERE {1}='{2}'", tabla, clavePk, pk), cx)

        Return cm.ExecuteScalar()
    End Function

    Public Function DarBajaCliente(ByVal idCliente As Integer, ByVal razonBaja As String) As Boolean
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cm = New OdbcCommand(String.Format("UPDATE cliente SET motivobaja='{0}' WHERE id={1}", razonBaja, idCliente), cx)

        Try
            Return cm.ExecuteNonQuery()
        Catch ex As Exception
            Mensajes.ErrorSimple(ex.Message)
            Return False
        End Try
    End Function
End Module

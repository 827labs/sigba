Imports System.Data.Odbc

Module Clientes
    Public Function AltaCliente(ByVal CalleDirC As String, ByVal CiudadC As String, ByVal CodPostalC As String, ByVal NroDirC As String, ByVal TelefonoC As String, ByVal BlockDirC As String, ByVal ApDirC As String, ByVal AclaracionDirC As String) As String
        Dim cx = ConexionBaseDatos.ObtenerActual()

        ' Insertar cliente
        Dim sql = String.Format("INSERT INTO cliente (calledirc, ciudadc, codpostalc, nrodirc, telefonoc, blockdirc," & If(ApDirC <> "", "apdirc,", "") & "aclaraciondirc) VALUES ('{0}', '{1}', '{2}', {3}, '{4}', '{5}', " & If(ApDirC <> "", "{6},", "") & "'{7}');", CalleDirC, CiudadC, CodPostalC, NroDirC, TelefonoC, BlockDirC, ApDirC, AclaracionDirC)
        Dim cm = New OdbcCommand(sql, cx)
        cm.ExecuteNonQuery()

        ' Obtener ID del cliente recien creado
        Dim cmr = New OdbcCommand("SELECT LAST 1 id FROM cliente", cx)
        Return cmr.ExecuteScalar()
    End Function
End Module

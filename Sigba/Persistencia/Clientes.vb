Imports System.Data.Odbc

Module Clientes
    Public Function AltaCliente(ByVal CalleDirC As String, ByVal CiudadC As String, ByVal CodPostalC As String, ByVal NroDirC As Integer, ByVal TelefonoC As String, ByVal BlockDirC As String, ByVal ApDirC As Integer, ByVal AclaracionDirC As String) As String
        Dim cx = ConexionBaseDatos.ObtenerActual()

        ' Insertar cliente
        Dim sql = String.Format("INSERT INTO cliente (calledirc, ciudadc, codpostalc, nrodirc, telefonoc, blockdirc, apdirc, aclaraciondirc) VALUES ('{0}', '{1}', '{2}', {3},'{4}', '{5}', {6}, '{7}')", CalleDirC, CiudadC, CodPostalC, NroDirC, TelefonoC, BlockDirC, ApDirC, AclaracionDirC)
        Dim cm = New OdbcCommand(sql, cx)
        cm.ExecuteNonQuery()

        ' Obtener ID del cliente recien creado
        Dim cmr = New OdbcCommand("SELECT LAST 1 id FROM cliente", cx)
        Return cmr.ExecuteScalar()
    End Function
End Module

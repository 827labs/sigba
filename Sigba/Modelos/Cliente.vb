Imports System.Data.Odbc

Public Class Cliente
    Public AclaracionDirC As String
    Public ApDirC As Integer
    Public BlockDirC As String
    Public CalleDirC As String
    Public CiudadC As String
    Public CodPostalC As Integer
    Public Id As Integer
    Public MotivoBaja As String
    Public NroDirC As String
    Public TelefonoC As String

    Public Sub New(ByVal id As Integer)
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cm = New OdbcCommand(String.Format("SELECT NVL(aclaraciondirc, ''), NVL(apdirc, 0), NVL(blockdirc, ''), calledirc, ciudadc, codpostalc, id, NVL(motivobaja, '') baja, nrodirc, NVL(telefonoc, '') tel FROM cliente WHERE id={0}", id), cx)
        Dim lector = cm.ExecuteReader
        Dim existe = False

        While lector.Read()
            existe = True
            AclaracionDirC = lector("aclaraciondirc")
            ApDirC = lector("apdirc")
            BlockDirC = lector("blockdirc")
            CalleDirC = lector("calledirc")
            CiudadC = lector("ciudadc")
            CodPostalC = lector("codpostalc")
            Me.Id = lector("id")
            MotivoBaja = lector("baja")
            NroDirC = lector("nrodirc")
            TelefonoC = lector("tel")
        End While
    End Sub

    Public Function Existe()
        Return Me.Id <> Nothing
    End Function

End Class

Imports System.Data.Odbc
Module Personas
    Public Function AltaPersona(ByVal apellidop As String, ByVal ciudadnac As String, ByVal fechanac As DateTime, ByVal mail As String, ByVal id As Integer, ByVal nombrep As String, ByVal numdoccony As String, ByVal numdocp As String, ByVal paisdoccony As String, ByVal paisdocp As String, ByVal paisnac As String, ByVal sexop As String, ByVal tipodoccony As String, ByVal tipodocp As String) As Boolean
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim fechaNacimiento = fechanac.ToString("dd/MM/yyyy")

        ' Insertar cliente
        Dim sql = String.Format("INSERT INTO persona (apellidop, ciudadnac, fechanac, mail, id, nombrep, numdoccony, numdocp, paisdoccony, paisdocp, paisnac, sexop, tipodoccony, tipodocp) VALUES ('{0}', '{1}', '{2}', '{3}', {4}, '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}');", apellidop, ciudadnac, fechaNacimiento, mail, id, nombrep, numdoccony, numdocp, paisdoccony, paisdocp, paisnac, sexop, tipodoccony, tipodocp)
        Dim cm = New OdbcCommand(sql, cx)

        Try
            cm.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Mensajes.ErrorSimple(ex.Message)
            Return False
        End Try
    End Function
End Module

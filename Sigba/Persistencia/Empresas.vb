Imports System.Data.Odbc
Module Empresas
    Public Function AltaEmpresa(ByVal departamentoe As String, ByVal id As Integer, ByVal rut As String, ByVal paisorigencapitale As String, ByVal paisorigene As String, ByVal webe As String, ByVal razonsociale As String, ByVal tiposociedade As String) As Boolean
        Dim cx = ConexionBaseDatos.ObtenerActual()

        ' Insertar cliente
        Dim sql = String.Format("INSERT INTO empresa (departamentoe, id, rut, paisorigencapitale, paisorigene, webe, razonsociale, tiposociedade) VALUES ('{0}', {1}, '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');", departamentoe, id, rut, paisorigencapitale, paisorigene, webe, razonsociale, tiposociedade)
        Dim cm = New OdbcCommand(sql, cx)

        Try
            cm.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            If (ModoDesarrolloActivado()) Then
                Mensajes.ErrorSimple(ex.Message)
            End If

            If ex.Message.Contains("UNIQUE INDEX") Then
                Mensajes.ErrorSimple("El número de RUT que ingresó ya existe.")
            End If
            Return False
        End Try
    End Function
End Module

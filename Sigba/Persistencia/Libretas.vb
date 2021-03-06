﻿Imports System.Data.Odbc

Module Libretas
    Public Function CrearLibreta(ByVal cuentaCompleta As String, ByVal serie As String, ByVal numero As String, ByVal cantCheques As Integer)
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim idcuenta = cuentaCompleta.Split(" ").Last()
        Dim cm = New OdbcCommand(String.Format("insert into libreta (numlib, serie, fechaemisionlib, idcuenta) values ({0}, {1}, '{2}', {3})", numero, serie, Date.Today.ToString(FormatoFecha()), idcuenta), cx)

        If cm.ExecuteNonQuery() <= 0 Then
            Mensajes.ErrorSimple(T("No se pudo crear la libreta, contacte a soporte.", "We couldn't register the checkbook, please contact support."))
            Return False
        End If

        ' Crear cheques
        For i As Integer = 1 To cantCheques
            Dim cmCheque = New OdbcCommand(String.Format("insert into cheque (numche, serielib, numlib) values ({0}, {1}, {2})", i, serie, numero), cx)
            cmCheque.ExecuteNonQuery()
        Next

        Return True
    End Function

    Public Function EliminarLibreta(ByVal serie As String, ByVal numero As String) As Boolean
        Dim cx = ConexionBaseDatos.ObtenerActual
        Dim cm = New OdbcCommand(String.Format("delete from libreta where serie={0} and numlib={1}", serie, numero), cx)

        If cm.ExecuteNonQuery() > 0 Then
            Return True
        Else
            Mensajes.ErrorSimple(T("No se pudo eliminar la libreta, verifique los valores que ingreso o contacte a soporte.", "We couldn't delete the checkbook, please check the values you entered or contact support."))
            Return False
        End If

    End Function
End Module

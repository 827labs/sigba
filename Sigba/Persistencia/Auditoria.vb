﻿Imports System.Data.Odbc

Module Auditoria

    Sub ObtenerRegistros(ByRef dgv As DataGridView)
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cm = New OdbcCommand
        cm.Connection = cx

        cm.CommandText = "SELECT idreg, nombre, numdocu, fecha, hora, datosextra FROM registroaccion ORDER BY idreg DESC"
        Dim da = New OdbcDataAdapter(cm)
        Dim ds = New DataSet
        da.Fill(ds, "registroaccion")

        dgv.DataSource = ds.Tables("registroaccion")

        With dgv
            .Columns(0).HeaderCell.Value = "ID"
            .Columns(1).HeaderCell.Value = "Funcionalidad"
            .Columns(2).HeaderCell.Value = "Usuario"
            .Columns(3).HeaderCell.Value = "Fecha"
            .Columns(4).HeaderCell.Value = "Hora"
            .Columns(5).HeaderCell.Value = "Datos extra"
        End With
    End Sub

    Sub RegistrarAccion(ByVal nombreAccion As String, Optional ByVal datosExtra As String = "")
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cm = New OdbcCommand
        cm.Connection = cx

        Dim fecha = DateTime.Now()
        Dim fechaStr = fecha.ToString(FormatoFecha())
        Dim horaStr = fecha.ToString("HH:mm")
        Dim nomUsuario = Autenticacion.usuario

        If nomUsuario <> "" Then
            Dim usu = New Usuario(nomUsuario)
            cm.CommandText = String.Format("INSERT INTO registroaccion (nombre, numdocu, fecha, hora, datosextra) VALUES ('{0}', {1}, '{2}', '{3}', '{4}')", nombreAccion, usu.NumDocU, fechaStr, horaStr, datosExtra)
        Else
            cm.CommandText = String.Format("INSERT INTO registroaccion (nombre, fecha, hora, datosextra) VALUES ('{0}', '{1}', '{2}', '{3}')", nombreAccion, fechaStr, horaStr, datosExtra)
        End If

        cm.ExecuteNonQuery()
    End Sub

End Module

Imports System.Data.Odbc

Public Class Estado
    Public IdE As Integer
    Public Fecha As String
    Public Tipo As String
    Public NumCaja As Integer
    Public SaldoUYU As Integer
    Public SaldoUSD As Integer

    Public Guardado As Boolean

    Public Sub New()
        Me.Guardado = False
    End Sub

    Public Sub New(ByVal numero As String)
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cm = New OdbcCommand
        cm.Connection = cx
        cm.CommandText = String.Format("SELECT * from estado WHERE ide={0}", numero)
        Dim lector = cm.ExecuteReader()

        While lector.Read()
            Me.Guardado = True
            Me.IdE = lector("ide")
            Me.Fecha = lector("fecha")
            Me.Tipo = lector("tipo")
            Me.NumCaja = lector("numcaja")
            Me.SaldoUYU = lector("saldouyu")
            Me.SaldoUSD = lector("saldousd")
        End While
    End Sub

    Public Function EsValido() As Boolean
        ' Retorna True si una caja ha sido seteado en la instancia
        Return Me.IdE > 0
    End Function

    Private Function Insertar() As Boolean
        If Not (Tipo = "APERTURA" Or Tipo = "CIERRE") Then
            Return False
        End If

        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cm = New OdbcCommand(String.Format("INSERT INTO estado (fecha, tipo, numcaja, saldouyu, saldousd) VALUES ('{0}', '{1}', {2}, {3}, {4})", Fecha, Tipo, NumCaja, SaldoUYU, SaldoUSD), cx)

        Try
            cm.ExecuteNonQuery()
            Me.Guardado = True

            cm = New OdbcCommand(String.Format("SELECT MAX(ide) FROM estado WHERE fecha='{0}' AND numcaja={1}", Fecha, NumCaja), cx)
            IdE = cm.ExecuteScalar

            Return True
        Catch ex As Exception
            Mensajes.ErrorSimple(String.Format("No pudimos guardar  el nuevo estado. Error: {0}", ex.Message))
            Return False
        End Try
    End Function


    Public Function Guardar() As Boolean
        Return Me.Insertar()
    End Function
End Class

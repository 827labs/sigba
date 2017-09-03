Imports System.Data.Odbc

Public Class Caja
    Public Abierta As Integer
    Public NumSuc As Integer
    Public Num As Integer

    Public Guardado As Boolean

    Public Sub New()
        Me.Guardado = False
    End Sub

    Public Sub New(ByVal numero As String)
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cm = New OdbcCommand
        cm.Connection = cx
        cm.CommandText = String.Format("SELECT * from caja WHERE num={0}", numero)
        Dim lector = cm.ExecuteReader()

        While lector.Read()
            Me.Abierta = PuedeSerNullInt(lector, "abierta")
            Me.NumSuc = lector("numsuc")
            Me.Num = lector("num")
        End While
    End Sub

    Public Function EsValido() As Boolean
        ' Retorna True si una caja ha sido seteado en la instancia
        Return Me.Num > 0
    End Function

    Private Function Insertar() As Boolean
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cm = New OdbcCommand(String.Format("INSERT INTO caja (numsuc) VALUES ({0})", NumSuc), cx)

        Try
            cm.ExecuteNonQuery()
            Me.Guardado = True
            Return True
        Catch ex As Exception
            Mensajes.ErrorSimple(String.Format("No pudimos guardar la nueva caja. Error: {0}", ex.Message))
            Return False
        End Try
    End Function

    Public Function Actualizar() As Boolean
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cm = New OdbcCommand(String.Format("UPDATE caja SET abierta={0}, numsuc={1} WHERE num={2}", Abierta, NumSuc, Num), cx)

        Try
            cm.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Mensajes.ErrorSimple(String.Format("No pudimos guardar los cambios en la caja. Error: {0}", ex.Message))
            Return False
        End Try
    End Function

    Public Function Guardar() As Boolean
        If Me.Guardado = True Then
            Return Me.Actualizar()
        Else
            Return Me.Insertar()
        End If
    End Function

    Public Function CerrarCaja() As Boolean
        Dim cx = ConexionBaseDatos.ObtenerActual
        Dim cm = New OdbcCommand("UPDATE caja SET abierta=NULL WHERE num=" & Num, cx)

        Try
            cm.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Mensajes.ErrorSimple("No se pudo cerrar la caja. Error: " & ex.Message)
            Return False
        End Try
    End Function
End Class

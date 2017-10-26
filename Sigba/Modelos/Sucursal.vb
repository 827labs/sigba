Imports System.Data.Odbc

Public Class Sucursal
    Public CalleDirSuc As String
    Public Horario As String
    Public NombreSuc As String
    Public NroDirSuc As Integer
    Public NumSuc As Integer
    Public Guardado As Boolean

    Public Sub New()
        Me.Guardado = False
    End Sub

    Public Sub New(ByVal numero As String)
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cm = New OdbcCommand
        cm.Connection = cx
        cm.CommandText = String.Format("SELECT * from sucursal WHERE numsuc={0}", numero)
        Dim lector = cm.ExecuteReader()

        Dim existe = False

        While lector.Read()
            existe = True
            Me.CalleDirSuc = lector("calledirsuc")
            Me.Horario = lector("horario")
            Me.NombreSuc = lector("nombresuc")
            Me.NroDirSuc = lector("nrodirsuc")
            Me.NumSuc = lector("numsuc")
            Me.Guardado = True
        End While

        If Not existe Then
            Mensajes.Simple(String.Format("La sucursal {0} no existe.", numero))
        End If
    End Sub

    Public Function EsValido() As Boolean
        ' Retorna True si una sucursal ha sido seteado en la instancia
        Return Me.NumSuc > 0
    End Function

    Private Function Insertar() As Boolean
        NumSuc = 0 ' Se pone en 0 para que Informix lo reemplaze por el SERIAL autoincrementable
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cm = New OdbcCommand(String.Format("INSERT INTO sucursal (calledirsuc, horario, nombresuc, nrodirsuc, numsuc) VALUES ('{0}', '{1}', '{2}', {3}, {4})", CalleDirSuc, Horario, NombreSuc, NroDirSuc, NumSuc), cx)

        Try
            cm.ExecuteNonQuery()
            Me.Guardado = True
            Return True
        Catch ex As Exception
            Mensajes.ErrorSimple(String.Format("No pudimos guardar la nueva sucursal. Error: {0}", ex.Message))
            Return False
        End Try
    End Function

    Private Function Actualizar() As Boolean
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cm = New OdbcCommand(String.Format("UPDATE sucursal SET calledirsuc='{0}', horario='{1}', nombresuc='{2}', nrodirsuc={3} WHERE numsuc={4}", CalleDirSuc, Horario, NombreSuc, NroDirSuc, NumSuc), cx)

        Try
            cm.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Mensajes.ErrorSimple(String.Format("No pudimos guardar los cambios en la sucursal. Error: {0}", ex.Message))
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
End Class

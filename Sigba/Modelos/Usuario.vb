﻿Imports System.Data.Odbc

Public Class Usuario
    Public Nombre As String
    Public Apellido As String
    Public NumDocU As Integer
    Public ClaveU As String
    Public CodRecuperacionU As Integer
    Public EmailU As String
    Public Suspendido As String

    Public Sub New(ByVal cedula As String)
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cm = New OdbcCommand
        cm.Connection = cx
        cm.CommandText = String.Format("SELECT NVL(nombre, '') nom, NVL(apellido, '') ape, numdocu, claveu, emailu, NVL(codrecuperacionu, 0) codrec, NVL(suspendido, '') sus from usuario WHERE numdocu={0}", cedula)
        Dim lector = cm.ExecuteReader()

        Dim existe = False

        While lector.Read()
            existe = True
            Me.Nombre = lector("nom")
            Me.Apellido = lector("ape")
            Me.NumDocU = lector("numdocu")
            Me.ClaveU = lector("claveu")
            Me.CodRecuperacionU = lector("codrec")
            Me.EmailU = lector("emailu")
            Me.Suspendido = lector("sus")
        End While

        If Me.EstaSuspendido() Then
            Mensajes.ErrorSimple(String.Format("El usuario {0} ({1} {2}) fué suspendido el dia {3}.", Me.NumDocU, Me.Nombre, Me.Apellido, Me.Suspendido))
        End If

        If Not existe Then
            Mensajes.Simple(String.Format("El usuario con cédula {0} no existe.", cedula))
        End If
    End Sub

    Public Function EsValido() As Boolean
        ' Retorna True si un usuario ha sido seteado en la instancia
        Return Me.NumDocU > 0
    End Function

    Public Function EstaSuspendido() As Boolean
        Return Me.Suspendido.Length > 0
    End Function

    Public Function EsFuncionario() As Boolean
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cm = New OdbcCommand("SELECT COUNT(*) cargos FROM ejerce WHERE numdocu=" & Me.NumDocU, cx)
        Dim cantCargos = cm.ExecuteScalar()

        Return cantCargos <> "0"
    End Function

    Public Function ActualizarCodRecuperacion(ByVal nuevoCodigoRecuperacion As Integer) As Boolean
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cm = New OdbcCommand
        cm.Connection = cx
        cm.CommandText = String.Format("UPDATE usuario SET codrecuperacionu={0} WHERE numdocu={1}", nuevoCodigoRecuperacion, NumDocU)

        Try
            cm.ExecuteNonQuery()
            Me.CodRecuperacionU = nuevoCodigoRecuperacion
            Return True
        Catch ex As Exception
            Mensajes.ErrorSimple("No pudimos generar el codigo de recuperación para el usuario. Error: " & ex.Message)
            Return False
        End Try

    End Function

    Public Function Cargo() As String
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cm = New OdbcCommand("select FIRST 1 c.nombre from cargo as c INNER JOIN ejerce as e ON e.idcargo = c.idcargo where e.numdocu=" & Me.NumDocU, cx)

        Return cm.ExecuteScalar()
    End Function
End Class

Imports System.Data.Odbc

Module Utilidades
    Public Function PuedeSerNullStr(ByRef lector As OdbcDataReader, ByVal columna As String) As String
        Try
            Return lector(columna)
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function PuedeSerNullInt(ByRef lector As OdbcDataReader, ByVal columna As String) As Integer
        Try
            Return lector(columna)
        Catch ex As Exception
            Return 0
        End Try
    End Function
End Module

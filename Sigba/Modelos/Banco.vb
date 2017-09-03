Imports System.Data.Odbc


Public Class Banco
    Public DireccionB As String
    Public HabilitarCCPersonas As Boolean
    Public LogoB As String
    Public NombreFantasiaB As String
    Public RUT As String
    Public LimiteRetiroCajeroIslaPesos As Integer
    Public LimiteRetiroCajeroIslaDolares As Integer
    Public LimiteRetiroCajeroDependenciasPesos As Integer
    Public LimiteRetiroCajeroDependenciasDolares As Integer
    Public RazonSocial As String
    Public SitioWebB As String
    Public TelefonoB As String
    Public MaxDepositoSinDeclararPesos As Integer
    Public MaxDepositoSinDeclararDolares As Integer
    Public MinimoDepositoSinDeclararPesos As Integer
    Public MinimoDepositoSinDeclararDolares As Integer

    Sub New()
        If Not Banco.HayBancoRegistrado Then
            Return
        End If

        Dim cx = ConexionBaseDatos.ObtenerActual
        Dim cm = New OdbcCommand("SELECT FIRST 1 direccionb, habilitarccpersonas, limiteretirocajerobdependenciaspesos, limiteretirocajerobisladolares, limiteretirocajerobislapesos, logob, nombrefantasiab, rut, razonsocial, sitiowebb, telefonob, limiteretirocajerobdependenciasdolares, maxdepositosindeclararpesos, maxdepositosindeclarardolares, minimodepositocajapesos, minimodepositocajadolares FROM banco", cx)
        Dim lector = cm.ExecuteReader

        While lector.Read
            Me.DireccionB = lector("direccionb")
            Me.HabilitarCCPersonas = lector("habilitarccpersonas")
            Me.LogoB = PuedeSerNullStr(lector, "logob")
            Me.NombreFantasiaB = lector("nombrefantasiab")
            Me.RUT = lector("rut")
            Me.LimiteRetiroCajeroIslaPesos = lector("limiteretirocajerobislapesos")
            Me.LimiteRetiroCajeroIslaDolares = lector("limiteretirocajerobisladolares")
            Me.LimiteRetiroCajeroDependenciasPesos = lector("limiteretirocajerobdependenciaspesos")
            Me.LimiteRetiroCajeroDependenciasDolares = lector("limiteretirocajerobdependenciasdolares")
            Me.RazonSocial = lector("razonsocial")
            Me.SitioWebB = PuedeSerNullStr(lector, "sitiowebb")
            Me.TelefonoB = PuedeSerNullStr(lector, "telefonob")
            Me.MaxDepositoSinDeclararPesos = lector("maxdepositosindeclararpesos")
            Me.MaxDepositoSinDeclararDolares = lector("maxdepositosindeclarardolares")
            Me.MinimoDepositoSinDeclararPesos = lector("minimodepositocajapesos")
            Me.MinimoDepositoSinDeclararDolares = lector("minimodepositocajadolares")
        End While

    End Sub

    Public Shared Function HayBancoRegistrado() As Boolean
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cm = New OdbcCommand("SELECT COUNT(*) FROM banco", cx)
        Dim resp = cm.ExecuteScalar

        Return resp <> "0"
    End Function

    Public Function Actualizar() As Boolean
        Dim cx = ConexionBaseDatos.ObtenerActual
        Dim sql = "UPDATE banco SET direccionb='{0}', habilitarccpersonas={1}, limiteretirocajerobdependenciaspesos={2}, limiteretirocajerobisladolares={3}, limiteretirocajerobislapesos={4}, logob='{5}', nombrefantasiab='{6}', rut='{7}', razonsocial='{8}', sitiowebb='{9}', telefonob='{10}', limiteretirocajerobdependenciasdolares={11}, maxdepositosindeclararpesos={12}, maxdepositosindeclarardolares={13}, minimodepositocajapesos={14}, minimodepositocajadolares={15} WHERE rut={7}"
        If Not Banco.HayBancoRegistrado Then
            sql = "INSERT INTO banco (direccionb, habilitarccpersonas, limiteretirocajerobdependenciaspesos, limiteretirocajerobisladolares, limiteretirocajerobislapesos, logob, nombrefantasiab, rut, razonsocial, sitiowebb, telefonob, limiteretirocajerobdependenciasdolares, maxdepositosindeclararpesos, maxdepositosindeclarardolares, minimodepositocajapesos, minimodepositocajadolares) VALUES ('{0}', {1}, {2}, {3}, {4}, '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', {11}, {12}, {13}, {14}, {15})"
        End If
        Dim cm = New OdbcCommand(String.Format(sql, DireccionB, If(HabilitarCCPersonas = True, "'t'", "'f'"), LimiteRetiroCajeroDependenciasPesos, LimiteRetiroCajeroIslaDolares, LimiteRetiroCajeroIslaPesos, LogoB, NombreFantasiaB, RUT, RazonSocial, SitioWebB, TelefonoB, LimiteRetiroCajeroDependenciasDolares, MaxDepositoSinDeclararPesos, MaxDepositoSinDeclararDolares, MinimoDepositoSinDeclararPesos, MinimoDepositoSinDeclararDolares), cx)

        Try
            cm.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Mensajes.ErrorSimple("Error con la base de datos: " & ex.Message)
            Return False
        End Try
    End Function
End Class

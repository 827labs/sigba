Imports System.Data.Odbc

Module Movimientos
    Public Enum TipoMovimiento
        Retiro = 0
        Deposito = 1
        Transferencia = 2
        Debito = 3
    End Enum

    Public Function NuevoMovimiento(ByVal concepto As String, ByVal diferencia As Decimal, ByVal nroCuentaCompleto As String) As Boolean
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim saldoCuenta = ObtenerSaldoCuenta(nroCuentaCompleto).Split(" ")(1)
        Dim fechaActual = Date.Today().ToString(FormatoFecha())
        Dim horaActual = Date.Now().ToString("HH:mm")
        Dim idCuenta = nroCuentaCompleto.Split(" ")(2)
        Dim usuario = New Usuario(Autenticacion.usuario)
        Dim numdocu = usuario.NumDocU

        Dim cm = New OdbcCommand(String.Format("INSERT INTO movimiento (concepto, fecha, hora, diferencia, idcuenta, numdocu, saldoanterior) VALUES ('{0}', '{1}', '{2}', {3}, {4}, {5}, {6});", concepto, fechaActual, horaActual, diferencia, idCuenta, numdocu, saldoCuenta), cx)

        Return cm.ExecuteNonQuery() > 0
    End Function

    Public Sub HistoricoCuentaDGV(ByRef dgv As DataGridView, ByVal nroCuenta As String)
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cuenta = nroCuenta.Split(" ")
        Dim idCuenta = cuenta(2)

        Dim cm = New OdbcCommand(String.Format("SELECT idmov comprobante, numdocu usuario, concepto, diferencia monto, saldoanterior anterior, saldoanterior + diferencia actual FROM movimiento WHERE idcuenta={0}", idCuenta), cx)
        Dim da = New OdbcDataAdapter(cm)
        Dim ds = New DataSet
        da.Fill(ds, "movimiento")
        dgv.DataSource = ds.Tables("movimiento")

        With dgv
            .Columns(0).HeaderCell.Value = "Comprobante"
            .Columns(1).HeaderCell.Value = "Usuario"
            .Columns(2).HeaderCell.Value = "Concepto"
            .Columns(3).HeaderCell.Value = "Monto"
            .Columns(4).HeaderCell.Value = "Saldo Anterior"
            .Columns(5).HeaderCell.Value = "Saldo Actual"
        End With
    End Sub



    Public Function EfectuarTransferencia(ByVal cuentaOrigenCompleto As String, ByVal cuentaDestinoCompleto As String, ByVal moneda As String, ByVal monto As Decimal) As Boolean
        Dim cx = ConexionBaseDatos.ObtenerActual()

        Dim monedaCuentaOrigen = cuentaOrigenCompleto.Split(" ")(1)
        Dim monedaCuentaDestino = cuentaDestinoCompleto.Split(" ")(1)

        Dim idCuentaOrigen = cuentaOrigenCompleto.Split(" ")(2)
        Dim idCuentaDestino = cuentaDestinoCompleto.Split(" ")(2)

        ' Obtener saldo actual de la cuenta de origen
        Dim saldoOrigen = (New OdbcCommand(String.Format("SELECT saldo FROM cuenta WHERE idcuenta={0}", idCuentaOrigen), cx)).ExecuteScalar()
        Dim saldoDestino = (New OdbcCommand(String.Format("SELECT saldo FROM cuenta WHERE idcuenta={0}", idCuentaDestino), cx)).ExecuteScalar()

        Dim validezTransferencia = Movimientos.TransferenciaEsValida(cuentaOrigenCompleto, cuentaDestinoCompleto, moneda, monto)

        If validezTransferencia <> ValidezTransaccion.Valida Then
            ' Transferencia Invalida
            Select Case validezTransferencia
                Case ValidezTransaccion.SaldoInsuficiente
                    Mensajes.ErrorSimple("El saldo de la cuenta de origen es insuficiente.")
                Case ValidezTransaccion.CuentaOrigenNoHabilitadaNoValida
                    Mensajes.ErrorSimple("La cuenta de origen no está habilitada o no es válida.")
                Case ValidezTransaccion.CuentaDestinoNoHabilitadaNoValida
                    Mensajes.ErrorSimple("La cuenta de destino no está habilitada o no es válida.")
                Case ValidezTransaccion.CuentaNoValida
                    Mensajes.ErrorSimple("La cuenta de destino o de origen no és válida.")
                Case Else
                    Mensajes.ErrorSimple("La transferencia no pudo ser validada. Comuniquese con el gerente de la sucursal.")
            End Select

            Return False
        End If

        ' Debitar el dinero de la cuenta de origen
        Dim montoADebitar = ObtenerMontoNormalizado(monto, moneda, monedaCuentaOrigen)
        NuevoMovimiento("TRANSFERENCIA SALIENTE " & cuentaDestinoCompleto, -1 * montoADebitar, cuentaOrigenCompleto)
        Dim nuevoSaldoOrigen = saldoOrigen - montoADebitar
        Dim cmDebitoOrigen = New OdbcCommand(String.Format("UPDATE cuenta SET saldo={0} WHERE idcuenta={1}", nuevoSaldoOrigen, idCuentaOrigen), cx)

        If cmDebitoOrigen.ExecuteNonQuery() > 0 Then
            RegistrarAccion("Transferencia saliente", String.Format("cuenta={0};moneda={1};monto={2}", cuentaOrigenCompleto, moneda, monto))
        End If

        ' Acreditar el dinero en la cuenta de destino
        Dim montoACreditar = ObtenerMontoNormalizado(montoADebitar, monedaCuentaOrigen, monedaCuentaDestino)
        NuevoMovimiento("TRANSFERENCIA ENTRANTE " & cuentaOrigenCompleto, montoACreditar, cuentaDestinoCompleto)
        Dim nuevoSaldoDestino = saldoDestino + montoACreditar
        Dim cmCreditoDestino = New OdbcCommand(String.Format("UPDATE cuenta SET saldo={0} WHERE idcuenta={1}", nuevoSaldoDestino, idCuentaDestino), cx)

        If cmCreditoDestino.ExecuteNonQuery() > 0 Then
            RegistrarAccion("Transferencia entrante", String.Format("cuenta={0};moneda={1};monto={2}", cuentaDestinoCompleto, moneda, monto))
        End If

        Return True
    End Function

    Public Function ObtenerMontoNormalizado(ByVal monto As Decimal, ByVal moneda As String, Optional ByVal montoDestino As String = "UYU") As Decimal
        Dim tasaDolares = 29.43 ' Reemplazar esto por tasa dinámica
        Dim tasaEuros = 34.7

        If montoDestino = "UYU" Then
            Select Case moneda
                Case "UYU"
                    Return monto
                Case "USD"
                    Return monto * tasaDolares
                Case "EUR"
                    Return monto * tasaEuros
                Case Else
                    Return monto
            End Select
        ElseIf montoDestino = "USD" Then
            Select Case moneda
                Case "UYU"
                    Return monto / tasaDolares
                Case "USD"
                    Return monto
                Case "EUR"
                    Return (monto * tasaEuros) / tasaDolares
                Case Else
                    Return monto
            End Select
        ElseIf montoDestino = "EUR" Then
            Select Case moneda
                Case "UYU"
                    Return monto / tasaEuros
                Case "USD"
                    Return (monto * tasaDolares) / tasaEuros
                Case "EUR"
                    Return monto
                Case Else
                    Return monto
            End Select
        End If
    End Function

    Public Enum ValidezTransaccion
        Valida = 0
        SaldoInsuficiente = 1
        CuentaNoValida = 2
        CuentaNoHabilitada = 3

        ' Dedicado a transferencias 
        CuentaOrigenNoHabilitadaNoValida = 4
        CuentaDestinoNoHabilitadaNoValida = 5
    End Enum

    Public Function TransferenciaEsValida(ByVal cuentaOrigenCompleto As String, ByVal cuentaDestinoCompleto As String, ByVal moneda As String, ByVal monto As Decimal) As ValidezTransaccion
        ' Validar que ningúna de las cuentas sea cuenta corriente en euros (ya que no se puede)
        If cuentaDestinoCompleto.ToUpper().Contains("CC") And cuentaDestinoCompleto.ToUpper().Contains("EUR") Then
            Return ValidezTransaccion.CuentaNoValida
        End If

        If cuentaOrigenCompleto.ToUpper().Contains("CC") And cuentaOrigenCompleto.ToUpper().Contains("EUR") Then
            Return ValidezTransaccion.CuentaNoValida
        End If

        Dim monedaOrigen As String = cuentaOrigenCompleto.Split()(1)
        Dim monedaDestino As String = cuentaDestinoCompleto.Split()(1)
        Dim saldoOrigen As Decimal = Cuentas.ObtenerSaldoCuenta(cuentaOrigenCompleto)

        Dim saldoOrigenNormalizado As Decimal = ObtenerMontoNormalizado(saldoOrigen, monedaOrigen)
        Dim montoTransaccionNormalizado As Decimal = ObtenerMontoNormalizado(monto, moneda)

        ' Validar que la cuenta de origen tenga los fondos necesarios
        If (saldoOrigenNormalizado < montoTransaccionNormalizado) Then
            Return ValidezTransaccion.SaldoInsuficiente
        End If

        If Not CuentaEstaHabilitada(cuentaOrigenCompleto) Then
            Return ValidezTransaccion.CuentaOrigenNoHabilitadaNoValida
        End If

        If Not CuentaEstaHabilitada(cuentaDestinoCompleto) Then
            Return ValidezTransaccion.CuentaDestinoNoHabilitadaNoValida
        End If
    End Function
End Module

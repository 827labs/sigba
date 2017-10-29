Imports System.Data.Odbc

Module Movimientos
    Public Enum TipoMovimiento
        Retiro = 0
        Deposito = 1
        Transferencia = 2
        Debito = 3
    End Enum

    Public Function NuevoMovimiento(ByVal concepto As String, ByVal diferencia As Decimal, ByVal nroCuentaCompleto As String, Optional ByVal DatosExtra As String = "") As Boolean
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim saldoCuenta = ObtenerSaldoCuenta(nroCuentaCompleto).Split(" ")(1)
        Dim fechaActual = Date.Today().ToString(FormatoFecha())
        Dim horaActual = Date.Now().ToString("HH:mm")
        Dim idCuenta = nroCuentaCompleto.Split(" ")(2)
        Dim usuario = New Usuario(Autenticacion.usuario)
        Dim numdocu = usuario.NumDocU

        If Autenticacion.HayCajaAbierta() Then
            DatosExtra = DatosExtra & If(DatosExtra.Length > 0, ";", "") & String.Format("numcaja={0};sucursal={1};estadocaja={2}", Autenticacion.cajaAbierta, Autenticacion.sucursalCajaAbierta, Autenticacion.estadoCaja)
        End If

        If Autenticacion.numATMActivo <> Nothing Then
            DatosExtra = DatosExtra & If(DatosExtra.Length > 0, ";", "") & String.Format("numcajeroatm={0}", Autenticacion.numATMActivo)
        End If

        Dim cm = New OdbcCommand(String.Format("INSERT INTO movimiento (concepto, fecha, hora, diferencia, idcuenta, numdocu, saldoanterior, datosextra) VALUES ('{0}', '{1}', '{2}', {3}, {4}, {5}, {6}, '{7}');", concepto, fechaActual, horaActual, diferencia, idCuenta, numdocu, saldoCuenta, DatosExtra), cx)

        Return cm.ExecuteNonQuery() > 0
    End Function

    Public Sub HistoricoCuentaDGV(ByRef dgv As DataGridView, ByVal nroCuenta As String)
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cuenta = nroCuenta.Split(" ")
        Dim idCuenta = cuenta(2)

        Dim cm = New OdbcCommand(String.Format("SELECT idmov comprobante, numdocu usuario, concepto, diferencia monto, saldoanterior anterior, saldoanterior + diferencia actual FROM movimiento WHERE idcuenta={0} ORDER BY idmov DESC", idCuenta), cx)
        Dim da = New OdbcDataAdapter(cm)
        Dim ds = New DataSet
        da.Fill(ds, "movimiento")
        dgv.DataSource = ds.Tables("movimiento")

        With dgv
            .Columns(0).HeaderCell.Value = T("Comprobante", "Transaction")
            .Columns(1).HeaderCell.Value = T("Usuario", "User")
            .Columns(2).HeaderCell.Value = T("Concepto", "Concept")
            .Columns(3).HeaderCell.Value = T("Monto", "Amount")
            .Columns(4).HeaderCell.Value = T("Saldo Anterior", "Previous balance")
            .Columns(5).HeaderCell.Value = T("Saldo Actual", "Current balance")
        End With
    End Sub

    Public Function EfectuarCobroCheque(ByVal cuentaDebitoCompleto As String, ByVal moneda As String, ByVal monto As Decimal, ByVal serieLibreta As String, ByVal numeroLibreta As String, ByVal numeroCheque As Integer) As Boolean
        Dim cx = ConexionBaseDatos.ObtenerActual()

        If Not CuentaEstaHabilitada(cuentaDebitoCompleto) Then
            Mensajes.ErrorSimple(T("La cuenta no esta habilitada o no es válida.", "The account is disabled or not valid."))
            Return False
        End If

        Dim monedaCuenta = cuentaDebitoCompleto.Split(" ")(1)
        Dim montoADebitar = ObtenerMontoNormalizado(monto, moneda, monedaCuenta)
        Dim saldoCuenta = ObtenerSaldoCuenta(cuentaDebitoCompleto).Split(" ")(1)

        If saldoCuenta < montoADebitar Then
            Mensajes.ErrorSimple(T("La cuenta no poseé los fondos suficientes para esta operación.", "The account does not have enough funds to perform this operation."))
            Return False
        End If

        NuevoMovimiento(String.Format("DEBITO CHEQUE CAJA {0}-{1}-{2}", serieLibreta, numeroLibreta, numeroCheque), -1 * montoADebitar, cuentaDebitoCompleto)
        Dim nuevoSaldo = saldoCuenta - montoADebitar
        Dim idCuenta = cuentaDebitoCompleto.Split(" ")(2)
        Dim cm = New OdbcCommand(String.Format("UPDATE cuenta SET saldo={0} WHERE idcuenta={1}", nuevoSaldo, idCuenta), cx)

        If cm.ExecuteNonQuery() > 0 Then
            RegistrarAccion("Debito cheque", String.Format("cuenta={0};moneda={1};monto={2}", cuentaDebitoCompleto, moneda, monto))
            Return True
        End If

        Return False

    End Function

    Public Function EfectuarRetiro(ByVal cuentaBeneficiarioCompleto As String, ByVal moneda As String, ByVal monto As Decimal) As Boolean
        Dim cx = ConexionBaseDatos.ObtenerActual()

        If Not CuentaEstaHabilitada(cuentaBeneficiarioCompleto) Then
            Mensajes.ErrorSimple(T("La cuenta no esta habilitada o no es válida.", "The account is disabled or not valid."))
            Return False
        End If

        Dim monedaCuenta = cuentaBeneficiarioCompleto.Split(" ")(1)
        Dim montoADebitar = ObtenerMontoNormalizado(monto, moneda, monedaCuenta)
        Dim saldoCuenta = ObtenerSaldoCuenta(cuentaBeneficiarioCompleto).Split(" ")(1)

        If saldoCuenta < montoADebitar Then
            Mensajes.ErrorSimple(T("La cuenta no poseé los fondos suficientes para esta operación.", "The account does not have enough funds to perform this operation."))
            Return False
        End If

        NuevoMovimiento("RETIRO CAJA", -1 * montoADebitar, cuentaBeneficiarioCompleto)
        Dim nuevoSaldo = saldoCuenta - montoADebitar
        Dim idCuenta = cuentaBeneficiarioCompleto.Split(" ")(2)
        Dim cm = New OdbcCommand(String.Format("UPDATE cuenta SET saldo={0} WHERE idcuenta={1}", nuevoSaldo, idCuenta), cx)

        If cm.ExecuteNonQuery() > 0 Then
            RegistrarAccion("Retiro de cuenta", String.Format("cuenta={0};moneda={1};monto={2}", cuentaBeneficiarioCompleto, moneda, monto))
            Return True
        End If

        Return False

    End Function

    Public Function EfectuarDeposito(ByVal cuentaBeneficiarioCompleto As String, ByVal moneda As String, ByVal monto As Decimal, Optional ByVal noLimitar As Boolean = False) As Boolean
        Dim cx = ConexionBaseDatos.ObtenerActual()

        If Not CuentaEstaHabilitada(cuentaBeneficiarioCompleto) Then
            Mensajes.ErrorSimple(T("La cuenta no esta habilitada o no es válida.", "The account is disabled or not valid."))
            Return False
        End If

        Dim montoEnUYU = ObtenerMontoNormalizado(monto, moneda)

        Dim banco = New Banco()

        If noLimitar = False Then
            If montoEnUYU > banco.MaxDepositoSinDeclararPesos Then
                If Not Mensajes.PreguntaSiNo(String.Format(T("El monto del deposito (UYU {0}) excede los limites establecidos por el banco. (UYU {2}) ¿Confirma que el depositante declaró el origen de los fondos?", "The deposit amount (UYU {0}) exceeds the bank free-deposit limit (UYU {2}). Confirm the client declared its procedence?."), montoEnUYU, banco.MinimoDepositoSinDeclararPesos, banco.MaxDepositoSinDeclararPesos), T("Limite excedido", "Limit exceeded")) Then
                    Return False
                End If
            ElseIf montoEnUYU < banco.MinimoDepositoSinDeclararPesos Then
                Mensajes.ErrorSimple(String.Format(T("El monto no llega al minimo de depósito (UYU {0}).", "The amount does not reach the minimum deposit limit (UYU {0})"), banco.MinimoDepositoSinDeclararPesos))
                Return False
            End If
        End If

        Dim monedaCuenta = cuentaBeneficiarioCompleto.Split(" ")(1)
        Dim saldoCuenta = ObtenerSaldoCuenta(cuentaBeneficiarioCompleto).Split(" ")(1)
        Dim montoACreditar = ObtenerMontoNormalizado(monto, moneda, monedaCuenta)

        NuevoMovimiento("DEPOSITO CAJA EFECTIVO", montoACreditar, cuentaBeneficiarioCompleto)
        Dim nuevoSaldo = saldoCuenta + montoACreditar
        Dim cmCredito = New OdbcCommand(String.Format("UPDATE cuenta SET saldo={0} WHERE idcuenta={1}", nuevoSaldo, cuentaBeneficiarioCompleto.Split(" ")(2)), cx)

        RegistrarAccion("Deposito en cuenta", String.Format("cuenta={0};moneda={1};monto={2}", cuentaBeneficiarioCompleto, monedaCuenta, montoACreditar))

        Return cmCredito.ExecuteNonQuery() > 0
    End Function

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
                    Mensajes.ErrorSimple(T("El saldo de la cuenta de origen es insuficiente.", "The origin account does not have enough funds."))
                Case ValidezTransaccion.CuentaOrigenNoHabilitadaNoValida
                    Mensajes.ErrorSimple(T("La cuenta de origen no está habilitada o no es válida.", "The origin account is not enabled or not valid."))
                Case ValidezTransaccion.CuentaDestinoNoHabilitadaNoValida
                    Mensajes.ErrorSimple(T("La cuenta de destino no está habilitada o no es válida.", "The destination account is not enabled or not valid."))
                Case ValidezTransaccion.CuentaNoValida
                    Mensajes.ErrorSimple(T("La cuenta de destino o de origen no és válida.", "One of the accounts is not valid."))
                Case Else
                    Mensajes.ErrorSimple(T("La transferencia no pudo ser validada. Comuniquese con el gerente de la sucursal.", "The transaction could not be validated. Please contact support."))
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
        Dim tasaDolares = Cotizaciones.cotUSD
        Dim tasaEuros = Cotizaciones.cotEUR

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

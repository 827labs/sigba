Imports System.Data.Odbc
Module Cuentas
    Public Function CrearCuenta(ByVal tipoCliente As Clientes.TipoCliente, ByVal idCliente As Integer, ByVal tipoCuenta As String, ByVal usoFirmas As String, ByVal moneda As String, ByVal sucursal As String) As Boolean
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim fechaActual = Date.Today()
        Dim fechaApertura = fechaActual.ToString(FormatoFecha())
        Dim saldoInicial = 0

        Dim sql = String.Format("INSERT INTO cuenta (fechaapertura, moneda, usofirmas, tipo, numsuc, saldo, idcliente) VALUES ('{0}', '{1}', '{2}', '{3}', {4}, {5}, {6});", fechaApertura, moneda, usoFirmas, tipoCuenta, sucursal, saldoInicial, idCliente)
        Dim cm = New OdbcCommand(sql, cx)

        Try
            cm.ExecuteNonQuery()
            RegistrarAccion("Alta cuenta", String.Format("numsuc={0};moneda={1};tipo={2};usofirmas={3};idcliente={4}", sucursal, moneda, tipoCuenta, usoFirmas, idCliente))
            Return True
        Catch ex As Exception
            Mensajes.ErrorSimple(ex.Message)
            Return False
        End Try
    End Function

    Public Function BajarCuenta(ByVal idCuenta As Integer) As Boolean
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim fecha = Date.Today.ToString(FormatoFecha())
        Dim cm = New OdbcCommand(String.Format("UPDATE cuenta set fechacierre='{0}' where idcuenta={1}", fecha, idCuenta), cx)
        Try
            cm.ExecuteNonQuery()
            RegistrarAccion("Baja cuenta", String.Format("idcuenta={0}", idCuenta))
            Return True
        Catch ex As Exception
            Mensajes.ErrorSimple(ex.Message)
            Return False
        End Try
    End Function

    Public Sub BuscarCuentasCorrienteCombo(ByVal idCliente As Integer, ByRef cbo As ComboBox)
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cm = New OdbcCommand("SELECT tipo || ' ' || moneda || ' ' || idcuenta cuen FROM cuenta WHERE fechacierre IS NULL AND tipo='CC' AND idcliente=" & idCliente, cx)
        Dim lector = cm.ExecuteReader()

        cbo.Items.Clear()

        While lector.Read()
            cbo.Items.Add(lector("cuen"))
        End While
    End Sub

    Public Sub BuscarCuentasDGV(ByVal idCliente As Integer, ByRef dgv As DataGridView)
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cm = New OdbcCommand("SELECT tipo || ' ' || moneda || ' ' || idcuenta, saldo  FROM cuenta WHERE fechacierre IS NULL AND idcliente=" & idCliente, cx)
        Dim da = New OdbcDataAdapter(cm)
        Dim ds = New DataSet
        da.Fill(ds, "cuenta")
        dgv.DataSource = ds.Tables("cuenta")

        With dgv
            .Columns(0).HeaderCell.Value = "Número"
            .Columns(1).HeaderCell.Value = "Saldo"
        End With
    End Sub

    Public Function ObtenerNombreTitularCuenta(ByVal nroCuentaCompleto As String) As String
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim nroCuentaSplitteado = nroCuentaCompleto.Split(" ")
        Dim nroCuenta = nroCuentaSplitteado(2)

        Dim cm = New OdbcCommand(String.Format("SELECT idcliente from cuenta where idcuenta={0}", nroCuenta), cx)
        Dim idCliente = cm.ExecuteScalar()

        Dim tipoCliente = ObtenerTipoCliente(idCliente)

        Return ObtenerNombreCliente(idCliente, tipoCliente)
    End Function

    Public Function ObtenerSaldoCuenta(ByVal nroCuentaCompleto As String) As String
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim nroCuentaSplitteado = nroCuentaCompleto.Split(" ")
        Dim nroCuenta = nroCuentaSplitteado(2)

        Dim cm = New OdbcCommand(String.Format("SELECT moneda || ' ' ||  saldo from cuenta where idcuenta={0}", nroCuenta), cx)

        Return cm.ExecuteScalar()
    End Function

    Public Function CuentaEstaHabilitada(ByVal numeroCuentaCompleto As String) As Boolean
        Dim tipo = numeroCuentaCompleto.Split()(0)
        Dim moneda = numeroCuentaCompleto.Split()(1)
        Dim idcuenta = numeroCuentaCompleto.Split()(2)

        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cm = New OdbcCommand(String.Format("SELECT COUNT(*) FROM cuenta WHERE fechacierre IS NULL AND tipo='{0}' AND moneda='{1}' AND idcuenta={2}", tipo, moneda, idcuenta), cx)

        Return Val(cm.ExecuteScalar()) > 0
    End Function

End Module

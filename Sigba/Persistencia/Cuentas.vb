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

    Public Sub BuscarCuentasDGV(ByVal idCliente As Integer, ByRef dgv As DataGridView)
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cm = New OdbcCommand("SELECT tipo || ' ' || moneda || ' ' || idcuenta, saldo  FROM cuenta WHERE idcliente=" & idCliente, cx)
        Dim da = New OdbcDataAdapter(cm)
        Dim ds = New DataSet
        da.Fill(ds, "cuenta")
        dgv.DataSource = ds.Tables("cuenta")

        With dgv
            .Columns(0).HeaderCell.Value = "Número"
            .Columns(1).HeaderCell.Value = "Saldo"
        End With
    End Sub
End Module

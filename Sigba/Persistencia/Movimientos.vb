Imports System.Data.Odbc

Module Movimientos
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
End Module

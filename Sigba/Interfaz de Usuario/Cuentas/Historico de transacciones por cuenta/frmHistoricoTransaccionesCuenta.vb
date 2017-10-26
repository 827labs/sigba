Public Class frmHistoricoTransaccionesCuenta

    Public Sub SetearNroCuenta(ByVal nroCuenta As String)
        HistoricoCuentaDGV(dgvTransacciones, nroCuenta)
        txtNroCuenta.Text = nroCuenta
    End Sub
End Class
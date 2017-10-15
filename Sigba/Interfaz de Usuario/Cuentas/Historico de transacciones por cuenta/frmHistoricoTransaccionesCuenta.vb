Public Class frmHistoricoTransaccionesCuenta

    Public Sub SetearNroCuenta(ByVal nroCuenta As String)
        HistoricoCuentaDGV(dgvTransacciones, nroCuenta)
        txtNroCuenta.Text = nroCuenta
    End Sub

    Private Sub frmHistoricoTransaccionesCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub
End Class
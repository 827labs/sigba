Public Class frmCierreCaja
    ' Estas variables solo se utilizan en la primera entrega
    ' a fin de simular una diferencia con el saldo previo de la caja.
    Dim ejemploSaldoActualUYU = 21823
    Dim ejemploSaldoActualUSD = 7513

    Private Sub frmCierreCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtFecha.Text = Generadores.StringFechaActual()
        txtHora.Text = Generadores.StringHoraActual()
    End Sub

    Private Sub KPSoloNumeros(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSaldoUYU.KeyPress, txtSaldoUSD.KeyPress, txtCaja.KeyPress, txtCajero.KeyPress, txtSucursal.KeyPress
        Validadores.KeyPressSoloNumeros(e)
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class
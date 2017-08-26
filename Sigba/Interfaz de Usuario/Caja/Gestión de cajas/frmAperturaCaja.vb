Public Class frmAperturaCaja

    Private Sub frmAperturaCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtFecha.Text = Generadores.StringFechaActual()
        txtHora.Text = Generadores.StringHoraActual()
        txtCajero.Text = Autenticacion.usuario
        txtCajero.Enabled = False

        Dim cajero = New Usuario(Autenticacion.usuario)

        txtEmailCajero.Text = String.Format("{0}, {1}", cajero.Apellido, cajero.Nombre)
    End Sub

    Private Sub KPSoloNumeros(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSaldoUSD.KeyPress, txtSaldoUYU.KeyPress, txtSucursal.KeyPress, txtCaja.KeyPress, txtCajero.KeyPress
        Validadores.KeyPressSoloNumeros(e)
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click

    End Sub
End Class
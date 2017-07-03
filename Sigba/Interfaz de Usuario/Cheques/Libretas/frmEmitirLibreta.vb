Public Class frmEmitirLibreta

    Private Sub EmitirLibreta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboPaisDocCliente.Items.AddRange(Constantes.Paises())
        cboPaisDocCliente.SelectedIndex = 187
    End Sub

    Private Sub txtNroDocCliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroDocCliente.KeyPress
        Validadores.KeyPressDocumento(e, cboTipoDocCliente, txtNroDocCliente)
    End Sub

    Private Sub txtNroDocCliente_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroDocCliente.Leave
        If txtNroDocCliente.Text <> "" Then
            cboNumCuenta.Items.Add("CC UYU 045-018925-2 - Franco Correa - UYU 2814,28")
            cboNumCuenta.Items.Add("CC USD 045-018925-2 - Franco Correa - USD 75,31")
            cboNumCuenta.SelectedIndex = 0
        End If
    End Sub

    Private Sub txtCantCheques_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantCheques.KeyPress
        Validadores.KeyPressSoloNumeros(e)
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class
Public Class frmEmitirLibreta

    Private Sub EmitirLibreta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboPaisDocCliente.Items.AddRange(Constantes.Paises())
        cboPaisDocCliente.SelectedIndex = 187
        cboTipoDocCliente.SelectedIndex = 0
    End Sub

    Private Sub txtNroDocCliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroDocCliente.KeyPress
        Validadores.KeyPressDocumento(e, cboTipoDocCliente, txtNroDocCliente)
    End Sub

    Private Sub txtNroDocCliente_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroDocCliente.Leave
        If txtNroDocCliente.Text <> "" Then
            cboNumCuenta.Items.Add("CC UYU 045-018925-2 - Franco Correa - UYU 2814,28")
            cboNumCuenta.Items.Add("CC USD 045-018925-2 - Franco Correa - USD 75,31")
            cboNumCuenta.SelectedIndex = 0
            txtSerieLibreta.Text = "001"
            txtNroLibreta.Text = "45189252-001"
        End If
    End Sub

    Private Sub KPSoloNumeros(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantCheques.KeyPress, txtNroLibreta.KeyPress, txtSerieLibreta.KeyPress
        Validadores.KeyPressSoloNumeros(e)
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnEmitir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmitir.Click
        If (cboPaisDocCliente.Text <> "" _
            And cboTipoDocCliente.Text <> "" _
            And txtNroDocCliente.Text <> "" _
            And cboNumCuenta.Text <> "" _
            And txtSerieLibreta.Text <> "" _
            And txtNroLibreta.Text <> "" _
            And txtCantCheques.Text <> "" _
            And Val(txtCantCheques.Text) <> 0 _
        ) Then
            If MessageBox.Show("¿Confirma la emisión de la libreta?", "Confirmar", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                MessageBox.Show("Libreta emitida exitosamente")
                Me.Close()
            End If
        Else
            MessageBox.Show("Compruebe los campos")
        End If
    End Sub
End Class
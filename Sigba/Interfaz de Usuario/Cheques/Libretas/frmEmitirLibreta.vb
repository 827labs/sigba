Public Class frmEmitirLibreta

    Private Sub EmitirLibreta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim banco = New Banco()
        If banco.HabilitarCCPersonas = False Then
            txtNroDoc.Text = T("El banco no permite la emisión de cheques a personas", "The bank does not allow people to have checkbooks")
            txtNroDoc.Enabled = False
        End If
    End Sub

    Private Sub KPSoloNumeros(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantCheques.KeyPress, txtNroLibreta.KeyPress, txtSerieLibreta.KeyPress
        Validadores.KeyPressSoloNumeros(e)
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnEmitir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmitir.Click
        If ( _
            cboNumCuenta.Text <> "" _
            And txtSerieLibreta.Text <> "" _
            And txtNroLibreta.Text <> "" _
            And txtCantCheques.Text <> "" _
            And Val(txtCantCheques.Text) <> 0 _
        ) Then
            If MessageBox.Show(T("¿Confirma la emisión de la libreta?", "Confirm checkbook creation?"), T("Confirmar", "Confirm"), MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                If Libretas.CrearLibreta(cboNumCuenta.Text, txtSerieLibreta.Text, txtNroLibreta.Text, txtCantCheques.Text) Then
                    MessageBox.Show(T("Libreta emitida exitosamente", "Checkbook has been created successfully"))
                    Me.Close()
                End If
            End If
        Else
            MessageBox.Show(T("Compruebe los campos", "Check all fields are completed"))
        End If
    End Sub

    Private Sub txtRUT_TextChanged(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles txtRUT.TextChanged, txtNroDoc.TextChanged
        Dim tipo = If(tabTipoCli.SelectedIndex = 0, TipoCliente.Empresa, TipoCliente.Persona)
        Dim idCliente = ObtenerIdCliente(sender.Text, tipo)
        BuscarCuentasCorrienteCombo(idCliente, cboNumCuenta)
    End Sub

    Private Sub txtRUT_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRUT.KeyPress
        Validadores.KeyPressRUT(e, txtRUT.Text)
    End Sub
End Class
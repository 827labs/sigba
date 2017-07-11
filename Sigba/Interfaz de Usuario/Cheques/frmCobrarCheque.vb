Public Class frmCobrarCheque

    Private Sub frmCobrarCheque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboPaisDoc.Items.AddRange(Constantes.Paises())
        cboPaisDoc.SelectedIndex = 187
    End Sub

    Private Sub txtNroDoc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroDoc.KeyPress
        Validadores.KeyPressDocumento(e, cboTipoDoc, txtNroDoc)
    End Sub

    Private Sub txtFechaEmision_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFechaEmision.TextChanged
        If cboTipoCheque.SelectedIndex = 0 Then
            txtFechaCobro.Enabled = False
            txtFechaCobro.Text = txtFechaEmision.Text
        ElseIf cboTipoCheque.SelectedIndex = 1 Then
            txtFechaCobro.Enabled = True
        Else
            txtFechaCobro.Enabled = False
            txtFechaCobro.Text = txtFechaEmision.Text
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        If ( _
            cboTipoCheque.Text <> "" _
            And cboTipoCobro.Text <> "" _
            And txtFechaEmision.Text <> "__/__/____" _
            And txtFechaCobro.Text <> "__/__/____" _
            And cboPaisDoc.Text <> "" _
            And cboTipoDoc.Text <> "" _
            And txtNroDoc.Text <> "" _
            And cboMontoMoneda.Text <> "" _
            And txtMontoCantidad.Text <> "" _
            And Val(txtMontoCantidad.Text) <> 0 _
            And txtNumLibreta.Text <> "" _
            And txtNumSerie.Text <> "" _
            And txtNumCheque.Text <> "") Then

            If MessageBox.Show("¿Desea confirmar el cobro del cheque?", "Confirmar", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                MessageBox.Show("Transacción completada existosamente")
                Me.Close()
            End If
        Else
            MessageBox.Show("Compruebe los campos")
        End If
    End Sub
End Class
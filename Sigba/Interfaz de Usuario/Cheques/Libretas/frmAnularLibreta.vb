Public Class frmAnularLibreta
    Dim clienteEjemplo = "12345678 - PEREZ, JUAN"

    Private Function FormularioEsValido()
        Dim condicion = txtNumLibreta.Text <> "" And Val(txtNumLibreta.Text) <> 0 And Val(txtSerieLibreta.Text) <> 0
        If condicion = False Then
            MessageBox.Show("Compruebe los campos")
        End If
        Return condicion
    End Function

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
        If FormularioEsValido() Then
            Dim respuesta = MessageBox.Show("Está seguro que desea confirmar la anulación de la libreta? Todos los futuros cheques emitidos en esta libreta no se podrán ser cobrados.", "Confirmación", MessageBoxButtons.YesNo)

            If respuesta = Windows.Forms.DialogResult.Yes Then
                MessageBox.Show("Libreta anulada exitosamente")
                Me.Close()
            End If
        End If
    End Sub

    Private Sub txtNumLibreta_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumLibreta.Leave
        lblCliente.Visible = True
        lblCliente.Text = Me.clienteEjemplo
    End Sub

    Private Sub KPSoloNumeros(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumLibreta.KeyPress, txtSerieLibreta.KeyPress
        Validadores.KeyPressSoloNumeros(e)
    End Sub
End Class
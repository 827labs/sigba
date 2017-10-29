Public Class frmAnularLibreta


    Private Function FormularioEsValido()
        Dim condicion = txtNumLibreta.Text <> "" And Val(txtNumLibreta.Text) <> 0 And Val(txtSerieLibreta.Text) <> 0
        If condicion = False Then
            MessageBox.Show(T("Compruebe los campos", "Check the fields"))
        End If
        Return condicion
    End Function

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
        If FormularioEsValido() Then
            Dim respuesta = MessageBox.Show(T("Está seguro que desea confirmar la anulación de la libreta? Todos los futuros cheques emitidos en esta libreta no se podrán ser cobrados.", "Are you sure you want to delete the checkbook?"), T("Confirmación", "Confirm"), MessageBoxButtons.YesNo)

            If respuesta = Windows.Forms.DialogResult.Yes Then
                If Libretas.EliminarLibreta(txtSerieLibreta.Text, txtNumLibreta.Text) Then
                    MessageBox.Show(T("Libreta anulada exitosamente", "Checkbook deleted successfully"))
                End If
                Me.Close()
            End If
        End If
    End Sub

    Private Sub KPSoloNumeros(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumLibreta.KeyPress, txtSerieLibreta.KeyPress
        Validadores.KeyPressSoloNumeros(e)
    End Sub
End Class
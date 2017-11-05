Public Class frmDebitoAutomatico

    Dim cuenta As String

    Public Sub SetearNroCuenta(ByVal nrocuenta As String)
        Me.cuenta = nrocuenta
        lblTitulo.Text = T("Suscripciones de débito automático para la cuenta ", "Automatic debits for the account: ") & nrocuenta
        CompletarDGVDebitos(Me.cuenta, dgvDebitos)
    End Sub

    Private Sub dgvDebitos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDebitos.CellClick

    End Sub

    Private Sub btnNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNueva.Click
        Dim form = New frmNuevoDebitoAutomatico()
        form.Show()
        form.SetearNroCuenta(Me.cuenta)
    End Sub

    Private Sub dgvDebitos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDebitos.CellContentClick
        Dim idSeleccionado = dgvDebitos.Rows(e.RowIndex).Cells(0).Value

        If Mensajes.PreguntaSiNo(T("¿Confirma la eliminación?", "Confirm?"), "") Then

            If DebitosAutomaticos.Eliminar(idSeleccionado) Then
                CompletarDGVDebitos(Me.cuenta, dgvDebitos)
                Mensajes.Simple(T("El débito se ha eliminado exitosamente", "Success!"))
            End If

        End If
    End Sub
End Class
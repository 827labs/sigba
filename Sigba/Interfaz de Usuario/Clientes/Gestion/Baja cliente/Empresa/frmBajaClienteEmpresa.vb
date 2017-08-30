Public Class frmBajaClienteEmpresa
    Dim RutDePrueba = "1234567890"
    Dim EmpresaDePrueba = "827Labs S.R.L."

    Private Sub btnContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinuar.Click

    End Sub

    Private Sub txtRUT_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRUT.TextChanged
        If txtRUT.Text = Me.RutDePrueba Then
            lblNombreEmpresa.Text = Me.EmpresaDePrueba
        End If
    End Sub
End Class
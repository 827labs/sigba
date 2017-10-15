Public Class frmBajaCuenta
    Private NroCuenta As String = ""

    Public Sub SetearNroCuenta(ByVal nroCuenta As String)
        Me.NroCuenta = nroCuenta
        lblCuenta.Text = nroCuenta
        lblTitular.Text = ObtenerNombreTitularCuenta(nroCuenta)
    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click

        Dim decision = MessageBox.Show("La cuenta se archivará.", "Confirmar cierre", MessageBoxButtons.YesNo)
        If decision = Windows.Forms.DialogResult.Yes Then
            Dim idCuenta = Me.NroCuenta.Split(" ")(2)
            Dim pudoBajarCuenta = Cuentas.BajarCuenta(idCuenta)

            If (pudoBajarCuenta) Then
                MessageBox.Show("Cuenta archivada exitosamente.")
                Me.Close()
            End If

        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class
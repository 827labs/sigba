Public Class frmBusquedaCuentaPorCliente

    Private Function FormularioEsValido() As Boolean
        Dim condicion = ( _
            cboPaisDoc.Text <> "" _
            And cboTipoDoc.Text <> "" _
            And txtNroDoc.Text <> "" _
        )

        If cboTipoDoc.SelectedIndex = 0 Then
            condicion = condicion And txtNroDoc.TextLength = 8
        End If

        If condicion = False Then
            MessageBox.Show("Complete todos los campos para realizar la búsqueda.")
        End If

        Return condicion
    End Function

    Private Sub InicializarFormulario()
        cboPaisDoc.SelectedIndex = 187
        cboTipoDoc.SelectedIndex = 0
        txtNroDoc.Clear()
    End Sub

    Private Sub frmBusquedaCuentaPorCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        InicializarFormulario()
    End Sub

    Private Sub txtNroDoc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroDoc.KeyPress
        Validadores.KeyPressDocumento(e, cboTipoDoc, txtNroDoc)
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        dgvCuentas.Rows.Clear()

        If FormularioEsValido() = True Then
            dgvCuentas.Rows.Add("CA UYU 045-048325-2", "UYU 827,00", "02/12/2016")
            dgvCuentas.Rows.Add("CA USD 045-048325-2", "USD 751,30", "32/12/2016")
        End If

        InicializarFormulario()
    End Sub

    Private Sub dgvCuentas_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCuentas.CellClick
        frmHistoricoTransaccionesCuenta.Show()
    End Sub
End Class
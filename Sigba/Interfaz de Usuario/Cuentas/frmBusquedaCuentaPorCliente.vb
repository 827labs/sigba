Public Class frmBusquedaCuentaPorCliente

    Dim tipoBusqueda As TipoBusquedaCuenta = tipoBusquedaCuenta.Visualizacion

    Public Enum TipoBusquedaCuenta
        Visualizacion = 0
        Baja = 1
    End Enum

    Public Sub SetearTipoBusquedaCuenta(ByVal tipo As TipoBusquedaCuenta)
        Me.tipoBusqueda = tipo
    End Sub

    Private Function FormularioEsValido() As Boolean
        Dim condicion = ( _
            cboPaisDoc.Text <> "" _
            And cboTipoDoc.Text <> "" _
            And txtNroDoc.Text <> "" _
        ) Or ( _
            txtRUT.Text <> "" _
        )

        If cboTipoDoc.SelectedIndex = 0 And txtRUT.Text = "" Then
            condicion = condicion And txtNroDoc.TextLength = 8
        End If

        If condicion = False Then
            MessageBox.Show("Complete los campos para realizar la búsqueda.")
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
            dgvCuentas.Rows.Add("CA USD 045-048325-2", "USD 751,30", "31/12/2016")
        End If

        InicializarFormulario()
    End Sub

    Private Sub dgvCuentas_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCuentas.CellClick
        If Me.tipoBusqueda = TipoBusquedaCuenta.Visualizacion Then
            frmHistoricoTransaccionesCuenta.Show()
        ElseIf Me.tipoBusqueda = TipoBusquedaCuenta.Baja Then
            frmBajaCuenta.Show()
        End If
    End Sub

    Private Sub txtRUT_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRUT.KeyPress
        Validadores.KeyPressRUT(e, txtRUT.Text)
    End Sub
End Class
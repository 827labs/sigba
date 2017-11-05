Public Class frmBusquedaCuentaPorCliente

    Dim tipoBusqueda As TipoBusquedaCuenta = TipoBusquedaCuenta.Visualizacion
    Dim notificable As Action(Of String)

    Public Enum TipoBusquedaCuenta
        Visualizacion = 0
        Baja = 1
        DebitoAutomatico = 2
        Notificable = 3
    End Enum

    Public Sub SetearTipoBusquedaCuenta(ByVal tipo As TipoBusquedaCuenta)
        Me.tipoBusqueda = tipo
        Dim textoAuxiliar As String

        Select Case tipo
            Case TipoBusquedaCuenta.Visualizacion
                textoAuxiliar = "Seleccione una cuenta para ver los movimientos recientes."
            Case TipoBusquedaCuenta.Baja
                textoAuxiliar = "Seleccione una cuenta para dar de baja."
            Case TipoBusquedaCuenta.DebitoAutomatico
                textoAuxiliar = "Seleccione una cuenta para ver sus débitos automáticos."
            Case Else
                textoAuxiliar = "Seleccione una cuenta para continuar."
        End Select

        lblMotivoAux.Text = textoAuxiliar
    End Sub

    Public Sub SetearNotificable(ByVal noti As Action(Of String))
        ' El notificable sirve para avisarle a una ventana padre
        ' en caso de ser necesario, que el usuario ha seleccionado una cuenta
        Me.notificable = noti
        Me.SetearTipoBusquedaCuenta(TipoBusquedaCuenta.Notificable)
    End Sub

    Private Function FormularioEsValido() As Boolean
        Dim condicion = ( _
            txtNroDoc.Text <> "" _
        ) Or ( _
            txtRUT.Text <> "" _
        )

        If condicion = False Then
            MessageBox.Show("Complete los campos para realizar la búsqueda.")
        End If

        Return condicion
    End Function

    Private Sub InicializarFormulario()
        txtNroDoc.Clear()
    End Sub

    Private Sub frmBusquedaCuentaPorCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        InicializarFormulario()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            dgvCuentas.Rows.Clear()
        Catch ex As Exception

        End Try

        If FormularioEsValido() = True Then
            Dim tipoCuenta = If(TabControl.SelectedIndex = 0, Clientes.TipoCliente.Persona, Clientes.TipoCliente.Empresa)
            Dim pkTextField = If(tipoCuenta = TipoCliente.Persona, txtNroDoc, txtRUT)
            Dim idCliente = Clientes.ObtenerIdCliente(pkTextField.Text, tipoCuenta)

            ' Rellenar DGV
            Cuentas.BuscarCuentasDGV(idCliente, dgvCuentas)
        End If

        InicializarFormulario()
    End Sub

    Private Sub dgvCuentas_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCuentas.CellClick
        Dim nroCuenta = dgvCuentas.Rows(e.RowIndex).Cells(0).Value

        If Me.tipoBusqueda = TipoBusquedaCuenta.Visualizacion Then
            Dim frmHistorico = New frmHistoricoTransaccionesCuenta()
            frmHistorico.Show()
            frmHistorico.SetearNroCuenta(nroCuenta)
        ElseIf Me.tipoBusqueda = TipoBusquedaCuenta.Baja Then
            Dim frmBaja = New frmBajaCuenta()
            frmBaja.Show()
            frmBaja.SetearNroCuenta(nroCuenta)
        ElseIf Me.tipoBusqueda = TipoBusquedaCuenta.DebitoAutomatico Then
            Dim form = New frmDebitoAutomatico()
            form.Show()
            form.SetearNroCuenta(nroCuenta)
        ElseIf Me.tipoBusqueda = TipoBusquedaCuenta.Notificable Then
            If Not (Me.notificable Is Nothing) Then
                Me.notificable(nroCuenta)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub txtRUT_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRUT.KeyPress
        Validadores.KeyPressRUT(e, txtRUT.Text)
    End Sub

End Class
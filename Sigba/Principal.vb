Public Class Principal


    ' El formulario 'Principal' actúa como un menú de funcionalidades
    ' donde el usuario es libre de elegir a que sección del sistema quiere dirigirse.

    Private Sub Principal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ' Si se cierra el formulario principal,
        ' terminar la ejecucion el programa.
        Application.Exit()
    End Sub

    Private Sub GestionarUsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionarUsuariosToolStripMenuItem.Click
        frmGestionUsuarios.Show()
    End Sub

    Private Sub AdministraciónDeCargosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministraciónDeCargosToolStripMenuItem.Click
        frmGestionCargos.Show()
    End Sub

    Private Sub RecuperacionDeContraseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecuperacionDeContraseToolStripMenuItem.Click
        frmRecuperacionClaveEmisor.Show()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        AcercaDe.Show()
    End Sub

    Private Sub AltaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmAgregarClienteEmpresa.Show()
    End Sub

    Private Sub BajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmBajaCliente.Show()
    End Sub

    Private Sub PersonaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonaToolStripMenuItem.Click
        frmAgregarClienteEmpresa.Show()
    End Sub

    Private Sub PersonaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonaToolStripMenuItem1.Click
        frmBajaCliente.Show()
    End Sub

    Private Sub EmpresaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpresaToolStripMenuItem.Click
        frmAltaClienteEmpresa.Show()
    End Sub

    Private Sub EmpresaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpresaToolStripMenuItem1.Click
        frmBajaClienteEmpresa.Show()
    End Sub

    Private Sub HistóricoDeTransacciónesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistóricoDeTransacciónesToolStripMenuItem.Click
        frmBusquedaCuentaPorCliente.Show()
    End Sub

    Private Sub EmitirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmitirToolStripMenuItem.Click
        frmEmitirLibreta.Show()
    End Sub

    Private Sub DatosDelBancoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatosDelBancoToolStripMenuItem.Click
        frmDatosBanco.Show()
    End Sub

    Private Sub AnularToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnularToolStripMenuItem.Click
        frmAnularLibreta.Show()
    End Sub

    Private Sub AperturaDeCajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AperturaDeCajaToolStripMenuItem.Click
        frmAperturaCaja.Show()
    End Sub

    Private Sub CajasAbiertasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CajasAbiertasToolStripMenuItem.Click
        frmCierreCaja.Show()
    End Sub

    Private Sub AltaDeCuentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaDeCuentaToolStripMenuItem.Click
        frmNuevaCuenta.Show()
    End Sub

    Private Sub BajaDeCuentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaDeCuentaToolStripMenuItem.Click
        Dim form = New frmBusquedaCuentaPorCliente()
        form.SetearTipoBusquedaCuenta(frmBusquedaCuentaPorCliente.TipoBusquedaCuenta.Baja)
        form.Show()
    End Sub

    Private Sub CobrarChequeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CobrarChequeToolStripMenuItem.Click
        frmCobrarCheque.Show()
    End Sub

    Private Sub AuditoriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AuditoriaToolStripMenuItem.Click
        frmAuditoria.Show()
    End Sub

    Private Sub DébitosAutomáticosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DébitosAutomáticosToolStripMenuItem.Click
        Dim form = New frmBusquedaCuentaPorCliente()
        form.SetearTipoBusquedaCuenta(frmBusquedaCuentaPorCliente.TipoBusquedaCuenta.DebitoAutomatico)
        form.Show()
    End Sub

    Private Sub RetiroDeCuentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetiroDeCuentaToolStripMenuItem.Click
        frmRetiroCuenta.Show()
    End Sub

    Private Sub DepósitoEnCuentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepósitoEnCuentaToolStripMenuItem.Click
        frmDepositoCuenta.Show()
    End Sub

    Private Sub TransferenciaEntreCuentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransferenciaEntreCuentasToolStripMenuItem.Click
        frmTransferenciaCuentas.Show()
    End Sub

    Private Sub IngresarUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresarUsuarioToolStripMenuItem.Click
        frmNuevoUsuario.Show()
    End Sub

    Private Sub AdministracíToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministracíToolStripMenuItem.Click
        frmListaSucursales.Show()
    End Sub

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim usuario = New Usuario(Autenticacion.usuario)
        lblStatusUsuario.Text = String.Format("CI: {2} ({0} {1}) - {3}", usuario.Nombre, usuario.Apellido, usuario.NumDocU, usuario.EmailU)

        Dim cargo = usuario.Cargo()
        lblCargo.Text = cargo

        Select Case cargo
            Case Autenticacion.RolAuxiliar
                ConfiguraciónToolStripMenuItem.Visible = False
                ClientesToolStripMenuItem.Visible = False
                GestiónCuentasToolStripMenuItem.Visible = False
                DébitosAutomáticosToolStripMenuItem.Visible = False
                LibretasToolStripMenuItem.Visible = False

            Case Autenticacion.RolEjecutivo
                ConfiguraciónToolStripMenuItem.Visible = False
                CobrarChequeToolStripMenuItem.Visible = False
                CajaToolStripMenuItem.Visible = False
                DepósitoEnCuentaToolStripMenuItem.Visible = False
                RetiroDeCuentaToolStripMenuItem.Visible = False

            Case Autenticacion.RolGerente
                CajaToolStripMenuItem.Visible = False
                GestiónCuentasToolStripMenuItem.Visible = False
                DébitosAutomáticosToolStripMenuItem.Visible = False
                DepósitoEnCuentaToolStripMenuItem.Visible = False
                RetiroDeCuentaToolStripMenuItem.Visible = False
                ChequesToolStripMenuItem.Visible = False
        End Select
    End Sub
End Class
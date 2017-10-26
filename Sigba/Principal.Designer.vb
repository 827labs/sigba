<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.strItems = New System.Windows.Forms.MenuStrip
        Me.CajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GestiónDeCajasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AperturaDeCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CajasAbiertasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CuentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GestiónCuentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaDeCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaDeCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HistóricoDeTransacciónesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DébitosAutomáticosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DepósitoEnCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RetiroDeCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TransferenciaEntreCuentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GestiónToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PersonaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChequesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LibretasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmitirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AnularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CobrarChequeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AdministraciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GestionarUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IngresarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DatosDelBancoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AuditoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AdministracíToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.picSigba = New System.Windows.Forms.PictureBox
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.lblStatusUsuario = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblCargo = New System.Windows.Forms.Label
        Me.strItems.SuspendLayout()
        CType(Me.picSigba, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'strItems
        '
        Me.strItems.AccessibleDescription = Nothing
        Me.strItems.AccessibleName = Nothing
        resources.ApplyResources(Me.strItems, "strItems")
        Me.strItems.BackgroundImage = Nothing
        Me.strItems.Font = Nothing
        Me.strItems.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CajaToolStripMenuItem, Me.CuentasToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ChequesToolStripMenuItem, Me.ConfiguraciónToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.strItems.Name = "strItems"
        '
        'CajaToolStripMenuItem
        '
        Me.CajaToolStripMenuItem.AccessibleDescription = Nothing
        Me.CajaToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.CajaToolStripMenuItem, "CajaToolStripMenuItem")
        Me.CajaToolStripMenuItem.BackgroundImage = Nothing
        Me.CajaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestiónDeCajasToolStripMenuItem})
        Me.CajaToolStripMenuItem.Name = "CajaToolStripMenuItem"
        Me.CajaToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        '
        'GestiónDeCajasToolStripMenuItem
        '
        Me.GestiónDeCajasToolStripMenuItem.AccessibleDescription = Nothing
        Me.GestiónDeCajasToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.GestiónDeCajasToolStripMenuItem, "GestiónDeCajasToolStripMenuItem")
        Me.GestiónDeCajasToolStripMenuItem.BackgroundImage = Nothing
        Me.GestiónDeCajasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AperturaDeCajaToolStripMenuItem, Me.CajasAbiertasToolStripMenuItem})
        Me.GestiónDeCajasToolStripMenuItem.Name = "GestiónDeCajasToolStripMenuItem"
        Me.GestiónDeCajasToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        '
        'AperturaDeCajaToolStripMenuItem
        '
        Me.AperturaDeCajaToolStripMenuItem.AccessibleDescription = Nothing
        Me.AperturaDeCajaToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.AperturaDeCajaToolStripMenuItem, "AperturaDeCajaToolStripMenuItem")
        Me.AperturaDeCajaToolStripMenuItem.BackgroundImage = Nothing
        Me.AperturaDeCajaToolStripMenuItem.Name = "AperturaDeCajaToolStripMenuItem"
        Me.AperturaDeCajaToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        '
        'CajasAbiertasToolStripMenuItem
        '
        Me.CajasAbiertasToolStripMenuItem.AccessibleDescription = Nothing
        Me.CajasAbiertasToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.CajasAbiertasToolStripMenuItem, "CajasAbiertasToolStripMenuItem")
        Me.CajasAbiertasToolStripMenuItem.BackgroundImage = Nothing
        Me.CajasAbiertasToolStripMenuItem.Name = "CajasAbiertasToolStripMenuItem"
        Me.CajasAbiertasToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        '
        'CuentasToolStripMenuItem
        '
        Me.CuentasToolStripMenuItem.AccessibleDescription = Nothing
        Me.CuentasToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.CuentasToolStripMenuItem, "CuentasToolStripMenuItem")
        Me.CuentasToolStripMenuItem.BackgroundImage = Nothing
        Me.CuentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestiónCuentasToolStripMenuItem, Me.HistóricoDeTransacciónesToolStripMenuItem, Me.DébitosAutomáticosToolStripMenuItem, Me.DepósitoEnCuentaToolStripMenuItem, Me.RetiroDeCuentaToolStripMenuItem, Me.TransferenciaEntreCuentasToolStripMenuItem})
        Me.CuentasToolStripMenuItem.Name = "CuentasToolStripMenuItem"
        Me.CuentasToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        '
        'GestiónCuentasToolStripMenuItem
        '
        Me.GestiónCuentasToolStripMenuItem.AccessibleDescription = Nothing
        Me.GestiónCuentasToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.GestiónCuentasToolStripMenuItem, "GestiónCuentasToolStripMenuItem")
        Me.GestiónCuentasToolStripMenuItem.BackgroundImage = Nothing
        Me.GestiónCuentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDeCuentaToolStripMenuItem, Me.BajaDeCuentaToolStripMenuItem})
        Me.GestiónCuentasToolStripMenuItem.Name = "GestiónCuentasToolStripMenuItem"
        Me.GestiónCuentasToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        '
        'AltaDeCuentaToolStripMenuItem
        '
        Me.AltaDeCuentaToolStripMenuItem.AccessibleDescription = Nothing
        Me.AltaDeCuentaToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.AltaDeCuentaToolStripMenuItem, "AltaDeCuentaToolStripMenuItem")
        Me.AltaDeCuentaToolStripMenuItem.BackgroundImage = Nothing
        Me.AltaDeCuentaToolStripMenuItem.Name = "AltaDeCuentaToolStripMenuItem"
        Me.AltaDeCuentaToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        '
        'BajaDeCuentaToolStripMenuItem
        '
        Me.BajaDeCuentaToolStripMenuItem.AccessibleDescription = Nothing
        Me.BajaDeCuentaToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.BajaDeCuentaToolStripMenuItem, "BajaDeCuentaToolStripMenuItem")
        Me.BajaDeCuentaToolStripMenuItem.BackgroundImage = Nothing
        Me.BajaDeCuentaToolStripMenuItem.Name = "BajaDeCuentaToolStripMenuItem"
        Me.BajaDeCuentaToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        '
        'HistóricoDeTransacciónesToolStripMenuItem
        '
        Me.HistóricoDeTransacciónesToolStripMenuItem.AccessibleDescription = Nothing
        Me.HistóricoDeTransacciónesToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.HistóricoDeTransacciónesToolStripMenuItem, "HistóricoDeTransacciónesToolStripMenuItem")
        Me.HistóricoDeTransacciónesToolStripMenuItem.BackgroundImage = Nothing
        Me.HistóricoDeTransacciónesToolStripMenuItem.Name = "HistóricoDeTransacciónesToolStripMenuItem"
        Me.HistóricoDeTransacciónesToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        '
        'DébitosAutomáticosToolStripMenuItem
        '
        Me.DébitosAutomáticosToolStripMenuItem.AccessibleDescription = Nothing
        Me.DébitosAutomáticosToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.DébitosAutomáticosToolStripMenuItem, "DébitosAutomáticosToolStripMenuItem")
        Me.DébitosAutomáticosToolStripMenuItem.BackgroundImage = Nothing
        Me.DébitosAutomáticosToolStripMenuItem.Name = "DébitosAutomáticosToolStripMenuItem"
        Me.DébitosAutomáticosToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        '
        'DepósitoEnCuentaToolStripMenuItem
        '
        Me.DepósitoEnCuentaToolStripMenuItem.AccessibleDescription = Nothing
        Me.DepósitoEnCuentaToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.DepósitoEnCuentaToolStripMenuItem, "DepósitoEnCuentaToolStripMenuItem")
        Me.DepósitoEnCuentaToolStripMenuItem.BackgroundImage = Nothing
        Me.DepósitoEnCuentaToolStripMenuItem.Name = "DepósitoEnCuentaToolStripMenuItem"
        Me.DepósitoEnCuentaToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        '
        'RetiroDeCuentaToolStripMenuItem
        '
        Me.RetiroDeCuentaToolStripMenuItem.AccessibleDescription = Nothing
        Me.RetiroDeCuentaToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.RetiroDeCuentaToolStripMenuItem, "RetiroDeCuentaToolStripMenuItem")
        Me.RetiroDeCuentaToolStripMenuItem.BackgroundImage = Nothing
        Me.RetiroDeCuentaToolStripMenuItem.Name = "RetiroDeCuentaToolStripMenuItem"
        Me.RetiroDeCuentaToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        '
        'TransferenciaEntreCuentasToolStripMenuItem
        '
        Me.TransferenciaEntreCuentasToolStripMenuItem.AccessibleDescription = Nothing
        Me.TransferenciaEntreCuentasToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.TransferenciaEntreCuentasToolStripMenuItem, "TransferenciaEntreCuentasToolStripMenuItem")
        Me.TransferenciaEntreCuentasToolStripMenuItem.BackgroundImage = Nothing
        Me.TransferenciaEntreCuentasToolStripMenuItem.Name = "TransferenciaEntreCuentasToolStripMenuItem"
        Me.TransferenciaEntreCuentasToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.AccessibleDescription = Nothing
        Me.ClientesToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.ClientesToolStripMenuItem, "ClientesToolStripMenuItem")
        Me.ClientesToolStripMenuItem.BackgroundImage = Nothing
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestiónToolStripMenuItem1})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        '
        'GestiónToolStripMenuItem1
        '
        Me.GestiónToolStripMenuItem1.AccessibleDescription = Nothing
        Me.GestiónToolStripMenuItem1.AccessibleName = Nothing
        resources.ApplyResources(Me.GestiónToolStripMenuItem1, "GestiónToolStripMenuItem1")
        Me.GestiónToolStripMenuItem1.BackgroundImage = Nothing
        Me.GestiónToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaClienteToolStripMenuItem, Me.BajaClienteToolStripMenuItem})
        Me.GestiónToolStripMenuItem1.Name = "GestiónToolStripMenuItem1"
        Me.GestiónToolStripMenuItem1.ShortcutKeyDisplayString = Nothing
        '
        'AltaClienteToolStripMenuItem
        '
        Me.AltaClienteToolStripMenuItem.AccessibleDescription = Nothing
        Me.AltaClienteToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.AltaClienteToolStripMenuItem, "AltaClienteToolStripMenuItem")
        Me.AltaClienteToolStripMenuItem.BackgroundImage = Nothing
        Me.AltaClienteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonaToolStripMenuItem, Me.EmpresaToolStripMenuItem})
        Me.AltaClienteToolStripMenuItem.Name = "AltaClienteToolStripMenuItem"
        Me.AltaClienteToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        '
        'PersonaToolStripMenuItem
        '
        Me.PersonaToolStripMenuItem.AccessibleDescription = Nothing
        Me.PersonaToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.PersonaToolStripMenuItem, "PersonaToolStripMenuItem")
        Me.PersonaToolStripMenuItem.BackgroundImage = Nothing
        Me.PersonaToolStripMenuItem.Name = "PersonaToolStripMenuItem"
        Me.PersonaToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        '
        'EmpresaToolStripMenuItem
        '
        Me.EmpresaToolStripMenuItem.AccessibleDescription = Nothing
        Me.EmpresaToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.EmpresaToolStripMenuItem, "EmpresaToolStripMenuItem")
        Me.EmpresaToolStripMenuItem.BackgroundImage = Nothing
        Me.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        Me.EmpresaToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        '
        'BajaClienteToolStripMenuItem
        '
        Me.BajaClienteToolStripMenuItem.AccessibleDescription = Nothing
        Me.BajaClienteToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.BajaClienteToolStripMenuItem, "BajaClienteToolStripMenuItem")
        Me.BajaClienteToolStripMenuItem.BackgroundImage = Nothing
        Me.BajaClienteToolStripMenuItem.Name = "BajaClienteToolStripMenuItem"
        Me.BajaClienteToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        '
        'ChequesToolStripMenuItem
        '
        Me.ChequesToolStripMenuItem.AccessibleDescription = Nothing
        Me.ChequesToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.ChequesToolStripMenuItem, "ChequesToolStripMenuItem")
        Me.ChequesToolStripMenuItem.BackgroundImage = Nothing
        Me.ChequesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LibretasToolStripMenuItem, Me.CobrarChequeToolStripMenuItem})
        Me.ChequesToolStripMenuItem.Name = "ChequesToolStripMenuItem"
        Me.ChequesToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        '
        'LibretasToolStripMenuItem
        '
        Me.LibretasToolStripMenuItem.AccessibleDescription = Nothing
        Me.LibretasToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.LibretasToolStripMenuItem, "LibretasToolStripMenuItem")
        Me.LibretasToolStripMenuItem.BackgroundImage = Nothing
        Me.LibretasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmitirToolStripMenuItem, Me.AnularToolStripMenuItem})
        Me.LibretasToolStripMenuItem.Name = "LibretasToolStripMenuItem"
        Me.LibretasToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        '
        'EmitirToolStripMenuItem
        '
        Me.EmitirToolStripMenuItem.AccessibleDescription = Nothing
        Me.EmitirToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.EmitirToolStripMenuItem, "EmitirToolStripMenuItem")
        Me.EmitirToolStripMenuItem.BackgroundImage = Nothing
        Me.EmitirToolStripMenuItem.Name = "EmitirToolStripMenuItem"
        Me.EmitirToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        '
        'AnularToolStripMenuItem
        '
        Me.AnularToolStripMenuItem.AccessibleDescription = Nothing
        Me.AnularToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.AnularToolStripMenuItem, "AnularToolStripMenuItem")
        Me.AnularToolStripMenuItem.BackgroundImage = Nothing
        Me.AnularToolStripMenuItem.Name = "AnularToolStripMenuItem"
        Me.AnularToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        '
        'CobrarChequeToolStripMenuItem
        '
        Me.CobrarChequeToolStripMenuItem.AccessibleDescription = Nothing
        Me.CobrarChequeToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.CobrarChequeToolStripMenuItem, "CobrarChequeToolStripMenuItem")
        Me.CobrarChequeToolStripMenuItem.BackgroundImage = Nothing
        Me.CobrarChequeToolStripMenuItem.Name = "CobrarChequeToolStripMenuItem"
        Me.CobrarChequeToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.AccessibleDescription = Nothing
        Me.ConfiguraciónToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.ConfiguraciónToolStripMenuItem, "ConfiguraciónToolStripMenuItem")
        Me.ConfiguraciónToolStripMenuItem.BackgroundImage = Nothing
        Me.ConfiguraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministraciToolStripMenuItem, Me.DatosDelBancoToolStripMenuItem, Me.AuditoriaToolStripMenuItem, Me.AdministracíToolStripMenuItem})
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        '
        'AdministraciToolStripMenuItem
        '
        Me.AdministraciToolStripMenuItem.AccessibleDescription = Nothing
        Me.AdministraciToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.AdministraciToolStripMenuItem, "AdministraciToolStripMenuItem")
        Me.AdministraciToolStripMenuItem.BackgroundImage = Nothing
        Me.AdministraciToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarUsuariosToolStripMenuItem, Me.IngresarUsuarioToolStripMenuItem})
        Me.AdministraciToolStripMenuItem.Name = "AdministraciToolStripMenuItem"
        Me.AdministraciToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        '
        'GestionarUsuariosToolStripMenuItem
        '
        Me.GestionarUsuariosToolStripMenuItem.AccessibleDescription = Nothing
        Me.GestionarUsuariosToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.GestionarUsuariosToolStripMenuItem, "GestionarUsuariosToolStripMenuItem")
        Me.GestionarUsuariosToolStripMenuItem.BackgroundImage = Nothing
        Me.GestionarUsuariosToolStripMenuItem.Name = "GestionarUsuariosToolStripMenuItem"
        Me.GestionarUsuariosToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        '
        'IngresarUsuarioToolStripMenuItem
        '
        Me.IngresarUsuarioToolStripMenuItem.AccessibleDescription = Nothing
        Me.IngresarUsuarioToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.IngresarUsuarioToolStripMenuItem, "IngresarUsuarioToolStripMenuItem")
        Me.IngresarUsuarioToolStripMenuItem.BackgroundImage = Nothing
        Me.IngresarUsuarioToolStripMenuItem.Name = "IngresarUsuarioToolStripMenuItem"
        Me.IngresarUsuarioToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        '
        'DatosDelBancoToolStripMenuItem
        '
        Me.DatosDelBancoToolStripMenuItem.AccessibleDescription = Nothing
        Me.DatosDelBancoToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.DatosDelBancoToolStripMenuItem, "DatosDelBancoToolStripMenuItem")
        Me.DatosDelBancoToolStripMenuItem.BackgroundImage = Nothing
        Me.DatosDelBancoToolStripMenuItem.Name = "DatosDelBancoToolStripMenuItem"
        Me.DatosDelBancoToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        '
        'AuditoriaToolStripMenuItem
        '
        Me.AuditoriaToolStripMenuItem.AccessibleDescription = Nothing
        Me.AuditoriaToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.AuditoriaToolStripMenuItem, "AuditoriaToolStripMenuItem")
        Me.AuditoriaToolStripMenuItem.BackgroundImage = Nothing
        Me.AuditoriaToolStripMenuItem.Name = "AuditoriaToolStripMenuItem"
        Me.AuditoriaToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        '
        'AdministracíToolStripMenuItem
        '
        Me.AdministracíToolStripMenuItem.AccessibleDescription = Nothing
        Me.AdministracíToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.AdministracíToolStripMenuItem, "AdministracíToolStripMenuItem")
        Me.AdministracíToolStripMenuItem.BackgroundImage = Nothing
        Me.AdministracíToolStripMenuItem.Name = "AdministracíToolStripMenuItem"
        Me.AdministracíToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.AccessibleDescription = Nothing
        Me.AyudaToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.AyudaToolStripMenuItem, "AyudaToolStripMenuItem")
        Me.AyudaToolStripMenuItem.BackgroundImage = Nothing
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.AccessibleDescription = Nothing
        Me.AcercaDeToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.AcercaDeToolStripMenuItem, "AcercaDeToolStripMenuItem")
        Me.AcercaDeToolStripMenuItem.BackgroundImage = Nothing
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        '
        'picSigba
        '
        Me.picSigba.AccessibleDescription = Nothing
        Me.picSigba.AccessibleName = Nothing
        resources.ApplyResources(Me.picSigba, "picSigba")
        Me.picSigba.BackgroundImage = Nothing
        Me.picSigba.Font = Nothing
        Me.picSigba.ImageLocation = Nothing
        Me.picSigba.Name = "picSigba"
        Me.picSigba.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AccessibleDescription = Nothing
        Me.StatusStrip1.AccessibleName = Nothing
        resources.ApplyResources(Me.StatusStrip1, "StatusStrip1")
        Me.StatusStrip1.BackgroundImage = Nothing
        Me.StatusStrip1.Font = Nothing
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatusUsuario})
        Me.StatusStrip1.Name = "StatusStrip1"
        '
        'lblStatusUsuario
        '
        Me.lblStatusUsuario.AccessibleDescription = Nothing
        Me.lblStatusUsuario.AccessibleName = Nothing
        resources.ApplyResources(Me.lblStatusUsuario, "lblStatusUsuario")
        Me.lblStatusUsuario.BackgroundImage = Nothing
        Me.lblStatusUsuario.Name = "lblStatusUsuario"
        '
        'lblCargo
        '
        Me.lblCargo.AccessibleDescription = Nothing
        Me.lblCargo.AccessibleName = Nothing
        resources.ApplyResources(Me.lblCargo, "lblCargo")
        Me.lblCargo.Font = Nothing
        Me.lblCargo.Name = "lblCargo"
        '
        'Principal
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.lblCargo)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.picSigba)
        Me.Controls.Add(Me.strItems)
        Me.Font = Nothing
        Me.MainMenuStrip = Me.strItems
        Me.Name = "Principal"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.strItems.ResumeLayout(False)
        Me.strItems.PerformLayout()
        CType(Me.picSigba, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents strItems As System.Windows.Forms.MenuStrip
    Friend WithEvents CajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestiónDeCajasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChequesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picSigba As System.Windows.Forms.PictureBox
    Friend WithEvents AperturaDeCajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CajasAbiertasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministraciToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionarUsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestiónCuentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaDeCuentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaDeCuentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistóricoDeTransacciónesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestiónToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpresaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LibretasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmitirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnularToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CobrarChequeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatosDelBancoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DébitosAutomáticosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepósitoEnCuentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RetiroDeCuentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransferenciaEntreCuentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AuditoriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresarUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministracíToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatusUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblCargo As System.Windows.Forms.Label
End Class

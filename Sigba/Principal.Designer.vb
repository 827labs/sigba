﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.GestiónDeCajerosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VerificarTransacciónreciboToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CuentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GestiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaDeCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaDeCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HistóricoDeTransacciónesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GestiónToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PersonaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PersonaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.EmpresaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ChequesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AdministraciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GestionarUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RecuperacionDeContraseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AdministraciónDeCargosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.picSigba = New System.Windows.Forms.PictureBox
        Me.strItems.SuspendLayout()
        CType(Me.picSigba, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'strItems
        '
        Me.strItems.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CajaToolStripMenuItem, Me.CuentasToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ChequesToolStripMenuItem, Me.ConfiguraciónToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.strItems.Location = New System.Drawing.Point(0, 0)
        Me.strItems.Name = "strItems"
        Me.strItems.Size = New System.Drawing.Size(919, 24)
        Me.strItems.TabIndex = 0
        Me.strItems.Text = "MenuStrip1"
        '
        'CajaToolStripMenuItem
        '
        Me.CajaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestiónDeCajasToolStripMenuItem, Me.GestiónDeCajerosToolStripMenuItem, Me.VerificarTransacciónreciboToolStripMenuItem})
        Me.CajaToolStripMenuItem.Name = "CajaToolStripMenuItem"
        Me.CajaToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.CajaToolStripMenuItem.Text = "Caja"
        '
        'GestiónDeCajasToolStripMenuItem
        '
        Me.GestiónDeCajasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AperturaDeCajaToolStripMenuItem, Me.CajasAbiertasToolStripMenuItem})
        Me.GestiónDeCajasToolStripMenuItem.Name = "GestiónDeCajasToolStripMenuItem"
        Me.GestiónDeCajasToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.GestiónDeCajasToolStripMenuItem.Text = "Gestión de cajas"
        '
        'AperturaDeCajaToolStripMenuItem
        '
        Me.AperturaDeCajaToolStripMenuItem.Name = "AperturaDeCajaToolStripMenuItem"
        Me.AperturaDeCajaToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.AperturaDeCajaToolStripMenuItem.Text = "Apertura de caja"
        '
        'CajasAbiertasToolStripMenuItem
        '
        Me.CajasAbiertasToolStripMenuItem.Name = "CajasAbiertasToolStripMenuItem"
        Me.CajasAbiertasToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.CajasAbiertasToolStripMenuItem.Text = "Cajas abiertas"
        '
        'GestiónDeCajerosToolStripMenuItem
        '
        Me.GestiónDeCajerosToolStripMenuItem.Name = "GestiónDeCajerosToolStripMenuItem"
        Me.GestiónDeCajerosToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.GestiónDeCajerosToolStripMenuItem.Text = "Gestión de cajeros"
        '
        'VerificarTransacciónreciboToolStripMenuItem
        '
        Me.VerificarTransacciónreciboToolStripMenuItem.Name = "VerificarTransacciónreciboToolStripMenuItem"
        Me.VerificarTransacciónreciboToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.VerificarTransacciónreciboToolStripMenuItem.Text = "Verificar transacción/recibo"
        '
        'CuentasToolStripMenuItem
        '
        Me.CuentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestiónToolStripMenuItem, Me.HistóricoDeTransacciónesToolStripMenuItem})
        Me.CuentasToolStripMenuItem.Name = "CuentasToolStripMenuItem"
        Me.CuentasToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.CuentasToolStripMenuItem.Text = "Cuentas"
        '
        'GestiónToolStripMenuItem
        '
        Me.GestiónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDeCuentaToolStripMenuItem, Me.BajaDeCuentaToolStripMenuItem})
        Me.GestiónToolStripMenuItem.Name = "GestiónToolStripMenuItem"
        Me.GestiónToolStripMenuItem.Size = New System.Drawing.Size(273, 22)
        Me.GestiónToolStripMenuItem.Text = "Gestión"
        '
        'AltaDeCuentaToolStripMenuItem
        '
        Me.AltaDeCuentaToolStripMenuItem.Name = "AltaDeCuentaToolStripMenuItem"
        Me.AltaDeCuentaToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.AltaDeCuentaToolStripMenuItem.Text = "Alta de cuenta"
        '
        'BajaDeCuentaToolStripMenuItem
        '
        Me.BajaDeCuentaToolStripMenuItem.Name = "BajaDeCuentaToolStripMenuItem"
        Me.BajaDeCuentaToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.BajaDeCuentaToolStripMenuItem.Text = "Baja de cuenta"
        '
        'HistóricoDeTransacciónesToolStripMenuItem
        '
        Me.HistóricoDeTransacciónesToolStripMenuItem.Name = "HistóricoDeTransacciónesToolStripMenuItem"
        Me.HistóricoDeTransacciónesToolStripMenuItem.Size = New System.Drawing.Size(273, 22)
        Me.HistóricoDeTransacciónesToolStripMenuItem.Text = "Histórico de transacciones por cuenta"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestiónToolStripMenuItem1})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'GestiónToolStripMenuItem1
        '
        Me.GestiónToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaClienteToolStripMenuItem, Me.BajaClienteToolStripMenuItem})
        Me.GestiónToolStripMenuItem1.Name = "GestiónToolStripMenuItem1"
        Me.GestiónToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.GestiónToolStripMenuItem1.Text = "Gestión"
        '
        'AltaClienteToolStripMenuItem
        '
        Me.AltaClienteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonaToolStripMenuItem, Me.EmpresaToolStripMenuItem})
        Me.AltaClienteToolStripMenuItem.Name = "AltaClienteToolStripMenuItem"
        Me.AltaClienteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AltaClienteToolStripMenuItem.Text = "Alta cliente"
        '
        'PersonaToolStripMenuItem
        '
        Me.PersonaToolStripMenuItem.Name = "PersonaToolStripMenuItem"
        Me.PersonaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PersonaToolStripMenuItem.Text = "Persona"
        '
        'EmpresaToolStripMenuItem
        '
        Me.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        Me.EmpresaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EmpresaToolStripMenuItem.Text = "Empresa"
        '
        'BajaClienteToolStripMenuItem
        '
        Me.BajaClienteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonaToolStripMenuItem1, Me.EmpresaToolStripMenuItem1})
        Me.BajaClienteToolStripMenuItem.Name = "BajaClienteToolStripMenuItem"
        Me.BajaClienteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BajaClienteToolStripMenuItem.Text = "Baja cliente"
        '
        'PersonaToolStripMenuItem1
        '
        Me.PersonaToolStripMenuItem1.Name = "PersonaToolStripMenuItem1"
        Me.PersonaToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.PersonaToolStripMenuItem1.Text = "Persona"
        '
        'EmpresaToolStripMenuItem1
        '
        Me.EmpresaToolStripMenuItem1.Name = "EmpresaToolStripMenuItem1"
        Me.EmpresaToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.EmpresaToolStripMenuItem1.Text = "Empresa"
        '
        'ChequesToolStripMenuItem
        '
        Me.ChequesToolStripMenuItem.Name = "ChequesToolStripMenuItem"
        Me.ChequesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ChequesToolStripMenuItem.Text = "Cheques"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministraciToolStripMenuItem, Me.AdministraciónDeCargosToolStripMenuItem})
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración"
        '
        'AdministraciToolStripMenuItem
        '
        Me.AdministraciToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarUsuariosToolStripMenuItem, Me.RecuperacionDeContraseToolStripMenuItem})
        Me.AdministraciToolStripMenuItem.Name = "AdministraciToolStripMenuItem"
        Me.AdministraciToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.AdministraciToolStripMenuItem.Text = "Administración de usuarios"
        '
        'GestionarUsuariosToolStripMenuItem
        '
        Me.GestionarUsuariosToolStripMenuItem.Name = "GestionarUsuariosToolStripMenuItem"
        Me.GestionarUsuariosToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.GestionarUsuariosToolStripMenuItem.Text = "Gestionar usuarios"
        '
        'RecuperacionDeContraseToolStripMenuItem
        '
        Me.RecuperacionDeContraseToolStripMenuItem.Name = "RecuperacionDeContraseToolStripMenuItem"
        Me.RecuperacionDeContraseToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.RecuperacionDeContraseToolStripMenuItem.Text = "Recuperación de contraseña"
        '
        'AdministraciónDeCargosToolStripMenuItem
        '
        Me.AdministraciónDeCargosToolStripMenuItem.Name = "AdministraciónDeCargosToolStripMenuItem"
        Me.AdministraciónDeCargosToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.AdministraciónDeCargosToolStripMenuItem.Text = "Administración de cargos"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'picSigba
        '
        Me.picSigba.Image = CType(resources.GetObject("picSigba.Image"), System.Drawing.Image)
        Me.picSigba.Location = New System.Drawing.Point(0, 25)
        Me.picSigba.Name = "picSigba"
        Me.picSigba.Size = New System.Drawing.Size(919, 570)
        Me.picSigba.TabIndex = 1
        Me.picSigba.TabStop = False
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 594)
        Me.Controls.Add(Me.picSigba)
        Me.Controls.Add(Me.strItems)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.strItems
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(935, 633)
        Me.MinimumSize = New System.Drawing.Size(935, 633)
        Me.Name = "Principal"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIGBA - Banco Republica"
        Me.strItems.ResumeLayout(False)
        Me.strItems.PerformLayout()
        CType(Me.picSigba, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents strItems As System.Windows.Forms.MenuStrip
    Friend WithEvents CajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestiónDeCajasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestiónDeCajerosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerificarTransacciónreciboToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
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
    Friend WithEvents RecuperacionDeContraseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministraciónDeCargosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaDeCuentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaDeCuentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistóricoDeTransacciónesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestiónToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpresaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpresaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class

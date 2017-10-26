<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevaCuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNuevaCuenta))
        Me.tabTipoCliente = New System.Windows.Forms.TabControl
        Me.tabPersona = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtNroDoc = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.tabEmpresa = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtRUT = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboTipoCuenta = New System.Windows.Forms.ComboBox
        Me.cboSucursal = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboUsoFormas = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnConfirmar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.txtClienteEncontrado = New System.Windows.Forms.Label
        Me.cboMoneda = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.tabTipoCliente.SuspendLayout()
        Me.tabPersona.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tabEmpresa.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabTipoCliente
        '
        Me.tabTipoCliente.AccessibleDescription = Nothing
        Me.tabTipoCliente.AccessibleName = Nothing
        resources.ApplyResources(Me.tabTipoCliente, "tabTipoCliente")
        Me.tabTipoCliente.BackgroundImage = Nothing
        Me.tabTipoCliente.Controls.Add(Me.tabPersona)
        Me.tabTipoCliente.Controls.Add(Me.tabEmpresa)
        Me.tabTipoCliente.Font = Nothing
        Me.tabTipoCliente.Name = "tabTipoCliente"
        Me.tabTipoCliente.SelectedIndex = 0
        '
        'tabPersona
        '
        Me.tabPersona.AccessibleDescription = Nothing
        Me.tabPersona.AccessibleName = Nothing
        resources.ApplyResources(Me.tabPersona, "tabPersona")
        Me.tabPersona.BackgroundImage = Nothing
        Me.tabPersona.Controls.Add(Me.GroupBox2)
        Me.tabPersona.Font = Nothing
        Me.tabPersona.Name = "tabPersona"
        Me.tabPersona.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.AccessibleDescription = Nothing
        Me.GroupBox2.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.BackgroundImage = Nothing
        Me.GroupBox2.Controls.Add(Me.txtNroDoc)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = Nothing
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'txtNroDoc
        '
        Me.txtNroDoc.AccessibleDescription = Nothing
        Me.txtNroDoc.AccessibleName = Nothing
        resources.ApplyResources(Me.txtNroDoc, "txtNroDoc")
        Me.txtNroDoc.BackgroundImage = Nothing
        Me.txtNroDoc.Font = Nothing
        Me.txtNroDoc.Name = "txtNroDoc"
        '
        'Label7
        '
        Me.Label7.AccessibleDescription = Nothing
        Me.Label7.AccessibleName = Nothing
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'tabEmpresa
        '
        Me.tabEmpresa.AccessibleDescription = Nothing
        Me.tabEmpresa.AccessibleName = Nothing
        resources.ApplyResources(Me.tabEmpresa, "tabEmpresa")
        Me.tabEmpresa.BackgroundImage = Nothing
        Me.tabEmpresa.Controls.Add(Me.GroupBox1)
        Me.tabEmpresa.Font = Nothing
        Me.tabEmpresa.Name = "tabEmpresa"
        Me.tabEmpresa.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleDescription = Nothing
        Me.GroupBox1.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.BackgroundImage = Nothing
        Me.GroupBox1.Controls.Add(Me.txtRUT)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = Nothing
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'txtRUT
        '
        Me.txtRUT.AccessibleDescription = Nothing
        Me.txtRUT.AccessibleName = Nothing
        resources.ApplyResources(Me.txtRUT, "txtRUT")
        Me.txtRUT.BackgroundImage = Nothing
        Me.txtRUT.Font = Nothing
        Me.txtRUT.Name = "txtRUT"
        '
        'Label9
        '
        Me.Label9.AccessibleDescription = Nothing
        Me.Label9.AccessibleName = Nothing
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'GroupBox3
        '
        Me.GroupBox3.AccessibleDescription = Nothing
        Me.GroupBox3.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.BackgroundImage = Nothing
        Me.GroupBox3.Controls.Add(Me.tabTipoCliente)
        Me.GroupBox3.Font = Nothing
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = Nothing
        Me.Label1.AccessibleName = Nothing
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Font = Nothing
        Me.Label1.Name = "Label1"
        '
        'cboTipoCuenta
        '
        Me.cboTipoCuenta.AccessibleDescription = Nothing
        Me.cboTipoCuenta.AccessibleName = Nothing
        resources.ApplyResources(Me.cboTipoCuenta, "cboTipoCuenta")
        Me.cboTipoCuenta.BackgroundImage = Nothing
        Me.cboTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoCuenta.Font = Nothing
        Me.cboTipoCuenta.FormattingEnabled = True
        Me.cboTipoCuenta.Items.AddRange(New Object() {resources.GetString("cboTipoCuenta.Items"), resources.GetString("cboTipoCuenta.Items1")})
        Me.cboTipoCuenta.Name = "cboTipoCuenta"
        '
        'cboSucursal
        '
        Me.cboSucursal.AccessibleDescription = Nothing
        Me.cboSucursal.AccessibleName = Nothing
        resources.ApplyResources(Me.cboSucursal, "cboSucursal")
        Me.cboSucursal.BackgroundImage = Nothing
        Me.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSucursal.Font = Nothing
        Me.cboSucursal.FormattingEnabled = True
        Me.cboSucursal.Items.AddRange(New Object() {resources.GetString("cboSucursal.Items"), resources.GetString("cboSucursal.Items1")})
        Me.cboSucursal.Name = "cboSucursal"
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = Nothing
        Me.Label2.AccessibleName = Nothing
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Font = Nothing
        Me.Label2.Name = "Label2"
        '
        'cboUsoFormas
        '
        Me.cboUsoFormas.AccessibleDescription = Nothing
        Me.cboUsoFormas.AccessibleName = Nothing
        resources.ApplyResources(Me.cboUsoFormas, "cboUsoFormas")
        Me.cboUsoFormas.BackgroundImage = Nothing
        Me.cboUsoFormas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUsoFormas.Font = Nothing
        Me.cboUsoFormas.FormattingEnabled = True
        Me.cboUsoFormas.Items.AddRange(New Object() {resources.GetString("cboUsoFormas.Items"), resources.GetString("cboUsoFormas.Items1"), resources.GetString("cboUsoFormas.Items2")})
        Me.cboUsoFormas.Name = "cboUsoFormas"
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = Nothing
        Me.Label3.AccessibleName = Nothing
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Font = Nothing
        Me.Label3.Name = "Label3"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.AccessibleDescription = Nothing
        Me.btnConfirmar.AccessibleName = Nothing
        resources.ApplyResources(Me.btnConfirmar, "btnConfirmar")
        Me.btnConfirmar.BackgroundImage = Nothing
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.AccessibleDescription = Nothing
        Me.btnCancelar.AccessibleName = Nothing
        resources.ApplyResources(Me.btnCancelar, "btnCancelar")
        Me.btnCancelar.BackgroundImage = Nothing
        Me.btnCancelar.Font = Nothing
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtClienteEncontrado
        '
        Me.txtClienteEncontrado.AccessibleDescription = Nothing
        Me.txtClienteEncontrado.AccessibleName = Nothing
        resources.ApplyResources(Me.txtClienteEncontrado, "txtClienteEncontrado")
        Me.txtClienteEncontrado.Font = Nothing
        Me.txtClienteEncontrado.Name = "txtClienteEncontrado"
        '
        'cboMoneda
        '
        Me.cboMoneda.AccessibleDescription = Nothing
        Me.cboMoneda.AccessibleName = Nothing
        resources.ApplyResources(Me.cboMoneda, "cboMoneda")
        Me.cboMoneda.BackgroundImage = Nothing
        Me.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda.Font = Nothing
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Items.AddRange(New Object() {resources.GetString("cboMoneda.Items"), resources.GetString("cboMoneda.Items1")})
        Me.cboMoneda.Name = "cboMoneda"
        '
        'Label4
        '
        Me.Label4.AccessibleDescription = Nothing
        Me.Label4.AccessibleName = Nothing
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Font = Nothing
        Me.Label4.Name = "Label4"
        '
        'frmNuevaCuenta
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.cboMoneda)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtClienteEncontrado)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.cboUsoFormas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboSucursal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboTipoCuenta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmNuevaCuenta"
        Me.tabTipoCliente.ResumeLayout(False)
        Me.tabPersona.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tabEmpresa.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabTipoCliente As System.Windows.Forms.TabControl
    Friend WithEvents tabPersona As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNroDoc As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tabEmpresa As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRUT As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboTipoCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents cboSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboUsoFormas As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtClienteEncontrado As System.Windows.Forms.Label
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class

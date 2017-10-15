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
        Me.tabTipoCliente.Controls.Add(Me.tabPersona)
        Me.tabTipoCliente.Controls.Add(Me.tabEmpresa)
        Me.tabTipoCliente.Location = New System.Drawing.Point(6, 19)
        Me.tabTipoCliente.Name = "tabTipoCliente"
        Me.tabTipoCliente.SelectedIndex = 0
        Me.tabTipoCliente.Size = New System.Drawing.Size(381, 108)
        Me.tabTipoCliente.TabIndex = 89
        '
        'tabPersona
        '
        Me.tabPersona.Controls.Add(Me.GroupBox2)
        Me.tabPersona.Location = New System.Drawing.Point(4, 22)
        Me.tabPersona.Name = "tabPersona"
        Me.tabPersona.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPersona.Size = New System.Drawing.Size(373, 82)
        Me.tabPersona.TabIndex = 0
        Me.tabPersona.Text = "Persona"
        Me.tabPersona.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNroDoc)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 67)
        Me.GroupBox2.TabIndex = 85
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Documento"
        '
        'txtNroDoc
        '
        Me.txtNroDoc.Location = New System.Drawing.Point(9, 33)
        Me.txtNroDoc.Name = "txtNroDoc"
        Me.txtNroDoc.Size = New System.Drawing.Size(129, 20)
        Me.txtNroDoc.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(6, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Número"
        '
        'tabEmpresa
        '
        Me.tabEmpresa.Controls.Add(Me.GroupBox1)
        Me.tabEmpresa.Location = New System.Drawing.Point(4, 22)
        Me.tabEmpresa.Name = "tabEmpresa"
        Me.tabEmpresa.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEmpresa.Size = New System.Drawing.Size(373, 82)
        Me.tabEmpresa.TabIndex = 1
        Me.tabEmpresa.Text = "Empresa"
        Me.tabEmpresa.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtRUT)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 67)
        Me.GroupBox1.TabIndex = 86
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Documento"
        '
        'txtRUT
        '
        Me.txtRUT.Location = New System.Drawing.Point(9, 31)
        Me.txtRUT.Name = "txtRUT"
        Me.txtRUT.Size = New System.Drawing.Size(139, 20)
        Me.txtRUT.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(6, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "RUT"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tabTipoCliente)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(392, 133)
        Me.GroupBox3.TabIndex = 90
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Tipo de cuenta"
        '
        'cboTipoCuenta
        '
        Me.cboTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoCuenta.FormattingEnabled = True
        Me.cboTipoCuenta.Items.AddRange(New Object() {"Cuenta de Ahorro (CA)", "Cuenta Corriente (CC)"})
        Me.cboTipoCuenta.Location = New System.Drawing.Point(13, 195)
        Me.cboTipoCuenta.Name = "cboTipoCuenta"
        Me.cboTipoCuenta.Size = New System.Drawing.Size(392, 21)
        Me.cboTipoCuenta.TabIndex = 92
        '
        'cboSucursal
        '
        Me.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSucursal.FormattingEnabled = True
        Me.cboSucursal.Items.AddRange(New Object() {"001 - Casa Central", "002 - Sucursal X"})
        Me.cboSucursal.Location = New System.Drawing.Point(13, 240)
        Me.cboSucursal.Name = "cboSucursal"
        Me.cboSucursal.Size = New System.Drawing.Size(154, 21)
        Me.cboSucursal.TabIndex = 94
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Sucursal"
        '
        'cboUsoFormas
        '
        Me.cboUsoFormas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUsoFormas.FormattingEnabled = True
        Me.cboUsoFormas.Items.AddRange(New Object() {"No Aplica", "Indistinta", "Conjunta"})
        Me.cboUsoFormas.Location = New System.Drawing.Point(173, 240)
        Me.cboUsoFormas.Name = "cboUsoFormas"
        Me.cboUsoFormas.Size = New System.Drawing.Size(232, 21)
        Me.cboUsoFormas.TabIndex = 96
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(170, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "Uso de firmas"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.Location = New System.Drawing.Point(219, 276)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(186, 26)
        Me.btnConfirmar.TabIndex = 98
        Me.btnConfirmar.Text = "Confirmar apertura de cuenta"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(146, 276)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(67, 26)
        Me.btnCancelar.TabIndex = 99
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtClienteEncontrado
        '
        Me.txtClienteEncontrado.AutoSize = True
        Me.txtClienteEncontrado.Location = New System.Drawing.Point(13, 153)
        Me.txtClienteEncontrado.Name = "txtClienteEncontrado"
        Me.txtClienteEncontrado.Size = New System.Drawing.Size(39, 13)
        Me.txtClienteEncontrado.TabIndex = 100
        Me.txtClienteEncontrado.Text = "Cliente"
        '
        'frmNuevaCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 313)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmNuevaCuenta"
        Me.Text = "Apertura de cuenta"
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
End Class

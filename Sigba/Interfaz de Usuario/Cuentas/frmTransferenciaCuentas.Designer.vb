<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransferenciaCuentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransferenciaCuentas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblSaldoCuentaOrigen = New System.Windows.Forms.Label
        Me.lblTitularCtaOrigen = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnBuscarCuentaOrigen = New System.Windows.Forms.Button
        Me.txtCuentaOrigen = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblTitularCtaDestino = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnBuscarCuentaDestino = New System.Windows.Forms.Button
        Me.txtCuentaDestino = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtMontoCantidad = New System.Windows.Forms.TextBox
        Me.cboMontoMoneda = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnTransferir = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleDescription = Nothing
        Me.GroupBox1.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.BackgroundImage = Nothing
        Me.GroupBox1.Controls.Add(Me.lblSaldoCuentaOrigen)
        Me.GroupBox1.Controls.Add(Me.lblTitularCtaOrigen)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnBuscarCuentaOrigen)
        Me.GroupBox1.Controls.Add(Me.txtCuentaOrigen)
        Me.GroupBox1.Font = Nothing
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'lblSaldoCuentaOrigen
        '
        Me.lblSaldoCuentaOrigen.AccessibleDescription = Nothing
        Me.lblSaldoCuentaOrigen.AccessibleName = Nothing
        resources.ApplyResources(Me.lblSaldoCuentaOrigen, "lblSaldoCuentaOrigen")
        Me.lblSaldoCuentaOrigen.Name = "lblSaldoCuentaOrigen"
        '
        'lblTitularCtaOrigen
        '
        Me.lblTitularCtaOrigen.AccessibleDescription = Nothing
        Me.lblTitularCtaOrigen.AccessibleName = Nothing
        resources.ApplyResources(Me.lblTitularCtaOrigen, "lblTitularCtaOrigen")
        Me.lblTitularCtaOrigen.Name = "lblTitularCtaOrigen"
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = Nothing
        Me.Label2.AccessibleName = Nothing
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Font = Nothing
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = Nothing
        Me.Label1.AccessibleName = Nothing
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Font = Nothing
        Me.Label1.Name = "Label1"
        '
        'btnBuscarCuentaOrigen
        '
        Me.btnBuscarCuentaOrigen.AccessibleDescription = Nothing
        Me.btnBuscarCuentaOrigen.AccessibleName = Nothing
        resources.ApplyResources(Me.btnBuscarCuentaOrigen, "btnBuscarCuentaOrigen")
        Me.btnBuscarCuentaOrigen.BackgroundImage = Nothing
        Me.btnBuscarCuentaOrigen.Font = Nothing
        Me.btnBuscarCuentaOrigen.Name = "btnBuscarCuentaOrigen"
        Me.btnBuscarCuentaOrigen.UseVisualStyleBackColor = True
        '
        'txtCuentaOrigen
        '
        Me.txtCuentaOrigen.AccessibleDescription = Nothing
        Me.txtCuentaOrigen.AccessibleName = Nothing
        resources.ApplyResources(Me.txtCuentaOrigen, "txtCuentaOrigen")
        Me.txtCuentaOrigen.BackgroundImage = Nothing
        Me.txtCuentaOrigen.Font = Nothing
        Me.txtCuentaOrigen.Name = "txtCuentaOrigen"
        '
        'GroupBox2
        '
        Me.GroupBox2.AccessibleDescription = Nothing
        Me.GroupBox2.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.BackgroundImage = Nothing
        Me.GroupBox2.Controls.Add(Me.lblTitularCtaDestino)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.btnBuscarCuentaDestino)
        Me.GroupBox2.Controls.Add(Me.txtCuentaDestino)
        Me.GroupBox2.Font = Nothing
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'lblTitularCtaDestino
        '
        Me.lblTitularCtaDestino.AccessibleDescription = Nothing
        Me.lblTitularCtaDestino.AccessibleName = Nothing
        resources.ApplyResources(Me.lblTitularCtaDestino, "lblTitularCtaDestino")
        Me.lblTitularCtaDestino.Name = "lblTitularCtaDestino"
        '
        'Label8
        '
        Me.Label8.AccessibleDescription = Nothing
        Me.Label8.AccessibleName = Nothing
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Font = Nothing
        Me.Label8.Name = "Label8"
        '
        'btnBuscarCuentaDestino
        '
        Me.btnBuscarCuentaDestino.AccessibleDescription = Nothing
        Me.btnBuscarCuentaDestino.AccessibleName = Nothing
        resources.ApplyResources(Me.btnBuscarCuentaDestino, "btnBuscarCuentaDestino")
        Me.btnBuscarCuentaDestino.BackgroundImage = Nothing
        Me.btnBuscarCuentaDestino.Font = Nothing
        Me.btnBuscarCuentaDestino.Name = "btnBuscarCuentaDestino"
        Me.btnBuscarCuentaDestino.UseVisualStyleBackColor = True
        '
        'txtCuentaDestino
        '
        Me.txtCuentaDestino.AccessibleDescription = Nothing
        Me.txtCuentaDestino.AccessibleName = Nothing
        resources.ApplyResources(Me.txtCuentaDestino, "txtCuentaDestino")
        Me.txtCuentaDestino.BackgroundImage = Nothing
        Me.txtCuentaDestino.Font = Nothing
        Me.txtCuentaDestino.Name = "txtCuentaDestino"
        '
        'GroupBox3
        '
        Me.GroupBox3.AccessibleDescription = Nothing
        Me.GroupBox3.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.BackgroundImage = Nothing
        Me.GroupBox3.Controls.Add(Me.txtMontoCantidad)
        Me.GroupBox3.Controls.Add(Me.cboMontoMoneda)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Font = Nothing
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'txtMontoCantidad
        '
        Me.txtMontoCantidad.AccessibleDescription = Nothing
        Me.txtMontoCantidad.AccessibleName = Nothing
        resources.ApplyResources(Me.txtMontoCantidad, "txtMontoCantidad")
        Me.txtMontoCantidad.BackgroundImage = Nothing
        Me.txtMontoCantidad.Font = Nothing
        Me.txtMontoCantidad.Name = "txtMontoCantidad"
        '
        'cboMontoMoneda
        '
        Me.cboMontoMoneda.AccessibleDescription = Nothing
        Me.cboMontoMoneda.AccessibleName = Nothing
        resources.ApplyResources(Me.cboMontoMoneda, "cboMontoMoneda")
        Me.cboMontoMoneda.BackgroundImage = Nothing
        Me.cboMontoMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMontoMoneda.Font = Nothing
        Me.cboMontoMoneda.FormattingEnabled = True
        Me.cboMontoMoneda.Items.AddRange(New Object() {resources.GetString("cboMontoMoneda.Items"), resources.GetString("cboMontoMoneda.Items1")})
        Me.cboMontoMoneda.Name = "cboMontoMoneda"
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = Nothing
        Me.Label3.AccessibleName = Nothing
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Font = Nothing
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        Me.Label4.AccessibleDescription = Nothing
        Me.Label4.AccessibleName = Nothing
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Font = Nothing
        Me.Label4.Name = "Label4"
        '
        'btnTransferir
        '
        Me.btnTransferir.AccessibleDescription = Nothing
        Me.btnTransferir.AccessibleName = Nothing
        resources.ApplyResources(Me.btnTransferir, "btnTransferir")
        Me.btnTransferir.BackgroundImage = Nothing
        Me.btnTransferir.Name = "btnTransferir"
        Me.btnTransferir.UseVisualStyleBackColor = True
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
        'frmTransferenciaCuentas
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnTransferir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmTransferenciaCuentas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscarCuentaOrigen As System.Windows.Forms.Button
    Friend WithEvents txtCuentaOrigen As System.Windows.Forms.TextBox
    Friend WithEvents lblSaldoCuentaOrigen As System.Windows.Forms.Label
    Friend WithEvents lblTitularCtaOrigen As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTitularCtaDestino As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarCuentaDestino As System.Windows.Forms.Button
    Friend WithEvents txtCuentaDestino As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMontoCantidad As System.Windows.Forms.TextBox
    Friend WithEvents cboMontoMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnTransferir As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class

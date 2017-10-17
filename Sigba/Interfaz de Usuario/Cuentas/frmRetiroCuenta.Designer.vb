<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetiroCuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRetiroCuenta))
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnConfirmar = New System.Windows.Forms.Button
        Me.cboMonto = New System.Windows.Forms.ComboBox
        Me.txtMontoCantidad = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnBuscarCuenta = New System.Windows.Forms.Button
        Me.txtCuentaBeneficiario = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(199, 62)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(65, 23)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.Location = New System.Drawing.Point(270, 62)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(84, 23)
        Me.btnConfirmar.TabIndex = 14
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'cboMonto
        '
        Me.cboMonto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonto.FormattingEnabled = True
        Me.cboMonto.Items.AddRange(New Object() {"UYU", "USD", "EUR"})
        Me.cboMonto.Location = New System.Drawing.Point(213, 28)
        Me.cboMonto.Name = "cboMonto"
        Me.cboMonto.Size = New System.Drawing.Size(51, 21)
        Me.cboMonto.TabIndex = 13
        '
        'txtMontoCantidad
        '
        Me.txtMontoCantidad.Location = New System.Drawing.Point(270, 28)
        Me.txtMontoCantidad.Name = "txtMontoCantidad"
        Me.txtMontoCantidad.Size = New System.Drawing.Size(84, 20)
        Me.txtMontoCantidad.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(210, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Monto:"
        '
        'btnBuscarCuenta
        '
        Me.btnBuscarCuenta.Location = New System.Drawing.Point(157, 26)
        Me.btnBuscarCuenta.Name = "btnBuscarCuenta"
        Me.btnBuscarCuenta.Size = New System.Drawing.Size(50, 23)
        Me.btnBuscarCuenta.TabIndex = 10
        Me.btnBuscarCuenta.Text = "Buscar"
        Me.btnBuscarCuenta.UseVisualStyleBackColor = True
        '
        'txtCuentaBeneficiario
        '
        Me.txtCuentaBeneficiario.Location = New System.Drawing.Point(10, 28)
        Me.txtCuentaBeneficiario.Name = "txtCuentaBeneficiario"
        Me.txtCuentaBeneficiario.Size = New System.Drawing.Size(141, 20)
        Me.txtCuentaBeneficiario.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nº cuenta a débitar:"
        '
        'frmRetiroCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 96)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.cboMonto)
        Me.Controls.Add(Me.txtMontoCantidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBuscarCuenta)
        Me.Controls.Add(Me.txtCuentaBeneficiario)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmRetiroCuenta"
        Me.Text = "Retiro de cuenta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents cboMonto As System.Windows.Forms.ComboBox
    Friend WithEvents txtMontoCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarCuenta As System.Windows.Forms.Button
    Friend WithEvents txtCuentaBeneficiario As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

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
        Me.txtCuentaOrigen = New System.Windows.Forms.TextBox
        Me.btnBuscarCuentaOrigen = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblSaldoCuentaOrigen = New System.Windows.Forms.Label
        Me.lblTitularCtaOrigen = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblTitularCtaDestino = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnBuscarCuentaDestino = New System.Windows.Forms.Button
        Me.txtCuentaDestino = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboMontoMoneda = New System.Windows.Forms.ComboBox
        Me.txtMontoCantidad = New System.Windows.Forms.TextBox
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
        Me.GroupBox1.Controls.Add(Me.lblSaldoCuentaOrigen)
        Me.GroupBox1.Controls.Add(Me.lblTitularCtaOrigen)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnBuscarCuentaOrigen)
        Me.GroupBox1.Controls.Add(Me.txtCuentaOrigen)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 89)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cuenta de origen"
        '
        'txtCuentaOrigen
        '
        Me.txtCuentaOrigen.Location = New System.Drawing.Point(6, 19)
        Me.txtCuentaOrigen.Name = "txtCuentaOrigen"
        Me.txtCuentaOrigen.Size = New System.Drawing.Size(189, 20)
        Me.txtCuentaOrigen.TabIndex = 0
        '
        'btnBuscarCuentaOrigen
        '
        Me.btnBuscarCuentaOrigen.Location = New System.Drawing.Point(200, 18)
        Me.btnBuscarCuentaOrigen.Name = "btnBuscarCuentaOrigen"
        Me.btnBuscarCuentaOrigen.Size = New System.Drawing.Size(53, 23)
        Me.btnBuscarCuentaOrigen.TabIndex = 1
        Me.btnBuscarCuentaOrigen.Text = "Buscar"
        Me.btnBuscarCuentaOrigen.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Titular:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Saldo disponible:"
        '
        'lblSaldoCuentaOrigen
        '
        Me.lblSaldoCuentaOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoCuentaOrigen.Location = New System.Drawing.Point(96, 62)
        Me.lblSaldoCuentaOrigen.Name = "lblSaldoCuentaOrigen"
        Me.lblSaldoCuentaOrigen.Size = New System.Drawing.Size(157, 13)
        Me.lblSaldoCuentaOrigen.TabIndex = 5
        Me.lblSaldoCuentaOrigen.Text = "UYU 123,45"
        Me.lblSaldoCuentaOrigen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTitularCtaOrigen
        '
        Me.lblTitularCtaOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitularCtaOrigen.Location = New System.Drawing.Point(48, 46)
        Me.lblTitularCtaOrigen.Name = "lblTitularCtaOrigen"
        Me.lblTitularCtaOrigen.Size = New System.Drawing.Size(205, 13)
        Me.lblTitularCtaOrigen.TabIndex = 4
        Me.lblTitularCtaOrigen.Text = "APELLIDO, NOMBRE"
        Me.lblTitularCtaOrigen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTitularCtaDestino)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.btnBuscarCuentaDestino)
        Me.GroupBox2.Controls.Add(Me.txtCuentaDestino)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 108)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(259, 68)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cuenta de destino"
        '
        'lblTitularCtaDestino
        '
        Me.lblTitularCtaDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitularCtaDestino.Location = New System.Drawing.Point(48, 46)
        Me.lblTitularCtaDestino.Name = "lblTitularCtaDestino"
        Me.lblTitularCtaDestino.Size = New System.Drawing.Size(205, 13)
        Me.lblTitularCtaDestino.TabIndex = 4
        Me.lblTitularCtaDestino.Text = "APELLIDO, NOMBRE"
        Me.lblTitularCtaDestino.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Titular:"
        '
        'btnBuscarCuentaDestino
        '
        Me.btnBuscarCuentaDestino.Location = New System.Drawing.Point(200, 18)
        Me.btnBuscarCuentaDestino.Name = "btnBuscarCuentaDestino"
        Me.btnBuscarCuentaDestino.Size = New System.Drawing.Size(53, 23)
        Me.btnBuscarCuentaDestino.TabIndex = 3
        Me.btnBuscarCuentaDestino.Text = "Buscar"
        Me.btnBuscarCuentaDestino.UseVisualStyleBackColor = True
        '
        'txtCuentaDestino
        '
        Me.txtCuentaDestino.Location = New System.Drawing.Point(6, 19)
        Me.txtCuentaDestino.Name = "txtCuentaDestino"
        Me.txtCuentaDestino.Size = New System.Drawing.Size(189, 20)
        Me.txtCuentaDestino.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtMontoCantidad)
        Me.GroupBox3.Controls.Add(Me.cboMontoMoneda)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 183)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(259, 65)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalles de la transferencia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Monto"
        '
        'cboMontoMoneda
        '
        Me.cboMontoMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMontoMoneda.FormattingEnabled = True
        Me.cboMontoMoneda.Items.AddRange(New Object() {"UYU", "USD"})
        Me.cboMontoMoneda.Location = New System.Drawing.Point(9, 36)
        Me.cboMontoMoneda.Name = "cboMontoMoneda"
        Me.cboMontoMoneda.Size = New System.Drawing.Size(58, 21)
        Me.cboMontoMoneda.TabIndex = 4
        '
        'txtMontoCantidad
        '
        Me.txtMontoCantidad.Location = New System.Drawing.Point(73, 36)
        Me.txtMontoCantidad.Name = "txtMontoCantidad"
        Me.txtMontoCantidad.Size = New System.Drawing.Size(180, 20)
        Me.txtMontoCantidad.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(270, 39)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "En caso de transferir en una moneda distinta a una de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "las cuentas, se realizará " & _
            "la conversión en base a la tasa" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "aplicable al día de la fecha." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnTransferir
        '
        Me.btnTransferir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransferir.Location = New System.Drawing.Point(179, 314)
        Me.btnTransferir.Name = "btnTransferir"
        Me.btnTransferir.Size = New System.Drawing.Size(96, 23)
        Me.btnTransferir.TabIndex = 6
        Me.btnTransferir.Text = "TRANSFERIR"
        Me.btnTransferir.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(98, 314)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmTransferenciaCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 349)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnTransferir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmTransferenciaCuentas"
        Me.Text = "Transferencia entre cuentas"
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

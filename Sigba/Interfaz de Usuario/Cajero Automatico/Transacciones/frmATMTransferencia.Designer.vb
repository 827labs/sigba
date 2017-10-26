<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmATMTransferencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmATMTransferencia))
        Me.lblCuentaOrigen = New System.Windows.Forms.Label
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnContinuar = New System.Windows.Forms.Button
        Me.txtMonto = New System.Windows.Forms.TextBox
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.lblBienvenido = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txtCuentaDestino = New System.Windows.Forms.TextBox
        Me.lblCuenta = New System.Windows.Forms.Label
        Me.cboCuentaDestinoTipo = New System.Windows.Forms.ComboBox
        Me.cboCuentaDestinoMoneda = New System.Windows.Forms.ComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCuentaOrigen
        '
        Me.lblCuentaOrigen.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.lblCuentaOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuentaOrigen.ForeColor = System.Drawing.Color.White
        Me.lblCuentaOrigen.Location = New System.Drawing.Point(419, 41)
        Me.lblCuentaOrigen.Name = "lblCuentaOrigen"
        Me.lblCuentaOrigen.Size = New System.Drawing.Size(370, 18)
        Me.lblCuentaOrigen.TabIndex = 29
        Me.lblCuentaOrigen.Text = "CA UYU 012-345678-9"
        Me.lblCuentaOrigen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(275, 433)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(240, 36)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnContinuar
        '
        Me.btnContinuar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinuar.Location = New System.Drawing.Point(275, 357)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(240, 53)
        Me.btnContinuar.TabIndex = 4
        Me.btnContinuar.Text = "CONTINUAR"
        Me.btnContinuar.UseVisualStyleBackColor = True
        '
        'txtMonto
        '
        Me.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMonto.Font = New System.Drawing.Font("Consolas", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.Location = New System.Drawing.Point(243, 274)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(303, 51)
        Me.txtMonto.TabIndex = 3
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.White
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(118, 232)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(552, 25)
        Me.lblTitulo.TabIndex = 25
        Me.lblTitulo.Text = "Ingrese el monto en la moneda de la cuenta a transferir"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBienvenido
        '
        Me.lblBienvenido.AutoSize = True
        Me.lblBienvenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.lblBienvenido.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenido.ForeColor = System.Drawing.Color.White
        Me.lblBienvenido.Location = New System.Drawing.Point(413, 8)
        Me.lblBienvenido.Name = "lblBienvenido"
        Me.lblBienvenido.Size = New System.Drawing.Size(380, 31)
        Me.lblBienvenido.TabIndex = 24
        Me.lblBienvenido.Text = "Transferencia entre cuentas"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 600)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'txtCuentaDestino
        '
        Me.txtCuentaDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaDestino.Font = New System.Drawing.Font("Consolas", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaDestino.Location = New System.Drawing.Point(351, 149)
        Me.txtCuentaDestino.Name = "txtCuentaDestino"
        Me.txtCuentaDestino.Size = New System.Drawing.Size(303, 51)
        Me.txtCuentaDestino.TabIndex = 2
        Me.txtCuentaDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCuenta
        '
        Me.lblCuenta.BackColor = System.Drawing.Color.White
        Me.lblCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuenta.Location = New System.Drawing.Point(173, 110)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(452, 25)
        Me.lblCuenta.TabIndex = 30
        Me.lblCuenta.Text = "Ingrese la cuenta de destino"
        Me.lblCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboCuentaDestinoTipo
        '
        Me.cboCuentaDestinoTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCuentaDestinoTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuentaDestinoTipo.FormattingEnabled = True
        Me.cboCuentaDestinoTipo.Items.AddRange(New Object() {"CA", "CC"})
        Me.cboCuentaDestinoTipo.Location = New System.Drawing.Point(132, 149)
        Me.cboCuentaDestinoTipo.Name = "cboCuentaDestinoTipo"
        Me.cboCuentaDestinoTipo.Size = New System.Drawing.Size(91, 50)
        Me.cboCuentaDestinoTipo.TabIndex = 0
        '
        'cboCuentaDestinoMoneda
        '
        Me.cboCuentaDestinoMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCuentaDestinoMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuentaDestinoMoneda.FormattingEnabled = True
        Me.cboCuentaDestinoMoneda.Items.AddRange(New Object() {"UYU", "USD"})
        Me.cboCuentaDestinoMoneda.Location = New System.Drawing.Point(229, 149)
        Me.cboCuentaDestinoMoneda.Name = "cboCuentaDestinoMoneda"
        Me.cboCuentaDestinoMoneda.Size = New System.Drawing.Size(116, 50)
        Me.cboCuentaDestinoMoneda.TabIndex = 1
        '
        'frmATMTransferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 601)
        Me.Controls.Add(Me.cboCuentaDestinoMoneda)
        Me.Controls.Add(Me.cboCuentaDestinoTipo)
        Me.Controls.Add(Me.txtCuentaDestino)
        Me.Controls.Add(Me.lblCuenta)
        Me.Controls.Add(Me.lblCuentaOrigen)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnContinuar)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblBienvenido)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmATMTransferencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cajero Automatico"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCuentaOrigen As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnContinuar As System.Windows.Forms.Button
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblBienvenido As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtCuentaDestino As System.Windows.Forms.TextBox
    Friend WithEvents lblCuenta As System.Windows.Forms.Label
    Friend WithEvents cboCuentaDestinoTipo As System.Windows.Forms.ComboBox
    Friend WithEvents cboCuentaDestinoMoneda As System.Windows.Forms.ComboBox
End Class

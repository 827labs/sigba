<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCobrarCheque
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboTipoCheque = New System.Windows.Forms.ComboBox
        Me.cboTipoCobro = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cboPaisDoc = New System.Windows.Forms.ComboBox
        Me.txtNroDoc = New System.Windows.Forms.TextBox
        Me.cboTipoDoc = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtFechaEmision = New System.Windows.Forms.MaskedTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtFechaCobro = New System.Windows.Forms.MaskedTextBox
        Me.txtNumLibreta = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboMontoMoneda = New System.Windows.Forms.ComboBox
        Me.txtMontoCantidad = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtNumSerie = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtNumCheque = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.rboEmitidoEste = New System.Windows.Forms.RadioButton
        Me.rboEmitidoOtro = New System.Windows.Forms.RadioButton
        Me.Label12 = New System.Windows.Forms.Label
        Me.btnProcesar = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de cheque"
        '
        'cboTipoCheque
        '
        Me.cboTipoCheque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoCheque.FormattingEnabled = True
        Me.cboTipoCheque.Items.AddRange(New Object() {"Común", "Diferido", "Cruzado"})
        Me.cboTipoCheque.Location = New System.Drawing.Point(16, 69)
        Me.cboTipoCheque.Name = "cboTipoCheque"
        Me.cboTipoCheque.Size = New System.Drawing.Size(121, 21)
        Me.cboTipoCheque.TabIndex = 1
        '
        'cboTipoCobro
        '
        Me.cboTipoCobro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoCobro.FormattingEnabled = True
        Me.cboTipoCobro.Items.AddRange(New Object() {"Cobro en efectivo", "Depósito en cuenta"})
        Me.cboTipoCobro.Location = New System.Drawing.Point(143, 69)
        Me.cboTipoCobro.Name = "cboTipoCobro"
        Me.cboTipoCobro.Size = New System.Drawing.Size(121, 21)
        Me.cboTipoCobro.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(140, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipo de cobro"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboPaisDoc)
        Me.GroupBox2.Controls.Add(Me.txtNroDoc)
        Me.GroupBox2.Controls.Add(Me.cboTipoDoc)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(270, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 79)
        Me.GroupBox2.TabIndex = 85
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Documento cliente"
        '
        'cboPaisDoc
        '
        Me.cboPaisDoc.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboPaisDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPaisDoc.FormattingEnabled = True
        Me.cboPaisDoc.Location = New System.Drawing.Point(9, 33)
        Me.cboPaisDoc.Name = "cboPaisDoc"
        Me.cboPaisDoc.Size = New System.Drawing.Size(129, 21)
        Me.cboPaisDoc.TabIndex = 5
        '
        'txtNroDoc
        '
        Me.txtNroDoc.Location = New System.Drawing.Point(221, 34)
        Me.txtNroDoc.Name = "txtNroDoc"
        Me.txtNroDoc.Size = New System.Drawing.Size(129, 20)
        Me.txtNroDoc.TabIndex = 7
        '
        'cboTipoDoc
        '
        Me.cboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDoc.FormattingEnabled = True
        Me.cboTipoDoc.Items.AddRange(New Object() {"CI", "Pasaporte", "Otros"})
        Me.cboTipoDoc.Location = New System.Drawing.Point(144, 33)
        Me.cboTipoDoc.Name = "cboTipoDoc"
        Me.cboTipoDoc.Size = New System.Drawing.Size(71, 21)
        Me.cboTipoDoc.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "País"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(141, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Tipo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(218, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Número"
        '
        'txtFechaEmision
        '
        Me.txtFechaEmision.Location = New System.Drawing.Point(16, 111)
        Me.txtFechaEmision.Mask = "99/99/9999"
        Me.txtFechaEmision.Name = "txtFechaEmision"
        Me.txtFechaEmision.Size = New System.Drawing.Size(121, 20)
        Me.txtFechaEmision.TabIndex = 86
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Fecha de emisión"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(140, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Cobrar a partir de:"
        '
        'txtFechaCobro
        '
        Me.txtFechaCobro.Enabled = False
        Me.txtFechaCobro.Location = New System.Drawing.Point(143, 111)
        Me.txtFechaCobro.Mask = "99/99/9999"
        Me.txtFechaCobro.Name = "txtFechaCobro"
        Me.txtFechaCobro.Size = New System.Drawing.Size(121, 20)
        Me.txtFechaCobro.TabIndex = 88
        '
        'txtNumLibreta
        '
        Me.txtNumLibreta.Location = New System.Drawing.Point(273, 156)
        Me.txtNumLibreta.Name = "txtNumLibreta"
        Me.txtNumLibreta.Size = New System.Drawing.Size(110, 20)
        Me.txtNumLibreta.TabIndex = 90
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(270, 140)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "Nº Libreta"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboMontoMoneda)
        Me.GroupBox1.Controls.Add(Me.txtMontoCantidad)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 137)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 47)
        Me.GroupBox1.TabIndex = 92
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Monto"
        '
        'cboMontoMoneda
        '
        Me.cboMontoMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMontoMoneda.FormattingEnabled = True
        Me.cboMontoMoneda.Items.AddRange(New Object() {"UYU - Pesos Uruguayos", "USD - Dólares Americanos"})
        Me.cboMontoMoneda.Location = New System.Drawing.Point(7, 18)
        Me.cboMontoMoneda.Name = "cboMontoMoneda"
        Me.cboMontoMoneda.Size = New System.Drawing.Size(129, 21)
        Me.cboMontoMoneda.TabIndex = 94
        '
        'txtMontoCantidad
        '
        Me.txtMontoCantidad.Location = New System.Drawing.Point(142, 19)
        Me.txtMontoCantidad.Name = "txtMontoCantidad"
        Me.txtMontoCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtMontoCantidad.TabIndex = 93
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(386, 140)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 94
        Me.Label9.Text = "Serie"
        '
        'txtNumSerie
        '
        Me.txtNumSerie.Location = New System.Drawing.Point(389, 156)
        Me.txtNumSerie.Name = "txtNumSerie"
        Me.txtNumSerie.Size = New System.Drawing.Size(74, 20)
        Me.txtNumSerie.TabIndex = 93
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(466, 139)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 13)
        Me.Label10.TabIndex = 96
        Me.Label10.Text = "Número de cheque"
        '
        'txtNumCheque
        '
        Me.txtNumCheque.Location = New System.Drawing.Point(469, 155)
        Me.txtNumCheque.Name = "txtNumCheque"
        Me.txtNumCheque.Size = New System.Drawing.Size(161, 20)
        Me.txtNumCheque.TabIndex = 95
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(204, 25)
        Me.Label11.TabIndex = 97
        Me.Label11.Text = "Cobro de cheques"
        '
        'rboEmitidoEste
        '
        Me.rboEmitidoEste.AutoSize = True
        Me.rboEmitidoEste.Checked = True
        Me.rboEmitidoEste.Location = New System.Drawing.Point(469, 19)
        Me.rboEmitidoEste.Name = "rboEmitidoEste"
        Me.rboEmitidoEste.Size = New System.Drawing.Size(79, 17)
        Me.rboEmitidoEste.TabIndex = 98
        Me.rboEmitidoEste.TabStop = True
        Me.rboEmitidoEste.Text = "Este banco"
        Me.rboEmitidoEste.UseVisualStyleBackColor = True
        '
        'rboEmitidoOtro
        '
        Me.rboEmitidoOtro.AutoSize = True
        Me.rboEmitidoOtro.Location = New System.Drawing.Point(554, 19)
        Me.rboEmitidoOtro.Name = "rboEmitidoOtro"
        Me.rboEmitidoOtro.Size = New System.Drawing.Size(78, 17)
        Me.rboEmitidoOtro.TabIndex = 99
        Me.rboEmitidoOtro.TabStop = True
        Me.rboEmitidoOtro.Text = "Otro banco"
        Me.rboEmitidoOtro.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(401, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 100
        Me.Label12.Text = "Emitido por:"
        '
        'btnProcesar
        '
        Me.btnProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcesar.Location = New System.Drawing.Point(516, 182)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(113, 24)
        Me.btnProcesar.TabIndex = 101
        Me.btnProcesar.Text = "Procesar cobro"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(435, 182)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 102
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmCobrarCheque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 213)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.rboEmitidoOtro)
        Me.Controls.Add(Me.rboEmitidoEste)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtNumCheque)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNumSerie)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtNumLibreta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFechaCobro)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFechaEmision)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cboTipoCobro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboTipoCheque)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCobrarCheque"
        Me.Text = "Cobrar cheque"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboTipoCheque As System.Windows.Forms.ComboBox
    Friend WithEvents cboTipoCobro As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboPaisDoc As System.Windows.Forms.ComboBox
    Friend WithEvents txtNroDoc As System.Windows.Forms.TextBox
    Friend WithEvents cboTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtFechaEmision As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFechaCobro As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtNumLibreta As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboMontoMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents txtMontoCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNumSerie As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNumCheque As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents rboEmitidoEste As System.Windows.Forms.RadioButton
    Friend WithEvents rboEmitidoOtro As System.Windows.Forms.RadioButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmitirLibreta
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cboNumCuenta = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.grpDocumento = New System.Windows.Forms.GroupBox
        Me.cboPaisDocCliente = New System.Windows.Forms.ComboBox
        Me.txtNroDocCliente = New System.Windows.Forms.TextBox
        Me.cboTipoDocCliente = New System.Windows.Forms.ComboBox
        Me.lblPaisDoc = New System.Windows.Forms.Label
        Me.lblTipoDoc = New System.Windows.Forms.Label
        Me.lblNroDocumento = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtCantCheques = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNroLibreta = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpDocumento.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.grpDocumento)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 153)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del librador"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboNumCuenta)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 92)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 53)
        Me.GroupBox2.TabIndex = 87
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cuenta"
        '
        'cboNumCuenta
        '
        Me.cboNumCuenta.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboNumCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNumCuenta.FormattingEnabled = True
        Me.cboNumCuenta.Location = New System.Drawing.Point(9, 20)
        Me.cboNumCuenta.Name = "cboNumCuenta"
        Me.cboNumCuenta.Size = New System.Drawing.Size(341, 21)
        Me.cboNumCuenta.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 26
        '
        'grpDocumento
        '
        Me.grpDocumento.Controls.Add(Me.cboPaisDocCliente)
        Me.grpDocumento.Controls.Add(Me.txtNroDocCliente)
        Me.grpDocumento.Controls.Add(Me.cboTipoDocCliente)
        Me.grpDocumento.Controls.Add(Me.lblPaisDoc)
        Me.grpDocumento.Controls.Add(Me.lblTipoDoc)
        Me.grpDocumento.Controls.Add(Me.lblNroDocumento)
        Me.grpDocumento.Location = New System.Drawing.Point(6, 19)
        Me.grpDocumento.Name = "grpDocumento"
        Me.grpDocumento.Size = New System.Drawing.Size(360, 67)
        Me.grpDocumento.TabIndex = 86
        Me.grpDocumento.TabStop = False
        Me.grpDocumento.Text = "Documento"
        '
        'cboPaisDocCliente
        '
        Me.cboPaisDocCliente.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboPaisDocCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPaisDocCliente.FormattingEnabled = True
        Me.cboPaisDocCliente.Location = New System.Drawing.Point(9, 33)
        Me.cboPaisDocCliente.Name = "cboPaisDocCliente"
        Me.cboPaisDocCliente.Size = New System.Drawing.Size(129, 21)
        Me.cboPaisDocCliente.TabIndex = 1
        '
        'txtNroDocCliente
        '
        Me.txtNroDocCliente.Location = New System.Drawing.Point(221, 34)
        Me.txtNroDocCliente.Name = "txtNroDocCliente"
        Me.txtNroDocCliente.Size = New System.Drawing.Size(129, 20)
        Me.txtNroDocCliente.TabIndex = 3
        '
        'cboTipoDocCliente
        '
        Me.cboTipoDocCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDocCliente.FormattingEnabled = True
        Me.cboTipoDocCliente.Items.AddRange(New Object() {"CI", "Pasaporte", "Otros"})
        Me.cboTipoDocCliente.Location = New System.Drawing.Point(144, 33)
        Me.cboTipoDocCliente.Name = "cboTipoDocCliente"
        Me.cboTipoDocCliente.Size = New System.Drawing.Size(71, 21)
        Me.cboTipoDocCliente.TabIndex = 2
        '
        'lblPaisDoc
        '
        Me.lblPaisDoc.AutoSize = True
        Me.lblPaisDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaisDoc.Location = New System.Drawing.Point(6, 19)
        Me.lblPaisDoc.Name = "lblPaisDoc"
        Me.lblPaisDoc.Size = New System.Drawing.Size(29, 13)
        Me.lblPaisDoc.TabIndex = 22
        Me.lblPaisDoc.Text = "País"
        '
        'lblTipoDoc
        '
        Me.lblTipoDoc.AutoSize = True
        Me.lblTipoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblTipoDoc.Location = New System.Drawing.Point(141, 19)
        Me.lblTipoDoc.Name = "lblTipoDoc"
        Me.lblTipoDoc.Size = New System.Drawing.Size(28, 13)
        Me.lblTipoDoc.TabIndex = 23
        Me.lblTipoDoc.Text = "Tipo"
        '
        'lblNroDocumento
        '
        Me.lblNroDocumento.AutoSize = True
        Me.lblNroDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblNroDocumento.Location = New System.Drawing.Point(218, 19)
        Me.lblNroDocumento.Name = "lblNroDocumento"
        Me.lblNroDocumento.Size = New System.Drawing.Size(44, 13)
        Me.lblNroDocumento.TabIndex = 24
        Me.lblNroDocumento.Text = "Número"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtCantCheques)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtNroLibreta)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 172)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(372, 65)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de la libreta"
        '
        'txtCantCheques
        '
        Me.txtCantCheques.Location = New System.Drawing.Point(227, 35)
        Me.txtCantCheques.Name = "txtCantCheques"
        Me.txtCantCheques.Size = New System.Drawing.Size(129, 20)
        Me.txtCantCheques.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(225, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Cant. de cheques"
        '
        'txtNroLibreta
        '
        Me.txtNroLibreta.Cursor = System.Windows.Forms.Cursors.No
        Me.txtNroLibreta.Enabled = False
        Me.txtNroLibreta.Location = New System.Drawing.Point(9, 35)
        Me.txtNroLibreta.Name = "txtNroLibreta"
        Me.txtNroLibreta.Size = New System.Drawing.Size(212, 20)
        Me.txtNroLibreta.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(6, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Número"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(309, 244)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Emitir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(228, 244)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmEmitirLibreta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 278)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmEmitirLibreta"
        Me.Text = "Emitir Libreta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpDocumento.ResumeLayout(False)
        Me.grpDocumento.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grpDocumento As System.Windows.Forms.GroupBox
    Friend WithEvents cboPaisDocCliente As System.Windows.Forms.ComboBox
    Friend WithEvents txtNroDocCliente As System.Windows.Forms.TextBox
    Friend WithEvents cboTipoDocCliente As System.Windows.Forms.ComboBox
    Friend WithEvents lblPaisDoc As System.Windows.Forms.Label
    Friend WithEvents lblTipoDoc As System.Windows.Forms.Label
    Friend WithEvents lblNroDocumento As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboNumCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNroLibreta As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCantCheques As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class

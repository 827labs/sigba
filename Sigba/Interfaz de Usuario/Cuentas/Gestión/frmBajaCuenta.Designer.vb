<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBajaCuenta
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
        Me.lblCuenta = New System.Windows.Forms.Label
        Me.lblTitular = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboRazonPredefinida = New System.Windows.Forms.ComboBox
        Me.txtRazon = New System.Windows.Forms.TextBox
        Me.btnConfirmar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cuenta"
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuenta.Location = New System.Drawing.Point(10, 28)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(150, 20)
        Me.lblCuenta.TabIndex = 1
        Me.lblCuenta.Text = "CA 012-345678-9"
        '
        'lblTitular
        '
        Me.lblTitular.AutoSize = True
        Me.lblTitular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitular.Location = New System.Drawing.Point(166, 28)
        Me.lblTitular.Name = "lblTitular"
        Me.lblTitular.Size = New System.Drawing.Size(145, 20)
        Me.lblTitular.TabIndex = 3
        Me.lblTitular.Text = "Apellido, Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(169, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Titular de la cuenta"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboRazonPredefinida)
        Me.GroupBox1.Controls.Add(Me.txtRazon)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(411, 129)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Razón de la baja"
        '
        'cboRazonPredefinida
        '
        Me.cboRazonPredefinida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRazonPredefinida.FormattingEnabled = True
        Me.cboRazonPredefinida.Items.AddRange(New Object() {"001 - Razón 1", "002 - Razón 2", "003 - Razón 3", "Otra... (Especificar)"})
        Me.cboRazonPredefinida.Location = New System.Drawing.Point(7, 20)
        Me.cboRazonPredefinida.Name = "cboRazonPredefinida"
        Me.cboRazonPredefinida.Size = New System.Drawing.Size(398, 21)
        Me.cboRazonPredefinida.TabIndex = 0
        '
        'txtRazon
        '
        Me.txtRazon.Enabled = False
        Me.txtRazon.Location = New System.Drawing.Point(7, 47)
        Me.txtRazon.Multiline = True
        Me.txtRazon.Name = "txtRazon"
        Me.txtRazon.Size = New System.Drawing.Size(398, 74)
        Me.txtRazon.TabIndex = 1
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.Location = New System.Drawing.Point(257, 197)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(170, 23)
        Me.btnConfirmar.TabIndex = 2
        Me.btnConfirmar.Text = "Confirmar baja de cuenta"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnCancelar.Location = New System.Drawing.Point(176, 197)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmBajaCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 236)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTitular)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblCuenta)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBajaCuenta"
        Me.Text = "Baja de cuenta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCuenta As System.Windows.Forms.Label
    Friend WithEvents lblTitular As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboRazonPredefinida As System.Windows.Forms.ComboBox
    Friend WithEvents txtRazon As System.Windows.Forms.TextBox
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmATMSelectorOperacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmATMSelectorOperacion))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnRetiro = New System.Windows.Forms.Button
        Me.btnDeposito = New System.Windows.Forms.Button
        Me.btnConsulta = New System.Windows.Forms.Button
        Me.btnTransferencia = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 600)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.Label1.Location = New System.Drawing.Point(269, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Seleccione la operación"
        '
        'btnRetiro
        '
        Me.btnRetiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.btnRetiro.Location = New System.Drawing.Point(218, 168)
        Me.btnRetiro.Name = "btnRetiro"
        Me.btnRetiro.Size = New System.Drawing.Size(342, 51)
        Me.btnRetiro.TabIndex = 1
        Me.btnRetiro.Text = "Retiro"
        Me.btnRetiro.UseVisualStyleBackColor = True
        '
        'btnDeposito
        '
        Me.btnDeposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.btnDeposito.Location = New System.Drawing.Point(218, 230)
        Me.btnDeposito.Name = "btnDeposito"
        Me.btnDeposito.Size = New System.Drawing.Size(342, 51)
        Me.btnDeposito.TabIndex = 2
        Me.btnDeposito.Text = "Depósito"
        Me.btnDeposito.UseVisualStyleBackColor = True
        '
        'btnConsulta
        '
        Me.btnConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.btnConsulta.Location = New System.Drawing.Point(218, 354)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(342, 51)
        Me.btnConsulta.TabIndex = 4
        Me.btnConsulta.Text = "Transacciones"
        Me.btnConsulta.UseVisualStyleBackColor = True
        '
        'btnTransferencia
        '
        Me.btnTransferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.btnTransferencia.Location = New System.Drawing.Point(218, 292)
        Me.btnTransferencia.Name = "btnTransferencia"
        Me.btnTransferencia.Size = New System.Drawing.Size(342, 51)
        Me.btnTransferencia.TabIndex = 3
        Me.btnTransferencia.Text = "Transferencia"
        Me.btnTransferencia.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.btnCancelar.Location = New System.Drawing.Point(218, 465)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(342, 36)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmATMSelectorOperacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 601)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnTransferencia)
        Me.Controls.Add(Me.btnConsulta)
        Me.Controls.Add(Me.btnDeposito)
        Me.Controls.Add(Me.btnRetiro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmATMSelectorOperacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cajero Automatico"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRetiro As System.Windows.Forms.Button
    Friend WithEvents btnDeposito As System.Windows.Forms.Button
    Friend WithEvents btnConsulta As System.Windows.Forms.Button
    Friend WithEvents btnTransferencia As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class

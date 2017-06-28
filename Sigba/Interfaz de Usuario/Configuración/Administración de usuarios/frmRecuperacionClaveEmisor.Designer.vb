<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecuperacionClaveEmisor
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
        Me.txtCedulaUsuario = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnGenerar = New System.Windows.Forms.Button
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.lblPreCodigo = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtCedulaUsuario
        '
        Me.txtCedulaUsuario.Location = New System.Drawing.Point(153, 12)
        Me.txtCedulaUsuario.Name = "txtCedulaUsuario"
        Me.txtCedulaUsuario.Size = New System.Drawing.Size(128, 20)
        Me.txtCedulaUsuario.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "C.I. de usuario a recuperar:"
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(205, 39)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerar.TabIndex = 2
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(76, 110)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(143, 37)
        Me.lblCodigo.TabIndex = 3
        Me.lblCodigo.Text = "###-###"
        Me.lblCodigo.Visible = False
        '
        'lblPreCodigo
        '
        Me.lblPreCodigo.AutoSize = True
        Me.lblPreCodigo.Location = New System.Drawing.Point(12, 74)
        Me.lblPreCodigo.Name = "lblPreCodigo"
        Me.lblPreCodigo.Size = New System.Drawing.Size(255, 13)
        Me.lblPreCodigo.TabIndex = 4
        Me.lblPreCodigo.Text = "El codigo de recuperación para Apellido, Nombre es:"
        Me.lblPreCodigo.Visible = False
        '
        'frmRecuperacionClaveEmisor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 183)
        Me.Controls.Add(Me.lblPreCodigo)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCedulaUsuario)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(313, 222)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(313, 222)
        Me.Name = "frmRecuperacionClaveEmisor"
        Me.ShowIcon = False
        Me.Text = "Recuperación de Clave"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCedulaUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblPreCodigo As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOlvidoClave
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOlvidoClave))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCodigoAcceso = New System.Windows.Forms.TextBox
        Me.txtNuevaClave = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnContinuar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Solicita un código de recuperación a tu supervisor directo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "e ingresalo en el sig" & _
            "uiente campo:"
        '
        'txtCodigoAcceso
        '
        Me.txtCodigoAcceso.Location = New System.Drawing.Point(17, 84)
        Me.txtCodigoAcceso.Name = "txtCodigoAcceso"
        Me.txtCodigoAcceso.Size = New System.Drawing.Size(275, 20)
        Me.txtCodigoAcceso.TabIndex = 1
        '
        'txtNuevaClave
        '
        Me.txtNuevaClave.Location = New System.Drawing.Point(17, 143)
        Me.txtNuevaClave.Name = "txtNuevaClave"
        Me.txtNuevaClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNuevaClave.Size = New System.Drawing.Size(275, 20)
        Me.txtNuevaClave.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(266, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ahora, escoge una nueva clave de acceso e ingresala" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "en el siguiente campo:"
        '
        'btnContinuar
        '
        Me.btnContinuar.Location = New System.Drawing.Point(146, 170)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(145, 23)
        Me.btnContinuar.TabIndex = 4
        Me.btnContinuar.Text = "Cambiar clave y continuar"
        Me.btnContinuar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(226, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Recuperación de clave"
        '
        'frmOlvidoClave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 203)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnContinuar)
        Me.Controls.Add(Me.txtNuevaClave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodigoAcceso)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOlvidoClave"
        Me.Text = "Recuperación de clave"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoAcceso As System.Windows.Forms.TextBox
    Friend WithEvents txtNuevaClave As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnContinuar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class

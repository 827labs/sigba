<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmATMSolicitarPin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmATMSolicitarPin))
        Me.txtPIN = New System.Windows.Forms.TextBox
        Me.lblSubtitulo = New System.Windows.Forms.Label
        Me.lblBienvenido = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnVolver = New System.Windows.Forms.Button
        Me.lblNuevoPinRecor = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPIN
        '
        Me.txtPIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPIN.Font = New System.Drawing.Font("Consolas", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPIN.Location = New System.Drawing.Point(240, 236)
        Me.txtPIN.Name = "txtPIN"
        Me.txtPIN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPIN.Size = New System.Drawing.Size(303, 51)
        Me.txtPIN.TabIndex = 7
        Me.txtPIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSubtitulo
        '
        Me.lblSubtitulo.BackColor = System.Drawing.Color.White
        Me.lblSubtitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitulo.Location = New System.Drawing.Point(119, 187)
        Me.lblSubtitulo.Name = "lblSubtitulo"
        Me.lblSubtitulo.Size = New System.Drawing.Size(545, 25)
        Me.lblSubtitulo.TabIndex = 6
        Me.lblSubtitulo.Text = "Ingrese su PIN"
        Me.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBienvenido
        '
        Me.lblBienvenido.AutoSize = True
        Me.lblBienvenido.BackColor = System.Drawing.Color.White
        Me.lblBienvenido.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenido.Location = New System.Drawing.Point(198, 139)
        Me.lblBienvenido.Name = "lblBienvenido"
        Me.lblBienvenido.Size = New System.Drawing.Size(386, 37)
        Me.lblBienvenido.TabIndex = 5
        Me.lblBienvenido.Text = "Bienvenido a SigbaBank"
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
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(12, 558)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(93, 31)
        Me.btnVolver.TabIndex = 8
        Me.btnVolver.Text = "< Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'lblNuevoPinRecor
        '
        Me.lblNuevoPinRecor.AutoSize = True
        Me.lblNuevoPinRecor.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblNuevoPinRecor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevoPinRecor.Location = New System.Drawing.Point(364, 566)
        Me.lblNuevoPinRecor.Name = "lblNuevoPinRecor"
        Me.lblNuevoPinRecor.Size = New System.Drawing.Size(362, 16)
        Me.lblNuevoPinRecor.TabIndex = 9
        Me.lblNuevoPinRecor.Text = "Si usted aún no tiene un PIN, ingrese 123456 para crear uno."
        '
        'frmATMSolicitarPin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 601)
        Me.Controls.Add(Me.lblNuevoPinRecor)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.txtPIN)
        Me.Controls.Add(Me.lblSubtitulo)
        Me.Controls.Add(Me.lblBienvenido)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmATMSolicitarPin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cajero Automatico"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPIN As System.Windows.Forms.TextBox
    Friend WithEvents lblSubtitulo As System.Windows.Forms.Label
    Friend WithEvents lblBienvenido As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents lblNuevoPinRecor As System.Windows.Forms.Label
End Class

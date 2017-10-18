<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.txtClave = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnContinuar = New System.Windows.Forms.Button
        Me.picSideImageLogin = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.lblVersion = New System.Windows.Forms.Label
        Me.btnCajero = New System.Windows.Forms.Button
        Me.cboIdioma = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.picSideImageLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtUsuario)
        Me.GroupBox1.Controls.Add(Me.txtClave)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(272, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 115)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso al sistema"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(9, 37)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(265, 20)
        Me.txtUsuario.TabIndex = 3
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(9, 82)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtClave.Size = New System.Drawing.Size(265, 20)
        Me.txtClave.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contraseña:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de usuario:"
        '
        'btnContinuar
        '
        Me.btnContinuar.Location = New System.Drawing.Point(468, 220)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(84, 30)
        Me.btnContinuar.TabIndex = 1
        Me.btnContinuar.Text = "Continuar"
        Me.btnContinuar.UseVisualStyleBackColor = True
        '
        'picSideImageLogin
        '
        Me.picSideImageLogin.Image = CType(resources.GetObject("picSideImageLogin.Image"), System.Drawing.Image)
        Me.picSideImageLogin.Location = New System.Drawing.Point(1, 1)
        Me.picSideImageLogin.Name = "picSideImageLogin"
        Me.picSideImageLogin.Size = New System.Drawing.Size(247, 373)
        Me.picSideImageLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSideImageLogin.TabIndex = 3
        Me.picSideImageLogin.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(286, 24)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(257, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(269, 351)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(231, 13)
        Me.lblVersion.TabIndex = 5
        Me.lblVersion.Text = "Sistema Informatico de Gestión Bancaria v1.0.0"
        '
        'btnCajero
        '
        Me.btnCajero.Location = New System.Drawing.Point(272, 325)
        Me.btnCajero.Name = "btnCajero"
        Me.btnCajero.Size = New System.Drawing.Size(145, 23)
        Me.btnCajero.TabIndex = 7
        Me.btnCajero.Text = "Modo Cajero Automático"
        Me.btnCajero.UseVisualStyleBackColor = True
        '
        'cboIdioma
        '
        Me.cboIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIdioma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboIdioma.FormattingEnabled = True
        Me.cboIdioma.Items.AddRange(New Object() {"Español", "English"})
        Me.cboIdioma.Location = New System.Drawing.Point(354, 224)
        Me.cboIdioma.Name = "cboIdioma"
        Me.cboIdioma.Size = New System.Drawing.Size(108, 21)
        Me.cboIdioma.TabIndex = 8
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 373)
        Me.Controls.Add(Me.cboIdioma)
        Me.Controls.Add(Me.btnCajero)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.picSideImageLogin)
        Me.Controls.Add(Me.btnContinuar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso a Sigba"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picSideImageLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnContinuar As System.Windows.Forms.Button
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents picSideImageLogin As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents btnCajero As System.Windows.Forms.Button
    Friend WithEvents cboIdioma As System.Windows.Forms.ComboBox

End Class

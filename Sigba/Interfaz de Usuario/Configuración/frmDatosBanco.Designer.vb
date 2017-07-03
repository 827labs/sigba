<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatosBanco
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatosBanco))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.picLogoBanco = New System.Windows.Forms.PictureBox
        Me.btnSeleccionarNuevoLogo = New System.Windows.Forms.Button
        Me.lblArchivoSeleccionadoLogo = New System.Windows.Forms.Label
        Me.grpDatosEmpresa = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.picLogoBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDatosEmpresa.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblArchivoSeleccionadoLogo)
        Me.GroupBox1.Controls.Add(Me.btnSeleccionarNuevoLogo)
        Me.GroupBox1.Controls.Add(Me.picLogoBanco)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 106)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Logotípo del banco"
        '
        'picLogoBanco
        '
        Me.picLogoBanco.Image = CType(resources.GetObject("picLogoBanco.Image"), System.Drawing.Image)
        Me.picLogoBanco.Location = New System.Drawing.Point(6, 19)
        Me.picLogoBanco.Name = "picLogoBanco"
        Me.picLogoBanco.Size = New System.Drawing.Size(185, 48)
        Me.picLogoBanco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogoBanco.TabIndex = 5
        Me.picLogoBanco.TabStop = False
        '
        'btnSeleccionarNuevoLogo
        '
        Me.btnSeleccionarNuevoLogo.Location = New System.Drawing.Point(6, 74)
        Me.btnSeleccionarNuevoLogo.Name = "btnSeleccionarNuevoLogo"
        Me.btnSeleccionarNuevoLogo.Size = New System.Drawing.Size(162, 23)
        Me.btnSeleccionarNuevoLogo.TabIndex = 6
        Me.btnSeleccionarNuevoLogo.Text = "Seleccionar nuevo archivo..."
        Me.btnSeleccionarNuevoLogo.UseVisualStyleBackColor = True
        '
        'lblArchivoSeleccionadoLogo
        '
        Me.lblArchivoSeleccionadoLogo.AutoSize = True
        Me.lblArchivoSeleccionadoLogo.Location = New System.Drawing.Point(172, 78)
        Me.lblArchivoSeleccionadoLogo.Name = "lblArchivoSeleccionadoLogo"
        Me.lblArchivoSeleccionadoLogo.Size = New System.Drawing.Size(148, 13)
        Me.lblArchivoSeleccionadoLogo.TabIndex = 7
        Me.lblArchivoSeleccionadoLogo.Text = "No hay archivo seleccionado."
        '
        'grpDatosEmpresa
        '
        Me.grpDatosEmpresa.Controls.Add(Me.Label2)
        Me.grpDatosEmpresa.Controls.Add(Me.TextBox2)
        Me.grpDatosEmpresa.Controls.Add(Me.Label1)
        Me.grpDatosEmpresa.Controls.Add(Me.TextBox1)
        Me.grpDatosEmpresa.Location = New System.Drawing.Point(12, 125)
        Me.grpDatosEmpresa.Name = "grpDatosEmpresa"
        Me.grpDatosEmpresa.Size = New System.Drawing.Size(360, 288)
        Me.grpDatosEmpresa.TabIndex = 1
        Me.grpDatosEmpresa.TabStop = False
        Me.grpDatosEmpresa.Text = "Datos de la empresa"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(9, 37)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(345, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre fantasia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(6, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Razón Social"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(9, 80)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(345, 20)
        Me.TextBox2.TabIndex = 2
        '
        'frmDatosBanco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 477)
        Me.Controls.Add(Me.grpDatosEmpresa)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDatosBanco"
        Me.Text = "frmDatosBanco"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picLogoBanco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDatosEmpresa.ResumeLayout(False)
        Me.grpDatosEmpresa.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents picLogoBanco As System.Windows.Forms.PictureBox
    Friend WithEvents lblArchivoSeleccionadoLogo As System.Windows.Forms.Label
    Friend WithEvents btnSeleccionarNuevoLogo As System.Windows.Forms.Button
    Friend WithEvents grpDatosEmpresa As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class

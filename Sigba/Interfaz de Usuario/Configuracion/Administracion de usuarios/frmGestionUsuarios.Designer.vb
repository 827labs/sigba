<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestionUsuarios))
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView
        Me.grpBuscarUsuarios = New System.Windows.Forms.GroupBox
        Me.btnLimpiarCedula = New System.Windows.Forms.Button
        Me.btnBuscarCedula = New System.Windows.Forms.Button
        Me.txtBuscaCedula = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnNuevoUsuario = New System.Windows.Forms.Button
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBuscarUsuarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.AllowUserToDeleteRows = False
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Location = New System.Drawing.Point(202, 12)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        Me.dgvUsuarios.Size = New System.Drawing.Size(719, 570)
        Me.dgvUsuarios.TabIndex = 0
        '
        'grpBuscarUsuarios
        '
        Me.grpBuscarUsuarios.Controls.Add(Me.btnLimpiarCedula)
        Me.grpBuscarUsuarios.Controls.Add(Me.btnBuscarCedula)
        Me.grpBuscarUsuarios.Controls.Add(Me.txtBuscaCedula)
        Me.grpBuscarUsuarios.Controls.Add(Me.Label2)
        Me.grpBuscarUsuarios.Location = New System.Drawing.Point(12, 12)
        Me.grpBuscarUsuarios.Name = "grpBuscarUsuarios"
        Me.grpBuscarUsuarios.Size = New System.Drawing.Size(184, 95)
        Me.grpBuscarUsuarios.TabIndex = 2
        Me.grpBuscarUsuarios.TabStop = False
        Me.grpBuscarUsuarios.Text = "Buscar usuarios"
        '
        'btnLimpiarCedula
        '
        Me.btnLimpiarCedula.Location = New System.Drawing.Point(41, 64)
        Me.btnLimpiarCedula.Name = "btnLimpiarCedula"
        Me.btnLimpiarCedula.Size = New System.Drawing.Size(55, 23)
        Me.btnLimpiarCedula.TabIndex = 9
        Me.btnLimpiarCedula.Text = "Limpiar"
        Me.btnLimpiarCedula.UseVisualStyleBackColor = True
        '
        'btnBuscarCedula
        '
        Me.btnBuscarCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCedula.Location = New System.Drawing.Point(102, 64)
        Me.btnBuscarCedula.Name = "btnBuscarCedula"
        Me.btnBuscarCedula.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarCedula.TabIndex = 2
        Me.btnBuscarCedula.Text = "Buscar"
        Me.btnBuscarCedula.UseVisualStyleBackColor = True
        '
        'txtBuscaCedula
        '
        Me.txtBuscaCedula.Location = New System.Drawing.Point(10, 37)
        Me.txtBuscaCedula.Name = "txtBuscaCedula"
        Me.txtBuscaCedula.Size = New System.Drawing.Size(167, 20)
        Me.txtBuscaCedula.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cédula de identidad"
        '
        'btnNuevoUsuario
        '
        Me.btnNuevoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoUsuario.Location = New System.Drawing.Point(12, 114)
        Me.btnNuevoUsuario.Name = "btnNuevoUsuario"
        Me.btnNuevoUsuario.Size = New System.Drawing.Size(184, 31)
        Me.btnNuevoUsuario.TabIndex = 3
        Me.btnNuevoUsuario.Text = "Nuevo Usuario"
        Me.btnNuevoUsuario.UseVisualStyleBackColor = True
        '
        'frmGestionUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 594)
        Me.Controls.Add(Me.btnNuevoUsuario)
        Me.Controls.Add(Me.grpBuscarUsuarios)
        Me.Controls.Add(Me.dgvUsuarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGestionUsuarios"
        Me.Text = "Gestión de usuarios"
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBuscarUsuarios.ResumeLayout(False)
        Me.grpBuscarUsuarios.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents grpBuscarUsuarios As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarCedula As System.Windows.Forms.Button
    Friend WithEvents txtBuscaCedula As System.Windows.Forms.TextBox
    Friend WithEvents btnLimpiarCedula As System.Windows.Forms.Button
    Friend WithEvents btnNuevoUsuario As System.Windows.Forms.Button
End Class

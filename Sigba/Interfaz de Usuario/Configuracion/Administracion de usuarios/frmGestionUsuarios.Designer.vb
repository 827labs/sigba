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
        Me.grpFiltro = New System.Windows.Forms.GroupBox
        Me.btnLimpiarFiltros = New System.Windows.Forms.Button
        Me.btnFiltrar = New System.Windows.Forms.Button
        Me.txtFiltroNombre = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtFiltroApellido = New System.Windows.Forms.TextBox
        Me.cboFiltroCargo = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.grpBuscarUsuarios = New System.Windows.Forms.GroupBox
        Me.btnLimpiarCedula = New System.Windows.Forms.Button
        Me.btnBuscarCedula = New System.Windows.Forms.Button
        Me.txtBuscaCedula = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnNuevoUsuario = New System.Windows.Forms.Button
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
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
        'grpFiltro
        '
        Me.grpFiltro.Controls.Add(Me.btnLimpiarFiltros)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.txtFiltroNombre)
        Me.grpFiltro.Controls.Add(Me.Label4)
        Me.grpFiltro.Controls.Add(Me.txtFiltroApellido)
        Me.grpFiltro.Controls.Add(Me.cboFiltroCargo)
        Me.grpFiltro.Controls.Add(Me.Label3)
        Me.grpFiltro.Controls.Add(Me.Label1)
        Me.grpFiltro.Location = New System.Drawing.Point(12, 12)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Size = New System.Drawing.Size(184, 193)
        Me.grpFiltro.TabIndex = 1
        Me.grpFiltro.TabStop = False
        Me.grpFiltro.Text = "Filtrar usuarios"
        '
        'btnLimpiarFiltros
        '
        Me.btnLimpiarFiltros.Location = New System.Drawing.Point(41, 160)
        Me.btnLimpiarFiltros.Name = "btnLimpiarFiltros"
        Me.btnLimpiarFiltros.Size = New System.Drawing.Size(56, 23)
        Me.btnLimpiarFiltros.TabIndex = 8
        Me.btnLimpiarFiltros.Text = "Limpiar"
        Me.btnLimpiarFiltros.UseVisualStyleBackColor = True
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltrar.Location = New System.Drawing.Point(103, 160)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(75, 23)
        Me.btnFiltrar.TabIndex = 7
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'txtFiltroNombre
        '
        Me.txtFiltroNombre.Location = New System.Drawing.Point(10, 125)
        Me.txtFiltroNombre.Name = "txtFiltroNombre"
        Me.txtFiltroNombre.Size = New System.Drawing.Size(168, 20)
        Me.txtFiltroNombre.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nombre"
        '
        'txtFiltroApellido
        '
        Me.txtFiltroApellido.Location = New System.Drawing.Point(10, 82)
        Me.txtFiltroApellido.Name = "txtFiltroApellido"
        Me.txtFiltroApellido.Size = New System.Drawing.Size(168, 20)
        Me.txtFiltroApellido.TabIndex = 4
        '
        'cboFiltroCargo
        '
        Me.cboFiltroCargo.FormattingEnabled = True
        Me.cboFiltroCargo.Items.AddRange(New Object() {"Administrador", "Gerente", "Ejecutivo ", "Auxiliares"})
        Me.cboFiltroCargo.Location = New System.Drawing.Point(10, 38)
        Me.cboFiltroCargo.Name = "cboFiltroCargo"
        Me.cboFiltroCargo.Size = New System.Drawing.Size(168, 21)
        Me.cboFiltroCargo.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Apellido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cargo"
        '
        'grpBuscarUsuarios
        '
        Me.grpBuscarUsuarios.Controls.Add(Me.btnLimpiarCedula)
        Me.grpBuscarUsuarios.Controls.Add(Me.btnBuscarCedula)
        Me.grpBuscarUsuarios.Controls.Add(Me.txtBuscaCedula)
        Me.grpBuscarUsuarios.Controls.Add(Me.Label2)
        Me.grpBuscarUsuarios.Location = New System.Drawing.Point(12, 211)
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
        Me.btnNuevoUsuario.Location = New System.Drawing.Point(12, 313)
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
        Me.Controls.Add(Me.grpFiltro)
        Me.Controls.Add(Me.dgvUsuarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGestionUsuarios"
        Me.Text = "Gestión de usuarios"
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        Me.grpBuscarUsuarios.ResumeLayout(False)
        Me.grpBuscarUsuarios.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents grpFiltro As System.Windows.Forms.GroupBox
    Friend WithEvents cboFiltroCargo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpBuscarUsuarios As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnLimpiarFiltros As System.Windows.Forms.Button
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents txtFiltroNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFiltroApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarCedula As System.Windows.Forms.Button
    Friend WithEvents txtBuscaCedula As System.Windows.Forms.TextBox
    Friend WithEvents btnLimpiarCedula As System.Windows.Forms.Button
    Friend WithEvents btnNuevoUsuario As System.Windows.Forms.Button
End Class

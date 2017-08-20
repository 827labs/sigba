<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEdicionCargo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEdicionCargo))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtIdCargo = New System.Windows.Forms.TextBox
        Me.txtNombreCargo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.dgvFuncionalidades = New System.Windows.Forms.DataGridView
        Me.hab = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.func = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFuncionalidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID del cargo:"
        '
        'txtIdCargo
        '
        Me.txtIdCargo.Enabled = False
        Me.txtIdCargo.Location = New System.Drawing.Point(106, 12)
        Me.txtIdCargo.Name = "txtIdCargo"
        Me.txtIdCargo.Size = New System.Drawing.Size(184, 20)
        Me.txtIdCargo.TabIndex = 1
        '
        'txtNombreCargo
        '
        Me.txtNombreCargo.Location = New System.Drawing.Point(106, 38)
        Me.txtNombreCargo.Name = "txtNombreCargo"
        Me.txtNombreCargo.Size = New System.Drawing.Size(184, 20)
        Me.txtNombreCargo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre del cargo:"
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.AllowUserToDeleteRows = False
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgvUsuarios.Location = New System.Drawing.Point(296, 12)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        Me.dgvUsuarios.Size = New System.Drawing.Size(414, 404)
        Me.dgvUsuarios.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.HeaderText = "Cédula"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Apellidos"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nombres"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Asignado"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(176, 69)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(114, 23)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "Guardar cambios"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(176, 98)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(114, 23)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "Eliminar Cargo"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'dgvFuncionalidades
        '
        Me.dgvFuncionalidades.AllowUserToAddRows = False
        Me.dgvFuncionalidades.AllowUserToDeleteRows = False
        Me.dgvFuncionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFuncionalidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.hab, Me.func})
        Me.dgvFuncionalidades.Location = New System.Drawing.Point(12, 136)
        Me.dgvFuncionalidades.Name = "dgvFuncionalidades"
        Me.dgvFuncionalidades.Size = New System.Drawing.Size(278, 280)
        Me.dgvFuncionalidades.TabIndex = 7
        '
        'hab
        '
        Me.hab.HeaderText = "Habilitado"
        Me.hab.Name = "hab"
        Me.hab.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.hab.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.hab.Width = 60
        '
        'func
        '
        Me.func.HeaderText = "Funcionalidad"
        Me.func.Name = "func"
        Me.func.Width = 180
        '
        'frmEdicionCargo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 428)
        Me.Controls.Add(Me.dgvFuncionalidades)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.dgvUsuarios)
        Me.Controls.Add(Me.txtNombreCargo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIdCargo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmEdicionCargo"
        Me.Text = "Editar cargo"
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFuncionalidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIdCargo As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreCargo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents dgvFuncionalidades As System.Windows.Forms.DataGridView
    Friend WithEvents hab As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents func As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
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
        Me.Cédula = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombres = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cargo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        Me.grpBuscarUsuarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cédula, Me.Apellidos, Me.Nombres, Me.Cargo, Me.Column1, Me.Column2})
        Me.DataGridView1.Location = New System.Drawing.Point(202, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(719, 570)
        Me.DataGridView1.TabIndex = 0
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
        'Cédula
        '
        Me.Cédula.HeaderText = "Cédula"
        Me.Cédula.Name = "Cédula"
        Me.Cédula.ReadOnly = True
        '
        'Apellidos
        '
        Me.Apellidos.HeaderText = "Apellidos"
        Me.Apellidos.Name = "Apellidos"
        Me.Apellidos.ReadOnly = True
        '
        'Nombres
        '
        Me.Nombres.HeaderText = "Nombres"
        Me.Nombres.Name = "Nombres"
        Me.Nombres.ReadOnly = True
        '
        'Cargo
        '
        Me.Cargo.HeaderText = "Cargo"
        Me.Cargo.Name = "Cargo"
        Me.Cargo.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Teléfono"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Correo electrónico"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'frmGestionUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 594)
        Me.Controls.Add(Me.grpBuscarUsuarios)
        Me.Controls.Add(Me.grpFiltro)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmGestionUsuarios"
        Me.Text = "Gestión de usuarios"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        Me.grpBuscarUsuarios.ResumeLayout(False)
        Me.grpBuscarUsuarios.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
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
    Friend WithEvents Cédula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellidos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

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
        Me.btnRefrescar = New System.Windows.Forms.Button
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBuscarUsuarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AccessibleDescription = Nothing
        Me.dgvUsuarios.AccessibleName = Nothing
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.AllowUserToDeleteRows = False
        resources.ApplyResources(Me.dgvUsuarios, "dgvUsuarios")
        Me.dgvUsuarios.BackgroundImage = Nothing
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Font = Nothing
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        '
        'grpBuscarUsuarios
        '
        Me.grpBuscarUsuarios.AccessibleDescription = Nothing
        Me.grpBuscarUsuarios.AccessibleName = Nothing
        resources.ApplyResources(Me.grpBuscarUsuarios, "grpBuscarUsuarios")
        Me.grpBuscarUsuarios.BackgroundImage = Nothing
        Me.grpBuscarUsuarios.Controls.Add(Me.btnLimpiarCedula)
        Me.grpBuscarUsuarios.Controls.Add(Me.btnBuscarCedula)
        Me.grpBuscarUsuarios.Controls.Add(Me.txtBuscaCedula)
        Me.grpBuscarUsuarios.Controls.Add(Me.Label2)
        Me.grpBuscarUsuarios.Font = Nothing
        Me.grpBuscarUsuarios.Name = "grpBuscarUsuarios"
        Me.grpBuscarUsuarios.TabStop = False
        '
        'btnLimpiarCedula
        '
        Me.btnLimpiarCedula.AccessibleDescription = Nothing
        Me.btnLimpiarCedula.AccessibleName = Nothing
        resources.ApplyResources(Me.btnLimpiarCedula, "btnLimpiarCedula")
        Me.btnLimpiarCedula.BackgroundImage = Nothing
        Me.btnLimpiarCedula.Font = Nothing
        Me.btnLimpiarCedula.Name = "btnLimpiarCedula"
        Me.btnLimpiarCedula.UseVisualStyleBackColor = True
        '
        'btnBuscarCedula
        '
        Me.btnBuscarCedula.AccessibleDescription = Nothing
        Me.btnBuscarCedula.AccessibleName = Nothing
        resources.ApplyResources(Me.btnBuscarCedula, "btnBuscarCedula")
        Me.btnBuscarCedula.BackgroundImage = Nothing
        Me.btnBuscarCedula.Name = "btnBuscarCedula"
        Me.btnBuscarCedula.UseVisualStyleBackColor = True
        '
        'txtBuscaCedula
        '
        Me.txtBuscaCedula.AccessibleDescription = Nothing
        Me.txtBuscaCedula.AccessibleName = Nothing
        resources.ApplyResources(Me.txtBuscaCedula, "txtBuscaCedula")
        Me.txtBuscaCedula.BackgroundImage = Nothing
        Me.txtBuscaCedula.Font = Nothing
        Me.txtBuscaCedula.Name = "txtBuscaCedula"
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = Nothing
        Me.Label2.AccessibleName = Nothing
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Font = Nothing
        Me.Label2.Name = "Label2"
        '
        'btnNuevoUsuario
        '
        Me.btnNuevoUsuario.AccessibleDescription = Nothing
        Me.btnNuevoUsuario.AccessibleName = Nothing
        resources.ApplyResources(Me.btnNuevoUsuario, "btnNuevoUsuario")
        Me.btnNuevoUsuario.BackgroundImage = Nothing
        Me.btnNuevoUsuario.Name = "btnNuevoUsuario"
        Me.btnNuevoUsuario.UseVisualStyleBackColor = True
        '
        'btnRefrescar
        '
        Me.btnRefrescar.AccessibleDescription = Nothing
        Me.btnRefrescar.AccessibleName = Nothing
        resources.ApplyResources(Me.btnRefrescar, "btnRefrescar")
        Me.btnRefrescar.BackgroundImage = Nothing
        Me.btnRefrescar.Font = Nothing
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.UseVisualStyleBackColor = True
        '
        'frmGestionUsuarios
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.btnRefrescar)
        Me.Controls.Add(Me.btnNuevoUsuario)
        Me.Controls.Add(Me.grpBuscarUsuarios)
        Me.Controls.Add(Me.dgvUsuarios)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGestionUsuarios"
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
    Friend WithEvents btnRefrescar As System.Windows.Forms.Button
End Class

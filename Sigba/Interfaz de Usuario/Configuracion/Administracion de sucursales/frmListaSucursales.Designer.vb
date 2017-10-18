<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaSucursales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaSucursales))
        Me.dgvSucursales = New System.Windows.Forms.DataGridView
        Me.btnNueva = New System.Windows.Forms.Button
        Me.btnRefrescar = New System.Windows.Forms.Button
        CType(Me.dgvSucursales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSucursales
        '
        Me.dgvSucursales.AccessibleDescription = Nothing
        Me.dgvSucursales.AccessibleName = Nothing
        Me.dgvSucursales.AllowUserToAddRows = False
        Me.dgvSucursales.AllowUserToDeleteRows = False
        resources.ApplyResources(Me.dgvSucursales, "dgvSucursales")
        Me.dgvSucursales.BackgroundImage = Nothing
        Me.dgvSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSucursales.Font = Nothing
        Me.dgvSucursales.Name = "dgvSucursales"
        Me.dgvSucursales.ReadOnly = True
        '
        'btnNueva
        '
        Me.btnNueva.AccessibleDescription = Nothing
        Me.btnNueva.AccessibleName = Nothing
        resources.ApplyResources(Me.btnNueva, "btnNueva")
        Me.btnNueva.BackgroundImage = Nothing
        Me.btnNueva.Font = Nothing
        Me.btnNueva.Name = "btnNueva"
        Me.btnNueva.UseVisualStyleBackColor = True
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
        'frmListaSucursales
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.btnRefrescar)
        Me.Controls.Add(Me.btnNueva)
        Me.Controls.Add(Me.dgvSucursales)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = Nothing
        Me.MaximizeBox = False
        Me.Name = "frmListaSucursales"
        Me.ShowIcon = False
        CType(Me.dgvSucursales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvSucursales As System.Windows.Forms.DataGridView
    Friend WithEvents btnNueva As System.Windows.Forms.Button
    Friend WithEvents btnRefrescar As System.Windows.Forms.Button
End Class

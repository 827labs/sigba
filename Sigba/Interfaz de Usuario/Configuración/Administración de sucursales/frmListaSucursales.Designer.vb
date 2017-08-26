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
        Me.dgvSucursales = New System.Windows.Forms.DataGridView
        Me.btnNueva = New System.Windows.Forms.Button
        Me.btnRefrescar = New System.Windows.Forms.Button
        CType(Me.dgvSucursales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSucursales
        '
        Me.dgvSucursales.AllowUserToAddRows = False
        Me.dgvSucursales.AllowUserToDeleteRows = False
        Me.dgvSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSucursales.Location = New System.Drawing.Point(12, 43)
        Me.dgvSucursales.Name = "dgvSucursales"
        Me.dgvSucursales.ReadOnly = True
        Me.dgvSucursales.Size = New System.Drawing.Size(505, 367)
        Me.dgvSucursales.TabIndex = 0
        '
        'btnNueva
        '
        Me.btnNueva.Location = New System.Drawing.Point(12, 12)
        Me.btnNueva.Name = "btnNueva"
        Me.btnNueva.Size = New System.Drawing.Size(75, 23)
        Me.btnNueva.TabIndex = 1
        Me.btnNueva.Text = "Nueva"
        Me.btnNueva.UseVisualStyleBackColor = True
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Location = New System.Drawing.Point(442, 12)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(75, 23)
        Me.btnRefrescar.TabIndex = 2
        Me.btnRefrescar.Text = "Refrescar"
        Me.btnRefrescar.UseVisualStyleBackColor = True
        '
        'frmListaSucursales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 422)
        Me.Controls.Add(Me.btnRefrescar)
        Me.Controls.Add(Me.btnNueva)
        Me.Controls.Add(Me.dgvSucursales)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmListaSucursales"
        Me.ShowIcon = False
        Me.Text = "Sucursales"
        CType(Me.dgvSucursales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvSucursales As System.Windows.Forms.DataGridView
    Friend WithEvents btnNueva As System.Windows.Forms.Button
    Friend WithEvents btnRefrescar As System.Windows.Forms.Button
End Class

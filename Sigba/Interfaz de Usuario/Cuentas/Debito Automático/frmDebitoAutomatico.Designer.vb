<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDebitoAutomatico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDebitoAutomatico))
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgvDebitos = New System.Windows.Forms.DataGridView
        Me.empresa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cuentaDeposito = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.monto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.estadoUlt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnNueva = New System.Windows.Forms.Button
        CType(Me.dgvDebitos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = Nothing
        Me.Label1.AccessibleName = Nothing
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'dgvDebitos
        '
        Me.dgvDebitos.AccessibleDescription = Nothing
        Me.dgvDebitos.AccessibleName = Nothing
        Me.dgvDebitos.AllowUserToAddRows = False
        Me.dgvDebitos.AllowUserToDeleteRows = False
        resources.ApplyResources(Me.dgvDebitos, "dgvDebitos")
        Me.dgvDebitos.BackgroundImage = Nothing
        Me.dgvDebitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDebitos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.empresa, Me.cuentaDeposito, Me.monto, Me.fecha, Me.estadoUlt})
        Me.dgvDebitos.Font = Nothing
        Me.dgvDebitos.Name = "dgvDebitos"
        Me.dgvDebitos.ReadOnly = True
        '
        'empresa
        '
        resources.ApplyResources(Me.empresa, "empresa")
        Me.empresa.Name = "empresa"
        Me.empresa.ReadOnly = True
        '
        'cuentaDeposito
        '
        resources.ApplyResources(Me.cuentaDeposito, "cuentaDeposito")
        Me.cuentaDeposito.Name = "cuentaDeposito"
        Me.cuentaDeposito.ReadOnly = True
        '
        'monto
        '
        resources.ApplyResources(Me.monto, "monto")
        Me.monto.Name = "monto"
        Me.monto.ReadOnly = True
        '
        'fecha
        '
        resources.ApplyResources(Me.fecha, "fecha")
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'estadoUlt
        '
        resources.ApplyResources(Me.estadoUlt, "estadoUlt")
        Me.estadoUlt.Name = "estadoUlt"
        Me.estadoUlt.ReadOnly = True
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
        'frmDebitoAutomatico
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.btnNueva)
        Me.Controls.Add(Me.dgvDebitos)
        Me.Controls.Add(Me.Label1)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmDebitoAutomatico"
        CType(Me.dgvDebitos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvDebitos As System.Windows.Forms.DataGridView
    Friend WithEvents btnNueva As System.Windows.Forms.Button
    Friend WithEvents empresa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuentaDeposito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estadoUlt As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

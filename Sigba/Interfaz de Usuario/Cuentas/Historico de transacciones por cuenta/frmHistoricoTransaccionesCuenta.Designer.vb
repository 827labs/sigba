<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistoricoTransaccionesCuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHistoricoTransaccionesCuenta))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNroCuenta = New System.Windows.Forms.Label
        Me.dgvTransacciones = New System.Windows.Forms.DataGridView
        CType(Me.dgvTransacciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = Nothing
        Me.Label1.AccessibleName = Nothing
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Font = Nothing
        Me.Label1.Name = "Label1"
        '
        'txtNroCuenta
        '
        Me.txtNroCuenta.AccessibleDescription = Nothing
        Me.txtNroCuenta.AccessibleName = Nothing
        resources.ApplyResources(Me.txtNroCuenta, "txtNroCuenta")
        Me.txtNroCuenta.Name = "txtNroCuenta"
        '
        'dgvTransacciones
        '
        Me.dgvTransacciones.AccessibleDescription = Nothing
        Me.dgvTransacciones.AccessibleName = Nothing
        Me.dgvTransacciones.AllowUserToAddRows = False
        Me.dgvTransacciones.AllowUserToDeleteRows = False
        resources.ApplyResources(Me.dgvTransacciones, "dgvTransacciones")
        Me.dgvTransacciones.BackgroundImage = Nothing
        Me.dgvTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransacciones.Font = Nothing
        Me.dgvTransacciones.Name = "dgvTransacciones"
        Me.dgvTransacciones.ReadOnly = True
        '
        'frmHistoricoTransaccionesCuenta
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.dgvTransacciones)
        Me.Controls.Add(Me.txtNroCuenta)
        Me.Controls.Add(Me.Label1)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmHistoricoTransaccionesCuenta"
        CType(Me.dgvTransacciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNroCuenta As System.Windows.Forms.Label
    Friend WithEvents dgvTransacciones As System.Windows.Forms.DataGridView
End Class

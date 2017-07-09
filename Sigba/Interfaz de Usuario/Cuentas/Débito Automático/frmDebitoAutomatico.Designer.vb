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
        Me.btnNueva = New System.Windows.Forms.Button
        Me.empresa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cuentaDeposito = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.monto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.estadoUlt = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvDebitos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(453, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Suscripciones de débito automático para la cuenta 012-345678-9"
        '
        'dgvDebitos
        '
        Me.dgvDebitos.AllowUserToAddRows = False
        Me.dgvDebitos.AllowUserToDeleteRows = False
        Me.dgvDebitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDebitos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.empresa, Me.cuentaDeposito, Me.monto, Me.fecha, Me.estadoUlt})
        Me.dgvDebitos.Location = New System.Drawing.Point(15, 44)
        Me.dgvDebitos.Name = "dgvDebitos"
        Me.dgvDebitos.ReadOnly = True
        Me.dgvDebitos.Size = New System.Drawing.Size(647, 304)
        Me.dgvDebitos.TabIndex = 1
        '
        'btnNueva
        '
        Me.btnNueva.Location = New System.Drawing.Point(587, 9)
        Me.btnNueva.Name = "btnNueva"
        Me.btnNueva.Size = New System.Drawing.Size(75, 23)
        Me.btnNueva.TabIndex = 2
        Me.btnNueva.Text = "Nueva"
        Me.btnNueva.UseVisualStyleBackColor = True
        '
        'empresa
        '
        Me.empresa.HeaderText = "Empresa"
        Me.empresa.Name = "empresa"
        Me.empresa.ReadOnly = True
        '
        'cuentaDeposito
        '
        Me.cuentaDeposito.HeaderText = "Cuenta a depositar"
        Me.cuentaDeposito.Name = "cuentaDeposito"
        Me.cuentaDeposito.ReadOnly = True
        '
        'monto
        '
        Me.monto.HeaderText = "Monto"
        Me.monto.Name = "monto"
        Me.monto.ReadOnly = True
        '
        'fecha
        '
        Me.fecha.HeaderText = "Prox. débito"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'estadoUlt
        '
        Me.estadoUlt.HeaderText = "Últ. transacción"
        Me.estadoUlt.Name = "estadoUlt"
        Me.estadoUlt.ReadOnly = True
        '
        'frmDebitoAutomatico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 360)
        Me.Controls.Add(Me.btnNueva)
        Me.Controls.Add(Me.dgvDebitos)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDebitoAutomatico"
        Me.Text = "Débito Automático"
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

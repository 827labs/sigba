<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleDebitoAutomatico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleDebitoAutomatico))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgvTransacciones = New System.Windows.Forms.DataGridView
        Me.asunto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.hora = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblDiaCobro = New System.Windows.Forms.Label
        Me.lblCtaDebito = New System.Windows.Forms.Label
        Me.lblEmpresa = New System.Windows.Forms.Label
        Me.lblMonto = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
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
        'Label2
        '
        Me.Label2.AccessibleDescription = Nothing
        Me.Label2.AccessibleName = Nothing
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Font = Nothing
        Me.Label2.Name = "Label2"
        '
        'Label4
        '
        Me.Label4.AccessibleDescription = Nothing
        Me.Label4.AccessibleName = Nothing
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Font = Nothing
        Me.Label4.Name = "Label4"
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleDescription = Nothing
        Me.GroupBox1.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.BackgroundImage = Nothing
        Me.GroupBox1.Controls.Add(Me.dgvTransacciones)
        Me.GroupBox1.Font = Nothing
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
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
        Me.dgvTransacciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.asunto, Me.fecha, Me.hora})
        Me.dgvTransacciones.Font = Nothing
        Me.dgvTransacciones.Name = "dgvTransacciones"
        Me.dgvTransacciones.ReadOnly = True
        '
        'asunto
        '
        resources.ApplyResources(Me.asunto, "asunto")
        Me.asunto.Name = "asunto"
        Me.asunto.ReadOnly = True
        '
        'fecha
        '
        resources.ApplyResources(Me.fecha, "fecha")
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'hora
        '
        resources.ApplyResources(Me.hora, "hora")
        Me.hora.Name = "hora"
        Me.hora.ReadOnly = True
        '
        'lblDiaCobro
        '
        Me.lblDiaCobro.AccessibleDescription = Nothing
        Me.lblDiaCobro.AccessibleName = Nothing
        resources.ApplyResources(Me.lblDiaCobro, "lblDiaCobro")
        Me.lblDiaCobro.Name = "lblDiaCobro"
        '
        'lblCtaDebito
        '
        Me.lblCtaDebito.AccessibleDescription = Nothing
        Me.lblCtaDebito.AccessibleName = Nothing
        resources.ApplyResources(Me.lblCtaDebito, "lblCtaDebito")
        Me.lblCtaDebito.Name = "lblCtaDebito"
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AccessibleDescription = Nothing
        Me.lblEmpresa.AccessibleName = Nothing
        resources.ApplyResources(Me.lblEmpresa, "lblEmpresa")
        Me.lblEmpresa.Name = "lblEmpresa"
        '
        'lblMonto
        '
        Me.lblMonto.AccessibleDescription = Nothing
        Me.lblMonto.AccessibleName = Nothing
        resources.ApplyResources(Me.lblMonto, "lblMonto")
        Me.lblMonto.Name = "lblMonto"
        '
        'Label10
        '
        Me.Label10.AccessibleDescription = Nothing
        Me.Label10.AccessibleName = Nothing
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Font = Nothing
        Me.Label10.Name = "Label10"
        '
        'btnEliminar
        '
        Me.btnEliminar.AccessibleDescription = Nothing
        Me.btnEliminar.AccessibleName = Nothing
        resources.ApplyResources(Me.btnEliminar, "btnEliminar")
        Me.btnEliminar.BackgroundImage = Nothing
        Me.btnEliminar.Font = Nothing
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'frmDetalleDebitoAutomatico
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblDiaCobro)
        Me.Controls.Add(Me.lblCtaDebito)
        Me.Controls.Add(Me.lblEmpresa)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmDetalleDebitoAutomatico"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvTransacciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDiaCobro As System.Windows.Forms.Label
    Friend WithEvents lblCtaDebito As System.Windows.Forms.Label
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dgvTransacciones As System.Windows.Forms.DataGridView
    Friend WithEvents asunto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
End Class

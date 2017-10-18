<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAuditoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAuditoria))
        Me.dgvAcciones = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtFechaHasta = New System.Windows.Forms.TextBox
        Me.txtFechaDesde = New System.Windows.Forms.TextBox
        Me.btnFiltrarFecha = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtCedula = New System.Windows.Forms.TextBox
        Me.btnFiltrarUsuario = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.dgvAcciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvAcciones
        '
        Me.dgvAcciones.AccessibleDescription = Nothing
        Me.dgvAcciones.AccessibleName = Nothing
        Me.dgvAcciones.AllowUserToAddRows = False
        Me.dgvAcciones.AllowUserToDeleteRows = False
        resources.ApplyResources(Me.dgvAcciones, "dgvAcciones")
        Me.dgvAcciones.BackgroundImage = Nothing
        Me.dgvAcciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAcciones.Font = Nothing
        Me.dgvAcciones.Name = "dgvAcciones"
        Me.dgvAcciones.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleDescription = Nothing
        Me.GroupBox1.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.BackgroundImage = Nothing
        Me.GroupBox1.Controls.Add(Me.txtFechaHasta)
        Me.GroupBox1.Controls.Add(Me.txtFechaDesde)
        Me.GroupBox1.Controls.Add(Me.btnFiltrarFecha)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = Nothing
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.AccessibleDescription = Nothing
        Me.txtFechaHasta.AccessibleName = Nothing
        resources.ApplyResources(Me.txtFechaHasta, "txtFechaHasta")
        Me.txtFechaHasta.BackgroundImage = Nothing
        Me.txtFechaHasta.Font = Nothing
        Me.txtFechaHasta.Name = "txtFechaHasta"
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.AccessibleDescription = Nothing
        Me.txtFechaDesde.AccessibleName = Nothing
        resources.ApplyResources(Me.txtFechaDesde, "txtFechaDesde")
        Me.txtFechaDesde.BackgroundImage = Nothing
        Me.txtFechaDesde.Font = Nothing
        Me.txtFechaDesde.Name = "txtFechaDesde"
        '
        'btnFiltrarFecha
        '
        Me.btnFiltrarFecha.AccessibleDescription = Nothing
        Me.btnFiltrarFecha.AccessibleName = Nothing
        resources.ApplyResources(Me.btnFiltrarFecha, "btnFiltrarFecha")
        Me.btnFiltrarFecha.BackgroundImage = Nothing
        Me.btnFiltrarFecha.Font = Nothing
        Me.btnFiltrarFecha.Name = "btnFiltrarFecha"
        Me.btnFiltrarFecha.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = Nothing
        Me.Label2.AccessibleName = Nothing
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Font = Nothing
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = Nothing
        Me.Label1.AccessibleName = Nothing
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Font = Nothing
        Me.Label1.Name = "Label1"
        '
        'GroupBox2
        '
        Me.GroupBox2.AccessibleDescription = Nothing
        Me.GroupBox2.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.BackgroundImage = Nothing
        Me.GroupBox2.Controls.Add(Me.txtCedula)
        Me.GroupBox2.Controls.Add(Me.btnFiltrarUsuario)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = Nothing
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'txtCedula
        '
        Me.txtCedula.AccessibleDescription = Nothing
        Me.txtCedula.AccessibleName = Nothing
        resources.ApplyResources(Me.txtCedula, "txtCedula")
        Me.txtCedula.BackgroundImage = Nothing
        Me.txtCedula.Font = Nothing
        Me.txtCedula.Name = "txtCedula"
        '
        'btnFiltrarUsuario
        '
        Me.btnFiltrarUsuario.AccessibleDescription = Nothing
        Me.btnFiltrarUsuario.AccessibleName = Nothing
        resources.ApplyResources(Me.btnFiltrarUsuario, "btnFiltrarUsuario")
        Me.btnFiltrarUsuario.BackgroundImage = Nothing
        Me.btnFiltrarUsuario.Font = Nothing
        Me.btnFiltrarUsuario.Name = "btnFiltrarUsuario"
        Me.btnFiltrarUsuario.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AccessibleDescription = Nothing
        Me.Label4.AccessibleName = Nothing
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Font = Nothing
        Me.Label4.Name = "Label4"
        '
        'frmAuditoria
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvAcciones)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAuditoria"
        CType(Me.dgvAcciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvAcciones As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFiltrarFecha As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFiltrarUsuario As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaHasta As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaDesde As System.Windows.Forms.TextBox
End Class

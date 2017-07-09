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
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblDiaCobro = New System.Windows.Forms.Label
        Me.lblCtaCredito = New System.Windows.Forms.Label
        Me.lblCtaDebito = New System.Windows.Forms.Label
        Me.lblEmpresa = New System.Windows.Forms.Label
        Me.lblMonto = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.dgvTransacciones = New System.Windows.Forms.DataGridView
        Me.asunto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.hora = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvTransacciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Empresa:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cuenta débito:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cuenta crédito:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Día de cobro:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvTransacciones)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 174)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Últimas transsaciónes"
        '
        'lblDiaCobro
        '
        Me.lblDiaCobro.AutoSize = True
        Me.lblDiaCobro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiaCobro.Location = New System.Drawing.Point(98, 64)
        Me.lblDiaCobro.Name = "lblDiaCobro"
        Me.lblDiaCobro.Size = New System.Drawing.Size(97, 13)
        Me.lblDiaCobro.TabIndex = 8
        Me.lblDiaCobro.Text = "20 de cada mes"
        '
        'lblCtaCredito
        '
        Me.lblCtaCredito.AutoSize = True
        Me.lblCtaCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCtaCredito.Location = New System.Drawing.Point(98, 47)
        Me.lblCtaCredito.Name = "lblCtaCredito"
        Me.lblCtaCredito.Size = New System.Drawing.Size(135, 13)
        Me.lblCtaCredito.TabIndex = 7
        Me.lblCtaCredito.Text = "CC UYU 045-011217-5"
        '
        'lblCtaDebito
        '
        Me.lblCtaDebito.AutoSize = True
        Me.lblCtaDebito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCtaDebito.Location = New System.Drawing.Point(98, 30)
        Me.lblCtaDebito.Name = "lblCtaDebito"
        Me.lblCtaDebito.Size = New System.Drawing.Size(135, 13)
        Me.lblCtaDebito.TabIndex = 6
        Me.lblCtaDebito.Text = "CA UYU 012-345678-9"
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresa.Location = New System.Drawing.Point(98, 13)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(92, 13)
        Me.lblEmpresa.TabIndex = 5
        Me.lblEmpresa.Text = "FUCEREP S.A."
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.Location = New System.Drawing.Point(98, 81)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(83, 13)
        Me.lblMonto.TabIndex = 10
        Me.lblMonto.Text = "UYU 1200,00"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(52, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Monto:"
        '
        'dgvTransacciones
        '
        Me.dgvTransacciones.AllowUserToAddRows = False
        Me.dgvTransacciones.AllowUserToDeleteRows = False
        Me.dgvTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransacciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.asunto, Me.fecha, Me.hora})
        Me.dgvTransacciones.Location = New System.Drawing.Point(7, 20)
        Me.dgvTransacciones.Name = "dgvTransacciones"
        Me.dgvTransacciones.ReadOnly = True
        Me.dgvTransacciones.Size = New System.Drawing.Size(349, 148)
        Me.dgvTransacciones.TabIndex = 0
        '
        'asunto
        '
        Me.asunto.HeaderText = "Asunto"
        Me.asunto.Name = "asunto"
        Me.asunto.ReadOnly = True
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'hora
        '
        Me.hora.HeaderText = "Estado"
        Me.hora.Name = "hora"
        Me.hora.ReadOnly = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(292, 13)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 47)
        Me.btnEliminar.TabIndex = 11
        Me.btnEliminar.Text = "Eliminar débito"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'frmDetalleDebitoAutomatico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 291)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblDiaCobro)
        Me.Controls.Add(Me.lblCtaCredito)
        Me.Controls.Add(Me.lblCtaDebito)
        Me.Controls.Add(Me.lblEmpresa)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDetalleDebitoAutomatico"
        Me.Text = "Detalle de débito automatico"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvTransacciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDiaCobro As System.Windows.Forms.Label
    Friend WithEvents lblCtaCredito As System.Windows.Forms.Label
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

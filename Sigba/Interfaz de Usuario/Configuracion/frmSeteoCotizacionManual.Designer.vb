<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeteoCotizacionManual
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtUSDCot = New System.Windows.Forms.TextBox
        Me.txtEURCot = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnContinuar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(327, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Necesitamos que ingrese la cotización del día de hoy a fin de poder" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "operar norma" & _
            "lmente en todos los servicios del banco."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dólares Americanos"
        '
        'txtUSDCot
        '
        Me.txtUSDCot.Location = New System.Drawing.Point(16, 68)
        Me.txtUSDCot.Name = "txtUSDCot"
        Me.txtUSDCot.Size = New System.Drawing.Size(154, 20)
        Me.txtUSDCot.TabIndex = 2
        '
        'txtEURCot
        '
        Me.txtEURCot.Location = New System.Drawing.Point(176, 68)
        Me.txtEURCot.Name = "txtEURCot"
        Me.txtEURCot.Size = New System.Drawing.Size(161, 20)
        Me.txtEURCot.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(173, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Euros"
        '
        'btnContinuar
        '
        Me.btnContinuar.Location = New System.Drawing.Point(131, 103)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(95, 23)
        Me.btnContinuar.TabIndex = 5
        Me.btnContinuar.Text = "Continuar"
        Me.btnContinuar.UseVisualStyleBackColor = True
        '
        'frmSeteoCotizacionManual
        '
        Me.AcceptButton = Me.btnContinuar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 138)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnContinuar)
        Me.Controls.Add(Me.txtEURCot)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUSDCot)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSeteoCotizacionManual"
        Me.ShowIcon = False
        Me.Text = "Asignación de cotización manual"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUSDCot As System.Windows.Forms.TextBox
    Friend WithEvents txtEURCot As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnContinuar As System.Windows.Forms.Button
End Class

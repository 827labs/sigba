<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeteoCotizacionATMManual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSeteoCotizacionATMManual))
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
        'txtUSDCot
        '
        Me.txtUSDCot.AccessibleDescription = Nothing
        Me.txtUSDCot.AccessibleName = Nothing
        resources.ApplyResources(Me.txtUSDCot, "txtUSDCot")
        Me.txtUSDCot.BackgroundImage = Nothing
        Me.txtUSDCot.Font = Nothing
        Me.txtUSDCot.Name = "txtUSDCot"
        '
        'txtEURCot
        '
        Me.txtEURCot.AccessibleDescription = Nothing
        Me.txtEURCot.AccessibleName = Nothing
        resources.ApplyResources(Me.txtEURCot, "txtEURCot")
        Me.txtEURCot.BackgroundImage = Nothing
        Me.txtEURCot.Font = Nothing
        Me.txtEURCot.Name = "txtEURCot"
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = Nothing
        Me.Label3.AccessibleName = Nothing
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Font = Nothing
        Me.Label3.Name = "Label3"
        '
        'btnContinuar
        '
        Me.btnContinuar.AccessibleDescription = Nothing
        Me.btnContinuar.AccessibleName = Nothing
        resources.ApplyResources(Me.btnContinuar, "btnContinuar")
        Me.btnContinuar.BackgroundImage = Nothing
        Me.btnContinuar.Font = Nothing
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.UseVisualStyleBackColor = True
        '
        'frmSeteoCotizacionManual
        '
        Me.AcceptButton = Me.btnContinuar
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.ControlBox = False
        Me.Controls.Add(Me.btnContinuar)
        Me.Controls.Add(Me.txtEURCot)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUSDCot)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = Nothing
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSeteoCotizacionManual"
        Me.ShowIcon = False
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

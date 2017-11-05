<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnularLibreta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnularLibreta))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtSerieLibreta = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNumLibreta = New System.Windows.Forms.TextBox
        Me.btnAnular = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleDescription = Nothing
        Me.GroupBox1.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.BackgroundImage = Nothing
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSerieLibreta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNumLibreta)
        Me.GroupBox1.Font = Nothing
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = Nothing
        Me.Label2.AccessibleName = Nothing
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Font = Nothing
        Me.Label2.Name = "Label2"
        '
        'txtSerieLibreta
        '
        Me.txtSerieLibreta.AccessibleDescription = Nothing
        Me.txtSerieLibreta.AccessibleName = Nothing
        resources.ApplyResources(Me.txtSerieLibreta, "txtSerieLibreta")
        Me.txtSerieLibreta.BackgroundImage = Nothing
        Me.txtSerieLibreta.Font = Nothing
        Me.txtSerieLibreta.Name = "txtSerieLibreta"
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = Nothing
        Me.Label1.AccessibleName = Nothing
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Font = Nothing
        Me.Label1.Name = "Label1"
        '
        'txtNumLibreta
        '
        Me.txtNumLibreta.AccessibleDescription = Nothing
        Me.txtNumLibreta.AccessibleName = Nothing
        resources.ApplyResources(Me.txtNumLibreta, "txtNumLibreta")
        Me.txtNumLibreta.BackgroundImage = Nothing
        Me.txtNumLibreta.Font = Nothing
        Me.txtNumLibreta.Name = "txtNumLibreta"
        '
        'btnAnular
        '
        Me.btnAnular.AccessibleDescription = Nothing
        Me.btnAnular.AccessibleName = Nothing
        resources.ApplyResources(Me.btnAnular, "btnAnular")
        Me.btnAnular.BackgroundImage = Nothing
        Me.btnAnular.Font = Nothing
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.UseVisualStyleBackColor = True
        '
        'frmAnularLibreta
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.btnAnular)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAnularLibreta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumLibreta As System.Windows.Forms.TextBox
    Friend WithEvents btnAnular As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSerieLibreta As System.Windows.Forms.TextBox
End Class

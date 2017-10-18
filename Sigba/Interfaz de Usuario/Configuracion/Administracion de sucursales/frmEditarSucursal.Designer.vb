<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarSucursal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditarSucursal))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNumero = New System.Windows.Forms.TextBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDirCalle = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDirNumero = New System.Windows.Forms.TextBox
        Me.txtHorario = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnAccion = New System.Windows.Forms.Button
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
        'txtNumero
        '
        Me.txtNumero.AccessibleDescription = Nothing
        Me.txtNumero.AccessibleName = Nothing
        resources.ApplyResources(Me.txtNumero, "txtNumero")
        Me.txtNumero.BackgroundImage = Nothing
        Me.txtNumero.Font = Nothing
        Me.txtNumero.Name = "txtNumero"
        '
        'txtNombre
        '
        Me.txtNombre.AccessibleDescription = Nothing
        Me.txtNombre.AccessibleName = Nothing
        resources.ApplyResources(Me.txtNombre, "txtNombre")
        Me.txtNombre.BackgroundImage = Nothing
        Me.txtNombre.Font = Nothing
        Me.txtNombre.Name = "txtNombre"
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = Nothing
        Me.Label2.AccessibleName = Nothing
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Font = Nothing
        Me.Label2.Name = "Label2"
        '
        'txtDirCalle
        '
        Me.txtDirCalle.AccessibleDescription = Nothing
        Me.txtDirCalle.AccessibleName = Nothing
        resources.ApplyResources(Me.txtDirCalle, "txtDirCalle")
        Me.txtDirCalle.BackgroundImage = Nothing
        Me.txtDirCalle.Font = Nothing
        Me.txtDirCalle.Name = "txtDirCalle"
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = Nothing
        Me.Label3.AccessibleName = Nothing
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Font = Nothing
        Me.Label3.Name = "Label3"
        '
        'txtDirNumero
        '
        Me.txtDirNumero.AccessibleDescription = Nothing
        Me.txtDirNumero.AccessibleName = Nothing
        resources.ApplyResources(Me.txtDirNumero, "txtDirNumero")
        Me.txtDirNumero.BackgroundImage = Nothing
        Me.txtDirNumero.Font = Nothing
        Me.txtDirNumero.Name = "txtDirNumero"
        '
        'txtHorario
        '
        Me.txtHorario.AccessibleDescription = Nothing
        Me.txtHorario.AccessibleName = Nothing
        resources.ApplyResources(Me.txtHorario, "txtHorario")
        Me.txtHorario.BackgroundImage = Nothing
        Me.txtHorario.Font = Nothing
        Me.txtHorario.Name = "txtHorario"
        '
        'Label4
        '
        Me.Label4.AccessibleDescription = Nothing
        Me.Label4.AccessibleName = Nothing
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Font = Nothing
        Me.Label4.Name = "Label4"
        '
        'btnAccion
        '
        Me.btnAccion.AccessibleDescription = Nothing
        Me.btnAccion.AccessibleName = Nothing
        resources.ApplyResources(Me.btnAccion, "btnAccion")
        Me.btnAccion.BackgroundImage = Nothing
        Me.btnAccion.Font = Nothing
        Me.btnAccion.Name = "btnAccion"
        Me.btnAccion.UseVisualStyleBackColor = True
        '
        'frmEditarSucursal
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.btnAccion)
        Me.Controls.Add(Me.txtHorario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDirNumero)
        Me.Controls.Add(Me.txtDirCalle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.Label1)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = Nothing
        Me.Name = "frmEditarSucursal"
        Me.ShowIcon = False
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDirCalle As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDirNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtHorario As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnAccion As System.Windows.Forms.Button
End Class

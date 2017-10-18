<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevoUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNuevoUsuario))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCorreo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCedula = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtApellidos = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNombres = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnIngresar = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleDescription = Nothing
        Me.GroupBox1.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.BackgroundImage = Nothing
        Me.GroupBox1.Controls.Add(Me.txtCorreo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCedula)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtApellidos)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNombres)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = Nothing
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'txtCorreo
        '
        Me.txtCorreo.AccessibleDescription = Nothing
        Me.txtCorreo.AccessibleName = Nothing
        resources.ApplyResources(Me.txtCorreo, "txtCorreo")
        Me.txtCorreo.BackgroundImage = Nothing
        Me.txtCorreo.Font = Nothing
        Me.txtCorreo.Name = "txtCorreo"
        '
        'Label4
        '
        Me.Label4.AccessibleDescription = Nothing
        Me.Label4.AccessibleName = Nothing
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Font = Nothing
        Me.Label4.Name = "Label4"
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
        'Label3
        '
        Me.Label3.AccessibleDescription = Nothing
        Me.Label3.AccessibleName = Nothing
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Font = Nothing
        Me.Label3.Name = "Label3"
        '
        'txtApellidos
        '
        Me.txtApellidos.AccessibleDescription = Nothing
        Me.txtApellidos.AccessibleName = Nothing
        resources.ApplyResources(Me.txtApellidos, "txtApellidos")
        Me.txtApellidos.BackgroundImage = Nothing
        Me.txtApellidos.Font = Nothing
        Me.txtApellidos.Name = "txtApellidos"
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = Nothing
        Me.Label2.AccessibleName = Nothing
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Font = Nothing
        Me.Label2.Name = "Label2"
        '
        'txtNombres
        '
        Me.txtNombres.AccessibleDescription = Nothing
        Me.txtNombres.AccessibleName = Nothing
        resources.ApplyResources(Me.txtNombres, "txtNombres")
        Me.txtNombres.BackgroundImage = Nothing
        Me.txtNombres.Font = Nothing
        Me.txtNombres.Name = "txtNombres"
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = Nothing
        Me.Label1.AccessibleName = Nothing
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Font = Nothing
        Me.Label1.Name = "Label1"
        '
        'btnIngresar
        '
        Me.btnIngresar.AccessibleDescription = Nothing
        Me.btnIngresar.AccessibleName = Nothing
        resources.ApplyResources(Me.btnIngresar, "btnIngresar")
        Me.btnIngresar.BackgroundImage = Nothing
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.AccessibleDescription = Nothing
        Me.btnLimpiar.AccessibleName = Nothing
        resources.ApplyResources(Me.btnLimpiar, "btnLimpiar")
        Me.btnLimpiar.BackgroundImage = Nothing
        Me.btnLimpiar.Font = Nothing
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AccessibleDescription = Nothing
        Me.Label5.AccessibleName = Nothing
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'frmNuevoUsuario
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmNuevoUsuario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtApellidos As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class

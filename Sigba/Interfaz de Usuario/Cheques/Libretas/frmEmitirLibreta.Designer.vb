<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmitirLibreta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmitirLibreta))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.tabTipoCli = New System.Windows.Forms.TabControl
        Me.tabEmpresa = New System.Windows.Forms.TabPage
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.txtRUT = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.tabPersona = New System.Windows.Forms.TabPage
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtNroDoc = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cboNumCuenta = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtSerieLibreta = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCantCheques = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNroLibreta = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnEmitir = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.tabTipoCli.SuspendLayout()
        Me.tabEmpresa.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.tabPersona.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleDescription = Nothing
        Me.GroupBox1.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.BackgroundImage = Nothing
        Me.GroupBox1.Controls.Add(Me.tabTipoCli)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = Nothing
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'tabTipoCli
        '
        Me.tabTipoCli.AccessibleDescription = Nothing
        Me.tabTipoCli.AccessibleName = Nothing
        resources.ApplyResources(Me.tabTipoCli, "tabTipoCli")
        Me.tabTipoCli.BackgroundImage = Nothing
        Me.tabTipoCli.Controls.Add(Me.tabEmpresa)
        Me.tabTipoCli.Controls.Add(Me.tabPersona)
        Me.tabTipoCli.Font = Nothing
        Me.tabTipoCli.Name = "tabTipoCli"
        Me.tabTipoCli.SelectedIndex = 0
        '
        'tabEmpresa
        '
        Me.tabEmpresa.AccessibleDescription = Nothing
        Me.tabEmpresa.AccessibleName = Nothing
        resources.ApplyResources(Me.tabEmpresa, "tabEmpresa")
        Me.tabEmpresa.BackgroundImage = Nothing
        Me.tabEmpresa.Controls.Add(Me.GroupBox5)
        Me.tabEmpresa.Font = Nothing
        Me.tabEmpresa.Name = "tabEmpresa"
        Me.tabEmpresa.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.AccessibleDescription = Nothing
        Me.GroupBox5.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox5, "GroupBox5")
        Me.GroupBox5.BackgroundImage = Nothing
        Me.GroupBox5.Controls.Add(Me.txtRUT)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Font = Nothing
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.TabStop = False
        '
        'txtRUT
        '
        Me.txtRUT.AccessibleDescription = Nothing
        Me.txtRUT.AccessibleName = Nothing
        resources.ApplyResources(Me.txtRUT, "txtRUT")
        Me.txtRUT.BackgroundImage = Nothing
        Me.txtRUT.Font = Nothing
        Me.txtRUT.Name = "txtRUT"
        '
        'Label9
        '
        Me.Label9.AccessibleDescription = Nothing
        Me.Label9.AccessibleName = Nothing
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'tabPersona
        '
        Me.tabPersona.AccessibleDescription = Nothing
        Me.tabPersona.AccessibleName = Nothing
        resources.ApplyResources(Me.tabPersona, "tabPersona")
        Me.tabPersona.BackgroundImage = Nothing
        Me.tabPersona.Controls.Add(Me.GroupBox4)
        Me.tabPersona.Font = Nothing
        Me.tabPersona.Name = "tabPersona"
        Me.tabPersona.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.AccessibleDescription = Nothing
        Me.GroupBox4.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox4, "GroupBox4")
        Me.GroupBox4.BackgroundImage = Nothing
        Me.GroupBox4.Controls.Add(Me.txtNroDoc)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Font = Nothing
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.TabStop = False
        '
        'txtNroDoc
        '
        Me.txtNroDoc.AccessibleDescription = Nothing
        Me.txtNroDoc.AccessibleName = Nothing
        resources.ApplyResources(Me.txtNroDoc, "txtNroDoc")
        Me.txtNroDoc.BackgroundImage = Nothing
        Me.txtNroDoc.Font = Nothing
        Me.txtNroDoc.Name = "txtNroDoc"
        '
        'Label7
        '
        Me.Label7.AccessibleDescription = Nothing
        Me.Label7.AccessibleName = Nothing
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'GroupBox2
        '
        Me.GroupBox2.AccessibleDescription = Nothing
        Me.GroupBox2.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.BackgroundImage = Nothing
        Me.GroupBox2.Controls.Add(Me.cboNumCuenta)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = Nothing
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'cboNumCuenta
        '
        Me.cboNumCuenta.AccessibleDescription = Nothing
        Me.cboNumCuenta.AccessibleName = Nothing
        resources.ApplyResources(Me.cboNumCuenta, "cboNumCuenta")
        Me.cboNumCuenta.BackgroundImage = Nothing
        Me.cboNumCuenta.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboNumCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNumCuenta.Font = Nothing
        Me.cboNumCuenta.FormattingEnabled = True
        Me.cboNumCuenta.Name = "cboNumCuenta"
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = Nothing
        Me.Label1.AccessibleName = Nothing
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'GroupBox3
        '
        Me.GroupBox3.AccessibleDescription = Nothing
        Me.GroupBox3.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.BackgroundImage = Nothing
        Me.GroupBox3.Controls.Add(Me.txtSerieLibreta)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtCantCheques)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtNroLibreta)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Font = Nothing
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'txtSerieLibreta
        '
        Me.txtSerieLibreta.AccessibleDescription = Nothing
        Me.txtSerieLibreta.AccessibleName = Nothing
        resources.ApplyResources(Me.txtSerieLibreta, "txtSerieLibreta")
        Me.txtSerieLibreta.BackgroundImage = Nothing
        Me.txtSerieLibreta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSerieLibreta.Font = Nothing
        Me.txtSerieLibreta.Name = "txtSerieLibreta"
        '
        'Label4
        '
        Me.Label4.AccessibleDescription = Nothing
        Me.Label4.AccessibleName = Nothing
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'txtCantCheques
        '
        Me.txtCantCheques.AccessibleDescription = Nothing
        Me.txtCantCheques.AccessibleName = Nothing
        resources.ApplyResources(Me.txtCantCheques, "txtCantCheques")
        Me.txtCantCheques.BackgroundImage = Nothing
        Me.txtCantCheques.Font = Nothing
        Me.txtCantCheques.Name = "txtCantCheques"
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = Nothing
        Me.Label3.AccessibleName = Nothing
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'txtNroLibreta
        '
        Me.txtNroLibreta.AccessibleDescription = Nothing
        Me.txtNroLibreta.AccessibleName = Nothing
        resources.ApplyResources(Me.txtNroLibreta, "txtNroLibreta")
        Me.txtNroLibreta.BackgroundImage = Nothing
        Me.txtNroLibreta.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtNroLibreta.Font = Nothing
        Me.txtNroLibreta.Name = "txtNroLibreta"
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = Nothing
        Me.Label2.AccessibleName = Nothing
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'btnEmitir
        '
        Me.btnEmitir.AccessibleDescription = Nothing
        Me.btnEmitir.AccessibleName = Nothing
        resources.ApplyResources(Me.btnEmitir, "btnEmitir")
        Me.btnEmitir.BackgroundImage = Nothing
        Me.btnEmitir.Font = Nothing
        Me.btnEmitir.Name = "btnEmitir"
        Me.btnEmitir.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.AccessibleDescription = Nothing
        Me.btnCancelar.AccessibleName = Nothing
        resources.ApplyResources(Me.btnCancelar, "btnCancelar")
        Me.btnCancelar.BackgroundImage = Nothing
        Me.btnCancelar.Font = Nothing
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmEmitirLibreta
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEmitir)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmEmitirLibreta"
        Me.GroupBox1.ResumeLayout(False)
        Me.tabTipoCli.ResumeLayout(False)
        Me.tabEmpresa.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.tabPersona.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboNumCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNroLibreta As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCantCheques As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnEmitir As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtSerieLibreta As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tabTipoCli As System.Windows.Forms.TabControl
    Friend WithEvents tabPersona As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNroDoc As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tabEmpresa As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRUT As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class

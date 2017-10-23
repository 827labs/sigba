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
        Me.GroupBox1.Controls.Add(Me.tabTipoCli)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'tabTipoCli
        '
        Me.tabTipoCli.Controls.Add(Me.tabEmpresa)
        Me.tabTipoCli.Controls.Add(Me.tabPersona)
        resources.ApplyResources(Me.tabTipoCli, "tabTipoCli")
        Me.tabTipoCli.Name = "tabTipoCli"
        Me.tabTipoCli.SelectedIndex = 0
        '
        'tabEmpresa
        '
        Me.tabEmpresa.Controls.Add(Me.GroupBox5)
        resources.ApplyResources(Me.tabEmpresa, "tabEmpresa")
        Me.tabEmpresa.Name = "tabEmpresa"
        Me.tabEmpresa.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtRUT)
        Me.GroupBox5.Controls.Add(Me.Label9)
        resources.ApplyResources(Me.GroupBox5, "GroupBox5")
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.TabStop = False
        '
        'txtRUT
        '
        resources.ApplyResources(Me.txtRUT, "txtRUT")
        Me.txtRUT.Name = "txtRUT"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'tabPersona
        '
        Me.tabPersona.Controls.Add(Me.GroupBox4)
        resources.ApplyResources(Me.tabPersona, "tabPersona")
        Me.tabPersona.Name = "tabPersona"
        Me.tabPersona.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtNroDoc)
        Me.GroupBox4.Controls.Add(Me.Label7)
        resources.ApplyResources(Me.GroupBox4, "GroupBox4")
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.TabStop = False
        '
        'txtNroDoc
        '
        resources.ApplyResources(Me.txtNroDoc, "txtNroDoc")
        Me.txtNroDoc.Name = "txtNroDoc"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboNumCuenta)
        Me.GroupBox2.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'cboNumCuenta
        '
        Me.cboNumCuenta.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboNumCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNumCuenta.FormattingEnabled = True
        resources.ApplyResources(Me.cboNumCuenta, "cboNumCuenta")
        Me.cboNumCuenta.Name = "cboNumCuenta"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtSerieLibreta)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtCantCheques)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtNroLibreta)
        Me.GroupBox3.Controls.Add(Me.Label2)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'txtSerieLibreta
        '
        Me.txtSerieLibreta.Cursor = System.Windows.Forms.Cursors.IBeam
        resources.ApplyResources(Me.txtSerieLibreta, "txtSerieLibreta")
        Me.txtSerieLibreta.Name = "txtSerieLibreta"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'txtCantCheques
        '
        resources.ApplyResources(Me.txtCantCheques, "txtCantCheques")
        Me.txtCantCheques.Name = "txtCantCheques"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'txtNroLibreta
        '
        Me.txtNroLibreta.Cursor = System.Windows.Forms.Cursors.Arrow
        resources.ApplyResources(Me.txtNroLibreta, "txtNroLibreta")
        Me.txtNroLibreta.Name = "txtNroLibreta"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'btnEmitir
        '
        resources.ApplyResources(Me.btnEmitir, "btnEmitir")
        Me.btnEmitir.Name = "btnEmitir"
        Me.btnEmitir.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        resources.ApplyResources(Me.btnCancelar, "btnCancelar")
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmEmitirLibreta
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEmitir)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
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

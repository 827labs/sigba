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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cboNumCuenta = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.grpDocumento = New System.Windows.Forms.GroupBox
        Me.cboPaisDocCliente = New System.Windows.Forms.ComboBox
        Me.txtNroDocCliente = New System.Windows.Forms.TextBox
        Me.cboTipoDocCliente = New System.Windows.Forms.ComboBox
        Me.lblPaisDoc = New System.Windows.Forms.Label
        Me.lblTipoDoc = New System.Windows.Forms.Label
        Me.lblNroDocumento = New System.Windows.Forms.Label
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
        Me.GroupBox2.SuspendLayout()
        Me.grpDocumento.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleDescription = Nothing
        Me.GroupBox1.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.BackgroundImage = Nothing
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.grpDocumento)
        Me.GroupBox1.Font = Nothing
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
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
        'grpDocumento
        '
        Me.grpDocumento.AccessibleDescription = Nothing
        Me.grpDocumento.AccessibleName = Nothing
        resources.ApplyResources(Me.grpDocumento, "grpDocumento")
        Me.grpDocumento.BackgroundImage = Nothing
        Me.grpDocumento.Controls.Add(Me.cboPaisDocCliente)
        Me.grpDocumento.Controls.Add(Me.txtNroDocCliente)
        Me.grpDocumento.Controls.Add(Me.cboTipoDocCliente)
        Me.grpDocumento.Controls.Add(Me.lblPaisDoc)
        Me.grpDocumento.Controls.Add(Me.lblTipoDoc)
        Me.grpDocumento.Controls.Add(Me.lblNroDocumento)
        Me.grpDocumento.Font = Nothing
        Me.grpDocumento.Name = "grpDocumento"
        Me.grpDocumento.TabStop = False
        '
        'cboPaisDocCliente
        '
        Me.cboPaisDocCliente.AccessibleDescription = Nothing
        Me.cboPaisDocCliente.AccessibleName = Nothing
        resources.ApplyResources(Me.cboPaisDocCliente, "cboPaisDocCliente")
        Me.cboPaisDocCliente.BackgroundImage = Nothing
        Me.cboPaisDocCliente.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboPaisDocCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPaisDocCliente.Font = Nothing
        Me.cboPaisDocCliente.FormattingEnabled = True
        Me.cboPaisDocCliente.Name = "cboPaisDocCliente"
        '
        'txtNroDocCliente
        '
        Me.txtNroDocCliente.AccessibleDescription = Nothing
        Me.txtNroDocCliente.AccessibleName = Nothing
        resources.ApplyResources(Me.txtNroDocCliente, "txtNroDocCliente")
        Me.txtNroDocCliente.BackgroundImage = Nothing
        Me.txtNroDocCliente.Font = Nothing
        Me.txtNroDocCliente.Name = "txtNroDocCliente"
        '
        'cboTipoDocCliente
        '
        Me.cboTipoDocCliente.AccessibleDescription = Nothing
        Me.cboTipoDocCliente.AccessibleName = Nothing
        resources.ApplyResources(Me.cboTipoDocCliente, "cboTipoDocCliente")
        Me.cboTipoDocCliente.BackgroundImage = Nothing
        Me.cboTipoDocCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDocCliente.Font = Nothing
        Me.cboTipoDocCliente.FormattingEnabled = True
        Me.cboTipoDocCliente.Items.AddRange(New Object() {resources.GetString("cboTipoDocCliente.Items"), resources.GetString("cboTipoDocCliente.Items1"), resources.GetString("cboTipoDocCliente.Items2")})
        Me.cboTipoDocCliente.Name = "cboTipoDocCliente"
        '
        'lblPaisDoc
        '
        Me.lblPaisDoc.AccessibleDescription = Nothing
        Me.lblPaisDoc.AccessibleName = Nothing
        resources.ApplyResources(Me.lblPaisDoc, "lblPaisDoc")
        Me.lblPaisDoc.Name = "lblPaisDoc"
        '
        'lblTipoDoc
        '
        Me.lblTipoDoc.AccessibleDescription = Nothing
        Me.lblTipoDoc.AccessibleName = Nothing
        resources.ApplyResources(Me.lblTipoDoc, "lblTipoDoc")
        Me.lblTipoDoc.Name = "lblTipoDoc"
        '
        'lblNroDocumento
        '
        Me.lblNroDocumento.AccessibleDescription = Nothing
        Me.lblNroDocumento.AccessibleName = Nothing
        resources.ApplyResources(Me.lblNroDocumento, "lblNroDocumento")
        Me.lblNroDocumento.Name = "lblNroDocumento"
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
        Me.txtSerieLibreta.Cursor = System.Windows.Forms.Cursors.No
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
        Me.txtNroLibreta.Cursor = System.Windows.Forms.Cursors.No
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
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpDocumento.ResumeLayout(False)
        Me.grpDocumento.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grpDocumento As System.Windows.Forms.GroupBox
    Friend WithEvents cboPaisDocCliente As System.Windows.Forms.ComboBox
    Friend WithEvents txtNroDocCliente As System.Windows.Forms.TextBox
    Friend WithEvents cboTipoDocCliente As System.Windows.Forms.ComboBox
    Friend WithEvents lblPaisDoc As System.Windows.Forms.Label
    Friend WithEvents lblTipoDoc As System.Windows.Forms.Label
    Friend WithEvents lblNroDocumento As System.Windows.Forms.Label
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
End Class

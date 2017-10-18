<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCobrarCheque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCobrarCheque))
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboTipoCheque = New System.Windows.Forms.ComboBox
        Me.cboTipoCobro = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cboPaisDoc = New System.Windows.Forms.ComboBox
        Me.txtNroDoc = New System.Windows.Forms.TextBox
        Me.cboTipoDoc = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtFechaEmision = New System.Windows.Forms.MaskedTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtFechaCobro = New System.Windows.Forms.MaskedTextBox
        Me.txtNumLibreta = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboMontoMoneda = New System.Windows.Forms.ComboBox
        Me.txtMontoCantidad = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtNumSerie = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtNumCheque = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnProcesar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        'cboTipoCheque
        '
        Me.cboTipoCheque.AccessibleDescription = Nothing
        Me.cboTipoCheque.AccessibleName = Nothing
        resources.ApplyResources(Me.cboTipoCheque, "cboTipoCheque")
        Me.cboTipoCheque.BackgroundImage = Nothing
        Me.cboTipoCheque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoCheque.Font = Nothing
        Me.cboTipoCheque.FormattingEnabled = True
        Me.cboTipoCheque.Items.AddRange(New Object() {resources.GetString("cboTipoCheque.Items"), resources.GetString("cboTipoCheque.Items1"), resources.GetString("cboTipoCheque.Items2")})
        Me.cboTipoCheque.Name = "cboTipoCheque"
        '
        'cboTipoCobro
        '
        Me.cboTipoCobro.AccessibleDescription = Nothing
        Me.cboTipoCobro.AccessibleName = Nothing
        resources.ApplyResources(Me.cboTipoCobro, "cboTipoCobro")
        Me.cboTipoCobro.BackgroundImage = Nothing
        Me.cboTipoCobro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoCobro.Font = Nothing
        Me.cboTipoCobro.FormattingEnabled = True
        Me.cboTipoCobro.Items.AddRange(New Object() {resources.GetString("cboTipoCobro.Items"), resources.GetString("cboTipoCobro.Items1")})
        Me.cboTipoCobro.Name = "cboTipoCobro"
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = Nothing
        Me.Label2.AccessibleName = Nothing
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Font = Nothing
        Me.Label2.Name = "Label2"
        '
        'GroupBox2
        '
        Me.GroupBox2.AccessibleDescription = Nothing
        Me.GroupBox2.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.BackgroundImage = Nothing
        Me.GroupBox2.Controls.Add(Me.cboPaisDoc)
        Me.GroupBox2.Controls.Add(Me.txtNroDoc)
        Me.GroupBox2.Controls.Add(Me.cboTipoDoc)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = Nothing
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'cboPaisDoc
        '
        Me.cboPaisDoc.AccessibleDescription = Nothing
        Me.cboPaisDoc.AccessibleName = Nothing
        resources.ApplyResources(Me.cboPaisDoc, "cboPaisDoc")
        Me.cboPaisDoc.BackgroundImage = Nothing
        Me.cboPaisDoc.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboPaisDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPaisDoc.Font = Nothing
        Me.cboPaisDoc.FormattingEnabled = True
        Me.cboPaisDoc.Name = "cboPaisDoc"
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
        'cboTipoDoc
        '
        Me.cboTipoDoc.AccessibleDescription = Nothing
        Me.cboTipoDoc.AccessibleName = Nothing
        resources.ApplyResources(Me.cboTipoDoc, "cboTipoDoc")
        Me.cboTipoDoc.BackgroundImage = Nothing
        Me.cboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDoc.Font = Nothing
        Me.cboTipoDoc.FormattingEnabled = True
        Me.cboTipoDoc.Items.AddRange(New Object() {resources.GetString("cboTipoDoc.Items"), resources.GetString("cboTipoDoc.Items1"), resources.GetString("cboTipoDoc.Items2")})
        Me.cboTipoDoc.Name = "cboTipoDoc"
        '
        'Label5
        '
        Me.Label5.AccessibleDescription = Nothing
        Me.Label5.AccessibleName = Nothing
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label6
        '
        Me.Label6.AccessibleDescription = Nothing
        Me.Label6.AccessibleName = Nothing
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Label7
        '
        Me.Label7.AccessibleDescription = Nothing
        Me.Label7.AccessibleName = Nothing
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'txtFechaEmision
        '
        Me.txtFechaEmision.AccessibleDescription = Nothing
        Me.txtFechaEmision.AccessibleName = Nothing
        resources.ApplyResources(Me.txtFechaEmision, "txtFechaEmision")
        Me.txtFechaEmision.BackgroundImage = Nothing
        Me.txtFechaEmision.Font = Nothing
        Me.txtFechaEmision.Name = "txtFechaEmision"
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = Nothing
        Me.Label3.AccessibleName = Nothing
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Font = Nothing
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        Me.Label4.AccessibleDescription = Nothing
        Me.Label4.AccessibleName = Nothing
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Font = Nothing
        Me.Label4.Name = "Label4"
        '
        'txtFechaCobro
        '
        Me.txtFechaCobro.AccessibleDescription = Nothing
        Me.txtFechaCobro.AccessibleName = Nothing
        resources.ApplyResources(Me.txtFechaCobro, "txtFechaCobro")
        Me.txtFechaCobro.BackgroundImage = Nothing
        Me.txtFechaCobro.Font = Nothing
        Me.txtFechaCobro.Name = "txtFechaCobro"
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
        'Label8
        '
        Me.Label8.AccessibleDescription = Nothing
        Me.Label8.AccessibleName = Nothing
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Font = Nothing
        Me.Label8.Name = "Label8"
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleDescription = Nothing
        Me.GroupBox1.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.BackgroundImage = Nothing
        Me.GroupBox1.Controls.Add(Me.cboMontoMoneda)
        Me.GroupBox1.Controls.Add(Me.txtMontoCantidad)
        Me.GroupBox1.Font = Nothing
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'cboMontoMoneda
        '
        Me.cboMontoMoneda.AccessibleDescription = Nothing
        Me.cboMontoMoneda.AccessibleName = Nothing
        resources.ApplyResources(Me.cboMontoMoneda, "cboMontoMoneda")
        Me.cboMontoMoneda.BackgroundImage = Nothing
        Me.cboMontoMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMontoMoneda.Font = Nothing
        Me.cboMontoMoneda.FormattingEnabled = True
        Me.cboMontoMoneda.Items.AddRange(New Object() {resources.GetString("cboMontoMoneda.Items"), resources.GetString("cboMontoMoneda.Items1")})
        Me.cboMontoMoneda.Name = "cboMontoMoneda"
        '
        'txtMontoCantidad
        '
        Me.txtMontoCantidad.AccessibleDescription = Nothing
        Me.txtMontoCantidad.AccessibleName = Nothing
        resources.ApplyResources(Me.txtMontoCantidad, "txtMontoCantidad")
        Me.txtMontoCantidad.BackgroundImage = Nothing
        Me.txtMontoCantidad.Font = Nothing
        Me.txtMontoCantidad.Name = "txtMontoCantidad"
        '
        'Label9
        '
        Me.Label9.AccessibleDescription = Nothing
        Me.Label9.AccessibleName = Nothing
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Font = Nothing
        Me.Label9.Name = "Label9"
        '
        'txtNumSerie
        '
        Me.txtNumSerie.AccessibleDescription = Nothing
        Me.txtNumSerie.AccessibleName = Nothing
        resources.ApplyResources(Me.txtNumSerie, "txtNumSerie")
        Me.txtNumSerie.BackgroundImage = Nothing
        Me.txtNumSerie.Font = Nothing
        Me.txtNumSerie.Name = "txtNumSerie"
        '
        'Label10
        '
        Me.Label10.AccessibleDescription = Nothing
        Me.Label10.AccessibleName = Nothing
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Font = Nothing
        Me.Label10.Name = "Label10"
        '
        'txtNumCheque
        '
        Me.txtNumCheque.AccessibleDescription = Nothing
        Me.txtNumCheque.AccessibleName = Nothing
        resources.ApplyResources(Me.txtNumCheque, "txtNumCheque")
        Me.txtNumCheque.BackgroundImage = Nothing
        Me.txtNumCheque.Font = Nothing
        Me.txtNumCheque.Name = "txtNumCheque"
        '
        'Label11
        '
        Me.Label11.AccessibleDescription = Nothing
        Me.Label11.AccessibleName = Nothing
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'btnProcesar
        '
        Me.btnProcesar.AccessibleDescription = Nothing
        Me.btnProcesar.AccessibleName = Nothing
        resources.ApplyResources(Me.btnProcesar, "btnProcesar")
        Me.btnProcesar.BackgroundImage = Nothing
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.UseVisualStyleBackColor = True
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
        'frmCobrarCheque
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtNumCheque)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNumSerie)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtNumLibreta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFechaCobro)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFechaEmision)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cboTipoCobro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboTipoCheque)
        Me.Controls.Add(Me.Label1)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCobrarCheque"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboTipoCheque As System.Windows.Forms.ComboBox
    Friend WithEvents cboTipoCobro As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboPaisDoc As System.Windows.Forms.ComboBox
    Friend WithEvents txtNroDoc As System.Windows.Forms.TextBox
    Friend WithEvents cboTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtFechaEmision As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFechaCobro As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtNumLibreta As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboMontoMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents txtMontoCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNumSerie As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNumCheque As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class

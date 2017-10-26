<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBajaCliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBajaCliente))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cboPaisDoc = New System.Windows.Forms.ComboBox
        Me.txtNroDoc = New System.Windows.Forms.TextBox
        Me.cboTipoDoc = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtRazonBaja = New System.Windows.Forms.TextBox
        Me.btnContinuar = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lblNombreEmpresa = New System.Windows.Forms.Label
        Me.txtRUT = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tabTipoCliente = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.tabTipoCliente.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.cboPaisDoc.Items.AddRange(New Object() {resources.GetString("cboPaisDoc.Items"), resources.GetString("cboPaisDoc.Items1"), resources.GetString("cboPaisDoc.Items2"), resources.GetString("cboPaisDoc.Items3"), resources.GetString("cboPaisDoc.Items4"), resources.GetString("cboPaisDoc.Items5"), resources.GetString("cboPaisDoc.Items6"), resources.GetString("cboPaisDoc.Items7"), resources.GetString("cboPaisDoc.Items8"), resources.GetString("cboPaisDoc.Items9"), resources.GetString("cboPaisDoc.Items10"), resources.GetString("cboPaisDoc.Items11"), resources.GetString("cboPaisDoc.Items12"), resources.GetString("cboPaisDoc.Items13"), resources.GetString("cboPaisDoc.Items14"), resources.GetString("cboPaisDoc.Items15"), resources.GetString("cboPaisDoc.Items16"), resources.GetString("cboPaisDoc.Items17"), resources.GetString("cboPaisDoc.Items18"), resources.GetString("cboPaisDoc.Items19"), resources.GetString("cboPaisDoc.Items20"), resources.GetString("cboPaisDoc.Items21"), resources.GetString("cboPaisDoc.Items22"), resources.GetString("cboPaisDoc.Items23"), resources.GetString("cboPaisDoc.Items24"), resources.GetString("cboPaisDoc.Items25"), resources.GetString("cboPaisDoc.Items26"), resources.GetString("cboPaisDoc.Items27"), resources.GetString("cboPaisDoc.Items28"), resources.GetString("cboPaisDoc.Items29"), resources.GetString("cboPaisDoc.Items30"), resources.GetString("cboPaisDoc.Items31"), resources.GetString("cboPaisDoc.Items32"), resources.GetString("cboPaisDoc.Items33"), resources.GetString("cboPaisDoc.Items34"), resources.GetString("cboPaisDoc.Items35"), resources.GetString("cboPaisDoc.Items36"), resources.GetString("cboPaisDoc.Items37"), resources.GetString("cboPaisDoc.Items38"), resources.GetString("cboPaisDoc.Items39"), resources.GetString("cboPaisDoc.Items40"), resources.GetString("cboPaisDoc.Items41"), resources.GetString("cboPaisDoc.Items42"), resources.GetString("cboPaisDoc.Items43"), resources.GetString("cboPaisDoc.Items44"), resources.GetString("cboPaisDoc.Items45"), resources.GetString("cboPaisDoc.Items46"), resources.GetString("cboPaisDoc.Items47"), resources.GetString("cboPaisDoc.Items48"), resources.GetString("cboPaisDoc.Items49"), resources.GetString("cboPaisDoc.Items50"), resources.GetString("cboPaisDoc.Items51"), resources.GetString("cboPaisDoc.Items52"), resources.GetString("cboPaisDoc.Items53"), resources.GetString("cboPaisDoc.Items54"), resources.GetString("cboPaisDoc.Items55"), resources.GetString("cboPaisDoc.Items56"), resources.GetString("cboPaisDoc.Items57"), resources.GetString("cboPaisDoc.Items58"), resources.GetString("cboPaisDoc.Items59"), resources.GetString("cboPaisDoc.Items60"), resources.GetString("cboPaisDoc.Items61"), resources.GetString("cboPaisDoc.Items62"), resources.GetString("cboPaisDoc.Items63"), resources.GetString("cboPaisDoc.Items64"), resources.GetString("cboPaisDoc.Items65"), resources.GetString("cboPaisDoc.Items66"), resources.GetString("cboPaisDoc.Items67"), resources.GetString("cboPaisDoc.Items68"), resources.GetString("cboPaisDoc.Items69"), resources.GetString("cboPaisDoc.Items70"), resources.GetString("cboPaisDoc.Items71"), resources.GetString("cboPaisDoc.Items72"), resources.GetString("cboPaisDoc.Items73"), resources.GetString("cboPaisDoc.Items74"), resources.GetString("cboPaisDoc.Items75"), resources.GetString("cboPaisDoc.Items76"), resources.GetString("cboPaisDoc.Items77"), resources.GetString("cboPaisDoc.Items78"), resources.GetString("cboPaisDoc.Items79"), resources.GetString("cboPaisDoc.Items80"), resources.GetString("cboPaisDoc.Items81"), resources.GetString("cboPaisDoc.Items82"), resources.GetString("cboPaisDoc.Items83"), resources.GetString("cboPaisDoc.Items84"), resources.GetString("cboPaisDoc.Items85"), resources.GetString("cboPaisDoc.Items86"), resources.GetString("cboPaisDoc.Items87"), resources.GetString("cboPaisDoc.Items88"), resources.GetString("cboPaisDoc.Items89"), resources.GetString("cboPaisDoc.Items90"), resources.GetString("cboPaisDoc.Items91"), resources.GetString("cboPaisDoc.Items92"), resources.GetString("cboPaisDoc.Items93"), resources.GetString("cboPaisDoc.Items94"), resources.GetString("cboPaisDoc.Items95"), resources.GetString("cboPaisDoc.Items96"), resources.GetString("cboPaisDoc.Items97"), resources.GetString("cboPaisDoc.Items98"), resources.GetString("cboPaisDoc.Items99"), resources.GetString("cboPaisDoc.Items100"), resources.GetString("cboPaisDoc.Items101"), resources.GetString("cboPaisDoc.Items102"), resources.GetString("cboPaisDoc.Items103"), resources.GetString("cboPaisDoc.Items104"), resources.GetString("cboPaisDoc.Items105"), resources.GetString("cboPaisDoc.Items106"), resources.GetString("cboPaisDoc.Items107"), resources.GetString("cboPaisDoc.Items108"), resources.GetString("cboPaisDoc.Items109"), resources.GetString("cboPaisDoc.Items110"), resources.GetString("cboPaisDoc.Items111"), resources.GetString("cboPaisDoc.Items112"), resources.GetString("cboPaisDoc.Items113"), resources.GetString("cboPaisDoc.Items114"), resources.GetString("cboPaisDoc.Items115"), resources.GetString("cboPaisDoc.Items116"), resources.GetString("cboPaisDoc.Items117"), resources.GetString("cboPaisDoc.Items118"), resources.GetString("cboPaisDoc.Items119"), resources.GetString("cboPaisDoc.Items120"), resources.GetString("cboPaisDoc.Items121"), resources.GetString("cboPaisDoc.Items122"), resources.GetString("cboPaisDoc.Items123"), resources.GetString("cboPaisDoc.Items124"), resources.GetString("cboPaisDoc.Items125"), resources.GetString("cboPaisDoc.Items126"), resources.GetString("cboPaisDoc.Items127"), resources.GetString("cboPaisDoc.Items128"), resources.GetString("cboPaisDoc.Items129"), resources.GetString("cboPaisDoc.Items130"), resources.GetString("cboPaisDoc.Items131"), resources.GetString("cboPaisDoc.Items132"), resources.GetString("cboPaisDoc.Items133"), resources.GetString("cboPaisDoc.Items134"), resources.GetString("cboPaisDoc.Items135"), resources.GetString("cboPaisDoc.Items136"), resources.GetString("cboPaisDoc.Items137"), resources.GetString("cboPaisDoc.Items138"), resources.GetString("cboPaisDoc.Items139"), resources.GetString("cboPaisDoc.Items140"), resources.GetString("cboPaisDoc.Items141"), resources.GetString("cboPaisDoc.Items142"), resources.GetString("cboPaisDoc.Items143"), resources.GetString("cboPaisDoc.Items144"), resources.GetString("cboPaisDoc.Items145"), resources.GetString("cboPaisDoc.Items146"), resources.GetString("cboPaisDoc.Items147"), resources.GetString("cboPaisDoc.Items148"), resources.GetString("cboPaisDoc.Items149"), resources.GetString("cboPaisDoc.Items150"), resources.GetString("cboPaisDoc.Items151"), resources.GetString("cboPaisDoc.Items152"), resources.GetString("cboPaisDoc.Items153"), resources.GetString("cboPaisDoc.Items154"), resources.GetString("cboPaisDoc.Items155"), resources.GetString("cboPaisDoc.Items156"), resources.GetString("cboPaisDoc.Items157"), resources.GetString("cboPaisDoc.Items158"), resources.GetString("cboPaisDoc.Items159"), resources.GetString("cboPaisDoc.Items160"), resources.GetString("cboPaisDoc.Items161"), resources.GetString("cboPaisDoc.Items162"), resources.GetString("cboPaisDoc.Items163"), resources.GetString("cboPaisDoc.Items164"), resources.GetString("cboPaisDoc.Items165"), resources.GetString("cboPaisDoc.Items166"), resources.GetString("cboPaisDoc.Items167"), resources.GetString("cboPaisDoc.Items168"), resources.GetString("cboPaisDoc.Items169"), resources.GetString("cboPaisDoc.Items170"), resources.GetString("cboPaisDoc.Items171"), resources.GetString("cboPaisDoc.Items172"), resources.GetString("cboPaisDoc.Items173"), resources.GetString("cboPaisDoc.Items174"), resources.GetString("cboPaisDoc.Items175"), resources.GetString("cboPaisDoc.Items176"), resources.GetString("cboPaisDoc.Items177"), resources.GetString("cboPaisDoc.Items178"), resources.GetString("cboPaisDoc.Items179"), resources.GetString("cboPaisDoc.Items180"), resources.GetString("cboPaisDoc.Items181"), resources.GetString("cboPaisDoc.Items182"), resources.GetString("cboPaisDoc.Items183"), resources.GetString("cboPaisDoc.Items184"), resources.GetString("cboPaisDoc.Items185"), resources.GetString("cboPaisDoc.Items186"), resources.GetString("cboPaisDoc.Items187"), resources.GetString("cboPaisDoc.Items188"), resources.GetString("cboPaisDoc.Items189"), resources.GetString("cboPaisDoc.Items190"), resources.GetString("cboPaisDoc.Items191"), resources.GetString("cboPaisDoc.Items192"), resources.GetString("cboPaisDoc.Items193"), resources.GetString("cboPaisDoc.Items194"), resources.GetString("cboPaisDoc.Items195"), resources.GetString("cboPaisDoc.Items196")})
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
        'GroupBox1
        '
        Me.GroupBox1.AccessibleDescription = Nothing
        Me.GroupBox1.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.BackgroundImage = Nothing
        Me.GroupBox1.Controls.Add(Me.txtRazonBaja)
        Me.GroupBox1.Font = Nothing
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'txtRazonBaja
        '
        Me.txtRazonBaja.AccessibleDescription = Nothing
        Me.txtRazonBaja.AccessibleName = Nothing
        resources.ApplyResources(Me.txtRazonBaja, "txtRazonBaja")
        Me.txtRazonBaja.BackgroundImage = Nothing
        Me.txtRazonBaja.Font = Nothing
        Me.txtRazonBaja.Name = "txtRazonBaja"
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
        'GroupBox3
        '
        Me.GroupBox3.AccessibleDescription = Nothing
        Me.GroupBox3.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.BackgroundImage = Nothing
        Me.GroupBox3.Controls.Add(Me.lblNombreEmpresa)
        Me.GroupBox3.Controls.Add(Me.txtRUT)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Font = Nothing
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'lblNombreEmpresa
        '
        Me.lblNombreEmpresa.AccessibleDescription = Nothing
        Me.lblNombreEmpresa.AccessibleName = Nothing
        resources.ApplyResources(Me.lblNombreEmpresa, "lblNombreEmpresa")
        Me.lblNombreEmpresa.Name = "lblNombreEmpresa"
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
        'Label1
        '
        Me.Label1.AccessibleDescription = Nothing
        Me.Label1.AccessibleName = Nothing
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'tabTipoCliente
        '
        Me.tabTipoCliente.AccessibleDescription = Nothing
        Me.tabTipoCliente.AccessibleName = Nothing
        resources.ApplyResources(Me.tabTipoCliente, "tabTipoCliente")
        Me.tabTipoCliente.BackgroundImage = Nothing
        Me.tabTipoCliente.Controls.Add(Me.TabPage1)
        Me.tabTipoCliente.Controls.Add(Me.TabPage2)
        Me.tabTipoCliente.Font = Nothing
        Me.tabTipoCliente.Name = "tabTipoCliente"
        Me.tabTipoCliente.SelectedIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AccessibleDescription = Nothing
        Me.TabPage1.AccessibleName = Nothing
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.BackgroundImage = Nothing
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Font = Nothing
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.AccessibleDescription = Nothing
        Me.TabPage2.AccessibleName = Nothing
        resources.ApplyResources(Me.TabPage2, "TabPage2")
        Me.TabPage2.BackgroundImage = Nothing
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Font = Nothing
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'frmBajaCliente
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.tabTipoCliente)
        Me.Controls.Add(Me.btnContinuar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = Nothing
        Me.MaximizeBox = False
        Me.Name = "frmBajaCliente"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.tabTipoCliente.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboPaisDoc As System.Windows.Forms.ComboBox
    Friend WithEvents txtNroDoc As System.Windows.Forms.TextBox
    Friend WithEvents cboTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRazonBaja As System.Windows.Forms.TextBox
    Friend WithEvents btnContinuar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNombreEmpresa As System.Windows.Forms.Label
    Friend WithEvents txtRUT As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tabTipoCliente As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
End Class

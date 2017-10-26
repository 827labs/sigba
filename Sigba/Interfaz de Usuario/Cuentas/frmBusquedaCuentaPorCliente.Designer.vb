<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaCuentaPorCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBusquedaCuentaPorCliente))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtNroDoc = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.dgvCuentas = New System.Windows.Forms.DataGridView
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.TabControl = New System.Windows.Forms.TabControl
        Me.tabPersona = New System.Windows.Forms.TabPage
        Me.tabEmpresa = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtRUT = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblMotivoAux = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.tabPersona.SuspendLayout()
        Me.tabEmpresa.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.AccessibleDescription = Nothing
        Me.GroupBox2.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.BackgroundImage = Nothing
        Me.GroupBox2.Controls.Add(Me.txtNroDoc)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = Nothing
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
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
        'dgvCuentas
        '
        Me.dgvCuentas.AccessibleDescription = Nothing
        Me.dgvCuentas.AccessibleName = Nothing
        Me.dgvCuentas.AllowUserToAddRows = False
        Me.dgvCuentas.AllowUserToDeleteRows = False
        resources.ApplyResources(Me.dgvCuentas, "dgvCuentas")
        Me.dgvCuentas.BackgroundImage = Nothing
        Me.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCuentas.Font = Nothing
        Me.dgvCuentas.Name = "dgvCuentas"
        Me.dgvCuentas.ReadOnly = True
        '
        'btnBuscar
        '
        Me.btnBuscar.AccessibleDescription = Nothing
        Me.btnBuscar.AccessibleName = Nothing
        resources.ApplyResources(Me.btnBuscar, "btnBuscar")
        Me.btnBuscar.BackgroundImage = Nothing
        Me.btnBuscar.Font = Nothing
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'TabControl
        '
        Me.TabControl.AccessibleDescription = Nothing
        Me.TabControl.AccessibleName = Nothing
        resources.ApplyResources(Me.TabControl, "TabControl")
        Me.TabControl.BackgroundImage = Nothing
        Me.TabControl.Controls.Add(Me.tabPersona)
        Me.TabControl.Controls.Add(Me.tabEmpresa)
        Me.TabControl.Font = Nothing
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        '
        'tabPersona
        '
        Me.tabPersona.AccessibleDescription = Nothing
        Me.tabPersona.AccessibleName = Nothing
        resources.ApplyResources(Me.tabPersona, "tabPersona")
        Me.tabPersona.BackgroundImage = Nothing
        Me.tabPersona.Controls.Add(Me.GroupBox2)
        Me.tabPersona.Font = Nothing
        Me.tabPersona.Name = "tabPersona"
        Me.tabPersona.UseVisualStyleBackColor = True
        '
        'tabEmpresa
        '
        Me.tabEmpresa.AccessibleDescription = Nothing
        Me.tabEmpresa.AccessibleName = Nothing
        resources.ApplyResources(Me.tabEmpresa, "tabEmpresa")
        Me.tabEmpresa.BackgroundImage = Nothing
        Me.tabEmpresa.Controls.Add(Me.GroupBox1)
        Me.tabEmpresa.Font = Nothing
        Me.tabEmpresa.Name = "tabEmpresa"
        Me.tabEmpresa.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleDescription = Nothing
        Me.GroupBox1.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.BackgroundImage = Nothing
        Me.GroupBox1.Controls.Add(Me.txtRUT)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = Nothing
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
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
        'ComboBox1
        '
        Me.ComboBox1.AccessibleDescription = Nothing
        Me.ComboBox1.AccessibleName = Nothing
        resources.ApplyResources(Me.ComboBox1, "ComboBox1")
        Me.ComboBox1.BackgroundImage = Nothing
        Me.ComboBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = Nothing
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {resources.GetString("ComboBox1.Items"), resources.GetString("ComboBox1.Items1"), resources.GetString("ComboBox1.Items2"), resources.GetString("ComboBox1.Items3"), resources.GetString("ComboBox1.Items4"), resources.GetString("ComboBox1.Items5"), resources.GetString("ComboBox1.Items6"), resources.GetString("ComboBox1.Items7"), resources.GetString("ComboBox1.Items8"), resources.GetString("ComboBox1.Items9"), resources.GetString("ComboBox1.Items10"), resources.GetString("ComboBox1.Items11"), resources.GetString("ComboBox1.Items12"), resources.GetString("ComboBox1.Items13"), resources.GetString("ComboBox1.Items14"), resources.GetString("ComboBox1.Items15"), resources.GetString("ComboBox1.Items16"), resources.GetString("ComboBox1.Items17"), resources.GetString("ComboBox1.Items18"), resources.GetString("ComboBox1.Items19"), resources.GetString("ComboBox1.Items20"), resources.GetString("ComboBox1.Items21"), resources.GetString("ComboBox1.Items22"), resources.GetString("ComboBox1.Items23"), resources.GetString("ComboBox1.Items24"), resources.GetString("ComboBox1.Items25"), resources.GetString("ComboBox1.Items26"), resources.GetString("ComboBox1.Items27"), resources.GetString("ComboBox1.Items28"), resources.GetString("ComboBox1.Items29"), resources.GetString("ComboBox1.Items30"), resources.GetString("ComboBox1.Items31"), resources.GetString("ComboBox1.Items32"), resources.GetString("ComboBox1.Items33"), resources.GetString("ComboBox1.Items34"), resources.GetString("ComboBox1.Items35"), resources.GetString("ComboBox1.Items36"), resources.GetString("ComboBox1.Items37"), resources.GetString("ComboBox1.Items38"), resources.GetString("ComboBox1.Items39"), resources.GetString("ComboBox1.Items40"), resources.GetString("ComboBox1.Items41"), resources.GetString("ComboBox1.Items42"), resources.GetString("ComboBox1.Items43"), resources.GetString("ComboBox1.Items44"), resources.GetString("ComboBox1.Items45"), resources.GetString("ComboBox1.Items46"), resources.GetString("ComboBox1.Items47"), resources.GetString("ComboBox1.Items48"), resources.GetString("ComboBox1.Items49"), resources.GetString("ComboBox1.Items50"), resources.GetString("ComboBox1.Items51"), resources.GetString("ComboBox1.Items52"), resources.GetString("ComboBox1.Items53"), resources.GetString("ComboBox1.Items54"), resources.GetString("ComboBox1.Items55"), resources.GetString("ComboBox1.Items56"), resources.GetString("ComboBox1.Items57"), resources.GetString("ComboBox1.Items58"), resources.GetString("ComboBox1.Items59"), resources.GetString("ComboBox1.Items60"), resources.GetString("ComboBox1.Items61"), resources.GetString("ComboBox1.Items62"), resources.GetString("ComboBox1.Items63"), resources.GetString("ComboBox1.Items64"), resources.GetString("ComboBox1.Items65"), resources.GetString("ComboBox1.Items66"), resources.GetString("ComboBox1.Items67"), resources.GetString("ComboBox1.Items68"), resources.GetString("ComboBox1.Items69"), resources.GetString("ComboBox1.Items70"), resources.GetString("ComboBox1.Items71"), resources.GetString("ComboBox1.Items72"), resources.GetString("ComboBox1.Items73"), resources.GetString("ComboBox1.Items74"), resources.GetString("ComboBox1.Items75"), resources.GetString("ComboBox1.Items76"), resources.GetString("ComboBox1.Items77"), resources.GetString("ComboBox1.Items78"), resources.GetString("ComboBox1.Items79"), resources.GetString("ComboBox1.Items80"), resources.GetString("ComboBox1.Items81"), resources.GetString("ComboBox1.Items82"), resources.GetString("ComboBox1.Items83"), resources.GetString("ComboBox1.Items84"), resources.GetString("ComboBox1.Items85"), resources.GetString("ComboBox1.Items86"), resources.GetString("ComboBox1.Items87"), resources.GetString("ComboBox1.Items88"), resources.GetString("ComboBox1.Items89"), resources.GetString("ComboBox1.Items90"), resources.GetString("ComboBox1.Items91"), resources.GetString("ComboBox1.Items92"), resources.GetString("ComboBox1.Items93"), resources.GetString("ComboBox1.Items94"), resources.GetString("ComboBox1.Items95"), resources.GetString("ComboBox1.Items96"), resources.GetString("ComboBox1.Items97"), resources.GetString("ComboBox1.Items98"), resources.GetString("ComboBox1.Items99"), resources.GetString("ComboBox1.Items100"), resources.GetString("ComboBox1.Items101"), resources.GetString("ComboBox1.Items102"), resources.GetString("ComboBox1.Items103"), resources.GetString("ComboBox1.Items104"), resources.GetString("ComboBox1.Items105"), resources.GetString("ComboBox1.Items106"), resources.GetString("ComboBox1.Items107"), resources.GetString("ComboBox1.Items108"), resources.GetString("ComboBox1.Items109"), resources.GetString("ComboBox1.Items110"), resources.GetString("ComboBox1.Items111"), resources.GetString("ComboBox1.Items112"), resources.GetString("ComboBox1.Items113"), resources.GetString("ComboBox1.Items114"), resources.GetString("ComboBox1.Items115"), resources.GetString("ComboBox1.Items116"), resources.GetString("ComboBox1.Items117"), resources.GetString("ComboBox1.Items118"), resources.GetString("ComboBox1.Items119"), resources.GetString("ComboBox1.Items120"), resources.GetString("ComboBox1.Items121"), resources.GetString("ComboBox1.Items122"), resources.GetString("ComboBox1.Items123"), resources.GetString("ComboBox1.Items124"), resources.GetString("ComboBox1.Items125"), resources.GetString("ComboBox1.Items126"), resources.GetString("ComboBox1.Items127"), resources.GetString("ComboBox1.Items128"), resources.GetString("ComboBox1.Items129"), resources.GetString("ComboBox1.Items130"), resources.GetString("ComboBox1.Items131"), resources.GetString("ComboBox1.Items132"), resources.GetString("ComboBox1.Items133"), resources.GetString("ComboBox1.Items134"), resources.GetString("ComboBox1.Items135"), resources.GetString("ComboBox1.Items136"), resources.GetString("ComboBox1.Items137"), resources.GetString("ComboBox1.Items138"), resources.GetString("ComboBox1.Items139"), resources.GetString("ComboBox1.Items140"), resources.GetString("ComboBox1.Items141"), resources.GetString("ComboBox1.Items142"), resources.GetString("ComboBox1.Items143"), resources.GetString("ComboBox1.Items144"), resources.GetString("ComboBox1.Items145"), resources.GetString("ComboBox1.Items146"), resources.GetString("ComboBox1.Items147"), resources.GetString("ComboBox1.Items148"), resources.GetString("ComboBox1.Items149"), resources.GetString("ComboBox1.Items150"), resources.GetString("ComboBox1.Items151"), resources.GetString("ComboBox1.Items152"), resources.GetString("ComboBox1.Items153"), resources.GetString("ComboBox1.Items154"), resources.GetString("ComboBox1.Items155"), resources.GetString("ComboBox1.Items156"), resources.GetString("ComboBox1.Items157"), resources.GetString("ComboBox1.Items158"), resources.GetString("ComboBox1.Items159"), resources.GetString("ComboBox1.Items160"), resources.GetString("ComboBox1.Items161"), resources.GetString("ComboBox1.Items162"), resources.GetString("ComboBox1.Items163"), resources.GetString("ComboBox1.Items164"), resources.GetString("ComboBox1.Items165"), resources.GetString("ComboBox1.Items166"), resources.GetString("ComboBox1.Items167"), resources.GetString("ComboBox1.Items168"), resources.GetString("ComboBox1.Items169"), resources.GetString("ComboBox1.Items170"), resources.GetString("ComboBox1.Items171"), resources.GetString("ComboBox1.Items172"), resources.GetString("ComboBox1.Items173"), resources.GetString("ComboBox1.Items174"), resources.GetString("ComboBox1.Items175"), resources.GetString("ComboBox1.Items176"), resources.GetString("ComboBox1.Items177"), resources.GetString("ComboBox1.Items178"), resources.GetString("ComboBox1.Items179"), resources.GetString("ComboBox1.Items180"), resources.GetString("ComboBox1.Items181"), resources.GetString("ComboBox1.Items182"), resources.GetString("ComboBox1.Items183"), resources.GetString("ComboBox1.Items184"), resources.GetString("ComboBox1.Items185"), resources.GetString("ComboBox1.Items186"), resources.GetString("ComboBox1.Items187"), resources.GetString("ComboBox1.Items188"), resources.GetString("ComboBox1.Items189"), resources.GetString("ComboBox1.Items190"), resources.GetString("ComboBox1.Items191"), resources.GetString("ComboBox1.Items192"), resources.GetString("ComboBox1.Items193"), resources.GetString("ComboBox1.Items194"), resources.GetString("ComboBox1.Items195"), resources.GetString("ComboBox1.Items196")})
        Me.ComboBox1.Name = "ComboBox1"
        '
        'TextBox1
        '
        Me.TextBox1.AccessibleDescription = Nothing
        Me.TextBox1.AccessibleName = Nothing
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.BackgroundImage = Nothing
        Me.TextBox1.Font = Nothing
        Me.TextBox1.Name = "TextBox1"
        '
        'ComboBox2
        '
        Me.ComboBox2.AccessibleDescription = Nothing
        Me.ComboBox2.AccessibleName = Nothing
        resources.ApplyResources(Me.ComboBox2, "ComboBox2")
        Me.ComboBox2.BackgroundImage = Nothing
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = Nothing
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {resources.GetString("ComboBox2.Items"), resources.GetString("ComboBox2.Items1"), resources.GetString("ComboBox2.Items2")})
        Me.ComboBox2.Name = "ComboBox2"
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = Nothing
        Me.Label1.AccessibleName = Nothing
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = Nothing
        Me.Label2.AccessibleName = Nothing
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = Nothing
        Me.Label3.AccessibleName = Nothing
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'lblMotivoAux
        '
        Me.lblMotivoAux.AccessibleDescription = Nothing
        Me.lblMotivoAux.AccessibleName = Nothing
        resources.ApplyResources(Me.lblMotivoAux, "lblMotivoAux")
        Me.lblMotivoAux.Font = Nothing
        Me.lblMotivoAux.Name = "lblMotivoAux"
        '
        'frmBusquedaCuentaPorCliente
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.lblMotivoAux)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.dgvCuentas)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBusquedaCuentaPorCliente"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.tabPersona.ResumeLayout(False)
        Me.tabEmpresa.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNroDoc As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgvCuentas As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents tabPersona As System.Windows.Forms.TabPage
    Friend WithEvents tabEmpresa As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRUT As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblMotivoAux As System.Windows.Forms.Label
End Class

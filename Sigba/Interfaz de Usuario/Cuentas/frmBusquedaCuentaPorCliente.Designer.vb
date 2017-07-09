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
        Me.cboPaisDoc = New System.Windows.Forms.ComboBox
        Me.txtNroDoc = New System.Windows.Forms.TextBox
        Me.cboTipoDoc = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.dgvCuentas = New System.Windows.Forms.DataGridView
        Me.numCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.saldoCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ultTransaccion = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        Me.GroupBox2.Controls.Add(Me.cboPaisDoc)
        Me.GroupBox2.Controls.Add(Me.txtNroDoc)
        Me.GroupBox2.Controls.Add(Me.cboTipoDoc)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 67)
        Me.GroupBox2.TabIndex = 85
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Documento"
        '
        'cboPaisDoc
        '
        Me.cboPaisDoc.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboPaisDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPaisDoc.FormattingEnabled = True
        Me.cboPaisDoc.Items.AddRange(New Object() {"Afganistán", "Albania" & Global.Microsoft.VisualBasic.ChrW(9), "Alemania" & Global.Microsoft.VisualBasic.ChrW(9), "Andorra" & Global.Microsoft.VisualBasic.ChrW(9), "Angola" & Global.Microsoft.VisualBasic.ChrW(9), "Antigua y Barbuda" & Global.Microsoft.VisualBasic.ChrW(9), "Arabia Saudita" & Global.Microsoft.VisualBasic.ChrW(9), "Argelia" & Global.Microsoft.VisualBasic.ChrW(9), "Argentina", "Armenia" & Global.Microsoft.VisualBasic.ChrW(9), "Australia" & Global.Microsoft.VisualBasic.ChrW(9), "Austria", "Azerbaiyán" & Global.Microsoft.VisualBasic.ChrW(9), "Bahamas" & Global.Microsoft.VisualBasic.ChrW(9), "Bangladés" & Global.Microsoft.VisualBasic.ChrW(9), "Barbados" & Global.Microsoft.VisualBasic.ChrW(9), "Baréin" & Global.Microsoft.VisualBasic.ChrW(9), "Bélgica" & Global.Microsoft.VisualBasic.ChrW(9), "Belice" & Global.Microsoft.VisualBasic.ChrW(9), "Benín" & Global.Microsoft.VisualBasic.ChrW(9), "Bielorrusia" & Global.Microsoft.VisualBasic.ChrW(9), "Birmania" & Global.Microsoft.VisualBasic.ChrW(9), "Bolivia" & Global.Microsoft.VisualBasic.ChrW(9), "Bosnia-Herzegovina" & Global.Microsoft.VisualBasic.ChrW(9), "Botsuana" & Global.Microsoft.VisualBasic.ChrW(9), "Brasil" & Global.Microsoft.VisualBasic.ChrW(9), "Brunéi" & Global.Microsoft.VisualBasic.ChrW(9), "Bulgaria" & Global.Microsoft.VisualBasic.ChrW(9), "Burkina Faso" & Global.Microsoft.VisualBasic.ChrW(9), "Burundi" & Global.Microsoft.VisualBasic.ChrW(9), "Bután" & Global.Microsoft.VisualBasic.ChrW(9), "Cabo Verde" & Global.Microsoft.VisualBasic.ChrW(9), "Camboya" & Global.Microsoft.VisualBasic.ChrW(9), "Camerún" & Global.Microsoft.VisualBasic.ChrW(9), "Canadá" & Global.Microsoft.VisualBasic.ChrW(9), "Catar" & Global.Microsoft.VisualBasic.ChrW(9), "Chad" & Global.Microsoft.VisualBasic.ChrW(9), "Chile" & Global.Microsoft.VisualBasic.ChrW(9), "China" & Global.Microsoft.VisualBasic.ChrW(9), "Chipre" & Global.Microsoft.VisualBasic.ChrW(9), "Colombia" & Global.Microsoft.VisualBasic.ChrW(9), "Comoras" & Global.Microsoft.VisualBasic.ChrW(9), "Congo" & Global.Microsoft.VisualBasic.ChrW(9), "Corea del Norte" & Global.Microsoft.VisualBasic.ChrW(9), "Corea del Sur" & Global.Microsoft.VisualBasic.ChrW(9), "Costa de Marfil" & Global.Microsoft.VisualBasic.ChrW(9), "Costa Rica", "Croacia" & Global.Microsoft.VisualBasic.ChrW(9), "Cuba" & Global.Microsoft.VisualBasic.ChrW(9), "Dinamarca" & Global.Microsoft.VisualBasic.ChrW(9), "Dominica" & Global.Microsoft.VisualBasic.ChrW(9), "Ecuador" & Global.Microsoft.VisualBasic.ChrW(9), "Egipto" & Global.Microsoft.VisualBasic.ChrW(9), "El Salvador" & Global.Microsoft.VisualBasic.ChrW(9), "Emiratos Árabes Unidos" & Global.Microsoft.VisualBasic.ChrW(9), "Eritrea" & Global.Microsoft.VisualBasic.ChrW(9), "Eslovaquia", "Eslovenia" & Global.Microsoft.VisualBasic.ChrW(9), "España", "Estados Unidos" & Global.Microsoft.VisualBasic.ChrW(9), "Estonia" & Global.Microsoft.VisualBasic.ChrW(9), "Etiopía" & Global.Microsoft.VisualBasic.ChrW(9), "Filipinas" & Global.Microsoft.VisualBasic.ChrW(9), "Finlandia" & Global.Microsoft.VisualBasic.ChrW(9), "Fiyi" & Global.Microsoft.VisualBasic.ChrW(9), "Francia", "Gabón" & Global.Microsoft.VisualBasic.ChrW(9), "Gambia", "Georgia" & Global.Microsoft.VisualBasic.ChrW(9), "Ghana" & Global.Microsoft.VisualBasic.ChrW(9), "Granada", "Grecia" & Global.Microsoft.VisualBasic.ChrW(9), "Guatemala" & Global.Microsoft.VisualBasic.ChrW(9), "Guinea" & Global.Microsoft.VisualBasic.ChrW(9), "Guinea Ecuatorial" & Global.Microsoft.VisualBasic.ChrW(9), "Guinea-Bisáu" & Global.Microsoft.VisualBasic.ChrW(9), "Guyana", "Haití" & Global.Microsoft.VisualBasic.ChrW(9), "Honduras" & Global.Microsoft.VisualBasic.ChrW(9), "Hungría" & Global.Microsoft.VisualBasic.ChrW(9), "India" & Global.Microsoft.VisualBasic.ChrW(9), "Indonesia" & Global.Microsoft.VisualBasic.ChrW(9), "Irak" & Global.Microsoft.VisualBasic.ChrW(9), "Irán" & Global.Microsoft.VisualBasic.ChrW(9), "Irlanda" & Global.Microsoft.VisualBasic.ChrW(9), "Islandia" & Global.Microsoft.VisualBasic.ChrW(9), "Islas Marshall" & Global.Microsoft.VisualBasic.ChrW(9), "Islas Salomón" & Global.Microsoft.VisualBasic.ChrW(9), "Israel" & Global.Microsoft.VisualBasic.ChrW(9), "Italia" & Global.Microsoft.VisualBasic.ChrW(9), "Jamaica" & Global.Microsoft.VisualBasic.ChrW(9), "Japón" & Global.Microsoft.VisualBasic.ChrW(9), "Jordania" & Global.Microsoft.VisualBasic.ChrW(9), "Kazajistán", "Kenia" & Global.Microsoft.VisualBasic.ChrW(9), "Kirguistán" & Global.Microsoft.VisualBasic.ChrW(9), "Kiribati" & Global.Microsoft.VisualBasic.ChrW(9), "Kosovo" & Global.Microsoft.VisualBasic.ChrW(9), "Kuwait" & Global.Microsoft.VisualBasic.ChrW(9), "Laos" & Global.Microsoft.VisualBasic.ChrW(9), "Lesoto" & Global.Microsoft.VisualBasic.ChrW(9), "Letonia" & Global.Microsoft.VisualBasic.ChrW(9), "Líbano", "Liberia" & Global.Microsoft.VisualBasic.ChrW(9), "Libia" & Global.Microsoft.VisualBasic.ChrW(9), "Liechtenstein" & Global.Microsoft.VisualBasic.ChrW(9), "Lituania" & Global.Microsoft.VisualBasic.ChrW(9), "Luxemburgo" & Global.Microsoft.VisualBasic.ChrW(9), "Macedonia" & Global.Microsoft.VisualBasic.ChrW(9), "Madagascar" & Global.Microsoft.VisualBasic.ChrW(9), "Malasia" & Global.Microsoft.VisualBasic.ChrW(9), "Malaui" & Global.Microsoft.VisualBasic.ChrW(9), "Maldivas" & Global.Microsoft.VisualBasic.ChrW(9), "Malí" & Global.Microsoft.VisualBasic.ChrW(9), "Malta" & Global.Microsoft.VisualBasic.ChrW(9), "Marruecos", "Mauricio", "Mauritania" & Global.Microsoft.VisualBasic.ChrW(9), "México" & Global.Microsoft.VisualBasic.ChrW(9), "Micronesia" & Global.Microsoft.VisualBasic.ChrW(9), "Moldavia" & Global.Microsoft.VisualBasic.ChrW(9), "Mónaco" & Global.Microsoft.VisualBasic.ChrW(9), "Mongolia" & Global.Microsoft.VisualBasic.ChrW(9), "Montenegro" & Global.Microsoft.VisualBasic.ChrW(9), "Mozambique" & Global.Microsoft.VisualBasic.ChrW(9), "Namibia", "Nauru" & Global.Microsoft.VisualBasic.ChrW(9), "Nepal" & Global.Microsoft.VisualBasic.ChrW(9), "Nicaragua", "Níger" & Global.Microsoft.VisualBasic.ChrW(9), "Nigeria" & Global.Microsoft.VisualBasic.ChrW(9), "Noruega" & Global.Microsoft.VisualBasic.ChrW(9), "Nueva Zelanda" & Global.Microsoft.VisualBasic.ChrW(9), "Omán", "Países Bajos" & Global.Microsoft.VisualBasic.ChrW(9), "Pakistán" & Global.Microsoft.VisualBasic.ChrW(9), "Palaos" & Global.Microsoft.VisualBasic.ChrW(9), "Palestina" & Global.Microsoft.VisualBasic.ChrW(9), "Panamá" & Global.Microsoft.VisualBasic.ChrW(9), "Papúa Nueva Guinea" & Global.Microsoft.VisualBasic.ChrW(9), "Paraguay" & Global.Microsoft.VisualBasic.ChrW(9), "Perú" & Global.Microsoft.VisualBasic.ChrW(9), "Polonia", "Portugal" & Global.Microsoft.VisualBasic.ChrW(9), "Reino Unido" & Global.Microsoft.VisualBasic.ChrW(9), "República Centroafricana", "República Checa", "República Democrática del Congo", "República Dominicana", "Ruanda", "Rumania", "Rusia" & Global.Microsoft.VisualBasic.ChrW(9), "Samoa" & Global.Microsoft.VisualBasic.ChrW(9), "San Cristóbal y Nieves", "San Marino" & Global.Microsoft.VisualBasic.ChrW(9), "San Vicente y las Granadinas" & Global.Microsoft.VisualBasic.ChrW(9), "Santa Lucía" & Global.Microsoft.VisualBasic.ChrW(9), "Santo Tomé y Príncipe", "Senegal" & Global.Microsoft.VisualBasic.ChrW(9), "Serbia" & Global.Microsoft.VisualBasic.ChrW(9), "Seychelles" & Global.Microsoft.VisualBasic.ChrW(9), "Sierra Leona" & Global.Microsoft.VisualBasic.ChrW(9), "Singapur" & Global.Microsoft.VisualBasic.ChrW(9), "Siria" & Global.Microsoft.VisualBasic.ChrW(9), "Somalia" & Global.Microsoft.VisualBasic.ChrW(9), "Sri Lanka" & Global.Microsoft.VisualBasic.ChrW(9), "Suazilandia" & Global.Microsoft.VisualBasic.ChrW(9), "Sudáfrica" & Global.Microsoft.VisualBasic.ChrW(9), "Sudán" & Global.Microsoft.VisualBasic.ChrW(9), "Sudán del Sur" & Global.Microsoft.VisualBasic.ChrW(9), "Suecia" & Global.Microsoft.VisualBasic.ChrW(9), "Suiza" & Global.Microsoft.VisualBasic.ChrW(9), "Surinam" & Global.Microsoft.VisualBasic.ChrW(9), "Tailandia", "Taiwán" & Global.Microsoft.VisualBasic.ChrW(9), "Tanzania" & Global.Microsoft.VisualBasic.ChrW(9), "Tayikistán" & Global.Microsoft.VisualBasic.ChrW(9), "Timor Oriental" & Global.Microsoft.VisualBasic.ChrW(9), "Togo" & Global.Microsoft.VisualBasic.ChrW(9), "Tonga" & Global.Microsoft.VisualBasic.ChrW(9), "Trinidad y Tobago", "Túnez" & Global.Microsoft.VisualBasic.ChrW(9), "Turkmenistán", "Turquía" & Global.Microsoft.VisualBasic.ChrW(9), "Tuvalu" & Global.Microsoft.VisualBasic.ChrW(9), "Ucrania" & Global.Microsoft.VisualBasic.ChrW(9), "Uganda" & Global.Microsoft.VisualBasic.ChrW(9), "Uruguay", "Uzbekistán", "Vanuatu", "Vaticano" & Global.Microsoft.VisualBasic.ChrW(9), "Venezuela" & Global.Microsoft.VisualBasic.ChrW(9), "Vietnam" & Global.Microsoft.VisualBasic.ChrW(9), "Yemen" & Global.Microsoft.VisualBasic.ChrW(9), "Yibuti" & Global.Microsoft.VisualBasic.ChrW(9), "Zambia" & Global.Microsoft.VisualBasic.ChrW(9), "Zimbabue" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.cboPaisDoc.Location = New System.Drawing.Point(9, 33)
        Me.cboPaisDoc.Name = "cboPaisDoc"
        Me.cboPaisDoc.Size = New System.Drawing.Size(129, 21)
        Me.cboPaisDoc.TabIndex = 5
        '
        'txtNroDoc
        '
        Me.txtNroDoc.Location = New System.Drawing.Point(221, 34)
        Me.txtNroDoc.Name = "txtNroDoc"
        Me.txtNroDoc.Size = New System.Drawing.Size(129, 20)
        Me.txtNroDoc.TabIndex = 7
        '
        'cboTipoDoc
        '
        Me.cboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDoc.FormattingEnabled = True
        Me.cboTipoDoc.Items.AddRange(New Object() {"CI", "Pasaporte", "Otros"})
        Me.cboTipoDoc.Location = New System.Drawing.Point(144, 33)
        Me.cboTipoDoc.Name = "cboTipoDoc"
        Me.cboTipoDoc.Size = New System.Drawing.Size(71, 21)
        Me.cboTipoDoc.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "País"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(141, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Tipo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(218, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Número"
        '
        'dgvCuentas
        '
        Me.dgvCuentas.AllowUserToAddRows = False
        Me.dgvCuentas.AllowUserToDeleteRows = False
        Me.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numCuenta, Me.saldoCuenta, Me.ultTransaccion})
        Me.dgvCuentas.Location = New System.Drawing.Point(12, 194)
        Me.dgvCuentas.Name = "dgvCuentas"
        Me.dgvCuentas.ReadOnly = True
        Me.dgvCuentas.Size = New System.Drawing.Size(375, 208)
        Me.dgvCuentas.TabIndex = 86
        '
        'numCuenta
        '
        Me.numCuenta.HeaderText = "Numero"
        Me.numCuenta.Name = "numCuenta"
        Me.numCuenta.ReadOnly = True
        '
        'saldoCuenta
        '
        Me.saldoCuenta.HeaderText = "Saldo"
        Me.saldoCuenta.Name = "saldoCuenta"
        Me.saldoCuenta.ReadOnly = True
        '
        'ultTransaccion
        '
        Me.ultTransaccion.HeaderText = "Última transacción"
        Me.ultTransaccion.Name = "ultTransaccion"
        Me.ultTransaccion.ReadOnly = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(298, 152)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(91, 23)
        Me.btnBuscar.TabIndex = 87
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.tabPersona)
        Me.TabControl.Controls.Add(Me.tabEmpresa)
        Me.TabControl.Location = New System.Drawing.Point(12, 42)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(381, 108)
        Me.TabControl.TabIndex = 88
        '
        'tabPersona
        '
        Me.tabPersona.Controls.Add(Me.GroupBox2)
        Me.tabPersona.Location = New System.Drawing.Point(4, 22)
        Me.tabPersona.Name = "tabPersona"
        Me.tabPersona.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPersona.Size = New System.Drawing.Size(373, 82)
        Me.tabPersona.TabIndex = 0
        Me.tabPersona.Text = "Personas"
        Me.tabPersona.UseVisualStyleBackColor = True
        '
        'tabEmpresa
        '
        Me.tabEmpresa.Controls.Add(Me.GroupBox1)
        Me.tabEmpresa.Location = New System.Drawing.Point(4, 22)
        Me.tabEmpresa.Name = "tabEmpresa"
        Me.tabEmpresa.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEmpresa.Size = New System.Drawing.Size(373, 82)
        Me.tabEmpresa.TabIndex = 1
        Me.tabEmpresa.Text = "Empresas"
        Me.tabEmpresa.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtRUT)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 67)
        Me.GroupBox1.TabIndex = 86
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Documento"
        '
        'txtRUT
        '
        Me.txtRUT.Location = New System.Drawing.Point(9, 31)
        Me.txtRUT.Name = "txtRUT"
        Me.txtRUT.Size = New System.Drawing.Size(345, 20)
        Me.txtRUT.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(6, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "RUT"
        '
        'ComboBox1
        '
        Me.ComboBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Afganistán", "Albania" & Global.Microsoft.VisualBasic.ChrW(9), "Alemania" & Global.Microsoft.VisualBasic.ChrW(9), "Andorra" & Global.Microsoft.VisualBasic.ChrW(9), "Angola" & Global.Microsoft.VisualBasic.ChrW(9), "Antigua y Barbuda" & Global.Microsoft.VisualBasic.ChrW(9), "Arabia Saudita" & Global.Microsoft.VisualBasic.ChrW(9), "Argelia" & Global.Microsoft.VisualBasic.ChrW(9), "Argentina", "Armenia" & Global.Microsoft.VisualBasic.ChrW(9), "Australia" & Global.Microsoft.VisualBasic.ChrW(9), "Austria", "Azerbaiyán" & Global.Microsoft.VisualBasic.ChrW(9), "Bahamas" & Global.Microsoft.VisualBasic.ChrW(9), "Bangladés" & Global.Microsoft.VisualBasic.ChrW(9), "Barbados" & Global.Microsoft.VisualBasic.ChrW(9), "Baréin" & Global.Microsoft.VisualBasic.ChrW(9), "Bélgica" & Global.Microsoft.VisualBasic.ChrW(9), "Belice" & Global.Microsoft.VisualBasic.ChrW(9), "Benín" & Global.Microsoft.VisualBasic.ChrW(9), "Bielorrusia" & Global.Microsoft.VisualBasic.ChrW(9), "Birmania" & Global.Microsoft.VisualBasic.ChrW(9), "Bolivia" & Global.Microsoft.VisualBasic.ChrW(9), "Bosnia-Herzegovina" & Global.Microsoft.VisualBasic.ChrW(9), "Botsuana" & Global.Microsoft.VisualBasic.ChrW(9), "Brasil" & Global.Microsoft.VisualBasic.ChrW(9), "Brunéi" & Global.Microsoft.VisualBasic.ChrW(9), "Bulgaria" & Global.Microsoft.VisualBasic.ChrW(9), "Burkina Faso" & Global.Microsoft.VisualBasic.ChrW(9), "Burundi" & Global.Microsoft.VisualBasic.ChrW(9), "Bután" & Global.Microsoft.VisualBasic.ChrW(9), "Cabo Verde" & Global.Microsoft.VisualBasic.ChrW(9), "Camboya" & Global.Microsoft.VisualBasic.ChrW(9), "Camerún" & Global.Microsoft.VisualBasic.ChrW(9), "Canadá" & Global.Microsoft.VisualBasic.ChrW(9), "Catar" & Global.Microsoft.VisualBasic.ChrW(9), "Chad" & Global.Microsoft.VisualBasic.ChrW(9), "Chile" & Global.Microsoft.VisualBasic.ChrW(9), "China" & Global.Microsoft.VisualBasic.ChrW(9), "Chipre" & Global.Microsoft.VisualBasic.ChrW(9), "Colombia" & Global.Microsoft.VisualBasic.ChrW(9), "Comoras" & Global.Microsoft.VisualBasic.ChrW(9), "Congo" & Global.Microsoft.VisualBasic.ChrW(9), "Corea del Norte" & Global.Microsoft.VisualBasic.ChrW(9), "Corea del Sur" & Global.Microsoft.VisualBasic.ChrW(9), "Costa de Marfil" & Global.Microsoft.VisualBasic.ChrW(9), "Costa Rica", "Croacia" & Global.Microsoft.VisualBasic.ChrW(9), "Cuba" & Global.Microsoft.VisualBasic.ChrW(9), "Dinamarca" & Global.Microsoft.VisualBasic.ChrW(9), "Dominica" & Global.Microsoft.VisualBasic.ChrW(9), "Ecuador" & Global.Microsoft.VisualBasic.ChrW(9), "Egipto" & Global.Microsoft.VisualBasic.ChrW(9), "El Salvador" & Global.Microsoft.VisualBasic.ChrW(9), "Emiratos Árabes Unidos" & Global.Microsoft.VisualBasic.ChrW(9), "Eritrea" & Global.Microsoft.VisualBasic.ChrW(9), "Eslovaquia", "Eslovenia" & Global.Microsoft.VisualBasic.ChrW(9), "España", "Estados Unidos" & Global.Microsoft.VisualBasic.ChrW(9), "Estonia" & Global.Microsoft.VisualBasic.ChrW(9), "Etiopía" & Global.Microsoft.VisualBasic.ChrW(9), "Filipinas" & Global.Microsoft.VisualBasic.ChrW(9), "Finlandia" & Global.Microsoft.VisualBasic.ChrW(9), "Fiyi" & Global.Microsoft.VisualBasic.ChrW(9), "Francia", "Gabón" & Global.Microsoft.VisualBasic.ChrW(9), "Gambia", "Georgia" & Global.Microsoft.VisualBasic.ChrW(9), "Ghana" & Global.Microsoft.VisualBasic.ChrW(9), "Granada", "Grecia" & Global.Microsoft.VisualBasic.ChrW(9), "Guatemala" & Global.Microsoft.VisualBasic.ChrW(9), "Guinea" & Global.Microsoft.VisualBasic.ChrW(9), "Guinea Ecuatorial" & Global.Microsoft.VisualBasic.ChrW(9), "Guinea-Bisáu" & Global.Microsoft.VisualBasic.ChrW(9), "Guyana", "Haití" & Global.Microsoft.VisualBasic.ChrW(9), "Honduras" & Global.Microsoft.VisualBasic.ChrW(9), "Hungría" & Global.Microsoft.VisualBasic.ChrW(9), "India" & Global.Microsoft.VisualBasic.ChrW(9), "Indonesia" & Global.Microsoft.VisualBasic.ChrW(9), "Irak" & Global.Microsoft.VisualBasic.ChrW(9), "Irán" & Global.Microsoft.VisualBasic.ChrW(9), "Irlanda" & Global.Microsoft.VisualBasic.ChrW(9), "Islandia" & Global.Microsoft.VisualBasic.ChrW(9), "Islas Marshall" & Global.Microsoft.VisualBasic.ChrW(9), "Islas Salomón" & Global.Microsoft.VisualBasic.ChrW(9), "Israel" & Global.Microsoft.VisualBasic.ChrW(9), "Italia" & Global.Microsoft.VisualBasic.ChrW(9), "Jamaica" & Global.Microsoft.VisualBasic.ChrW(9), "Japón" & Global.Microsoft.VisualBasic.ChrW(9), "Jordania" & Global.Microsoft.VisualBasic.ChrW(9), "Kazajistán", "Kenia" & Global.Microsoft.VisualBasic.ChrW(9), "Kirguistán" & Global.Microsoft.VisualBasic.ChrW(9), "Kiribati" & Global.Microsoft.VisualBasic.ChrW(9), "Kosovo" & Global.Microsoft.VisualBasic.ChrW(9), "Kuwait" & Global.Microsoft.VisualBasic.ChrW(9), "Laos" & Global.Microsoft.VisualBasic.ChrW(9), "Lesoto" & Global.Microsoft.VisualBasic.ChrW(9), "Letonia" & Global.Microsoft.VisualBasic.ChrW(9), "Líbano", "Liberia" & Global.Microsoft.VisualBasic.ChrW(9), "Libia" & Global.Microsoft.VisualBasic.ChrW(9), "Liechtenstein" & Global.Microsoft.VisualBasic.ChrW(9), "Lituania" & Global.Microsoft.VisualBasic.ChrW(9), "Luxemburgo" & Global.Microsoft.VisualBasic.ChrW(9), "Macedonia" & Global.Microsoft.VisualBasic.ChrW(9), "Madagascar" & Global.Microsoft.VisualBasic.ChrW(9), "Malasia" & Global.Microsoft.VisualBasic.ChrW(9), "Malaui" & Global.Microsoft.VisualBasic.ChrW(9), "Maldivas" & Global.Microsoft.VisualBasic.ChrW(9), "Malí" & Global.Microsoft.VisualBasic.ChrW(9), "Malta" & Global.Microsoft.VisualBasic.ChrW(9), "Marruecos", "Mauricio", "Mauritania" & Global.Microsoft.VisualBasic.ChrW(9), "México" & Global.Microsoft.VisualBasic.ChrW(9), "Micronesia" & Global.Microsoft.VisualBasic.ChrW(9), "Moldavia" & Global.Microsoft.VisualBasic.ChrW(9), "Mónaco" & Global.Microsoft.VisualBasic.ChrW(9), "Mongolia" & Global.Microsoft.VisualBasic.ChrW(9), "Montenegro" & Global.Microsoft.VisualBasic.ChrW(9), "Mozambique" & Global.Microsoft.VisualBasic.ChrW(9), "Namibia", "Nauru" & Global.Microsoft.VisualBasic.ChrW(9), "Nepal" & Global.Microsoft.VisualBasic.ChrW(9), "Nicaragua", "Níger" & Global.Microsoft.VisualBasic.ChrW(9), "Nigeria" & Global.Microsoft.VisualBasic.ChrW(9), "Noruega" & Global.Microsoft.VisualBasic.ChrW(9), "Nueva Zelanda" & Global.Microsoft.VisualBasic.ChrW(9), "Omán", "Países Bajos" & Global.Microsoft.VisualBasic.ChrW(9), "Pakistán" & Global.Microsoft.VisualBasic.ChrW(9), "Palaos" & Global.Microsoft.VisualBasic.ChrW(9), "Palestina" & Global.Microsoft.VisualBasic.ChrW(9), "Panamá" & Global.Microsoft.VisualBasic.ChrW(9), "Papúa Nueva Guinea" & Global.Microsoft.VisualBasic.ChrW(9), "Paraguay" & Global.Microsoft.VisualBasic.ChrW(9), "Perú" & Global.Microsoft.VisualBasic.ChrW(9), "Polonia", "Portugal" & Global.Microsoft.VisualBasic.ChrW(9), "Reino Unido" & Global.Microsoft.VisualBasic.ChrW(9), "República Centroafricana", "República Checa", "República Democrática del Congo", "República Dominicana", "Ruanda", "Rumania", "Rusia" & Global.Microsoft.VisualBasic.ChrW(9), "Samoa" & Global.Microsoft.VisualBasic.ChrW(9), "San Cristóbal y Nieves", "San Marino" & Global.Microsoft.VisualBasic.ChrW(9), "San Vicente y las Granadinas" & Global.Microsoft.VisualBasic.ChrW(9), "Santa Lucía" & Global.Microsoft.VisualBasic.ChrW(9), "Santo Tomé y Príncipe", "Senegal" & Global.Microsoft.VisualBasic.ChrW(9), "Serbia" & Global.Microsoft.VisualBasic.ChrW(9), "Seychelles" & Global.Microsoft.VisualBasic.ChrW(9), "Sierra Leona" & Global.Microsoft.VisualBasic.ChrW(9), "Singapur" & Global.Microsoft.VisualBasic.ChrW(9), "Siria" & Global.Microsoft.VisualBasic.ChrW(9), "Somalia" & Global.Microsoft.VisualBasic.ChrW(9), "Sri Lanka" & Global.Microsoft.VisualBasic.ChrW(9), "Suazilandia" & Global.Microsoft.VisualBasic.ChrW(9), "Sudáfrica" & Global.Microsoft.VisualBasic.ChrW(9), "Sudán" & Global.Microsoft.VisualBasic.ChrW(9), "Sudán del Sur" & Global.Microsoft.VisualBasic.ChrW(9), "Suecia" & Global.Microsoft.VisualBasic.ChrW(9), "Suiza" & Global.Microsoft.VisualBasic.ChrW(9), "Surinam" & Global.Microsoft.VisualBasic.ChrW(9), "Tailandia", "Taiwán" & Global.Microsoft.VisualBasic.ChrW(9), "Tanzania" & Global.Microsoft.VisualBasic.ChrW(9), "Tayikistán" & Global.Microsoft.VisualBasic.ChrW(9), "Timor Oriental" & Global.Microsoft.VisualBasic.ChrW(9), "Togo" & Global.Microsoft.VisualBasic.ChrW(9), "Tonga" & Global.Microsoft.VisualBasic.ChrW(9), "Trinidad y Tobago", "Túnez" & Global.Microsoft.VisualBasic.ChrW(9), "Turkmenistán", "Turquía" & Global.Microsoft.VisualBasic.ChrW(9), "Tuvalu" & Global.Microsoft.VisualBasic.ChrW(9), "Ucrania" & Global.Microsoft.VisualBasic.ChrW(9), "Uganda" & Global.Microsoft.VisualBasic.ChrW(9), "Uruguay", "Uzbekistán", "Vanuatu", "Vaticano" & Global.Microsoft.VisualBasic.ChrW(9), "Venezuela" & Global.Microsoft.VisualBasic.ChrW(9), "Vietnam" & Global.Microsoft.VisualBasic.ChrW(9), "Yemen" & Global.Microsoft.VisualBasic.ChrW(9), "Yibuti" & Global.Microsoft.VisualBasic.ChrW(9), "Zambia" & Global.Microsoft.VisualBasic.ChrW(9), "Zimbabue" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.ComboBox1.Location = New System.Drawing.Point(9, 33)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(129, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(221, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(129, 20)
        Me.TextBox1.TabIndex = 7
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"CI", "Pasaporte", "Otros"})
        Me.ComboBox2.Location = New System.Drawing.Point(144, 33)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(71, 21)
        Me.ComboBox2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "País"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(141, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Tipo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(218, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Número"
        '
        'lblMotivoAux
        '
        Me.lblMotivoAux.AutoSize = True
        Me.lblMotivoAux.Location = New System.Drawing.Point(12, 13)
        Me.lblMotivoAux.Name = "lblMotivoAux"
        Me.lblMotivoAux.Size = New System.Drawing.Size(120, 13)
        Me.lblMotivoAux.TabIndex = 89
        Me.lblMotivoAux.Text = "Seleccione una cuenta."
        '
        'frmBusquedaCuentaPorCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 414)
        Me.Controls.Add(Me.lblMotivoAux)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.dgvCuentas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBusquedaCuentaPorCliente"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar cuenta por cliente"
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
    Friend WithEvents cboPaisDoc As System.Windows.Forms.ComboBox
    Friend WithEvents txtNroDoc As System.Windows.Forms.TextBox
    Friend WithEvents cboTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgvCuentas As System.Windows.Forms.DataGridView
    Friend WithEvents numCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents saldoCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ultTransaccion As System.Windows.Forms.DataGridViewTextBoxColumn
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

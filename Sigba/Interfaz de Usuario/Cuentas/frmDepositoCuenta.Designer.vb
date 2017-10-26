<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepositoCuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDepositoCuenta))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCuentaBeneficiario = New System.Windows.Forms.TextBox
        Me.btnBuscarCuenta = New System.Windows.Forms.Button
        Me.txtMontoCantidad = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboMonto = New System.Windows.Forms.ComboBox
        Me.btnConfirmar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
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
        'txtCuentaBeneficiario
        '
        Me.txtCuentaBeneficiario.AccessibleDescription = Nothing
        Me.txtCuentaBeneficiario.AccessibleName = Nothing
        resources.ApplyResources(Me.txtCuentaBeneficiario, "txtCuentaBeneficiario")
        Me.txtCuentaBeneficiario.BackgroundImage = Nothing
        Me.txtCuentaBeneficiario.Font = Nothing
        Me.txtCuentaBeneficiario.Name = "txtCuentaBeneficiario"
        '
        'btnBuscarCuenta
        '
        Me.btnBuscarCuenta.AccessibleDescription = Nothing
        Me.btnBuscarCuenta.AccessibleName = Nothing
        resources.ApplyResources(Me.btnBuscarCuenta, "btnBuscarCuenta")
        Me.btnBuscarCuenta.BackgroundImage = Nothing
        Me.btnBuscarCuenta.Font = Nothing
        Me.btnBuscarCuenta.Name = "btnBuscarCuenta"
        Me.btnBuscarCuenta.UseVisualStyleBackColor = True
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
        'Label2
        '
        Me.Label2.AccessibleDescription = Nothing
        Me.Label2.AccessibleName = Nothing
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Font = Nothing
        Me.Label2.Name = "Label2"
        '
        'cboMonto
        '
        Me.cboMonto.AccessibleDescription = Nothing
        Me.cboMonto.AccessibleName = Nothing
        resources.ApplyResources(Me.cboMonto, "cboMonto")
        Me.cboMonto.BackgroundImage = Nothing
        Me.cboMonto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonto.Font = Nothing
        Me.cboMonto.FormattingEnabled = True
        Me.cboMonto.Items.AddRange(New Object() {resources.GetString("cboMonto.Items"), resources.GetString("cboMonto.Items1"), resources.GetString("cboMonto.Items2")})
        Me.cboMonto.Name = "cboMonto"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.AccessibleDescription = Nothing
        Me.btnConfirmar.AccessibleName = Nothing
        resources.ApplyResources(Me.btnConfirmar, "btnConfirmar")
        Me.btnConfirmar.BackgroundImage = Nothing
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
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
        'frmDepositoCuenta
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.cboMonto)
        Me.Controls.Add(Me.txtMontoCantidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBuscarCuenta)
        Me.Controls.Add(Me.txtCuentaBeneficiario)
        Me.Controls.Add(Me.Label1)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmDepositoCuenta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCuentaBeneficiario As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarCuenta As System.Windows.Forms.Button
    Friend WithEvents txtMontoCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboMonto As System.Windows.Forms.ComboBox
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class

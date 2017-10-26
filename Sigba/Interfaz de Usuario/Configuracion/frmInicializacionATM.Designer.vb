<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicializacionATM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicializacionATM))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNumCajero = New System.Windows.Forms.TextBox
        Me.txtDineroUYU = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDineroUSD = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCotizaciónUSD = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCotizacionEUR = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnContinuar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'txtNumCajero
        '
        resources.ApplyResources(Me.txtNumCajero, "txtNumCajero")
        Me.txtNumCajero.Name = "txtNumCajero"
        '
        'txtDineroUYU
        '
        resources.ApplyResources(Me.txtDineroUYU, "txtDineroUYU")
        Me.txtDineroUYU.Name = "txtDineroUYU"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'txtDineroUSD
        '
        resources.ApplyResources(Me.txtDineroUSD, "txtDineroUSD")
        Me.txtDineroUSD.Name = "txtDineroUSD"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'txtCotizaciónUSD
        '
        resources.ApplyResources(Me.txtCotizaciónUSD, "txtCotizaciónUSD")
        Me.txtCotizaciónUSD.Name = "txtCotizaciónUSD"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'txtCotizacionEUR
        '
        resources.ApplyResources(Me.txtCotizacionEUR, "txtCotizacionEUR")
        Me.txtCotizacionEUR.Name = "txtCotizacionEUR"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'btnContinuar
        '
        resources.ApplyResources(Me.btnContinuar, "btnContinuar")
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.UseVisualStyleBackColor = True
        '
        'frmInicializacionATM
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnContinuar)
        Me.Controls.Add(Me.txtCotizacionEUR)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCotizaciónUSD)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDineroUSD)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDineroUYU)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNumCajero)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInicializacionATM"
        Me.ShowIcon = False
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNumCajero As System.Windows.Forms.TextBox
    Friend WithEvents txtDineroUYU As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDineroUSD As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCotizaciónUSD As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCotizacionEUR As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnContinuar As System.Windows.Forms.Button
End Class

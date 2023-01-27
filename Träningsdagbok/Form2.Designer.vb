<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnlaggtill = New System.Windows.Forms.Button()
        Me.btnAndra = New System.Windows.Forms.Button()
        Me.btnradera = New System.Windows.Forms.Button()
        Me.btnAvbryt = New System.Windows.Forms.Button()
        Me.btnSpara = New System.Windows.Forms.Button()
        Me.cboAktivitet = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnlaggtill
        '
        Me.btnlaggtill.Location = New System.Drawing.Point(452, 192)
        Me.btnlaggtill.Name = "btnlaggtill"
        Me.btnlaggtill.Size = New System.Drawing.Size(77, 30)
        Me.btnlaggtill.TabIndex = 11
        Me.btnlaggtill.Text = "Lägg till"
        Me.btnlaggtill.UseVisualStyleBackColor = True
        '
        'btnAndra
        '
        Me.btnAndra.Location = New System.Drawing.Point(452, 228)
        Me.btnAndra.Name = "btnAndra"
        Me.btnAndra.Size = New System.Drawing.Size(77, 30)
        Me.btnAndra.TabIndex = 10
        Me.btnAndra.Text = "Ändra"
        Me.btnAndra.UseVisualStyleBackColor = True
        '
        'btnradera
        '
        Me.btnradera.Location = New System.Drawing.Point(452, 264)
        Me.btnradera.Name = "btnradera"
        Me.btnradera.Size = New System.Drawing.Size(77, 30)
        Me.btnradera.TabIndex = 9
        Me.btnradera.Text = "Ta bort"
        Me.btnradera.UseVisualStyleBackColor = True
        '
        'btnAvbryt
        '
        Me.btnAvbryt.Location = New System.Drawing.Point(354, 156)
        Me.btnAvbryt.Name = "btnAvbryt"
        Me.btnAvbryt.Size = New System.Drawing.Size(77, 30)
        Me.btnAvbryt.TabIndex = 8
        Me.btnAvbryt.Text = "Avbryt"
        Me.btnAvbryt.UseVisualStyleBackColor = True
        '
        'btnSpara
        '
        Me.btnSpara.Location = New System.Drawing.Point(271, 156)
        Me.btnSpara.Name = "btnSpara"
        Me.btnSpara.Size = New System.Drawing.Size(77, 30)
        Me.btnSpara.TabIndex = 7
        Me.btnSpara.Text = "Spara"
        Me.btnSpara.UseVisualStyleBackColor = True
        '
        'cboAktivitet
        '
        Me.cboAktivitet.FormattingEnabled = True
        Me.cboAktivitet.Location = New System.Drawing.Point(271, 192)
        Me.cboAktivitet.Name = "cboAktivitet"
        Me.cboAktivitet.Size = New System.Drawing.Size(151, 28)
        Me.cboAktivitet.TabIndex = 6
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnlaggtill)
        Me.Controls.Add(Me.btnAndra)
        Me.Controls.Add(Me.btnradera)
        Me.Controls.Add(Me.btnAvbryt)
        Me.Controls.Add(Me.btnSpara)
        Me.Controls.Add(Me.cboAktivitet)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnlaggtill As Button
    Friend WithEvents btnAndra As Button
    Friend WithEvents btnradera As Button
    Friend WithEvents btnAvbryt As Button
    Friend WithEvents btnSpara As Button
    Friend WithEvents cboAktivitet As ComboBox
End Class

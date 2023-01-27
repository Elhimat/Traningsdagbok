<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grdDetalj = New System.Windows.Forms.DataGridView()
        Me.tvwDagbok = New System.Windows.Forms.TreeView()
        Me.btnAktivitet = New System.Windows.Forms.Button()
        CType(Me.grdDetalj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdDetalj
        '
        Me.grdDetalj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDetalj.Location = New System.Drawing.Point(171, 0)
        Me.grdDetalj.Name = "grdDetalj"
        Me.grdDetalj.RowHeadersWidth = 51
        Me.grdDetalj.RowTemplate.Height = 29
        Me.grdDetalj.Size = New System.Drawing.Size(629, 325)
        Me.grdDetalj.TabIndex = 0
        '
        'tvwDagbok
        '
        Me.tvwDagbok.Location = New System.Drawing.Point(0, 0)
        Me.tvwDagbok.Name = "tvwDagbok"
        Me.tvwDagbok.Size = New System.Drawing.Size(165, 446)
        Me.tvwDagbok.TabIndex = 1
        '
        'btnAktivitet
        '
        Me.btnAktivitet.Location = New System.Drawing.Point(171, 349)
        Me.btnAktivitet.Name = "btnAktivitet"
        Me.btnAktivitet.Size = New System.Drawing.Size(138, 29)
        Me.btnAktivitet.TabIndex = 2
        Me.btnAktivitet.Text = "Lägg till aktivitet"
        Me.btnAktivitet.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAktivitet)
        Me.Controls.Add(Me.tvwDagbok)
        Me.Controls.Add(Me.grdDetalj)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.grdDetalj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdDetalj As DataGridView
    Friend WithEvents tvwDagbok As TreeView
    Friend WithEvents btnAktivitet As Button
End Class

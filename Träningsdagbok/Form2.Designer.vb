<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLista
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
        Me.lstAdresser = New System.Windows.Forms.ListView()
        Me.colid = New System.Windows.Forms.ColumnHeader()
        Me.colAktivitetID = New System.Windows.Forms.ColumnHeader()
        Me.colDatum = New System.Windows.Forms.ColumnHeader()
        Me.colTid = New System.Windows.Forms.ColumnHeader()
        Me.colDistans = New System.Windows.Forms.ColumnHeader()
        Me.colBeskrivning = New System.Windows.Forms.ColumnHeader()
        Me.SuspendLayout()
        '
        'lstAdresser
        '
        Me.lstAdresser.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colid, Me.colAktivitetID, Me.colDatum, Me.colTid, Me.colDistans, Me.colBeskrivning})
        Me.lstAdresser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstAdresser.FullRowSelect = True
        Me.lstAdresser.GridLines = True
        Me.lstAdresser.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstAdresser.Location = New System.Drawing.Point(0, 0)
        Me.lstAdresser.MinimumSize = New System.Drawing.Size(489, 360)
        Me.lstAdresser.MultiSelect = False
        Me.lstAdresser.Name = "lstAdresser"
        Me.lstAdresser.Size = New System.Drawing.Size(653, 549)
        Me.lstAdresser.TabIndex = 1
        Me.lstAdresser.UseCompatibleStateImageBehavior = False
        Me.lstAdresser.View = System.Windows.Forms.View.Details
        '
        'colid
        '
        Me.colid.Text = "ID"
        Me.colid.Width = 100
        '
        'colAktivitetID
        '
        Me.colAktivitetID.DisplayIndex = 5
        Me.colAktivitetID.Text = "AktivitetID"
        Me.colAktivitetID.Width = 100
        '
        'colDatum
        '
        Me.colDatum.DisplayIndex = 1
        Me.colDatum.Text = "Datum"
        Me.colDatum.Width = 120
        '
        'colTid
        '
        Me.colTid.DisplayIndex = 2
        Me.colTid.Text = "Tid"
        Me.colTid.Width = 120
        '
        'colDistans
        '
        Me.colDistans.DisplayIndex = 3
        Me.colDistans.Text = "Distans"
        Me.colDistans.Width = 100
        '
        'colBeskrivning
        '
        Me.colBeskrivning.DisplayIndex = 4
        Me.colBeskrivning.Text = "Beskrivning"
        Me.colBeskrivning.Width = 100
        '
        'frmLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 549)
        Me.Controls.Add(Me.lstAdresser)
        Me.Name = "frmLista"
        Me.Text = "frmLista"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstAdresser As ListView
    Friend WithEvents colAktivitetID As ColumnHeader
    Friend WithEvents colDatum As ColumnHeader
    Friend WithEvents colTid As ColumnHeader
    Friend WithEvents colDistans As ColumnHeader
    Friend WithEvents colBeskrivning As ColumnHeader
    Friend WithEvents colid As ColumnHeader
End Class

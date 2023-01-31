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
        Me.btnAngra = New System.Windows.Forms.Button()
        Me.btnRadera = New System.Windows.Forms.Button()
        Me.btnLista = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPost = New System.Windows.Forms.TextBox()
        Me.btnSista = New System.Windows.Forms.Button()
        Me.btnNasta = New System.Windows.Forms.Button()
        Me.btnForegaende = New System.Windows.Forms.Button()
        Me.btnForsta = New System.Windows.Forms.Button()
        Me.btnNyPost = New System.Windows.Forms.Button()
        Me.btnSpara = New System.Windows.Forms.Button()
        Me.txtOrt = New System.Windows.Forms.TextBox()
        Me.txtPostnr = New System.Windows.Forms.TextBox()
        Me.txtAdress = New System.Windows.Forms.TextBox()
        Me.txtEfternamn = New System.Windows.Forms.TextBox()
        Me.txtFornamn = New System.Windows.Forms.TextBox()
        Me.txtRpe = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAngra
        '
        Me.btnAngra.Location = New System.Drawing.Point(587, 291)
        Me.btnAngra.Name = "btnAngra"
        Me.btnAngra.Size = New System.Drawing.Size(94, 29)
        Me.btnAngra.TabIndex = 39
        Me.btnAngra.Text = "Ångra"
        Me.btnAngra.UseVisualStyleBackColor = True
        '
        'btnRadera
        '
        Me.btnRadera.Location = New System.Drawing.Point(587, 206)
        Me.btnRadera.Name = "btnRadera"
        Me.btnRadera.Size = New System.Drawing.Size(94, 29)
        Me.btnRadera.TabIndex = 38
        Me.btnRadera.Text = "Radera"
        Me.btnRadera.UseVisualStyleBackColor = True
        '
        'btnLista
        '
        Me.btnLista.Location = New System.Drawing.Point(587, 249)
        Me.btnLista.Name = "btnLista"
        Me.btnLista.Size = New System.Drawing.Size(94, 29)
        Me.btnLista.TabIndex = 37
        Me.btnLista.Text = "Visa lista"
        Me.btnLista.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(128, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 20)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Beskrivning"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(129, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Distans"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(129, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 20)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Tid"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(129, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Datum"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(360, 295)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "AktivitetID"
        '
        'txtPost
        '
        Me.txtPost.Location = New System.Drawing.Point(269, 377)
        Me.txtPost.MaxLength = 8
        Me.txtPost.Name = "txtPost"
        Me.txtPost.Size = New System.Drawing.Size(38, 27)
        Me.txtPost.TabIndex = 31
        '
        'btnSista
        '
        Me.btnSista.Location = New System.Drawing.Point(406, 375)
        Me.btnSista.Name = "btnSista"
        Me.btnSista.Size = New System.Drawing.Size(55, 29)
        Me.btnSista.TabIndex = 30
        Me.btnSista.Text = ">>"
        Me.btnSista.UseVisualStyleBackColor = True
        '
        'btnNasta
        '
        Me.btnNasta.Location = New System.Drawing.Point(331, 374)
        Me.btnNasta.Name = "btnNasta"
        Me.btnNasta.Size = New System.Drawing.Size(54, 29)
        Me.btnNasta.TabIndex = 29
        Me.btnNasta.Text = ">"
        Me.btnNasta.UseVisualStyleBackColor = True
        '
        'btnForegaende
        '
        Me.btnForegaende.Location = New System.Drawing.Point(192, 375)
        Me.btnForegaende.Name = "btnForegaende"
        Me.btnForegaende.Size = New System.Drawing.Size(55, 29)
        Me.btnForegaende.TabIndex = 28
        Me.btnForegaende.Text = "<"
        Me.btnForegaende.UseVisualStyleBackColor = True
        '
        'btnForsta
        '
        Me.btnForsta.Location = New System.Drawing.Point(120, 375)
        Me.btnForsta.Name = "btnForsta"
        Me.btnForsta.Size = New System.Drawing.Size(57, 29)
        Me.btnForsta.TabIndex = 27
        Me.btnForsta.Text = "<<"
        Me.btnForsta.UseVisualStyleBackColor = True
        '
        'btnNyPost
        '
        Me.btnNyPost.Location = New System.Drawing.Point(587, 167)
        Me.btnNyPost.Name = "btnNyPost"
        Me.btnNyPost.Size = New System.Drawing.Size(94, 29)
        Me.btnNyPost.TabIndex = 26
        Me.btnNyPost.Text = "Ny post"
        Me.btnNyPost.UseVisualStyleBackColor = True
        '
        'btnSpara
        '
        Me.btnSpara.Location = New System.Drawing.Point(587, 109)
        Me.btnSpara.Name = "btnSpara"
        Me.btnSpara.Size = New System.Drawing.Size(94, 29)
        Me.btnSpara.TabIndex = 25
        Me.btnSpara.Text = "Spara"
        Me.btnSpara.UseVisualStyleBackColor = True
        '
        'txtOrt
        '
        Me.txtOrt.Location = New System.Drawing.Point(129, 64)
        Me.txtOrt.Name = "txtOrt"
        Me.txtOrt.Size = New System.Drawing.Size(209, 27)
        Me.txtOrt.TabIndex = 24
        '
        'txtPostnr
        '
        Me.txtPostnr.Location = New System.Drawing.Point(129, 323)
        Me.txtPostnr.Name = "txtPostnr"
        Me.txtPostnr.Size = New System.Drawing.Size(157, 27)
        Me.txtPostnr.TabIndex = 23
        '
        'txtAdress
        '
        Me.txtAdress.Location = New System.Drawing.Point(129, 249)
        Me.txtAdress.Name = "txtAdress"
        Me.txtAdress.Size = New System.Drawing.Size(310, 27)
        Me.txtAdress.TabIndex = 22
        '
        'txtEfternamn
        '
        Me.txtEfternamn.Location = New System.Drawing.Point(129, 169)
        Me.txtEfternamn.Name = "txtEfternamn"
        Me.txtEfternamn.Size = New System.Drawing.Size(310, 27)
        Me.txtEfternamn.TabIndex = 21
        '
        'txtFornamn
        '
        Me.txtFornamn.Location = New System.Drawing.Point(360, 323)
        Me.txtFornamn.Name = "txtFornamn"
        Me.txtFornamn.Size = New System.Drawing.Size(79, 27)
        Me.txtFornamn.TabIndex = 20
        '
        'txtRpe
        '
        Me.txtRpe.Location = New System.Drawing.Point(454, 323)
        Me.txtRpe.Name = "txtRpe"
        Me.txtRpe.Size = New System.Drawing.Size(86, 27)
        Me.txtRpe.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(454, 295)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 20)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Rpe"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtRpe)
        Me.Controls.Add(Me.btnAngra)
        Me.Controls.Add(Me.btnRadera)
        Me.Controls.Add(Me.btnLista)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPost)
        Me.Controls.Add(Me.btnSista)
        Me.Controls.Add(Me.btnNasta)
        Me.Controls.Add(Me.btnForegaende)
        Me.Controls.Add(Me.btnForsta)
        Me.Controls.Add(Me.btnNyPost)
        Me.Controls.Add(Me.btnSpara)
        Me.Controls.Add(Me.txtOrt)
        Me.Controls.Add(Me.txtPostnr)
        Me.Controls.Add(Me.txtAdress)
        Me.Controls.Add(Me.txtEfternamn)
        Me.Controls.Add(Me.txtFornamn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAngra As Button
    Friend WithEvents btnRadera As Button
    Friend WithEvents btnLista As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPost As TextBox
    Friend WithEvents btnSista As Button
    Friend WithEvents btnNasta As Button
    Friend WithEvents btnForegaende As Button
    Friend WithEvents btnForsta As Button
    Friend WithEvents btnNyPost As Button
    Friend WithEvents btnSpara As Button
    Friend WithEvents txtOrt As TextBox
    Friend WithEvents txtPostnr As TextBox
    Friend WithEvents txtAdress As TextBox
    Friend WithEvents txtEfternamn As TextBox
    Friend WithEvents txtFornamn As TextBox
    Friend WithEvents txtRpe As TextBox
    Friend WithEvents Label6 As Label
End Class

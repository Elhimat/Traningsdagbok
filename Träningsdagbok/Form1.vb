Imports System.Data.OleDb
Public Class Form1
    Private antalPoster As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Koppla mot databasen
        dbConnect()

        antalPoster = dsDagbok.Tables("Dagbok").Rows.Count

        ' Fyll formuläret med första posten
        fyllFormular(0)





    End Sub

    Public Sub fyllFormular(postnr As Integer)
        ' Kontrollera att antalet poster håller sig inom korrekta gränser
        If postnr >= antalPoster Then
            postnr = antalPoster - 1
        ElseIf postnr < 0 Then
            postnr = 0
        End If

        ' Fyll formuläret med uppgifter från databasen
        txtFornamn.Text = dsDagbok.Tables("Dagbok").Rows(postnr)("AktivitetID")
        txtEfternamn.Text = dsDagbok.Tables("Dagbok").Rows(postnr)("datum")
        txtAdress.Text = dsDagbok.Tables("Dagbok").Rows(postnr)("tid")
        txtPostnr.Text = dsDagbok.Tables("Dagbok").Rows(postnr)("distans")
        txtOrt.Text = dsDagbok.Tables("Dagbok").Rows(postnr)("beskrivning")
        txtRpe.Text = dsDagbok.Tables("Dagbok").Rows(postnr)("rpe")


        ' Fyll i aktuellt postnr i rutan
        txtPost.Text = postnr

        aktiveraKnappar(postnr)
    End Sub

    Private Sub aktiveraKnappar(postnr As Integer)
        ' Dölj Ångra-knappen om den syns
        btnAngra.Visible = False

        ' Aktivera radera, ny och visa lista
        btnRadera.Enabled = True
        btnNyPost.Enabled = True
        btnLista.Enabled = True

        ' Avaktivera alla navigationsknappar som standard
        btnForsta.Enabled = False
        btnForegaende.Enabled = False
        btnNasta.Enabled = False
        btnSista.Enabled = False
        Select Case postnr
            Case 0 ' Första posten  - Nästa och Sista aktiva
                btnNasta.Enabled = True
                btnSista.Enabled = True
            Case antalPoster - 1 ' Sista posten - Första och Föregående aktiva
                btnForsta.Enabled = True
                btnForegaende.Enabled = True
            Case Else ' Alla knappar aktiva
                btnForsta.Enabled = True
                btnForegaende.Enabled = True
                btnNasta.Enabled = True
                btnSista.Enabled = True
        End Select
    End Sub

    Private Sub btnForsta_Click(sender As Object, e As EventArgs) Handles btnForsta.Click
        fyllFormular(0)
    End Sub

    Private Sub btnForegaende_Click(sender As Object, e As EventArgs) Handles btnForegaende.Click
        Dim postnr As Integer = Val(txtPost.Text)
        fyllFormular(postnr - 1)
    End Sub

    Private Sub btnSista_Click(sender As Object, e As EventArgs) Handles btnSista.Click
        fyllFormular(antalPoster - 1)
    End Sub

    Private Sub btnNasta_Click(sender As Object, e As EventArgs) Handles btnNasta.Click
        Dim postnr As Integer = Val(txtPost.Text)
        fyllFormular(postnr + 1)
    End Sub

    Private Sub txtPost_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPost.KeyPress
        If e.KeyChar = vbBack Then
            Return
        End If
        Dim allowedChars As String = "0123456789"
        If Not allowedChars.Contains(e.KeyChar.ToString) Then
            e.KeyChar = ChrW(0)
            e.Handled = True
        End If
    End Sub

    Private Sub txtPost_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPost.KeyDown
        If e.KeyCode = Keys.Enter Then
            fyllFormular(Val(txtPost.Text))
        End If
    End Sub

    Private Sub btnSpara_Click(sender As Object, e As EventArgs) Handles btnSpara.Click
        sparaPost()
    End Sub
    Private Sub sparaPost()
        Dim commandBuilder As New OleDb.OleDbCommandBuilder(daDagbok)
        Dim dbRow As DataRow
        Dim postnr As Integer

        ' Skapa en ny datarow om det är fråga om en ny post
        If txtPost.Text = "*" Then
            dbRow = dsDagbok.Tables("Dagbok").NewRow
            ' Sätt databasfälten
            dbRow = tilldelaDatabaspost(dbRow)

            dsDagbok.Tables("Dagbok").Rows.Add(dbRow)
            postnr = dsDagbok.Tables("Dagbok").Rows.Count - 1
            antalPoster = dsDagbok.Tables("Dagbok").Rows.Count
        Else
            ' Tilldela den gamla raden annars
            dbRow = dsDagbok.Tables("Dagbok").Rows(Val(txtPost.Text))
            ' Sätt databasfälten
            dbRow = tilldelaDatabaspost(dbRow)
            postnr = txtPost.Text
        End If

        daDagbok.Update(dsDagbok, "Dagbok")
        fyllFormular(postnr)

    End Sub
    Private Function tilldelaDatabaspost(row As DataRow) As DataRow
        ' Sätt databasfälten baserat på textrutorna
        row.Item("rpe") = txtFornamn.Text
        row.Item("datum") = txtEfternamn.Text
        row.Item("tid") = txtAdress.Text
        row.Item("distans") = txtPostnr.Text
        row.Item("beskrivning") = txtOrt.Text

        Return row
    End Function
    Private Sub btnNyPost_Click(sender As Object, e As EventArgs) Handles btnNyPost.Click
        ' Spara undan senaste postnummer för användning i Ångra-knappen
        btnAngra.Tag = txtPost.Text
        btnAngra.Visible = True

        ' Rensa alla fält
        txtFornamn.Text = ""
        txtEfternamn.Text = ""
        txtAdress.Text = ""
        txtPostnr.Text = ""
        txtOrt.Text = ""

        ' Markera att det är en ny post i post-rutan
        txtPost.Text = "*"

        ' Disabla alla knappar
        btnForsta.Enabled = False
        btnForegaende.Enabled = False
        btnNasta.Enabled = False
        btnSista.Enabled = False
        btnRadera.Enabled = False
        btnNyPost.Enabled = False
        btnLista.Enabled = False

        ' Sätt fokus på förnamn
        txtFornamn.Focus()

    End Sub

    Private Sub btnAngra_Click(sender As Object, e As EventArgs) Handles btnAngra.Click
        txtPost.Text = btnAngra.Tag
        fyllFormular(btnAngra.Tag)
        aktiveraKnappar(btnAngra.Tag)
    End Sub

    Private Sub btnRadera_Click(sender As Object, e As EventArgs) Handles btnRadera.Click
        If MsgBox("Vill du verkligen radera denna?", vbYesNo + vbQuestion) = vbYes Then
            Dim commandBuilder As New OleDbCommandBuilder(daDagbok)

            ' Radera raden och uppdatera dataadaptern
            dsDagbok.Tables("Dagbok").Rows(txtPost.Text).Delete()
            daDagbok.Update(dsDagbok, "Dagbok")

            ' Uppdatera antal poster
            antalPoster = dsDagbok.Tables("Dagbok").Rows.Count

            ' Hitta numret på posten som ska visas
            Dim nyPost As Integer = txtPost.Text - 1
            If nyPost < 0 Then
                nyPost = 0
            End If

            ' Visa rätt post och aktivera knappar
            txtPost.Text = nyPost
            fyllFormular(nyPost)
            aktiveraKnappar(nyPost)

        End If
    End Sub

    Private Sub btnLista_Click(sender As Object, e As EventArgs) Handles btnLista.Click
        frmLista.show()
        Me.Hide()
    End Sub
End Class

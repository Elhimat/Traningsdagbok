
Public Class frmLista
    Private Sub frmLista_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()
    End Sub

    Private Sub frmLista_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim listitem As ListViewItem

        For i = 0 To dsDagbok.Tables("Dagbok").Rows.Count - 1
            listitem = lstAdresser.Items.Add(dsDagbok.Tables("Dagbok").Rows(i)("id"))
            listitem.SubItems.Add(dsDagbok.Tables("Dagbok").Rows(i)("AktivitetID"))
            listitem.SubItems.Add(dsDagbok.Tables("Dagbok").Rows(i)("datum"))
            listitem.SubItems.Add(dsDagbok.Tables("Dagbok").Rows(i)("tid"))
            listitem.SubItems.Add(dsDagbok.Tables("Dagbok").Rows(i)("distans"))
            listitem.SubItems.Add(dsDagbok.Tables("Dagbok").Rows(i)("beskrivning"))
            listitem.SubItems.Add(dsDagbok.Tables("Dagbok").Rows(i)("rpe"))
        Next
    End Sub

    Private Sub lstAdresser_DoubleClick(sender As Object, e As EventArgs) Handles lstAdresser.DoubleClick
        ' hämta markerad rad
        Dim rad As Integer = lstAdresser.SelectedIndices(0)

        'Fyll formuläret med vald post 
        Form1.fyllFormular(rad)

        'stänga listan
        Me.Close()
    End Sub

    Private Sub lstAdresser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAdresser.SelectedIndexChanged

    End Sub
End Class
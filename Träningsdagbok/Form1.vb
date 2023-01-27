Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        reloadTree()
    End Sub
    Private Sub reloadTree()
        ' töm trädvyn
        tvwDagbok.Nodes.Clear()

        'Hämta alla artister
        Dim dtDagbok As DataTable = hamtaData("SELECT * FROM dagbok")

        'fyll  trädvyn med artister 
        fyllTrad(dtDagbok, 0, Nothing, "aktivitetID", "ID")

        'sortera listan
        tvwDagbok.Sort()

    End Sub
    Private Sub fyllTrad(tabell As DataTable, paraentId As Integer, nod As TreeNode, title As String, tag As String)
        'rekursiv funktion för att fylla trädet
        For Each row As DataRow In tabell.Rows
            'skapa en ny trädnode och sätta text
            Dim child As New TreeNode
            child.Text = row(title).ToString
            'sätt en tag som möjliggör sökning av "barn"
            child.Tag = tag & "=" & row(tag)

            If paraentId = 0 Then
                'det är en rot-nod, lägg noden i trädvyn
                tvwDagbok.Nodes.Add(child)
                'hämta information om artistens album
                Dim dtAlbum As DataTable = hamtaData("SELECT * from albums where " & child.Tag)
                fyllTrad(dtAlbum, row(tag), child, "Title", "AlbumId")
            Else
                'tilldela noden till ovanliggande nod
                nod.Nodes.Add(child)

            End If
        Next
    End Sub


    Private Sub showDataGrid(sql As String)
        'Rensa befintlig data 
        grdDetalj.DataSource = Nothing
        'Hämta ny data 
        grdDetalj.DataSource = hamtaData(sql)
        'autojustera för innehållet (och inte för rubrikerna)
        grdDetalj.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        'dölj id-kolumnen
        grdDetalj.Columns(0).Visible = False
    End Sub

End Class
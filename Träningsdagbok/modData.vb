Imports System.Data.OleDb

Module modData
    Public con As New OleDb.OleDbConnection
    Public dsDagbok As New DataSet
    Public daDagbok As OleDbDataAdapter

    Public Sub dbConnect()
        ' Kombinera sökvägar, databasens namn mm till en dbSource
        Dim dbProvider As String = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        Dim dbName As String = "Database3.accdb"
        Dim dbPath As String = "C:\Users\EliasMattsson\source\repos\Träningsdagbok"
        Dim dbSource As String = "Data source=" & dbPath & "\" & dbName
        Dim sql As String

        ' Sätt i hop kopplingssträngen mha variablerna ovan
        con.ConnectionString = dbProvider & dbSource

        ' Öppna databasen
        con.Open()

        ' Välj data att visa
        sql = "SELECT * FROM Dagbok"

        ' Koppla in dataadaptern och fyll den
        daDagbok = New OleDbDataAdapter(sql, con)
        daDagbok.MissingSchemaAction = MissingSchemaAction.AddWithKey
        daDagbok.Fill(dsDagbok, "Dagbok")
    End Sub
End Module

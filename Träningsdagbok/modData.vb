Imports System.Data.OleDb

Module modData
    Public Database3 As New OleDb.OleDbConnection
    Public dsDagbok As New DataSet
    Public daDagbok As OleDbDataAdapter

    Public Sub dbConnect()
        ' Kombinera sökvägar, databasens namn mm till en dbSource
        Dim dbProvider As String = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        Dim dbName As String = "Database3.accdb"
        Dim dbPath As String = "C:\Users\EliasMattsson\source\repos\"
        Dim dbSource As String = "Data source=" & dbPath & "\" & dbName
        Dim sql As String


    End Sub
    Public Function hamtaData(oledb As String) As DataTable
        ' skapa en Datatable för returen
        Dim dt As New DataTable

        'skapa ett kommandoobjekt för att läsa databasen
        Dim cmd As New OleDbCommand(oledb, Database3)

        ' skapa en dataadapter för att exekvera kommandot 
        Dim da As New OleDbDataAdapter(cmd)

        'fyll returobjekt
        da.Fill(dt)

        'returnera datatabellen
        Return dt
    End Function
End Module


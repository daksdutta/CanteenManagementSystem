Imports System.Data.OleDb
Module ModProject
    Public dbcon As New OleDbConnection
    Public Sub pConnectDB()
        dbcon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Final Complete Project\VB.NET PROJECT\projectDbmain.mdb"
        dbcon.Open()
    End Sub

    Public Sub pDisconnectDB()
        If dbcon.State = ConnectionState.Open Then
            dbcon.Close()
            ' MsgBox("closed") 
        End If
    End Sub
End Module

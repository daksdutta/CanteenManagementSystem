Imports System.Data.OleDb

Public Class ChangePassword
    Dim read As String
    Dim datafile As String
    Dim dr As OleDbDataReader
    Dim cmd As OleDbCommand
    Dim dbcon As New OleDbConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            dbcon = New OleDbConnection
            dbcon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Final Complete Project\VB.NET PROJECT\projectDbmain.mdb"
            dbcon.Open()

            Dim sql1 As String
            If (PasswordTB.Text = "" And confirmPasswordTB.Text = "") Then
                MessageBox.Show("all information required")
            ElseIf (PasswordTB.Text <> confirmPasswordTB.Text) Then
                MessageBox.Show("New password And confirm password didn't match")
            Else
                sql1 = "update tbUsers set Password1='" & PasswordTB.Text & "' where Name1='" & currentUsername.Text & "'"
                MessageBox.Show(sql1)
                cmd = New OleDbCommand(sql1, dbcon)
                cmd.ExecuteNonQuery()
                MsgBox("Password Changed succesfully", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

End Class

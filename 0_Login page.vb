﻿Imports System.Data.OleDb
Public Class Login
    Dim read As String
    Dim datafile As String
    Dim dr As OleDbDataReader
    Dim cmd As OleDbCommand
    Dim dbcon As New OleDbConnection

    Private Sub Button1_login_Click(sender As Object, e As EventArgs) Handles Button1_login.Click
        dbcon = New OleDbConnection
        Dim dbprovider As String = "Provider=Microsoft.Jet.OLEDB.4.0;"
        Dim dbsource As String = "Data Source=D:\Final Complete Project\VB.NET PROJECT\projectDbmain.mdb"
        dbcon.ConnectionString = dbprovider & dbsource
        dbcon.Open()
        Dim cmd As OleDbCommand = New OleDbCommand("Select * from tbUsers where Name1 = '" & TextBoxusername.Text & "'and Password1 = '" & TextBoxpassword.Text & "'", dbcon)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        Dim userFound As Boolean = False
        Dim FirstName As String = " "
        Dim LastName As String = " "
        If dr.Read() Then
            userFound = True
            FirstName = dr("FirstName").ToString
            LastName = dr("LastName").ToString
        End If
        If userFound = True Then
            prgBar.Show()
        Else
            MsgBox("Sorry,Username of password not found ", MsgBoxStyle.OkOnly, "invalid login")
        End If

        TextBoxusername.Text = ""
        TextBoxpassword.Text = ""

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            'IF TRUE, IT SHOWS THE TEXT
            TextBoxpassword.UseSystemPasswordChar = False
        Else
            'IF FALSE, IT WILL HIDE THE TEXT AND IT WILL TURN INTO BULLETS.
            TextBoxpassword.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxpassword.UseSystemPasswordChar = True
    End Sub

    Private Sub Label_ForgotPassword_Click(sender As Object, e As EventArgs) Handles Label_ForgotPassword.Click
        ChangePassword.Show()
    End Sub


End Class

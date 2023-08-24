Imports System.Data.OleDb
Public Class Item_Details
    Dim cmd As OleDbCommand
    Dim con As OleDbConnection
    Dim adp As OleDbDataAdapter
    Dim ds As New DataSet
    Dim t1 As DataTable
    Dim i As Integer

    Private Sub FrmItem_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Call pDisconnectDB()
    End Sub
    Private Sub FrmItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call pConnectDB()
        Dim sSql1 As String
        sSql1 = "select * from tbItem"
        ds.Clear()
        adp = New OleDbDataAdapter(sSql1, dbcon)
        adp.Fill(ds, "tbItem")
        DataGridView2.DataSource = ds.Tables(0)
        DataGridView2.Columns(0).ReadOnly = True
        DataGridView2.Columns(0).Visible = False
        TextTitle.Text = ""
        TextCost.Text = ""
        TextDesc.Text = ""
        btnUpdate.Enabled = True
        BtnADD.Enabled = True

    End Sub

    Private Sub BtnADD_Click(sender As Object, e As EventArgs) Handles BtnADD.Click
        Try
            Dim ans As Integer
            ans = MsgBox("Are you sure you want to Insert ?", vbQuestion + vbYesNo, "Insertion")
        If ans = vbYes Then
            Dim sSql As String
            If TextTitle.Text = "" Or TextCost.Text = "" Or TextDesc.Text = "" Or cboItem.Text = "" Then Exit Sub
            sSql = "insert into tbItem (Title,Cost,ItemType,Description) values ('" & TextTitle.Text & "'," & TextCost.Text & ",'" & cboItem.Text & "','" & TextDesc.Text & "')"
            MsgBox("Item added")
            cmd = New OleDbCommand(sSql, dbcon)
            cmd.ExecuteNonQuery()
        End If
        ' to show changes in grid view
        Dim sSql1 As String
        sSql1 = "select * from tbItem"
        ds.Clear()
        adp = New OleDbDataAdapter(sSql1, dbcon)
        adp.Fill(ds, "tbItem")
        DataGridView2.DataSource = ds.Tables(0)
        DataGridView2.Columns(0).ReadOnly = True
        TextTitle.Text = ""
        TextCost.Text = ""
        TextDesc.Text = ""
            cboItem.Text = ""
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click_1(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim ans As Integer
            ans = MsgBox("Do you want to Update ?", vbQuestion + vbYesNo, "Updation")
            If ans = vbYes Then
                Dim sSql As String
                If TextTitle.Text = "" Or TextCost.Text = "" Or TextDesc.Text = "" Or cboItem.Text = "" Then Exit Sub
                sSql = "update tbItem set Title = '" & TextTitle.Text & "', ItemType = '" & cboItem.Text & "', Description = '" & TextDesc.Text & "', Cost = '" & TextCost.Text & "' where ID =" & i
                MsgBox("item Updated")
                cmd = New OleDbCommand(sSql, dbcon)
                cmd.ExecuteNonQuery()
            End If
            ' to show changes in grid view
            Dim sSql1 As String
            sSql1 = "select * from tbItem"
            ds.Clear()
            adp = New OleDbDataAdapter(sSql1, dbcon)
            adp.Fill(ds, "tbItem")
            DataGridView2.DataSource = ds.Tables(0)
            DataGridView2.Columns(0).ReadOnly = True
            TextTitle.Text = ""
            TextCost.Text = ""
            TextDesc.Text = ""
            cboItem.Text = ""
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim ans As Integer
        ans = MsgBox("Are you sure you want to delete ?", vbQuestion + vbYesNo, "Deletion")
        If ans = vbYes Then
            Dim sSql As String
            If TextTitle.Text = "" Or TextCost.Text = "" Or TextDesc.Text = "" Or cboItem.Text = "" Then Exit Sub
            sSql = "Delete from tbItem where ID =" & i
            MsgBox("item Deleted")
            cmd = New OleDbCommand(sSql, dbcon)
            cmd.ExecuteNonQuery()
        End If
        ' to show changes in grid view
        Dim sSql1 As String
        sSql1 = "select * from tbItem"
        ds.Clear()
        adp = New OleDbDataAdapter(sSql1, dbcon)
        adp.Fill(ds, "tbItem")
        DataGridView2.DataSource = ds.Tables(0)
        DataGridView2.Columns(0).ReadOnly = True
        TextTitle.Text = ""
        TextCost.Text = ""
        TextDesc.Text = ""
        cboItem.Text = ""
    End Sub

    Private Sub DataGridView2_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick
        t1 = ds.Tables(0)
        If t1.Rows.Count = 0 Then Exit Sub
        If DataGridView2.CurrentRow.Index >= t1.Rows.Count Then Exit Sub
        Dim myrow As DataRow = t1.Rows(DataGridView2.CurrentRow.Index)
        TextTitle.Text = myrow("Title")
        TextCost.Text = myrow("Cost")
        cboItem.Text = myrow("ItemType")
        TextDesc.Text = myrow("Description")
        i = DataGridView2.Rows().Item(e.RowIndex).Cells(0).Value

    End Sub

    Private Sub Search(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Dim sSql As String
            sSql = "Select * from tbItem where title like '" & TextTitle.Text & "%'"
            ds.Clear()
            adp = New OleDbDataAdapter(sSql, dbcon)
            adp.Fill(ds, "tbItem")
            DataGridView2.DataSource = ds.Tables("tbItem")
            DataGridView2.Columns(0).ReadOnly = True
            'MessageBox.Show("Done")
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TextTitle.Text = ""
        TextCost.Text = ""
        TextDesc.Text = ""
        cboItem.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub



    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim sSql1 As String
        sSql1 = "select * from tbItem"
        ds.Clear()
        adp = New OleDbDataAdapter(sSql1, dbcon)
        adp.Fill(ds, "tbItem")
        DataGridView2.DataSource = ds.Tables(0)
        DataGridView2.Columns(0).ReadOnly = True
        DataGridView2.Columns(0).Visible = False
        TextTitle.Text = ""
        TextCost.Text = ""
        TextDesc.Text = ""
    End Sub

    Private Sub TextTitle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextTitle.KeyPress
        Dim sSql As String
        sSql = "Select * from tbItem where title like '" & TextTitle.Text & "%'"
        ds.Clear()
        adp = New OleDbDataAdapter(sSql, dbcon)
        adp.Fill(ds, "tbItem")
        DataGridView2.DataSource = ds.Tables("tbItem")
        DataGridView2.Columns(0).ReadOnly = True
    End Sub
End Class
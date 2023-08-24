Imports System.Data.OleDb
Public Class GroceryStock
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
        sSql1 = "select * from tbGroceryItems"
        ds.Clear()
        adp = New OleDbDataAdapter(sSql1, dbcon)
        adp.Fill(ds, "tbGroceryItems")
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Columns(0).ReadOnly = True
        DataGridView1.Columns(0).Visible = False
        txtItem.Text = ""
        txtQuantity.Text = ""
        txtDesc.Text = ""
        BtnUpdate.Enabled = True
        BtnAdd.Enabled = True

    End Sub

    Private Sub BtnADD_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Try
            Dim ans As Integer
            ans = MsgBox("Are you sure you want to Insert ?", vbQuestion + vbYesNo, "Insertion")
            If ans = vbYes Then
                Dim sSql As String
                If txtItem.Text = "" Or txtQuantity.Text = "" Or txtDesc.Text = "" Then Exit Sub
                sSql = "insert into tbGroceryItems (Title,Cost,Description) values ('" & txtItem.Text & "'," & txtQuantity.Text & ",'" & txtDesc.Text & "')"
                MsgBox("Item added")
                cmd = New OleDbCommand(sSql, dbcon)
                cmd.ExecuteNonQuery()
            End If
            ' to show changes in grid view
            Dim sSql1 As String
            sSql1 = "select * from tbGroceryItems"
            ds.Clear()
            adp = New OleDbDataAdapter(sSql1, dbcon)
            adp.Fill(ds, "tbGroceryItems")
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.Columns(0).ReadOnly = True
            txtItem.Text = ""
            txtQuantity.Text = ""
            txtDesc.Text = ""
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try


    End Sub

    Private Sub btnUpdate_Click_1(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try
            Dim ans As Integer
            ans = MsgBox("Do you want to Update ?", vbQuestion + vbYesNo, "Updation")
            If ans = vbYes Then
                Dim sSql As String
                If txtItem.Text = "" Or txtQuantity.Text = "" Or txtDesc.Text = "" Then Exit Sub
                sSql = "update tbGroceryItems set Title = '" & txtItem.Text & "', Description = '" & txtDesc.Text & "', Cost = '" & txtQuantity.Text & "' where ID =" & i
                MsgBox("item Updated")
                cmd = New OleDbCommand(sSql, dbcon)
                cmd.ExecuteNonQuery()
            End If
            ' to show changes in grid view
            Dim sSql1 As String
            sSql1 = "select * from tbGroceryItems"
            ds.Clear()
            adp = New OleDbDataAdapter(sSql1, dbcon)
            adp.Fill(ds, "tbGroceryItems")
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.Columns(0).ReadOnly = True
            txtItem.Text = ""
            txtQuantity.Text = ""
            txtDesc.Text = ""
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try

    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim ans As Integer
        ans = MsgBox("Are you sure you want to delete ?", vbQuestion + vbYesNo, "Deletion")
        If ans = vbYes Then
            Dim sSql As String
            If txtItem.Text = "" Or txtQuantity.Text = "" Or txtDesc.Text = "" Then Exit Sub
            sSql = "Delete from tbGroceryItems where ID =" & i
            MsgBox("item Deleted")
            cmd = New OleDbCommand(sSql, dbcon)
            cmd.ExecuteNonQuery()
        End If
        ' to show changes in grid view
        Dim sSql1 As String
        sSql1 = "select * from tbGroceryItems"
        ds.Clear()
        adp = New OleDbDataAdapter(sSql1, dbcon)
        adp.Fill(ds, "tbGroceryItems")
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Columns(0).ReadOnly = True
        txtItem.Text = ""
        txtQuantity.Text = ""
        txtDesc.Text = ""

    End Sub

    Private Sub DataGridView2_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        t1 = ds.Tables(0)
        If t1.Rows.Count = 0 Then Exit Sub
        If DataGridView1.CurrentRow.Index >= t1.Rows.Count Then Exit Sub
        Dim myrow As DataRow = t1.Rows(DataGridView1.CurrentRow.Index)
        txtItem.Text = myrow("Title")
        txtQuantity.Text = myrow("Cost")
        txtDesc.Text = myrow("Description")
        i = DataGridView1.Rows().Item(e.RowIndex).Cells(0).Value

    End Sub

    Private Sub Search(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim sSql As String
            sSql = "Select * from tbGroceryItems where title like '" & txtItem.Text & "%'"
            ds.Clear()
            adp = New OleDbDataAdapter(sSql, dbcon)
            adp.Fill(ds, "tbGroceryItems")
            DataGridView1.DataSource = ds.Tables("tbGroceryItems")
            DataGridView1.Columns(0).ReadOnly = True
            'MessageBox.Show("Done")
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtItem.Text = ""
        txtQuantity.Text = ""
        txtDesc.Text = ""

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub txtItem_KeyPress(sender As Object, e As EventArgs) Handles txtItem.KeyPress
        Dim sSql As String
        sSql = "Select * from tbGroceryItems where title like '" & txtItem.Text & "%'"
        ds.Clear()
        adp = New OleDbDataAdapter(sSql, dbcon)
        adp.Fill(ds, "tbGroceryItems")
        DataGridView1.DataSource = ds.Tables("tbGroceryItems")
        DataGridView1.Columns(0).ReadOnly = True
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim sSql1 As String
        sSql1 = "select * from tbGroceryItems"
        ds.Clear()
        adp = New OleDbDataAdapter(sSql1, dbcon)
        adp.Fill(ds, "tbGroceryItems")
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Columns(0).ReadOnly = True
        txtItem.Text = ""
        txtQuantity.Text = ""
        txtDesc.Text = ""
    End Sub
End Class
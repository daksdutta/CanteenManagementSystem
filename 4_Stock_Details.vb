Imports System.Data.OleDb
Public Class Stock_Details
    Dim cmd As OleDbCommand
    Dim con As OleDbConnection
    Dim adp As OleDbDataAdapter
    Dim ds, ds1 As New DataSet
    Dim t1 As DataTable
    Dim i As Integer
    Dim Descriptionn As String = ""
    Private Sub FrmStock_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Call pDisconnectDB()
    End Sub
    Private Sub FrmStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call pConnectDB()
        Call pLoadCboEmp()

        Dim sSql1 As String
        sSql1 = "select * from tbStock"
        ds.Clear()
        adp = New OleDbDataAdapter(sSql1, dbcon)
        adp.Fill(ds, "tbStock")
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Columns(0).ReadOnly = True
        DataGridView1.Columns(0).Visible = False
        cboItem.Text = ""
        txtQuantity.Text = ""
        txtDesc.Text = ""
        BtnUpdate.Enabled = True
        BtnAdd.Enabled = True
    End Sub

    Private Sub pLoadCboEmp()
        adp = New OleDbDataAdapter("select * from tbItem", dbcon)
        adp.Fill(ds1) 'OR adp.Fill(ds, "tbItem")
        cboItem.DataSource = ds1.Tables(0)
        cboItem.ValueMember = "Title" 'Exist behind the combo list
        cboItem.DisplayMember = "Item Type" 'Visible content
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        t1 = ds.Tables(0)
        If t1.Rows.Count = 0 Then Exit Sub
        If DataGridView1.CurrentRow.Index >= t1.Rows.Count Then Exit Sub
        Dim myrow As DataRow = t1.Rows(DataGridView1.CurrentRow.Index)

        cboItem.Text = myrow("Item")
        txtQuantity.Text = myrow("Quantity")
        'txtDesc.Text = myrow("Description")
        i = DataGridView1.Rows().Item(e.RowIndex).Cells(0).Value

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Try
            Dim ans As Integer
        ans = MsgBox("Do you want to Insert ?", vbQuestion + vbYesNo, "Insertion")
        If ans = vbYes Then
            Dim sSql As String
            sSql = "insert into tbStock (Item,Quantity,Description) values ('" & cboItem.Text & "'," & txtQuantity.Text & ",'" & txtDesc.Text & "')"
            MsgBox("Item added to stock")
            cmd = New OleDbCommand(sSql, dbcon)
            cmd.ExecuteNonQuery()
        End If
        'to show changes in grid view
        Dim sSql1 As String
        sSql1 = "select * from tbStock"
        ds.Clear()
        adp = New OleDbDataAdapter(sSql1, dbcon)
        adp.Fill(ds, "tbStock")
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Columns(0).ReadOnly = True
        cboItem.Text = ""
        txtQuantity.Text = ""
            txtDesc.Text = ""
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim ans As Integer
        ans = MsgBox("Are you sure you want to delete ?", vbQuestion + vbYesNo, "Deletion")
        If ans = vbYes Then
            Dim sSql As String
            sSql = "Delete from tbStock where ID =" & i
            MsgBox("item Deleted")
            cmd = New OleDbCommand(sSql, dbcon)
            cmd.ExecuteNonQuery()
        End If
        'to show changes in grid view
        Dim sSql1 As String
        sSql1 = "select * from tbStock"
        ds.Clear()
        adp = New OleDbDataAdapter(sSql1, dbcon)
        adp.Fill(ds, "tbStock")
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Columns(0).ReadOnly = True
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim sSql As String
            sSql = "Select * from tbStock where Item like '" & cboItem.Text & "%'"
            ds.Clear()
            adp = New OleDbDataAdapter(sSql, dbcon)
            adp.Fill(ds, "tbStock")
            DataGridView1.DataSource = ds.Tables("tbStock")
            DataGridView1.Columns(0).ReadOnly = True
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try
    End Sub

    Private Sub cboItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboItem.SelectedIndexChanged
        Dim connString As String
        connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Rajesh Mittal\Desktop\vbdotnet\New Project\Final Project VB\VB.NET PROJECT\projectDbmain.mdb"
        con = New OleDbConnection
        con.ConnectionString = connString
        If con.State = 1 Then con.Close()
        txtQuantity.Clear()

        Try
            cmd = New OleDbCommand("select * from tbItem where Title='" & cboItem.Text & "'", dbcon)
            con.Open()
            Dim dr1 As OleDbDataReader = cmd.ExecuteReader()
            If dr1.Read Then
                txtDesc.Text = dr1.Item("Description").ToString
                Descriptionn = dr1.Item("Description").ToString
                txtQuantity.Focus()
            End If
        Catch ex As Exception
            If con.State = 1 Then con.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtDesc.Text = ""
        txtQuantity.Text = ""
        cboItem.Text = ""
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try
            Dim ans As Integer
            ans = MsgBox("Are you sure you want to Update ?", vbQuestion + vbYesNo, "updation")
            If ans = vbYes Then
                Dim sSql As String

                sSql = "update tbStock set Item = '" & cboItem.Text & "', Quantity = '" & txtQuantity.Text & "' where ID =" & i
                MsgBox("item Updated in stock")
                cmd = New OleDbCommand(sSql, dbcon)
                cmd.ExecuteNonQuery()
            End If
            'to show changes in grid view
            Dim sSql1 As String
            sSql1 = "select * from tbStock"
            ds.Clear()
            adp = New OleDbDataAdapter(sSql1, dbcon)
            adp.Fill(ds, "tbStock")
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.Columns(0).ReadOnly = True
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim sSql1 As String
        sSql1 = "select * from tbStock"
        ds.Clear()
        adp = New OleDbDataAdapter(sSql1, dbcon)
        adp.Fill(ds, "tbStock")
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Columns(0).ReadOnly = True
        cboItem.Text = ""
        txtQuantity.Text = ""
        txtDesc.Text = ""
        BtnUpdate.Enabled = True
        BtnAdd.Enabled = True
    End Sub

    Private Sub cboItem_Leave(sender As Object, e As EventArgs) Handles cboItem.Leave
        Dim sSql As String
        sSql = "Select * from tbStock where Item like '" & cboItem.Text & "%'"
        ds.Clear()
        adp = New OleDbDataAdapter(sSql, dbcon)
        adp.Fill(ds, "tbStock")
        DataGridView1.DataSource = ds.Tables("tbStock")
        DataGridView1.Columns(0).ReadOnly = True
    End Sub

End Class
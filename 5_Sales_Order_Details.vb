Imports System.Data.OleDb
Public Class Sales_Details
    Dim cmd As OleDbCommand
    Dim con As OleDbConnection
    Dim adp As OleDbDataAdapter
    Dim ds, ds1 As New DataSet
    Dim t1 As DataTable
    Dim i As Integer
    Dim qry As String = ""
    Dim Cost As String = ""
    Dim Quantity As String = ""
    Dim qty2 As String = ""


    Private Sub FrmSales_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Call pDisconnectDB()
    End Sub
    Private Sub FrmSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call pConnectDB()
        pLoadCboSales()
        Dim sSql1 As String
        Dim sSql2 As String
        sSql1 = "select * from tbSales"
        sSql2 = "select * from tbOrder"
        ds.Clear()
        adp = New OleDbDataAdapter(sSql1, dbcon)
        adp.Fill(ds, "tbSales")
        DataGrid_Sales.DataSource = ds.Tables(0)
        DataGrid_Sales.Columns(0).ReadOnly = True
        txtCost.Text = ""
        txtsalesQuantity.Text = ""
        cboItem.Text = ""
        adp.SelectCommand.CommandText = sSql2
        adp.Fill(ds, "tbOrder")
        DataGrid_Order.DataSource = ds.Tables(1)

    End Sub

    Private Sub pLoadCboSales()
        adp = New OleDbDataAdapter("select * from tbItem", dbcon)
        adp.Fill(ds1) 'OR adp.Fill(ds, "tbItem")
        cboItem.DataSource = ds1.Tables(0)
        cboItem.ValueMember = "Title" 'Exist behind the combo list
        cboItem.DisplayMember = "Item" 'Visible content
    End Sub

    Private Sub cboItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboItem.SelectedIndexChanged
        Dim connString As String
        connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Rajesh Mittal\Desktop\vbdotnet\New Project\Final Project VB\VB.NET PROJECT\projectDbmain.mdb"
        con = New OleDbConnection
        con.ConnectionString = connString
        If con.State = 1 Then con.Close()
        txtsalesQuantity.Clear()

        Try
            cmd = New OleDbCommand("select * from tbItem where Title='" & cboItem.Text & "'", dbcon)
            con.Open()
            Dim dr1 As OleDbDataReader = cmd.ExecuteReader()
            If dr1.Read Then
                txtCost.Text = dr1.Item("Cost").ToString
                Cost = dr1.Item("Cost").ToString
                txtsalesQuantity.Focus()
            End If
        Catch ex As Exception
            If con.State = 1 Then con.Close()
        End Try
    End Sub



    Private Function InsertData(ByVal qry As String) As Integer
        Dim i As String
        If con.State = 1 Then con.Close()

        cmd = New OleDbCommand(qry, dbcon)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        i = cmd.ExecuteNonQuery()
        If con.State = 1 Then
            con.Close()
        End If
        Return i
    End Function



    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGrid_Sales.CellMouseClick
        t1 = ds.Tables(0)
        If t1.Rows.Count = 0 Then Exit Sub
        If DataGrid_Sales.CurrentRow.Index >= t1.Rows.Count Then Exit Sub
        Dim myrow As DataRow = t1.Rows(DataGrid_Sales.CurrentRow.Index)

        cboItem.Text = myrow("Item")
        txtsalesQuantity.Text = myrow("Quantity")
        txtCost.Text = myrow("Cost")

        i = DataGrid_Sales.Rows().Item(e.RowIndex).Cells(0).Value
    End Sub

    Private Sub btn_NewOrder_Click(sender As Object, e As EventArgs) Handles btn_NewOrder.Click
        Try
            Dim sSql As String
            sSql = "Delete * from tbOrder "
            cmd = New OleDbCommand(sSql, dbcon)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try
    End Sub

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles BtnInsert.Click
        Try
            checkstock()
            Dim i As String
            qry = "insert into tbSales (Item,Quantity,Cost) values ('" & cboItem.Text & "'," & txtsalesQuantity.Text & "," & txtCost.Text & ")"
            cmd = New OleDbCommand(qry, con)
            cmd.ExecuteNonQuery()
            If Val(Quantity) >= Val(txtsalesQuantity.Text) Then
                qty2 = Val(Quantity) - Val(txtsalesQuantity.Text)
                qry = "update tbStock set Quantity ='" & qty2 & "' where Item ='" & cboItem.Text & "' "
                i = InsertData(qry)
                If i >= 1 Then
                Else
                    MsgBox("failed")
                End If
            Else
                MsgBox("Item Out of Stock...", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox("Error: Please Add To Bill First Then Insert Into Sales")
        End Try
    End Sub

    Private Sub btn_AddToBill_Click(sender As Object, e As EventArgs) Handles btn_AddToBill.Click
        Try
            qry = "insert into tbOrder (Item,Quantity,Cost) values ('" & cboItem.Text & "'," & txtsalesQuantity.Text & "," & txtCost.Text & ")"
            cmd = New OleDbCommand(qry, con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try
    End Sub

    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click
        cboItem.Text = " "
        txtCost.Text = " "
        txtsalesQuantity.Text = " "
    End Sub

    Private Sub Btn_GrandTotal_Click(sender As Object, e As EventArgs) Handles Btn_GrandTotal.Click
        Dim total As Integer
        For Each row As DataGridViewRow In DataGrid_Order.Rows
            total += row.Cells("Cost").Value
        Next
        txtTotal.Text = total
    End Sub

    Private Sub btn_Remove_Click(sender As Object, e As EventArgs) Handles btn_Remove.Click
        If Val(txtsalesQuantity.Text) > 0 Then
            txtsalesQuantity.Text = Val(txtsalesQuantity.Text) - 1
        End If
    End Sub

    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        txtsalesQuantity.Text = Val(txtsalesQuantity.Text) + 1
    End Sub

    Private Sub Btn_Show_Click(sender As Object, e As EventArgs) Handles Btn_Show.Click
        Dim sSql1 As String
        Dim sSql2 As String
        sSql1 = "select * from tbSales"
        sSql2 = "select * from tbOrder"
        ds.Clear()
        adp = New OleDbDataAdapter(sSql1, dbcon)
        adp.Fill(ds, "tbSales")
        DataGrid_Sales.DataSource = ds.Tables(0)
        DataGrid_Sales.Columns(0).ReadOnly = True
        adp.SelectCommand.CommandText = sSql2
        adp.Fill(ds, "tbOrder")
        DataGrid_Order.DataSource = ds.Tables(1)
    End Sub

    Private Sub txtsalesQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtsalesQuantity.TextChanged
        Try
            If txtsalesQuantity.Text = "" Then
                txtCost.Text = Cost
            Else
                txtCost.Text = Convert.ToInt32(txtsalesQuantity.Text) * Convert.ToInt32(txtCost.Text)
                txtCost.ReadOnly = True
            End If
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Btn_Print_Click(sender As Object, e As EventArgs) Handles Btn_Print.Click
        frmOrderReport.Show()
    End Sub

    Public Sub checkstock()
        If con.State = 1 Then con.Close()
        Try
            cmd = New OleDbCommand("select * from tbStock where Item ='" & cboItem.Text & "'", con)
            con.Open()
            Dim dr1 As OleDbDataReader = cmd.ExecuteReader()
            If dr1.Read() Then
                Quantity = dr1.Item("Quantity").ToString
            Else
                MsgBox("Data not available")
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class


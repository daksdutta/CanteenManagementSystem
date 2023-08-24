Imports System.Data.OleDb
Public Class Employee_Details
    Dim cmd As OleDbCommand
    Dim con As OleDbConnection
    Dim adp As OleDbDataAdapter
    Dim ds As New DataSet
    Dim t1 As DataTable

    Private Sub Employee_Management_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Call pDisconnectDB()
    End Sub

    Private Sub Employee_Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call pConnectDB()

        Dim sSql1 As String
        sSql1 = "select * from EmpMangement"
        ds.Clear()
        adp = New OleDbDataAdapter(sSql1, dbcon)
        adp.Fill(ds, "EmpMangement")
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Columns(0).ReadOnly = True
        btnUpdate.Enabled = True
        btnAdd.Enabled = True

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtId.Text = " "
        txtName.Text = " "
        txtSal.Text = " "
        txtEmail.Text = " "
        cbGender.Text = " "
        txtDob.Text = " "
        txtDoj.Text = " "
        txtMobile.Text = " "
        txtAddress.Text = " "
        txtCity.Text = " "
        cbState.Text = " "
        txtPin.Text = " "
        txtDesignation.Text = " "
    End Sub

    Private Sub bt_dob_Click(sender As Object, e As EventArgs) Handles bt_dob.Click
        txtDob.Text = Format(AppointmentDatePicker.Value, "dd-MM-yyyy")
    End Sub

    Private Sub bt_doj_Click(sender As Object, e As EventArgs) Handles bt_dojoining.Click
        txtDoj.Text = Format(AppointmentDatePicker.Value, "dd-MM-yyyy")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            'Dim ans As Integer
            ' ans = MsgBox("Do you want to Insert ?", vbQuestion + vbYesNo, "Insertion")
            'If ans = vbYes Then
            Dim sSql As String
                sSql = "insert into EmpMangement (Id,EmployeeName,EmployeeSalary,EmployeeEmail,EmpGender,EmployeeDOB,EmployeeDOJ,EmployeeMobile,AddressLine1,City,State,Pincode,Designation) 
                values( " & txtId.Text & ",
                       '" & txtName.Text & "',
                        " & txtSal.Text & ",
                        '" & txtEmail.Text & " ',                       
                        '" & cbGender.Text & " ',
                        #" & txtDob.Text & "#,
                        #" & txtDoj.Text & "#,
                         " & txtMobile.Text & ",
                        '" & txtAddress.Text & "',
                        '" & txtCity.Text & " ',
                        '" & cbState.Text & " ',
                         " & txtPin.Text & ",
                        '" & txtDesignation.Text & " ')"

            'MsgBox("Record added", MsgBoxStyle.Information)
            cmd = New OleDbCommand(sSql, dbcon)
                cmd.ExecuteNonQuery()
            'End If
            'to show changes in grid view
            Dim sSql1 As String
            sSql1 = "select * from EmpMangement"
            ds.Clear()
            adp = New OleDbDataAdapter(sSql1, dbcon)
            adp.Fill(ds, "EmpMangement")
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.Columns(0).ReadOnly = True

        Catch ex As Exception
            txtId.Text = MsgBox("Error: You Cannot Insert Same ID", MsgBoxStyle.Critical)
            txtId.Text = ""
        End Try

    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        t1 = ds.Tables(0)
        If t1.Rows.Count = 0 Then Exit Sub
        If DataGridView1.CurrentRow.Index >= t1.Rows.Count Then Exit Sub
        Dim myrow As DataRow = t1.Rows(DataGridView1.CurrentRow.Index)
        txtId.Text = myrow("Id")
        txtName.Text = myrow("EmployeeName")
        txtSal.Text = myrow("EmployeeSalary")
        txtEmail.Text = myrow("EmployeeEmail")
        cbGender.Text = myrow("EmpGender")
        txtDob.Text = myrow("EmployeeDOB")
        txtDoj.Text = myrow("EmployeeDOJ")
        txtMobile.Text = myrow("EmployeeMobile")
        txtAddress.Text = myrow("AddressLine1")
        txtCity.Text = myrow("City")
        cbState.Text = myrow("State")
        txtPin.Text = myrow("Pincode")
        txtDesignation.Text = myrow("Designation")

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim ans As Integer
            ans = MsgBox("Are you sure you want to Update ?", vbQuestion + vbYesNo, "Updation")
            If ans = vbYes Then
                Dim sSql As String
                sSql = "update EmpMangement set EmployeeName = '" & txtName.Text & "', 
                                        EmployeeSalary = '" & txtSal.Text & "', 
                                        EmployeeEmail = '" & txtEmail.Text & "', 
                                        EmpGender = '" & cbGender.Text & "',
                                        EmployeeDOB = #" & txtDob.Text & "#,
                                        EmployeeDOJ = #" & txtDoj.Text & "#,
                                        EmployeeMobile = '" & txtMobile.Text & "',
                                        AddressLine1 = '" & txtAddress.Text & "',
                                        City = '" & txtCity.Text & "', 
                                        State = '" & cbState.Text & "', 
                                        Pincode = '" & txtPin.Text & "', 
                                        Designation = '" & txtDesignation.Text & "' 
                                        where ID =" & txtId.Text
                'MsgBox("Record Updated")
                cmd = New OleDbCommand(sSql, dbcon)
                cmd.ExecuteNonQuery()
            End If
            'to show changes in grid view
            Dim sSql1 As String
            sSql1 = "select * from EmpMangement"
            ds.Clear()
            adp = New OleDbDataAdapter(sSql1, dbcon)
            adp.Fill(ds, "EmpMangement")
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.Columns(0).ReadOnly = True
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim ans As Integer
        ans = MsgBox("Are you sure you want to delete ?", vbQuestion + vbYesNo, "Deletion")
        If ans = vbYes Then
            Dim sSql As String
            sSql = "Delete from EmpMangement where ID =" & txtId.Text
            'MsgBox("Record Deleted")
            cmd = New OleDbCommand(sSql, dbcon)
            cmd.ExecuteNonQuery()
        End If
        'to show changes in grid view
        Dim sSql1 As String
        sSql1 = "select * from EmpMangement"
        ds.Clear()
        adp = New OleDbDataAdapter(sSql1, dbcon)
        adp.Fill(ds, "EmpMangement")
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Columns(0).ReadOnly = True
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try

            If (txtId.Text = "") Then
                MsgBox("Please enter ID for search", MsgBoxStyle.Critical)
            Else
                Dim sSql As String
                sSql = "Select * from EmpMangement where ID like '" & txtId.Text & "%'"
                ds.Clear()
                adp = New OleDbDataAdapter(sSql, dbcon)
                adp.Fill(ds, "EmpMangement")
                DataGridView1.DataSource = ds.Tables("EmpMangement")
                DataGridView1.Columns(0).ReadOnly = True
                'MsgBox("Record Found", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim sSql1 As String
        sSql1 = "select * from EmpMangement"
        ds.Clear()
        adp = New OleDbDataAdapter(sSql1, dbcon)
        adp.Fill(ds, "EmpMangement")
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Columns(0).ReadOnly = True
    End Sub
End Class
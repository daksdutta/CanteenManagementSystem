Public Class Homepage

    Private Sub AddNewEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewEmployeeToolStripMenuItem.Click
        Employee_Details.Show()
    End Sub

    Private Sub AddItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddItemsToolStripMenuItem.Click
        Item_Details.Show()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        ChangePassword.Show()
    End Sub


    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim ans As Integer
        ans = MsgBox("Are you sure you want to LogOut ?", vbQuestion + vbYesNo, "LogOut")
        If ans = vbYes Then
            Login.Close()
        End If
    End Sub

    Private Sub EmployeeReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeReportToolStripMenuItem.Click
        frmEmpReport.Show()
    End Sub

    Private Sub ItemReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemReportToolStripMenuItem.Click
        frmItemsReport.Show()
    End Sub

    Private Sub AddSaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSaleToolStripMenuItem.Click
        Sales_Details.Show()
    End Sub

    Private Sub SalesReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesReportToolStripMenuItem.Click
        frmSalesReport.Show()
    End Sub

    Private Sub AddItemsToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AddItemsToolStripMenuItem2.Click
        GroceryItems.Show()
    End Sub

    Private Sub AddItemsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddItemsToolStripMenuItem1.Click
        GroceryStock.Show()
    End Sub

    Private Sub StockReportToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles StockReportToolStripMenuItem.Click
        FrmStockReport.Show()
    End Sub


End Class
Public Class frmSalesReport
    Private Sub frmSalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalesDataSet1.tbSales' table. You can move, or remove it, as needed.
        Me.tbSalesTableAdapter.Fill(Me.SalesDataSet1.tbSales)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
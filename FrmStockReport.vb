Public Class FrmStockReport
    Private Sub FrmStockReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StockDataSet1.tbStock' table. You can move, or remove it, as needed.
        Me.tbStockTableAdapter.Fill(Me.StockDataSet1.tbStock)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
Public Class frmItemsReport
    Private Sub frmItemsReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ItemDataSet1.tbItem' table. You can move, or remove it, as needed.
        Me.tbItemTableAdapter.Fill(Me.ItemDataSet1.tbItem)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
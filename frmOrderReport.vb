Public Class frmOrderReport
    Private Sub frmOrderReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OrderDataSet1.tbOrder' table. You can move, or remove it, as needed.
        Me.tbOrderTableAdapter.Fill(Me.OrderDataSet1.tbOrder)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
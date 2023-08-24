Public Class frmEmpReport
    Private Sub frmEmpReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmpDataSet1.EmpMangement' table. You can move, or remove it, as needed.
        Me.EmpMangementTableAdapter.Fill(Me.EmpDataSet1.EmpMangement)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
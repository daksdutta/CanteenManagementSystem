<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStockReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.StockDataSet1 = New WindowsApp1.StockDataSet1()
        Me.tbStockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbStockTableAdapter = New WindowsApp1.StockDataSet1TableAdapters.tbStockTableAdapter()
        CType(Me.StockDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbStockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tbStockBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApp1.StockReport1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'StockDataSet1
        '
        Me.StockDataSet1.DataSetName = "StockDataSet1"
        Me.StockDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbStockBindingSource
        '
        Me.tbStockBindingSource.DataMember = "tbStock"
        Me.tbStockBindingSource.DataSource = Me.StockDataSet1
        '
        'tbStockTableAdapter
        '
        Me.tbStockTableAdapter.ClearBeforeFill = True
        '
        'FrmStockReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmStockReport"
        Me.Text = "FrmStockReport"
        CType(Me.StockDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbStockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbStockBindingSource As BindingSource
    Friend WithEvents StockDataSet1 As StockDataSet1
    Friend WithEvents tbStockTableAdapter As StockDataSet1TableAdapters.tbStockTableAdapter
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderReport
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
        Me.OrderDataSet1 = New WindowsApp1.OrderDataSet1()
        Me.tbOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbOrderTableAdapter = New WindowsApp1.OrderDataSet1TableAdapters.tbOrderTableAdapter()
        CType(Me.OrderDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tbOrderBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApp1.OrderReport1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'OrderDataSet1
        '
        Me.OrderDataSet1.DataSetName = "OrderDataSet1"
        Me.OrderDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbOrderBindingSource
        '
        Me.tbOrderBindingSource.DataMember = "tbOrder"
        Me.tbOrderBindingSource.DataSource = Me.OrderDataSet1
        '
        'tbOrderTableAdapter
        '
        Me.tbOrderTableAdapter.ClearBeforeFill = True
        '
        'frmOrderReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmOrderReport"
        Me.Text = "frmOrderReport"
        CType(Me.OrderDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbOrderBindingSource As BindingSource
    Friend WithEvents OrderDataSet1 As OrderDataSet1
    Friend WithEvents tbOrderTableAdapter As OrderDataSet1TableAdapters.tbOrderTableAdapter
End Class

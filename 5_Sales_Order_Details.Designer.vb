<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sales_Details
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnInsert = New System.Windows.Forms.Button()
        Me.Btn_Show = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_GrandTotal = New System.Windows.Forms.Button()
        Me.btn_AddToBill = New System.Windows.Forms.Button()
        Me.btn_NewOrder = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Btn_Print = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Btn_Clear = New System.Windows.Forms.Button()
        Me.DataGrid_Order = New System.Windows.Forms.DataGridView()
        Me.btn_Remove = New System.Windows.Forms.Button()
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.txtsalesQuantity = New System.Windows.Forms.TextBox()
        Me.cboItem = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGrid_Sales = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.DataGrid_Order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid_Sales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnInsert
        '
        Me.BtnInsert.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BtnInsert.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInsert.ForeColor = System.Drawing.Color.White
        Me.BtnInsert.Location = New System.Drawing.Point(712, 573)
        Me.BtnInsert.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(193, 53)
        Me.BtnInsert.TabIndex = 5
        Me.BtnInsert.Text = "Save Sales"
        Me.BtnInsert.UseVisualStyleBackColor = False
        '
        'Btn_Show
        '
        Me.Btn_Show.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Btn_Show.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Show.ForeColor = System.Drawing.Color.White
        Me.Btn_Show.Location = New System.Drawing.Point(357, 212)
        Me.Btn_Show.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Show.Name = "Btn_Show"
        Me.Btn_Show.Size = New System.Drawing.Size(128, 32)
        Me.Btn_Show.TabIndex = 146
        Me.Btn_Show.Text = "SHOW"
        Me.Btn_Show.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(73, 485)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 20)
        Me.Label3.TabIndex = 145
        Me.Label3.Text = "BILL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 310)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 144
        Me.Label2.Text = "SALES "
        '
        'Btn_GrandTotal
        '
        Me.Btn_GrandTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Btn_GrandTotal.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_GrandTotal.ForeColor = System.Drawing.Color.White
        Me.Btn_GrandTotal.Location = New System.Drawing.Point(591, 455)
        Me.Btn_GrandTotal.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_GrandTotal.Name = "Btn_GrandTotal"
        Me.Btn_GrandTotal.Size = New System.Drawing.Size(117, 38)
        Me.Btn_GrandTotal.TabIndex = 143
        Me.Btn_GrandTotal.Text = "TOTAL"
        Me.Btn_GrandTotal.UseVisualStyleBackColor = False
        '
        'btn_AddToBill
        '
        Me.btn_AddToBill.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btn_AddToBill.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddToBill.ForeColor = System.Drawing.Color.White
        Me.btn_AddToBill.Location = New System.Drawing.Point(216, 212)
        Me.btn_AddToBill.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_AddToBill.Name = "btn_AddToBill"
        Me.btn_AddToBill.Size = New System.Drawing.Size(128, 32)
        Me.btn_AddToBill.TabIndex = 142
        Me.btn_AddToBill.Text = "ADD TO BILL"
        Me.btn_AddToBill.UseVisualStyleBackColor = False
        '
        'btn_NewOrder
        '
        Me.btn_NewOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btn_NewOrder.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_NewOrder.ForeColor = System.Drawing.Color.White
        Me.btn_NewOrder.Location = New System.Drawing.Point(75, 255)
        Me.btn_NewOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_NewOrder.Name = "btn_NewOrder"
        Me.btn_NewOrder.Size = New System.Drawing.Size(129, 32)
        Me.btn_NewOrder.TabIndex = 141
        Me.btn_NewOrder.Text = "NEW ORDER"
        Me.btn_NewOrder.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(75, 212)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 32)
        Me.Button1.TabIndex = 140
        Me.Button1.Text = "ADD TO SALES"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Btn_Print
        '
        Me.Btn_Print.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Btn_Print.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Print.ForeColor = System.Drawing.Color.White
        Me.Btn_Print.Location = New System.Drawing.Point(357, 255)
        Me.Btn_Print.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Print.Name = "Btn_Print"
        Me.Btn_Print.Size = New System.Drawing.Size(128, 32)
        Me.Btn_Print.TabIndex = 139
        Me.Btn_Print.Text = "PRINT RECEIPT"
        Me.Btn_Print.UseVisualStyleBackColor = False
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.Silver
        Me.txtTotal.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(591, 520)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(118, 27)
        Me.txtTotal.TabIndex = 138
        '
        'Btn_Clear
        '
        Me.Btn_Clear.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Btn_Clear.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Clear.ForeColor = System.Drawing.Color.White
        Me.Btn_Clear.Location = New System.Drawing.Point(216, 255)
        Me.Btn_Clear.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Clear.Name = "Btn_Clear"
        Me.Btn_Clear.Size = New System.Drawing.Size(128, 32)
        Me.Btn_Clear.TabIndex = 137
        Me.Btn_Clear.Text = "CLEAR "
        Me.Btn_Clear.UseVisualStyleBackColor = False
        '
        'DataGrid_Order
        '
        Me.DataGrid_Order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGrid_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_Order.Location = New System.Drawing.Point(75, 520)
        Me.DataGrid_Order.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGrid_Order.Name = "DataGrid_Order"
        Me.DataGrid_Order.RowTemplate.Height = 24
        Me.DataGrid_Order.Size = New System.Drawing.Size(473, 132)
        Me.DataGrid_Order.TabIndex = 136
        '
        'btn_Remove
        '
        Me.btn_Remove.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btn_Remove.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Remove.ForeColor = System.Drawing.Color.White
        Me.btn_Remove.Location = New System.Drawing.Point(402, 128)
        Me.btn_Remove.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Remove.Name = "btn_Remove"
        Me.btn_Remove.Size = New System.Drawing.Size(65, 27)
        Me.btn_Remove.TabIndex = 135
        Me.btn_Remove.Text = "-"
        Me.btn_Remove.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Remove.UseVisualStyleBackColor = False
        '
        'Btn_Add
        '
        Me.Btn_Add.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Btn_Add.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Add.ForeColor = System.Drawing.Color.White
        Me.Btn_Add.Location = New System.Drawing.Point(266, 130)
        Me.Btn_Add.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(62, 27)
        Me.Btn_Add.TabIndex = 134
        Me.Btn_Add.Text = "+"
        Me.Btn_Add.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Add.UseVisualStyleBackColor = False
        '
        'txtsalesQuantity
        '
        Me.txtsalesQuantity.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsalesQuantity.Location = New System.Drawing.Point(330, 129)
        Me.txtsalesQuantity.Name = "txtsalesQuantity"
        Me.txtsalesQuantity.Size = New System.Drawing.Size(68, 25)
        Me.txtsalesQuantity.TabIndex = 133
        Me.txtsalesQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboItem
        '
        Me.cboItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboItem.FormattingEnabled = True
        Me.cboItem.Location = New System.Drawing.Point(266, 95)
        Me.cboItem.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboItem.Name = "cboItem"
        Me.cboItem.Size = New System.Drawing.Size(203, 27)
        Me.cboItem.TabIndex = 132
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(151, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 41)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "SALES and ORDER"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(71, 166)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 20)
        Me.Label4.TabIndex = 128
        Me.Label4.Text = "Cost"
        '
        'txtCost
        '
        Me.txtCost.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCost.Location = New System.Drawing.Point(266, 165)
        Me.txtCost.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(203, 27)
        Me.txtCost.TabIndex = 129
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(71, 133)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 20)
        Me.Label5.TabIndex = 127
        Me.Label5.Text = "Quantity"
        '
        'DataGrid_Sales
        '
        Me.DataGrid_Sales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGrid_Sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_Sales.Location = New System.Drawing.Point(75, 342)
        Me.DataGrid_Sales.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGrid_Sales.Name = "DataGrid_Sales"
        Me.DataGrid_Sales.Size = New System.Drawing.Size(473, 138)
        Me.DataGrid_Sales.TabIndex = 130
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(71, 97)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 20)
        Me.Label6.TabIndex = 126
        Me.Label6.Text = "Item"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(581, 636)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(128, 32)
        Me.btnExit.TabIndex = 147
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Sales_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SandyBrown
        Me.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.sales1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1265, 679)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Btn_Show)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_GrandTotal)
        Me.Controls.Add(Me.btn_AddToBill)
        Me.Controls.Add(Me.btn_NewOrder)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Btn_Print)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Btn_Clear)
        Me.Controls.Add(Me.DataGrid_Order)
        Me.Controls.Add(Me.btn_Remove)
        Me.Controls.Add(Me.Btn_Add)
        Me.Controls.Add(Me.txtsalesQuantity)
        Me.Controls.Add(Me.cboItem)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGrid_Sales)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnInsert)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Sales_Details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales_Details"
        CType(Me.DataGrid_Order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid_Sales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnInsert As Button
    Friend WithEvents Btn_Show As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_GrandTotal As Button
    Friend WithEvents btn_AddToBill As Button
    Friend WithEvents btn_NewOrder As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Btn_Print As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Btn_Clear As Button
    Friend WithEvents DataGrid_Order As DataGridView
    Friend WithEvents btn_Remove As Button
    Friend WithEvents Btn_Add As Button
    Friend WithEvents txtsalesQuantity As TextBox
    Friend WithEvents cboItem As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCost As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGrid_Sales As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents btnExit As Button
End Class

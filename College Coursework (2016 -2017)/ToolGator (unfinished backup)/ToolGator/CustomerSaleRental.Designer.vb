<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerSaleRental
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
        Me.btnBrowseTool = New System.Windows.Forms.Button()
        Me.txtToolID = New System.Windows.Forms.TextBox()
        Me.txtManufacturer = New System.Windows.Forms.TextBox()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblToolID = New System.Windows.Forms.Label()
        Me.lblManufacturer = New System.Windows.Forms.Label()
        Me.lblCateory = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.imgDisplay = New System.Windows.Forms.PictureBox()
        Me.grpRental = New System.Windows.Forms.GroupBox()
        Me.lblReturn = New System.Windows.Forms.Label()
        Me.lblCurrentDate = New System.Windows.Forms.Label()
        Me.timDueDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.txtTakeoutDate = New System.Windows.Forms.TextBox()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.btnVerifyAdd = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grpSaleControls = New System.Windows.Forms.GroupBox()
        Me.lblToolPriceSale = New System.Windows.Forms.Label()
        Me.txtToolPriceSale = New System.Windows.Forms.TextBox()
        Me.grpLoyalty = New System.Windows.Forms.GroupBox()
        Me.lblPointsToSpend = New System.Windows.Forms.Label()
        Me.txtPointsToSpend = New System.Windows.Forms.TextBox()
        Me.lblPointsToBeGained = New System.Windows.Forms.Label()
        Me.txtPointsToBeGained = New System.Windows.Forms.TextBox()
        Me.lblCurrentPoints = New System.Windows.Forms.Label()
        Me.txtCurrentLoyaltyPoints = New System.Windows.Forms.TextBox()
        Me.grpConfirmTransaction = New System.Windows.Forms.GroupBox()
        Me.btnConfirmTransaction = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPriceToPayIncVAT = New System.Windows.Forms.TextBox()
        Me.lblPriceToPayExVat = New System.Windows.Forms.Label()
        Me.txtPriceToPayExVAT = New System.Windows.Forms.TextBox()
        CType(Me.imgDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRental.SuspendLayout()
        Me.grpSaleControls.SuspendLayout()
        Me.grpLoyalty.SuspendLayout()
        Me.grpConfirmTransaction.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBrowseTool
        '
        Me.btnBrowseTool.Location = New System.Drawing.Point(34, 40)
        Me.btnBrowseTool.Name = "btnBrowseTool"
        Me.btnBrowseTool.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseTool.TabIndex = 0
        Me.btnBrowseTool.Text = "Browse Tool"
        Me.btnBrowseTool.UseVisualStyleBackColor = True
        '
        'txtToolID
        '
        Me.txtToolID.Location = New System.Drawing.Point(34, 83)
        Me.txtToolID.Name = "txtToolID"
        Me.txtToolID.ReadOnly = True
        Me.txtToolID.Size = New System.Drawing.Size(100, 20)
        Me.txtToolID.TabIndex = 1
        '
        'txtManufacturer
        '
        Me.txtManufacturer.Location = New System.Drawing.Point(34, 122)
        Me.txtManufacturer.Name = "txtManufacturer"
        Me.txtManufacturer.ReadOnly = True
        Me.txtManufacturer.Size = New System.Drawing.Size(100, 20)
        Me.txtManufacturer.TabIndex = 2
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(34, 160)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.ReadOnly = True
        Me.txtCategory.Size = New System.Drawing.Size(100, 20)
        Me.txtCategory.TabIndex = 3
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(34, 199)
        Me.txtType.Name = "txtType"
        Me.txtType.ReadOnly = True
        Me.txtType.Size = New System.Drawing.Size(100, 20)
        Me.txtType.TabIndex = 4
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(34, 238)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 5
        '
        'lblToolID
        '
        Me.lblToolID.AutoSize = True
        Me.lblToolID.Location = New System.Drawing.Point(140, 86)
        Me.lblToolID.Name = "lblToolID"
        Me.lblToolID.Size = New System.Drawing.Size(42, 13)
        Me.lblToolID.TabIndex = 6
        Me.lblToolID.Text = "Tool ID"
        '
        'lblManufacturer
        '
        Me.lblManufacturer.AutoSize = True
        Me.lblManufacturer.Location = New System.Drawing.Point(140, 125)
        Me.lblManufacturer.Name = "lblManufacturer"
        Me.lblManufacturer.Size = New System.Drawing.Size(70, 13)
        Me.lblManufacturer.TabIndex = 7
        Me.lblManufacturer.Text = "Manufacturer"
        '
        'lblCateory
        '
        Me.lblCateory.AutoSize = True
        Me.lblCateory.Location = New System.Drawing.Point(140, 163)
        Me.lblCateory.Name = "lblCateory"
        Me.lblCateory.Size = New System.Drawing.Size(49, 13)
        Me.lblCateory.TabIndex = 8
        Me.lblCateory.Text = "Category"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(140, 206)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(31, 13)
        Me.lblType.TabIndex = 9
        Me.lblType.Text = "Type"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(140, 238)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 10
        Me.lblName.Text = "Name"
        '
        'imgDisplay
        '
        Me.imgDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgDisplay.Location = New System.Drawing.Point(34, 282)
        Me.imgDisplay.Name = "imgDisplay"
        Me.imgDisplay.Size = New System.Drawing.Size(176, 145)
        Me.imgDisplay.TabIndex = 11
        Me.imgDisplay.TabStop = False
        '
        'grpRental
        '
        Me.grpRental.Controls.Add(Me.lblReturn)
        Me.grpRental.Controls.Add(Me.lblCurrentDate)
        Me.grpRental.Controls.Add(Me.timDueDatePicker)
        Me.grpRental.Controls.Add(Me.txtTakeoutDate)
        Me.grpRental.Controls.Add(Me.lblCustomerName)
        Me.grpRental.Controls.Add(Me.txtCustomerName)
        Me.grpRental.Controls.Add(Me.btnVerifyAdd)
        Me.grpRental.Controls.Add(Me.GroupBox1)
        Me.grpRental.Location = New System.Drawing.Point(252, 40)
        Me.grpRental.Name = "grpRental"
        Me.grpRental.Size = New System.Drawing.Size(228, 179)
        Me.grpRental.TabIndex = 12
        Me.grpRental.TabStop = False
        Me.grpRental.Text = "Rental Controls"
        '
        'lblReturn
        '
        Me.lblReturn.AutoSize = True
        Me.lblReturn.Location = New System.Drawing.Point(6, 118)
        Me.lblReturn.Name = "lblReturn"
        Me.lblReturn.Size = New System.Drawing.Size(66, 13)
        Me.lblReturn.TabIndex = 19
        Me.lblReturn.Text = "Return date:"
        '
        'lblCurrentDate
        '
        Me.lblCurrentDate.AutoSize = True
        Me.lblCurrentDate.Location = New System.Drawing.Point(114, 82)
        Me.lblCurrentDate.Name = "lblCurrentDate"
        Me.lblCurrentDate.Size = New System.Drawing.Size(74, 13)
        Me.lblCurrentDate.TabIndex = 18
        Me.lblCurrentDate.Text = "Take out date"
        '
        'timDueDatePicker
        '
        Me.timDueDatePicker.Enabled = False
        Me.timDueDatePicker.Location = New System.Drawing.Point(6, 134)
        Me.timDueDatePicker.Name = "timDueDatePicker"
        Me.timDueDatePicker.Size = New System.Drawing.Size(200, 20)
        Me.timDueDatePicker.TabIndex = 17
        '
        'txtTakeoutDate
        '
        Me.txtTakeoutDate.Location = New System.Drawing.Point(8, 78)
        Me.txtTakeoutDate.Name = "txtTakeoutDate"
        Me.txtTakeoutDate.ReadOnly = True
        Me.txtTakeoutDate.Size = New System.Drawing.Size(100, 20)
        Me.txtTakeoutDate.TabIndex = 16
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Location = New System.Drawing.Point(114, 53)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(82, 13)
        Me.lblCustomerName.TabIndex = 14
        Me.lblCustomerName.Text = "Customer Name"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(8, 50)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.ReadOnly = True
        Me.txtCustomerName.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerName.TabIndex = 15
        '
        'btnVerifyAdd
        '
        Me.btnVerifyAdd.Enabled = False
        Me.btnVerifyAdd.Location = New System.Drawing.Point(8, 20)
        Me.btnVerifyAdd.Name = "btnVerifyAdd"
        Me.btnVerifyAdd.Size = New System.Drawing.Size(97, 23)
        Me.btnVerifyAdd.TabIndex = 14
        Me.btnVerifyAdd.Text = "Verify customer"
        Me.btnVerifyAdd.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(8, 198)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 145)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rental Controls"
        '
        'grpSaleControls
        '
        Me.grpSaleControls.Controls.Add(Me.lblToolPriceSale)
        Me.grpSaleControls.Controls.Add(Me.txtToolPriceSale)
        Me.grpSaleControls.Location = New System.Drawing.Point(252, 260)
        Me.grpSaleControls.Name = "grpSaleControls"
        Me.grpSaleControls.Size = New System.Drawing.Size(228, 122)
        Me.grpSaleControls.TabIndex = 13
        Me.grpSaleControls.TabStop = False
        Me.grpSaleControls.Text = "Sale Controls"
        '
        'lblToolPriceSale
        '
        Me.lblToolPriceSale.AutoSize = True
        Me.lblToolPriceSale.Location = New System.Drawing.Point(114, 38)
        Me.lblToolPriceSale.Name = "lblToolPriceSale"
        Me.lblToolPriceSale.Size = New System.Drawing.Size(98, 13)
        Me.lblToolPriceSale.TabIndex = 20
        Me.lblToolPriceSale.Text = "Tool price (ex VAT)"
        '
        'txtToolPriceSale
        '
        Me.txtToolPriceSale.Location = New System.Drawing.Point(8, 38)
        Me.txtToolPriceSale.Name = "txtToolPriceSale"
        Me.txtToolPriceSale.ReadOnly = True
        Me.txtToolPriceSale.Size = New System.Drawing.Size(100, 20)
        Me.txtToolPriceSale.TabIndex = 20
        '
        'grpLoyalty
        '
        Me.grpLoyalty.Controls.Add(Me.lblPointsToSpend)
        Me.grpLoyalty.Controls.Add(Me.txtPointsToSpend)
        Me.grpLoyalty.Controls.Add(Me.lblPointsToBeGained)
        Me.grpLoyalty.Controls.Add(Me.txtPointsToBeGained)
        Me.grpLoyalty.Controls.Add(Me.lblCurrentPoints)
        Me.grpLoyalty.Controls.Add(Me.txtCurrentLoyaltyPoints)
        Me.grpLoyalty.Location = New System.Drawing.Point(534, 40)
        Me.grpLoyalty.Name = "grpLoyalty"
        Me.grpLoyalty.Size = New System.Drawing.Size(247, 179)
        Me.grpLoyalty.TabIndex = 14
        Me.grpLoyalty.TabStop = False
        Me.grpLoyalty.Text = "Loyalty Points"
        '
        'lblPointsToSpend
        '
        Me.lblPointsToSpend.AutoSize = True
        Me.lblPointsToSpend.Location = New System.Drawing.Point(112, 118)
        Me.lblPointsToSpend.Name = "lblPointsToSpend"
        Me.lblPointsToSpend.Size = New System.Drawing.Size(82, 13)
        Me.lblPointsToSpend.TabIndex = 24
        Me.lblPointsToSpend.Text = "Points to Spend"
        '
        'txtPointsToSpend
        '
        Me.txtPointsToSpend.Location = New System.Drawing.Point(6, 111)
        Me.txtPointsToSpend.Name = "txtPointsToSpend"
        Me.txtPointsToSpend.Size = New System.Drawing.Size(100, 20)
        Me.txtPointsToSpend.TabIndex = 23
        '
        'lblPointsToBeGained
        '
        Me.lblPointsToBeGained.AutoSize = True
        Me.lblPointsToBeGained.Location = New System.Drawing.Point(112, 82)
        Me.lblPointsToBeGained.Name = "lblPointsToBeGained"
        Me.lblPointsToBeGained.Size = New System.Drawing.Size(100, 13)
        Me.lblPointsToBeGained.TabIndex = 22
        Me.lblPointsToBeGained.Text = "Points to be Gained"
        '
        'txtPointsToBeGained
        '
        Me.txtPointsToBeGained.Location = New System.Drawing.Point(6, 78)
        Me.txtPointsToBeGained.Name = "txtPointsToBeGained"
        Me.txtPointsToBeGained.ReadOnly = True
        Me.txtPointsToBeGained.Size = New System.Drawing.Size(100, 20)
        Me.txtPointsToBeGained.TabIndex = 21
        '
        'lblCurrentPoints
        '
        Me.lblCurrentPoints.AutoSize = True
        Me.lblCurrentPoints.Location = New System.Drawing.Point(112, 49)
        Me.lblCurrentPoints.Name = "lblCurrentPoints"
        Me.lblCurrentPoints.Size = New System.Drawing.Size(109, 13)
        Me.lblCurrentPoints.TabIndex = 20
        Me.lblCurrentPoints.Text = "Current Loyalty Points"
        '
        'txtCurrentLoyaltyPoints
        '
        Me.txtCurrentLoyaltyPoints.Location = New System.Drawing.Point(6, 46)
        Me.txtCurrentLoyaltyPoints.Name = "txtCurrentLoyaltyPoints"
        Me.txtCurrentLoyaltyPoints.ReadOnly = True
        Me.txtCurrentLoyaltyPoints.Size = New System.Drawing.Size(100, 20)
        Me.txtCurrentLoyaltyPoints.TabIndex = 20
        '
        'grpConfirmTransaction
        '
        Me.grpConfirmTransaction.Controls.Add(Me.btnConfirmTransaction)
        Me.grpConfirmTransaction.Controls.Add(Me.Label1)
        Me.grpConfirmTransaction.Controls.Add(Me.txtPriceToPayIncVAT)
        Me.grpConfirmTransaction.Controls.Add(Me.lblPriceToPayExVat)
        Me.grpConfirmTransaction.Controls.Add(Me.txtPriceToPayExVAT)
        Me.grpConfirmTransaction.Location = New System.Drawing.Point(540, 260)
        Me.grpConfirmTransaction.Name = "grpConfirmTransaction"
        Me.grpConfirmTransaction.Size = New System.Drawing.Size(241, 122)
        Me.grpConfirmTransaction.TabIndex = 15
        Me.grpConfirmTransaction.TabStop = False
        Me.grpConfirmTransaction.Text = "Confirm Transaction"
        '
        'btnConfirmTransaction
        '
        Me.btnConfirmTransaction.Location = New System.Drawing.Point(6, 93)
        Me.btnConfirmTransaction.Name = "btnConfirmTransaction"
        Me.btnConfirmTransaction.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirmTransaction.TabIndex = 28
        Me.btnConfirmTransaction.Text = "Confirm"
        Me.btnConfirmTransaction.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(106, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Price to pay (inc VAT)"
        '
        'txtPriceToPayIncVAT
        '
        Me.txtPriceToPayIncVAT.Location = New System.Drawing.Point(6, 66)
        Me.txtPriceToPayIncVAT.Name = "txtPriceToPayIncVAT"
        Me.txtPriceToPayIncVAT.ReadOnly = True
        Me.txtPriceToPayIncVAT.Size = New System.Drawing.Size(100, 20)
        Me.txtPriceToPayIncVAT.TabIndex = 27
        '
        'lblPriceToPayExVat
        '
        Me.lblPriceToPayExVat.AutoSize = True
        Me.lblPriceToPayExVat.Location = New System.Drawing.Point(106, 31)
        Me.lblPriceToPayExVat.Name = "lblPriceToPayExVat"
        Me.lblPriceToPayExVat.Size = New System.Drawing.Size(107, 13)
        Me.lblPriceToPayExVat.TabIndex = 25
        Me.lblPriceToPayExVat.Text = "Price to pay (ex VAT)"
        '
        'txtPriceToPayExVAT
        '
        Me.txtPriceToPayExVAT.Location = New System.Drawing.Point(6, 31)
        Me.txtPriceToPayExVAT.Name = "txtPriceToPayExVAT"
        Me.txtPriceToPayExVAT.ReadOnly = True
        Me.txtPriceToPayExVAT.Size = New System.Drawing.Size(100, 20)
        Me.txtPriceToPayExVAT.TabIndex = 25
        '
        'CustomerSaleRental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1247, 584)
        Me.Controls.Add(Me.grpConfirmTransaction)
        Me.Controls.Add(Me.grpLoyalty)
        Me.Controls.Add(Me.grpSaleControls)
        Me.Controls.Add(Me.grpRental)
        Me.Controls.Add(Me.imgDisplay)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblCateory)
        Me.Controls.Add(Me.lblManufacturer)
        Me.Controls.Add(Me.lblToolID)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.txtManufacturer)
        Me.Controls.Add(Me.txtToolID)
        Me.Controls.Add(Me.btnBrowseTool)
        Me.Name = "CustomerSaleRental"
        Me.Text = "CustomerSaleRental"
        CType(Me.imgDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRental.ResumeLayout(False)
        Me.grpRental.PerformLayout()
        Me.grpSaleControls.ResumeLayout(False)
        Me.grpSaleControls.PerformLayout()
        Me.grpLoyalty.ResumeLayout(False)
        Me.grpLoyalty.PerformLayout()
        Me.grpConfirmTransaction.ResumeLayout(False)
        Me.grpConfirmTransaction.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBrowseTool As Button
    Friend WithEvents txtToolID As TextBox
    Friend WithEvents txtManufacturer As TextBox
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents txtType As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblToolID As Label
    Friend WithEvents lblManufacturer As Label
    Friend WithEvents lblCateory As Label
    Friend WithEvents lblType As Label
    Friend WithEvents lblName As Label
    Friend WithEvents imgDisplay As PictureBox
    Friend WithEvents grpRental As GroupBox
    Friend WithEvents timDueDatePicker As DateTimePicker
    Friend WithEvents txtTakeoutDate As TextBox
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents btnVerifyAdd As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grpSaleControls As GroupBox
    Friend WithEvents lblReturn As Label
    Friend WithEvents lblCurrentDate As Label
    Friend WithEvents lblToolPriceSale As Label
    Friend WithEvents txtToolPriceSale As TextBox
    Friend WithEvents grpLoyalty As GroupBox
    Friend WithEvents lblPointsToSpend As Label
    Friend WithEvents txtPointsToSpend As TextBox
    Friend WithEvents lblPointsToBeGained As Label
    Friend WithEvents txtPointsToBeGained As TextBox
    Friend WithEvents lblCurrentPoints As Label
    Friend WithEvents txtCurrentLoyaltyPoints As TextBox
    Friend WithEvents grpConfirmTransaction As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPriceToPayIncVAT As TextBox
    Friend WithEvents lblPriceToPayExVat As Label
    Friend WithEvents txtPriceToPayExVAT As TextBox
    Friend WithEvents btnConfirmTransaction As Button
End Class

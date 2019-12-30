<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addStock
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
        Me.lblManufacturer = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.btnAddManufacturer = New System.Windows.Forms.Button()
        Me.btnAddToolCategory = New System.Windows.Forms.Button()
        Me.btnAddToolType = New System.Windows.Forms.Button()
        Me.lblToolType = New System.Windows.Forms.Label()
        Me.cmbToolType = New System.Windows.Forms.ComboBox()
        Me.btnImportImage = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.cmbManufacturer = New System.Windows.Forms.ComboBox()
        Me.btnAddTool = New System.Windows.Forms.Button()
        Me.cmbToolName = New System.Windows.Forms.ComboBox()
        Me.lblToolName = New System.Windows.Forms.Label()
        Me.lblSalePrice = New System.Windows.Forms.Label()
        Me.lblSalePriceDescriptor = New System.Windows.Forms.Label()
        Me.cmbSalePrice = New System.Windows.Forms.ComboBox()
        Me.cmbRentalBaseCost = New System.Windows.Forms.ComboBox()
        Me.lblBaseRentalCost = New System.Windows.Forms.Label()
        Me.radSale = New System.Windows.Forms.RadioButton()
        Me.radRental = New System.Windows.Forms.RadioButton()
        Me.btnSelectImage = New System.Windows.Forms.Button()
        Me.iboxToolPreview = New System.Windows.Forms.PictureBox()
        CType(Me.iboxToolPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblManufacturer
        '
        Me.lblManufacturer.AutoSize = True
        Me.lblManufacturer.Location = New System.Drawing.Point(23, 168)
        Me.lblManufacturer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblManufacturer.Name = "lblManufacturer"
        Me.lblManufacturer.Size = New System.Drawing.Size(73, 13)
        Me.lblManufacturer.TabIndex = 1
        Me.lblManufacturer.Text = "Manufacturer:"
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(20, 217)
        Me.lblCategory.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(76, 13)
        Me.lblCategory.TabIndex = 3
        Me.lblCategory.Text = "Tool Category:"
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(97, 214)
        Me.cmbCategory.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(139, 21)
        Me.cmbCategory.TabIndex = 2
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(98, 395)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(2)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(138, 20)
        Me.txtQuantity.TabIndex = 6
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(23, 395)
        Me.lblQuantity.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(49, 13)
        Me.lblQuantity.TabIndex = 7
        Me.lblQuantity.Text = "Quantity:"
        '
        'btnAddManufacturer
        '
        Me.btnAddManufacturer.Location = New System.Drawing.Point(268, 161)
        Me.btnAddManufacturer.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddManufacturer.Name = "btnAddManufacturer"
        Me.btnAddManufacturer.Size = New System.Drawing.Size(112, 28)
        Me.btnAddManufacturer.TabIndex = 8
        Me.btnAddManufacturer.Text = "Add Manufacturer"
        Me.btnAddManufacturer.UseVisualStyleBackColor = True
        '
        'btnAddToolCategory
        '
        Me.btnAddToolCategory.Location = New System.Drawing.Point(268, 210)
        Me.btnAddToolCategory.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddToolCategory.Name = "btnAddToolCategory"
        Me.btnAddToolCategory.Size = New System.Drawing.Size(112, 28)
        Me.btnAddToolCategory.TabIndex = 9
        Me.btnAddToolCategory.Text = "Add Tool Category"
        Me.btnAddToolCategory.UseVisualStyleBackColor = True
        '
        'btnAddToolType
        '
        Me.btnAddToolType.Location = New System.Drawing.Point(268, 259)
        Me.btnAddToolType.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddToolType.Name = "btnAddToolType"
        Me.btnAddToolType.Size = New System.Drawing.Size(112, 28)
        Me.btnAddToolType.TabIndex = 12
        Me.btnAddToolType.Text = "Add Tool Type"
        Me.btnAddToolType.UseVisualStyleBackColor = True
        '
        'lblToolType
        '
        Me.lblToolType.AutoSize = True
        Me.lblToolType.Location = New System.Drawing.Point(20, 266)
        Me.lblToolType.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblToolType.Name = "lblToolType"
        Me.lblToolType.Size = New System.Drawing.Size(58, 13)
        Me.lblToolType.TabIndex = 11
        Me.lblToolType.Text = "Tool Type:"
        '
        'cmbToolType
        '
        Me.cmbToolType.FormattingEnabled = True
        Me.cmbToolType.Location = New System.Drawing.Point(97, 264)
        Me.cmbToolType.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbToolType.Name = "cmbToolType"
        Me.cmbToolType.Size = New System.Drawing.Size(139, 21)
        Me.cmbToolType.TabIndex = 10
        '
        'btnImportImage
        '
        Me.btnImportImage.Location = New System.Drawing.Point(668, 28)
        Me.btnImportImage.Margin = New System.Windows.Forms.Padding(2)
        Me.btnImportImage.Name = "btnImportImage"
        Me.btnImportImage.Size = New System.Drawing.Size(99, 29)
        Me.btnImportImage.TabIndex = 13
        Me.btnImportImage.Text = "Import Images"
        Me.btnImportImage.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(97, 105)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(82, 36)
        Me.btnRefresh.TabIndex = 14
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'cmbManufacturer
        '
        Me.cmbManufacturer.FormattingEnabled = True
        Me.cmbManufacturer.Location = New System.Drawing.Point(96, 166)
        Me.cmbManufacturer.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbManufacturer.Name = "cmbManufacturer"
        Me.cmbManufacturer.Size = New System.Drawing.Size(139, 21)
        Me.cmbManufacturer.TabIndex = 15
        '
        'btnAddTool
        '
        Me.btnAddTool.Location = New System.Drawing.Point(90, 448)
        Me.btnAddTool.Name = "btnAddTool"
        Me.btnAddTool.Size = New System.Drawing.Size(159, 41)
        Me.btnAddTool.TabIndex = 16
        Me.btnAddTool.Text = "Add to Inventory"
        Me.btnAddTool.UseVisualStyleBackColor = True
        '
        'cmbToolName
        '
        Me.cmbToolName.FormattingEnabled = True
        Me.cmbToolName.Location = New System.Drawing.Point(95, 301)
        Me.cmbToolName.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbToolName.Name = "cmbToolName"
        Me.cmbToolName.Size = New System.Drawing.Size(140, 21)
        Me.cmbToolName.TabIndex = 17
        '
        'lblToolName
        '
        Me.lblToolName.AutoSize = True
        Me.lblToolName.Location = New System.Drawing.Point(20, 307)
        Me.lblToolName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblToolName.Name = "lblToolName"
        Me.lblToolName.Size = New System.Drawing.Size(59, 13)
        Me.lblToolName.TabIndex = 18
        Me.lblToolName.Text = "Tool Name"
        '
        'lblSalePrice
        '
        Me.lblSalePrice.AutoSize = True
        Me.lblSalePrice.Location = New System.Drawing.Point(23, 362)
        Me.lblSalePrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSalePrice.Name = "lblSalePrice"
        Me.lblSalePrice.Size = New System.Drawing.Size(55, 13)
        Me.lblSalePrice.TabIndex = 20
        Me.lblSalePrice.Text = "Sale Price"
        '
        'lblSalePriceDescriptor
        '
        Me.lblSalePriceDescriptor.AutoSize = True
        Me.lblSalePriceDescriptor.Location = New System.Drawing.Point(241, 363)
        Me.lblSalePriceDescriptor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSalePriceDescriptor.Name = "lblSalePriceDescriptor"
        Me.lblSalePriceDescriptor.Size = New System.Drawing.Size(99, 13)
        Me.lblSalePriceDescriptor.TabIndex = 21
        Me.lblSalePriceDescriptor.Text = "Sale Price (ex VAT)"
        '
        'cmbSalePrice
        '
        Me.cmbSalePrice.Enabled = False
        Me.cmbSalePrice.FormattingEnabled = True
        Me.cmbSalePrice.Location = New System.Drawing.Point(97, 360)
        Me.cmbSalePrice.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbSalePrice.Name = "cmbSalePrice"
        Me.cmbSalePrice.Size = New System.Drawing.Size(140, 21)
        Me.cmbSalePrice.TabIndex = 19
        '
        'cmbRentalBaseCost
        '
        Me.cmbRentalBaseCost.Enabled = False
        Me.cmbRentalBaseCost.FormattingEnabled = True
        Me.cmbRentalBaseCost.Location = New System.Drawing.Point(465, 360)
        Me.cmbRentalBaseCost.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbRentalBaseCost.Name = "cmbRentalBaseCost"
        Me.cmbRentalBaseCost.Size = New System.Drawing.Size(140, 21)
        Me.cmbRentalBaseCost.TabIndex = 22
        '
        'lblBaseRentalCost
        '
        Me.lblBaseRentalCost.AutoSize = True
        Me.lblBaseRentalCost.Location = New System.Drawing.Point(372, 362)
        Me.lblBaseRentalCost.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBaseRentalCost.Name = "lblBaseRentalCost"
        Me.lblBaseRentalCost.Size = New System.Drawing.Size(89, 13)
        Me.lblBaseRentalCost.TabIndex = 23
        Me.lblBaseRentalCost.Text = "Base Rental Cost"
        '
        'radSale
        '
        Me.radSale.AutoSize = True
        Me.radSale.Location = New System.Drawing.Point(90, 338)
        Me.radSale.Name = "radSale"
        Me.radSale.Size = New System.Drawing.Size(46, 17)
        Me.radSale.TabIndex = 24
        Me.radSale.TabStop = True
        Me.radSale.Text = "Sale"
        Me.radSale.UseVisualStyleBackColor = True
        '
        'radRental
        '
        Me.radRental.AutoSize = True
        Me.radRental.Location = New System.Drawing.Point(170, 338)
        Me.radRental.Name = "radRental"
        Me.radRental.Size = New System.Drawing.Size(56, 17)
        Me.radRental.TabIndex = 25
        Me.radRental.TabStop = True
        Me.radRental.Text = "Rental"
        Me.radRental.UseVisualStyleBackColor = True
        '
        'btnSelectImage
        '
        Me.btnSelectImage.Location = New System.Drawing.Point(668, 59)
        Me.btnSelectImage.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSelectImage.Name = "btnSelectImage"
        Me.btnSelectImage.Size = New System.Drawing.Size(99, 26)
        Me.btnSelectImage.TabIndex = 26
        Me.btnSelectImage.Text = "Tool Image"
        Me.btnSelectImage.UseVisualStyleBackColor = True
        '
        'iboxToolPreview
        '
        Me.iboxToolPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.iboxToolPreview.Location = New System.Drawing.Point(575, 106)
        Me.iboxToolPreview.Name = "iboxToolPreview"
        Me.iboxToolPreview.Size = New System.Drawing.Size(191, 173)
        Me.iboxToolPreview.TabIndex = 27
        Me.iboxToolPreview.TabStop = False
        '
        'addStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 580)
        Me.Controls.Add(Me.iboxToolPreview)
        Me.Controls.Add(Me.btnSelectImage)
        Me.Controls.Add(Me.radRental)
        Me.Controls.Add(Me.radSale)
        Me.Controls.Add(Me.lblBaseRentalCost)
        Me.Controls.Add(Me.cmbRentalBaseCost)
        Me.Controls.Add(Me.lblSalePriceDescriptor)
        Me.Controls.Add(Me.lblSalePrice)
        Me.Controls.Add(Me.cmbSalePrice)
        Me.Controls.Add(Me.lblToolName)
        Me.Controls.Add(Me.cmbToolName)
        Me.Controls.Add(Me.btnAddTool)
        Me.Controls.Add(Me.cmbManufacturer)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnImportImage)
        Me.Controls.Add(Me.btnAddToolType)
        Me.Controls.Add(Me.lblToolType)
        Me.Controls.Add(Me.cmbToolType)
        Me.Controls.Add(Me.btnAddToolCategory)
        Me.Controls.Add(Me.btnAddManufacturer)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.lblManufacturer)
        Me.Name = "addStock"
        Me.Text = "Add New Stock"
        CType(Me.iboxToolPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblManufacturer As System.Windows.Forms.Label
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents btnAddManufacturer As System.Windows.Forms.Button
    Friend WithEvents btnAddToolCategory As System.Windows.Forms.Button
    Friend WithEvents btnAddToolType As System.Windows.Forms.Button
    Friend WithEvents lblToolType As System.Windows.Forms.Label
    Friend WithEvents cmbToolType As System.Windows.Forms.ComboBox
    Friend WithEvents btnImportImage As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents cmbManufacturer As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddTool As System.Windows.Forms.Button
    Friend WithEvents cmbToolName As System.Windows.Forms.ComboBox
    Friend WithEvents lblToolName As System.Windows.Forms.Label
    Friend WithEvents lblSalePrice As System.Windows.Forms.Label
    Friend WithEvents lblSalePriceDescriptor As System.Windows.Forms.Label
    Friend WithEvents cmbSalePrice As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRentalBaseCost As System.Windows.Forms.ComboBox
    Friend WithEvents lblBaseRentalCost As System.Windows.Forms.Label
    Friend WithEvents radSale As System.Windows.Forms.RadioButton
    Friend WithEvents radRental As System.Windows.Forms.RadioButton
    Friend WithEvents btnSelectImage As System.Windows.Forms.Button
    Friend WithEvents iboxToolPreview As System.Windows.Forms.PictureBox
End Class

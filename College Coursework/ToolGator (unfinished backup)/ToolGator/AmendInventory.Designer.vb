<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AmendInventory
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
        Me.btnPopulate = New System.Windows.Forms.Button()
        Me.radRental = New System.Windows.Forms.RadioButton()
        Me.radSale = New System.Windows.Forms.RadioButton()
        Me.grpStaticFilters = New System.Windows.Forms.GroupBox()
        Me.grpAdditionalFilter = New System.Windows.Forms.GroupBox()
        Me.cmbTypeFilter = New System.Windows.Forms.ComboBox()
        Me.chkTypeFilter = New System.Windows.Forms.CheckBox()
        Me.cmbCategoryFilter = New System.Windows.Forms.ComboBox()
        Me.chkCategoryFilter = New System.Windows.Forms.CheckBox()
        Me.cmbManufacturerFilter = New System.Windows.Forms.ComboBox()
        Me.chkManufacturerFilter = New System.Windows.Forms.CheckBox()
        Me.chkToolIDFilter = New System.Windows.Forms.CheckBox()
        Me.txtIToolDFilter = New System.Windows.Forms.TextBox()
        Me.tblInventory = New System.Windows.Forms.DataGridView()
        Me.clmToolID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmManufacturer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmBaseCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmImageFilePath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDamageNotes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCurrentlyRented = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.cmbNewManufacturer = New System.Windows.Forms.ComboBox()
        Me.cmbNewCategory = New System.Windows.Forms.ComboBox()
        Me.cmbNewType = New System.Windows.Forms.ComboBox()
        Me.cmbNewName = New System.Windows.Forms.ComboBox()
        Me.cmbNewBaseCost = New System.Windows.Forms.ComboBox()
        Me.txtNewImagePath = New System.Windows.Forms.TextBox()
        Me.grpNewState = New System.Windows.Forms.GroupBox()
        Me.radNewRental = New System.Windows.Forms.RadioButton()
        Me.radNewSale = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.lblNewNotes = New System.Windows.Forms.Label()
        Me.txtNewNotes = New System.Windows.Forms.TextBox()
        Me.btnSelectToolSaleRental = New System.Windows.Forms.Button()
        Me.grpStaticFilters.SuspendLayout()
        Me.grpAdditionalFilter.SuspendLayout()
        CType(Me.tblInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpNewState.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPopulate
        '
        Me.btnPopulate.Location = New System.Drawing.Point(21, 544)
        Me.btnPopulate.Name = "btnPopulate"
        Me.btnPopulate.Size = New System.Drawing.Size(68, 43)
        Me.btnPopulate.TabIndex = 1
        Me.btnPopulate.Text = "Populate Table"
        Me.btnPopulate.UseVisualStyleBackColor = True
        '
        'radRental
        '
        Me.radRental.AutoSize = True
        Me.radRental.Location = New System.Drawing.Point(18, 60)
        Me.radRental.Name = "radRental"
        Me.radRental.Size = New System.Drawing.Size(82, 17)
        Me.radRental.TabIndex = 2
        Me.radRental.TabStop = True
        Me.radRental.Text = "View Rental"
        Me.radRental.UseVisualStyleBackColor = True
        '
        'radSale
        '
        Me.radSale.AutoSize = True
        Me.radSale.Checked = True
        Me.radSale.Location = New System.Drawing.Point(18, 37)
        Me.radSale.Name = "radSale"
        Me.radSale.Size = New System.Drawing.Size(72, 17)
        Me.radSale.TabIndex = 3
        Me.radSale.TabStop = True
        Me.radSale.Text = "View Sale"
        Me.radSale.UseVisualStyleBackColor = True
        '
        'grpStaticFilters
        '
        Me.grpStaticFilters.Controls.Add(Me.radSale)
        Me.grpStaticFilters.Controls.Add(Me.radRental)
        Me.grpStaticFilters.Location = New System.Drawing.Point(15, 34)
        Me.grpStaticFilters.Name = "grpStaticFilters"
        Me.grpStaticFilters.Size = New System.Drawing.Size(155, 95)
        Me.grpStaticFilters.TabIndex = 5
        Me.grpStaticFilters.TabStop = False
        Me.grpStaticFilters.Text = "Static Filters"
        '
        'grpAdditionalFilter
        '
        Me.grpAdditionalFilter.Controls.Add(Me.cmbTypeFilter)
        Me.grpAdditionalFilter.Controls.Add(Me.chkTypeFilter)
        Me.grpAdditionalFilter.Controls.Add(Me.cmbCategoryFilter)
        Me.grpAdditionalFilter.Controls.Add(Me.chkCategoryFilter)
        Me.grpAdditionalFilter.Controls.Add(Me.cmbManufacturerFilter)
        Me.grpAdditionalFilter.Controls.Add(Me.chkManufacturerFilter)
        Me.grpAdditionalFilter.Controls.Add(Me.chkToolIDFilter)
        Me.grpAdditionalFilter.Controls.Add(Me.txtIToolDFilter)
        Me.grpAdditionalFilter.Location = New System.Drawing.Point(15, 175)
        Me.grpAdditionalFilter.Name = "grpAdditionalFilter"
        Me.grpAdditionalFilter.Size = New System.Drawing.Size(155, 253)
        Me.grpAdditionalFilter.TabIndex = 6
        Me.grpAdditionalFilter.TabStop = False
        Me.grpAdditionalFilter.Text = "Additional Filters:"
        '
        'cmbTypeFilter
        '
        Me.cmbTypeFilter.Enabled = False
        Me.cmbTypeFilter.FormattingEnabled = True
        Me.cmbTypeFilter.Location = New System.Drawing.Point(18, 182)
        Me.cmbTypeFilter.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbTypeFilter.Name = "cmbTypeFilter"
        Me.cmbTypeFilter.Size = New System.Drawing.Size(110, 21)
        Me.cmbTypeFilter.TabIndex = 12
        '
        'chkTypeFilter
        '
        Me.chkTypeFilter.AutoSize = True
        Me.chkTypeFilter.Location = New System.Drawing.Point(18, 160)
        Me.chkTypeFilter.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkTypeFilter.Name = "chkTypeFilter"
        Me.chkTypeFilter.Size = New System.Drawing.Size(50, 17)
        Me.chkTypeFilter.TabIndex = 11
        Me.chkTypeFilter.Text = "Type"
        Me.chkTypeFilter.UseVisualStyleBackColor = True
        '
        'cmbCategoryFilter
        '
        Me.cmbCategoryFilter.Enabled = False
        Me.cmbCategoryFilter.FormattingEnabled = True
        Me.cmbCategoryFilter.Location = New System.Drawing.Point(18, 136)
        Me.cmbCategoryFilter.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbCategoryFilter.Name = "cmbCategoryFilter"
        Me.cmbCategoryFilter.Size = New System.Drawing.Size(110, 21)
        Me.cmbCategoryFilter.TabIndex = 10
        '
        'chkCategoryFilter
        '
        Me.chkCategoryFilter.AutoSize = True
        Me.chkCategoryFilter.Location = New System.Drawing.Point(18, 114)
        Me.chkCategoryFilter.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkCategoryFilter.Name = "chkCategoryFilter"
        Me.chkCategoryFilter.Size = New System.Drawing.Size(68, 17)
        Me.chkCategoryFilter.TabIndex = 9
        Me.chkCategoryFilter.Text = "Category"
        Me.chkCategoryFilter.UseVisualStyleBackColor = True
        '
        'cmbManufacturerFilter
        '
        Me.cmbManufacturerFilter.Enabled = False
        Me.cmbManufacturerFilter.FormattingEnabled = True
        Me.cmbManufacturerFilter.Location = New System.Drawing.Point(18, 89)
        Me.cmbManufacturerFilter.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbManufacturerFilter.Name = "cmbManufacturerFilter"
        Me.cmbManufacturerFilter.Size = New System.Drawing.Size(110, 21)
        Me.cmbManufacturerFilter.TabIndex = 8
        '
        'chkManufacturerFilter
        '
        Me.chkManufacturerFilter.AutoSize = True
        Me.chkManufacturerFilter.Location = New System.Drawing.Point(18, 67)
        Me.chkManufacturerFilter.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkManufacturerFilter.Name = "chkManufacturerFilter"
        Me.chkManufacturerFilter.Size = New System.Drawing.Size(89, 17)
        Me.chkManufacturerFilter.TabIndex = 7
        Me.chkManufacturerFilter.Text = "Manufacturer"
        Me.chkManufacturerFilter.UseVisualStyleBackColor = True
        '
        'chkToolIDFilter
        '
        Me.chkToolIDFilter.AutoSize = True
        Me.chkToolIDFilter.Location = New System.Drawing.Point(18, 22)
        Me.chkToolIDFilter.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkToolIDFilter.Name = "chkToolIDFilter"
        Me.chkToolIDFilter.Size = New System.Drawing.Size(61, 17)
        Me.chkToolIDFilter.TabIndex = 6
        Me.chkToolIDFilter.Text = "Tool ID"
        Me.chkToolIDFilter.UseVisualStyleBackColor = True
        '
        'txtIToolDFilter
        '
        Me.txtIToolDFilter.Enabled = False
        Me.txtIToolDFilter.Location = New System.Drawing.Point(18, 44)
        Me.txtIToolDFilter.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtIToolDFilter.Name = "txtIToolDFilter"
        Me.txtIToolDFilter.Size = New System.Drawing.Size(110, 20)
        Me.txtIToolDFilter.TabIndex = 5
        '
        'tblInventory
        '
        Me.tblInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblInventory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmToolID, Me.clmManufacturer, Me.clmCategory, Me.clmType, Me.clmName, Me.clmStatus, Me.clmBaseCost, Me.clmImageFilePath, Me.clmDamageNotes, Me.clmCurrentlyRented})
        Me.tblInventory.Location = New System.Drawing.Point(188, 34)
        Me.tblInventory.Name = "tblInventory"
        Me.tblInventory.Size = New System.Drawing.Size(838, 553)
        Me.tblInventory.TabIndex = 7
        '
        'clmToolID
        '
        Me.clmToolID.HeaderText = "Tool ID"
        Me.clmToolID.Name = "clmToolID"
        '
        'clmManufacturer
        '
        Me.clmManufacturer.HeaderText = "Manufacturer"
        Me.clmManufacturer.Name = "clmManufacturer"
        '
        'clmCategory
        '
        Me.clmCategory.HeaderText = "Category"
        Me.clmCategory.Name = "clmCategory"
        '
        'clmType
        '
        Me.clmType.HeaderText = "Type"
        Me.clmType.Name = "clmType"
        '
        'clmName
        '
        Me.clmName.HeaderText = "Name"
        Me.clmName.Name = "clmName"
        '
        'clmStatus
        '
        Me.clmStatus.HeaderText = "Sale/Rental"
        Me.clmStatus.Name = "clmStatus"
        '
        'clmBaseCost
        '
        Me.clmBaseCost.HeaderText = "Base Cost"
        Me.clmBaseCost.Name = "clmBaseCost"
        '
        'clmImageFilePath
        '
        Me.clmImageFilePath.HeaderText = "Image path"
        Me.clmImageFilePath.Name = "clmImageFilePath"
        '
        'clmDamageNotes
        '
        Me.clmDamageNotes.HeaderText = "Notes"
        Me.clmDamageNotes.Name = "clmDamageNotes"
        '
        'clmCurrentlyRented
        '
        Me.clmCurrentlyRented.HeaderText = "Currently Rented"
        Me.clmCurrentlyRented.Name = "clmCurrentlyRented"
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(1052, 540)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(103, 43)
        Me.btnConfirm.TabIndex = 8
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'cmbNewManufacturer
        '
        Me.cmbNewManufacturer.FormattingEnabled = True
        Me.cmbNewManufacturer.Location = New System.Drawing.Point(1046, 124)
        Me.cmbNewManufacturer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbNewManufacturer.Name = "cmbNewManufacturer"
        Me.cmbNewManufacturer.Size = New System.Drawing.Size(110, 21)
        Me.cmbNewManufacturer.TabIndex = 13
        '
        'cmbNewCategory
        '
        Me.cmbNewCategory.FormattingEnabled = True
        Me.cmbNewCategory.Location = New System.Drawing.Point(1046, 171)
        Me.cmbNewCategory.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbNewCategory.Name = "cmbNewCategory"
        Me.cmbNewCategory.Size = New System.Drawing.Size(110, 21)
        Me.cmbNewCategory.TabIndex = 14
        '
        'cmbNewType
        '
        Me.cmbNewType.FormattingEnabled = True
        Me.cmbNewType.Location = New System.Drawing.Point(1046, 223)
        Me.cmbNewType.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbNewType.Name = "cmbNewType"
        Me.cmbNewType.Size = New System.Drawing.Size(110, 21)
        Me.cmbNewType.TabIndex = 15
        '
        'cmbNewName
        '
        Me.cmbNewName.FormattingEnabled = True
        Me.cmbNewName.Location = New System.Drawing.Point(1046, 275)
        Me.cmbNewName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbNewName.Name = "cmbNewName"
        Me.cmbNewName.Size = New System.Drawing.Size(110, 21)
        Me.cmbNewName.TabIndex = 16
        '
        'cmbNewBaseCost
        '
        Me.cmbNewBaseCost.FormattingEnabled = True
        Me.cmbNewBaseCost.Location = New System.Drawing.Point(1046, 328)
        Me.cmbNewBaseCost.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbNewBaseCost.Name = "cmbNewBaseCost"
        Me.cmbNewBaseCost.Size = New System.Drawing.Size(110, 21)
        Me.cmbNewBaseCost.TabIndex = 17
        '
        'txtNewImagePath
        '
        Me.txtNewImagePath.Location = New System.Drawing.Point(1046, 384)
        Me.txtNewImagePath.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNewImagePath.Name = "txtNewImagePath"
        Me.txtNewImagePath.Size = New System.Drawing.Size(110, 20)
        Me.txtNewImagePath.TabIndex = 13
        '
        'grpNewState
        '
        Me.grpNewState.Controls.Add(Me.radNewRental)
        Me.grpNewState.Controls.Add(Me.radNewSale)
        Me.grpNewState.Location = New System.Drawing.Point(1046, 424)
        Me.grpNewState.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpNewState.Name = "grpNewState"
        Me.grpNewState.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpNewState.Size = New System.Drawing.Size(150, 81)
        Me.grpNewState.TabIndex = 18
        Me.grpNewState.TabStop = False
        Me.grpNewState.Text = "New Sale/Rental State"
        '
        'radNewRental
        '
        Me.radNewRental.AutoSize = True
        Me.radNewRental.Location = New System.Drawing.Point(7, 47)
        Me.radNewRental.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.radNewRental.Name = "radNewRental"
        Me.radNewRental.Size = New System.Drawing.Size(56, 17)
        Me.radNewRental.TabIndex = 1
        Me.radNewRental.TabStop = True
        Me.radNewRental.Text = "Rental"
        Me.radNewRental.UseVisualStyleBackColor = True
        '
        'radNewSale
        '
        Me.radNewSale.AutoSize = True
        Me.radNewSale.Location = New System.Drawing.Point(7, 25)
        Me.radNewSale.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.radNewSale.Name = "radNewSale"
        Me.radNewSale.Size = New System.Drawing.Size(46, 17)
        Me.radNewSale.TabIndex = 0
        Me.radNewSale.TabStop = True
        Me.radNewSale.Text = "Sale"
        Me.radNewSale.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1043, 107)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "New Manufacturer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1043, 154)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "New Category"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1043, 207)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "New Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1043, 258)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "New Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1048, 312)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "New Base Cost"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1043, 368)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "New Image Path"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(1160, 384)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(90, 28)
        Me.btnBrowse.TabIndex = 25
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(1256, 124)
        Me.txtNotes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ReadOnly = True
        Me.txtNotes.Size = New System.Drawing.Size(200, 229)
        Me.txtNotes.TabIndex = 26
        Me.txtNotes.TabStop = False
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Location = New System.Drawing.Point(1254, 107)
        Me.lblNotes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(35, 13)
        Me.lblNotes.TabIndex = 27
        Me.lblNotes.Text = "Notes"
        '
        'lblNewNotes
        '
        Me.lblNewNotes.AutoSize = True
        Me.lblNewNotes.Location = New System.Drawing.Point(1254, 354)
        Me.lblNewNotes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNewNotes.Name = "lblNewNotes"
        Me.lblNewNotes.Size = New System.Drawing.Size(60, 13)
        Me.lblNewNotes.TabIndex = 28
        Me.lblNewNotes.Text = "New Notes"
        '
        'txtNewNotes
        '
        Me.txtNewNotes.Location = New System.Drawing.Point(1256, 370)
        Me.txtNewNotes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNewNotes.Multiline = True
        Me.txtNewNotes.Name = "txtNewNotes"
        Me.txtNewNotes.Size = New System.Drawing.Size(200, 97)
        Me.txtNewNotes.TabIndex = 29
        '
        'btnSelectToolSaleRental
        '
        Me.btnSelectToolSaleRental.Enabled = False
        Me.btnSelectToolSaleRental.Location = New System.Drawing.Point(1046, 34)
        Me.btnSelectToolSaleRental.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSelectToolSaleRental.Name = "btnSelectToolSaleRental"
        Me.btnSelectToolSaleRental.Size = New System.Drawing.Size(103, 43)
        Me.btnSelectToolSaleRental.TabIndex = 30
        Me.btnSelectToolSaleRental.Text = "Select Tool"
        Me.btnSelectToolSaleRental.UseVisualStyleBackColor = True
        '
        'AmendInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1443, 739)
        Me.Controls.Add(Me.btnSelectToolSaleRental)
        Me.Controls.Add(Me.txtNewNotes)
        Me.Controls.Add(Me.lblNewNotes)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpNewState)
        Me.Controls.Add(Me.txtNewImagePath)
        Me.Controls.Add(Me.cmbNewBaseCost)
        Me.Controls.Add(Me.cmbNewName)
        Me.Controls.Add(Me.cmbNewType)
        Me.Controls.Add(Me.cmbNewCategory)
        Me.Controls.Add(Me.cmbNewManufacturer)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.tblInventory)
        Me.Controls.Add(Me.grpAdditionalFilter)
        Me.Controls.Add(Me.grpStaticFilters)
        Me.Controls.Add(Me.btnPopulate)
        Me.Name = "AmendInventory"
        Me.Text = "AmendInventory"
        Me.grpStaticFilters.ResumeLayout(False)
        Me.grpStaticFilters.PerformLayout()
        Me.grpAdditionalFilter.ResumeLayout(False)
        Me.grpAdditionalFilter.PerformLayout()
        CType(Me.tblInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpNewState.ResumeLayout(False)
        Me.grpNewState.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPopulate As System.Windows.Forms.Button
    Friend WithEvents radRental As System.Windows.Forms.RadioButton
    Friend WithEvents radSale As System.Windows.Forms.RadioButton
    Friend WithEvents grpStaticFilters As System.Windows.Forms.GroupBox
    Friend WithEvents grpAdditionalFilter As System.Windows.Forms.GroupBox
    Friend WithEvents tblInventory As DataGridView
    Friend WithEvents clmToolID As DataGridViewTextBoxColumn
    Friend WithEvents clmManufacturer As DataGridViewTextBoxColumn
    Friend WithEvents clmCategory As DataGridViewTextBoxColumn
    Friend WithEvents clmType As DataGridViewTextBoxColumn
    Friend WithEvents clmName As DataGridViewTextBoxColumn
    Friend WithEvents clmStatus As DataGridViewTextBoxColumn
    Friend WithEvents clmBaseCost As DataGridViewTextBoxColumn
    Friend WithEvents clmImageFilePath As DataGridViewTextBoxColumn
    Friend WithEvents clmDamageNotes As DataGridViewTextBoxColumn
    Friend WithEvents clmCurrentlyRented As DataGridViewTextBoxColumn
    Friend WithEvents cmbTypeFilter As ComboBox
    Friend WithEvents chkTypeFilter As CheckBox
    Friend WithEvents cmbCategoryFilter As ComboBox
    Friend WithEvents chkCategoryFilter As CheckBox
    Friend WithEvents cmbManufacturerFilter As ComboBox
    Friend WithEvents chkManufacturerFilter As CheckBox
    Friend WithEvents chkToolIDFilter As CheckBox
    Friend WithEvents txtIToolDFilter As TextBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents cmbNewManufacturer As ComboBox
    Friend WithEvents cmbNewCategory As ComboBox
    Friend WithEvents cmbNewType As ComboBox
    Friend WithEvents cmbNewName As ComboBox
    Friend WithEvents cmbNewBaseCost As ComboBox
    Friend WithEvents txtNewImagePath As TextBox
    Friend WithEvents grpNewState As GroupBox
    Friend WithEvents radNewSale As RadioButton
    Friend WithEvents radNewRental As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents lblNotes As Label
    Friend WithEvents lblNewNotes As Label
    Friend WithEvents txtNewNotes As TextBox
    Friend WithEvents btnSelectToolSaleRental As Button
End Class

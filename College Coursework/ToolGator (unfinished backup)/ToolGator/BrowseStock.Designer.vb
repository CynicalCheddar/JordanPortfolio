<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BrowseStock
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
        Me.chkRental = New System.Windows.Forms.CheckBox()
        Me.chkSale = New System.Windows.Forms.CheckBox()
        Me.chkPowerTool = New System.Windows.Forms.CheckBox()
        Me.chkHandTool = New System.Windows.Forms.CheckBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkRental
        '
        Me.chkRental.AutoSize = True
        Me.chkRental.Location = New System.Drawing.Point(9, 141)
        Me.chkRental.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkRental.Name = "chkRental"
        Me.chkRental.Size = New System.Drawing.Size(57, 17)
        Me.chkRental.TabIndex = 1
        Me.chkRental.Text = "Rental"
        Me.chkRental.UseVisualStyleBackColor = True
        '
        'chkSale
        '
        Me.chkSale.AutoSize = True
        Me.chkSale.Location = New System.Drawing.Point(9, 171)
        Me.chkSale.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkSale.Name = "chkSale"
        Me.chkSale.Size = New System.Drawing.Size(47, 17)
        Me.chkSale.TabIndex = 2
        Me.chkSale.Text = "Sale"
        Me.chkSale.UseVisualStyleBackColor = True
        '
        'chkPowerTool
        '
        Me.chkPowerTool.AutoSize = True
        Me.chkPowerTool.Location = New System.Drawing.Point(9, 232)
        Me.chkPowerTool.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkPowerTool.Name = "chkPowerTool"
        Me.chkPowerTool.Size = New System.Drawing.Size(85, 17)
        Me.chkPowerTool.TabIndex = 3
        Me.chkPowerTool.Text = "Power Tools"
        Me.chkPowerTool.UseVisualStyleBackColor = True
        '
        'chkHandTool
        '
        Me.chkHandTool.AutoSize = True
        Me.chkHandTool.Location = New System.Drawing.Point(9, 263)
        Me.chkHandTool.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkHandTool.Name = "chkHandTool"
        Me.chkHandTool.Size = New System.Drawing.Size(81, 17)
        Me.chkHandTool.TabIndex = 4
        Me.chkHandTool.Text = "Hand Tools"
        Me.chkHandTool.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(322, 22)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(181, 31)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Browse Stock"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmToolID, Me.clmManufacturer, Me.clmCategory, Me.clmType, Me.clmName, Me.clmStatus, Me.clmBaseCost, Me.clmImageFilePath, Me.clmDamageNotes, Me.clmCurrentlyRented})
        Me.DataGridView1.Location = New System.Drawing.Point(189, 141)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1195, 553)
        Me.DataGridView1.TabIndex = 6
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
        'BrowseStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1446, 767)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.chkHandTool)
        Me.Controls.Add(Me.chkPowerTool)
        Me.Controls.Add(Me.chkSale)
        Me.Controls.Add(Me.chkRental)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "BrowseStock"
        Me.Text = "BrowseStock"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkRental As System.Windows.Forms.CheckBox
    Friend WithEvents chkSale As System.Windows.Forms.CheckBox
    Friend WithEvents chkPowerTool As System.Windows.Forms.CheckBox
    Friend WithEvents chkHandTool As System.Windows.Forms.CheckBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As DataGridView
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
End Class

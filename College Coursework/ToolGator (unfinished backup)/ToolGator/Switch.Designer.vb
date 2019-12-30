<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Switch
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
        Me.btnCreateAccount = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnStock = New System.Windows.Forms.Button()
        Me.btnAddStock = New System.Windows.Forms.Button()
        Me.btnAmendView = New System.Windows.Forms.Button()
        Me.btnCustomerSaleRental = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.Location = New System.Drawing.Point(50, 37)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(91, 58)
        Me.btnCreateAccount.TabIndex = 0
        Me.btnCreateAccount.Text = "Create Account"
        Me.btnCreateAccount.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(185, 37)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(99, 57)
        Me.btnView.TabIndex = 1
        Me.btnView.Text = "Amend and view  accounts"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnStock
        '
        Me.btnStock.Location = New System.Drawing.Point(334, 38)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.Size = New System.Drawing.Size(99, 57)
        Me.btnStock.TabIndex = 2
        Me.btnStock.Text = "Browse Stock"
        Me.btnStock.UseVisualStyleBackColor = True
        '
        'btnAddStock
        '
        Me.btnAddStock.Location = New System.Drawing.Point(484, 38)
        Me.btnAddStock.Name = "btnAddStock"
        Me.btnAddStock.Size = New System.Drawing.Size(99, 57)
        Me.btnAddStock.TabIndex = 3
        Me.btnAddStock.Text = "Add Stock"
        Me.btnAddStock.UseVisualStyleBackColor = True
        '
        'btnAmendView
        '
        Me.btnAmendView.Location = New System.Drawing.Point(50, 130)
        Me.btnAmendView.Name = "btnAmendView"
        Me.btnAmendView.Size = New System.Drawing.Size(99, 57)
        Me.btnAmendView.TabIndex = 4
        Me.btnAmendView.Text = "Amend and View Stock"
        Me.btnAmendView.UseVisualStyleBackColor = True
        '
        'btnCustomerSaleRental
        '
        Me.btnCustomerSaleRental.Location = New System.Drawing.Point(185, 130)
        Me.btnCustomerSaleRental.Name = "btnCustomerSaleRental"
        Me.btnCustomerSaleRental.Size = New System.Drawing.Size(99, 57)
        Me.btnCustomerSaleRental.TabIndex = 5
        Me.btnCustomerSaleRental.Text = "Customer Sale/Rental"
        Me.btnCustomerSaleRental.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(334, 130)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(99, 57)
        Me.btnReturn.TabIndex = 6
        Me.btnReturn.Text = "Return tool"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'Switch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 375)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnCustomerSaleRental)
        Me.Controls.Add(Me.btnAmendView)
        Me.Controls.Add(Me.btnAddStock)
        Me.Controls.Add(Me.btnStock)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnCreateAccount)
        Me.Name = "Switch"
        Me.Text = "Switch"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCreateAccount As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnStock As System.Windows.Forms.Button
    Friend WithEvents btnAddStock As System.Windows.Forms.Button
    Friend WithEvents btnAmendView As System.Windows.Forms.Button
    Friend WithEvents btnCustomerSaleRental As Button
    Friend WithEvents btnReturn As Button
End Class

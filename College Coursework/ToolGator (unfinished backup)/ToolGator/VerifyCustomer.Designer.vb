<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerifyCustomer
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
        Me.txtForename = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnVerify = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.chkOnFile = New System.Windows.Forms.CheckBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAddNewCustomer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtForename
        '
        Me.txtForename.Location = New System.Drawing.Point(36, 50)
        Me.txtForename.Name = "txtForename"
        Me.txtForename.Size = New System.Drawing.Size(142, 20)
        Me.txtForename.TabIndex = 0
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(36, 97)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(142, 20)
        Me.txtSurname.TabIndex = 1
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(36, 143)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(142, 20)
        Me.txtAddress.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(185, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Customer Forename"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(185, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Customer Surname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(185, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Customer Address"
        '
        'btnVerify
        '
        Me.btnVerify.Location = New System.Drawing.Point(36, 184)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(89, 23)
        Me.btnVerify.TabIndex = 6
        Me.btnVerify.Text = "Verify Customer"
        Me.btnVerify.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(36, 263)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(89, 23)
        Me.btnConfirm.TabIndex = 7
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'chkOnFile
        '
        Me.chkOnFile.AutoSize = True
        Me.chkOnFile.Location = New System.Drawing.Point(36, 228)
        Me.chkOnFile.Name = "chkOnFile"
        Me.chkOnFile.Size = New System.Drawing.Size(107, 17)
        Me.chkOnFile.TabIndex = 8
        Me.chkOnFile.Text = "Customer on file?"
        Me.chkOnFile.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(188, 263)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(89, 23)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAddNewCustomer
        '
        Me.btnAddNewCustomer.Location = New System.Drawing.Point(345, 51)
        Me.btnAddNewCustomer.Name = "btnAddNewCustomer"
        Me.btnAddNewCustomer.Size = New System.Drawing.Size(112, 23)
        Me.btnAddNewCustomer.TabIndex = 10
        Me.btnAddNewCustomer.Text = "Add New Customer"
        Me.btnAddNewCustomer.UseVisualStyleBackColor = True
        '
        'VerifyCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 373)
        Me.Controls.Add(Me.btnAddNewCustomer)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.chkOnFile)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnVerify)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtForename)
        Me.Name = "VerifyCustomer"
        Me.Text = "VerifyCustomer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtForename As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnVerify As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents chkOnFile As CheckBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAddNewCustomer As Button
End Class

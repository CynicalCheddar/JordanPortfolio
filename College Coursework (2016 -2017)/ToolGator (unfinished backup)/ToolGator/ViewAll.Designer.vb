<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewAll
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
        Me.lstAccounts = New System.Windows.Forms.ListBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.txtNewUsername = New System.Windows.Forms.TextBox()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.chkNewAdmin = New System.Windows.Forms.CheckBox()
        Me.chkNewStaff = New System.Windows.Forms.CheckBox()
        Me.chkNewCustomerTerminal = New System.Windows.Forms.CheckBox()
        Me.lblNewUsername = New System.Windows.Forms.Label()
        Me.lblNewPassword = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstAccounts
        '
        Me.lstAccounts.FormattingEnabled = True
        Me.lstAccounts.Location = New System.Drawing.Point(75, 35)
        Me.lstAccounts.Name = "lstAccounts"
        Me.lstAccounts.Size = New System.Drawing.Size(425, 134)
        Me.lstAccounts.TabIndex = 0
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(75, 288)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(71, 30)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(413, 288)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(128, 30)
        Me.btnConfirm.TabIndex = 2
        Me.btnConfirm.Text = "Confirm Amend Details"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'txtNewUsername
        '
        Me.txtNewUsername.Location = New System.Drawing.Point(413, 179)
        Me.txtNewUsername.Name = "txtNewUsername"
        Me.txtNewUsername.Size = New System.Drawing.Size(127, 20)
        Me.txtNewUsername.TabIndex = 3
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(413, 205)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(127, 20)
        Me.txtNewPassword.TabIndex = 4
        '
        'chkNewAdmin
        '
        Me.chkNewAdmin.AutoSize = True
        Me.chkNewAdmin.Location = New System.Drawing.Point(413, 231)
        Me.chkNewAdmin.Name = "chkNewAdmin"
        Me.chkNewAdmin.Size = New System.Drawing.Size(55, 17)
        Me.chkNewAdmin.TabIndex = 5
        Me.chkNewAdmin.Text = "Admin"
        Me.chkNewAdmin.UseVisualStyleBackColor = True
        '
        'chkNewStaff
        '
        Me.chkNewStaff.AutoSize = True
        Me.chkNewStaff.Location = New System.Drawing.Point(485, 231)
        Me.chkNewStaff.Name = "chkNewStaff"
        Me.chkNewStaff.Size = New System.Drawing.Size(48, 17)
        Me.chkNewStaff.TabIndex = 6
        Me.chkNewStaff.Text = "Staff"
        Me.chkNewStaff.UseVisualStyleBackColor = True
        '
        'chkNewCustomerTerminal
        '
        Me.chkNewCustomerTerminal.AutoSize = True
        Me.chkNewCustomerTerminal.Location = New System.Drawing.Point(413, 254)
        Me.chkNewCustomerTerminal.Name = "chkNewCustomerTerminal"
        Me.chkNewCustomerTerminal.Size = New System.Drawing.Size(113, 17)
        Me.chkNewCustomerTerminal.TabIndex = 7
        Me.chkNewCustomerTerminal.Text = "Customer Terminal"
        Me.chkNewCustomerTerminal.UseVisualStyleBackColor = True
        '
        'lblNewUsername
        '
        Me.lblNewUsername.AutoSize = True
        Me.lblNewUsername.Location = New System.Drawing.Point(327, 179)
        Me.lblNewUsername.Name = "lblNewUsername"
        Me.lblNewUsername.Size = New System.Drawing.Size(80, 13)
        Me.lblNewUsername.TabIndex = 8
        Me.lblNewUsername.Text = "New Username"
        '
        'lblNewPassword
        '
        Me.lblNewPassword.AutoSize = True
        Me.lblNewPassword.Location = New System.Drawing.Point(327, 205)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(78, 13)
        Me.lblNewPassword.TabIndex = 9
        Me.lblNewPassword.Text = "New Password"
        '
        'ViewAll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 344)
        Me.Controls.Add(Me.lblNewPassword)
        Me.Controls.Add(Me.lblNewUsername)
        Me.Controls.Add(Me.chkNewCustomerTerminal)
        Me.Controls.Add(Me.chkNewStaff)
        Me.Controls.Add(Me.chkNewAdmin)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.txtNewUsername)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lstAccounts)
        Me.Name = "ViewAll"
        Me.Text = "ViewAll"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstAccounts As System.Windows.Forms.ListBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents txtNewUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents chkNewAdmin As System.Windows.Forms.CheckBox
    Friend WithEvents chkNewStaff As System.Windows.Forms.CheckBox
    Friend WithEvents chkNewCustomerTerminal As System.Windows.Forms.CheckBox
    Friend WithEvents lblNewUsername As System.Windows.Forms.Label
    Friend WithEvents lblNewPassword As System.Windows.Forms.Label
End Class

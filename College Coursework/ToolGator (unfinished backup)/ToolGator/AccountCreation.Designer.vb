<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountCreation
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
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblConfirmUsername = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.txtUsernameConfirm = New System.Windows.Forms.TextBox()
        Me.txtPasswordConfirm = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkCustomer = New System.Windows.Forms.CheckBox()
        Me.chkStaff = New System.Windows.Forms.CheckBox()
        Me.chkAdmin = New System.Windows.Forms.CheckBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.Location = New System.Drawing.Point(140, 266)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(94, 29)
        Me.btnCreateAccount.TabIndex = 19
        Me.btnCreateAccount.Text = "Create Account"
        Me.btnCreateAccount.UseVisualStyleBackColor = True
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.Location = New System.Drawing.Point(24, 153)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(94, 13)
        Me.lblConfirmPassword.TabIndex = 18
        Me.lblConfirmPassword.Text = "Confirm Password:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(62, 118)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblPassword.TabIndex = 17
        Me.lblPassword.Text = "Password:"
        '
        'lblConfirmUsername
        '
        Me.lblConfirmUsername.AutoSize = True
        Me.lblConfirmUsername.Location = New System.Drawing.Point(24, 77)
        Me.lblConfirmUsername.Name = "lblConfirmUsername"
        Me.lblConfirmUsername.Size = New System.Drawing.Size(96, 13)
        Me.lblConfirmUsername.TabIndex = 16
        Me.lblConfirmUsername.Text = "Confirm Username:"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(62, 40)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(58, 13)
        Me.lblUsername.TabIndex = 15
        Me.lblUsername.Text = "Username:"
        '
        'lblAdmin
        '
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.Location = New System.Drawing.Point(83, -16)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(152, 13)
        Me.lblAdmin.TabIndex = 14
        Me.lblAdmin.Text = "Administrator Account Creation"
        '
        'txtUsernameConfirm
        '
        Me.txtUsernameConfirm.Location = New System.Drawing.Point(140, 77)
        Me.txtUsernameConfirm.Name = "txtUsernameConfirm"
        Me.txtUsernameConfirm.Size = New System.Drawing.Size(120, 20)
        Me.txtUsernameConfirm.TabIndex = 11
        '
        'txtPasswordConfirm
        '
        Me.txtPasswordConfirm.Location = New System.Drawing.Point(140, 153)
        Me.txtPasswordConfirm.Name = "txtPasswordConfirm"
        Me.txtPasswordConfirm.Size = New System.Drawing.Size(120, 20)
        Me.txtPasswordConfirm.TabIndex = 13
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(140, 115)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(120, 20)
        Me.txtPassword.TabIndex = 12
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(140, 37)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(120, 20)
        Me.txtUsername.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Administrator Account Creation"
        '
        'chkCustomer
        '
        Me.chkCustomer.AutoSize = True
        Me.chkCustomer.Location = New System.Drawing.Point(55, 239)
        Me.chkCustomer.Name = "chkCustomer"
        Me.chkCustomer.Size = New System.Drawing.Size(70, 17)
        Me.chkCustomer.TabIndex = 22
        Me.chkCustomer.Text = "Customer"
        Me.chkCustomer.UseVisualStyleBackColor = True
        '
        'chkStaff
        '
        Me.chkStaff.AutoSize = True
        Me.chkStaff.Location = New System.Drawing.Point(55, 216)
        Me.chkStaff.Name = "chkStaff"
        Me.chkStaff.Size = New System.Drawing.Size(48, 17)
        Me.chkStaff.TabIndex = 21
        Me.chkStaff.Text = "Staff"
        Me.chkStaff.UseVisualStyleBackColor = True
        '
        'chkAdmin
        '
        Me.chkAdmin.AutoSize = True
        Me.chkAdmin.Location = New System.Drawing.Point(55, 193)
        Me.chkAdmin.Name = "chkAdmin"
        Me.chkAdmin.Size = New System.Drawing.Size(86, 17)
        Me.chkAdmin.TabIndex = 23
        Me.chkAdmin.Text = "Administrator"
        Me.chkAdmin.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(24, 266)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(94, 29)
        Me.btnBack.TabIndex = 24
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'AccountCreation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 324)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.chkAdmin)
        Me.Controls.Add(Me.chkCustomer)
        Me.Controls.Add(Me.chkStaff)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCreateAccount)
        Me.Controls.Add(Me.lblConfirmPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblConfirmUsername)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblAdmin)
        Me.Controls.Add(Me.txtUsernameConfirm)
        Me.Controls.Add(Me.txtPasswordConfirm)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Name = "AccountCreation"
        Me.Text = "AccountCreation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCreateAccount As System.Windows.Forms.Button
    Friend WithEvents lblConfirmPassword As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblConfirmUsername As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblAdmin As System.Windows.Forms.Label
    Friend WithEvents txtUsernameConfirm As System.Windows.Forms.TextBox
    Friend WithEvents txtPasswordConfirm As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkCustomer As System.Windows.Forms.CheckBox
    Friend WithEvents chkStaff As System.Windows.Forms.CheckBox
    Friend WithEvents chkAdmin As System.Windows.Forms.CheckBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class

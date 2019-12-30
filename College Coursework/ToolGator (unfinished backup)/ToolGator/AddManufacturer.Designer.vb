<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddManufacturer
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
        Me.lblNewName = New System.Windows.Forms.Label()
        Me.txtNewName = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNewName
        '
        Me.lblNewName.AutoSize = True
        Me.lblNewName.Location = New System.Drawing.Point(7, 65)
        Me.lblNewName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNewName.Name = "lblNewName"
        Me.lblNewName.Size = New System.Drawing.Size(129, 13)
        Me.lblNewName.TabIndex = 0
        Me.lblNewName.Text = "New Manufacturer Name:"
        '
        'txtNewName
        '
        Me.txtNewName.Location = New System.Drawing.Point(147, 65)
        Me.txtNewName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNewName.Name = "txtNewName"
        Me.txtNewName.Size = New System.Drawing.Size(144, 20)
        Me.txtNewName.TabIndex = 1
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(180, 179)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(83, 29)
        Me.btnConfirm.TabIndex = 2
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(32, 179)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(83, 29)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'AddManufacturer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 252)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.txtNewName)
        Me.Controls.Add(Me.lblNewName)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AddManufacturer"
        Me.Text = "AddManufacturer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNewName As System.Windows.Forms.Label
    Friend WithEvents txtNewName As System.Windows.Forms.TextBox
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class

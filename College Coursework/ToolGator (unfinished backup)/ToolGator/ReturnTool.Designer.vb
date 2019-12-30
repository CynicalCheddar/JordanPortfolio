<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnTool
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
        Me.txtCustomerForename = New System.Windows.Forms.TextBox()
        Me.txtCustomerSurname = New System.Windows.Forms.TextBox()
        Me.txtCustomerAddress = New System.Windows.Forms.TextBox()
        Me.lstCurrentlyRentedTools = New System.Windows.Forms.ListBox()
        Me.btnGetTools = New System.Windows.Forms.Button()
        Me.lblForename = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.txtTest = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtCustomerForename
        '
        Me.txtCustomerForename.Location = New System.Drawing.Point(65, 103)
        Me.txtCustomerForename.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCustomerForename.Name = "txtCustomerForename"
        Me.txtCustomerForename.Size = New System.Drawing.Size(132, 22)
        Me.txtCustomerForename.TabIndex = 0
        '
        'txtCustomerSurname
        '
        Me.txtCustomerSurname.Location = New System.Drawing.Point(65, 160)
        Me.txtCustomerSurname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCustomerSurname.Name = "txtCustomerSurname"
        Me.txtCustomerSurname.Size = New System.Drawing.Size(132, 22)
        Me.txtCustomerSurname.TabIndex = 1
        '
        'txtCustomerAddress
        '
        Me.txtCustomerAddress.Location = New System.Drawing.Point(65, 217)
        Me.txtCustomerAddress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCustomerAddress.Name = "txtCustomerAddress"
        Me.txtCustomerAddress.Size = New System.Drawing.Size(132, 22)
        Me.txtCustomerAddress.TabIndex = 2
        '
        'lstCurrentlyRentedTools
        '
        Me.lstCurrentlyRentedTools.FormattingEnabled = True
        Me.lstCurrentlyRentedTools.ItemHeight = 16
        Me.lstCurrentlyRentedTools.Location = New System.Drawing.Point(512, 103)
        Me.lstCurrentlyRentedTools.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstCurrentlyRentedTools.Name = "lstCurrentlyRentedTools"
        Me.lstCurrentlyRentedTools.Size = New System.Drawing.Size(471, 292)
        Me.lstCurrentlyRentedTools.TabIndex = 3
        '
        'btnGetTools
        '
        Me.btnGetTools.Location = New System.Drawing.Point(65, 278)
        Me.btnGetTools.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGetTools.Name = "btnGetTools"
        Me.btnGetTools.Size = New System.Drawing.Size(100, 28)
        Me.btnGetTools.TabIndex = 4
        Me.btnGetTools.Text = "Get Tools"
        Me.btnGetTools.UseVisualStyleBackColor = True
        '
        'lblForename
        '
        Me.lblForename.AutoSize = True
        Me.lblForename.Location = New System.Drawing.Point(208, 103)
        Me.lblForename.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblForename.Name = "lblForename"
        Me.lblForename.Size = New System.Drawing.Size(72, 17)
        Me.lblForename.TabIndex = 5
        Me.lblForename.Text = "Forename"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(207, 169)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Surname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(208, 225)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(508, 84)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Currently rented tools:"
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(512, 404)
        Me.btnReturn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(100, 28)
        Me.btnReturn.TabIndex = 9
        Me.btnReturn.Text = "Return Tool"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'txtTest
        '
        Me.txtTest.Location = New System.Drawing.Point(342, 533)
        Me.txtTest.Name = "txtTest"
        Me.txtTest.Size = New System.Drawing.Size(100, 22)
        Me.txtTest.TabIndex = 10
        '
        'ReturnTool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 645)
        Me.Controls.Add(Me.txtTest)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblForename)
        Me.Controls.Add(Me.btnGetTools)
        Me.Controls.Add(Me.lstCurrentlyRentedTools)
        Me.Controls.Add(Me.txtCustomerAddress)
        Me.Controls.Add(Me.txtCustomerSurname)
        Me.Controls.Add(Me.txtCustomerForename)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ReturnTool"
        Me.Text = "ReturnTool"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCustomerForename As TextBox
    Friend WithEvents txtCustomerSurname As TextBox
    Friend WithEvents txtCustomerAddress As TextBox
    Friend WithEvents lstCurrentlyRentedTools As ListBox
    Friend WithEvents btnGetTools As Button
    Friend WithEvents lblForename As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReturn As Button
    Friend WithEvents txtTest As TextBox
End Class

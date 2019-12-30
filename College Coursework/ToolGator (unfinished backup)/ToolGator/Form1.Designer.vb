<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.lblSplash = New System.Windows.Forms.Label()
        Me.tmrSpash = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblSplash
        '
        Me.lblSplash.AutoSize = True
        Me.lblSplash.Location = New System.Drawing.Point(91, 123)
        Me.lblSplash.Name = "lblSplash"
        Me.lblSplash.Size = New System.Drawing.Size(76, 13)
        Me.lblSplash.TabIndex = 0
        Me.lblSplash.Text = "Splash Screen"
        '
        'tmrSpash
        '
        Me.tmrSpash.Enabled = True
        Me.tmrSpash.Interval = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblSplash)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSplash As System.Windows.Forms.Label
    Friend WithEvents tmrSpash As System.Windows.Forms.Timer

End Class

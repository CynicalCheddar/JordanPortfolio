Imports System.IO
Public Class LoginForm

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        Dim userRecord As String = ""
        Dim userDetails() As String
        Dim userFileReader As StreamReader = File.OpenText(strPathToPasswordsFile)
        Do
            userRecord = userFileReader.ReadLine
            userDetails = userRecord.Split(",")
            If txtLoginUsername.Text = userDetails(0) And txtLoginPassword.Text = userDetails(1) Then
                If userDetails(2) = "Admin" Then            'Program set to appropriate security level via global variable strLevel
                    strLevel = "Admin"
                ElseIf userDetails(2) = "Staff" Then
                    strLevel = "Staff"
                ElseIf userDetails(2) = "Customer" Then
                    strLevel = "Customer"
                End If
                Switch.Show()
                Me.Close()
                Exit Do
            End If
            If userFileReader.Peek = -1 Then
                MessageBox.Show("Invalid Login", "Error", _
     MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Loop Until userFileReader.Peek = -1
        userFileReader.Close()
    End Sub

    Private Sub LoginForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
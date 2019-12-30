Public Class Form1


    Private Sub tmrSpash_Tick(sender As System.Object, e As System.EventArgs) Handles tmrSpash.Tick
        If My.Computer.FileSystem.FileExists(strPathToPasswordsFile) Then
            LoginForm.Show()
            Me.Close()
        Else
            AccountCreation.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

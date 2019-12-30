Imports System.IO
Public Class ViewAll
    Dim strSelectedRecord As String = ""
    Dim strSelectedField() As String
    Private Sub lstAccounts_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstAccounts.SelectedIndexChanged

        btnConfirm.Enabled = True

    End Sub
    'amend details process
    '1 - Write all lines of file to a new temporary file, excluding the line to be amended
    '2 - Append the new details to the end of the temporary file
    '3 - Kill original file and rename temp file to that of the deleted file.
    Private Sub ViewAll_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        refreshBox()
        btnConfirm.Enabled = False
    End Sub

    Private Sub refreshBox()
        lstAccounts.Items.Clear()
        Dim staffRecord As String = ""
        Dim staffDetails() As String
        Dim staffFileReader As StreamReader = File.OpenText(strPathToPasswordsFile)
        Do
            staffRecord = staffFileReader.ReadLine                                  'Writes the contents of the staff login information to a list box only the admin may see.
            lstAccounts.Items.Add(staffRecord)

        Loop Until staffFileReader.Peek = -1
        staffFileReader.Close()
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Switch.Show()
        Me.Close()

    End Sub

    Private Sub btnConfirm_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirm.Click
        Dim strField() As String
        Dim strCurrentRecord As String = ""
        Dim fileRead As New StreamReader(strPathToPasswordsFile) 'Reader of password file

        strSelectedRecord = lstAccounts.SelectedItem.ToString()
        strSelectedField = strSelectedRecord.Split(",")

        Do
            strCurrentRecord = fileRead.ReadLine
            strField = strCurrentRecord.Split(",")
            If Not (strField(0) = strSelectedField(0) And strField(1) = strSelectedField(1)) Then 'Copies all lines to temp file excluding selected record.
                Dim tempWriter = New StreamWriter(strPathToTemporaryPasswordFile, True)
                tempWriter.WriteLine(strCurrentRecord)
                tempWriter.Close()

            End If

        Loop Until fileRead.Peek = -1
        fileRead.Close()
        appendNewDetails()
    End Sub

    Sub appendNewDetails()
        Dim fileSave As New StreamWriter(strPathToTemporaryPasswordFile, True)
        Dim strSecurityLevel = ""
        If chkNewAdmin.Checked Then                                      'Finds new security level, assigns it to a string variable
            strSecurityLevel = "Admin"
        End If
        If chkNewStaff.Checked Then
            strSecurityLevel = "Staff"
        End If
        If chkNewCustomerTerminal.Checked Then
            strSecurityLevel = "CustomerTerminal"
        End If
        fileSave.WriteLine(txtNewUsername.Text & "," & txtNewPassword.Text & "," & strSecurityLevel)
        fileSave.Close()
        Kill(Application.StartupPath & "\shiftyLookingFile.txt")                                        'Kills original password file
        Rename(Application.StartupPath & "\temporaryPasswordFile.txt", Application.StartupPath & "\shiftyLookingFile.txt") 'Renames temporary file to the name of the original file.
        refreshBox()
    End Sub
End Class
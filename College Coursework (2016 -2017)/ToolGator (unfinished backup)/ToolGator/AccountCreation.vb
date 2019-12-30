Imports System.IO

Public Class AccountCreation
    Dim blnStaff As Boolean = False
    Dim blnCustomerTerminal As Boolean = False
    Dim blnAdmin As Boolean = False

    Dim blnFirstTimeSetup As Boolean = False

    Sub intitialseMore()
        Dim FileStream1 = New FileStream(strPathToCustomerFile, FileMode.Append, FileAccess.Write, FileShare.None) 'Here we create necessary files for the program
        FileStream1.Flush()
        FileStream1.Close()
        Dim FileStream2 = New FileStream(strPathToLoyaltyFile, FileMode.Append, FileAccess.Write, FileShare.None)
        Dim FileWriter2 As StreamWriter = New StreamWriter(FileStream2)
        FileWriter2.WriteLine("0.05" + "," + "1")
        FileWriter2.Close()
        FileStream2.Close()


        Dim FileStream3 = New FileStream(strPathToRentalSettingsFile, FileMode.Append, FileAccess.Write, FileShare.None)
        Dim FileWriter3 As StreamWriter = New StreamWriter(FileStream3)
        FileWriter3.WriteLine("0.1" + "," + "0")
        FileWriter3.Close()
        FileStream3.Close()


        Dim FileStream4 = New FileStream(strPathToVATfile, FileMode.Append, FileAccess.Write, FileShare.None)
        Dim FileWriter4 As StreamWriter = New StreamWriter(FileStream4)
        FileWriter4.WriteLine("1.2")
        FileWriter4.Close()
        FileStream4.Close()

        Dim FileStream5 = New FileStream(strPathToRentalTransactionFile, FileMode.Append, FileAccess.Write, FileShare.None)
        Dim FileWriter5 As StreamWriter = New StreamWriter(FileStream5)
        FileWriter5.Close()
        FileWriter5.Close()

        Dim FileStream6 = New FileStream(strPathToSaleTransactionFile, FileMode.Append, FileAccess.Write, FileShare.None)
        Dim FileWriter6 As StreamWriter = New StreamWriter(FileStream6)
        FileWriter6.Close()
        FileWriter6.Close()
    End Sub
    Private Sub btnCreateAccount_Click(sender As System.Object, e As System.EventArgs) Handles btnCreateAccount.Click


        If ((txtUsername.Text = txtUsernameConfirm.Text) And (txtPassword.Text = txtPasswordConfirm.Text)) Then
            If Not (My.Computer.FileSystem.FileExists(strPathToInventoryFile)) Then ' It is assumed that this is the first time starting up if there is no inventory file.
                blnFirstTimeSetup = True
                chkAdmin.Checked = True




                Dim FileStreamA = New FileStream(strPathToToolCategoryFile, FileMode.Append, FileAccess.Write, FileShare.None) '                                        Writes category files and populates with placeholder                               
                Dim FileWriterA As StreamWriter = New StreamWriter(FileStreamA)
                FileWriterA.WriteLine("N/A")
                FileWriterA.Close()
                FileStreamA.Close()

                Dim FileStream1 = New FileStream(strPathToManufacturersFile, FileMode.Append, FileAccess.Write, FileShare.None)
                Dim FileWriter1 As StreamWriter = New StreamWriter(FileStream1)
                FileWriter1.WriteLine("N/A")
                FileWriter1.Close()
                FileStream1.Close()



                Dim FileStream2 = New FileStream(strPathToToolTypeFile, FileMode.Append, FileAccess.Write, FileShare.None)
                Dim FileWriter2 As StreamWriter = New StreamWriter(FileStream2)
                FileWriter2.WriteLine("N/A")
                FileWriter2.Close()
                FileStream2.Close()
                intitialseMore()

                ' Creates image directory
                Directory.CreateDirectory(strPathToImageDirectory)


            End If
            Dim FileStream = New FileStream(strPathToInventoryFile, FileMode.Append, FileAccess.Write, FileShare.None)
            Dim AdminFileWriter As StreamWriter = New StreamWriter(FileStream)
            SavePassword()                                                            'See subroutine
            FileStream.Flush()
            AdminFileWriter.Close()
            FileStream.Close()
            If blnFirstTimeSetup = True Then
                LoginForm.Show()                                                      ' Brings new admin account to the login page




                Me.Close()
            Else
                txtPassword.Text = ""                                                 ' Clears textboxes for easy creation of more accounts
                txtPasswordConfirm.Text = ""
                txtUsername.Text = ""
                txtUsernameConfirm.Text = ""

                MessageBox.Show("Account Created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                ' Initilalise any other files for the program

            End If

        Else
            MessageBox.Show("Invalid Login information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Sub SavePassword()                                                     ' A funtion that writes the username and password to a serial file along with the user's assigned security level.
        Dim FileStream = New FileStream(strPathToPasswordsFile, FileMode.Append, FileAccess.Write, FileShare.None)
        Dim AdminFileWriter As StreamWriter = New StreamWriter(FileStream)
        If blnFirstTimeSetup = False Then
            AdminFileWriter.WriteLine("")
        End If

        AdminFileWriter.Write(txtUsername.Text & ",")
        AdminFileWriter.Write(txtPassword.Text & ",")
        If blnAdmin = True Then                                             ' Assigns new accound appropriate security level.
            AdminFileWriter.Write("Admin")                                 ' Adds third element in the login record - the security level.
        End If
        If blnStaff = True Then                                             ' If staff box is ticked, add Staff security level
            AdminFileWriter.Write("Staff")
        End If
        If blnCustomerTerminal = True Then                                  ' Add low level customer security level for use in the warehouse. Can see available tools.
            AdminFileWriter.Write("Customer")
        End If
        FileStream.Flush()
        AdminFileWriter.Close()
        FileStream.Close()
    End Sub

    Private Sub AdminForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Not (My.Computer.FileSystem.FileExists(strPathToInventoryFile)) Then 'If this is the first time the program has started up then staff or customer accounts cannot be made until an admin account has been created.
            chkStaff.Visible = False
            chkStaff.Enabled = False
            chkCustomer.Visible = False
            chkCustomer.Enabled = False

        End If
        If Not (strLevel = "Admin") Then
            btnBack.Visible = False
            btnBack.Enabled = False
        End If
    End Sub

    Private Sub chkAdmin_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkAdmin.CheckedChanged
        blnAdmin = Not (blnAdmin)
    End Sub

    Private Sub chkStaff_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkStaff.CheckedChanged
        blnStaff = Not (blnStaff)
    End Sub

    Private Sub chkCustomer_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCustomer.CheckedChanged
        blnCustomerTerminal = Not (blnCustomerTerminal)
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Switch.Show()
        Me.Close()

    End Sub
End Class
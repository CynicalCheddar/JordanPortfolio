Imports System.IO
Public Class AddCustomer
    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click


        Dim strLastLine As String = ""
        Dim strCustomerDetails() As String
        Dim strLastID = "1"



        If File.ReadAllText(strPathToCustomerFile).Length = 0 Then
            strLastID = "1"
        Else
            Dim lines As String() = IO.File.ReadAllLines(strPathToCustomerFile)                                        'Finds the unique identifier of the last line. 
            strLastLine = (lines(lines.Length - 1))
            strCustomerDetails = strLastLine.Split(",")
            strLastID = CStr((CInt(strCustomerDetails(0)) + 1))                                                                             'The customer ID of the first item in the batch is equal to 1 + last ID.
        End If

        Dim FileStream = New FileStream(strPathToCustomerFile, FileMode.Append, FileAccess.Write, FileShare.None)
        Dim FileWriter As StreamWriter = New StreamWriter(FileStream)

        FileWriter.WriteLine(strLastID & "," & txtCustomerForename.Text & "," & txtCustomerSurname.Text & "," & Date.Now & "," & txtContactNumber.Text & "," & txtAddress.Text & "," & "0")
        FileWriter.Flush()
        FileStream.Close()
        VerifyCustomer.Enabled = True
        Me.Close()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        VerifyCustomer.Enabled = True
        Me.Close()
    End Sub
End Class
Imports System.IO
Public Class VerifyCustomer
    Dim customerDetails() As String
    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        Dim customerRecord As String = ""

        Dim customerFileReader As StreamReader = File.OpenText(strPathToCustomerFile)
        Dim found = False
        Do
            customerRecord = customerFileReader.ReadLine
            customerDetails = customerRecord.Split(",")
            If txtForename.Text = customerDetails(1) And txtSurname.Text = customerDetails(2) And txtAddress.Text = customerDetails(5) Then
                chkOnFile.CheckState = 1
                found = True
                Exit Do
            End If
        Loop Until customerFileReader.Peek = -1
        customerFileReader.Close()
        If found = False Then
            MessageBox.Show("Customer not on file.", "Toolgator",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            chkOnFile.CheckState = False
        Else
            btnConfirm.Enabled = True
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        CustomerSaleRental.txtCustomerName.Text = customerDetails(1) + customerDetails(2)
        CustomerSaleRental.txtTakeoutDate.Text = Date.Now
        CustomerSaleRental.customerDetails = customerDetails
        CustomerSaleRental.Enabled = True
        CustomerSaleRental.txtCurrentLoyaltyPoints.Text = customerDetails(6)
        CustomerSaleRental.CalculatePointsToBeGained() 'calls public function
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        CustomerSaleRental.Enabled = True
        Me.Close()
    End Sub

    Private Sub btnAddNewCustomer_Click(sender As Object, e As EventArgs) Handles btnAddNewCustomer.Click
        AddCustomer.Show()
        Me.Enabled = False
    End Sub

    Private Sub VerifyCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
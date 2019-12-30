

Imports System.IO

Public Class CustomerSaleRental
    Public customerDetails() As String
    Public strRentalSaleState As String
    Public sngBaseCost As Single

    Dim sngPointValue As Single
    Dim sngEarnRate As Single
    Dim sngRentalCost As Single
    Dim sngPointsToEarn As Single
    Dim sngVATRate As Single

    Dim loyaltySettingsDetails() As String
    Private Sub btnBrowseTool_Click(sender As Object, e As EventArgs) Handles btnBrowseTool.Click
        AmendInventory.Show()                            'This opens the amend inventory form with disabled controls, only allowing for a tool to be selected.
        AmendInventory.txtNewImagePath.Enabled = False
        AmendInventory.txtNewNotes.Enabled = False
        AmendInventory.txtNotes.Enabled = False
        AmendInventory.cmbNewBaseCost.Enabled = False
        AmendInventory.cmbNewCategory.Enabled = False
        AmendInventory.cmbNewManufacturer.Enabled = False
        AmendInventory.cmbNewName.Enabled = False
        AmendInventory.cmbNewType.Enabled = False
        AmendInventory.radNewRental.Enabled = False
        AmendInventory.radNewSale.Enabled = False
        AmendInventory.btnConfirm.Enabled = False
        AmendInventory.btnSelectToolSaleRental.Enabled = True
        Me.Enabled = False
    End Sub

    Private Sub CustomerSaleRental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sngVATRate = My.Computer.FileSystem.ReadAllText(strPathToVATfile)
        CalculatePointsToBeGained()
    End Sub

    Private Sub btnVerifyAdd_Click(sender As Object, e As EventArgs) Handles btnVerifyAdd.Click
        ' Here we open another form if the tool is a rental item. We can verify the customer and add if needs be.
        VerifyCustomer.Show()
        Me.Enabled = False
    End Sub

    Public Sub CalculatePointsToBeGained()                                  ' This is called from the verify customer form.
        ' Read loyalty points file for points per £
        Dim loyaltySettingsRecord As String = ""

        Dim loyaltySettingsFileReader As StreamReader = File.OpenText(strPathToLoyaltyFile)

        Do
            loyaltySettingsRecord = loyaltySettingsFileReader.ReadLine
            loyaltySettingsDetails = loyaltySettingsRecord.Split(",")
            sngPointValue = loyaltySettingsDetails(0)
            sngEarnRate = loyaltySettingsDetails(1)
        Loop Until loyaltySettingsFileReader.Peek = -1

        loyaltySettingsFileReader.Close()
        ' Get final rental cost.
        FillPriceFields()

    End Sub
    Sub FillPriceFields() 'This is used for rental tools
        sngRentalCost = Math.Round(timDueDatePicker.Value.Subtract(Date.Today).Days) * sngBaseCost * GetRentalAlgorithm(0) + GetRentalAlgorithm(1)
        ' Multiply
        sngPointsToEarn = Math.Truncate(sngRentalCost * sngEarnRate)

        'Fill fields
        txtPointsToBeGained.Text = sngPointsToEarn
        txtCurrentLoyaltyPoints.Text = customerDetails(6)
        txtPriceToPayExVAT.Text = sngRentalCost
        txtPriceToPayIncVAT.Text = sngRentalCost * sngVATRate
    End Sub

    Function GetRentalAlgorithm()
        Dim rentalSettingsFileReader As StreamReader = File.OpenText(strPathToRentalSettingsFile)
        Dim rentalSettingsRecord As String = ""
        Dim rentalSettingsDetails() As String
        Do
            rentalSettingsRecord = rentalSettingsFileReader.ReadLine
            rentalSettingsDetails = rentalSettingsRecord.Split(",")


        Loop Until rentalSettingsFileReader.Peek = -1
        Return rentalSettingsDetails
    End Function

    Private Sub txtPointsToSpend_TextChanged(sender As Object, e As EventArgs) Handles txtPointsToSpend.TextChanged
        If Not (txtPointsToSpend.Text = "") Then
            txtPriceToPayExVAT.Text = sngRentalCost - CSng(txtPointsToSpend.Text) * loyaltySettingsDetails(0)
            txtPriceToPayIncVAT.Text = CSng(txtPriceToPayExVAT.Text) * sngVATRate
        End If

    End Sub

    Private Sub timDueDatePicker_ValueChanged(sender As Object, e As EventArgs) Handles timDueDatePicker.ValueChanged
        FillPriceFields()

    End Sub

    Private Sub btnConfirmTransaction_Click(sender As Object, e As EventArgs) Handles btnConfirmTransaction.Click
        'Now we need to make an entry in the transaction log and mark the tool as currently rented.
        If strRentalSaleState = "Rental" Then
            writeToRentalTransactionLog()
            markRentalToolAsTaken()
        End If
        If strRentalSaleState = "Sale" Then
            writeToSaleTransactionLog()

        End If
    End Sub

    Sub writeToRentalTransactionLog()
        Dim strLastID As String
        Dim strLastLine As String
        Dim strTransactionDetails() As String
        If File.ReadAllText(strPathToRentalTransactionFile).Length = 0 Then
            strLastID = "1"
        Else
            Dim lines As String() = IO.File.ReadAllLines(strPathToRentalTransactionFile)                                        'Finds the unique identifier of the last line. 
            strLastLine = (lines(lines.Length - 1))
            strTransactionDetails = strLastLine.Split(",")
            strLastID = CStr((CInt(strTransactionDetails(0)) + 1))                                                                             'The transaction ID of the first item in the batch is equal to 1 + last ID.
        End If


        Dim RentalTransactionFileStream = New FileStream(strPathToRentalTransactionFile, FileMode.Append, FileAccess.Write, FileShare.None)
        Dim RentalTranactionFileWriter As StreamWriter = New StreamWriter(RentalTransactionFileStream)
        Dim pointsToSpend = 0
        ' Get the most recent ID:
        If Not (txtPointsToSpend.Text = "") Then
            pointsToSpend = CInt(txtPointsToSpend.Text)
        End If
        Dim intPointsToSpend As Integer = 0
        If Not (txtPointsToSpend.Text = "") Then
            intPointsToSpend = CInt(txtPointsToSpend.Text)
        End If

        RentalTranactionFileWriter.WriteLine(strLastID & "," & txtToolID.Text & "," & customerDetails(0) & "," & FormatDateTime(Now, DateFormat.ShortDate) & "," & timDueDatePicker.Value & "," & "False" & "," & txtPriceToPayExVAT.Text & "," & txtPriceToPayIncVAT.Text & "," & intPointsToSpend & "," & intPointsToSpend * sngPointValue)
        RentalTranactionFileWriter.Flush()
        RentalTranactionFileWriter.Close()
        RentalTransactionFileStream.Close()

    End Sub
    Sub writeToSaleTransactionLog()
        Dim strLastID As String
        Dim strLastLine As String
        Dim strTransactionDetails() As String
        If File.ReadAllText(strPathToSaleTransactionFile).Length = 0 Then
            strLastID = "1"
        Else
            Dim lines As String() = IO.File.ReadAllLines(strPathToSaleTransactionFile)                                        'Finds the unique identifier of the last line. 
            strLastLine = (lines(lines.Length - 1))
            strTransactionDetails = strLastLine.Split(",")
            strLastID = CStr((CInt(strTransactionDetails(0)) + 1))                                                                             'The transaction ID of the first item in the batch is equal to 1 + last ID.
        End If


        Dim SaleTransactionFileStream = New FileStream(strPathToSaleTransactionFile, FileMode.Append, FileAccess.Write, FileShare.None)
        Dim SaleTranactionFileWriter As StreamWriter = New StreamWriter(SaleTransactionFileStream)

        ' Get the most recent ID:


        SaleTranactionFileWriter.WriteLine(strLastID & "," & txtToolID.Text & "," & FormatDateTime(Now, DateFormat.ShortDate) & "," & txtPriceToPayExVAT.Text & "," & txtPriceToPayIncVAT.Text)
        SaleTranactionFileWriter.Flush()
        SaleTranactionFileWriter.Close()
        SaleTranactionFileWriter.Close()

    End Sub

    Sub markRentalToolAsTaken()
        Dim toolRecord As String = ""
        Dim toolDetails() As String
        Dim toolFileReader As StreamReader = File.OpenText(strPathToInventoryFile)

        Dim FileStream = New FileStream(strPathToTempInventoryFile, FileMode.Append, FileAccess.Write, FileShare.None)
        Dim tempToolFileWriter As StreamWriter = New StreamWriter(FileStream)


        Do
            toolRecord = toolFileReader.ReadLine
            toolDetails = toolRecord.Split(",")
            If toolDetails(0) = txtToolID.Text Then
                tempToolFileWriter.WriteLine(toolDetails(0) & "," & toolDetails(1) & "," & toolDetails(2) & "," & toolDetails(3) & "," & toolDetails(4) & "," & toolDetails(5) & "," & toolDetails(6) & "," & toolDetails(7) & "," & toolDetails(8) & "," & "True")
            Else
                tempToolFileWriter.WriteLine(toolRecord)
            End If

        Loop Until toolFileReader.Peek = -1
        toolFileReader.Close()

        FileStream.Flush()
        tempToolFileWriter.Close()
        FileStream.Close()
        My.Computer.FileSystem.DeleteFile(strPathToInventoryFile)
        My.Computer.FileSystem.RenameFile(strPathToTempInventoryFile, "Inventory.txt")
    End Sub

    Private Sub txtPriceToPayIncVAT_TextChanged(sender As Object, e As EventArgs) Handles txtPriceToPayIncVAT.TextChanged

    End Sub
End Class
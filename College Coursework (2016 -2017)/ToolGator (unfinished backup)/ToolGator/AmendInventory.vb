Imports System.IO
Public Class AmendInventory
    Dim strSelectedRecord As String = ""

    Dim blnFilterRental As Boolean = False
    Dim blnFilterSale As Boolean = False
    Dim intCurrentToolID As Integer
    Private Sub btnPopulate_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulate.Click
        If radSale.Checked = True Then 'Filters
            blnFilterSale = True
            blnFilterRental = False
        End If
        If radRental.Checked = True Then
            blnFilterRental = True
            blnFilterSale = False
        End If

        tblInventory.Rows.Clear()
        ' For each record in the inventory, add to a temporary file according to the filters.
        CreateTempFile()
        PopulateTable()
        KillTemporaryFile()

    End Sub

    Sub CreateTempFile()
        Dim toolRecord As String = ""
        Dim toolDetails() As String
        Dim toolFileReader As StreamReader = File.OpenText(strPathToInventoryFile)

        Dim FileStream = New FileStream(strPathToTempInventoryFile, FileMode.Append, FileAccess.Write, FileShare.None)
        Dim tempToolFileWriter As StreamWriter = New StreamWriter(FileStream)


        Do
            toolRecord = toolFileReader.ReadLine
            toolDetails = toolRecord.Split(",")
            If (toolDetails(5) = "Sale" And blnFilterSale = True And MatchesAdditionalFilters(toolDetails) = True) Then ' We can add more filters here if needed.

                tempToolFileWriter.Write(toolRecord)
                tempToolFileWriter.WriteLine("")

            End If
            If (toolDetails(5) = "Rental" And blnFilterRental = True And MatchesAdditionalFilters(toolDetails) = True) Then

                tempToolFileWriter.Write(toolRecord)
                tempToolFileWriter.WriteLine("")
            End If

        Loop Until toolFileReader.Peek = -1
        toolFileReader.Close()

        FileStream.Flush()
        tempToolFileWriter.Close()
        FileStream.Close()


    End Sub
    Function MatchesAdditionalFilters(toolDetailsPassed() As String)
        ' Get the total number of filters to pass
        Dim requiredPasses = 0
        Dim Passes = 0
        If (chkToolIDFilter.Checked = True) Then
            requiredPasses += 1
        End If
        If (chkManufacturerFilter.Checked = True) Then
            requiredPasses += 1
        End If
        If (chkCategoryFilter.Checked = True) Then
            requiredPasses += 1
        End If
        If (chkTypeFilter.Checked = True) Then
            requiredPasses += 1
        End If

        If txtIToolDFilter.Enabled = True Then 'Tool ID filter
            If toolDetailsPassed(0) = txtIToolDFilter.Text Then
                'This has passed the first check
                Passes += 1
            End If
        End If

        If cmbManufacturerFilter.Enabled = True Then 'Tool ID filter
            If toolDetailsPassed(1) = cmbManufacturerFilter.Text Then
                'This has passed the second check
                Passes += 1
            End If
        End If

        If cmbCategoryFilter.Enabled = True Then 'Tool ID filter
            If toolDetailsPassed(2) = cmbCategoryFilter.Text Then
                'This has passed the first check
                Passes += 1
            End If
        End If

        If cmbTypeFilter.Enabled = True Then 'Tool ID filter
            If toolDetailsPassed(3) = cmbTypeFilter.Text Then
                'This has passed the first check
                Passes += 1
            End If
        End If


        If Passes >= requiredPasses Then
            Return True
        Else
            Return False
        End If

    End Function
    Sub PopulateTable()
        Dim x As Integer = 0
        Dim y As Integer = 0
        Dim toolRecord As String = ""
        Dim toolDetails() As String
        'Open the file reader so we can read the sorted and filtered temporary inventory file:
        Dim toolFileReader As StreamReader = File.OpenText(strPathToTempInventoryFile)

        Do
            x = 0
            toolRecord = toolFileReader.ReadLine
            If Not (toolRecord = "") Then
                toolDetails = toolRecord.Split(",")
                tblInventory.Rows.Add()
                For Each field As String In toolDetails ' Here we loop through each field in the record and add it to the table.
                    tblInventory.Rows(y).Cells(x).Value = field
                    x += 1
                Next

                y += 1
            End If
        Loop Until toolFileReader.Peek = -1
        toolFileReader.Close()
    End Sub


    Sub KillTemporaryFile()
        Kill(strPathToTempInventoryFile)
    End Sub


    Private Sub chkToolIDFilter_CheckedChanged(sender As Object, e As EventArgs) Handles chkToolIDFilter.CheckedChanged
        txtIToolDFilter.Enabled = chkToolIDFilter.CheckState
    End Sub

    Private Sub chkManufacturerFilter_CheckedChanged(sender As Object, e As EventArgs) Handles chkManufacturerFilter.CheckedChanged
        cmbManufacturerFilter.Enabled = chkManufacturerFilter.CheckState
    End Sub

    Private Sub chkCategoryFilter_CheckedChanged(sender As Object, e As EventArgs) Handles chkCategoryFilter.CheckedChanged
        cmbCategoryFilter.Enabled = chkCategoryFilter.CheckState
    End Sub

    Private Sub chkTypeFilter_CheckedChanged(sender As Object, e As EventArgs) Handles chkTypeFilter.CheckedChanged
        cmbTypeFilter.Enabled = chkTypeFilter.CheckState
    End Sub

    Private Sub AmendInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateManufacturerBox()
        PopulateCategoryBox()
        PopulateTypeBox()
        tblInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Sub PopulateManufacturerBox()
        cmbManufacturerFilter.Items.Clear()
        Dim manufacturerRecord As String = ""
        Dim manufacturerFileReader As StreamReader = File.OpenText(strPathToManufacturersFile)
        Do
            manufacturerRecord = manufacturerFileReader.ReadLine
            cmbManufacturerFilter.Items.Add(manufacturerRecord)

        Loop Until manufacturerFileReader.Peek = -1
        manufacturerFileReader.Close()
    End Sub

    Sub PopulateCategoryBox()
        cmbCategoryFilter.Items.Clear()
        Dim CategoryRecord As String = ""
        Dim CategoryFileReader As StreamReader = File.OpenText(strPathToToolCategoryFile)
        Do
            CategoryRecord = CategoryFileReader.ReadLine
            cmbCategoryFilter.Items.Add(CategoryRecord)

        Loop Until CategoryFileReader.Peek = -1
        CategoryFileReader.Close()
    End Sub

    Sub PopulateTypeBox()
        cmbTypeFilter.Items.Clear()
        Dim strTypeRecord As String = ""
        Dim TypeFileReader As StreamReader = File.OpenText(strPathToToolTypeFile)
        Do
            strTypeRecord = TypeFileReader.ReadLine
            cmbTypeFilter.Items.Add(strTypeRecord)

        Loop Until TypeFileReader.Peek = -1
        TypeFileReader.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        LoadRecordInformation()
    End Sub

    Sub LoadRecordInformation() 'Here we're just loading our fields with the data already in the record.
        intCurrentToolID = tblInventory.SelectedCells(0).Value
        cmbNewManufacturer.Text = tblInventory.SelectedCells(1).Value
        cmbNewCategory.Text = tblInventory.SelectedCells(2).Value
        cmbNewType.Text = tblInventory.SelectedCells(3).Value
        cmbNewName.Text = tblInventory.SelectedCells(4).Value
        cmbNewBaseCost.Text = tblInventory.SelectedCells(6).Value
        txtNewImagePath.Text = tblInventory.SelectedCells(7).Value
        txtNotes.Text = tblInventory.SelectedCells(8).Value
        If Me.tblInventory.SelectedCells(5).Value = "Rental" Then
            radNewRental.Checked = True
            radNewSale.Checked = False
        End If
        If Me.tblInventory.SelectedCells(5).Value = "Sale" Then
            radNewRental.Checked = False
            radNewSale.Checked = True
        End If
    End Sub

    Private Sub tblInventory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblInventory.CellClick
        LoadRecordInformation()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim FileDialog As OpenFileDialog = New OpenFileDialog() 'Defines a file dialog
        Dim strImageName As String
        Dim strImagePath As String
        FileDialog.Title = "Select tool image"
        FileDialog.InitialDirectory = strPathToImageDirectory
        FileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG " ' Only allows selection of image files
        FileDialog.RestoreDirectory = True ' If the file dialog is closed without selecting a file, it returns to the last open window when re-opened.
        If FileDialog.ShowDialog() = DialogResult.OK Then
            strImageName = FileDialog.FileName
            strImagePath = strImageName
            txtNewImagePath.Text = strImagePath
        End If

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        ' We now need to get the tool ID of the current tool, write the inventory up to this ID to a different file, append our line, then copy the rest.

        '   Dim intToolID As Integer
        Dim strNewStatus As String
        Dim strCurrentlyRented As String
        Dim length As Integer = File.ReadAllLines(strPathToInventoryFile).Length
        Dim loops As Integer = 0

        Dim FileStream = New FileStream(strPathToTempInventoryFile, FileMode.Append, FileAccess.Write, FileShare.None)
        Dim InventoryFileWriter As StreamWriter = New StreamWriter(FileStream)
        Dim toolFileReader As StreamReader = File.OpenText(strPathToInventoryFile)

        Dim strToolRecord As String
        Dim strToolArray As String()
        strCurrentlyRented = tblInventory.SelectedCells(9).Value


        For i = 1 To length                                               'Writes and reads n lines in the inventory file where n is the quantity.
            strToolRecord = toolFileReader.ReadLine
            strToolArray = strToolRecord.Split(",")
            If i = intCurrentToolID Then                       ' Write amended new line
                If radNewRental.Checked = True Then
                    strNewStatus = "Rental"
                End If
                If radNewSale.Checked = True Then
                    strNewStatus = "Sale"
                End If
                InventoryFileWriter.Write(intCurrentToolID & "," & cmbNewManufacturer.Text & "," & cmbNewCategory.Text & "," & cmbNewType.Text & "," & cmbNewName.Text & "," & strNewStatus & "," & cmbNewBaseCost.Text & "," & txtNewImagePath.Text & "," & txtNewNotes.Text & "," & strCurrentlyRented)
                InventoryFileWriter.WriteLine("")
            Else
                InventoryFileWriter.Write(strToolArray(0) & "," & strToolArray(1) & "," & strToolArray(2) & "," & strToolArray(3) & "," & strToolArray(4) & "," & strToolArray(5) & "," & strToolArray(6) & "," & strToolArray(7) & "," & strToolArray(8) & "," & strToolArray(9))
                InventoryFileWriter.WriteLine("") ' Blank line so that the program writes to a new line upon next input.
            End If
            loops += 1
        Next









        'Close the writers and readers
        InventoryFileWriter.Flush()
        FileStream.Flush()
        FileStream.Close()

        '  InventoryFileWriter.Close()
        toolFileReader.Close()

        'Delete old inventory
        My.Computer.FileSystem.DeleteFile(strPathToInventoryFile)
        My.Computer.FileSystem.RenameFile(strPathToTempInventoryFile, "Inventory.txt")
    End Sub

    Private Sub btnSelectToolSaleRental_Click(sender As Object, e As EventArgs) Handles btnSelectToolSaleRental.Click ' This litte function is only used 
        CustomerSaleRental.Enabled = True
        ' Now we're going to fill in our sale/rental fields in the other form
        CustomerSaleRental.txtToolID.Text = tblInventory.SelectedCells(0).Value
        CustomerSaleRental.txtManufacturer.Text = tblInventory.SelectedCells(1).Value
        CustomerSaleRental.txtCategory.Text = tblInventory.SelectedCells(2).Value
        CustomerSaleRental.txtType.Text = tblInventory.SelectedCells(3).Value
        CustomerSaleRental.txtName.Text = tblInventory.SelectedCells(4).Value
        'CustomerSaleRental.imgDisplay.BackgroundImage = Image.FromFile(tblInventory.SelectedCells(7).Value)
        If (tblInventory.SelectedCells(5).Value = "Rental") Then
            ' If it's a rental tool, then we fill in the fields with the relevant rental information and set the base cost.
            CustomerSaleRental.sngBaseCost = tblInventory.SelectedCells(6).Value
            CustomerSaleRental.txtToolPriceSale.Text = ""
            CustomerSaleRental.txtPointsToSpend.ReadOnly = False
            CustomerSaleRental.txtPriceToPayExVAT.Text = ""
            CustomerSaleRental.txtPriceToPayIncVAT.Text = ""
            CustomerSaleRental.timDueDatePicker.Enabled = True
            CustomerSaleRental.btnVerifyAdd.Enabled = True
        End If
        If (tblInventory.SelectedCells(5).Value = "Sale") Then
            ' If it's a rental tool, then we fill in the field and set the variable with the base price
            CustomerSaleRental.sngBaseCost = tblInventory.SelectedCells(6).Value
            CustomerSaleRental.txtToolPriceSale.Text = tblInventory.SelectedCells(6).Value
            CustomerSaleRental.txtCustomerName.Text = ""
            CustomerSaleRental.txtPointsToSpend.Text = ""
            CustomerSaleRental.txtPointsToSpend.ReadOnly = True
            CustomerSaleRental.txtPriceToPayExVAT.Text = tblInventory.SelectedCells(6).Value
            CustomerSaleRental.txtPriceToPayIncVAT.Text = tblInventory.SelectedCells(6).Value * My.Computer.FileSystem.ReadAllText(strPathToVATfile)
            CustomerSaleRental.timDueDatePicker.Enabled = False
            CustomerSaleRental.btnVerifyAdd.Enabled = False
            CustomerSaleRental.txtCurrentLoyaltyPoints.Text = ""
            CustomerSaleRental.txtPointsToBeGained.Text = ""
        End If

        ' We tell the sale/rental form whether the tool is for sale or rent
        CustomerSaleRental.strRentalSaleState = tblInventory.SelectedCells(5).Value




        Me.Close()
    End Sub
End Class
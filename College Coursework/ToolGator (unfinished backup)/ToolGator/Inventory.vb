Imports System.IO
Public Class addStock

    Dim imgToolImage As Image
    Dim strImagePath As String
    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        PopulateManufacturerBox()
        PopulateCategoryBox()
        PopulateTypeBox()
    End Sub

    Private Sub btnAddManufacturer_Click(sender As System.Object, e As System.EventArgs) Handles btnAddManufacturer.Click
        AddManufacturer.Show()
    End Sub

    Sub PopulateManufacturerBox()
        cmbManufacturer.Items.Clear()
        Dim manufacturerRecord As String = ""
        Dim manufacturerFileReader As StreamReader = File.OpenText(strPathToManufacturersFile)   'File does not exist
        Do
            manufacturerRecord = manufacturerFileReader.ReadLine
            cmbManufacturer.Items.Add(manufacturerRecord)

        Loop Until manufacturerFileReader.Peek = -1
        manufacturerFileReader.Close()
    End Sub

    Sub PopulateCategoryBox()
        cmbCategory.Items.Clear()
        Dim CategoryRecord As String = ""
        Dim CategoryFileReader As StreamReader = File.OpenText(strPathToToolCategoryFile)
        Do
            CategoryRecord = CategoryFileReader.ReadLine
            cmbCategory.Items.Add(CategoryRecord)

        Loop Until CategoryFileReader.Peek = -1
        CategoryFileReader.Close()
    End Sub

    Sub PopulateTypeBox()
        cmbToolType.Items.Clear()
        Dim strTypeRecord As String = ""
        Dim TypeFileReader As StreamReader = File.OpenText(strPathToToolTypeFile)
        Do
            strTypeRecord = TypeFileReader.ReadLine
            cmbToolType.Items.Add(strTypeRecord)

        Loop Until typeFileReader.Peek = -1
        TypeFileReader.Close()
    End Sub

    Sub PopulateNameBox()
        'Subroutine used for recalling tool names and suggesting them in combobox. Useful for long and forgettable tool names.
        'Check inventory for names if manufacturer, category, and type match user input. 
        'If inventory is empty, don't bother.
            If Not (File.ReadAllText(strPathToInventoryFile).Length = 0) Then
            cmbToolName.Items.Clear()
            Dim strRecord() As String
            Dim strManufacturer = cmbManufacturer.Text
            Dim strCategory = cmbCategory.Text
            Dim strType = cmbToolType.Text
            Dim intCurrentElement = 0
            Dim lstAddedNames As New List(Of String)() 'List used to avoid error instead of an array (add is not a valid memeber). Holds names added to name combobox, including duplicates.
            Dim blnCanAdd = True
            Dim lstRemovals As New List(Of String)()
            Dim NameFileReader As StreamReader = File.OpenText(strPathToInventoryFile)
                Do
                strRecord = NameFileReader.ReadLine.Split(",")      'Splits last read record into separate string elements
                If (strManufacturer = strRecord(1) And strCategory = strRecord(2) And strType = strRecord(3)) Then  'Compares selected manufacturer, category, and type to that of the last read line in the inventory text file (strRecord).
                    For i = 0 To (lstAddedNames.Count - 1) 'For each element in list, check if already added. If yes, do not add to final list.
                        If lstAddedNames(i) = strRecord(4) Then
                            blnCanAdd = False
                        End If
                    Next

                    If blnCanAdd = True Then
                        lstAddedNames.Add(strRecord(4))            'List of all compatible names, includes duplicates.
                    End If

                    blnCanAdd = True
                End If

                Loop Until NameFileReader.Peek = -1
                ' For each element
                '   Check each previous element
                '   Delete if equal
            For Each UniqueName In lstAddedNames
                cmbToolName.Items.Add(UniqueName)
            Next
                NameFileReader.Close()
            End If
    End Sub

    ' TO DO --- DO THIS SAME ALGORITH FOR RENTAL OR SALE PRICE



    Private Sub addStock_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load                       'All files are created if not already created

    End Sub



    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        PopulateManufacturerBox()
        PopulateCategoryBox()
        PopulateTypeBox()
        PopulateNameBox()
    End Sub

    Private Sub btnAddToolCategory_Click(sender As System.Object, e As System.EventArgs) Handles btnAddToolCategory.Click
        AddCategory.Show()
    End Sub

    Private Sub btnAddToolType_Click(sender As System.Object, e As System.EventArgs) Handles btnAddToolType.Click
        AddToolType.Show()
    End Sub

    Private Sub btnAddTool_Click(sender As System.Object, e As System.EventArgs) Handles btnAddTool.Click

        Dim strLastLine As String = ""
        Dim strToolDetails() As String             ' ID - Manufacturer - Category - Type - Name - Sale/Rental - Sale Price/Base Cost - Image File Destination
        Dim strLastID = "1"
        Dim strSaleType = ""
        Dim strCost = ""


        'Finds Current ID from inventory (Read inventory. If no lines, start at 0001)
        If File.ReadAllText(strPathToInventoryFile).Length = 0 Then
            strLastID = "1"
        Else
            Dim lines As String() = IO.File.ReadAllLines(strPathToInventoryFile)                                        'Finds the unique identifier of the last line. 
            strLastLine = (lines(lines.Length - 1))
            strToolDetails = strLastLine.Split(",")
            strLastID = CStr((CInt(strToolDetails(0)) + 1))                                                                             'The tool ID of the first item in the batch is equal to 1 + last ID.
        End If

        Dim FileStream = New FileStream(strPathToInventoryFile, FileMode.Append, FileAccess.Write, FileShare.None)
        Dim InventoryFileWriter As StreamWriter = New StreamWriter(FileStream)

        If radRental.Checked = True Then
            strSaleType = "Rental"
        End If
        If radSale.Checked = True Then
            strSaleType = "Sale"
        End If

        'Checks if the tools to be added are for rent or sale - prevents double input.
        If radRental.Checked Then
            strCost = CStr(cmbRentalBaseCost.Text)
        End If
        If radSale.Checked Then
            strCost = CStr(cmbSalePrice.Text)
        End If


        For i = 0 To CInt(txtQuantity.Text) - 1 'Writes n lines in the inventory file where n is the quantity.
            InventoryFileWriter.Write(strLastID & "," & cmbManufacturer.Text & "," & cmbCategory.Text & "," & cmbToolType.Text & "," & cmbToolName.Text & "," & strSaleType & "," & strCost & "," & strImagePath & "," & "-" & "," & "False")
            InventoryFileWriter.WriteLine("") ' Blank line so that the program writes to a new line upon next input.
            strLastID += 1  'ID Increments by 1

        Next
        InventoryFileWriter.Close()
        'FileStream.Flush()
        FileStream.Close()




        'Create new record per quantity, increment ID

        'Save new inventory file
    End Sub

    Private Sub radSale_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radSale.CheckedChanged
        If radSale.Checked Then
            cmbSalePrice.Enabled = True
            cmbRentalBaseCost.Enabled = False
        End If
    End Sub

    Private Sub radRental_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radRental.CheckedChanged
        If radRental.Checked Then
            cmbSalePrice.Enabled = False
            cmbRentalBaseCost.Enabled = True
        End If
    End Sub


    Private Sub btnImportImage_Click(sender As System.Object, e As System.EventArgs) Handles btnImportImage.Click
        ' Opens the image directory
        Process.Start("explorer.exe", strPathToImageDirectory)
    End Sub

    Sub btnSelectImage_Click(sender As System.Object, e As System.EventArgs) Handles btnSelectImage.Click
        Dim FileDialog As OpenFileDialog = New OpenFileDialog() 'Defines a file dialog
        Dim strImageName As String
        FileDialog.Title = "Select tool image"
        FileDialog.InitialDirectory = strPathToImageDirectory
        FileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG " ' Only allows selection of image files
        FileDialog.RestoreDirectory = True ' If the file dialog is closed without selecting a file, it returns to the last open window when re-opened.
        If FileDialog.ShowDialog() = DialogResult.OK Then
            Dim FileInfo As New FileInfo(FileDialog.FileName)
            strImageName = Application.StartupPath + "\ImageDirectory" + "\" + FileInfo.Name ' we need to change strPathToImageDirectory to a local path
            strImagePath = strImageName
            imgToolImage = Image.FromFile(strImageName)
            iboxToolPreview.BackgroundImage = imgToolImage
        End If

    End Sub

    Private Sub cmbRentalBaseCost_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRentalBaseCost.SelectedIndexChanged

    End Sub
End Class
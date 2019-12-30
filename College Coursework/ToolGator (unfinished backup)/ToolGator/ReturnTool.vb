Imports System.IO
Public Class ReturnTool


    Private Sub btnGetTools_Click(sender As Object, e As EventArgs) Handles btnGetTools.Click
        GetTools()

    End Sub

    Sub GetTools()
        Dim strCustomerDetails() As String
        Dim strTransactionDetailsArray() As String
        Dim strToolDetailsArray() As String
        Dim lstToolIDList As New List(Of String)
        Dim strFinalToolDetailsArray() As String

        Dim strForename = txtCustomerForename.Text
        Dim strSurname = txtCustomerSurname.Text
        Dim strAddress = txtCustomerAddress.Text
        Dim strCustomerID = "0"
        Dim i = 0
        ' Get customer ID
        Dim strNameOnFile As String = strForename
        For Each Line As String In File.ReadLines(strPathToCustomerFile)
            strCustomerDetails = Line.Split(",")
            If strCustomerDetails(1) = strForename And strCustomerDetails(2) = strSurname And strCustomerDetails(5) = strAddress Then


                strCustomerID = strCustomerDetails(0)
            End If
        Next
        'Get Tool IDs
        For Each Line As String In File.ReadLines(strPathToRentalTransactionFile)
            strTransactionDetailsArray = Line.Split(",")
            If strTransactionDetailsArray(2) = strCustomerID And strTransactionDetailsArray(5) = "False" Then

                ' Do something...Print the line

                lstToolIDList.Add(strTransactionDetailsArray(1))

                i += 1
            End If

        Next
        'Get Tools
        i = 0
        For Each Line As String In File.ReadLines(strPathToInventoryFile)
            strToolDetailsArray = Line.Split(",")
            For Each id As String In lstToolIDList
                If strToolDetailsArray(0) = id Then

                    ' Do something...Print the line

                    lstCurrentlyRentedTools.Items.Add(strToolDetailsArray(0) + "," + strToolDetailsArray(1) + "," + strToolDetailsArray(2) + "," + strToolDetailsArray(3) + "," + strToolDetailsArray(4))

                End If
                i += 1
            Next


        Next
    End Sub

    Sub ReturnTool()


        Dim tempInventoryStream = New FileStream(strPathToTempInventoryFile, FileMode.Append, FileAccess.Write, FileShare.None)
        Dim tempInventoryFileWriter As StreamWriter = New StreamWriter(tempInventoryStream)


        Dim strToolDetailsArray() As String
        Dim strToolDetailsArray2() As String

        Dim strToolDetailsRecord = lstCurrentlyRentedTools.SelectedItem.ToString()
        strToolDetailsArray = strToolDetailsRecord.Split(",")

        txtTest.Text = strToolDetailsArray(0)
        Dim id As String = strToolDetailsArray(0)
        For Each Line As String In File.ReadLines(strPathToInventoryFile)
            strToolDetailsArray2 = Line.Split(",")
            If strToolDetailsArray2(0) = id Then
                strToolDetailsArray2(9) = “False”

            End If
            'Copy line to new file by writing array to file
            tempInventoryFileWriter.WriteLine(strToolDetailsArray2(0) + "," + strToolDetailsArray2(1) + "," + strToolDetailsArray2(2) + "," + strToolDetailsArray2(3) + "," + strToolDetailsArray2(4) + "," + strToolDetailsArray2(5) + "," + strToolDetailsArray2(6) + "," + strToolDetailsArray2(7) + "," + strToolDetailsArray2(8) + "," + strToolDetailsArray2(9))
        Next
        tempInventoryFileWriter.Flush()
        tempInventoryStream.Flush()
        tempInventoryFileWriter.Close()
        tempInventoryStream.Close()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblForename.Click

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        ReturnTool()

    End Sub
End Class
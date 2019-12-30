Imports System.IO

Public Class AddManufacturer

    Private Sub btnConfirm_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirm.Click
        Dim strManufacturerName As String = txtNewName.Text
        Dim FileStream = New FileStream(strPathToManufacturersFile, FileMode.Append, FileAccess.Write, FileShare.None)
        Dim ManufacturerFileWriter As StreamWriter = New StreamWriter(FileStream)
        ManufacturerFileWriter.WriteLine("")
        ManufacturerFileWriter.Write(strManufacturerName)
        FileStream.Flush()
        ManufacturerFileWriter.Close()
        FileStream.Close()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


    Private Sub AddManufacturer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
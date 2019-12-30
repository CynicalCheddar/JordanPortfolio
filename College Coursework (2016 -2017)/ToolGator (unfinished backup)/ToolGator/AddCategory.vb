Imports System.IO
Public Class AddCategory

    Private Sub btnConfirm_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirm.Click
        Dim strCategoryName As String = txtNewName.Text
        Dim FileStream = New FileStream(strPathToToolCategoryFile, FileMode.Append, FileAccess.Write, FileShare.None)
        Dim CategoryFileWriter As StreamWriter = New StreamWriter(FileStream)
        CategoryFileWriter.WriteLine(strCategoryName)
        FileStream.Flush()
        CategoryFileWriter.Close()
        FileStream.Close()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub AddCategory_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
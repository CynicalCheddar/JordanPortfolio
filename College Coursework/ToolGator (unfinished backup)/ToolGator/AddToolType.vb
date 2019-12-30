Imports System.IO


Public Class AddToolType

    Private Sub btnConfirm_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirm.Click
        Dim strToolTypeName As String = txtNewName.Text
        Dim FileStream = New FileStream(strPathToToolTypeFile, FileMode.Append, FileAccess.Write, FileShare.None)
        Dim ToolTypeFileWriter As StreamWriter = New StreamWriter(FileStream)
        ToolTypeFileWriter.WriteLine(strToolTypeName)
        FileStream.Flush()
        ToolTypeFileWriter.Close()
        FileStream.Close()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub AddToolType_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
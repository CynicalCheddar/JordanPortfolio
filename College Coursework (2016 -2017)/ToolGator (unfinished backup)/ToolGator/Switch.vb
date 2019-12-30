Public Class Switch

    Private Sub btnCreateAccount_Click(sender As System.Object, e As System.EventArgs) Handles btnCreateAccount.Click
        AccountCreation.Show()
        Me.Close()

    End Sub

    Private Sub Switch_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Not (strLevel = "Admin") Then
            btnCreateAccount.Enabled = False
        End If
    End Sub

    Private Sub btnView_Click(sender As System.Object, e As System.EventArgs) Handles btnView.Click
        ViewAll.Show()
        Me.Close()

    End Sub

    Private Sub btnStock_Click(sender As System.Object, e As System.EventArgs) Handles btnStock.Click

    End Sub

    Private Sub btnAddStock_Click(sender As System.Object, e As System.EventArgs) Handles btnAddStock.Click
        addStock.Show()
        Me.Close()
    End Sub

    Private Sub btnAmendView_Click(sender As System.Object, e As System.EventArgs) Handles btnAmendView.Click
        AmendInventory.Show()
        Me.Close()
    End Sub

    Private Sub btnCustomerSaleRental_Click(sender As Object, e As EventArgs) Handles btnCustomerSaleRental.Click
        CustomerSaleRental.Show()
        Me.Close()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        ReturnTool.Show()
        Me.Close()
    End Sub
End Class
Public Class Editstock
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Admin.Show()
        Me.Close()
    End Sub

    Private Sub btnAddstock_Click(sender As Object, e As EventArgs) Handles btnAddstock.Click
        Addstock.Show() 'opens add stock form
        Me.Close() 'closes form 
    End Sub

    Private Sub btnUpdatestockinfo_Click(sender As Object, e As EventArgs) Handles btnUpdatestockinfo.Click
        Updatestockinfo.Show() 'opens updatestockinfo form 
        Me.Close() 'closes the form
    End Sub

    Private Sub btnRemovestock_Click(sender As Object, e As EventArgs) Handles btnRemovestock.Click
        RemovePurchase.Show()
        Me.Close()
    End Sub
End Class
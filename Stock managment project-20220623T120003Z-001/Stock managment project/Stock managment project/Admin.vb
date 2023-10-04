Public Class Admin
    Private Sub btnEditusers_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Form1.Show() 'opens form1
        Me.Close() 'closes the form
    End Sub

    Private Sub btnEditstock_Click(sender As Object, e As EventArgs) Handles btnEditstock.Click
        Editstock.Show() 'opens edit stock form
        Me.Close() 'closes the form
    End Sub

    Private Sub btnSearchstock_Click(sender As Object, e As EventArgs) Handles btnSearchstock.Click
        searchstock.Show() 'opens search stock form
        Me.Close() 'closes the form
    End Sub

    Private Sub btnStockLevels_Click(sender As Object, e As EventArgs) Handles btnStockLevels.Click
        Stocklevel.Show() 'opens stock level form 
        Me.Close() 'closes the form
    End Sub

    Private Sub btnUserReport_Click(sender As Object, e As EventArgs) Handles btnUserReport.Click
        UserReport.Show() 'opens user report form 
        Me.Close() 'closes the form
    End Sub

    Private Sub btnProfit_Click(sender As Object, e As EventArgs) Handles btnProfit.Click
        ProfitCalculator.Show() 'opens profit calculator form
        Me.Close() 'closes the form
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Login.Show() 'opens login form
        Me.Close() 'closes the form 
    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileOpen(1, "CurrentUser.txt", OpenMode.Random,,, Len(CurrentUser)) 'opens currentuser.txt
        FileGet(1, CurrentUser) 'gets the records from currentuser.txt
        lblWelcome.Text = "Welcome " & CurrentUser.firstname & " " & CurrentUser.lastname 'will display firstname and lastname records in a welcome message
        FileClose(1) 'closes the file 
        FileOpen(2, "CurrentUser.txt", OpenMode.Random,,, Len(CurrentUser))
        If CurrentUser.level = "Staff" Then
            btnUpdate.Visible = False
            btnUserReport.Visible = False
        End If
        FileClose(2)
    End Sub
End Class
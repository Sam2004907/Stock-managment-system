Public Class searchstock
    Dim numberofrecords As Integer 'sets number of records as a global integer
    Private Sub searchstock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileOpen(1, "stock.txt", OpenMode.Random,,, Len(Stock)) 'opens stock.txt
        numberofrecords = LOF(1) / Len(Stock) 'calculates number of records
        FileClose(1) 'closes file
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim found As Boolean 'sets variable as boolean
        Dim index, level As Integer 'sets variable as integer
        Dim name As String 'sets variable as string
        name = txtName.Text 'sets the variable name to the text in the text box txtName
        If txtName.Text = "" Then 'validates wether or not dat has been entered into the text box
            MsgBox("please enter a product name to be searched for") 'if it fails the validation the user is promted to enter something
        Else 'if validation is passed code below is ran
            FileOpen(1, "stock.txt", OpenMode.Random,,, Len(Stock)) 'opens stock.txt
            Do Until EOF(1) Or found = True 'creates a loop that is only broken if the product is found or the program reaches end of file
                FileGet(1, Stock) 'gets the records from stock
                index = index + 1 'increases the index by 1 
                If Stock.product = txtName.Text.PadRight(10) Then 'checks if the name entered matches product name 
                    found = True 'if they do match found is set to true
                End If
            Loop
            If found = True Then 'checks wether or not product was found
                level = Stock.level 'gets the stock level of the product name
                lblOutput.Text = name & " currently has " & level & " in stock" 'label outputs this message stating name and current level
            Else
                MsgBox("product not found") 'if the product wasn't found the system will display this message
            End If
            FileClose(1) 'closes the file
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FileOpen(2, "CurrentUser.txt", OpenMode.Random,,, Len(CurrentUser)) 'opens CurrentUser.txt
        FileGet(2, CurrentUser) 'retrieves records stroed
        If CurrentUser.level = "Admin" Then 'checks the access level and opens the correct home screen
            FileClose(2)
            Admin.Show()
            Me.Close()
        Else
            FileClose(2)
            Staff.Show()
            Me.Close()
        End If
    End Sub
End Class
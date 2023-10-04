Public Class UserReport
    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim firstname, lastname, email, output As String 'sets the variables to string data type
        lsbOutput.Items.Clear()
        FileOpen(1, "workers.txt", OpenMode.Random,,, Len(workers)) 'opens workers.txt
        Do Until EOF(1) 'creats a loop that only breaks when the end of file is reached
            FileGet(1, workers) 'gets the records
            firstname = workers.firstname 'assigns a record to a variable
            lastname = workers.lastname
            email = workers.email
            output = firstname & " " & lastname & " " & email 'puts all of the variables into one long string to be used as the object for adding to the listbox
            lsbOutput.Items.Add(output) 'adds the data to the listbox
        Loop
        FileClose() 'closes file
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Admin.Show() 'opens admin form
        Me.Close() 'closes this form
    End Sub
End Class
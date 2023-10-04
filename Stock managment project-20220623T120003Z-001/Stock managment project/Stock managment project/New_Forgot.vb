Public Class New_Forgot
    Dim numberofrecords As Integer 'sets numberofrecords variable to an integer and global scope.
    Private Sub New_Forgot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileOpen(1, "workers.txt", OpenMode.Random,,, Len(workers))
        numberofrecords = LOF(1) / Len(workers) 'sets number of records to the number of lines in the file
        FileClose(1)
    End Sub
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        If txtFirstname.Text.Length = 0 Then 'makes sure that something is typesd into the text box
            MsgBox("Enter a first name") 'displays message to enter something
        ElseIf txtLastname.Text.Length = 0 Then 'makes sure something is typed into the text box
            MsgBox("Enter a last name") 'displays message to enter something into the box
        ElseIf txtCode.Text.Length <> 4 Then 'makes sure that the code length is 4 
            MsgBox("wrong code length") 'displays message to make sure length is correct
        ElseIf txtEmail.Text.Length = 0 Then 'makes sure something is typed into the text box
            MsgBox("Enter an email address. if there is no email address for this employee enter N/A into the box") 'displays message to enter something into the box
        ElseIf txtPhonenum.Text.Length <> 11 Then 'makes sure that the phone number entered length is 11
            MsgBox("The number you have entered is the wrong length, please make sure there are no spaces in the number.") 'displays message to make sure length is correct
        ElseIf txtAddress.Text.Length = 0 Then 'makes sure something is typed into the text box
            MsgBox("Enter an address. If there is no address then enter N/A.") 'displays message to enter something into the box
        ElseIf txtPostcode.Text.Length = 0 Then 'makes sure something is typed into the text box
            MsgBox("Enter a postcode. if there is no postcode then enter N/A.") 'displays message to enter something into the box
        Else
            workers.firstname = txtFirstname.Text 'sets the record firstname to the data in the textbox
            workers.lastname = txtLastname.Text 'sets the record lastname to the data in the textbox
            workers.code = txtCode.Text 'sets the record code to the data in the textbox
            workers.email = txtEmail.Text 'sets the record email to the data in the textbox
            workers.phonenum = txtPhonenum.Text 'sets the record phonenum to the data in the textbox
            workers.address = txtAddress.Text 'sets the record address to the data in the textbox
            workers.postcode = txtPostcode.Text 'sets the record postcode to the data in the textbox
            workers.level = "Staff" 'sets the record level to the data in the textbox
            workers.username = txtFirstname.Text.Substring(0, 1) & txtLastname.Text.Substring(0, 1) & "Staff" ' uses string handling to set the username to the first letter of their firstname, the secondletter of their last name and their access level.
            MsgBox("Your username is " & workers.username & " and your passwrod is " & workers.code & " Please make a note of this") ' displays a message with the users username and paswword
            FileOpen(1, "workers.txt", OpenMode.Random,,, Len(workers)) ' opens the random access file workers.txt
            FilePut(1, workers, numberofrecords + 1) ' puts the new data into the database
            FileClose(1) ' closes the file 
            FileOpen(2, "CurrentUser.txt", OpenMode.Random,,, Len(CurrentUser)) 'opens CurrentUser.txt
            CurrentUser.username = workers.username 'assigns the username stored in workers to the username in CurrentUser
            CurrentUser.firstname = workers.firstname 'assigns the first name stored in workers to the first name in CurrentUser
            CurrentUser.lastname = workers.lastname 'assigns the last name stored in workers to the last name in CurrentUser
            CurrentUser.level = workers.level 'assigns the access level stored in workers to the access level in CurrentUser
            FilePut(2, CurrentUser) 'puts the data into the file 
            FileClose(2) 'closes CurrentUser
            txtFirstname.Text = "" ' resets all the text boxes to blank
            txtLastname.Text = ""
            txtCode.Text = ""
            txtEmail.Text = ""
            txtPhonenum.Text = ""
            txtAddress.Text = ""
            txtPostcode.Text = ""
            numberofrecords = numberofrecords + 1
        End If ' ends if statement
        MsgBox("You have been given an automatic access level of 'Staff', if you wish to change this please contact an admin.")
        Admin.Show()
        Me.Close()
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        Dim username As String 'sets the 2 variables to strings
        Dim found As Boolean 'sets found to a boolean
        Dim index, confirm, change As Integer ' sets index confirm and change to integers
        If txtAdminCode.Text = "" Or txtUsername1.Text = "" Or txtNewpassword.Text = "" Or txtConfirmpassword.Text = "" Then
            MsgBox("please enter usernmae, password, new password and confirm password.")
        Else
            username = txtUsername1.Text.PadRight(10) 'pads out the entered value so that it can be compared to the record in the database
            found = False
            index = 0
            change = txtNewpassword.Text
            confirm = txtConfirmpassword.Text
            If txtAdminCode.Text.Length <> 4 Then 'checks to make sure that the new passwords are of correct length
                MsgBox("please entetr your current password")
            ElseIf txtNewpassword.Text.Length <> 4 Then
                MsgBox("please enter new password at the correct length")
            ElseIf txtConfirmpassword.Text.Length <> 4 Then
                MsgBox("please enter new password to confirm at correct length")
            ElseIf txtUsername1.Text.Length = 0 Then
                MsgBox("please enter your current username")
            Else
                If change <> confirm Then ' makes sure that the new password has been entered correctly
                    MsgBox("You new password does not match the confirm please make sure you have entered this correctly.")
                Else
                    FileOpen(1, "workers.txt", OpenMode.Random,,, Len(workers)) ' opens the random access file workers.txt
                    Do Until EOF(1) Or found = True 'searches the file until the record is found or the file reaches the end
                        FileGet(1, workers)
                        index = index + 1
                        If workers.username = username And txtAdminCode.Text = "7689" Then
                            found = True
                        End If
                    Loop
                    If found = True Then
                        workers.code = txtNewpassword.Text
                        FilePut(1, workers, index) 'changes the record if found is true to the new password.
                        lblConfirm1.Text = "your password has been changed"
                    Else
                        lblConfirm1.Text = "username not found or password is incorrect"
                    End If
                    FileClose(1) 'closes file
                End If
            End If
        End If
        txtNewpassword.Text = "" 'sets all the text boxes to blank to be used next time
        txtConfirmpassword.Text = ""
        txtAdminCode.Text = ""
        txtUsername1.Text = ""
    End Sub
    Private Sub txtCode_KeyPressed(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCode.KeyPress ' creates a subroutine that detects what keys are beng pressed to make sure they are numbers
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then ' makes sure only numbers can be entered
            Dim title = "Warning Message" ' sets title to warning message
            MessageBox.Show("Please enter numbers only", title) 'if the condition is met a warning message is displayed 
            e.Handled = True 'makes sure the system knows that the message has been displayed
        End If
    End Sub
    Private Sub txtPhonenum_KeyPressed(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhonenum.KeyPress ' creates a subroutine that detects what keys are beng pressed to make sure they are numbers for the phone number
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then ' makes sure only numbers can be entered
            Dim title = "Warning Message" ' sets title to warning message
            MessageBox.Show("Please enter numbers only", title) 'if the condition is met a warning message is displayed 
            e.Handled = True 'makes sure the system knows that the message has been displayed
        End If
    End Sub
    Private Sub txtNewpassword_KeyPressed(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNewpassword.KeyPress
        ' creates a subroutine that detects what keys are beng pressed to make sure they are numbers
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then ' makes sure only numbers can be entered
            Dim title = "Warning Message" ' sets title to warning message
            MessageBox.Show("Please enter numbers only", title) 'if the condition is met a warning message is displayed 
            e.Handled = True 'makes sure the system knows that the message has been displayed
        End If
    End Sub
    Private Sub txtConfirmpassword_KeyPressed(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConfirmpassword.KeyPress ' creates a subroutine that detects what keys are beng pressed to make sure they are numbers for the phone number
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then ' makes sure only numbers can be entered
            Dim title = "Warning Message" ' sets title to warning message
            MessageBox.Show("Please enter numbers only", title) 'if the condition is met a warning message is displayed 
            e.Handled = True 'makes sure the system knows that the message has been displayed
        End If
    End Sub
    Private Sub txtCurrentpassword_KeyPressed(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAdminCode.KeyPress ' creates a subroutine that detects what keys are beng pressed to make sure they are numbers for the phone number
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then ' makes sure only numbers can be entered
            Dim title = "Warning Message" ' sets title to warning message
            MessageBox.Show("Please enter numbers only", title) 'if the condition is met a warning message is displayed 
            e.Handled = True 'makes sure the system knows that the message has been displayed
        End If
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Login.Show()
        Me.Close()
    End Sub
End Class
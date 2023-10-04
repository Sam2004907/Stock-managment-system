Public Class Form1
    Dim numberofrecords As Integer 'sets numberofrecords variable to an integer and global scope.
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileOpen(1, "workers.txt", OpenMode.Random,,, Len(workers))
        numberofrecords = LOF(1) / Len(workers) 'sets number of records to the number of lines in the file
        FileClose(1)
        FileOpen(2, "CurrentUser.txt", OpenMode.Random,,, Len(CurrentUser))
        If CurrentUser.level = "Staff" Then
            gbxAdd.Visible = False
            gbxRemove.Visible = False
        End If
        FileClose(2)
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
        ElseIf txtPostcode.text.length = 0 Then 'makes sure something is typed into the text box
            MsgBox("Enter a postcode. if there is no postcode then enter N/A.") 'displays message to enter something into the box
        Else
            workers.firstname = txtFirstname.Text 'sets the record firstname to the data in the textbox
            workers.lastname = txtLastname.Text 'sets the record lastname to the data in the textbox
            workers.code = txtCode.Text 'sets the record code to the data in the textbox
            workers.email = txtEmail.Text 'sets the record email to the data in the textbox
            workers.phonenum = txtPhonenum.Text 'sets the record phonenum to the data in the textbox
            workers.address = txtAddress.Text 'sets the record address to the data in the textbox
            workers.postcode = txtPostcode.Text 'sets the record postcode to the data in the textbox
            workers.level = cbxLevel.Text 'sets the record level to the data in the textbox
            workers.username = txtFirstname.Text.Substring(0, 1) & txtLastname.Text.Substring(0, 1) & cbxLevel.Text ' uses string handling to set the username to the first letter of their firstname, the secondletter of their last name and their access level.
            MsgBox("Your username is " & workers.username & " and your passwrod is " & workers.code & " Please make a note of this") ' displays a message with the users username and paswword
            If cbxLevel.Text = "Admin" Then
                MsgBox("Admin code is 7689")
            End If
            FileOpen(1, "workers.txt", OpenMode.Random,,, Len(workers)) ' opens the random access file workers.txt
            FilePut(1, workers, numberofrecords + 1) ' puts the new data into the database
            FileClose(1) ' closes the file 
            txtFirstname.Text = "" ' resets all the text boxes to blank
            txtLastname.Text = ""
            txtCode.Text = ""
            txtEmail.Text = ""
            txtPhonenum.Text = ""
            txtAddress.Text = ""
            txtPostcode.Text = ""
            numberofrecords = numberofrecords + 1
        End If ' ends if statement
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

    Private Sub btnChnage_Click(sender As Object, e As EventArgs) Handles btnChnageUsername.Click
        Dim current, change, confirm As String 'defines the variables as strings
        Dim found As Boolean ' set found to a boolean value 
        Dim index As Integer ' sets index to an integer value
        found = False
        index = 0
        current = txtCurrent.Text.PadRight(10) 'pads out the remaining letters to make sure that they follow the database rules and can be matched against items in database.
        change = txtChange.Text.PadRight(10)
        confirm = txtConfirm.Text.PadRight(10)
        If txtCurrent.Text.Length = 0 Then ' checks to makes sure a value has been enetered
            MsgBox("please entetr your current username")
        ElseIf txtChange.Text.Length = 0 Then
            MsgBox("please enter new username")
        ElseIf txtConfirm.Text.Length = 0 Then
            MsgBox("please enter new username to confirm")
        Else
            If change <> confirm Then ' makes sure that the confirm matches the first change to make sure it was entered correctly
                MsgBox("You new username is does not match the confirm please make sure you have entered this correctly.")
            Else
                FileOpen(1, "workers.txt", OpenMode.Random,,, Len(workers)) ' opens the random access file workers.txt
                Do Until EOF(1) Or found = True ' searches the file until its found or the file reaches the end 
                    FileGet(1, workers)
                    index = index + 1
                    If workers.username = current Then
                        found = True
                    End If
                Loop
                If found = True Then
                    workers.username = txtChange.Text
                    FilePut(1, workers, index) 'changes the record in the database to the new value
                    lblConfirm.Text = "your username has been changed"
                Else
                    lblConfirm.Text = "username not found"
                End If
                FileClose(1) ' closes the file
            End If
        End If
        txtChange.Text = "" ' resets all the text boxes yo blank for the next user.
        txtConfirm.Text = ""
        txtCurrent.Text = ""
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        Dim current, username As String 'sets the 2 variables to strings
        Dim found As Boolean 'sets found to a boolean
        Dim index, confirm, change As Integer ' sets index confirm and change to integers
        If txtCurrentpassword.Text = "" Or txtUsername1.Text = "" Or txtNewpassword.Text = "" Or txtConfirmpassword.Text = "" Then
            MsgBox("please enter usernmae, password, new password and confirm password.")
        Else
            username = txtUsername1.Text.PadRight(10) 'pads out the entered value so that it can be compared to the record in the database
            found = False
            index = 0
            current = txtCurrentpassword.Text
            change = txtNewpassword.Text
            confirm = txtConfirmpassword.Text
            If txtCurrentpassword.Text.Length <> 4 Then 'checks to make sure that the new passwords are of correct length
                MsgBox("please entetr your current password")
            ElseIf txtNewpassword.Text.Length <> 4 Then
                MsgBox("please enter new password at the correct length")
            ElseIf txtConfirmpassword.Text.Length <> 4 Then
                MsgBox("please enter new password to confirm at correct length")
            ElseIf txtUsername1.Text.Length = 0 Then
                MsgBox("please enter your current username")
            Else
                If change <> confirm Then ' makes sure that the new password has been entered correctly
                    MsgBox("You new password is does not match the confirm please make sure you have entered this correctly.")
                Else
                    FileOpen(1, "workers.txt", OpenMode.Random,,, Len(workers)) ' opens the random access file workers.txt
                    Do Until EOF(1) Or found = True 'searches the file until the record is found or the file reaches the end
                        FileGet(1, workers)
                        index = index + 1
                        If workers.code = current And workers.username = username Then
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
        txtCurrentpassword.Text = ""
        txtUsername1.Text = ""
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
    Private Sub txtCurrentpassword_KeyPressed(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCurrentpassword.KeyPress ' creates a subroutine that detects what keys are beng pressed to make sure they are numbers for the phone number
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then ' makes sure only numbers can be entered
            Dim title = "Warning Message" ' sets title to warning message
            MessageBox.Show("Please enter numbers only", title) 'if the condition is met a warning message is displayed 
            e.Handled = True 'makes sure the system knows that the message has been displayed
        End If
    End Sub
    Private Sub txtPassword_KeyPressed(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress ' creates a subroutine that detects what keys are beng pressed to make sure they are numbers for the phone number
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then ' makes sure only numbers can be entered
            Dim title = "Warning Message" ' sets title to warning message
            MessageBox.Show("Please enter numbers only", title) 'if the condition is met a warning message is displayed 
            e.Handled = True 'makes sure the system knows that the message has been displayed
        End If
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim index As Integer
        Dim found As Boolean
        index = 0
        found = False
        If txtUsername.Text.Length = 0 And txtPassword.Text.Length = 0 Then 'makes sure that a username and password has been entered
            MsgBox("enter username and password to update details")
        Else
            FileOpen(1, "workers.txt", OpenMode.Random,,, Len(workers)) 'opens workers.txt
            Do Until EOF(1) Or found = True 'searches file until found = true or the file ends.
                FileGet(1, workers) 'gets the records
                index = index + 1 'increase the index to know where to input the altered date
                If workers.username = txtUsername.Text.PadRight(10) And workers.code = txtPassword.Text Then 'makes sure that the username and assword are correct
                    found = True
                End If
            Loop
            If found = True Then
                If txtUpdateFirstname.Text.Length <> 0 Then 'updates the firstname record if data has been entered
                    workers.firstname = txtUpdateFirstname.Text
                    FilePut(1, workers, index)
                End If
                If txtUpdateLastname.Text.Length <> 0 Then 'updates the lastname record if data has been entered
                    workers.lastname = txtUpdateLastname.Text
                    FilePut(1, workers, index)
                End If
                If cbxUpdatelevel.Text <> "" Then 'updates the access level record if data has been entered
                    workers.level = cbxUpdatelevel.Text
                    FilePut(1, workers, index)
                End If
                If txtUpdateEmail.Text.Length <> 0 Then 'updates the email record if data has been entered
                    workers.email = txtUpdateEmail.Text
                    FilePut(1, workers, index)
                End If
                If txtUpdatePhonenum.Text.Length <> 0 Then 'updates the phonenum record if data has been entered
                    workers.phonenum = txtUpdatePhonenum.Text
                    FilePut(1, workers, index)
                End If
                If txtUpdateAddress.Text.Length <> 0 Then 'updates the address record if data has been entered
                    workers.address = txtUpdateAddress.Text
                    FilePut(1, workers, index)
                End If
                If txtUpdatePostcode.Text.Length <> 0 Then 'updates the postcode record if data has been entered
                    workers.postcode = txtUpdatePostcode.Text
                    FilePut(1, workers, index)
                End If
                lblConfirm2.Text = "your details have been updated" 'tells the suer that their details ahve been updated 
            Else
                MsgBox("username or password is incorrect") 'if the username and password dont correctly match error message displays
            End If
        End If
        txtUpdateFirstname.Text = ""
        txtUpdateLastname.Text = ""
        txtUpdateEmail.Text = ""
        txtUpdatePhonenum.Text = ""
        txtUpdateAddress.Text = ""
        txtUpdatePostcode.Text = ""
        FileClose(1)
    End Sub
    Private Sub txtUpdatePhonenum_KeyPressed(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUpdatePhonenum.KeyPress ' creates a subroutine that detects what keys are beng pressed to make sure they are numbers
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then ' makes sure only numbers can be entered
            Dim title = "Warning Message" ' sets title to warning message
            MessageBox.Show("Please enter numbers only", title) 'if the condition is met a warning message is displayed 
            e.Handled = True 'makes sure the system knows that the message has been displayed
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Admin.Show()
        Me.Close()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim index As Integer 'sets index data type to integer
        Dim found As Boolean 'sets found data type to boolean
        index = 0 'sets index value to 0 
        found = False 'sets found to boolean value false
        If txtRemoveUsername.Text.Length = 0 Or txtAdminUsername.Text.Length = 0 Or txtAdminPassword.Text.Length = 0 Or txtRemoveUsername.Text = " " Then 'if no value have been entered into text box message displays
            MsgBox("please enter a username, Admin username and Admin password")
        Else
            FileOpen(1, "workers.txt", OpenMode.Random,,, Len(workers)) 'opens workers.txt to begin search
            Do Until EOF(1) Or found = True 'runs code until conditions are met
                FileGet(1, workers) 'gets data from workers
                index = index + 1
                If workers.username = txtAdminUsername.Text.PadRight(10) And workers.code = txtAdminPassword.Text And workers.level = "Admin" Then 'checks if password and username match
                    found = True
                End If
            Loop
            FileClose(1)
            If found = True Then ' if Admin username and Admin password are found then the username to be deleted is searched
                index = 0 'resets index
                found = False 'resets found
                FileOpen(1, "workers.txt", OpenMode.Random,,, Len(workers))
                Do Until EOF(1) Or found = True
                    FileGet(1, workers) 'gets data from workers
                    index = index + 1
                    If workers.username = txtRemoveUsername.Text.PadRight(10) Then 'checks if password and username match
                        found = True
                    End If
                Loop
                If found = True Then 'if username is correct then data is changed
                    workers.username = "Removed"
                    workers.code = 0
                    workers.firstname = ""
                    workers.lastname = ""
                    workers.level = ""
                    workers.email = ""
                    workers.phonenum = 0
                    workers.address = ""
                    workers.postcode = ""
                    FilePut(1, workers, index) 'puts the changed data into the database
                    MsgBox("User Removed")
                Else
                    MsgBox("User not found") 'if username is wrong error messaage is displayed
                End If
                FileClose(1)
            Else
                MsgBox("Admin username and password not found") 'if username and password not found then error message displays
            End If
            txtRemoveUsername.Text = "" 'resets text boxes
            txtAdminUsername.Text = ""
            txtAdminPassword.Text = ""
            txtRemoveUsername.Focus()
        End If
    End Sub


End Class
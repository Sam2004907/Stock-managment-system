Public Class Login
    Dim numberofrecords, chances, attempts As Integer 'sets numberofrecords, chances and attempts variables to an integer and global scope.
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileOpen(1, "workers.txt", OpenMode.Random,,, Len(workers))
        numberofrecords = LOF(1) / Len(workers) 'sets number of records to the number of lines in the file
        FileClose(1)
        attempts = 0 'sets attempts to 0
        chances = 3 'sets chances to 3
    End Sub
    Private Sub txtCode_KeyPressed(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress ' creates a subroutine that detects what keys are beng pressed to make sure they are numbers
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then ' makes sure only numbers can be entered
            Dim title = "Warning Message" ' sets title to warning message
            MessageBox.Show("Please enter numbers only", title) 'if the condition is met a warning message is displayed 
            e.Handled = True 'makes sure the system knows that the message has been displayed
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        New_Forgot.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        New_Forgot.Show()
        Me.Close()
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then 'checks if enter key has been pressed
            btnEnter_Click(Nothing, Nothing) 'calls enter button
        Else
            Exit Sub  'exits subroutine
        End If
        e.SuppressKeyPress = True 'stops system from making a sound when key is pressed
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim username As String 'sets the variable username as string
        Dim password, chances, attempts As Integer 'sets the variable password as integer
        Dim found As Boolean 'sets the variable found as boolean
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("please enter a username and password")
        Else
            found = False
            password = txtPassword.Text 'sets the variable password to the text in txtpassword
            username = txtUsername.Text.PadRight(10) 'sets the variable username tot he text in txt username paded right to 10
            If chances = 0 And attempts = 3 Then
                MsgBox("you have reached you maximum attempt limit") 'tells the suer they have no more chances left
                Me.Close() 'closes the system
            Else
                If txtUsername.Text.Length = 0 Then 'validates username and password to make sure they are the correct length
                    MsgBox("Please enter a username")
                ElseIf txtPassword.Text.Length <> 4 Then
                    MsgBox("please enter a password")
                Else
                    FileOpen(1, "workers.txt", OpenMode.Random,,, Len(workers)) 'opens workers.txt
                    Do Until EOF(1) Or found = True 'creats a loop that only breaks if found = true or the end of file is reached
                        FileGet(1, workers) 'gets the records
                        If workers.username = username And workers.code = password Then 'if the database data matches inputted data found becomes true
                            found = True
                        End If
                    Loop
                    FileClose() 'closes file
                    If found = True And workers.level.Contains("Admin") Then 'if found is true and the access levelis admin opens admin form
                        User()
                        Admin.Show()
                        Me.Close()
                    Else
                        chances = chances - 1 'reduces the number of chances the user has left to get the correct username and password
                        attempts = attempts + 1 ' increases the number of attempts had by the user by 1
                        MsgBox("not found. your username or password is incorrect. You have " & chances & " attempts left") 'if password and username are incorrect error message displays and number of attempts left
                    End If
                End If
            End If
        End If
    End Sub
    Public Sub User() 'creates a public subroutine called User
        FileOpen(2, "CurrentUser.txt", OpenMode.Random,,, Len(CurrentUser)) 'opens CurrentUser.txt
        CurrentUser.username = workers.username 'assigns the username stored in workers to the username in CurrentUser
        CurrentUser.firstname = workers.firstname 'assigns the first name stored in workers to the first name in CurrentUser
        CurrentUser.lastname = workers.lastname 'assigns the last name stored in workers to the last name in CurrentUser
        CurrentUser.level = workers.level 'assigns the access level stored in workers to the access level in CurrentUser
        FilePut(2, CurrentUser) 'puts the data into the file 
        FileClose(2) 'closes CurrentUser
    End Sub
End Class
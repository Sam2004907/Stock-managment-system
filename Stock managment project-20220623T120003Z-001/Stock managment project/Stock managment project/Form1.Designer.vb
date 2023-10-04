<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbxAdd = New System.Windows.Forms.GroupBox()
        Me.txtPostcode = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtPhonenum = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxLevel = New System.Windows.Forms.ComboBox()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.gbxChangeUser = New System.Windows.Forms.GroupBox()
        Me.lblConfirm = New System.Windows.Forms.Label()
        Me.txtConfirm = New System.Windows.Forms.TextBox()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.txtCurrent = New System.Windows.Forms.TextBox()
        Me.btnChnageUsername = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.gbxChanePass = New System.Windows.Forms.GroupBox()
        Me.lblConfirm1 = New System.Windows.Forms.Label()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.txtConfirmpassword = New System.Windows.Forms.TextBox()
        Me.txtNewpassword = New System.Windows.Forms.TextBox()
        Me.txtCurrentpassword = New System.Windows.Forms.TextBox()
        Me.txtUsername1 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.gbxEdit = New System.Windows.Forms.GroupBox()
        Me.lblConfirm2 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cbxUpdatelevel = New System.Windows.Forms.ComboBox()
        Me.txtUpdatePostcode = New System.Windows.Forms.TextBox()
        Me.txtUpdateAddress = New System.Windows.Forms.TextBox()
        Me.txtUpdatePhonenum = New System.Windows.Forms.TextBox()
        Me.txtUpdateEmail = New System.Windows.Forms.TextBox()
        Me.txtUpdateLastname = New System.Windows.Forms.TextBox()
        Me.txtUpdateFirstname = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.gbxRemove = New System.Windows.Forms.GroupBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.txtAdminPassword = New System.Windows.Forms.TextBox()
        Me.txtAdminUsername = New System.Windows.Forms.TextBox()
        Me.txtRemoveUsername = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.gbxAdd.SuspendLayout()
        Me.gbxChangeUser.SuspendLayout()
        Me.gbxChanePass.SuspendLayout()
        Me.gbxEdit.SuspendLayout()
        Me.gbxRemove.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFirstname
        '
        Me.txtFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.Location = New System.Drawing.Point(203, 28)
        Me.txtFirstname.MaxLength = 10
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(155, 29)
        Me.txtFirstname.TabIndex = 0
        '
        'txtLastname
        '
        Me.txtLastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.Location = New System.Drawing.Point(203, 64)
        Me.txtLastname.MaxLength = 10
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(155, 29)
        Me.txtLastname.TabIndex = 1
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(203, 101)
        Me.txtCode.MaxLength = 4
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(155, 29)
        Me.txtCode.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(98, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "First name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Last name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Code"
        '
        'gbxAdd
        '
        Me.gbxAdd.Controls.Add(Me.txtPostcode)
        Me.gbxAdd.Controls.Add(Me.txtAddress)
        Me.gbxAdd.Controls.Add(Me.txtPhonenum)
        Me.gbxAdd.Controls.Add(Me.txtEmail)
        Me.gbxAdd.Controls.Add(Me.Label8)
        Me.gbxAdd.Controls.Add(Me.Label7)
        Me.gbxAdd.Controls.Add(Me.Label6)
        Me.gbxAdd.Controls.Add(Me.Label5)
        Me.gbxAdd.Controls.Add(Me.Label4)
        Me.gbxAdd.Controls.Add(Me.cbxLevel)
        Me.gbxAdd.Controls.Add(Me.btnInput)
        Me.gbxAdd.Controls.Add(Me.Label1)
        Me.gbxAdd.Controls.Add(Me.Label3)
        Me.gbxAdd.Controls.Add(Me.Label2)
        Me.gbxAdd.Controls.Add(Me.txtCode)
        Me.gbxAdd.Controls.Add(Me.txtFirstname)
        Me.gbxAdd.Controls.Add(Me.txtLastname)
        Me.gbxAdd.Location = New System.Drawing.Point(12, 14)
        Me.gbxAdd.Name = "gbxAdd"
        Me.gbxAdd.Size = New System.Drawing.Size(387, 369)
        Me.gbxAdd.TabIndex = 6
        Me.gbxAdd.TabStop = False
        Me.gbxAdd.Text = "Add staff details"
        '
        'txtPostcode
        '
        Me.txtPostcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostcode.Location = New System.Drawing.Point(203, 271)
        Me.txtPostcode.MaxLength = 8
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(155, 29)
        Me.txtPostcode.TabIndex = 7
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(203, 240)
        Me.txtAddress.MaxLength = 40
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(155, 29)
        Me.txtAddress.TabIndex = 6
        '
        'txtPhonenum
        '
        Me.txtPhonenum.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhonenum.Location = New System.Drawing.Point(203, 206)
        Me.txtPhonenum.MaxLength = 11
        Me.txtPhonenum.Name = "txtPhonenum"
        Me.txtPhonenum.Size = New System.Drawing.Size(155, 29)
        Me.txtPhonenum.TabIndex = 5
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(203, 174)
        Me.txtEmail.MaxLength = 30
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(155, 29)
        Me.txtEmail.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 278)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 24)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Postcode"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 24)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(174, 24)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Telephone number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Access level"
        '
        'cbxLevel
        '
        Me.cbxLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxLevel.FormattingEnabled = True
        Me.cbxLevel.Items.AddRange(New Object() {"Admin", "Staff"})
        Me.cbxLevel.Location = New System.Drawing.Point(203, 137)
        Me.cbxLevel.Name = "cbxLevel"
        Me.cbxLevel.Size = New System.Drawing.Size(155, 32)
        Me.cbxLevel.TabIndex = 3
        '
        'btnInput
        '
        Me.btnInput.BackColor = System.Drawing.Color.Gold
        Me.btnInput.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInput.Location = New System.Drawing.Point(203, 314)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(84, 47)
        Me.btnInput.TabIndex = 8
        Me.btnInput.Text = "Input"
        Me.btnInput.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(7, 62)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(140, 24)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "New Last name"
        '
        'gbxChangeUser
        '
        Me.gbxChangeUser.Controls.Add(Me.lblConfirm)
        Me.gbxChangeUser.Controls.Add(Me.txtConfirm)
        Me.gbxChangeUser.Controls.Add(Me.txtChange)
        Me.gbxChangeUser.Controls.Add(Me.txtCurrent)
        Me.gbxChangeUser.Controls.Add(Me.btnChnageUsername)
        Me.gbxChangeUser.Controls.Add(Me.Label11)
        Me.gbxChangeUser.Controls.Add(Me.Label10)
        Me.gbxChangeUser.Controls.Add(Me.Label9)
        Me.gbxChangeUser.Location = New System.Drawing.Point(426, 14)
        Me.gbxChangeUser.Name = "gbxChangeUser"
        Me.gbxChangeUser.Size = New System.Drawing.Size(344, 207)
        Me.gbxChangeUser.TabIndex = 7
        Me.gbxChangeUser.TabStop = False
        Me.gbxChangeUser.Text = "Change Username"
        '
        'lblConfirm
        '
        Me.lblConfirm.AutoSize = True
        Me.lblConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirm.Location = New System.Drawing.Point(9, 174)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Size = New System.Drawing.Size(66, 20)
        Me.lblConfirm.TabIndex = 33
        Me.lblConfirm.Text = "Label12"
        '
        'txtConfirm
        '
        Me.txtConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirm.Location = New System.Drawing.Point(192, 95)
        Me.txtConfirm.MaxLength = 10
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.Size = New System.Drawing.Size(146, 26)
        Me.txtConfirm.TabIndex = 11
        '
        'txtChange
        '
        Me.txtChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChange.Location = New System.Drawing.Point(192, 64)
        Me.txtChange.MaxLength = 10
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(146, 26)
        Me.txtChange.TabIndex = 10
        '
        'txtCurrent
        '
        Me.txtCurrent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrent.Location = New System.Drawing.Point(192, 25)
        Me.txtCurrent.MaxLength = 10
        Me.txtCurrent.Name = "txtCurrent"
        Me.txtCurrent.Size = New System.Drawing.Size(146, 26)
        Me.txtCurrent.TabIndex = 9
        '
        'btnChnageUsername
        '
        Me.btnChnageUsername.BackColor = System.Drawing.Color.Gold
        Me.btnChnageUsername.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChnageUsername.Location = New System.Drawing.Point(192, 127)
        Me.btnChnageUsername.Name = "btnChnageUsername"
        Me.btnChnageUsername.Size = New System.Drawing.Size(100, 37)
        Me.btnChnageUsername.TabIndex = 12
        Me.btnChnageUsername.Text = "Change"
        Me.btnChnageUsername.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 101)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(170, 24)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Confirm username "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 24)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "New username"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(162, 24)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Current username"
        '
        'gbxChanePass
        '
        Me.gbxChanePass.Controls.Add(Me.lblConfirm1)
        Me.gbxChanePass.Controls.Add(Me.btnChangePassword)
        Me.gbxChanePass.Controls.Add(Me.txtConfirmpassword)
        Me.gbxChanePass.Controls.Add(Me.txtNewpassword)
        Me.gbxChanePass.Controls.Add(Me.txtCurrentpassword)
        Me.gbxChanePass.Controls.Add(Me.txtUsername1)
        Me.gbxChanePass.Controls.Add(Me.Label15)
        Me.gbxChanePass.Controls.Add(Me.Label14)
        Me.gbxChanePass.Controls.Add(Me.Label13)
        Me.gbxChanePass.Controls.Add(Me.Label12)
        Me.gbxChanePass.Location = New System.Drawing.Point(426, 238)
        Me.gbxChanePass.Name = "gbxChanePass"
        Me.gbxChanePass.Size = New System.Drawing.Size(350, 243)
        Me.gbxChanePass.TabIndex = 8
        Me.gbxChanePass.TabStop = False
        Me.gbxChanePass.Text = "Change Password"
        '
        'lblConfirm1
        '
        Me.lblConfirm1.AutoSize = True
        Me.lblConfirm1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirm1.Location = New System.Drawing.Point(6, 219)
        Me.lblConfirm1.Name = "lblConfirm1"
        Me.lblConfirm1.Size = New System.Drawing.Size(66, 20)
        Me.lblConfirm1.TabIndex = 34
        Me.lblConfirm1.Text = "Label12"
        '
        'btnChangePassword
        '
        Me.btnChangePassword.BackColor = System.Drawing.Color.Gold
        Me.btnChangePassword.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePassword.Location = New System.Drawing.Point(192, 167)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(109, 44)
        Me.btnChangePassword.TabIndex = 17
        Me.btnChangePassword.Text = "Change"
        Me.btnChangePassword.UseVisualStyleBackColor = False
        '
        'txtConfirmpassword
        '
        Me.txtConfirmpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmpassword.Location = New System.Drawing.Point(192, 130)
        Me.txtConfirmpassword.MaxLength = 4
        Me.txtConfirmpassword.Name = "txtConfirmpassword"
        Me.txtConfirmpassword.Size = New System.Drawing.Size(152, 29)
        Me.txtConfirmpassword.TabIndex = 16
        '
        'txtNewpassword
        '
        Me.txtNewpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewpassword.Location = New System.Drawing.Point(192, 95)
        Me.txtNewpassword.MaxLength = 4
        Me.txtNewpassword.Name = "txtNewpassword"
        Me.txtNewpassword.Size = New System.Drawing.Size(152, 29)
        Me.txtNewpassword.TabIndex = 15
        '
        'txtCurrentpassword
        '
        Me.txtCurrentpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentpassword.Location = New System.Drawing.Point(192, 59)
        Me.txtCurrentpassword.MaxLength = 4
        Me.txtCurrentpassword.Name = "txtCurrentpassword"
        Me.txtCurrentpassword.Size = New System.Drawing.Size(152, 29)
        Me.txtCurrentpassword.TabIndex = 14
        '
        'txtUsername1
        '
        Me.txtUsername1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername1.Location = New System.Drawing.Point(192, 24)
        Me.txtUsername1.MaxLength = 10
        Me.txtUsername1.Name = "txtUsername1"
        Me.txtUsername1.Size = New System.Drawing.Size(152, 29)
        Me.txtUsername1.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(7, 130)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(161, 24)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Confirm password"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 95)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(135, 24)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "New password"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(9, 62)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(158, 24)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Current password"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 24)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Username"
        '
        'gbxEdit
        '
        Me.gbxEdit.Controls.Add(Me.lblConfirm2)
        Me.gbxEdit.Controls.Add(Me.btnUpdate)
        Me.gbxEdit.Controls.Add(Me.txtPassword)
        Me.gbxEdit.Controls.Add(Me.txtUsername)
        Me.gbxEdit.Controls.Add(Me.Label24)
        Me.gbxEdit.Controls.Add(Me.Label23)
        Me.gbxEdit.Controls.Add(Me.cbxUpdatelevel)
        Me.gbxEdit.Controls.Add(Me.txtUpdatePostcode)
        Me.gbxEdit.Controls.Add(Me.txtUpdateAddress)
        Me.gbxEdit.Controls.Add(Me.txtUpdatePhonenum)
        Me.gbxEdit.Controls.Add(Me.txtUpdateEmail)
        Me.gbxEdit.Controls.Add(Me.txtUpdateLastname)
        Me.gbxEdit.Controls.Add(Me.txtUpdateFirstname)
        Me.gbxEdit.Controls.Add(Me.Label22)
        Me.gbxEdit.Controls.Add(Me.Label21)
        Me.gbxEdit.Controls.Add(Me.Label20)
        Me.gbxEdit.Controls.Add(Me.Label19)
        Me.gbxEdit.Controls.Add(Me.Label18)
        Me.gbxEdit.Controls.Add(Me.Label17)
        Me.gbxEdit.Controls.Add(Me.Label16)
        Me.gbxEdit.Location = New System.Drawing.Point(827, 141)
        Me.gbxEdit.Name = "gbxEdit"
        Me.gbxEdit.Size = New System.Drawing.Size(388, 478)
        Me.gbxEdit.TabIndex = 9
        Me.gbxEdit.TabStop = False
        Me.gbxEdit.Text = "edit other detials"
        '
        'lblConfirm2
        '
        Me.lblConfirm2.AutoSize = True
        Me.lblConfirm2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirm2.Location = New System.Drawing.Point(21, 429)
        Me.lblConfirm2.Name = "lblConfirm2"
        Me.lblConfirm2.Size = New System.Drawing.Size(76, 24)
        Me.lblConfirm2.TabIndex = 35
        Me.lblConfirm2.Text = "Label25"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Gold
        Me.btnUpdate.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(217, 358)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(106, 47)
        Me.btnUpdate.TabIndex = 27
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(217, 316)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(154, 29)
        Me.txtPassword.TabIndex = 26
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(217, 275)
        Me.txtUsername.MaxLength = 10
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(154, 29)
        Me.txtUsername.TabIndex = 25
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(5, 316)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(92, 24)
        Me.Label24.TabIndex = 26
        Me.Label24.Text = "Password"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(7, 274)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(97, 24)
        Me.Label23.TabIndex = 25
        Me.Label23.Text = "Username"
        '
        'cbxUpdatelevel
        '
        Me.cbxUpdatelevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxUpdatelevel.FormattingEnabled = True
        Me.cbxUpdatelevel.Items.AddRange(New Object() {"Admin", "Staff"})
        Me.cbxUpdatelevel.Location = New System.Drawing.Point(217, 97)
        Me.cbxUpdatelevel.Name = "cbxUpdatelevel"
        Me.cbxUpdatelevel.Size = New System.Drawing.Size(154, 32)
        Me.cbxUpdatelevel.TabIndex = 20
        '
        'txtUpdatePostcode
        '
        Me.txtUpdatePostcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdatePostcode.Location = New System.Drawing.Point(217, 240)
        Me.txtUpdatePostcode.MaxLength = 8
        Me.txtUpdatePostcode.Name = "txtUpdatePostcode"
        Me.txtUpdatePostcode.Size = New System.Drawing.Size(154, 29)
        Me.txtUpdatePostcode.TabIndex = 24
        '
        'txtUpdateAddress
        '
        Me.txtUpdateAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdateAddress.Location = New System.Drawing.Point(217, 205)
        Me.txtUpdateAddress.MaxLength = 40
        Me.txtUpdateAddress.Name = "txtUpdateAddress"
        Me.txtUpdateAddress.Size = New System.Drawing.Size(154, 29)
        Me.txtUpdateAddress.TabIndex = 23
        '
        'txtUpdatePhonenum
        '
        Me.txtUpdatePhonenum.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdatePhonenum.Location = New System.Drawing.Point(217, 170)
        Me.txtUpdatePhonenum.MaxLength = 11
        Me.txtUpdatePhonenum.Name = "txtUpdatePhonenum"
        Me.txtUpdatePhonenum.Size = New System.Drawing.Size(154, 29)
        Me.txtUpdatePhonenum.TabIndex = 22
        '
        'txtUpdateEmail
        '
        Me.txtUpdateEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdateEmail.Location = New System.Drawing.Point(217, 135)
        Me.txtUpdateEmail.MaxLength = 30
        Me.txtUpdateEmail.Name = "txtUpdateEmail"
        Me.txtUpdateEmail.Size = New System.Drawing.Size(154, 29)
        Me.txtUpdateEmail.TabIndex = 21
        '
        'txtUpdateLastname
        '
        Me.txtUpdateLastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdateLastname.Location = New System.Drawing.Point(217, 62)
        Me.txtUpdateLastname.MaxLength = 10
        Me.txtUpdateLastname.Name = "txtUpdateLastname"
        Me.txtUpdateLastname.Size = New System.Drawing.Size(154, 29)
        Me.txtUpdateLastname.TabIndex = 19
        '
        'txtUpdateFirstname
        '
        Me.txtUpdateFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdateFirstname.Location = New System.Drawing.Point(217, 27)
        Me.txtUpdateFirstname.MaxLength = 10
        Me.txtUpdateFirstname.Name = "txtUpdateFirstname"
        Me.txtUpdateFirstname.Size = New System.Drawing.Size(154, 29)
        Me.txtUpdateFirstname.TabIndex = 18
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(6, 240)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(132, 24)
        Me.Label22.TabIndex = 17
        Me.Label22.Text = "New postcode"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(5, 205)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(124, 24)
        Me.Label21.TabIndex = 17
        Me.Label21.Text = "New Address"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(5, 170)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(210, 24)
        Me.Label20.TabIndex = 17
        Me.Label20.Text = "New telephone number"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(7, 135)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(101, 24)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "New Email"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 97)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(160, 24)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "New Access level"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(5, 27)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(142, 24)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "New First name"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnBack.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(559, 542)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(92, 52)
        Me.btnBack.TabIndex = 32
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'gbxRemove
        '
        Me.gbxRemove.Controls.Add(Me.btnRemove)
        Me.gbxRemove.Controls.Add(Me.txtAdminPassword)
        Me.gbxRemove.Controls.Add(Me.txtAdminUsername)
        Me.gbxRemove.Controls.Add(Me.txtRemoveUsername)
        Me.gbxRemove.Controls.Add(Me.Label27)
        Me.gbxRemove.Controls.Add(Me.Label26)
        Me.gbxRemove.Controls.Add(Me.Label25)
        Me.gbxRemove.Location = New System.Drawing.Point(16, 428)
        Me.gbxRemove.Name = "gbxRemove"
        Me.gbxRemove.Size = New System.Drawing.Size(383, 214)
        Me.gbxRemove.TabIndex = 11
        Me.gbxRemove.TabStop = False
        Me.gbxRemove.Text = "Remove User"
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Gold
        Me.btnRemove.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(211, 149)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(103, 47)
        Me.btnRemove.TabIndex = 31
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'txtAdminPassword
        '
        Me.txtAdminPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdminPassword.Location = New System.Drawing.Point(211, 114)
        Me.txtAdminPassword.MaxLength = 4
        Me.txtAdminPassword.Name = "txtAdminPassword"
        Me.txtAdminPassword.Size = New System.Drawing.Size(143, 29)
        Me.txtAdminPassword.TabIndex = 30
        '
        'txtAdminUsername
        '
        Me.txtAdminUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdminUsername.Location = New System.Drawing.Point(211, 79)
        Me.txtAdminUsername.MaxLength = 10
        Me.txtAdminUsername.Name = "txtAdminUsername"
        Me.txtAdminUsername.Size = New System.Drawing.Size(143, 29)
        Me.txtAdminUsername.TabIndex = 29
        '
        'txtRemoveUsername
        '
        Me.txtRemoveUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemoveUsername.Location = New System.Drawing.Point(211, 40)
        Me.txtRemoveUsername.MaxLength = 10
        Me.txtRemoveUsername.Name = "txtRemoveUsername"
        Me.txtRemoveUsername.Size = New System.Drawing.Size(143, 29)
        Me.txtRemoveUsername.TabIndex = 28
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(6, 117)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(151, 24)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "Admin password"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(6, 84)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(157, 24)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "Admin Username"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(6, 32)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(184, 48)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Username of user to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "be deleted"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(884, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(331, 135)
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1218, 654)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.gbxRemove)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.gbxEdit)
        Me.Controls.Add(Me.gbxChanePass)
        Me.Controls.Add(Me.gbxChangeUser)
        Me.Controls.Add(Me.gbxAdd)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbxAdd.ResumeLayout(False)
        Me.gbxAdd.PerformLayout()
        Me.gbxChangeUser.ResumeLayout(False)
        Me.gbxChangeUser.PerformLayout()
        Me.gbxChanePass.ResumeLayout(False)
        Me.gbxChanePass.PerformLayout()
        Me.gbxEdit.ResumeLayout(False)
        Me.gbxEdit.PerformLayout()
        Me.gbxRemove.ResumeLayout(False)
        Me.gbxRemove.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents txtCode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents gbxAdd As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbxLevel As ComboBox
    Friend WithEvents btnInput As Button
    Friend WithEvents txtPostcode As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtPhonenum As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents gbxChangeUser As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtConfirm As TextBox
    Friend WithEvents txtChange As TextBox
    Friend WithEvents txtCurrent As TextBox
    Friend WithEvents btnChnageUsername As Button
    Friend WithEvents lblConfirm As Label
    Friend WithEvents gbxChanePass As GroupBox
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents txtConfirmpassword As TextBox
    Friend WithEvents txtNewpassword As TextBox
    Friend WithEvents txtCurrentpassword As TextBox
    Friend WithEvents txtUsername1 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblConfirm1 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents gbxEdit As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents cbxUpdatelevel As ComboBox
    Friend WithEvents txtUpdatePostcode As TextBox
    Friend WithEvents txtUpdateAddress As TextBox
    Friend WithEvents txtUpdatePhonenum As TextBox
    Friend WithEvents txtUpdateEmail As TextBox
    Friend WithEvents txtUpdateLastname As TextBox
    Friend WithEvents txtUpdateFirstname As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblConfirm2 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents gbxRemove As GroupBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents txtAdminPassword As TextBox
    Friend WithEvents txtAdminUsername As TextBox
    Friend WithEvents txtRemoveUsername As TextBox
    Friend WithEvents PictureBox2 As PictureBox
End Class

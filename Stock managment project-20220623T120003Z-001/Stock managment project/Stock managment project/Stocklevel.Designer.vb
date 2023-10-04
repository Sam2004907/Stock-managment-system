<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stocklevel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stocklevel))
        Me.btnView = New System.Windows.Forms.Button()
        Me.lsbOutput = New System.Windows.Forms.ListBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lsbReorder = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.Gold
        Me.btnView.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Location = New System.Drawing.Point(471, 155)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 38)
        Me.btnView.TabIndex = 0
        Me.btnView.Text = "View stock levels"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'lsbOutput
        '
        Me.lsbOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lsbOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsbOutput.FormattingEnabled = True
        Me.lsbOutput.HorizontalScrollbar = True
        Me.lsbOutput.ItemHeight = 25
        Me.lsbOutput.Location = New System.Drawing.Point(16, 72)
        Me.lsbOutput.Name = "lsbOutput"
        Me.lsbOutput.Size = New System.Drawing.Size(449, 177)
        Me.lsbOutput.TabIndex = 1
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnBack.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(471, 225)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 38)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lsbReorder
        '
        Me.lsbReorder.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsbReorder.FormattingEnabled = True
        Me.lsbReorder.HorizontalScrollbar = True
        Me.lsbReorder.ItemHeight = 25
        Me.lsbReorder.Location = New System.Drawing.Point(16, 291)
        Me.lsbReorder.Name = "lsbReorder"
        Me.lsbReorder.Size = New System.Drawing.Size(449, 129)
        Me.lsbReorder.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 259)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "These products need to be reordered"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(288, 60)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Information on stock is displayed in this " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "order: name, number in stock, supplie" &
    "r " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "name, supplier cost, store cost, sale"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(471, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(331, 135)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Stocklevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lsbReorder)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lsbOutput)
        Me.Controls.Add(Me.btnView)
        Me.Name = "Stocklevel"
        Me.Text = "Stocklevel"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnView As Button
    Friend WithEvents lsbOutput As ListBox
    Friend WithEvents btnBack As Button
    Friend WithEvents lsbReorder As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class

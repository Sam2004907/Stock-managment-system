<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Staff))
        Me.btnSearchstock = New System.Windows.Forms.Button()
        Me.btnStockLevels = New System.Windows.Forms.Button()
        Me.btnEditstock = New System.Windows.Forms.Button()
        Me.btnProfitCalculator = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearchstock
        '
        Me.btnSearchstock.BackColor = System.Drawing.Color.Gold
        Me.btnSearchstock.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchstock.Location = New System.Drawing.Point(174, 186)
        Me.btnSearchstock.Name = "btnSearchstock"
        Me.btnSearchstock.Size = New System.Drawing.Size(125, 68)
        Me.btnSearchstock.TabIndex = 0
        Me.btnSearchstock.Text = "Search stock"
        Me.btnSearchstock.UseVisualStyleBackColor = False
        '
        'btnStockLevels
        '
        Me.btnStockLevels.BackColor = System.Drawing.Color.Gold
        Me.btnStockLevels.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStockLevels.Location = New System.Drawing.Point(174, 98)
        Me.btnStockLevels.Name = "btnStockLevels"
        Me.btnStockLevels.Size = New System.Drawing.Size(125, 68)
        Me.btnStockLevels.TabIndex = 1
        Me.btnStockLevels.Text = "Stock levels"
        Me.btnStockLevels.UseVisualStyleBackColor = False
        '
        'btnEditstock
        '
        Me.btnEditstock.BackColor = System.Drawing.Color.Gold
        Me.btnEditstock.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditstock.Location = New System.Drawing.Point(22, 186)
        Me.btnEditstock.Name = "btnEditstock"
        Me.btnEditstock.Size = New System.Drawing.Size(125, 68)
        Me.btnEditstock.TabIndex = 2
        Me.btnEditstock.Text = "Edit stock"
        Me.btnEditstock.UseVisualStyleBackColor = False
        '
        'btnProfitCalculator
        '
        Me.btnProfitCalculator.BackColor = System.Drawing.Color.Gold
        Me.btnProfitCalculator.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfitCalculator.Location = New System.Drawing.Point(22, 98)
        Me.btnProfitCalculator.Name = "btnProfitCalculator"
        Me.btnProfitCalculator.Size = New System.Drawing.Size(125, 68)
        Me.btnProfitCalculator.TabIndex = 3
        Me.btnProfitCalculator.Text = "Profit Calculator"
        Me.btnProfitCalculator.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnLogout.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(174, 271)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(125, 68)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "Log out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(18, 18)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(75, 24)
        Me.lblWelcome.TabIndex = 8
        Me.lblWelcome.Text = "Label1"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(467, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(331, 135)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Gold
        Me.btnUpdate.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(22, 271)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(125, 68)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "Update Details"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 397)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnProfitCalculator)
        Me.Controls.Add(Me.btnEditstock)
        Me.Controls.Add(Me.btnStockLevels)
        Me.Controls.Add(Me.btnSearchstock)
        Me.Name = "Staff"
        Me.Text = "Staff"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSearchstock As Button
    Friend WithEvents btnStockLevels As Button
    Friend WithEvents btnEditstock As Button
    Friend WithEvents btnProfitCalculator As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblWelcome As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnUpdate As Button
End Class

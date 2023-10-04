<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editstock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Editstock))
        Me.btnAddstock = New System.Windows.Forms.Button()
        Me.btnUpdatestockinfo = New System.Windows.Forms.Button()
        Me.btnRemovestock = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddstock
        '
        Me.btnAddstock.BackColor = System.Drawing.Color.Gold
        Me.btnAddstock.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddstock.Location = New System.Drawing.Point(74, 29)
        Me.btnAddstock.Name = "btnAddstock"
        Me.btnAddstock.Size = New System.Drawing.Size(118, 61)
        Me.btnAddstock.TabIndex = 0
        Me.btnAddstock.Text = "Add stock"
        Me.btnAddstock.UseVisualStyleBackColor = False
        '
        'btnUpdatestockinfo
        '
        Me.btnUpdatestockinfo.BackColor = System.Drawing.Color.Gold
        Me.btnUpdatestockinfo.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdatestockinfo.Location = New System.Drawing.Point(221, 29)
        Me.btnUpdatestockinfo.Name = "btnUpdatestockinfo"
        Me.btnUpdatestockinfo.Size = New System.Drawing.Size(118, 61)
        Me.btnUpdatestockinfo.TabIndex = 1
        Me.btnUpdatestockinfo.Text = "Update stock information"
        Me.btnUpdatestockinfo.UseVisualStyleBackColor = False
        '
        'btnRemovestock
        '
        Me.btnRemovestock.BackColor = System.Drawing.Color.Gold
        Me.btnRemovestock.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemovestock.Location = New System.Drawing.Point(74, 122)
        Me.btnRemovestock.Name = "btnRemovestock"
        Me.btnRemovestock.Size = New System.Drawing.Size(118, 61)
        Me.btnRemovestock.TabIndex = 2
        Me.btnRemovestock.Text = "Remove stock"
        Me.btnRemovestock.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnBack.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(221, 122)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(118, 61)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(472, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(331, 135)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'Editstock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnRemovestock)
        Me.Controls.Add(Me.btnUpdatestockinfo)
        Me.Controls.Add(Me.btnAddstock)
        Me.Name = "Editstock"
        Me.Text = "Editstock"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddstock As Button
    Friend WithEvents btnUpdatestockinfo As Button
    Friend WithEvents btnRemovestock As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class

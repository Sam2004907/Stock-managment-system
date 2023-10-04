<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProfitCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProfitCalculator))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSupplier_Total = New System.Windows.Forms.Label()
        Me.lsbList = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblProfit = New System.Windows.Forms.Label()
        Me.lblStore_Total = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.chrProfit = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnGraph = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chrProfit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Gold
        Me.btnCalculate.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(339, 225)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(114, 40)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnBack.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(339, 386)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(114, 39)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "The total supplier cost is £"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(390, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Here is a list of everything that was sold today "
        '
        'lblSupplier_Total
        '
        Me.lblSupplier_Total.AutoSize = True
        Me.lblSupplier_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplier_Total.Location = New System.Drawing.Point(240, 225)
        Me.lblSupplier_Total.Name = "lblSupplier_Total"
        Me.lblSupplier_Total.Size = New System.Drawing.Size(66, 24)
        Me.lblSupplier_Total.TabIndex = 4
        Me.lblSupplier_Total.Text = "Label3"
        '
        'lsbList
        '
        Me.lsbList.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsbList.FormattingEnabled = True
        Me.lsbList.ItemHeight = 24
        Me.lsbList.Location = New System.Drawing.Point(12, 42)
        Me.lsbList.Name = "lsbList"
        Me.lsbList.Size = New System.Drawing.Size(441, 148)
        Me.lsbList.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 273)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "The total store price is £"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 323)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "The total profit is £"
        '
        'lblProfit
        '
        Me.lblProfit.AutoSize = True
        Me.lblProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfit.Location = New System.Drawing.Point(174, 323)
        Me.lblProfit.Name = "lblProfit"
        Me.lblProfit.Size = New System.Drawing.Size(66, 24)
        Me.lblProfit.TabIndex = 8
        Me.lblProfit.Text = "Label3"
        '
        'lblStore_Total
        '
        Me.lblStore_Total.AutoSize = True
        Me.lblStore_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStore_Total.Location = New System.Drawing.Point(222, 273)
        Me.lblStore_Total.Name = "lblStore_Total"
        Me.lblStore_Total.Size = New System.Drawing.Size(66, 24)
        Me.lblStore_Total.TabIndex = 9
        Me.lblStore_Total.Text = "Label3"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(468, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(331, 135)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'chrProfit
        '
        ChartArea1.Name = "ChartArea1"
        Me.chrProfit.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chrProfit.Legends.Add(Legend1)
        Me.chrProfit.Location = New System.Drawing.Point(468, 141)
        Me.chrProfit.Name = "chrProfit"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Legend = "Legend1"
        Series1.Name = "Profit"
        Me.chrProfit.Series.Add(Series1)
        Me.chrProfit.Size = New System.Drawing.Size(331, 300)
        Me.chrProfit.TabIndex = 11
        Me.chrProfit.Text = "Profit tracker"
        '
        'btnGraph
        '
        Me.btnGraph.BackColor = System.Drawing.Color.Gold
        Me.btnGraph.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGraph.Location = New System.Drawing.Point(339, 308)
        Me.btnGraph.Name = "btnGraph"
        Me.btnGraph.Size = New System.Drawing.Size(114, 39)
        Me.btnGraph.TabIndex = 12
        Me.btnGraph.Text = "Graph"
        Me.btnGraph.UseVisualStyleBackColor = False
        '
        'ProfitCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnGraph)
        Me.Controls.Add(Me.chrProfit)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblStore_Total)
        Me.Controls.Add(Me.lblProfit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lsbList)
        Me.Controls.Add(Me.lblSupplier_Total)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "ProfitCalculator"
        Me.Text = "ProfitCalculator"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrProfit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSupplier_Total As Label
    Friend WithEvents lsbList As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblProfit As Label
    Friend WithEvents lblStore_Total As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents chrProfit As DataVisualization.Charting.Chart
    Friend WithEvents btnGraph As Button
End Class

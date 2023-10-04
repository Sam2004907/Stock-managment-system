Public Class Addstock
    Dim numberofrecords As Integer
    Private Sub Addstock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileOpen(1, "Stock.txt", OpenMode.Random,,, Len(Stock)) ' opens stock.txt
        numberofrecords = LOF(1) / Len(Stock) 'calculates the number of records in the database
        FileClose(1) ' closes stock.txt
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click ' takes the user back to the previous screen
        Editstock.Show()
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Stock.product = txtproduct.Text
        Stock.level = 0
        Stock.Supplier = " "
        Stock.supplier_price = 0
        Stock.store_price = 0
        Stock.sale = 0
        If txtproduct.Text = "" Then 'validation 
            MsgBox("please enter the product name")
        Else
            FileOpen(1, "Stock.txt", OpenMode.Random,,, Len(Stock)) ' opens stock.txt
            FilePut(1, Stock, numberofrecords + 1) 'puts the product in stock.txt
            numberofrecords = numberofrecords + 1 'updates the number of records incase multiple additions are made.
            FileClose(1) ' closes stock.txt
        End If
        txtproduct.Text = ""
        txtproduct.Focus()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click 'adds the new stock to the stated product
        Dim index, level, addition As Integer
        Dim found As Boolean
        index = 0
        found = False
        If txtproductname.Text = "" Then ' makes sure a value has been entered into the boxes
            MsgBox("please enter product name")
        ElseIf txtlevel.Text = "" Then
            MsgBox("please enter the number of stock you wish to add to current stock level.")
        Else
            addition = CInt(txtlevel.Text)
            FileOpen(1, "Stock.txt", OpenMode.Random,,, Len(Stock)) ' opens stock.txt
            Do Until EOF(1) Or found = True
                FileGet(1, Stock)
                index = index + 1
                If Stock.product = txtproductname.Text.PadRight(10) Then
                    found = True
                End If
            Loop
            If found = True Then ' if the product has been found it will add the value entered by the user to the current level
                FileGet(1, Stock, index) 'gets the current level
                level = Stock.level
                level = level + addition 'adds original level to the value entered by the user
                Stock.level = level
                FilePut(1, Stock, index) 'puts the new stock level back into the database
                MsgBox("the stock level for " & txtproductname.Text & " has been updated to " & level) 'informs the user of the update to the product with the new level
            Else
                MsgBox("product not found") 'error message when product name not found in system
            End If
            FileClose(1) ' closes stock.txt
        End If
    End Sub
End Class
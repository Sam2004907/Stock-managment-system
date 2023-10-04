Public Class RemovePurchase
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim index As Integer 'sets the variable to integer
        Dim found As Boolean 'sets the variable to boolean
        index = 0 'sets the value of index to 0
        found = False 'sets the value of found to false
        If txtRemove.Text = "" Then 'validates txtremove to make sure a data value has been entered
            MsgBox("please enter the name of the product you wish to remove") 'displays a message to the user
        Else 'if validation is passed the code below will run
            FileOpen(1, "stock.txt", OpenMode.Random,,, Len(Stock)) 'opens Stock.txt
            Do Until EOF(1) Or found = True 'creates a loop that will break when end of file is reached or found = true
                FileGet(1, Stock) 'gets stock records
                index = index + 1 'increases index value by one
                If Stock.product = txtRemove.Text.PadRight(10) Then 'compares entered value to record
                    found = True 'if they match sets found to true
                End If
            Loop
            If found = True Then 'if found is set to true then 
                Stock.product = "Removed" 'sets product name to removed
                Stock.level = 0 'sets level to 0
                Stock.Supplier = " " 'sets supplier name to blank 
                Stock.supplier_price = 0 'sets supplier price to zero   
                Stock.store_price = 0 'sets store price to 0
                Stock.sale = 0 'sets sale to 0 
                FilePut(1, Stock, index) 'puts the records back into position index
                MsgBox("product has been removed") 'tells user product has been removed 
            Else
                MsgBox("product not found") 'if the product isn't found the system will display a message
            End If
            FileClose(1) 'close Stock.txt
            txtRemove.Text = "" 'clears text box
        End If
    End Sub

    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        Dim numberofrecords As Integer 'sets the variable to integer
        FileOpen(1, "Purchases.txt", OpenMode.Random,,, Len(Purchases)) 'opens Purchases.txt
        numberofrecords = LOF(1) / Len(Purchases) 'calculates number of records 
        FileClose(1) 'close Purchases.txt
        Dim found As Boolean 'sets the variable to boolean
        Dim index As Integer 'sets the variable to integer
        index = 0 'sets index value to 0
        found = False 'sets found vaue to false
        If txtPurchase.Text = "" Then 'validates txtPurchase
            MsgBox("please enter name of purchased product") 'if validation failed then system dispaly this message
        Else 'if validation is passed then system runs code below
            FileOpen(2, "Stock.txt", OpenMode.Random,,, Len(Stock)) 'opens Stock.txt
            Do Until EOF(2) Or found = True 'creates a loop that breaks when found = ture or end of file Stock.txt is reached 
                FileGet(2, Stock) 'gets stock records 
                index = index + 1 'increases index value by 1
                If Stock.product = txtPurchase.Text.PadRight(10) Then 'checks to see if product name in stock.txt matches one entered by the user 
                    found = True 'if they match found is set to true
                End If
            Loop
            If found = True Then 'if found = true then 
                FileOpen(1, "Purchases.txt", OpenMode.Random,,, Len(Purchases)) 'opens Purchases.txt
                Purchases.product = txtPurchase.Text 'sets record product to name entered by user
                Purchases.supplier_price = Stock.supplier_price 'sets record supplier price to the same value of supplier price in stock.txt
                Purchases.store_price = Stock.store_price 'sets record store price to the same value of store price in stock.txt
                Purchases.sale = Stock.sale 'sets record sale to the same value of sale in stock.txt
                Stock.level = Stock.level - 1 'decreases the stock level by 1
                FilePut(1, Purchases, numberofrecords + 1) 'adds the records into the system at numberofrecords + 1
                FilePut(2, Stock, index) 'adds stock records back to position index
                FileClose(1) 'closes Purchases.txt
            Else
                MsgBox("product not found") 'if the product name is not found it dispalys this message
            End If
            FileClose(2) 'closes Stock.txt
            txtPurchase.Text = "" 'clears txtPurchase
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Editstock.Show() 'opens edit stock form
        Me.Close() 'closes this form
    End Sub
End Class
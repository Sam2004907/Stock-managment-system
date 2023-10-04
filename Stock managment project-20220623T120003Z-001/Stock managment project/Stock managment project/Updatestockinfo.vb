Public Class Updatestockinfo
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim index As Integer 'set varaible to integer
        Dim found As Boolean 'sets variable to boolean
        found = False 'sets variable found to false
        index = 0 'sets variable index to 0
        If txtProduct.Text = "" Then 'validates if a product name has been entered 
            MsgBox("please enter a product name") 'message to user if validation is failed
        Else 'validation is passed runs code below
            FileOpen(1, "stock.txt", OpenMode.Random,,, Len(Stock)) 'opens stock.txt
            Do Until EOF(1) Or found = True 'creates a loop that breaks when the file reaches the end or found = true
                FileGet(1, Stock) 'gets stock records
                index = index + 1 'index increases by 1 
                If Stock.product = txtProduct.Text.PadRight(10) Then 'checks to see if the product name in the database is the same as the data entered by the user 
                    found = True 'if the names match variable found is set to true
                End If
            Loop
            If found = True Then 'if found was true then  
                If txtSupplier_Price.Text <> "" Then 'if only a value for supplier price exists it will only update supplier price record
                    Stock.supplier_price = txtSupplier_Price.Text 'sets stock record supplier_price to text in txtSupplier_Price
                    FilePut(1, Stock, index) 'puts the records back into stock 
                End If
                If txtSupplier.Text <> "" Then 'if only a value for supplier exists then it will only update supplier record
                    Stock.Supplier = txtSupplier.Text 'sets stock record supplier to text in txtsupplier
                    FilePut(1, Stock, index) 'puts the records back into stock 
                End If
                If txtStore_Price.Text <> "" Then 'if only a value for store price exists then it will only update store price record
                    Stock.store_price = txtStore_Price.Text 'sets stock record store price to text in txtStore_Price
                    FilePut(1, Stock, index) 'puts the records back into stock
                End If
                If cbxSale.Text <> "" Then ' if only a value for sale exists then it will only update the sale record
                    sale() ' calls the sub routine sale
                    FilePut(1, Stock, index) 'puts the records back into stock
                End If
                If txtSupplier.Text = "" And txtSupplier_Price.Text = "" And txtStore_Price.Text = "" And cbxSale.Text = "" Then
                    MsgBox("enter a supplier name, supplier price, store price or sale into the corrct box to update the record.") 'if nothing has been entered into the text boxes the system displays a message
                End If
            Else
                    MsgBox("product not found") 'if the product name isn't found the system displays the message
            End If
            FileClose(1) 'closes the file 
            txtSupplier_Price.Text = "" 'sets all text boxes to be blank 
            txtProduct.Text = ""
            txtSupplier.Text = ""
            txtStore_Price.Text = ""
            txtProduct.Focus() 'refocuses cursur to txtproduct
        End If
    End Sub
    Public Sub sale() ' creates a public subroutine called sale
        If cbxSale.Text = "0%" Then 'checks the percentage selected by the user
            Stock.sale = 0.00 'puts the correct decimal percentage for each percent off
        ElseIf cbxSale.Text = "5%" Then
            Stock.sale = 0.95
        ElseIf cbxSale.Text = "10%" Then
            Stock.sale = 0.9
        ElseIf cbxSale.Text = "15%" Then
            Stock.sale = 0.85
        ElseIf cbxSale.Text = "20%" Then
            Stock.sale = 0.8
        ElseIf cbxSale.Text = "25%" Then
            Stock.sale = 0.75
        ElseIf cbxSale.Text = "30%" Then
            Stock.sale = 0.7
        ElseIf cbxSale.Text = "35%" Then
            Stock.sale = 0.65
        ElseIf cbxSale.Text = "40%" Then
            Stock.sale = 0.6
        ElseIf cbxSale.Text = "45%" Then
            Stock.sale = 0.55
        ElseIf cbxSale.Text = "50%" Then
            Stock.sale = 0.5
        End If 'ends if statement
    End Sub 'closes the subroutine
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Editstock.Show() 'opens edit stock form 
        Me.Close() 'closes this form
    End Sub


End Class
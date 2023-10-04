Public Class Stocklevel
    Dim numberofrecords As Integer
    Private Sub Stocklevel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileOpen(1, "stock.txt", OpenMode.Random,,, Len(Stock))
        numberofrecords = LOF(1) / Len(Stock)
        FileClose(1)
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim reorder, product, supplier, output, sale As String 'assigns variable as strings
        Dim level, check As Integer 'assigns the variables as integers
        Dim Supplier_price, Store_price, SaleMulti As Decimal 'assigns variable as decimal
        check = 5 'sets the variable check to 5 
        FileOpen(1, "stock.txt", OpenMode.Random,,, Len(Stock)) 'opebns stock.txt
        Do Until EOF(1) 'runs the loop untilt the file reaches the end
            FileGet(1, Stock) 'gets the Stock records
            product = Stock.product 'assigns product to the product record
            supplier = Stock.Supplier 'assigns supplier to the product record
            level = Stock.level 'assigns level to the product record
            Supplier_price = Stock.supplier_price 'assigns Supplier_price to the product record  
            Store_price = Stock.store_price ' assigns store_price to the product record
            SaleMulti = Stock.sale ' assigns the sale value to the record sale
            If product <> "Removed".PadRight(10) Then
                If SaleMulti = 0 Then
                    sale = "0% off"
                ElseIf SaleMulti = 0.95 Then
                    sale = "5% off"
                ElseIf SaleMulti = 0.9 Then
                    sale = "10% off"
                ElseIf SaleMulti = 0.85 Then
                    sale = "15% off"
                ElseIf SaleMulti = 0.8 Then
                    sale = "20% off"
                ElseIf SaleMulti = 0.75 Then
                    sale = "25% off"
                ElseIf SaleMulti = 0.7 Then
                    sale = "30% off"
                ElseIf SaleMulti = 0.65 Then
                    sale = "35% off"
                ElseIf SaleMulti = 0.6 Then
                    sale = "40% off"
                ElseIf SaleMulti = 0.55 Then
                    sale = "45% off"
                Else
                    sale = "50% off"
                End If
                If level < check Then 'checks wether or not the current stock level is less than the variable check
                    reorder = (product & " " & level & " " & supplier & " £" & Supplier_price & " £" & Store_price & " " & sale) 'if level is less than check then variables are added to reorder
                    lsbReorder.Items.Add(reorder) 'add reorder to the list box reorder
                End If
                output = (product & " " & level & " " & supplier & " £" & Supplier_price & " £" & Store_price & " " & sale) 'assigns the variables to output
                lsbOutput.Items.Add(output) 'adds output to the listbox
            End If
        Loop
        FileClose(1)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Admin.Show()
        Me.Close()
    End Sub
End Class
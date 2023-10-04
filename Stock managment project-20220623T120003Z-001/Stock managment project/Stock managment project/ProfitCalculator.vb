Public Class ProfitCalculator
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim SupplierTotal, StoreTotal, Profit, supplier, store, sale As Decimal 'sets the variables to decimal
        Dim product, output As String 'sets the variables to string
        SupplierTotal = 0
        StoreTotal = 0
        store = 0
        Profit = 0 'sets the value of total to 0
        FileOpen(1, "Purchases.txt", OpenMode.Random,,, Len(Purchases)) 'opens Purchases.txt
        Do Until EOF(1) 'creates a loop that breaks at the end of the file
            FileGet(1, Purchases) 'gets the records from purchases
            supplier = Purchases.supplier_price 'sets the variable price to the record value in purchases
            product = Purchases.product 'sets the variable product to the record value in purchases
            store = Purchases.store_price 'sets the variable store to the record value in purchases
            sale = Purchases.sale 'sets the variable sale to the record value in purchases
            If sale = 0.00 Then 'makes sure that only when sale has a discount that the store is recalculated
                output = product & "  " & supplier & "  " & store  'creates a string for the variable output to add to the list box
            Else
                output = product & "  " & supplier & "  " & store & "  " & sale 'creates a string for the variable output to add to the list box
                store = store * sale 'applies sale to store
            End If
            lsbList.Items.Add(output) 'adds variable output to list box
            SupplierTotal = SupplierTotal + supplier 'calaculates total for the supplier costs
            StoreTotal = StoreTotal + store 'calculates total for store costs
        Loop
        Profit = StoreTotal - SupplierTotal 'calculates profit by minusing supplier total form store total
        lblSupplier_Total.Text = SupplierTotal 'outputs supplier total
        lblStore_Total.Text = StoreTotal 'outputs store total
        lblProfit.Text = Profit  'outputs profit
        Dim thisDay As Integer = Microsoft.VisualBasic.DateAndTime.Day(Now)
        MsgBox("please delete file Purchases.txt when profit is calculated in order to reset for new daily profit.")
        FileClose(1) 'closes Purchases.txt
        FileOpen(2, "ProfitData.txt", OpenMode.Random,,, Len(ProfitData)) 'opens profitdata.txt to add data to the file
        Dim recordNum As Integer = LOF(2) / Len(ProfitData) 'calculates the number or records
        ProfitData.Profit = Profit 'sets profit to the calculated daily profit
        ProfitData.day = thisDay 'sets the day value to the date of today
        FilePut(2, ProfitData, recordNum + 1) 'adds records to file
        FileClose() 'closes files
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Admin.Show()
        Me.Close()
        MsgBox("please delete file on the first of every month to avoid months overlaping")
    End Sub

    Private Sub btnGraph_Click(sender As Object, e As EventArgs) Handles btnGraph.Click
        FileOpen(1, "ProfitData.txt", OpenMode.Random, , , Len(ProfitData))
        'open the file in random access mode
        Dim NoOfRec As Integer = LOF(1) / Len(ProfitData)
        'calculate the number of records in the file
        For x = 1 To NoOfRec 'loop through the records one at a time
            FileGet(1, ProfitData) 'read the record
            chrProfit.Series("Profit").Points.AddXY(ProfitData.day, ProfitData.Profit)
            'adds the profit and date to the graph
        Next
        FileClose(1)  'close the file
    End Sub
End Class
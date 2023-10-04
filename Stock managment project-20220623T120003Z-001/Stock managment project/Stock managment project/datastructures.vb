Module datastructures
    Structure users
        <VBFixedString(10)> Public firstname As String 'sets the record firstname as a string and set at length 10 characters
        <VBFixedString(10)> Public lastname As String 'sets the record lastname as a string and set at length 10 characters
        Dim code As Integer 'sets the record code as an integer
        <VBFixedString(5)> Public level As String 'sets the record level as a string and set at length 5 characters
        <VBFixedString(30)> Public email As String 'sets the record email as a string and set at length 30 characters
        <VBFixedString(11)> Public phonenum As String 'sets the record phonenum as a string and set at length 11 characters
        <VBFixedString(40)> Public address As String 'sets the record address as a string and set at length 40 characters
        <VBFixedString(8)> Public postcode As String 'sets the record postcode as a string and set at length 8 characters
        <VBFixedString(10)> Public username As String 'sets the record username as a string and set at length 10 characters
    End Structure
    Public workers As users ' when first ran it will create a file called workers.txt to store the users data.
    Structure storage
        <VBFixedString(10)> Public product As String 'sets the record product as a string set at length 10
        <VBFixedString(10)> Public Supplier As String 'stes the record supplier as a string set at length 10
        Dim level As Integer 'sets record level as an integer
        Dim supplier_price As Decimal 'sets supplier_price as a decimal 
        Dim store_price As Decimal ' sets store_price as a decimal
        Dim sale As Decimal ' store the sale percentage as a decimal form
    End Structure
    Public Stock As storage 'when first used creates a file titles Stock.txt

    Structure purchase
        <VBFixedString(10)> Public product As String 'sets the record product to a fixed string of length 10 characters
        Dim supplier_price As Decimal 'sets supplier_price as a decimal 
        Dim store_price As Decimal ' sets store_price as a decimal
        Dim sale As Decimal ' store the sale percentage as a decimal form
    End Structure
    Public Purchases As purchase 'creates a new file called Purchases.txt to store purchases made

    Structure current
        <VBFixedString(10)> Public username As String
        <VBFixedString(10)> Public firstname As String
        <VBFixedString(10)> Public lastname As String
        <VBFixedString(5)> Public level As String
    End Structure
    Public CurrentUser As current

    Structure Save
        Dim Profit As Integer
        Dim day As Integer
    End Structure
    Public ProfitData As Save
End Module

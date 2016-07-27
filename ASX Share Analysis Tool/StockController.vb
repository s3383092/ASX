'The functions outlined below will:
' - populate the all stocks tab by using FindAllStocks function.
' - create records in access using the InsertStock function. once the import button is clicked loading the table.

Imports System.Data.OleDb

Public Class StockController
    Public Const CONNECTION_STRING As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ASXShareMarketAnalysisTool.accdbb"
    Public Function FindAllStocks() As List(Of Hashtable)
        'Function that returns a list of hashtables using stock name as input
        'Can be used upon opening application. All previous stocks stored in access into the can be loaded into all stocks

        Dim lsData As New List(Of Hashtable)
        'instantiates a connection object and pass connection string
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        'instantiates a connection object

        Try
            'Try/catch/finally is code  structure which facilitates the hnadling of execeptions that may occur in the program
            Debug.Print("Connection String: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            'Try to make connection to database

            'TODO
            oCommand.CommandText =
                                    "Select * FROM asx_analysis_database ORDER BY security_code;"
            oCommand.Prepare() 'compiles prepared SQL statement
            Dim oDataReader = oCommand.ExecuteReader() 'executes SQL and stores results in data reader object

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                'while there is a record to read
                htTempData = New Hashtable
                'Store record data with key in hashtable
                htTempData("SecurityCode") = CStr(oDataReader("security_code"))           'SQL everything is underscores
                htTempData("SecurityDate") = CStr(oDataReader("security_date"))             'Programming everything is CamelCase
                htTempData("OpeningPrice") = CDbl(oDataReader("opening_price"))
                htTempData("HighSalesPrice") = CDbl(oDataReader("high_sales_price"))
                htTempData("LowSalesPrice") = CDbl(oDataReader("low_sales_price"))
                htTempData("TotalVolume") = CDbl(oDataReader("total_volume"))
                lsData.Add(htTempData)
                'Compile each variable as a record in hashtable
            Loop

            Debug.Print("The records were found")

        Catch ex As Exception
            Debug.Print("error: " & ex.Message)
            MsgBox("An error occured!")
        Finally
            oConnection.Close()
            'Close connection ALLWAYS
        End Try

        Return lsData
        'Output list
    End Function
    Public Function insertStock(ByVal htdata As Hashtable) As Integer
        Dim iNumRows As Integer

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        'instantiates a connection object

        Try
            'Try/catch/finally is code  structure which facilitates the hnadling of execeptions that may occur in the program
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            'Try to make connection to database

            'TODO
            oCommand.CommandText =
            "INSERT INTO asx_analysis_database (security_code, security_date, opening_price, high_sales_price, low_sales_price, total_volume) VALUES (?, ?, ?, ?, ?, ?)"
            'SQL statement VB is passing into Access

            oCommand.Parameters.Add("SecurityCode", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("SecurityDate", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("OpeningPrice", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("HighSalesPrice", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("LowSalesPrice", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("TotalVolume", OleDbType.VarChar, 255)
            'Creates field parameters in access

            oCommand.Parameters("SecurityCode").Value = CStr(htdata("SecurityCode"))
            oCommand.Parameters("SecurityDate").Value = CStr(htdata("SecurityDate"))
            oCommand.Parameters("OpeningPrice").Value = CDbl(htdata("OpeningPrice"))
            oCommand.Parameters("HighSalesPrice").Value = CDbl(htdata("HighSalesPrice"))
            oCommand.Parameters("LowSalesPrice").Value = CDbl(htdata("LowSalesPrice"))
            oCommand.Parameters("TotalVolume").Value = CDbl(htdata("TotalVolume"))
            '

            oCommand.Prepare()
            iNumRows = oCommand.ExecuteNonQuery()
            Debug.Print(CStr(iNumRows))
            Debug.Print("The record was inserted.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occured:" & vbCrLf & ex.Message & vbCrLf & "The record wasn't inserted.")
        Finally
            oConnection.Close()
        End Try
        Return iNumRows
    End Function

End Class

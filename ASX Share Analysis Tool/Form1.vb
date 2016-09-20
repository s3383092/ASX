Imports System
Imports System.IO
Imports System.Data.OleDb
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    Public sTargetDate As String = "15/07/2016" 'DEBUGGING PURPOSES ONLY, THIS SHOULD BE REMOVED AND DONE BETTER

    Private Sub btnFile_Click(sender As Object, e As EventArgs) Handles btnImportFile.Click 'Handle importing data
        dgvImport.DataSource = "" 'Clear data grid view upon finding a new file

        Dim OpenFileDialog1 As New OpenFileDialog() ' Open Dialog window
        Dim FileType As String = ""                 ' Take the file time to determine how to handle importing into the DGV
        Dim dtImport As New DataTable               ' 
        Dim FileCounter As Integer = 0              'Opens the Open File explorer dialog
        OpenFileDialog1.Title = "Please Select a File"
        OpenFileDialog1.Multiselect = True          'Enable multiselect to import multiple file types

        ' Handles checking how many files are selected. A safe load is =<5
        AddHandler OpenFileDialog1.FileOk, Sub(s, ce)
                                               If OpenFileDialog1.FileNames.Length > 5 Then
                                                   MessageBox.Show("Please select up to 5 files")
                                                   ce.Cancel = True
                                               End If
                                           End Sub

        'If =<5 files are selected continue with import
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Handles opening the file
            ' Makes sure the user pressed OK on the Open dialog window
            Dim file As String = ""                            ' Store the file name from the open dialog
            For Each file In OpenFileDialog1.FileNames         ' Handle Importing multiple files
                Try
                    Dim TextFileReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(file) ' Textfile reader
                    Dim CurrentRow As String()                                                   ' Current row being read
                    Debug.Print(file)                                                            ' Prints out the file name ////DEBUGGING PURPOSES
                    TextFileReader.TextFieldType = FileIO.FieldType.Delimited                    ' IDK Maybe sets a delimiter style or something
                    TextFileReader.SetDelimiters(",")                                            ' Sets the delimiter to a comma, most of the files use a comma
                    FileType = Path.GetExtension(OpenFileDialog1.FileName)                       ' Grabs the file type

                    dspFileLocation.Text = OpenFileDialog1.FileName ' Shows where the file is located

                    Dim sInsightTrader As String = "InsightTrader" ' Handles InsightTrader format 
                    Dim TestPos As Integer = 0

                    TestPos = InStr(1, OpenFileDialog1.FileName, sInsightTrader, CompareMethod.Text) ' Looks for "InsightTrader" in the filename

                    If TestPos <> 0 Then                   ' InsightTrader is stupid so We need to determine if the filetype is stupid
                        TextFileReader.SetDelimiters(" ")  ' Changes the delimiters from commas to spaces
                    End If

                    'Call ClearDGVImport() ' will be necessary if he chooses the wrong file before, and then chooses one again

                    If FileType = ".txt" Then                                  ' Handles importing .txt file types
                        dgvImport.Columns.Add("ID", "Security Code")           ' Adds ID Column
                        dgvImport.Columns.Add("Date", "Date")                  ' Adds Date Column
                        dgvImport.Columns.Add("Open", "Opening Price")         ' Adds Open Column
                        dgvImport.Columns.Add("High", "High Sale price")       ' Adds High Column
                        dgvImport.Columns.Add("Low", "Low Sale Price")         ' Adds Low Column
                        dgvImport.Columns.Add("Close", "Closing Price")        ' Adds Close Column
                        dgvImport.Columns.Add("Volume", "Total Volume Traded") ' Adds Volume Column

                        While Not TextFileReader.EndOfData               ' Loops through the data and imports it into a table
                            Try
                                CurrentRow = TextFileReader.ReadFields() ' Declares the Row to be added
                                dgvImport.Rows.Add(CurrentRow)           'Adds the record into the DGV
                            Catch ex As _
                        Microsoft.VisualBasic.FileIO.MalformedLineException
                                MsgBox("Line " & ex.Message &
                            "Is Not valid And will be skipped.")
                            End Try
                        End While
                        TextFileReader.Dispose() 'Removes TextFileReader for next time

                    ElseIf FileType = ".csv" Then ' Handles importing .csv filetype
                        Dim sr As New IO.StreamReader(file)
                        Dim newline() As String = sr.ReadLine.Split(","c)

                        If FileCounter = 0 Then
                            dtImport.Columns.AddRange({New DataColumn(newline(0)),
                             New DataColumn(newline(1)),
                             New DataColumn(newline(2)),
                             New DataColumn(newline(3)),
                             New DataColumn(newline(4)),
                             New DataColumn(newline(5)),
                             New DataColumn(newline(6))})
                        End If

                        While (Not sr.EndOfStream)
                            newline = sr.ReadLine.Split(","c)
                            Dim newrow As DataRow = dtImport.NewRow
                            newrow.ItemArray = {newline(0), newline(1), newline(2), newline(3), newline(4), newline(5), newline(6)}
                            dtImport.Rows.Add(newrow)
                        End While

                        dgvImport.DataSource = dtImport

                    Else
                        MsgBox("Please select a .txt or .csv type file")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Looks like an error occured!" & ex.Message)
                End Try
                FileCounter = FileCounter + 1
            Next file
        End If
        dspStatus.Text = "Please press import."
    End Sub
    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim Response = MsgBox("Are you sure you want to import this into the database?", vbYesNo, "Please confirm importing")
        If Response = MsgBoxResult.Yes Then

            'Show loading bar and waiting cursor
            Cursor.Current = Cursors.WaitCursor
            dspStatus.Text = "Please wait while the data is imported."
            prgrssImportScreen.Maximum = 12000
            prgrssImportScreen.Visible = True
            prgrssImportScreen.Increment(100)


            Dim MyChar() As Char = {"b", "i", "n", "\", "D", "e", "b", "u", "g"} 'This is the locatation of the database file hardcoded in. If desirable, have an open file dialog to allow user selection in preferences?
            Dim path As String = Environment.CurrentDirectory
            Dim newpath As String = path.TrimEnd(MyChar)
            Dim CON_STRING As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & newpath & "\ASXShareMarketAnalysisTool.accdb"
            Dim myConnection As OleDbConnection = New OleDbConnection(CON_STRING)
            'instantiates a connection object


            'temporary variables declared which pull data from grid 
            Dim sSecurityCode As String
            Dim sSecurityDate As String
            Dim sOpeningPrice As String
            Dim sHighSalePrice As String
            Dim sLowSalePrice As String
            Dim sClosingPrice As String
            Dim sTotalVolume As String

            'Once variables loaded with grid data convert to relative format and stored in variables above
            Dim dtSecurityDate As Date
            Dim dblOpeningPrice As Double
            Dim dblHighSalePrice As Double
            Dim dblLowSalePrice As Double
            Dim dblClosingPrice As Double
            Dim iTotalVolume As Integer

            'Variables required for loop and SQL injection query
            Dim sqlQuery As String
            Dim iCounter As Integer
            Dim iCountRows As Integer

            Try
                Debug.Print("Connection String: " & myConnection.ConnectionString)
                'Try/catch/finally is code  structure which facilitates the hnadling of execeptions that may occur in the program

                myConnection.Open()
                'open connection to access

                iCountRows = dgvImport.Rows.Count - 2
                iCounter = 0
                'Variables that will count through data grid view untill end of grid

                For iCounter = 0 To iCountRows
                    prgrssImportScreen.Increment(1)

                    sSecurityCode = dgvImport.Rows(iCounter).Cells(0).Value
                    sSecurityDate = dgvImport.Rows(iCounter).Cells(1).Value
                    sOpeningPrice = dgvImport.Rows(iCounter).Cells(2).Value
                    sHighSalePrice = dgvImport.Rows(iCounter).Cells(3).Value
                    sLowSalePrice = dgvImport.Rows(iCounter).Cells(4).Value
                    sClosingPrice = dgvImport.Rows(iCounter).Cells(5).Value
                    sTotalVolume = dgvImport.Rows(iCounter).Cells(6).Value
                    'Count through one row and store in temporary variable

                    dtSecurityDate = CDate(sSecurityDate)
                    dblOpeningPrice = CDbl(sOpeningPrice)
                    dblHighSalePrice = CDbl(sHighSalePrice)
                    dblLowSalePrice = CDbl(sLowSalePrice)
                    dblClosingPrice = CDbl(sClosingPrice)
                    iTotalVolume = CInt(sTotalVolume)
                    'Convert temporary data to correct format for Access

                    sqlQuery = "INSERT INTO Daily_Stock_Prices (security_code, security_date, opening_price, high_sale_price, low_sale_price, closing_price, total_volume) VALUES (?, ?, ?, ?, ?, ?, ?)"
                    Using cmd As New OleDbCommand(sqlQuery, myConnection)
                        cmd.Parameters.AddWithValue("?", sSecurityCode)
                        cmd.Parameters.AddWithValue("?", dtSecurityDate)
                        cmd.Parameters.AddWithValue("?", dblOpeningPrice)
                        cmd.Parameters.AddWithValue("?", dblHighSalePrice)
                        cmd.Parameters.AddWithValue("?", dblLowSalePrice)
                        cmd.Parameters.AddWithValue("?", dblClosingPrice)
                        cmd.Parameters.AddWithValue("?", iTotalVolume)

                        'SQL statement which inserts Access tables(on left) with Variables(on right)
                        cmd.ExecuteNonQuery()
                    End Using
                Next
                'loop till end of data grid

                prgrssImportScreen.Increment(12000)
                prgrssImportScreen.Hide()
                prgrssImportScreen.Value = 0
                'Once import complete add max value to show completed loading. Then hide bar and reset value to start.

                dspStatus.Text = "Import successful!"
                'Display import successfull in text box otherwise display errors outlined below

            Catch ex As OleDb.OleDbException
                dspStatus.Text = MsgBoxStyle.Critical & "Database Error"
            Catch ex As Exception
                dspStatus.Text = MsgBoxStyle.Critical & "General Error"
            Finally
                myConnection.Close()
            End Try

            'dgvImport.Rows.Clear() 'this is broken, not sure why
        Else
            MsgBox("Importing has been aborted", , "Abort") ' Shows message box that the import was aborted
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Daily_Stock_PricesTableAdapter.Fill(Me.ASXShareMarketAnalysisToolDataSet2.Daily_Stock_Prices)                                   ' Might remove datasets soon
        Dim MyChar() As Char = {"b", "i", "n", "\", "D", "e", "b", "u", "g"}                                                               ' Not to sure (Elaborate Matt?)
        Dim path As String = Environment.CurrentDirectory                                                                                  ' Grabs the current directory
        Dim newpath As String = path.TrimEnd(MyChar)                                                                                       ' Trims something 
        Dim connectionstring As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & newpath & "\ASXShareMarketAnalysisTool.accdb" ' Maps out the database location
        Dim dtTable As New DataTable()                                                                                                     ' Declares a new datatable
        Dim sQuery As String = "SELECT * FROM Daily_Stock_Prices order by security_code ASC, security_date DESC"                           ' Builds the Query for the database

        Using con = New OleDbConnection(connectionstring) ' Opens the connection to the database
            Using da = New OleDbDataAdapter(sQuery, con)  ' Runs the Query
                da.Fill(dtTable)                          ' Fills the data into a datatable
                dgvAllStocks.DataSource = dtTable         ' Binds the datatable to the DGV
                'Might be worth binding to ALL DGVs to remove datasets
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'this is a test button that calls the complex algorithms required to display data
        dspAllStockStatus.Text = "Begin Filtering" ' Not working, occuring too slow?

        'Show loading bar and waiting cursor
        Cursor.Current = Cursors.WaitCursor
        prgrssAllStocks.Visible = True
        prgrssAllStocks.Maximum = 5000
        prgrssAllStocks.Increment(500)

        LoopData()                                 ' Does all the calculations

        '////////////////////////////////////////////////////////////////////////////
        prgrssAllStocks.Visible = False
        dspAllStockStatus.Text = "Filtering Completed!"
    End Sub

    Private Sub LoopData()
        Dim iRowCnt As Integer = 0        ' Total Row counter
        Dim iCnt As Integer = 0           ' Loop counter
        iRowCnt = dgvAllStocks.RowCount() ' Setting the Total row counter to the amount of rows in the DGV
        Dim htAverage As New Hashtable    ' Hashtable to save the Average of each Stock
        Dim dblTotalVolume As Double = 0  ' Total Volume (accrued in the loop)
        Dim dblAverage As Double = 0      ' Average (totalVolume/ 30records or equivalent)
        Dim iAverageCount As Integer = 0  ' The count of records processes
        Dim dtCriteriaTable As New DataTable()

        prgrssAllStocks.Increment(500)

        '*********************************************************************************
        'Calculate the 30 record average
        '*********************************************************************************
        For iCnt = 0 To iRowCnt - 1                                               ' iRowCnt -1 (needs to be 1 less coz we count from row 0)
            Dim iPrev As Integer = iCnt - 1                                       ' Grabs the next row data to compare, needed to check if security codes match
            Dim sSecurityCode1 As String = dgvAllStocks.Rows(iCnt).Cells(2).Value ' Grabs the current security code



            'Loops through finding the 30 day average per stock code
            If iPrev = -1 Then                                                           ' handles the very first stock code
                dblTotalVolume = dblTotalVolume + dgvAllStocks.Rows(iCnt).Cells(8).Value ' the first stock code will not have a previous value
            Else
                If iPrev < iRowCnt Then                                                    ' Makes sure the previous is less than the row count and greater than -1
                    Dim sSecurityCode2 As String = dgvAllStocks.Rows(iPrev).Cells(2).Value ' Previous security code, to check that it is the same as the current security code

                    If sSecurityCode2 = sSecurityCode1 Then ' Check if the security code matches the previous security code and its less than 30 records used
                        If iAverageCount <= 30 Then         ' Stops calculating once the iAverageCount has exceeded 30 records
                            dblTotalVolume = dblTotalVolume + dgvAllStocks.Rows(iCnt).Cells(8).Value ' Add the current Volume to the Total Accrued
                            iAverageCount = iAverageCount + 1                                        ' Increases the Denominator by 1 
                        End If
                    Else                                                                                         ' Saves the data and moves on to the next security code
                        dblAverage = dblTotalVolume / iAverageCount                                              ' Does the final calculation

                        'Maybe incorporate a TRY CATCH statement here so it doesn't crash
                        If Not IsNothing(sSecurityCode2) And Not IsNothing(dblAverage) And dblAverage <> 0 Then  ' Makes sure there is a security code and an Average AND Average is not 0
                            htAverage.Add(sSecurityCode2, dblAverage)                                            ' Adds the data into a hashtable with the security code(2) as the key
                        End If                                                                                   ' IT MUST BE sSecurityCode2 AS IT IS THE PREVIOUS CODE!!

                        dblTotalVolume = 0                                      ' Resetting the Total Volume accrued
                        dblTotalVolume = dgvAllStocks.Rows(iCnt).Cells(8).Value ' Starts at the new security code
                        iAverageCount = 1                                       ' Resetting the Average count to 1 since its a new code
                    End If
                End If
            End If
        Next
        prgrssAllStocks.Increment(1000)

        '//////////////////////////////////////////////////////////////////////////////////////////////////////////
        'ONLY NEEDED FOR DEBUGGING / LEAVE IT FOR NOW AS A REFERENCE ON HOW TO USE THE HASHTABLE
        Dim MyKeys As ICollection
        Dim key As Object

        MyKeys = htAverage.Keys() ' Declares the keys from the hashtable into the collection

        'The following For Loop Is Not necessary, just there for debugging purposes
        For Each key In MyKeys                                          ' Loops through each key in the MyKeys collection (hashtable keys)
            '    Debug.Print(key.ToString & " - " & htAverage(key).ToString) ' Prints out the key name and the respective value (comment this out BUT DO NOT DELETE, NEED IT FOR REFERENCE)
        Next
        prgrssAllStocks.Increment(1000)
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////

        '**********************************************************************************
        ' Loop to find Primary Keys that have a High price greater than Previous High
        ' ---
        ' This is slow...
        '*********************************************************************************
        iCnt = 0 ' Redefines iCnt for the next loop
        Dim sHighMatchIDs As String = ""        ' Saves all the Primary Keys for the High Price calculation
        Dim sCloseMatchIDs As String = ""       ' Saves all the Primary Keys for the Close Price calculation
        Dim sVolumeMatchIDs As String = ""      ' Saves all the Primary Keys for the Volume calculation
        Dim bMatched As Boolean = False
        Dim iAdd As Integer = 0

        dtCriteriaTable.Columns.Add("Record")
        dtCriteriaTable.Columns.Add("Stock ID")
        dtCriteriaTable.Columns.Add("Security Code")
        dtCriteriaTable.Columns.Add("Date")
        dtCriteriaTable.Columns.Add("Open")
        dtCriteriaTable.Columns.Add("High")
        dtCriteriaTable.Columns.Add("Low")
        dtCriteriaTable.Columns.Add("Close")
        dtCriteriaTable.Columns.Add("Volume")

        Dim LatestDate As Date = dgvAllStocks.Rows(0).Cells(3).Value
        For iCnt = 0 To iRowCnt - 1                                               ' (iRowCnt - 1) since DGV rows start at count = 0
            Dim iNext As Integer = iCnt + 1                                       ' Find the next record for comparison reasons
            Dim sSecurityCode1 As String = dgvAllStocks.Rows(iCnt).Cells(2).Value ' Current security code
            Dim dblHigh1 As Double = dgvAllStocks.Rows(iCnt).Cells(5).Value       ' High price of current security code
            Dim dblClose1 As Double = dgvAllStocks.Rows(iCnt).Cells(7).Value      ' Close price of current security code
            Dim dblVolume As Double = dgvAllStocks.Rows(iCnt).Cells(8).Value      ' Volume of current security code
            Dim DR As DataRow = dtCriteriaTable.NewRow
            Dim RowDate As Date = dgvAllStocks.Rows(iCnt).Cells(3).Value

            If RowDate = LatestDate Then
                If iNext < iRowCnt Then                                                    ' Make sure that there is a next row in the DGV
                    Dim sSecurityCode2 As String = dgvAllStocks.Rows(iNext).Cells(2).Value ' Security code of the next row
                    Dim dblHigh2 As Double = dgvAllStocks.Rows(iNext).Cells(5).Value       ' High Price of the next row (sorted in descending order)
                    Dim dblClose2 As Double = dgvAllStocks.Rows(iNext).Cells(7).Value      ' Close Price of the next row (sorted in descending order)
                    ' High Price > Previous High AND Close Price > Previous Close calculations here
                    If sSecurityCode2 = sSecurityCode1 Then                                                  ' compares the security codes first
                        If dblHigh1 > dblHigh2 Then                                                          ' compares the High Prices
                            If dblClose1 > dblClose2 Then                                                    ' compares the High Prices
                                bMatched = True
                            End If
                        End If
                    End If
                Else
                    If bMatched Then
                        DR("Record") = dgvAllStocks.Rows(iCnt).Cells(0).Value
                        DR("Stock ID") = dgvAllStocks.Rows(iCnt).Cells(1).Value
                        DR("Security Code") = dgvAllStocks.Rows(iCnt).Cells(2).Value
                        DR("Date") = dgvAllStocks.Rows(iCnt).Cells(3).Value
                        DR("Open") = dgvAllStocks.Rows(iCnt).Cells(4).Value
                        DR("High") = dgvAllStocks.Rows(iCnt).Cells(5).Value
                        DR("Low") = dgvAllStocks.Rows(iCnt).Cells(6).Value
                        DR("Close") = dgvAllStocks.Rows(iCnt).Cells(7).Value
                        DR("Volume") = dgvAllStocks.Rows(iCnt).Cells(8).Value

                        dtCriteriaTable.Rows.Add(DR)
                        bMatched = False
                    End If
                End If
            End If
        Next

        '*********************************************************************************
        ' Need to somehow count the "|" in each sResult and create a loop
        ' Need to FIELD("|") through the IDs found and compile them to a list or something
        ' Maybe need to do the over 5/10 days thingo aswell
        '*********************************************************************************
        prgrssAllStocks.Increment(1000)
        '*********************************************************************************
        ' Need to somehow count the "|" in each sResult and create a loop
        ' Need to FIELD("|") through the IDs found and compile them to a list or something
        ' Maybe need to do the over 5/10 days thingo aswell
        '*********************************************************************************

        dgvHistory.DataSource = dtCriteriaTable

        prgrssAllStocks.Increment(1000)

    End Sub
End Class



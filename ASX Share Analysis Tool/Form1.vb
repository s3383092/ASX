Imports System
Imports System.IO
Imports System.Data.OleDb
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient

Public Class Form1

    Public sTargetDate As String = "15/07/2016" 'DEBUGGING PURPOSES ONLY, THIS SHOULD BE REMOVED AND DONE BETTER

    Private Sub btnFile_Click(sender As Object, e As EventArgs) Handles btnImportFile.Click 'Handle importing data
        Dim OpenFileDialog1 As New OpenFileDialog()
        Dim FileType As String
        Dim dtImport As New DataTable
        Dim FileCounter As Integer = 0
        'Opens the Open File explorer dialog
        OpenFileDialog1.Title = "Please Select a File"
        'OpenFileDialog1.InitialDirectory = "C:\Users\Downloads" 'Default file location
        OpenFileDialog1.Multiselect = True 'Enable multiselect to import multiple file types

        'Handles opening the file
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim file As String
            For Each file In OpenFileDialog1.FileNames
                Try
                    '  Dim TextFileReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(OpenFileDialog1.FileName)
                    Dim TextFileReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(file)
                    Dim CurrentRow As String()
                    Debug.Print(file)
                    TextFileReader.TextFieldType = FileIO.FieldType.Delimited
                    TextFileReader.SetDelimiters(",")
                    FileType = Path.GetExtension(OpenFileDialog1.FileName)

                    dspFileLocation.Text = OpenFileDialog1.FileName

                    Dim sInsightTrader As String = "InsightTrader"
                    Dim TestPos As Integer = 0

                    TestPos = InStr(1, OpenFileDialog1.FileName, sInsightTrader, CompareMethod.Text) 'Checks if the user has chosen an Insight Trader file type

                    ' Changes a delimiter type to a space, because InsightTrader is a stupid file type
                    If TestPos <> 0 Then
                        TextFileReader.SetDelimiters(" ")
                    End If

                    'Call ClearDGVImport() ' will be necessary if he chooses the wrong file before, and then chooses one again

                    If FileType = ".txt" Then
                        'Handles importing a .txt file
                        'Adding the column names
                        dgvImport.Columns.Add("ID", "Security Code")
                        dgvImport.Columns.Add("Date", "Date")
                        dgvImport.Columns.Add("Open", "Opening Price")
                        dgvImport.Columns.Add("High", "High Sale price")
                        dgvImport.Columns.Add("Low", "Low Sale Price")
                        dgvImport.Columns.Add("Close", "Closing Price")
                        dgvImport.Columns.Add("Volume", "Total Volume Traded")

                        'Loops through the data and imports it into a table
                        While Not TextFileReader.EndOfData
                            Try
                                CurrentRow = TextFileReader.ReadFields() 'Declares the Row to be added
                                dgvImport.Rows.Add(CurrentRow) 'Adds the data in
                            Catch ex As _
                        Microsoft.VisualBasic.FileIO.MalformedLineException
                                MsgBox("Line " & ex.Message &
                            "Is Not valid And will be skipped.")
                            End Try
                        End While
                        TextFileReader.Dispose() 'Removes TextFileReader for next time

                    ElseIf FileType = ".csv" Then
                        'handles importing a .csv file
                        Dim sr As New IO.StreamReader(file)
                        '  Dim dtImport As New DataTable

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

    End Sub
    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim Response = MsgBox("Are you sure you want to import this into the database?", vbYesNo, "Please confirm importing")
        If Response = MsgBoxResult.Yes Then
            'Show loading cursor and please wait
            lblPleaseWait.Show()
            Cursor.Current = Cursors.WaitCursor

            Dim MyChar() As Char = {"b", "i", "n", "\", "D", "e", "b", "u", "g"}
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
                dspStatus.Text = "Import successful!"
                'Display import successfull in text box otherwise display errors outlined below

            Catch ex As OleDb.OleDbException
                dspStatus.Text = MsgBoxStyle.Critical & "Oledb Error"
            Catch ex As Exception
                dspStatus.Text = MsgBoxStyle.Critical & "General Error"
            Finally
                myConnection.Close()
            End Try

            lblPleaseWait.Hide() ' Once import is complete hide "please wait"
            'dgvImport.Rows.Clear() 'this is broken, not sure why
        Else
            MsgBox("Importing has been aborted",, "Abort") ' Shows message box that the import was aborted
        End If

        ' Might need to call ClearDGVImport() here
        ' CleaDGVImport() ' This will clear even if the import was not done (may or may not need to be looked at)
    End Sub

    Private Sub ClearDGVImport()
        ' Clears the Import DataGridView (Not sure if this is being used
        dgvImport.Rows.Clear()
        dgvImport.Columns.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Daily_Stock_PricesTableAdapter.Fill(Me.ASXShareMarketAnalysisToolDataSet2.Daily_Stock_Prices)                                   ' Might remove datasets soon
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
        LoopData()
    End Sub

    Private Sub LoopData()
        Dim iRowCnt As Integer = 0        ' Total Row counter
        Dim iCnt As Integer = 0           ' Loop counter
        Dim sResult As String = ""        ' Results being outputted (testing purposes only)
        iRowCnt = dgvAllStocks.RowCount() ' Setting the Total row counter to the amount of rows in the DGV
        Dim bNewCode As Boolean = 1       ' New code flag, needed to reset the 30 record average
        Dim htAverage As New Hashtable
        Dim dblTotalVolume As Double = 0  ' Total Volume (accrued in the loop)
        Dim dblAverage As Double = 0      ' Average (totalVolume/ 30records or equivalent)
        Dim iAverageCount As Integer = 0                                      ' The count of records (would be 30, unless there isn't 30 records)

        'Calculate the 30 record average
        For iCnt = 0 To iRowCnt
            Dim iPrev As Integer = iCnt - 1                                       ' Grabs the next row data to compare, needed to check if security codes match
            Dim sSecurityCode1 As String = dgvAllStocks.Rows(iCnt).Cells(2).Value ' Grabs the current security code

            Dim iLastRecord As Integer = 0                                        ' The current row count + 30 (max records to be read)

            'Loops through finding the 30 day average per stock code
            If iPrev < iRowCnt And iPrev <> -1 Then
                Dim sSecurityCode2 As String = dgvAllStocks.Rows(iPrev).Cells(2).Value ' Previous security code, to check that it is the same as the current security code

                'Caters for a change in stock_code
                If bNewCode = True Then
                    iLastRecord = iCnt + 30 ' 30 records from the time the new code is discovered
                    iAverageCount = 0       ' Resetting the Average count
                    dblTotalVolume = 0      ' Resetting the Total Volume accrued / need to add previous Volume traded here, then figure out a way to deal with the very first security code
                    bNewCode = 0            ' Setting the new code to False
                End If

                'Makes sure the security codes are the same or else it will do the averaging calculations and reset
                If sSecurityCode2 = sSecurityCode1 Then                                          ' Check if the security code matches the previous security code
                    If iCnt < iLastRecord Then
                        dblTotalVolume = dblTotalVolume + dgvAllStocks.Rows(iCnt).Cells(8).Value ' Add the current Volume to the Total Accrued
                        iAverageCount = iAverageCount + 1                                        ' Increases the Denominator by 1 
                    End If
                Else
                    dblAverage = dblTotalVolume / iAverageCount ' Does the final calculation
                    bNewCode = 1                                ' Resets all the important flags
                    ' Will need to handle what happens when the security code changes (there is no calculation for the first security code (after change)
                    ' need to save data to a hash table security_code | dblAverage|
                    ' if iAverageCount = 30 then we need to do something
                    ' May need to handle iAverageCount = 0 (cant divide by 0)
                    If Not IsNothing(sSecurityCode1) And Not IsNothing(dblAverage) Then
                        htAverage.Add(sSecurityCode1, dblAverage)
                    End If
                End If
                End If
        Next

        Dim MyKeys As ICollection
        Dim key As Object

        MyKeys = htAverage.Keys()

        For Each key In MyKeys
            Debug.Print(key.ToString)
        Next

        'For iCnt = 0 To iRowCnt
        '    Dim iNext As Integer = iCnt + 1                                       ' Find the next record for comparison reasons
        '    Dim sSecurityCode1 As String = dgvAllStocks.Rows(iCnt).Cells(2).Value ' Current security code
        '    Dim dblHigh1 As Double = dgvAllStocks.Rows(iCnt).Cells(5).Value       ' High price of current security code

        '    'Make sure that there is a next row in the DGV
        '    If iNext < iRowCnt Then
        '        Dim sSecurityCode2 As String = dgvAllStocks.Rows(iNext).Cells(2).Value ' Security code of the next row
        '        Dim dblHigh2 As Double = dgvAllStocks.Rows(iNext).Cells(5).Value       ' High Price of the next row (sorted in descending order)

        '        ' Does the High Price > Previous High calculations here
        '        If sSecurityCode2 = sSecurityCode1 Then                                             ' compares the security codes first
        '            If dblHigh1 > dblHigh2 Then                                                     ' compares the High Prices
        '                sResult = sResult & dgvAllStocks.Rows(iCnt).Cells(2).Value & " " & dblHigh1 ' Outputting for debugging reasons (can be deleted later on)
        '                ' Need to save the Primary key here so we can use it later
        '            End If
        '        End If
        '    End If
        'Next
        'Debug.Print(sResult) 'Debugging

    End Sub

End Class


